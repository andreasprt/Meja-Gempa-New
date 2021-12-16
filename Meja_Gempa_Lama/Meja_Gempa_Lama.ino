#include <MurryLGAlib.h>

int LED = 13;

Stepper motor_1(4, 5);   //STEP pin =  4, DIR pin = 5
Stepper motor_2(2, 3);  //STEP pin =  2, DIR pin = 3

StepControl controller;
StepControl controller2;


String dataIn;
String dt[10];
unsigned int i;
boolean parsing = false;
int dtTampung[5000];
int dtTampungX[5000];
int dtTampungY[5000];
String masukan = dt[1];

int u , ubaru = 0;
boolean tampung = false;
boolean X = false;
boolean Y = false;

int jumlahDataTampung = 0;

void setup()
{

  Serial.begin(9600);
  dataIn = "";
  // setup the motors
  motor_1
  .setMaxSpeed(65000)       // steps/s
  .setAcceleration(1000000); // steps/s^2
  motor_2
  .setMaxSpeed(65000)       // steps/s
  .setAcceleration(1000000); // steps/s^2

  motor_2.setTargetRel(1000);
  controller.move(motor_2);
}

void perintah() {

  if (dt[1] == "a") {
    Serial.println("kiri");
    motor_1.setTargetRel(dt[2].toInt());
    controller.move(motor_1);
  }
  else if (dt[1] == "d") {
    Serial.println("kanan");
    motor_1.setTargetRel(-dt[2].toInt());
    controller.move(motor_1);
  }
  else if (dt[1] == "w") {
    Serial.println("atas");
    motor_2.setTargetRel(dt[2].toInt());
    controller.move(motor_2); //Sinkron
  }
  else if (dt[1] == "s") {
    Serial.println("bawah");
    motor_2.setTargetRel(-dt[2].toInt());
    controller.move(motor_2);
  }
  else if (dt[1] == "p") {
    for (int i = 0 ; i < 5000; i++) {
      Serial.print("tampung data");
      Serial.print(dtTampungX[i]);
      Serial.print("\n");
    }
  }

  else if (dt[1] == "m") {
    motor_1.setMaxSpeed(dt[2].toInt()) ;      // steps/s
    motor_2.setMaxSpeed(dt[2].toInt());       // steps/s
  }
  else if (dt[1] == "n") {
    motor_1.setAcceleration(dt[2].toInt());       // steps/s/s
    motor_2.setAcceleration(dt[2].toInt());      // steps/s/s
  }
  else if (dt[1] == "x") {
    Serial.println("x");
    //    for (int i = 0 ; i < 5000; i++) {
    //      Serial.print("tampung data");
    //      Serial.print(dtTampung[i]);
    //      Serial.print("\n");
    //    }
    //    while (u <= 2001) {
    while (u <= jumlahDataTampung) { //jumlahDataTampung
      if (u <= jumlahDataTampung) {
        motor_1.setTargetRel(1 * dtTampung[u]); //1 * dtTampung[u])
        motor_2.setTargetRel(100);
        controller.move(motor_1, motor_2);
      }
      else {
        controller.stop();

      }
      if (u - ubaru == 100) {
        Serial.println(u);
        ubaru = u;
      }
      u++;
    }
    u = ubaru = 0;
    Serial.println("data Complit");
  }
}


void loop()
{

  while (Serial.available() > 0) {
    // data = Serial.read();
    char inChar = (char)Serial.read();
    dataIn += inChar;
    if (inChar == '\n') {
      parsing = true;
    }
  }
  if (parsing)
  {
    parsingData();
    parsing = false;
    dataIn = "";
  }
  perintah();
  if (dt[1] == "*") {
    Serial.print("Tampung True");
    tampung = true;
    dt[1] = "";
    jumlahDataTampung = 0;
  }
  else if (dt[1] == "#" || jumlahDataTampung > 5000) {
    tampung = false;
    Serial.print("Tampung False");
    // cek  data masuk
    //    for (int i = 0; i < jumlahDataTampung; i++) {
    //      Serial.print("data Ke ");
    //      Serial.print(i);
    //      Serial.print(" = ");
    //      Serial.println(dtTampung[i]);
    //    }
  }

  dt[1] = "";


}
void parsingData()
{
  int j = 0;
  //kirim data yang telah diterima sebelumnya
  Serial.print("data masuk : ");
  Serial.print(dataIn);
  Serial.print("\n");
  //inisialisasi variabel, (reset isi variabel)
  dt[j] = "";
  //proses parsing data
  for (i = 0; i < dataIn.length(); i++)
  {
    //pengecekan tiap karakter dengan karakter (#) dan (,)
    if ((dataIn[i] == '{') || (dataIn[i] == ',') || (dataIn[i] == '}'))
    {
      //increment variabel j, digunakan untuk merubah index array penampung
      j++;
      dt[j] = ""; //inisialisasi variabel array dt[j]
    }
    else
    {
      //proses tampung data saat pengecekan karakter selesai.
      dt[j] = dt[j] + dataIn[i];
    }
  }
  if (tampung) {
    dtTampung[jumlahDataTampung] = dt[1].toInt();
    jumlahDataTampung++;
  }

}

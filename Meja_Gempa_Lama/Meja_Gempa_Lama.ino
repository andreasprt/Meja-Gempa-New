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
    while (u <= 2001) {
      if (u <= 2001) {
        motor_1.setTargetRel(1 * dtTampungX[u]);
        motor_2.setTargetRel(1 * 1);
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

  if (Serial.available() > 0) {
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
  dt[1] = "";

}
void parsingData()
{
  int j = 0;
  String dtBuffer;
  //kirim data yang telah diterima sebelumnya
  Serial.print("data masuk : ");
  Serial.print(dataIn);
  Serial.print("\n");
  //inisialisasi variabel, (reset isi variabel)
  dt[j] = "";
  dtBuffer = "";
  int a = 0;
  //proses parsing data
  for (i = 0; i < dataIn.length(); i++)
  {
    //pengecekan tiap karakter dengan karakter (#) dan (,)
    if ((dataIn[i] == '{') || (dataIn[i] == ',') || (dataIn[i] == '}'))
    {
      //increment variabel j, digunakan untuk merubah index array penampung
      j++;
      Serial.println(dtBuffer);
      dtTampung[j] = dtBuffer.toInt();
      dtBuffer = "";
      Serial.println(dtBuffer);
      if (a < 11) {
        dt[j] = ""; //inisialisasi variabel array dt[j]
      }
    }
    else
    {
      //proses tampung data saat pengecekan karakter selesai.
      dtBuffer += dataIn[i];
      if (a < 11) {
        dt[j] = dt[j] + dataIn[i];
      }
      //
    }
  }
  //kirim data hasil parsing
  if (dt[1] == "x") {
    Serial.println("Tunggu menammpung data");
    for (int i = 0 ; i < 5000; i++) {
      //Serial.print("tampung data");
      //Serial.print(dt[i].toInt());
      //Serial.print("\n");
      dtTampungX[i] = dtTampung[i];
    }
    Serial.println("Tampung data Selesai");
  }
}

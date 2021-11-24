#include <MurryLGAlib.h>

int LED = 13;

Stepper motor_1(20, 21);   //STEP pin =  4, DIR pin = 5
Stepper motor_2(16, 17);  //STEP pin =  2, DIR pin = 3

StepControl controller;
StepControl controller2;
char data;
int in1, in2, in3;
int l = 5000;


String dataIn;
String dt[5000];
int i;
boolean parsing = false;
int dtTampung[5000];

void setup()
{
  // pinMode(LED, OUTPUT);
  pinMode(1, INPUT);
  pinMode(2, INPUT);
  pinMode(3, INPUT);

  Serial.begin(9600);
  dataIn = "";
  // setup the motors
  motor_1
  .setMaxSpeed(45670)       // steps/s
  .setAcceleration(1000000); // steps/s^2
  motor_2
  .setMaxSpeed(45670)       // steps/s
  .setAcceleration(1000000); // steps/s^2
}

void perintah() {
  if (data == 'a') {
    motor_1.setTargetRel(l);
    controller.move(motor_1);
  }
  else if (data == 'd') {
    motor_1.setTargetRel(-l);
    controller.move(motor_1);
  }
  else if (data == 'w') {
    motor_2.setTargetRel(l);
    controller.move(motor_2);
  }
  else if (data == 's') {
    motor_2.setTargetRel(-l);
    controller.move(motor_2);
  }
  else if (data == 'l') {
    l = Serial.parseInt();
  }
  else if (data == 'm') {
    int speedMotor = Serial.parseInt();
    motor_1.setMaxSpeed(speedMotor) ;      // steps/s
    motor_2.setMaxSpeed(speedMotor);       // steps/s
  }
  else if (data == 'n') {
    int accMotor = Serial.parseInt();
    motor_1.setAcceleration(accMotor);       // steps/s/s
    motor_2.setAcceleration(accMotor);      // steps/s/s

  }
}

void loop()
{
  in1 = digitalRead(1);
  in2 = digitalRead(2);
  in3 = digitalRead(3);
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
  if (in1 == 0)
  {
    motor_1.setTargetRel(5000);
    motor_2.setTargetRel(-5000);
    controller.move(motor_1, motor_2);
  }

  if (in2 == 0)
  {
    motor_1.setTargetRel(-5000);
    motor_2.setTargetRel(5000);
    controller.move(motor_1, motor_2);
  }


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
  //kirim data hasil parsing
  if (dt[1] == "x") {
    for (int i = 2 ; i < 5001; i++) {
      Serial.print("tampung data");
      //Serial.print(dt[i].toInt());
      //Serial.print("\n");
      dtTampung[i] = dt[i].toInt();
    }
  }
}

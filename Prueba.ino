#include <Servo.h>


Servo leg1;
Servo leg2;
Servo leg3;
Servo leg4;       //Declaracion de los servos
Servo leg5;
Servo leg6;
Servo leg7;
Servo leg8;

int Nbp1=50;
int Nbp2= 0;
int Ibp1= 130;
int Ibp2= 180;
int Npp1= 60;
int Npp2 = 30;
int Ipp1 = 120;
int Ipp2= 150;
void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);    // inicia el puerto serial para comunicacion con el Bluetooth
   leg1.attach(2);
   leg2.attach(3);
   leg3.attach(4);
   leg4.attach(5);          //Asigna pin a los servos
   leg5.attach(6);
   leg6.attach(7);
   leg7.attach(8);
   leg8.attach(9);

 
}

void loop() {
  leg5.write(Npp2);
leg8.write(Npp2);
leg1.write(Nbp2);
leg4.write(Nbp2);
leg2.write(Ibp1);
leg3.write(Ibp1);

leg5.write(Npp1);
leg8.write(Npp1);
delay(500);
leg6.write(Ipp2);
leg7.write(Ipp2);
leg2.write(Ibp2);
leg3.write(Ibp2);
leg1.write(Nbp1);
leg4.write(Nbp1);
leg6.write(Ipp1);
leg7.write(Ipp1);
delay(500); 


}


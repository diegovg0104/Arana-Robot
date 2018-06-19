#include <Servo.h>

int estado = 'g';
Servo leg1;
Servo leg2;
Servo leg3;
Servo leg4;       //Declaracion de los servos
Servo leg5;
Servo leg6;
Servo leg7;
Servo leg8;

const int pinecho = 11;
const int pintrigger = 10;

unsigned int tiempo, distancia;    //Declaracion de el sensor ultrasonico


int Nbp1=30;
int Nbp2 =90; //Normal base posisicon (n)
int Nbp3 = 0;

int Ibp1= 100;
int Ibp2= 40;  //Invertido base psicion (n)
int Ibp3= 160;

int Npp1= 70;
int Npp2=50;   //Normal pata posisicon (n)
int Npp3=30;

int Ipp1 = 100;
int Ipp2 = 120; //Invertido pata psicion (n)
int Ipp3 = 150;
  
void setup()  { 
  Serial.begin(9600);    // inicia el puerto serial para comunicacion con el Bluetooth
   leg1.attach(2);
   leg2.attach(3);
   leg3.attach(4);
   leg4.attach(5);          //Asigna pin a los servos
   leg5.attach(6);
   leg6.attach(7);
   leg7.attach(8);
   leg8.attach(9);
 
  leg1.write(Nbp3);
  leg5.write(Npp1);
  leg2.write(Ibp1);
  leg6.write(Ipp1);
  leg3.write(Ibp1);
  leg7.write(Ipp1);
  leg4.write(Nbp1);
  leg8.write(Npp1);
    
  pinMode(pinecho, INPUT);
  pinMode(pintrigger, OUTPUT);             
    
 } 
 
void loop()  { 
  
  if(Serial.available()>0){        // lee el bluetooth y almacena en estado
      estado = Serial.read();
  }

  if (estado =='f'){          // Boton ON se mueve sensando distancia 
    mauto();
  }
  if (estado != 'f'){
    //Intrucciones control remoto
     if(Serial.available()>0){        // lee el bluetooth y almacena en estado
      estado = Serial.read();
     }
      if  (estado == 'a'){
        Adel();
      }
      if (estado == 'b'){
        Atras();
      }
      if (estado == 'c'){
        izq();
      }
      if (estado == 'd'){
        der();
      }
      if (estado == 'e'){
        gir_izq();
      }
      if (estado == 'h'){
        gir_der();
      }
      if (estado == 'i'){
        subir();
      }
      if (estado == 'j'){
        bajar();
      }
      if (estado == 'k'){
	saludar();
      }
      if  (estado=='g'){          
    //Instrucciones de no hacer nada

         
         
         
         
         
         
         Neutral(); 
         
         
    
                }
          
    } 
}

void Neutral() {
leg6.write(Ipp1);
leg7.write(Ipp1);
leg5.write(Npp1);
leg8.write(Npp1);
leg1.write(Nbp1);
leg4.write(Nbp1);
leg2.write(Ibp1);
leg3.write(Ibp1);
}

void Adel() {
leg5.write(Npp1);
leg1.write(Nbp1);
leg8.write(Npp1);
delay(500);
leg6.write(Ipp2);
leg7.write(Ipp2);
delay(500);
leg2.write(Ibp3);
leg3.write(Ibp2);
leg4.write(Nbp3);
leg1.write(Nbp2);
delay(500);
leg6.write(Ipp1);
leg7.write(Ipp1);
delay(500);
leg5.write(Npp2);
leg8.write(Npp2);
delay(500);
leg1.write(Nbp1);
leg4.write(Nbp2);
leg2.write(Ibp2);
leg3.write(Ibp1);
delay(500);
}

void Atras() {
leg8.write(Npp1);
leg4.write(Nbp1);
leg5.write(Npp1);
delay(500);
leg6.write(Ipp2);
leg7.write(Ipp2);
delay(500);
leg2.write(Ibp2);
leg3.write(Ibp3);
leg4.write(Nbp2);
leg1.write(Nbp3);
delay(500);
leg6.write(Ipp1);
leg7.write(Ipp1);
delay(500);
leg5.write(Npp2);
leg8.write(Npp2);
delay(500);
leg1.write(Nbp2);
leg4.write(Nbp3);
leg2.write(Ibp3);
leg3.write(Ibp2);
delay(500);

}

void der() {
leg5.write(Npp2);
leg8.write(Npp2);
delay(500);
leg1.write(Nbp3);
leg4.write(Nbp2);
leg2.write(Ibp3);
leg3.write(Ibp2);
delay(500);
leg5.write(Npp1);
leg8.write(Npp1);
delay(500);
leg6.write(Ipp2);
leg7.write(Ipp2);
delay(500);
leg2.write(Ibp2);
leg3.write(Ibp3);
leg1.write(Nbp2);
leg4.write(Nbp3);
delay(500);
leg6.write(Ipp1);
leg7.write(Ipp1);
delay(500);
}

void izq() {
leg5.write(Npp2);
leg8.write(Npp2);
delay(500);
leg1.write(Nbp2);
leg4.write(Nbp3);
leg2.write(Ibp2);
leg3.write(Ibp3);
delay(500);
leg5.write(Npp1);
leg8.write(Npp1);
delay(500);
leg6.write(Ipp2);
leg7.write(Ipp2);
delay(500);
leg2.write(Ibp3);
leg3.write(Ibp2);
leg1.write(Nbp3);
leg4.write(Nbp2);
delay(500);
leg6.write(Ipp1);
leg7.write(Ipp1);
delay(500);
}

void gir_der() {
 leg1.write(Nbp1);
leg5.write(Npp1);
leg2.write(Ibp1);
leg6.write(Ipp1);
leg3.write(Ibp1);
leg7.write(Ipp1);
leg4.write(Nbp1);
leg8.write(Npp1);
delay(500);
leg5.write(Npp2);
delay(500);
leg1.write(Nbp3);
delay(500);
leg5.write(Npp1);
delay(500);
leg6.write(Ipp2);
delay(500);
leg2.write(Ibp2);
delay(500);
leg6.write(Ipp1);
delay(500);
leg8.write(Npp2);
delay(500);
leg4.write(Nbp3);
delay(500);
leg8.write(Npp1);
delay(500);
leg7.write(Ipp2);
delay(500);
leg3.write(Ibp2);
delay(500);
leg7.write(Ipp1);
delay(500);
}

void gir_izq() {
leg1.write(Nbp1);
leg5.write(Npp1);
leg2.write(Ibp1);
leg6.write(Ipp1);
leg3.write(Ibp1);
leg7.write(Ipp1);
leg4.write(Nbp1);
leg8.write(Npp1);
delay(500);
leg5.write(Npp2);
delay(500);
leg1.write(Nbp2);
delay(500);
leg5.write(Npp1);
delay(500);
leg7.write(Ipp2);
delay(500);
leg3.write(Ibp3);
delay(500);
leg7.write(Ipp1);
delay(500);
leg8.write(Npp2);
delay(500);
leg4.write(Nbp2);
delay(500);
leg8.write(Npp1);
delay(500);
leg6.write(Ipp2);
delay(500);
leg2.write(Ibp3);
delay(500);
leg6.write(Ipp1);
delay(500);

}

void subir() {

  
leg5.write(Npp1);
leg6.write(Ipp1);
leg7.write(Ipp1);
leg8.write(Npp1);

}

void bajar() {
  
leg5.write(Npp3);
leg6.write(Ipp3);
leg7.write(Ipp3);
leg8.write(Npp3);

}
void saludar() {
 
leg5.write(Npp3);
leg7.write(Ipp3);
leg8.write(Npp3);
leg6.write(180);
leg1.write(Nbp1);
leg3.write(Ibp1);
leg4.write(Nbp1);
delay(500);

for(int k = 0 ; k < 5 ; k++)
{
  leg2.write(Ibp3);
 delay(500);
  leg2.write(Ibp2);
  delay(500);
  }
 delay(500);

}

void mauto(){

  
   digitalWrite(pintrigger, LOW);
   delayMicroseconds(2);
   digitalWrite(pintrigger, HIGH);
   delayMicroseconds(10);
   digitalWrite(pintrigger, LOW);
   tiempo = pulseIn(pinecho, HIGH);
   distancia = tiempo / 58;
   
   
       

         if (distancia < 8){
            leg1.write(Nbp1);
            leg5.write(Npp1);
            leg2.write(Ibp1);
            leg6.write(Ipp1);
            leg3.write(Ibp1);
            leg7.write(Ipp1);
            leg4.write(Nbp1);
            leg8.write(Npp1);
            delay(500);
            leg5.write(Npp2);
            delay(500);
            leg1.write(Nbp2);
            delay(500);
            leg5.write(Npp1);
            delay(500);
            leg7.write(Ipp2);
            delay(500);
            leg3.write(Ibp3);
            delay(500);
            leg7.write(Ipp1);
            delay(500);
            leg8.write(Npp2);
            delay(500);
            leg4.write(Nbp2);
            delay(500);
            leg8.write(Npp1);
            delay(500);
            leg6.write(Ipp2);
            delay(500);
            leg2.write(Ibp3);
            delay(500);
            leg6.write(Ipp1);
            delay(500);
	     leg1.write(Nbp1);
            leg5.write(Npp1);
            leg2.write(Ibp1);
            leg6.write(Ipp1);
            leg3.write(Ibp1);
            leg7.write(Ipp1);
            leg4.write(Nbp1);
            leg8.write(Npp1);
            delay(500);
             
            
         }
         else
         {  
          leg5.write(Npp1);
          leg1.write(Nbp1);
          leg8.write(Npp1);
          delay(500);
          leg6.write(Ipp2);
          leg7.write(Ipp2);
          delay(500);
          leg2.write(Ibp3);
          leg3.write(Ibp2);
          leg4.write(Nbp3);
          leg1.write(Nbp2);
          delay(500);
          leg6.write(Ipp1);
          leg7.write(Ipp1);
          delay(500);
          leg5.write(Npp2);
          leg8.write(Npp2);
          delay(500);
          leg1.write(Nbp1);
          leg4.write(Nbp2);
          leg2.write(Ibp2);
          leg3.write(Ibp1);
          delay(500);
         }

    
}



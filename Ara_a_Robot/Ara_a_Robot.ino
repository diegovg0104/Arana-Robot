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
int trig=10;
int echo=11;           //Declaracion de el sensor ultrasonico
float duracion;
float distancia;

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
   pinMode(trig,OUTPUT);
   pinMode(echo,INPUT);   
  leg1.write(Nbp3);
  leg5.write(Npp1);
  leg2.write(Ibp1);
  leg6.write(Ipp1);
  leg3.write(Ibp1);
  leg7.write(Ipp1);
  leg4.write(Nbp1);
  leg8.write(Npp1);
                 
    
 } 
 
void loop()  { 
  
  if(Serial.available()>0){        // lee el bluetooth y almacena en estado
      estado = Serial.read();
  }

  if (estado =='f'){          // Boton ON se mueve sensando distancia 
    do
    {
       
            sensor();
         if (distancia < 50){
          //Instrucciones giro
          gir_izq();
         }
         else{
             //instrucciones caminar
             Adel();
         }
      
        if(Serial.available()>0){        // lee el bluetooth y almacena en estado
      estado = Serial.read();
       }
         
      } while (estado == 'f');
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


}

void der() {

}

void izq() {

}

void gir_der() {

}

void gir_izq() {

}

void subir() {



}

void bajar() {

}
void sensor(){
  digitalWrite(trig,LOW);
  delay(1);
  digitalWrite(trig,HIGH);
  delay(10);
  digitalWrite(trig,LOW);
  duracion=pulseIn(echo,HIGH);
  distancia= duracion*0.017;
    
}



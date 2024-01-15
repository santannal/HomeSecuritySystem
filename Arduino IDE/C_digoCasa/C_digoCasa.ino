//Bibliotecas
//#include <Servo.h>
#include <Keypad.h>
#include <LiquidCrystal_I2C.h>

//Variáveis do app
  String porta = "";
  String risco = "";

//Variável alarme
int alarme = A0;

//Variável servo
//Servo serv;

//variáveis sensor de gás mk2
#define entradaDigital 10
#define entradaAnalogica A1

bool dSensor;
int aSensor;
float tensao;

//leds
int ledSala1 =  22;
int ledQuartoB = 23;
int ledQuartoB2 = 24;
int ledQuartoB3 = 25;
int ledBanheiro = 27;
int ledQuartoA = 30;
int ledCozinha = 28;
int ledCorredor = 29;
/*int ledSala2 =  0;
int ledBanheiro2 = 0; */

//variáveis teclado 

int variavel=0; 
int num1=0, num2=0, num3=0, num4=0;
int dig1=1, dig2=2, dig3=3, dig4=4;

//config teclado

const byte filas = 4; 
const byte columnas = 4; 

char tecla[filas][columnas] = {
  
 {'1','2','3','A'},
 {'4','5','6','B'},
 {'7','8','9','C'},
 {'*','0','#','D'}
  
};

//Ligação arduino

byte pinFilas[filas] = {7, 6, 5, 4}; 
byte pinColumnas[columnas] = {3, 2, 9, 8}; 
Keypad keypad = Keypad( makeKeymap(tecla), pinFilas, pinColumnas, filas, columnas );


#define endereco 0x27
#define colunas 16
#define linhas 2

LiquidCrystal_I2C lcd(endereco, colunas, linhas);

void setup()
{ 
   /*
  servo 
  serv.attach(A3);
  */
  lcd.init();
  lcd.backlight(); 
  lcd.begin(16,2);
  
  //ativando leds
  pinMode (ledSala1, OUTPUT);
  pinMode (ledQuartoA, OUTPUT);
  pinMode (ledQuartoB, OUTPUT);
  pinMode (ledQuartoB2, OUTPUT);
  pinMode (ledQuartoB3, OUTPUT);
  pinMode (ledCozinha, OUTPUT);
  pinMode (ledCorredor, OUTPUT);
  pinMode (ledBanheiro, OUTPUT);
  /*
  pinMode (ledBanheiro2, OUTPUT);
  pinMode (ledSala2, OUTPUT); */
  
  digitalWrite(ledSala1, LOW);
  digitalWrite(ledQuartoA, LOW);
  digitalWrite(ledQuartoB, LOW);
  digitalWrite(ledQuartoB2, LOW);
  digitalWrite(ledQuartoB3, LOW);
  digitalWrite(ledCozinha, LOW);
  digitalWrite(ledCorredor, LOW);
  digitalWrite(ledBanheiro, LOW);
  
  /*
  digitalWrite(ledBanheiro2, LOW);
  digitalWrite(ledSala2, LOW); */

  //ativando monitor serial
   Serial.begin(9600);

   //configurando a entradaDigital do sensor mk2
   pinMode(entradaDigital, INPUT);
    
}
  

  void loop(){
    delay(100);
    if (Serial.available() > 0) { 
     String estadoSerial = Serial.readStringUntil('\n');

  if (estadoSerial == "1"){ 
     digitalWrite(ledSala1, HIGH);
  }

  if (estadoSerial == "0"){ 
     digitalWrite(ledSala1, LOW);
  }
  /*if (estadoSerial == "3"){ 
     digitalWrite(ledSala2, HIGH);
  }

  if (estadoSerial == "2"){ 
     digitalWrite(ledSala2, LOW);
  } */
  if (estadoSerial == "5"){ 
     digitalWrite(ledQuartoA, HIGH);
  }

if (estadoSerial == "4"){ 
     digitalWrite(ledQuartoA, LOW);
}

  if (estadoSerial == "6"){ 
     digitalWrite(ledQuartoB, LOW);
  }
  if (estadoSerial == "7"){ 
     digitalWrite(ledQuartoB, HIGH);
  }
  if (estadoSerial == "8"){ 
     digitalWrite(ledQuartoB2, LOW);
  }
  if (estadoSerial == "9"){ 
     digitalWrite(ledQuartoB2, HIGH);
  }
  if (estadoSerial == "a"){ 
     digitalWrite(ledQuartoB3, LOW);
  }
  if (estadoSerial == "b"){ 
     digitalWrite(ledQuartoB3, HIGH);
  }
  if (estadoSerial == "c"){ 
     digitalWrite(ledCozinha, LOW);
  }
  if (estadoSerial == "d"){ 
     digitalWrite(ledCozinha, HIGH);
  }
  if (estadoSerial == "e"){ 
     digitalWrite(ledCorredor, LOW);
  }
  if (estadoSerial == "f"){ 
     digitalWrite(ledCorredor, HIGH);
  }
  if (estadoSerial == "g"){ 
     digitalWrite(ledBanheiro, LOW);
  }
  if (estadoSerial == "h"){ 
     digitalWrite(ledBanheiro, HIGH);
  }
  /*
  if (estadoSerial == "j"){ 
     digitalWrite(ledBanheiro2, LOW);
  }
  if (estadoSerial == "i"){ 
     digitalWrite(ledBanheiro2, HIGH);
  }
  */
  if(estadoSerial == "clarao"){
  digitalWrite(ledSala1, HIGH);
  //digitalWrite(ledSala2, HIGH);
  digitalWrite(ledQuartoA, HIGH);
  digitalWrite(ledQuartoB, HIGH);
  digitalWrite(ledQuartoB2, HIGH);
  digitalWrite(ledQuartoB3, HIGH);
  digitalWrite(ledCozinha, HIGH);
  digitalWrite(ledCorredor, HIGH);
  digitalWrite(ledBanheiro, HIGH);
  //digitalWrite(ledBanheiro2, HIGH);
  }
  if(estadoSerial == "apagao"){
  digitalWrite(ledSala1, LOW);
  //digitalWrite(ledSala2, LOW);
  digitalWrite(ledQuartoA, LOW);
  digitalWrite(ledQuartoB, LOW);
  digitalWrite(ledQuartoB2, LOW);
  digitalWrite(ledQuartoB3, LOW);
  digitalWrite(ledCozinha, LOW);
  digitalWrite(ledCorredor, LOW);
  digitalWrite(ledBanheiro, LOW);
  //digitalWrite(ledBanheiro2, LOW);
  }
    
    }

  Serial.print(risco);
  Serial.print(",");
  Serial.println(porta);

  //configurando sensor mk(fumaça)
  dSensor = digitalRead(entradaDigital);
  aSensor = analogRead(entradaAnalogica);

  tensao = (aSensor/1023.0) * 5;

  if(tensao > 2.0){
    risco = "ALERTA DE RISCO COM FLUIDOS!!!";
    tone(alarme, 500);
    digitalWrite(ledSala1, HIGH);
    //digitalWrite(ledSala2, HIGH);
    digitalWrite(ledQuartoA, HIGH);
    digitalWrite(ledQuartoB, HIGH);
    digitalWrite(ledQuartoB2, HIGH);
    digitalWrite(ledQuartoB3, HIGH);
    digitalWrite(ledCozinha, HIGH);
    digitalWrite(ledCorredor, HIGH);
    digitalWrite(ledBanheiro, HIGH);
    //digitalWrite(ledBanheiro2, HIGH);
    delay(1000);
    noTone(alarme);
    digitalWrite(ledSala1, LOW);
    //digitalWrite(ledSala2, LOW);
    digitalWrite(ledQuartoA, LOW);
    digitalWrite(ledQuartoB, LOW);
    digitalWrite(ledQuartoB2, LOW);
    digitalWrite(ledQuartoB3, LOW);
    digitalWrite(ledCozinha, LOW);
    digitalWrite(ledCorredor, LOW);
    digitalWrite(ledBanheiro, LOW);
    //digitalWrite(ledBanheiro2, LOW); 
    delay(1000);
  } else{
    risco = "SEM RISCOS COM FLUIDOS";
  }

  char key = keypad.getKey();
  	if (key){
   	lcd.setCursor(6+variavel,1);
   	lcd.print(key);   
   	key=key-48; 
   	variavel++;
      
    switch(variavel){
    case 1:
    num1=key; 
    break;
    case 2:
    num2=key;
    break;
    case 3:
    num3=key; 
    break;
    case 4:
    num4=key;
   
    delay(100);
      
    //Caso a senha esteja correta
      
  	if(num1==dig1 && num2==dig2 && num3==dig3 && num4==dig4){
    lcd.clear();
    digitalWrite(ledSala1, HIGH);
    lcd.setCursor(6,0);
    lcd.print("SENHA");
    lcd.setCursor(5,1);
    lcd.print("CORRETA");
    porta = "PORTA DESBLOQUEADA";
    delay(1000); 
    porta = "PORTA DESBLOQUEADA";
    delay(1000); 
    porta = "PORTA DESBLOQUEADA";
    delay(1000); 
    porta = "PORTA DESBLOQUEADA";
    delay(1000); 
    porta = "PORTA DESBLOQUEADA";
    delay(1000); 
    lcd.clear();
    digitalWrite(ledSala1, LOW);
      
    }
      
      //Caso esteja incorreta
      
  	else{
    lcd.clear();
    lcd.setCursor(6,0);
    lcd.print("SENHA");
    lcd.setCursor(4,1);
    lcd.print("INCORRETA");
    tone(alarme, 900);
    delay(2000); 
    noTone(alarme);
    delay(1000);
    tone(alarme, 900);
    delay(2000);
    noTone(alarme);
    delay(1000);
    tone(alarme, 900);
    delay(2000);
    noTone(alarme);
    lcd.clear();
    }
      
  	variavel=0;
  	lcd.clear();

  	break;
  }

 }

    //Tela inicial
    
 if(!key){   
  porta = "PORTA BLOQUEADA";
  lcd.setCursor(0,0),lcd.print("-INSIRA A SENHA-");
        
 }
  delay(2);
}
  
  

    
  
  

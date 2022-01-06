//06.01.2022 Ömer ERMİŞ
//ARduino kontrollü zil programı için yazıldı.
//13 nolu portu seri porttan okuduğu bilgiye göre açıp kapatır.
//gelen==48  SIFIR gelirse ASCII kodu 48 demek (KAPAT)
//gelen==49  BİR gelirse ASCII kodu 49 demek (AÇ)

#define LED 13
int ledDurum=0;

void setup() {  
  Serial.begin(9600);
  pinMode(LED , OUTPUT);
  digitalWrite(LED , LOW);
}

void loop() {  
  int gelen;
  
  if (Serial.available() > 0) {    
    gelen= Serial.read();
    //Serial.print(gelen);

    if (gelen==48) {
      ledDurum = 0;
    }

    else if (gelen==49) {
      ledDurum = 1;
    }
    else if (gelen==50) {
      Serial.println("OTO DEVREDE");
    }
  } 
  digitalWrite(LED , ledDurum);  
  delay(50); 
}

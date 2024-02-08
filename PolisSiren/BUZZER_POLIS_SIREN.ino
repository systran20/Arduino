int buzzerPin = 12;
void setup() {
  pinMode(12 , OUTPUT);
}

void loop() {
  for (int i = 0; i <= 10 ; i++) {
    Siren1();
  }
  for (int i = 0; i <= 2; i++) {
    Siren2();
  }


}

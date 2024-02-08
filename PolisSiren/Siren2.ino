void Siren2() {
  for (int i = 350; i <= 1150 ; i++) {
    tone(buzzerPin , i);
    delay(5);
  }
  noTone(100);
  for (int i = 1150; i >= 350 ; i--) {
    tone(buzzerPin , i);
    delay(5);
  }
  noTone(100);
}

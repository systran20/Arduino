void Siren1() {
  for (int i = 262; i <= 1550 ; i++) {
    tone(buzzerPin , i);
    //delay(5);
  }
  
  for (int i = 1550; i >= 262 ; i--) {
    tone(buzzerPin , i);
    //delay(5);
  }
  
}

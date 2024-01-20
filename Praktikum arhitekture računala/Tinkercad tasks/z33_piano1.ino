
int piezzo = 11;
int c = 1, d = 2, e = 3, f = 4, g = 5, a = 6, h = 7, c2 = 8;

void setup()
{
  pinMode(piezzo, OUTPUT);
  digitalWrite(piezzo, LOW);
  pinMode(c, INPUT_PULLUP);
  pinMode(d, INPUT_PULLUP);
  pinMode(e, INPUT_PULLUP);
  pinMode(f, INPUT_PULLUP);
  pinMode(g, INPUT_PULLUP);
  pinMode(a, INPUT_PULLUP);
  pinMode(h, INPUT_PULLUP);
  pinMode(c2, INPUT_PULLUP);
}

void loop()
{
  if(digitalRead(c) == LOW)tone(piezzo, 523);
  else if(digitalRead(d) == LOW)tone(piezzo, 587);
  else if(digitalRead(e) == LOW)tone(piezzo, 659);
  else if(digitalRead(f) == LOW)tone(piezzo, 698);
  else if(digitalRead(g) == LOW)tone(piezzo, 784);
  else if(digitalRead(a) == LOW)tone(piezzo, 880);
  else if(digitalRead(h) == LOW)tone(piezzo, 988);
  else if(digitalRead(c2) == LOW)tone(piezzo, 1046);
  else noTone(piezzo);
}
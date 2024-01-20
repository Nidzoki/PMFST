
int piezzo = 3;

void setup()
{
  pinMode(piezzo, OUTPUT);
  digitalWrite(piezzo, LOW);
}

void loop()
{
  tone(piezzo, 1000);
  delay(1000);
  noTone(piezzo);
  delay(1000);
}
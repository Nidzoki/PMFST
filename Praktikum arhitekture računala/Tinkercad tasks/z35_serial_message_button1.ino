int tipkalo = 2;

void setup()
{
  pinMode(tipkalo, INPUT_PULLUP);
  Serial.begin(9600);
}

void loop()
{
  if(digitalRead(tipkalo) == LOW)Serial.println("Tipkalo je pritisnuto");
  else Serial.println("Tipkalo je otpusteno");
  delay(1000);
}
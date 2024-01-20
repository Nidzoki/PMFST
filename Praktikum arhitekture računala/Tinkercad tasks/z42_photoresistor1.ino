int photoresistor = A5;

void setup()
{
  Serial.begin(9600);
}

void loop()
{
  Serial.println(analogRead(photoresistor));
}
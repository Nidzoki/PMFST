int photoresistor = A5, led = 3;

void setup()
{
  Serial.begin(9600);
  pinMode(led, OUTPUT);
}

void loop()
{
  Serial.println(analogRead(photoresistor));
  
  analogWrite(led, 974 - analogRead(photoresistor));
}
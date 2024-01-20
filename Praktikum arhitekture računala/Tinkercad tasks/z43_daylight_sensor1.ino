int photoresistor = A5, led = 2;

void setup()
{
  Serial.begin(9600);
  pinMode(led, OUTPUT);
}

void loop()
{
  Serial.println(analogRead(photoresistor));
  if(analogRead(photoresistor)> 200){
  digitalWrite(led, LOW);
  }
  else digitalWrite(led, HIGH);
}
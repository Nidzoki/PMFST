
int led1 = 3;
int led2 = 5;

void setup()
{
  pinMode(led1, OUTPUT);
  pinMode(led2, OUTPUT);
  digitalWrite(led1, LOW);
  digitalWrite(led2, LOW);
  
}

void loop()
{
  analogWrite(led1, 51);
  analogWrite(led2, 204);
}
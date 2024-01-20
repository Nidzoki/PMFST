// C++ code
//
int p = A5;
int led1 = 3, led2 = 4, led3 = 5, led4 = 6, led5 = 7;

void setup()
{
  pinMode(led1, OUTPUT);
  pinMode(led2, OUTPUT);
  pinMode(led3, OUTPUT);
  pinMode(led4, OUTPUT);
  pinMode(led5, OUTPUT);
  digitalWrite(led1, LOW);
  digitalWrite(led2, LOW);
  digitalWrite(led3, LOW);
  digitalWrite(led4, LOW);
  digitalWrite(led5, LOW);
}

void loop()
{
  digitalWrite(led1, HIGH);
  delay(analogRead(p));
  digitalWrite(led1, LOW);
  digitalWrite(led2, HIGH);
  delay(analogRead(p));
  digitalWrite(led2, LOW);
  digitalWrite(led3, HIGH);
  delay(analogRead(p));
  digitalWrite(led3, LOW);
  digitalWrite(led4, HIGH);
  delay(analogRead(p));
  digitalWrite(led4, LOW);
  digitalWrite(led5, HIGH);
  delay(analogRead(p));
  digitalWrite(led5, LOW);
}
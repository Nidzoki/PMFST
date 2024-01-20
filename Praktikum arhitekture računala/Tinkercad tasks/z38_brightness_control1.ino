// C++ code
//
int p = A5;
int led = 3;

void setup()
{
  pinMode(led, OUTPUT);
  Serial.begin(9600);
}

void loop()
{
  analogWrite(led, analogRead(p));
}
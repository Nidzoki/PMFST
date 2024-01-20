// C++ code
//
int r = A5, g = A4, b = A3;
int red = 3, green = 6, blue = 5;

void setup()
{
  pinMode(red, OUTPUT);
  pinMode(green, OUTPUT);
  pinMode(blue, OUTPUT);
}

void loop()
{
  analogWrite(red, analogRead(r));
  analogWrite(green, analogRead(g));
  analogWrite(blue, analogRead(b));
}
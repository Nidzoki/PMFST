// C++ code
//
int red = 3;
int green = 5;
int blue = 6;

void setup()
{
  pinMode(red, OUTPUT);
  pinMode(green, OUTPUT);
  pinMode(blue, OUTPUT);
  digitalWrite(red, LOW);
  digitalWrite(green, LOW);
  digitalWrite(blue, LOW);
}

void loop()
{	
  analogWrite(red, 255/2);
  analogWrite(green, 0.8 * 255);
  analogWrite(blue, 0.25 *255);
  
  
}
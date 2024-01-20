// C++ code
//
int red = 1;
int green = 2;
int blue = 3;

void setup()
{
  pinMode(red, OUTPUT);
  pinMode(green, OUTPUT);
  pinMode(blue, OUTPUT);
}

void loop()
{
  digitalWrite(red, HIGH);
  digitalWrite(green , LOW);
  digitalWrite(blue, LOW);
  delay(1000); 
  digitalWrite(red, LOW);
  digitalWrite(green , LOW);
  digitalWrite(blue, LOW);
  delay(500);
  digitalWrite(red, LOW);
  digitalWrite(green , HIGH);
  digitalWrite(blue, LOW);
  delay(1000); 
  digitalWrite(red, LOW);
  digitalWrite(green , LOW);
  digitalWrite(blue, LOW);
  delay(500);
  digitalWrite(red, LOW);
  digitalWrite(green , LOW);
  digitalWrite(blue, HIGH);
  delay(1000); 
  digitalWrite(red, LOW);
  digitalWrite(green , LOW);
  digitalWrite(blue, LOW);
  delay(500);
  
}
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
{	//crvena
  digitalWrite(red, HIGH);
  digitalWrite(green , LOW);
  digitalWrite(blue, LOW);
  delay(3000); 
  //zuta
  digitalWrite(red, HIGH);
  digitalWrite(green , HIGH);
  digitalWrite(blue, LOW);
  delay(1000);
  //zelena
  digitalWrite(red, LOW);
  digitalWrite(green , HIGH);
  digitalWrite(blue, LOW);
  delay(3000); 
  // zuta
  digitalWrite(red, HIGH);
  digitalWrite(green , HIGH);
  digitalWrite(blue, LOW);
  delay(1000);
  
  
  
}
// C++ code
//
int LED = 3;
int intenzitet = 0;



void setup()
{
  pinMode(LED, OUTPUT);
  digitalWrite(LED, LOW);
}

void loop()
{ 
  analogWrite(LED, intenzitet);
  intenzitet++;
  
  if(intenzitet > 255)intenzitet = 0;
  delay(20);
}
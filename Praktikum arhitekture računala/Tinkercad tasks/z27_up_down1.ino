// C++ code
//
int LED = 3;
int intenzitet = 0;

bool predznak = true;

void setup()
{
  pinMode(LED, OUTPUT);
  digitalWrite(LED, LOW);
}

void loop()
{
  analogWrite(LED, intenzitet);
  
  if(predznak)intenzitet++;
  else intenzitet--;
  
  if(intenzitet > 255)predznak = false;
  else if(intenzitet < 0)predznak = true;
    
    delay(20);
}
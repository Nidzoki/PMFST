// C++ code
//
int LED = 3, LED2 = 5;
int intenzitet = 0;

bool predznak = true;

void setup()
{
  pinMode(LED, OUTPUT);
  digitalWrite(LED, LOW);
  pinMode(LED2, OUTPUT);
  digitalWrite(LED2, LOW);
}

void loop()
{
  analogWrite(LED, intenzitet);
  analogWrite(LED2, 255 - intenzitet);
  if(predznak)intenzitet++;
  else intenzitet--;
  
  if(intenzitet > 255)predznak = false;
  else if(intenzitet < 0)predznak = true;
    
    delay(20);
}
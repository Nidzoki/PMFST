// C++ code
//
int LED = 3, b1 = 5, b2 = 6, b3 = 7;
int intenzitet = 0;



void setup()
{
  pinMode(LED, OUTPUT);
  pinMode(b1, INPUT_PULLUP);
  pinMode(b2, INPUT_PULLUP);
  pinMode(b3, INPUT_PULLUP);
  digitalWrite(LED, LOW);
}

void loop()
{
  analogWrite(LED, intenzitet);
  
  if(digitalRead(b1) == LOW)intenzitet-=5;
  else if(digitalRead(b2) == LOW)intenzitet = 0;
  else if(digitalRead(b3) == LOW)intenzitet += 5;
    
    if(intenzitet < 0)intenzitet = 0;
    if(intenzitet > 255)intenzitet = 255;
    
    delay(100);
}
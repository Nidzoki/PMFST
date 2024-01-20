// C++ code
//

int led1 = 4, led2 = 5, s = 3;

void setup()
{
  pinMode(led1, OUTPUT);
  pinMode(led2, OUTPUT);
  pinMode(s, INPUT_PULLUP);
  digitalWrite(led1, LOW);
  digitalWrite(led2, LOW);
}

void loop()
{
  
  if(digitalRead(s) == LOW){
  	digitalWrite(led1, HIGH);
    digitalWrite(led2, HIGH);
    delay(500);
    digitalWrite(led2, LOW);
    delay(500);
  }
  else {
  digitalWrite(led1, HIGH);
    digitalWrite(led2, HIGH);
    delay(500);
    digitalWrite(led1, LOW);
    delay(500);
  }
  
}
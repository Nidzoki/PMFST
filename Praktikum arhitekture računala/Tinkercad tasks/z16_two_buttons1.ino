int LED = 2;
int button = 3;
int button2 = 4;

void setup()
{
  pinMode(LED, OUTPUT);
  pinMode(button, INPUT_PULLUP);
  pinMode(button2, INPUT_PULLUP);
  digitalWrite(LED, LOW);
}

void loop()
{
  
  
  if(digitalRead(button) == LOW){
  	digitalWrite(LED, HIGH);
  }
  
  if(digitalRead(button2) == LOW){
  	digitalWrite(LED, LOW);
  }
  
  
  
}
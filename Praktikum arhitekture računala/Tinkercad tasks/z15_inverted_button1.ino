int LED = 2;
int button = 3;
int isOn = 0;
void setup()
{
  pinMode(LED, OUTPUT);
  pinMode(button, INPUT_PULLUP);
}

void loop()
{
  isOn = digitalRead(button);
  if(!isOn)
  digitalWrite(LED, LOW);
  else digitalWrite(LED, HIGH);
  
}
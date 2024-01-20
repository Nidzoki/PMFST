int b1 = 2, b2 = 3, led = 7;

bool traka = false;
int proizvodi = 0;

void setup()
{
  pinMode(b1, INPUT_PULLUP);
  pinMode(b2, INPUT_PULLUP);
  Serial.begin(9600);
}

void loop()
{
  if(traka){
    digitalWrite(led, HIGH);
    if(proizvodi > 5){
      traka = false;
      Serial.println("PROIZVODNA KUTIJA JE NAPUNJENA");
    }
    if(digitalRead(b2) == LOW){
      traka = false;
      delay(250);
    }
    if(digitalRead(b1) == LOW){
      delay(250);
    	proizvodi++;
    }
  }
  else{
  digitalWrite(led, LOW);
    if(digitalRead(b2) == LOW){
      delay(250);
      traka = true;
      Serial.println("PROIZVODNA TRAKA JE U POGONU");
      if(proizvodi > 5)proizvodi = 0;
    }
    
  }
  
  
}
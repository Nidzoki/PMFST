// C++ code
//

int LEDG = 1;
int LEDR = 2;
int LEDO = 3;


void setup()
{
  pinMode(LEDG, OUTPUT);
  pinMode(LEDR, OUTPUT);
  pinMode(LEDO, OUTPUT);
}

void loop()
{
  digitalWrite(LEDR, HIGH);
  digitalWrite(LEDG, LOW);
  digitalWrite(LEDO, LOW);
  delay(300);
  digitalWrite(LEDR, LOW);
  digitalWrite(LEDG, HIGH);
  digitalWrite(LEDO, LOW);
  delay(300);
  digitalWrite(LEDR, LOW);
  digitalWrite(LEDG, LOW);
  digitalWrite(LEDO, HIGH);
  delay(300);
}
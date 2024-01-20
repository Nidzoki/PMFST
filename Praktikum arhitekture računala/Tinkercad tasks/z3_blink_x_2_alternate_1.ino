// C++ code
//

int LEDG = 1;
int LEDR = 2;


void setup()
{
  pinMode(LEDG, OUTPUT);
  pinMode(LEDR, OUTPUT);
}

void loop()
{
  digitalWrite(LEDR, HIGH);
  digitalWrite(LEDG, LOW);
  delay(500); // Wait for 1000 millisecond(s)
  digitalWrite(LEDR, LOW);
  digitalWrite(LEDG, HIGH);
  delay(500); // Wait for 1000 millisecond(s)
}
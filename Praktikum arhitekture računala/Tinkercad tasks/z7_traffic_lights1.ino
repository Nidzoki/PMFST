// C++ code
//

int LEDG = 3;
int LEDR = 2;
int LEDY = 1;

int LED_R = 9;
int LED_G = 8;


void setup()
{
  pinMode(LEDG, OUTPUT);
  pinMode(LEDR, OUTPUT);
  pinMode(LEDY, OUTPUT);
  pinMode(LED_R, OUTPUT);
  pinMode(LED_G, OUTPUT);
}

void loop()
{
  digitalWrite(LEDR, HIGH);
  digitalWrite(LEDG, LOW);
  digitalWrite(LEDY, LOW);
  digitalWrite(LED_R, LOW);
  digitalWrite(LED_G, HIGH);
  delay(3000);
  digitalWrite(LEDR, HIGH);
  digitalWrite(LEDG, LOW);
  digitalWrite(LEDY, HIGH);
  digitalWrite(LED_R, HIGH);
  digitalWrite(LED_G, LOW);
  delay(1000);
  digitalWrite(LEDR, LOW);
  digitalWrite(LEDG, HIGH);
  digitalWrite(LEDY, LOW);
  delay(3000);
  digitalWrite(LEDR, LOW);
  digitalWrite(LEDG, LOW);
  digitalWrite(LEDY, HIGH);
  delay(1000);
}
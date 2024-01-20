// C++ code
//
int red = 3,green = 5,blue = 6;
int rd = 2, rg = 4, gd = 7, gg = 8, bd = 9, bg = 10;

int r_i = 0, g_i = 0, b_i = 0;

void setup()
{
  pinMode(red, OUTPUT);
  pinMode(green, OUTPUT);
  pinMode(blue, OUTPUT);
  pinMode(rd, INPUT_PULLUP);
  pinMode(rg, INPUT_PULLUP);
  pinMode(gd, INPUT_PULLUP);
  pinMode(gg, INPUT_PULLUP);
  pinMode(bd, INPUT_PULLUP);
  pinMode(bg, INPUT_PULLUP);
  digitalWrite(red, LOW);
  digitalWrite(green, LOW);
  digitalWrite(blue, LOW);
}

void loop()
{
  // postavljanje svjetline
  
  analogWrite(red, r_i);
  analogWrite(green, g_i);
  analogWrite(blue, b_i);
  
  // ispitivanje tipkala
  
  if(digitalRead(rd) == LOW)r_i-=5;
  if(digitalRead(rg) == LOW)r_i+=5;
  
  if(digitalRead(gd) == LOW)g_i-=5;
  if(digitalRead(gg) == LOW)g_i+=5;
  
  if(digitalRead(bd) == LOW)b_i-=5;
  if(digitalRead(bg) == LOW)b_i+=5;
  
  // rezanje na granicama
  
  if(r_i < 0)r_i = 0;
  if(r_i > 255)r_i = 255;
  
  if(g_i < 0)g_i = 0;
  if(g_i > 255)g_i = 255;
  
  if(b_i < 0)b_i = 0;
  if(b_i > 255)b_i = 255;
  
  delay(20);
}






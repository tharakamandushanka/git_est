#include <AFMotor.h> 

AF_DCMotor m1(1);
AF_DCMotor m2(2);
AF_DCMotor m3(3);
AF_DCMotor m4(4);

# define  sensor1 0 
# define  sensor2 2
# define  sensor3 9
# define  sensor4 10
# define  sensor5 13

bool a,b,c,d,e;



void setup() {
  // put your setup code here, to run once:
m1.setSpeed(0);
m2.setSpeed(0);
m3.setSpeed(0);
m4.setSpeed(0);

//sensor1(pi

Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:

 a=digitalRead (sensor1);
 b=digitalRead (sensor2);
 c=digitalRead (sensor3);
 d=digitalRead (sensor4);
 e=digitalRead (sensor5);
 
if(a==0 && b==0 && c==0 && d==0  && e==1  ||a==0 && b==1 && c==1  && d==0 && e==1 )
  {
     forward();     
  }
   else if(a==1 && b==1 && c==0 && d==0 && e==0 || a==1 && b==1 && c==0 && d==0 && e==1)
  {
    //Break();
   

     Rotate_right();
    
    //delay(300);
  }

  else if(a==0 && b==1 && c==0 && d==0 && e==1 ||  a==0 && b==1 && c==0 && d==0 && e==0)
  {
    //Break();
   
    Turn_right();
    //delay(100);
  }
  else if(a==0 && b==0 && c==1 && d==0 && e==0 ||  a==0 && b==0 && c==1 && d==0 && e==1)
  {
     //Break();
    
    Turn_left();
    //delay(100);
  }
  else if(a==0 && b==0 && c==1 && d==1 && e==0 || a==0 && b==0 && c==1 && d==1 && e==1)
  {
     //Break();
    
   Rotate_left();
    //delay(300);
    
  }
  else if(a==0 && b==0 && c==0 && d==1 && e==1)
  {
   // Break();
   Turn_left();
    //delay(200);
  }
  else if(a==1 && b==0 && c==0 && d==0 && e==1)
  {
   // Break();
    Turn_right();
    //delay(200);
  
  }
  else if(a==0 && b==0 && c==0 && d==0 && e==0 || a==0 && b==1 && c==1  && d==0 && e==0)
  {
    Backward();
  }
 else
  {
     //Break();
    
    car_Stop();
  }
  
 

}
void Backward()
{
  Serial.println("Forward");
    m1.setSpeed(170);
    m1.run(FORWARD);
    m2.setSpeed(170);
    m2.run(FORWARD);
    m3.setSpeed(170);
    m3.run(FORWARD);
    m4.setSpeed(170);
    m4.run(FORWARD);

}
void forward()
{
  Serial.println("Backward");
     m1.setSpeed(120);
    m1.run(BACKWARD);
    m2.setSpeed(120);
    m2.run(BACKWARD);
    m3.setSpeed(120);
    m3.run(BACKWARD);
    m4.setSpeed(120);
    m4.run(BACKWARD);
   
}
void Break()
{
    Serial.println("Break");
   /* m1.setSpeed(120);
    m1.run(BACKWARD);
    m2.setSpeed(120);
    m2.run(BACKWARD);
    m3.setSpeed(120);
    m3.run(BACKWARD);
    m4.setSpeed(120);
    m4.run(BACKWARD);
    delay(20);
    */
 
   // m1.setSpeed(100);
    m1.run(BRAKE);
    //m2.setSpeed(100);
    m2.run(BRAKE);
    //m3.setSpeed(100);
    m3.run(BRAKE);
   // m4.setSpeed(100);
    m4.run(BRAKE);
    //delay(100);
}
void Turn_left()
{
  Serial.println("Turn left");
    m1.setSpeed(0);
    m1.run(FORWARD);
    m2.setSpeed(0);
    m2.run(FORWARD);
    m3.setSpeed(140);
    m3.run(FORWARD);
    m4.setSpeed(140);
    m4.run(FORWARD);
}
void Turn_right()
{
  Serial.println("Turn right");
    m1.setSpeed(140);
    m1.run(FORWARD);
    m2.setSpeed(140);
    m2.run(FORWARD);
    m3.setSpeed(0);
    m3.run(FORWARD);
    m4.setSpeed(0);
    m4.run(FORWARD);
}    
    
void Rotate_left()
{
  Serial.println("Rotate left");
    m1.setSpeed(150);
    m1.run(BACKWARD);
    m2.setSpeed(150);
    m2.run(BACKWARD);
    m3.setSpeed(150);
    m3.run(FORWARD);
    m4.setSpeed(150);
    m4.run(FORWARD);
}
void Rotate_right()
{
  Serial.println("Rotate right");
    m1.setSpeed(150);
    m1.run(FORWARD);
    m2.setSpeed(150);
    m2.run(FORWARD);
    m3.setSpeed(150);
    m3.run(BACKWARD);
    m4.setSpeed(150);
    m4.run(BACKWARD);
}

void car_Stop()
  {
  Serial.println("Stop");
    m1.setSpeed(0);  
    m1.run(RELEASE);
    m2.setSpeed(0);  
    m2.run(RELEASE);
    m3.setSpeed(0);  
    m3.run(RELEASE);
    m4.setSpeed(0);  
    m4.run(RELEASE);
  }

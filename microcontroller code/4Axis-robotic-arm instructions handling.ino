#include <Wire.h>
#include <Adafruit_PWMServoDriver.h>

Adafruit_PWMServoDriver pwm = Adafruit_PWMServoDriver();

const int SERVOMIN = 150; 
const int SERVOMAX = 600; 
const int ELECTROMAGNET_PIN = 12;

String data;

void setServoAngle(uint8_t servo, int angle) {
  int pulseLength = map(angle, 0, 180, SERVOMIN, SERVOMAX);
  pwm.setPWM(servo, 0, pulseLength);
}

void setup() {
  Serial.begin(9600);
  pwm.begin();
  pwm.setPWMFreq(60); 
  pinMode(ELECTROMAGNET_PIN, OUTPUT);
  digitalWrite(ELECTROMAGNET_PIN, LOW);
}

void loop() {
  if (Serial.available()) {
    data = Serial.readStringUntil('\n');
    if (data.charAt(0) == 'S') {
      // Handle multiple servo command " for the record who ever is modifying this in the future, Go get some bitches :)" 
      if (data.length() == 13) {
        int angle1 = data.substring(1, 4).toInt();
        int angle2 = data.substring(4, 7).toInt();
        int angle3 = data.substring(7, 10).toInt();
        int angle4 = data.substring(10, 13).toInt();

        if (angle1 >= 0 && angle1 <= 180) setServoAngle(0, angle1);
        delay(1500);
        if (angle2 >= 0 && angle2 <= 180) setServoAngle(1, angle2);
        delay(1500);
        if (angle3 >= 0 && angle3 <= 180) setServoAngle(2, angle3);
        delay(1500);
        if (angle4 >= 0 && angle4 <= 180) setServoAngle(3, angle4);
        delay(1500);
      }
      // Handle single servo command "yep you heard that right, and i'm pretty sure your more single than even the servo atleast its got components arount it :!"
      else if (data.length() == 5) {
        int servoNumber = data.substring(1, 2).toInt();
        int angle = data.substring(2, 5).toInt();

        if (servoNumber >= 0 && servoNumber <= 3 && angle >= 0 && angle <= 180) {
          setServoAngle(servoNumber, angle);
        }
      }
    } else if (data == "on") {
      digitalWrite(ELECTROMAGNET_PIN, LOW);
    } else if (data == "off") {
      digitalWrite(ELECTROMAGNET_PIN, HIGH);
    }
  }
}


// In any case i am Kim Anang son of THRANE and VICTORA

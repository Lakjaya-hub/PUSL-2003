#include <DHT.h>
#include <DHT_U.h>
#include <BlynkSimpleEsp8266.h>
#include <ESP8266WiFi.h>
char auth[] = "YPflfXGR967SYiyOIXE8e8mAUPGcxOzG";

String apiKey = "92I4BFXTA28U3LV0";     //  Enter your Write API key from ThingSpeak
 
const char *ssid =  "Dialog 4G 637";     // replace with your wifi ssid and wpa2 key
const char *pass =  "37A67Ff3";
const char* server = "api.thingspeak.com";

char sid[] = "Dialog 4G 637";
char ass[] = "37A67Ff3";
 
#define DHTPIN 0          //pin where the dht11 is connected
#define DHTTYPE DHT11
#define PulseSensorpin A0

DHT dht(DHTPIN, DHT11);

BlynkTimer timer;

void sendSensor()
{
  float hu = dht.readHumidity();
  float te = dht.readTemperature(); // or dht.readTemperature(true) for Fahrenheit
 
  if (isnan(hu) || isnan(te)) {
    Serial.println("Failed to read from DHT sensor!");
    return;
  }
  // You can send any value at any time.
  // Please don't send more that 10 values per second.
  Blynk.virtualWrite(V5, te);
  Blynk.virtualWrite(V6, hu);
}
WiFiClient client;
 
void setup() 
{
       Serial.begin(115200);
       Blynk.begin(auth, sid, ass);
       delay(10);
       dht.begin();
       timer.setInterval(1000L, sendSensor);
 
       Serial.println("Connecting to ");
       Serial.println(ssid);
 
 
       WiFi.begin(ssid, pass);
 
      while (WiFi.status() != WL_CONNECTED) 
     {
            delay(500);
            Serial.print(".");
     }
      Serial.println("");
      Serial.println("WiFi connected");
 
}
 
void loop() 
{
     Blynk.run();
     timer.run();
      int val = analogRead(PulseSensorpin);
      float h = dht.readHumidity();
      float t = dht.readTemperature();
      
              if (isnan(h) || isnan(t)) 
                 {
                     Serial.println("Failed to read from DHT sensor!");
                      return;
                 }
 
                         if (client.connect(server,80))   //   "184.106.153.149" or api.thingspeak.com
                      {  
                            
                             String postStr = apiKey;
                             postStr +="&field1=";
                             postStr += String(t);
                             postStr +="&field2=";
                             postStr += String(h);
                             postStr +="&field3=";
                             postStr += String(val);
                             postStr += "\r\n\r\n";
 
                             client.print("POST /update HTTP/1.1\n");
                             client.print("Host: api.thingspeak.com\n");
                             client.print("Connection: close\n");
                             client.print("X-THINGSPEAKAPIKEY: "+apiKey+"\n");
                             client.print("Content-Type: application/x-www-form-urlencoded\n");
                             client.print("Content-Length: ");
                             client.print(postStr.length());
                             client.print("\n\n");
                             client.print(postStr);
 
                             Serial.print("Temperature: ");
                             Serial.print(t);
                             Serial.print(" degrees Celcius, Humidity: ");
                             Serial.print(h);
                             Serial.println("%. Send to Thingspeak.");
                             Serial.print(val);
                             Serial.println("%. Send to Thingspeak.");
                        }
                        
          client.stop();
 
          Serial.println("Waiting...");
  
  // thingspeak needs minimum 15 sec delay between updates
  delay(1000);
}

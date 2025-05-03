1.	INTRODUCTION

1.1	PURPOSE OF THE PROJECT


Learning Traffic Management:

In this example, the mechanism of traffic lights can be observed in a simple way. The example shows how traffic lights change.


Timing and:
The duration of the traffic lights can be adjusted by users, and the number of vehicles can be increased, making the system easier to monitor..

Improving User Interaction:
The project aims to be more understandable by using user interface components such as Label, button, picturebox, combobox. Users can interact more closely with the program as they can try different scenarios.


1.2	IMPORTANCE OF TRAFFIC LIGHTS


  Traffic lights have various importance. These include: increasing safety, regulating traffic          flow, preventing potential dangers at pedestrian crossings, supporting traffic rules, and   preventing wrong-way and collision incidents.




1.	COMPONENTS USED

FORM
   
 Represents the main interface of the application. The screen that the user encounters to use the traffic light simulation is the form.
 
COMBOBOX (comboBox1, comboBox2, comboBox3, comboBox4)

Placed on the form for the user to adjust the traffic lights or the number of vehicles. This way, the program starts according to the selections.

PİCTUREBOX (pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10)

 Represents the visuals of traffic lights and vehicles. Each picturebox has a photo placed on it, creating visually understandable objects.

For example, pictureBox1 represents the vehicle visual, while pictureBox6 represents the traffic light.

LABEL (label1, label2, label3, label4)

Allows the user to follow the simulation. Each label shows the countdown time of the relevant traffic light.
For example, label1 shows the countdown of the first traffic light.

TİMER (timer1, timer2, timer3, timer4, timer5, timer6, timer7, timer8)

Used to control the durations of the traffic lights and the movement of the vehicles, ensuring they speed up. The timer is started at certain intervals to change the colors of the lights and to speed up the cars.

For example, timer1 shows the countdown of the first traffic light, while timer5 is activated to speed up the car after it passes a certain limit..

       BUTTON (startButton):
      Used to start the simulation. The user clicks this button to start all timers and make the    simulation work.

3. TRAFFIC LIGHTS AND TIMING SETTING


       3.1. BASIC OPERATION OF TRAFFIC LIGHTS

In a standard traffic light; 
• Green light: indicates that traffic can flow in the relevant direction, 
• Yellow light: indicates that the light is about to change from green to red or from red to green,
 • Red light: indicates that traffic must stop.

3.2. TIMING ADJUSTMENT

The duration of traffic lights on the highway depends on the burning time of the lights and the average speed of the vehicles, as well as the number of vehicles per unit area (density).

3.3. USER INTERACTION

        Thanks to the traffic light, drivers follow the status of the lights and determine their next move


4. PRINCIPLE OF OPERATION OF THE SIMULATION

        4.1. GENERAL WORKING LOGIC
1.	Definition of Form and Controls:
o	The Form1 class represents the main form of the Windows Form application. When the form is loaded, the necessary controls (e.g., PictureBox, ComboBox, Label) are created and initialized.  

2.	Usage of ComboBox:
o The user makes specific selections through the ComboBox controls. Each ComboBox selection affects the visibility of a particular PictureBox and sets the initial value of the relevant counter.
 o For example, when "1" or "2" is selected through comboBox1, pictureBox1 and pictureBox2 become visible, and the initial value of the counter is set.  
 
 
3.	Timers:
o The simulation includes a series of Timer objects to schedule specific events using timers. Each timer is triggered at a specific interval and decreases the relevant counter.
 o For example, timer1 decreases the value of counter1 by 1 at each trigger, thereby updating the  status of the traffic lights.

                                      
4.	Traffic Light Status Updates: 
o	When each timer is active, the visibility and colors of the relevant PictureBoxes are updated.
o	When the counter values reach a certain limit, the background colors of the PictureBoxes change (red, yellow, green), indicating the status of the traffic light.
                               
5.	Hareket ve Görsel Güncellemeler:
o	PictureBox'lar, belirli koşullara bağlı olarak form üzerinde hareket eder. Örneğin, pictureBox1 belirli bir konuma ulaştığında döndürülür ve yeni bir PictureBox eklenir.
o	Diğer PictureBox'lar, zamanlayıcılar tarafından kontrol edilen hareketlerle yukarı veya aşağı hareket eder. 
 
6.	Status Checks:
o	Each time a Timer is triggered, the value of the counter is checked. If a counter reaches zero, the background color of the relevant PictureBox turns red, and that timer is stopped.
o	Additionally, other timers are started, allowing the simulation to continue dynamically.
7.	User Interaction:
o	The user can start the simulation with buttons and ComboBox selections. All timers are started with the startButton, and the simulation becomes active. If the user does not make a ComboBox selection, the system gives a warning, and the simulation starts once a selection is made.
o	.
 

 


5. CONCLUSION AND EVALUATION

5.1.	SIMULATION RESULTS


      Purpose of the Simulator
The traffic light simulator aims to visually demonstrate how traffic lights work and how vehicles move. Users can interactively experience the basic knowledge of managing traffic flow. They can also observe different scenarios by changing the settings according to their preferences..
         Operation of the Simulation
The simulator works as follows:
•	Traffic Light Control
Traffic lights turn on sequentially with red, yellow, and green lights. There is a specific duration for transitions between lights; these durations can vary according to user selections..
•	Vehicle Movements
Vehicles move when the green light is on.
 Vehicles can change direction or stop according to the status of the traffic light. 
The positions of the vehicles are continuously updated based on the status of the light.



6.RESOURCES

https://tekneloji.net/trafik-isiklari-nasil-calisir/
https://tr.wikipedia.org/wiki/Trafik
https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.picturebox?view=windowsdesktop-9.0
https://stackoverflow.com/questions/11487901/how-do-i-change-a-pictureboxs-image




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Elevator_Control
{

    public partial class ElevatorSystem : Form // the ElevatorSystems class inherits from the form class.
    {
        Elevator elevator; // creating a varible of the class type elevator for refrencing.
        Button[] buttons = new Button[4]; // an array of buttons with 4 spaces.
        PictureBox[] pBoxes = new PictureBox[3];// an array of pictureboxes with 3 spaces.
        TextBox[] txtBoxes = new TextBox[3];// an array of textboxes with 3 spaces.


        public ElevatorSystem() // constructor for the elevatorsystems class.
        {
            InitializeComponent(); //calls the function which generates the gui. created by visual studio
        }

        private void ProduceArrays() // adds the buttons, pictureboxes and textboxes to the array properties of the class.
        {
            buttons[0] = btnF0Request;
            buttons[1] = btnF1Request;
            buttons[2] = btnFloor0;
            buttons[3] = btnFloor1;

            pBoxes[0] = pBoxElevator;
            pBoxes[1] = pBoxDoorL;
            pBoxes[2] = pBoxDoorR;

            txtBoxes[0] = txtEDisplay;
            txtBoxes[1] = txtF0Display;
            txtBoxes[2] = txtF1Display;
        }

        private void Form1_Load(object sender, EventArgs e) // event handler for when the form first loads.
        {
            ProduceArrays(); // calls the fuction to add all the gui objects into arrays to make it easier to send them to the elevator class.
            elevator = new Elevator(pBoxes, txtBoxes, buttons, dataViewLog, 0); // instantiating the Elevator class with the arrays, the datagridview object
                                                                                // and the floor the elevator will start on.
            elevator.UpdateDisplay(); // calls the updatedisplay method in the elevator class.
        }

        private void Form1_FormClosing(object sender, EventArgs e) // event handler for when the form closes.
        {
            elevator.log.DisconnentFromDB(); // calls the disconnectfromdb method from the database class instaniated in the elevation class.
        }

        private void Floor1Btn_Click(object sender, EventArgs e) // event handler for when either the 1st floor request button is pressed or
                                                                 // the floor 1 button on the control pannel.
        {
            if (!elevator.moving) // checks if the elevator boolean property called moving is set to false. So the elevator doesn't stop
                                  // moving towards a previously requested floor and move towards this floor.
            {
                elevator.log.UpdateLog("Requested to Move to Floor 1", elevator.currentFloor, elevator.doorOpen, elevator.fDoorOpen); // calls the updatelog method 
                                                                                                                                      // in the log class.
                elevator.MoveToFloor(1); // calls the movetofloor method in the elevator class with the interger 1 as a parametor
                                         // to reprecent which floor to move too.
            }
        }
        
        private void Floor0Btn_Click(object sender, EventArgs e) // event handler for when either the ground floor request button is pressed or
                                                                 // the groundfloor button on the control pannel.
        {
            if (!elevator.moving)
            {
                elevator.log.UpdateLog("Requested to Move to Floor 0", elevator.currentFloor, elevator.doorOpen, elevator.fDoorOpen);
                elevator.MoveToFloor(0);
            }
        }

        private void BtnLog_Click(object sender, EventArgs e)// makes the log visible or not visible
        {
            if(gBoxLog.Visible)
            {
                gBoxLog.Visible = false;
            }else
            {
            gBoxLog.Visible = true;

            elevator.log.DisplayData(); // calls the displaydata method in the log class to update the datagridview with uptodate data. 
            }
        }

    }


    public class Elevator // class to control the movement of the elevator and update of elevator status displays.
    {
        Timer animTimer; // declaring a varible of the type Timer.
        PictureBox[] components; // global arrays for the arrays passed into the contructor.
        Button[] buttons = new Button[4];
        TextBox[] statusBoxes;
        int newFloor; // global varible to stop the value passed into the movetofloor method.
        public Log log; // public varible of type Log class for refrencing to. public so that ElevatorSystems can also use it.
        public bool moving; // public bool varible so the Elevator systems class can check if the elevator is currently moving.
        public int currentFloor; // public varible so elevator systems class can call the updatelog method in the log class with this property as a parameter.
        public bool doorOpen; // boolean varible to know if the elevator door is open.
        public bool fDoorOpen; // boolean varible to know if the floor door is open.


        public Elevator(PictureBox[] pictureBoxes, TextBox[] txtBoxes, Button[] btns, DataGridView logDisplay, int startFloor) // constructor for the elevator class
                                                                                                                             // requiring several parameters. 
        {
            animTimer = new Timer(); // instantiating the timer class.
            animTimer.Interval = 100; // setting the timer interval to 100 miliseconds.
            components = pictureBoxes; // assigning the arrays passed in as parameters into the global arrays of the class.
            statusBoxes = txtBoxes;
            buttons = btns;
            currentFloor = startFloor; // sets the currentFloor to the start floor parameter.
            moving = false; // sets the moving bool to false.
            log = new Log(logDisplay); // instantinates the Log class with the datagridview as a parameter.
        }
        
        public void MoveToFloor(int newFloor) //look into bakcgorund worker remove sleep?
        {
            MoveElevator(this, EventArgs.Empty, currentFloor, newFloor); // calls the moveelevator event handler passing in the current floor and new floor.
            TurnLightsOn(); // calls the turnlightson method to change the backcolour of the buttons.
           
            
        }
        
        
        private void MoveElevator(object sender, EventArgs e, int curFloor, int nFloor) // An event handler method for the tick of the timer. 
                                                        // Checks which floor the elevator will be moving too and changes the tick event handler depending on
                                                        // if its going up or down.
        {
            newFloor = nFloor; // assigns the nfloor parameter to the global newfloor varible.
            log.UpdateLog("Moving to floor " + newFloor, currentFloor, doorOpen, fDoorOpen);
            moving = true; // sets the moving boolean to true.
            
            switch (newFloor) // switch to check which floor the elevator is moving to.
            {
                case 1: // if moving to floor 1.
                    animTimer.Tick -= MoveElevatorDown; // remove any possible moveelevatordown event handler from the timer tick.
                    animTimer.Tick += MoveElevatorUp; // add the moveelevatorup event handler to the timer tick.
                    animTimer.Start(); // starts the timer.
                    break; // breaks out of the switch.

                case 0:
                    
                    animTimer.Tick -= MoveElevatorUp;
                    animTimer.Tick += MoveElevatorDown;
                    animTimer.Start();
                    break;
            }       
        }

        private void MoveElevatorUp(object sender, EventArgs e) // event handler for the timer tick which moves the pictureboxes upwards.
        {
            if (components[0].Top> 20) // if the pictureboxes top property is > 20 pixels from the top of the animation groupbox.
            {
                foreach (PictureBox c in components) // loops through each item in the components array.
                {
                    c.Top -= 1; // -1 from the Top property for each picture box.
                }
            }
            else if(components[0].Top == 20) // if the pictureboxes top property is equal to 20.
            {
                UpdateFloor(); // call the updatefloor method.
                log.UpdateLog("Arrived at floor " + newFloor, currentFloor, doorOpen, fDoorOpen);
                log.UpdateLog("Opening Doors", currentFloor, doorOpen, fDoorOpen);
                animTimer.Tick += OpenDoors; // adds the opendoors event handler to the timer tick.
                animTimer.Tick -= MoveElevatorUp; // removes the moveelevatorup event handler.
            }
        }

        private void OpenDoors(object sender, EventArgs e) // event handler for the timer tick which moves the door pictureboxes to either side.
        {
            if (components[1].Left > 40) // if the pictureboxes left property is > 40 pixels from the left of the animation groupbox.
            {
                components[1].Left -= 1; // moves the left door to the left.
                components[2].Left += 1; // moves the right door to the right.
            }
            else if (components[1].Left == 40) // if the pictureboxes left property is equal to 40 pixels.
            {
                animTimer.Tick -= OpenDoors; // removes the opendoors event handler.
                animTimer.Tick += HoldElevatorDoors; // adds the holdelevatordoors event handler to the timer tick.
            }
        }
        
        private void HoldElevatorDoors(object sender, EventArgs e) //event handler for the timer tick to hold the doors open for 5 seconds.
        {
            doorOpen = true; // sets the doorOpen bool to true.
            fDoorOpen = true; // sets the fdoorOpen bool to true.
            log.UpdateLog("Doors Open", currentFloor, doorOpen, fDoorOpen);
            System.Threading.Thread.Sleep(5000); // causes the thread to sleep so the doors hold open.
            animTimer.Tick -= HoldElevatorDoors; // removes the holdelevatordoor event handler.
            log.UpdateLog("Closing Doors", currentFloor, doorOpen, fDoorOpen);
            animTimer.Tick += CloseDoors; // adds the closedoors event handler.
        }
        
        private void CloseDoors (object sender, EventArgs e) // event handler for closing the doors.
        {
            if (components[1].Left < 90) 
            {
                components[1].Left += 1;
                components[2].Left -= 1;
            }
            else if (components[1].Left == 90) // when doors are closed.
            {  
                animTimer.Tick -= CloseDoors; // removes the closedoor event hander from the timer tick.
                doorOpen = false;
                fDoorOpen = false;
                log.UpdateLog("Doors Closed", currentFloor, doorOpen, fDoorOpen);
                StopTimer(); //calls the stoptimer method.
            }
        }

        private void StopTimer() // method to stop the timer and turn of the button lights.
        {
            log.UpdateLog("Awaiting Request", currentFloor,  doorOpen, fDoorOpen);
            animTimer.Stop(); // calls the Timer class stop method.
            moving = false; // sets the moving boolean to false.
            TurnLightsOff(); // calls the turnlightsoff method.
        }

        private void MoveElevatorDown(object sender, EventArgs e) // event handler for the timer tick which moves the pictureboxes downwards.
        {
            if (components[0].Top <120) // if the pictureboxes top property is < 120 pixels from the top of the animation groupbox.
            {
                foreach(PictureBox c in components)
                {
                    c.Top += 1; // +1 to the Top property for each picture box.
                }
            }
            else if (components[0].Top ==120)
            {
                UpdateFloor();
                log.UpdateLog("Arrived at floor " + newFloor, currentFloor, doorOpen, fDoorOpen);
                log.UpdateLog("Opening Doors", currentFloor, doorOpen, fDoorOpen);

                animTimer.Tick -= MoveElevatorDown;
                animTimer.Tick += OpenDoors;
            }
        }

        private void UpdateFloor() // updates the current floor to the new floor.
        {
            switch (newFloor)
            {
                case 0:
                    currentFloor = 0;
                    break;
                case 1:
                    currentFloor = 1;
                    break;
                default:
                    currentFloor = 0;
                    break;
            }
            UpdateDisplay(); // calls the updatedisplay method.
        }

        public void UpdateDisplay() // updates the value in the statusboxes to show what floor the elevator is on.
        {
            foreach (TextBox d in statusBoxes) // foreach textbox in the statusboxes array.
            {
                d.Text = currentFloor.ToString(); // change the text property to the currentFloor value calling the ToString method as the textbox takes strings.
            }
        }

        private void TurnLightsOn() // changes the colour of the button to show the elevator is moving to that floor.
        {
            switch(newFloor)
            {
                case 0:
                    buttons[0].BackColor = Color.LightGreen; // sets the backcolor property of the button to lightgreen.
                    buttons[2].BackColor = Color.LightGreen;
                    break;
                case 1:
                    buttons[1].BackColor = Color.LightGreen;
                    buttons[3].BackColor = Color.LightGreen;
                    break;
            }
        }

        private void TurnLightsOff() // changes the colour of the button back to show the elevator is not moving anywhere.
        {
            switch (newFloor)
            {
                case 0:
                    buttons[0].BackColor = Color.LightGray;
                    buttons[2].BackColor = Color.LightGray;
                    break;
                case 1:
                    buttons[1].BackColor = Color.LightGray;
                    buttons[3].BackColor = Color.LightGray;
                    break;
            }
        }
    }


    public class Log // class to handle the connection to the database.
    {
        OleDbConnection connection; // declaring an OleDbConnection. Global varibles to be used by multiple methods.
        OleDbDataAdapter adapter; // declaring an OleDbAdapter.
        string connectionString; // declaring a string for the connection. 
        DataSet ds; // delcaring a dataset to hold the data from the database.
        DataGridView logDisplay; //declaring a datagridview varible to hold the datagridview passed into the constuctor.


        public Log(DataGridView lDisplay) // constructor for the log class with a parameter for the datagridview.
        {
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source = ..\..\..\Resources\Log.accdb"; // assigning the connection string for connecting to the database.
            connection = new OleDbConnection(connectionString); // creating a new connection with the connection string.
            ds = new DataSet(); // instaniates a new DataSet.
            logDisplay = lDisplay; // assigns the lDisplay parameter to the global logDisplay varible.

            ConnectToDB(); // calls the ConnectToDB method.
        }

        public void ConnectToDB() // connects to the database and fills the dataset.
        {
            connection.Open(); // opens the connection.
            try // try & catch exception handling.
            {
            adapter = new OleDbDataAdapter("select * from Log", connection); // creates the adapter with a Select SQL quiery and the connection as parameters.
            adapter.Fill(ds);  // fills the dataset with data from the database.
            }
            catch ( Exception ex) // if it encounters an exception.
            {
                MessageBox.Show(ex.ToString()); // create a messagebox with the exceptions string refrence.
            }
        }

        public void DisplayData() // updates the datagridview with the data in the dataset.
        {
            logDisplay.DataSource = ds.Tables[0]; // assigns the datasource property of the datagridview object with the data in the first table of the dataset.
        }

        public void UpdateLog(string status, int floor, bool eDoor, bool fDoor) // updates the dataset with a new row.
        {
            DataRow row = ds.Tables[0].NewRow(); // declaring a new Datarow in the first table of the dataset.
            row["Log_Time"] = DateTime.Now.ToString("HH:mm:ss"); // sets the "Log_Time" column value to the current time.
            row["Elevator_Status"] = status; // sets the status column to the string parameter.
            row["Floor_Number"] = floor; // updates the floor_number column to the current floor that the elevator is on.
            row["Elevator_Door_Open"] = eDoor; // updates the elevator_door_open column to the eDoor parameter.
            row["Floor_Door_Open"] = fDoor; // updates the elevator_door_open column to the eDoor parameter.

            ds.Tables[0].Rows.Add(row); // adds the new row to the datasets first table.
            UpdateDB(); // calls the updateDB method.
        }

        public void UpdateDB() // save the changes from the dataset to the database.
        {
            try
            {
                DataSet logChanges = ds.GetChanges(); // declaring a new dataset equal to the changes made in the other dataset.
                OleDbCommandBuilder command = new OleDbCommandBuilder(adapter); // delcaring a OleDBCommandBuilder using the adapter as a parameter. 
                                                                                // The builder can generate SQL commands from the Select command entered previously.
                adapter.InsertCommand = command.GetInsertCommand(); // assigning the adapters insertcommand property to the commandbuilder's 
                                                                    // getinsertcommand method's return value. 
                adapter.Update(logChanges); // calls the update method with the new dataset. not possible without the command builder.
                ds.Tables[0].AcceptChanges(); // accepts the changes made to the dataset so that the next time it doesnt update old data with the new data.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void DisconnentFromDB() // method to disconnect from the database.
        {
            connection.Close(); // closes the connect to the database.
        }
    }
}

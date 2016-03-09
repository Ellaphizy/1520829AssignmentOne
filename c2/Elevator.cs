using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;            // for connection to database

namespace c2
{
    public partial class Form1 : Form
    {
        private int lift_status;
        public bool btn = true;
        private string direction;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)     // form
        {
            lift_status = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void up_Click(object sender, EventArgs e)  // floor 0 button
        {
            
            if (lift_status == 0)
            {
                if (PictureBox.Top > 0)
                {
                    
                    Floor0Doors.Start();            // Open and close floor 0 doors
                }
                label.Text = "0";
            }
            else if (lift_status == 1)
            {

                if (PictureBox.Top <= 300)
                {
                    if ((panel4.Width >= 138) && (panel5.Width <= 150))
                    {
                        lift_status = 0;
                       
                        LiftDown.Start();       // lift goes down
                        FloorOneDoors.Stop();   // stop timer1 door
                        direction = "Lift went down";
    
                    }

                    label.Text = "0";

                    Level1.BackColor = Color.AliceBlue;
                    Level0.BackColor = Color.AliceBlue;
                    SaveEvent();    // function call of a method that saves event to the database
                }
               
            }
         
        }

        private async void timer1_Tick(object sender, EventArgs e)   // floor 0 doors
        {
            if (panel2.Top < 300)
            {
                if (btn == true)
                {
                    if (panel2.Width <= 11)
                    {
                       
                        btn = false;
                    }
                    else
                    {
                        await Task.Delay(1000);                 // delay doors. works with the keyword "async"
                        panel2.Width = panel2.Width - 1;            // Open the doors
                        panel3.Width = panel3.Width - 1;
                        panel3.Left = panel3.Left + 1;
                        
                    }

                }
                else
                {
                    if (panel2.Width >= 138)
                    {
                        Floor0Doors.Stop();             // stop floor 0 doors
                        btn = true;
                    }

                    else
                    {
                        
                        panel2.Width = panel2.Width + 1;            // close doors
                        panel3.Width = panel3.Width + 1;
                        panel3.Left = panel3.Left - 1;
          
                    }

                }
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)   // lift goes up
        {

            if (PictureBox.Top > 0)
            {
                lift_status = 1;
                PictureBox.Top = PictureBox.Top - 5;            // moves up by 5
               
               ProgressBar.Top = ProgressBar.Top - 5;
       
            }
            else if (PictureBox.Top < 300)
            {
 
                Floor1Doors.Start();        // when lift is up, open and close the floor1 doors

            }
          
        }

        private async void timer3_Tick(object sender, EventArgs e)   // floor 1 doors
        {

            if (PictureBox.Top < 300)
            {
                if (btn == true)
                {
                    if (panel4.Width <= 11)
                    {
                        
                        btn = false;
                    }
                    else
                    {
                        await Task.Delay(1500);     // delay doors. works with the keyword "async"
                        panel4.Width = panel4.Width - 1;            // open doors
                        panel5.Width = panel5.Width - 1;
                        panel5.Left = panel5.Left + 1;
                        LiftUp.Stop();                  // stop the timer for lift up
                          
                    }
                    

                }
                else
                {
                    if (panel4.Width >= 138)
                    {
                        Floor1Doors.Stop();             // stop the timer for floor 1 doors
                        btn = true;
                    }

                    else
                    {
                        
                        panel4.Width = panel4.Width + 1;        // close doors
                        panel5.Width = panel5.Width + 1;
                        panel5.Left = panel5.Left - 1;
                       
                    }

                }

            }

        }

        private void timer4_Tick(object sender, EventArgs e)    // lift goes down
        {
            if (PictureBox.Top < 290)
            {
               
                PictureBox.Top = PictureBox.Top + 6;            // move down by 6
                
                ProgressBar.Top = ProgressBar.Top + 5;
                
                lift_status = 1;
               
            }
            else if ((PictureBox.Top > 0))
            {
                FloorZeroDoors.Start();         // stop the timer for floor 0
                lift_status = 0;
               
            }
            
        }

        private void down_Click(object sender, EventArgs e)   // floor 1
        {

            if (lift_status == 0)
            {
                if (PictureBox.Top > 0)
                {
                    lift_status = 1;
                    LiftUp.Start();         // lift goes up if it was in floor 0
                    direction = "Lift went up";
                }

                SaveEvent();  // function call of a method that saves event to the database

            }

            else if (lift_status == 1)
            {
  
                if (PictureBox.Top <= 300)
                {
                    if ((panel4.Width >= 138) && (panel5.Width <= 150))
                    {
                       
                        Floor1Doors.Start();        // stop the timers for floor 1 doors
                        
                        FloorOneDoors.Stop();
   
                    }

                    label.Text = "1";
                    Level1.BackColor = Color.AliceBlue;
                    Level0.BackColor = Color.AliceBlue;
                }

            }
           
        }

        private async void timer5_Tick(object sender, EventArgs e)      // floor 1 doors
        {
            if (PictureBox.Top < 300)
            {
                if (btn == true)
                {
                    if (panel4.Width <= 11)
                    {
                       
                        btn = false;
                    }
                    else
                    {
                        await Task.Delay(1000);         // delay doors. works with the keyword "async"
                        panel4.Width = panel4.Width - 1;            // Open doors
                        panel5.Width = panel5.Width - 1;
                        panel5.Left = panel5.Left + 1;
                        LiftDown.Stop();
      
                    }
                }
                else
                {
                   
                    if (panel4.Width >= 138)
                    {
                        LiftDown.Stop();        // stop the timer for lift going down
                        btn = true;
                    }

                    else
                    {
                      
                        panel4.Width = panel4.Width + 1;        // close doors
                        panel5.Width = panel5.Width + 1;
                        panel5.Left = panel5.Left - 1;
 
                    }

                }

            }

        }

        private async void timer6_Tick(object sender, EventArgs e)  // floor 0 doors
        {
            if (PictureBox.Top < 300)
            {
                if (btn == true)
                {
                    if (panel2.Width <= 11)
                    {
                        
                        btn = false;
                    }
                    else
                    {
                        await Task.Delay(1000);         // delay doors. works with the keyword "async"
                        panel2.Width = panel2.Width - 1;        // open doors
                        panel3.Width = panel3.Width - 1;
                        panel3.Left = panel3.Left + 1;
                        LiftDown.Stop();                    // stop timer of lift going down
                     }

                }
                else
                {
                   

                    if (panel2.Width >= 138)
                    {
                        FloorZeroDoors.Stop();          // stop the timer for floor 0 doors
                        btn = true;
                    }

                    else
                    {
                       
                        panel2.Width = panel2.Width + 1;            // close doors
                        panel3.Width = panel3.Width + 1;
                        panel3.Left = panel3.Left - 1;
                        
                    }

                }

            }
 
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Level1_Click(object sender, EventArgs e)
        {
     
            if (PictureBox.Top >0)
            {
 
                if ((panel2.Width >= 138) && (panel3.Width <= 150))
                {
                    LiftUp.Start();         // lift goes up
                 
                    Floor1Doors.Stop();     // stop floor 1 doors
                    lift_status = 1;
                    direction = "Lift went up";

                    SaveEvent();        // function call of a method that saves event to the database
                }
                label.Text = "1";
                Level1.BackColor = Color.Red;
                Level0.BackColor = Color.AliceBlue;
            }

      
        }

        private void Level0_Click(object sender, EventArgs e)           // button 0
        {
            if (PictureBox.Top < 300)
            {

                if ((panel4.Width >= 138) && (panel5.Width <= 150))
                {
                    LiftDown.Start();           // lift goes down
                    lift_status = 0;
                    FloorOneDoors.Stop();           // stop timer for floor 1
                    direction = "Lift went down";
                    
                }
                
                label.Text = "0";
                Level0.BackColor = Color.Red;
                Level1.BackColor = Color.AliceBlue;

                SaveEvent();        // function call of a method that saves event to the database
            }
            
        }

        public void SaveEvent()     // a method to save event to database
        {
            try
            {
                // save events to database

                string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source =LogEvent.accdb";     // database connection string

                String dateTime = DateTime.Now.ToString("hh:mm:ss tt");             // time
                String dateDay = DateTime.Now.ToString("dd:mm:yyyy");               // date


                OleDbConnection conn = new OleDbConnection(dbconnection);       // connect to database

                conn.Open();        // open connection

                OleDbCommand InsertCommand = new OleDbCommand("INSERT INTO Logs ([Status],[Showtime],[ShowDate],[ShowDirection]) VALUES ('" + lift_status + "','" + dateTime + "','" + dateDay + "','" + direction + "');", conn);  // sql command

                InsertCommand.ExecuteNonQuery();

                conn.Close();       // close connection

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
   
     
        private void button2_Click(object sender, EventArgs e)          // display from database
        {
            string connectionString = null;
            OleDbConnection connection;
            OleDbDataAdapter oledbAdapter;
            DataSet ds = new DataSet();
             
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source = LogEvent.accdb";   // database connection string
            connection = new OleDbConnection(connectionString);         // connect to database
            try
            {
                connection.Open();      // open connection
                oledbAdapter = new OleDbDataAdapter("SELECT *from Logs", connection);  
                oledbAdapter.Fill(ds);          // fill dataset
                oledbAdapter.Dispose();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                   
                    ListViewItem myList = new ListViewItem(row["ID"].ToString());        // save the rows into the list view columns
                    myList.SubItems.Add(row["Status"].ToString());
                    myList.SubItems.Add(row["Showtime"].ToString());
                    myList.SubItems.Add(row["ShowDate"].ToString());
                    myList.SubItems.Add(row["ShowDirection"].ToString());

                    Listview.Items.Add(myList);
                }

                Listview.Items.Clear();         // update the list view

                foreach (DataRow row in ds.Tables[0].Rows)
                {

                    ListViewItem myList = new ListViewItem(row["ID"].ToString());        // save the rows into the list view columns
                    myList.SubItems.Add(row["Status"].ToString());
                    myList.SubItems.Add(row["Showtime"].ToString());
                    myList.SubItems.Add(row["ShowDate"].ToString());
                    myList.SubItems.Add(row["ShowDirection"].ToString());

                    Listview.Items.Add(myList);
                }

                connection.Close();     // close connection
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void button3_Click(object sender, EventArgs e)          // close form
        {
            this.Close();
        }
    }
}

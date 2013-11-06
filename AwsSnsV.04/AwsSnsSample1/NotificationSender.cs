using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Amazon;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using System.Timers;
//using System.Data.SqlClient;
//using System.Threading;


namespace AwsSnsSample1
{
  
    public partial class NotificationSender : Form
    {


        public NotificationSender()
        {
            InitializeComponent();
          
         
        }

        private void DataString_TextChanged(object sender, EventArgs e)
        {

        }



        private void DataString_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NotificationSender_Load(object sender, EventArgs e)
        {

            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox
            toolTip1.SetToolTip(this.DataString, "Connection Path to DataBase: Example  Data Source=KAMI-PC\\MYSQL;Initial Catalog=saleslogix_eval;Integrated Security=True;Asynchronous Processing=true");
            toolTip1.SetToolTip(this.TimeBox, "DataBase Check Timer value of 1 = 1 minute: Defualt value = 5");

            //populates list with Topics will make into easy to use function later

            AmazonSimpleNotificationService sns = new AmazonSimpleNotificationServiceClient(RegionEndpoint.USWest2);
            ListSubscriptionsRequest ListSubscriptionsobject = new ListSubscriptionsRequest();
            ListSubscriptionsResult listSubResults;

            do
            {
                listSubResults = sns.ListSubscriptions(ListSubscriptionsobject).ListSubscriptionsResult;
      
                foreach (var Subscription in listSubResults.Subscriptions)
                {
                       comboBox1.Items.Add(Subscription.Endpoint);
                }
                listSubResults.NextToken = listSubResults.NextToken;
            } while (listSubResults.NextToken != null);
   
      
        }
    

        private void MessageText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PublishFrm_Click(object sender, EventArgs e)
        {
            SendMessage settingsForm = new SendMessage();
            // Show the settings form
            settingsForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Subscriber CreateSub = new Subscriber();

            CreateSub.Show();
        }

        private void TopicFrm_Click(object sender, EventArgs e)
        {
            CreateTopic CreatForm = new CreateTopic();
            CreatForm.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    

        private void StartBt_Click(object sender, EventArgs e)
        { 
            
            on = true;
            if (on == true)
            {
                StartBt.Visible = false;
            }
            DelayFunct();
            //MainFunction();
           
       

        }

        void MainFunction()
        {
            NotificationObject notifyObject = new NotificationObject();
            //reminder comment this string out before giveing project to Client.
            // string connectionString = "Data Source=KAMI-PC\\MYSQL;Initial Catalog=saleslogix_eval;Integrated Security=True";
            string connectionString = "Server=localhost\\sqlexpress;Database=saleslogix_eval;User Id=sysdba;Password=SLXMa$t3r;MultipleActiveResultSets=true;";
            //MessageBox.Show(connectionString);
            //string connectionString = DataString.Text;
            SqlConnection thisConnection = new SqlConnection(connectionString);
            //SqlCommand SelectCommandName = new SqlCommand("SELECT * FROM [sysdba].[NOTIFICATION]", thisConnection);
            SqlCommand SelectCommandNameobject = new SqlCommand("Select * from sysdba.NOTIFICATION Where ISActive = 'T'", thisConnection);

            thisConnection.Open();
            int columnNumber = 0;
            string ColumnText;
            string sMessage;
            Boolean Loop = true;
            Boolean RecordLoop = true;
            List<string> list = new List<string>();

            SqlDataReader readerObj = SelectCommandNameobject.ExecuteReader();
            while (readerObj.Read())  //Looping through all notifications that are active
            {
                //MessageBox.Show(readerObj["NAME"].ToString());
                notifyObject.Message = readerObj["MESSAGETEXT"].ToString();
                notifyObject.Query = readerObj["QUERY"].ToString();
                notifyObject.Name = readerObj["NAME"].ToString();

                
                //"Select  SalesPotential, Description, UserName, OpportunityID  from SYSDBA.Opportunity O INNER JOIN SYSDBA.Userinfo U on O.AccountManagerID = U.UserID Where OpportunityID NOT in (Select SourceID as OpportunityID from SYSDBA.NotificationLog)"
                SqlCommand SelectCommandName = new SqlCommand(notifyObject.Query, thisConnection);
                SqlDataReader reader = SelectCommandName.ExecuteReader();

                while (reader.Read())   //Looping through all records that meet notification criteria
                {
                    notifyObject.Id = reader["SourceID"].ToString();
                    columnNumber = 0;
                    RecordLoop = true;
                    while (RecordLoop == true)  //Looping through columns of a particular notification
                    {
                        try
                        {
                            ColumnText = reader.GetName(columnNumber).ToString();
                            list.Add(reader[ColumnText].ToString());
                        }
                        catch
                        {
                            //MessageBox.Show("Error");
                            RecordLoop = false;
                            columnNumber = 0;
                        }
                        // reader.Close();
                        columnNumber++;
                    }

                    string output = String.Format(notifyObject.Message, list.ToArray());
                    //



                    //list.Clear();
                    SqlCommand GetId = new SqlCommand("select TOP 1 CAST(NotificationlogID AS INT) as MaxValue FROM notificationlog order by MaxValue desc", thisConnection);
                    SqlDataReader ReadId = GetId.ExecuteReader();
                    ReadId.Read();
                    long temp;
                    try
                    {
                        temp = Convert.ToInt64(ReadId["MaxValue"].ToString());
                    }
                    catch
                    {
                        temp = 1;
                        sMessage = Convert.ToString(temp);
                        MessageBox.Show(sMessage);

                    }
                    temp = temp + 1;

                    ReadId.Close();
                    try
                    {
                        SqlCommand insertCommand = new SqlCommand("Insert SYSDBA.NotificationLog  values('" + temp + "','ADMIN', '10/23/2013 04:00:00 PM', 'ADMIN', '10/23/2013 04:00:00 PM', 'QDEMOA000FRW', '" + notifyObject.Id + "'  ,'UDEMO00000F')", thisConnection);
                        insertCommand.ExecuteNonQuery();
                    }
                    catch
                    {
                        sMessage = Convert.ToString(temp);
                        MessageBox.Show(sMessage + ", " + notifyObject.Id);
                        temp = temp + 1;
                    }

                    // string output = String.Format("New $ {0} Opportunity {1}, for {2} was just created.", notifyObject.Oper, notifyObject.Description, notifyObject.name);
                    AmazonSimpleNotificationService sns = new AmazonSimpleNotificationServiceClient(RegionEndpoint.USWest2);
                    try
                    {
                        sns.Publish(new PublishRequest
                        {

                            // will add , to currency later not enought time to fix it before demo.
                            Subject = notifyObject.Name,
                            Message = output,
                            //TargetArn = comboBox1.SelectedItem.ToString()
                            TargetArn = "arn:aws:sns:us-west-2:723654957135:endpoint/APNS/SaleslogixNotify/67aa5284-331b-33ab-91d3-3c956f157e45"
                        });
                        //MessageBox.Show("Sent:" + output);
                    }
                    catch
                    {
                        MessageBox.Show(output);
                    }

                }
                
                reader.Close();//+ notifyObject.QueryGet + (CreateUser, CreateDate,ModifyUser, ModifyDate, NotificationID, SourceID, TargetID)
            }
            //MessageBox.Show("Done");
            readerObj.Close();
        }

        Boolean on = false;
      void DelayFunct()
      { 
          System.Timers.Timer timer = new System.Timers.Timer();
           //int time = Convert.ToInt32(TimeBox.Text);
            timer.Interval = 10000;
      
              timer.Enabled = true;

              timer.Elapsed += (s, e) =>
              {
                  if (on == false)
                  {
                      timer.Close();
                  }
                  else
                  {
                      timer.Stop();
                      MainFunction();
                      timer.Start();
                  }
              };
        
                 
          }

      
      
      private void label3_Click(object sender, EventArgs e)
      {

      }

      private void TimeBox_TextChanged(object sender, EventArgs e)
      {

      }

  

      private void Stopbt_Click_1(object sender, EventArgs e)
      {
          on = false;
          StartBt.Visible = true;
      }


    } 
}
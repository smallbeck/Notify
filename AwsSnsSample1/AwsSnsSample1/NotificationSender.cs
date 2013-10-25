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
using System.Data.SqlClient;
using System.Threading;
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
            ListTopicsRequest listTopicsRequest = new ListTopicsRequest();
            ListTopicsResult listTopicsResult;
            do
            {
                listTopicsResult = sns.ListTopics(listTopicsRequest).ListTopicsResult;
                foreach (var topic in listTopicsResult.Topics)
                {
                    comboBox1.Items.Add(topic.TopicArn);
                }
                listTopicsRequest.NextToken = listTopicsResult.NextToken;
            } while (listTopicsResult.NextToken != null);


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
    
        //will be used later
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void SetBt_Click(object sender, EventArgs e)
        {

        }

        private void StartBt_Click(object sender, EventArgs e)
        {
            MainFunction();
        }

      void MainFunction()
        {
            NotificationObject notifyObject = new NotificationObject();
            //reminder comment this string out before giveing project to Client.
          // string connectionString = "Data Source=KAMI-PC\\MYSQL;Initial Catalog=saleslogix_eval;Integrated Security=True";
           string connectionString = DataString.Text;
            SqlConnection thisConnection = new SqlConnection(connectionString);
            //SqlCommand SelectCommandName = new SqlCommand("SELECT * FROM [sysdba].[NOTIFICATION]", thisConnection);
            SqlCommand SelectCommandName = new SqlCommand("Select  OpportunityID, Description, SalesPotential,UserName, EstimatedClose,AccountManagerID as UserID from SYSDBA.Opportunity O INNER JOIN SYSDBA.Userinfo U on O.AccountManagerID = U.UserID Where OpportunityID NOT in (Select SourceID as OpportunityID from SYSDBA.NotificationLog)", thisConnection);

            thisConnection.Open();

       
            SqlDataReader reader = SelectCommandName.ExecuteReader();
            reader.Read();
            notifyObject.Oper = reader["SalesPotential"].ToString();
            reader.Close();
            reader = SelectCommandName.ExecuteReader();
            reader.Read();
            notifyObject.name = reader["UserName"].ToString();
            reader.Close();


            reader = SelectCommandName.ExecuteReader();
            reader.Read();
            notifyObject.OpportunityID = reader["OpportunityID"].ToString();
            reader.Close();


            reader = SelectCommandName.ExecuteReader();
            reader.Read();
            notifyObject.Description = reader["Description"].ToString();
            reader.Close();


            reader = SelectCommandName.ExecuteReader();
            reader.Read();
            notifyObject.UserId = reader["UserID"].ToString();
            reader.Close();
           // this is temp notificatin log Id will make it proper in later version of program.
            notifyObject.TempId = notifyObject.TempId +1;
            reader = SelectCommandName.ExecuteReader();
            reader.Read();
            notifyObject.OpportunityID = reader["OpportunityID"].ToString();
            reader.Close();//+ notifyObject.QueryGet + (CreateUser, CreateDate,ModifyUser, ModifyDate, NotificationID, SourceID, TargetID)
            SqlCommand insertCommand = new SqlCommand("Insert SYSDBA.NotificationLog  values('" + notifyObject.OpportunityID + "','ADMIN', '10/23/2013 04:00:00 PM', 'ADMIN', '10/23/2013 04:00:00 PM', 'QDEMOA000FRW', '" + notifyObject.OpportunityID + "'  ,'UDEMO00000F')", thisConnection);

            insertCommand.ExecuteNonQuery();
            AmazonSimpleNotificationService sns = new AmazonSimpleNotificationServiceClient(RegionEndpoint.USWest2);
            sns.Publish(new PublishRequest
            {
                // will add , to currency later not enought time to fix it before demo.
                Subject = "New Opportunity",
                Message = "New $" + notifyObject.Oper + " Opportunity, " + notifyObject.Description + " for " + notifyObject.name + " was just created",
                TopicArn = comboBox1.SelectedItem.ToString()
            });
         // Insert into NotificationLog (NotificationLogID, CreateUser, CreateDate,ModifyUser, ModifyDate, NotificationID, SourceID, TargetID) values('000000000001', 'ADMIN', '10/23/2013 04:00:00 PM', 'ADMIN', '10/23/2013 04:00:00 PM', 'QDEMOA000FRW', 'ODEMOA00001U','UDEMO00000F')
          
        }

      private void label3_Click(object sender, EventArgs e)
      {

      } 
    } 
}
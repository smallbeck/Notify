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

namespace AwsSnsSample1
{
    public partial class SendMessage : Form
    {
        public SendMessage()
        {
            InitializeComponent();
        }

        private void NoDatabt_Click(object sender, EventArgs e)
        {
            try
            {
                AmazonSimpleNotificationService sns = new AmazonSimpleNotificationServiceClient(RegionEndpoint.USWest2);
                sns.Publish(new PublishRequest
                {
                    Subject = subjectBox.Text,
                    Message = MessageBox.Text,
                    TargetArn = TopicList.SelectedItem.ToString()
                });
            }
            catch
            {
                MessageBox.Show();
            }
        }

        private void TopicList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SendMessage_Load(object sender, EventArgs e)
        {
            AmazonSimpleNotificationService sns = new AmazonSimpleNotificationServiceClient(RegionEndpoint.USWest2);
            ListSubscriptionsRequest ListSubscriptionsobject = new ListSubscriptionsRequest();
            ListSubscriptionsResult listSubResults;

            do
            {
                listSubResults = sns.ListSubscriptions(ListSubscriptionsobject).ListSubscriptionsResult;
      
                foreach (var Subscription in listSubResults.Subscriptions)
                {
                    TopicList.Items.Add(Subscription.Endpoint);
                }
                listSubResults.NextToken = listSubResults.NextToken;
            } while (listSubResults.NextToken != null);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

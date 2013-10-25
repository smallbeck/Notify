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
            AmazonSimpleNotificationService sns = new AmazonSimpleNotificationServiceClient(RegionEndpoint.USWest2);
            sns.Publish(new PublishRequest
            {
                Subject = subjectBox.Text,
                Message = MessageBox.Text,
                TopicArn = TopicList.SelectedItem.ToString()
            });
        }

        private void TopicList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SendMessage_Load(object sender, EventArgs e)
        {
            AmazonSimpleNotificationService sns = new AmazonSimpleNotificationServiceClient(RegionEndpoint.USWest2);
            ListTopicsRequest listTopicsRequest = new ListTopicsRequest();
            ListTopicsResult listTopicsResult;
            do
            {
                listTopicsResult = sns.ListTopics(listTopicsRequest).ListTopicsResult;
                foreach (var topic in listTopicsResult.Topics)
                {
                    TopicList.Items.Add(topic.TopicArn);
                }
                listTopicsRequest.NextToken = listTopicsResult.NextToken;
            } while (listTopicsResult.NextToken != null);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

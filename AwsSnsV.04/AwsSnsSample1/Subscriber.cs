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
    public partial class Subscriber : Form
    {
        public Subscriber()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TopicList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AmazonSimpleNotificationService sns = new AmazonSimpleNotificationServiceClient(RegionEndpoint.USWest2);

            sns.Subscribe(new SubscribeRequest
            {
                TopicArn = TopicList.SelectedItem.ToString(),
                    Protocol = "email",
                   Endpoint = emailBox.Text
            });
        }

        private void Subscriber_Load(object sender, EventArgs e)
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
    }
}

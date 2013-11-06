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
    public partial class CreateTopic : Form
    {
        public CreateTopic()
        {
            InitializeComponent();
        }

        private void maketopic_Click(object sender, EventArgs e)
        {
            AmazonSimpleNotificationService sns = new AmazonSimpleNotificationServiceClient(RegionEndpoint.USWest2);

            try
            {
                // Create topic

                string topicArn = sns.CreateTopic(new CreateTopicRequest
                {
                    Name = TopicNamebox.Text
                }).CreateTopicResult.TopicArn;

                //// Set display name to a friendly value

                sns.SetTopicAttributes(new SetTopicAttributesRequest
                {
                    TopicArn = topicArn,
                    AttributeName = "DisplayName",
                    AttributeValue = "Sample Notifications"
                });

                this.Hide();
            }
            catch (AmazonSimpleNotificationServiceException ex)
            {

            }
        }

        private void CreateTopic_Load(object sender, EventArgs e)
        {

        }
    }
}

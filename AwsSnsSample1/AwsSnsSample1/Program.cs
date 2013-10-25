
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;
namespace AwsSnsSample1
{
   
        static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NotificationSender());
    
            
        }
    }
          
        
    }
        
     

  
//                Console.WriteLine("Deleting topic...");
//                sns.DeleteTopic(new DeleteTopicRequest
//                {
//                    TopicArn = topicArn
//                });
//            }

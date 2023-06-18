using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form1 : Form
    {
        private HashSet<SendViaEmail> emailSubscriptionSet;
        private HashSet<SendViaMobile> mobileSubscriptionSet;
        private Publisher pub;
        NotificationPublisher notificationPublisherForm;


        public Form1()
        {
            InitializeComponent();

            emailSubscriptionSet = new HashSet<SendViaEmail>();
            mobileSubscriptionSet = new HashSet<SendViaMobile>();
            pub = new Publisher();
            notificationPublisherForm = new NotificationPublisher(pub);
        }




        private void manageSubscriptionBtn_Click(object sender, EventArgs e)
        {
            ManageSubscriptionForm frm = new ManageSubscriptionForm(this);
            frm.ShowDialog();
        }



        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        internal void SetMainStatusLabel(string newLabel)
        {
            this.mainStatusLabel.Text = newLabel;
        }



        internal void SetPublishBtn(bool shouldEnablePublishBtn)
        {
            this.publishNotificationBtn.Enabled = shouldEnablePublishBtn;
        }



        private void publishNotificationBtn_Click(object sender, EventArgs e)
        {           
            this.notificationPublisherForm.ShowDialog();

        }



        public void OnSubscriptionProcessed()
        {
            int numOfSubscribers = 0;

            foreach (var item in this.emailSubscriptionSet)
            {
                ++numOfSubscribers;
            }

            foreach (var item in this.mobileSubscriptionSet)
            {
                ++numOfSubscribers;
            }

            // Enable / disable the publishNotificationBtn.
            publishNotificationBtn.Enabled = false;

            if (numOfSubscribers > 0)
            {
                publishNotificationBtn.Enabled = true;
            }

        }


        public HashSet<SendViaEmail> GetSubscribedEmails()
        {
            return this.emailSubscriptionSet;
        }



        public HashSet<SendViaMobile> GetSubscribedMobiles()
        {
            return this.mobileSubscriptionSet;
        }



        public Publisher GetPublisher()
        {
            return pub;
        }



        public NotificationPublisher GetNotificationPublisherForm()
        {
            return this.notificationPublisherForm;
        }
    }
}

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
    public partial class ManageSubscriptionForm : Form
    {
        Form1 mainForm;
        HashSet<SendViaEmail> emailSubscriptionSet;
        HashSet<SendViaMobile> mobileSubscriptionSet;
        Publisher publisher;
        NotificationPublisher notificationPublisherForm;

        public ManageSubscriptionForm(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.emailSubscriptionSet = mainForm.GetSubscribedEmails();
            this.mobileSubscriptionSet = mainForm.GetSubscribedMobiles();
            this.publisher = mainForm.GetPublisher();
            this.notificationPublisherForm = mainForm.GetNotificationPublisherForm();
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void subscribeBtn_Click(object sender, EventArgs e)
        {
            resetLabels();

            // Subscribe email.
            if (notifyByEmailCheckBox.Checked)
            {
                processAction("subscribe", "email", emailTextBox.Text, emailResultLabel);
            }


            // Subscribe mobile.
            if (notifyBySmsCheckBox.Checked)
            {
                processAction("subscribe", "mobile", phoneTextBox.Text, phoneResultLabel);
            }
        }



        private void processAction(string processType, string contactType, string contact, Label resultLabel)
        {

            SubscriptionResult processResult;

            if (processType.Equals("subscribe"))
            {
                // Subscribe.
                processResult = ProcessSubscription(contactType, contact);
            }
            else
            {
                // Unsubscribe.
                processResult = ProcessUnsubscription(contactType, contact);
            }


            // If result is ok.
            if (processResult.IsSuccessful)
            {
                resultLabel.ForeColor = Color.Green;
            }


            // Set label.
            resultLabel.Text = processResult.ResultMsg;


            // Pseudo-event
            this.mainForm.OnSubscriptionProcessed();
        }



        public SubscriptionResult ProcessUnsubscription(string subscriptionType, string contact)
        {
            bool isWholeProcessOk = false;
            string resultMsg = "";

            // Validate contact.
            bool isContactValid = MyValidator.validate(subscriptionType, contact);


            // If contact is invalid, return..
            if (!isContactValid)
            {
                resultMsg = $"Invalid {subscriptionType}.";

                return new SubscriptionResult(isWholeProcessOk, resultMsg);
            }


            // If contact exists, proceed unsubscription.
            if (DoesContactExistInSet(subscriptionType, contact))
            {                

                if (subscriptionType.Equals("email"))
                {
                    // Unsubscribe from publisher and remove from specific subscriptionSet.
                    var subscription = this.ReferenceEmailSubscription(contact);
                    emailSubscriptionSet.Remove(subscription);
                    subscription.Unsubscribe(publisher);
                }
                else
                {
                    // Unsubscribe from publisher and remove from specific subscriptionSet.
                    var subscription = this.ReferenceMobileSubscription(contact);
                    mobileSubscriptionSet.Remove(subscription);
                    subscription.Unsubscribe(publisher);

                }

                // Successful subscription result.
                isWholeProcessOk = true;
                resultMsg = $"Succesfully unubscribed {contact}!";
            }
            else
            {
                resultMsg = $"Oops, {contact} does not exist.";

            }


            // Return.
            return new SubscriptionResult(isWholeProcessOk, resultMsg);
        }





        public SubscriptionResult ProcessSubscription(string subscriptionType, string contact)
        {
            bool isWholeProcessOk = false;
            string resultMsg = "";

            // Validate contact.
            bool isContactValid = MyValidator.validate(subscriptionType, contact);


            // If contact is invalid, return..
            if (!isContactValid)
            {
                resultMsg = $"Invalid {subscriptionType}.";

                return new SubscriptionResult(isWholeProcessOk, resultMsg);
            }


            // If contact already exists, return.
            if (DoesContactExistInSet(subscriptionType, contact))
            {
                resultMsg = $"Oops, {contact} already exists.";
            }
            else
            {
                // Add to specific subscriptionSet and subscribe to publisher.
                if (subscriptionType.Equals("email"))
                {
                    // For email.                    
                    var subscription = new SendViaEmail(contact, this.notificationPublisherForm);
                    emailSubscriptionSet.Add(subscription);
                    subscription.Subscribe(publisher);
                }
                else
                {
                    // For mobile.                    
                    var subscription = new SendViaMobile(contact, this.notificationPublisherForm);
                    mobileSubscriptionSet.Add(subscription);
                    subscription.Subscribe(publisher);

                }

                // Successful subscription result.
                isWholeProcessOk = true;
                resultMsg = $"Succesfully subscribed {contact}!";

            }


            // Return.
            return new SubscriptionResult(isWholeProcessOk, resultMsg);
        }



        public bool DoesContactExistInSet(string subscriptionType, string contact)
        {

            if (subscriptionType.Equals("email"))
            {
                var subscriptionSet = this.emailSubscriptionSet;

                foreach (var subscription in subscriptionSet)
                {
                    if (subscription.Contact.Equals(contact))
                    {
                        return true;
                    }
                }
            }
            else
            {
                var subscriptionSet = this.mobileSubscriptionSet;

                foreach (var subscription in subscriptionSet)
                {
                    if (subscription.Contact.Equals(contact))
                    {
                        return true;
                    }
                }
            }


            return false;
        }



        public SendViaEmail ReferenceEmailSubscription(string contact)
        {


            foreach (var subscription in this.emailSubscriptionSet)
            {
                if (subscription.Contact.Equals(contact))
                {
                    return subscription;
                }
            }

            return null;

        }



        public SendViaMobile ReferenceMobileSubscription(string contact)
        {


            foreach (var subscription in this.mobileSubscriptionSet)
            {
                if (subscription.Contact.Equals(contact))
                {
                    return subscription;
                }
            }

            return null;

        }





        private void unsubscribeBtn_Click(object sender, EventArgs e)
        {
            resetLabels();


            // Unsubscribe email.
            if (notifyByEmailCheckBox.Checked)
            {
                processAction("unsubscribe", "email", emailTextBox.Text, emailResultLabel);
            }


            // Unsubscribe mobile.
            if (notifyBySmsCheckBox.Checked)
            {
                processAction("unsubscribe", "mobile", phoneTextBox.Text, phoneResultLabel);
            }


        }



        private void resetLabels()
        {
            emailResultLabel.Text = "";
            phoneResultLabel.Text = "";

            emailResultLabel.ForeColor = Color.Red;
            phoneResultLabel.ForeColor = Color.Red;
        }
    }
}

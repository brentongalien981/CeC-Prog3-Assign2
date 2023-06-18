using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Practice
{
    public class SendViaEmail
    {
        public String Contact { get; set; }
        NotificationPublisher publisherForm;


        public SendViaEmail()
        {

        }



        public SendViaEmail(String contact, NotificationPublisher publisherForm)
        {
            Contact = contact;
            this.publisherForm = publisherForm;
        }



        public virtual void send(string msg)
        {
            string notification = "The message " + "\"" + msg + "\" was sent to " + Contact;
            publisherForm.DisplayNotification(notification);
        }



        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += send;
        }



        public void Unsubscribe(Publisher pub)
        {
            pub.publishmsg -= send;
        }
    }
}
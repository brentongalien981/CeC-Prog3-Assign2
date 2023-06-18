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
    public partial class NotificationPublisher : Form
    {
        Publisher publisher;

        public NotificationPublisher(Publisher pub)
        {
            InitializeComponent();
            this.publisher = pub;
        }



        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void publishBtn_Click(object sender, EventArgs e)
        {
            // Reset status label.
            statusLabel.Text = "";

            string msg = notificationContentTextBox.Text;

            // Show status message.
            if (string.IsNullOrEmpty(msg))
            {
                statusLabel.Text = "Notification content can't be empty.";
            }
            else
            {
                // Reset notificationsListView.
                notificationsListView.Items.Clear();

                // Publish messages.
                this.publisher.PublishMessage(msg);
            }

        }


        public void DisplayNotification(string notification)
        {
            notificationsListView.Items.Add(new ListViewItem(notification));
            notificationsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            
            // Delayed effect.
            System.Threading.Thread.Sleep(500);
        }

    }
}

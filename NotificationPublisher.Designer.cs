using System.Windows.Forms;

namespace Practice
{
    partial class NotificationPublisher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.notificationContentTextBox = new System.Windows.Forms.TextBox();
            this.notificationsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.publishBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notification Content";
            // 
            // notificationContentTextBox
            // 
            this.notificationContentTextBox.Location = new System.Drawing.Point(156, 27);
            this.notificationContentTextBox.Name = "notificationContentTextBox";
            this.notificationContentTextBox.Size = new System.Drawing.Size(343, 23);
            this.notificationContentTextBox.TabIndex = 1;
            // 
            // notificationsListView
            // 
            this.notificationsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.notificationsListView.Location = new System.Drawing.Point(34, 115);
            this.notificationsListView.Name = "notificationsListView";
            this.notificationsListView.Size = new System.Drawing.Size(560, 172);
            this.notificationsListView.TabIndex = 2;
            this.notificationsListView.UseCompatibleStateImageBehavior = false;
            this.notificationsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Notifications";
            this.columnHeader1.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Published Notifications";
            // 
            // publishBtn
            // 
            this.publishBtn.Location = new System.Drawing.Point(156, 56);
            this.publishBtn.Name = "publishBtn";
            this.publishBtn.Size = new System.Drawing.Size(75, 23);
            this.publishBtn.TabIndex = 4;
            this.publishBtn.Text = "Publish";
            this.publishBtn.UseVisualStyleBackColor = true;
            this.publishBtn.Click += new System.EventHandler(this.publishBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(237, 56);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(34, 316);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(22, 15);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "---";
            // 
            // NotificationPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 340);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.publishBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notificationsListView);
            this.Controls.Add(this.notificationContentTextBox);
            this.Controls.Add(this.label1);
            this.Name = "NotificationPublisher";
            this.Text = "Notification Publisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox notificationContentTextBox;
        private ListView notificationsListView;
        private Label label2;
        private Button publishBtn;
        private Button exitBtn;
        private Label statusLabel;
        private ColumnHeader columnHeader1;
    }
}
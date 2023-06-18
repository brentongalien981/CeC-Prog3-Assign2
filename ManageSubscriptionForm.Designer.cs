using System.Windows.Forms;

namespace Practice
{
    partial class ManageSubscriptionForm
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
            this.notifyByEmailCheckBox = new System.Windows.Forms.CheckBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailResultLabel = new System.Windows.Forms.Label();
            this.notifyBySmsCheckBox = new System.Windows.Forms.CheckBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneResultLabel = new System.Windows.Forms.Label();
            this.subscribeBtn = new System.Windows.Forms.Button();
            this.unsubscribeBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notifyByEmailCheckBox
            // 
            this.notifyByEmailCheckBox.AutoSize = true;
            this.notifyByEmailCheckBox.Location = new System.Drawing.Point(12, 40);
            this.notifyByEmailCheckBox.Name = "notifyByEmailCheckBox";
            this.notifyByEmailCheckBox.Size = new System.Drawing.Size(107, 19);
            this.notifyByEmailCheckBox.TabIndex = 0;
            this.notifyByEmailCheckBox.Text = "Notify by Email";
            this.notifyByEmailCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(125, 40);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(340, 23);
            this.emailTextBox.TabIndex = 1;
            // 
            // emailResultLabel
            // 
            this.emailResultLabel.AutoSize = true;
            this.emailResultLabel.Location = new System.Drawing.Point(125, 66);
            this.emailResultLabel.Name = "emailResultLabel";
            this.emailResultLabel.Size = new System.Drawing.Size(22, 15);
            this.emailResultLabel.TabIndex = 2;
            this.emailResultLabel.Text = "---";
            // 
            // notifyBySmsCheckBox
            // 
            this.notifyBySmsCheckBox.AutoSize = true;
            this.notifyBySmsCheckBox.Location = new System.Drawing.Point(12, 91);
            this.notifyBySmsCheckBox.Name = "notifyBySmsCheckBox";
            this.notifyBySmsCheckBox.Size = new System.Drawing.Size(101, 19);
            this.notifyBySmsCheckBox.TabIndex = 3;
            this.notifyBySmsCheckBox.Text = "Notify by SMS";
            this.notifyBySmsCheckBox.UseVisualStyleBackColor = true;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(125, 91);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(340, 23);
            this.phoneTextBox.TabIndex = 4;
            // 
            // phoneResultLabel
            // 
            this.phoneResultLabel.AutoSize = true;
            this.phoneResultLabel.Location = new System.Drawing.Point(125, 117);
            this.phoneResultLabel.Name = "phoneResultLabel";
            this.phoneResultLabel.Size = new System.Drawing.Size(22, 15);
            this.phoneResultLabel.TabIndex = 5;
            this.phoneResultLabel.Text = "---";
            // 
            // subscribeBtn
            // 
            this.subscribeBtn.AutoSize = true;
            this.subscribeBtn.Location = new System.Drawing.Point(12, 149);
            this.subscribeBtn.Name = "subscribeBtn";
            this.subscribeBtn.Size = new System.Drawing.Size(86, 25);
            this.subscribeBtn.TabIndex = 6;
            this.subscribeBtn.Text = "Subscribe";
            this.subscribeBtn.UseVisualStyleBackColor = true;
            this.subscribeBtn.Click += new System.EventHandler(this.subscribeBtn_Click);
            // 
            // unsubscribeBtn
            // 
            this.unsubscribeBtn.AutoSize = true;
            this.unsubscribeBtn.Location = new System.Drawing.Point(104, 149);
            this.unsubscribeBtn.Name = "unsubscribeBtn";
            this.unsubscribeBtn.Size = new System.Drawing.Size(95, 25);
            this.unsubscribeBtn.TabIndex = 7;
            this.unsubscribeBtn.Text = "Unsubscribe";
            this.unsubscribeBtn.UseVisualStyleBackColor = true;
            this.unsubscribeBtn.Click += new System.EventHandler(this.unsubscribeBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.Location = new System.Drawing.Point(205, 149);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 25);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 211);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(22, 15);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "---";
            // 
            // ManageSubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 235);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.unsubscribeBtn);
            this.Controls.Add(this.subscribeBtn);
            this.Controls.Add(this.phoneResultLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.notifyBySmsCheckBox);
            this.Controls.Add(this.emailResultLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.notifyByEmailCheckBox);
            this.Name = "ManageSubscriptionForm";
            this.Text = "Manage Subscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox notifyByEmailCheckBox;
        private TextBox emailTextBox;
        private Label emailResultLabel;
        private CheckBox notifyBySmsCheckBox;
        private TextBox phoneTextBox;
        private Label phoneResultLabel;
        private Button subscribeBtn;
        private Button unsubscribeBtn;
        private Button cancelBtn;
        private Label statusLabel;
    }
}
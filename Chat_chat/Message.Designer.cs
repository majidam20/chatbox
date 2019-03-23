using System.Windows.Forms;

namespace Chat_CODie
{
    partial class MessageForm
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
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new System.Windows.Forms.Panel();
            this.splitContainerControl1 = new System.Windows.Forms.SplitContainer();
            this.lbl_welcomed = new System.Windows.Forms.Label();
            this.cmb_rooms = new System.Windows.Forms.ComboBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.btn_newmessage = new System.Windows.Forms.Button();
            this.panelControl2 = new System.Windows.Forms.Panel();
            this.btn_CountOfInbox = new System.Windows.Forms.Button();
            this.lst_inbox = new System.Windows.Forms.ListBox();
            this.lst_sender = new System.Windows.Forms.ListBox();
            this.labelControl2 = new System.Windows.Forms.Label();
            this.labelControl1 = new System.Windows.Forms.Label();
            this.panelControl3 = new System.Windows.Forms.Panel();
            this.rtb_newmessage = new System.Windows.Forms.RichTextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            this.panelControl2.SuspendLayout();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitContainerControl1);
            this.panelControl1.Location = new System.Drawing.Point(13, 13);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 100);
            this.panelControl1.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.lbl_welcomed);
            this.splitContainerControl1.Panel1.Controls.Add(this.cmb_rooms);
            this.splitContainerControl1.Panel1.Controls.Add(this.lbl_search);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.btn_newmessage);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(784, 100);
            this.splitContainerControl1.SplitterDistance = 581;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // lbl_welcomed
            // 
            this.lbl_welcomed.AutoSize = true;
            this.lbl_welcomed.Location = new System.Drawing.Point(111, 4);
            this.lbl_welcomed.Name = "lbl_welcomed";
            this.lbl_welcomed.Size = new System.Drawing.Size(0, 13);
            this.lbl_welcomed.TabIndex = 5;
            // 
            // cmb_rooms
            // 
            this.cmb_rooms.Location = new System.Drawing.Point(107, 32);
            this.cmb_rooms.Name = "cmb_rooms";
            this.cmb_rooms.Size = new System.Drawing.Size(438, 21);
            this.cmb_rooms.TabIndex = 4;
            this.cmb_rooms.SelectedIndexChanged += new System.EventHandler(this.cmb_users_SelectedIndexChanged);
            // 
            // lbl_search
            // 
            this.lbl_search.Location = new System.Drawing.Point(20, 35);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(81, 27);
            this.lbl_search.TabIndex = 1;
            this.lbl_search.Text = "Search Rooms:";
            // 
            // btn_newmessage
            // 
            this.btn_newmessage.Location = new System.Drawing.Point(12, 19);
            this.btn_newmessage.Name = "btn_newmessage";
            this.btn_newmessage.Size = new System.Drawing.Size(103, 34);
            this.btn_newmessage.TabIndex = 0;
            this.btn_newmessage.Text = "New Message +";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_CountOfInbox);
            this.panelControl2.Controls.Add(this.lst_inbox);
            this.panelControl2.Controls.Add(this.lst_sender);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(15, 119);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(782, 372);
            this.panelControl2.TabIndex = 1;
            // 
            // btn_CountOfInbox
            // 
            this.btn_CountOfInbox.Location = new System.Drawing.Point(718, 14);
            this.btn_CountOfInbox.Name = "btn_CountOfInbox";
            this.btn_CountOfInbox.Size = new System.Drawing.Size(46, 23);
            this.btn_CountOfInbox.TabIndex = 9;
            this.btn_CountOfInbox.UseVisualStyleBackColor = true;
            this.btn_CountOfInbox.Visible = false;
            this.btn_CountOfInbox.Click += new System.EventHandler(this.btn_CountOfInbox_Click_1);
            // 
            // lst_inbox
            // 
            this.lst_inbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.lst_inbox.Location = new System.Drawing.Point(285, 14);
            this.lst_inbox.Name = "lst_inbox";
            this.lst_inbox.Size = new System.Drawing.Size(427, 342);
            this.lst_inbox.TabIndex = 8;
            this.lst_inbox.SelectedIndexChanged += new System.EventHandler(this.lst_inbox_SelectedIndexChanged);
            // 
            // lst_sender
            // 
            this.lst_sender.Cursor = System.Windows.Forms.Cursors.Default;
            this.lst_sender.Location = new System.Drawing.Point(65, 12);
            this.lst_sender.Name = "lst_sender";
            this.lst_sender.Size = new System.Drawing.Size(178, 342);
            this.lst_sender.TabIndex = 7;
            this.lst_sender.SelectedIndexChanged += new System.EventHandler(this.lst_sender_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(249, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 46);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Group Inbox:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 23);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "sender:";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.rtb_newmessage);
            this.panelControl3.Controls.Add(this.btn_send);
            this.panelControl3.Location = new System.Drawing.Point(15, 497);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(782, 138);
            this.panelControl3.TabIndex = 2;
            // 
            // rtb_newmessage
            // 
            this.rtb_newmessage.Location = new System.Drawing.Point(65, 33);
            this.rtb_newmessage.Name = "rtb_newmessage";
            this.rtb_newmessage.Size = new System.Drawing.Size(550, 75);
            this.rtb_newmessage.TabIndex = 3;
            this.rtb_newmessage.Text = "";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(637, 33);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 75);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "Send";
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 681);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Message";
            this.Text = "Messages";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelControl1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.panelControl2.ResumeLayout(false);
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelControl1;
        private SplitContainer splitContainerControl1;
        private Panel panelControl2;
        private Label lbl_search;
        private Button btn_newmessage;
        private Panel panelControl3;
        private Button btn_send;
        private ComboBox cmb_rooms;
        private Label labelControl2;
        private Label labelControl1;
        private ListBox lst_sender;
        private ListBox lst_inbox;
        private Label lbl_welcomed;
        private RichTextBox rtb_newmessage;
        private Button btn_CountOfInbox;
        public Timer timer1;
    }
}


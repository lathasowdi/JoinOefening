namespace JoinOefening
{
    partial class menu
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
            this.btnaddperson = new System.Windows.Forms.Button();
            this.lbpersoon = new System.Windows.Forms.ListBox();
            this.btnviewbadge = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnnaarJoske = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnaddperson
            // 
            this.btnaddperson.Location = new System.Drawing.Point(174, 59);
            this.btnaddperson.Name = "btnaddperson";
            this.btnaddperson.Size = new System.Drawing.Size(99, 23);
            this.btnaddperson.TabIndex = 6;
            this.btnaddperson.Text = "ADDPERSON";
            this.btnaddperson.UseVisualStyleBackColor = true;
            this.btnaddperson.Click += new System.EventHandler(this.btnaddperson_Click);
            // 
            // lbpersoon
            // 
            this.lbpersoon.FormattingEnabled = true;
            this.lbpersoon.Location = new System.Drawing.Point(34, 30);
            this.lbpersoon.Name = "lbpersoon";
            this.lbpersoon.Size = new System.Drawing.Size(120, 173);
            this.lbpersoon.TabIndex = 7;
            // 
            // btnviewbadge
            // 
            this.btnviewbadge.Location = new System.Drawing.Point(174, 30);
            this.btnviewbadge.Name = "btnviewbadge";
            this.btnviewbadge.Size = new System.Drawing.Size(99, 23);
            this.btnviewbadge.TabIndex = 8;
            this.btnviewbadge.Text = "VIEWBADGE";
            this.btnviewbadge.UseVisualStyleBackColor = true;
            this.btnviewbadge.Click += new System.EventHandler(this.btnviewbadge_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(174, 88);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(99, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "ADDBADGE";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(174, 146);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(99, 23);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "VERWIJDEREN";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(174, 117);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(99, 23);
            this.btnedit.TabIndex = 8;
            this.btnedit.Text = "EDITPERSON";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click_1);
            // 
            // btnnaarJoske
            // 
            this.btnnaarJoske.Location = new System.Drawing.Point(174, 180);
            this.btnnaarJoske.Name = "btnnaarJoske";
            this.btnnaarJoske.Size = new System.Drawing.Size(99, 23);
            this.btnnaarJoske.TabIndex = 9;
            this.btnnaarJoske.Text = "NAMECHANGE";
            this.btnnaarJoske.UseVisualStyleBackColor = true;
            this.btnnaarJoske.Click += new System.EventHandler(this.btnnaarJoske_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 215);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnviewbadge);
            this.Controls.Add(this.lbpersoon);
            this.Controls.Add(this.btnnaarJoske);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnaddperson);
            this.Name = "menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnaddperson;
        private System.Windows.Forms.ListBox lbpersoon;
        private System.Windows.Forms.Button btnviewbadge;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnnaarJoske;
    }
}


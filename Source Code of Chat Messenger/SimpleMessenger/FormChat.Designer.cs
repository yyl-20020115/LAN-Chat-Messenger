namespace SimpleMessenger
{
    partial class FormChat
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
            this.SendMsgBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnBuZZ = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxEnter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SendMsgBox
            // 
            this.SendMsgBox.BackColor = System.Drawing.Color.Thistle;
            this.SendMsgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SendMsgBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SendMsgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMsgBox.Location = new System.Drawing.Point(0, 320);
            this.SendMsgBox.Multiline = true;
            this.SendMsgBox.Name = "SendMsgBox";
            this.SendMsgBox.Size = new System.Drawing.Size(280, 74);
            this.SendMsgBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(-3, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "我发送的:";
            // 
            // btnSend
            // 
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Location = new System.Drawing.Point(0, 250);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(149, 29);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "发送消息(&S)";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // btnBuZZ
            // 
            this.btnBuZZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuZZ.Location = new System.Drawing.Point(195, 250);
            this.btnBuZZ.Name = "btnBuZZ";
            this.btnBuZZ.Size = new System.Drawing.Size(73, 29);
            this.btnBuZZ.TabIndex = 4;
            this.btnBuZZ.Tag = "Clip";
            this.btnBuZZ.Text = "拍拍(&P)";
            this.btnBuZZ.UseVisualStyleBackColor = true;
            this.btnBuZZ.Click += new System.EventHandler(this.btnBuZZ_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(280, 241);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // checkBoxEnter
            // 
            this.checkBoxEnter.AutoSize = true;
            this.checkBoxEnter.Checked = true;
            this.checkBoxEnter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkBoxEnter.Location = new System.Drawing.Point(4, 283);
            this.checkBoxEnter.Name = "checkBoxEnter";
            this.checkBoxEnter.Size = new System.Drawing.Size(102, 16);
            this.checkBoxEnter.TabIndex = 6;
            this.checkBoxEnter.Tag = "";
            this.checkBoxEnter.Text = "按回车发送(&E)";
            this.checkBoxEnter.UseVisualStyleBackColor = true;
            this.checkBoxEnter.CheckedChanged += new System.EventHandler(this.CheckBoxEnter_CheckedChanged);
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(280, 394);
            this.Controls.Add(this.checkBoxEnter);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnBuZZ);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendMsgBox);
            this.MaximizeBox = false;
            this.Name = "FormChat";
            this.Text = "聊天窗口";
            this.Load += new System.EventHandler(this.FormChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SendMsgBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnBuZZ;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBoxEnter;
    }
}
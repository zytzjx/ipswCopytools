namespace iPswCopyTools
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.tblIPSWInfo = new System.Windows.Forms.TextBox();
            this.tbiPhoneIpsw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbiPhonedmg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbiPadIpsw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbiPadDmg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.openDlgTxt = new System.Windows.Forms.OpenFileDialog();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tbiPodDmg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbiPodIpsw = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbApstDMG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(5, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button10);
            this.splitContainer1.Panel2.Controls.Add(this.button9);
            this.splitContainer1.Panel2.Controls.Add(this.tbApstDMG);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.button7);
            this.splitContainer1.Panel2.Controls.Add(this.button8);
            this.splitContainer1.Panel2.Controls.Add(this.tbiPodDmg);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.tbiPodIpsw);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.button6);
            this.splitContainer1.Panel2.Controls.Add(this.button5);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.tbiPadDmg);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.tbiPadIpsw);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.tbiPhonedmg);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.tbiPhoneIpsw);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.tblIPSWInfo);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2MinSize = 200;
            this.splitContainer1.Size = new System.Drawing.Size(1408, 656);
            this.splitContainer1.SplitterDistance = 613;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(3, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(600, 653);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IPSW Info Txt";
            // 
            // tblIPSWInfo
            // 
            this.tblIPSWInfo.Location = new System.Drawing.Point(91, 42);
            this.tblIPSWInfo.Name = "tblIPSWInfo";
            this.tblIPSWInfo.ReadOnly = true;
            this.tblIPSWInfo.Size = new System.Drawing.Size(666, 20);
            this.tblIPSWInfo.TabIndex = 1;
            // 
            // tbiPhoneIpsw
            // 
            this.tbiPhoneIpsw.Location = new System.Drawing.Point(91, 94);
            this.tbiPhoneIpsw.Name = "tbiPhoneIpsw";
            this.tbiPhoneIpsw.ReadOnly = true;
            this.tbiPhoneIpsw.Size = new System.Drawing.Size(666, 20);
            this.tbiPhoneIpsw.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "iPhone IPSW Folder:";
            // 
            // tbiPhonedmg
            // 
            this.tbiPhonedmg.Location = new System.Drawing.Point(91, 138);
            this.tbiPhonedmg.Name = "tbiPhonedmg";
            this.tbiPhonedmg.ReadOnly = true;
            this.tbiPhonedmg.Size = new System.Drawing.Size(666, 20);
            this.tbiPhonedmg.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "iPhone DMG Folder:";
            // 
            // tbiPadIpsw
            // 
            this.tbiPadIpsw.Location = new System.Drawing.Point(91, 208);
            this.tbiPadIpsw.Name = "tbiPadIpsw";
            this.tbiPadIpsw.ReadOnly = true;
            this.tbiPadIpsw.Size = new System.Drawing.Size(666, 20);
            this.tbiPadIpsw.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "iPad IPSW Folder:";
            // 
            // tbiPadDmg
            // 
            this.tbiPadDmg.Location = new System.Drawing.Point(91, 252);
            this.tbiPadDmg.Name = "tbiPadDmg";
            this.tbiPadDmg.ReadOnly = true;
            this.tbiPadDmg.Size = new System.Drawing.Size(666, 20);
            this.tbiPadDmg.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "iPad DMG Folder";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(731, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(731, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 11;
            this.button2.Tag = "4";
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(731, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 12;
            this.button3.Tag = "3";
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(731, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 23);
            this.button4.TabIndex = 13;
            this.button4.Tag = "2";
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button5_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(731, 91);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 23);
            this.button5.TabIndex = 14;
            this.button5.Tag = "1";
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(50, 527);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 126);
            this.button6.TabIndex = 15;
            this.button6.Text = "COPY";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // openDlgTxt
            // 
            this.openDlgTxt.Filter = "Text files (*.txt)|*.txt";
            this.openDlgTxt.ShowReadOnly = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(731, 327);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(26, 23);
            this.button7.TabIndex = 21;
            this.button7.Tag = "5";
            this.button7.Text = "...";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(731, 368);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(26, 23);
            this.button8.TabIndex = 20;
            this.button8.Tag = "6";
            this.button8.Text = "...";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbiPodDmg
            // 
            this.tbiPodDmg.Location = new System.Drawing.Point(91, 371);
            this.tbiPodDmg.Name = "tbiPodDmg";
            this.tbiPodDmg.ReadOnly = true;
            this.tbiPodDmg.Size = new System.Drawing.Size(666, 20);
            this.tbiPodDmg.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "iPod DMG Folder";
            // 
            // tbiPodIpsw
            // 
            this.tbiPodIpsw.Location = new System.Drawing.Point(91, 327);
            this.tbiPodIpsw.Name = "tbiPodIpsw";
            this.tbiPodIpsw.ReadOnly = true;
            this.tbiPodIpsw.Size = new System.Drawing.Size(666, 20);
            this.tbiPodIpsw.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "iPod IPSW Folder:";
            // 
            // tbApstDMG
            // 
            this.tbApstDMG.Location = new System.Drawing.Point(84, 450);
            this.tbApstDMG.Name = "tbApstDMG";
            this.tbApstDMG.Size = new System.Drawing.Size(666, 20);
            this.tbApstDMG.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "LOT DMG Folder:";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(201, 527);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(128, 126);
            this.button9.TabIndex = 24;
            this.button9.Text = "Check DMG Folder";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(347, 527);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(128, 126);
            this.button10.TabIndex = 25;
            this.button10.Text = "Delete DMG";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "ipad.ico");
            this.imageList.Images.SetKeyName(1, "iphone.ico");
            this.imageList.Images.SetKeyName(2, "ipod.ico");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 680);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMain";
            this.Text = "DMG Copy Tools";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox tblIPSWInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbiPadDmg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbiPadIpsw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbiPhonedmg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbiPhoneIpsw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openDlgTxt;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox tbiPodDmg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbiPodIpsw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbApstDMG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ImageList imageList;
    }
}


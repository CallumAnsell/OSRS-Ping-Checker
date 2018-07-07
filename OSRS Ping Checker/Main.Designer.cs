namespace OSRS_Helper
{
    partial class Main
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtWorld = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstWorlds = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstPingOutput = new System.Windows.Forms.ListBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.btnPingAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.wrkPINGALL = new System.ComponentModel.BackgroundWorker();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDemoFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtWorld
            // 
            this.txtWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorld.Location = new System.Drawing.Point(10, 60);
            this.txtWorld.Name = "txtWorld";
            this.txtWorld.Size = new System.Drawing.Size(116, 27);
            this.txtWorld.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Worlds (Comma seperated)";
            // 
            // lstWorlds
            // 
            this.lstWorlds.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWorlds.FormattingEnabled = true;
            this.lstWorlds.ItemHeight = 20;
            this.lstWorlds.Location = new System.Drawing.Point(463, 127);
            this.lstWorlds.Name = "lstWorlds";
            this.lstWorlds.Size = new System.Drawing.Size(120, 184);
            this.lstWorlds.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(133, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 27);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add World";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstPingOutput
            // 
            this.lstPingOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPingOutput.FormattingEnabled = true;
            this.lstPingOutput.ItemHeight = 20;
            this.lstPingOutput.Location = new System.Drawing.Point(9, 127);
            this.lstPingOutput.Name = "lstPingOutput";
            this.lstPingOutput.Size = new System.Drawing.Size(239, 184);
            this.lstPingOutput.TabIndex = 4;
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(132, 327);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(116, 33);
            this.btnPing.TabIndex = 6;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click_1);
            // 
            // btnPingAll
            // 
            this.btnPingAll.Location = new System.Drawing.Point(9, 327);
            this.btnPingAll.Name = "btnPingAll";
            this.btnPingAll.Size = new System.Drawing.Size(116, 33);
            this.btnPingAll.TabIndex = 7;
            this.btnPingAll.Text = "Ping All Worlds";
            this.btnPingAll.UseVisualStyleBackColor = true;
            this.btnPingAll.Click += new System.EventHandler(this.btnPingAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(269, 60);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(117, 27);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove World";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // wrkPINGALL
            // 
            this.wrkPINGALL.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wrkPINGALL_DoWork);
            this.wrkPINGALL.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.wrkPINGALL_RunWorkerCompleted);
            // 
            // lstInfo
            // 
            this.lstInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.ItemHeight = 20;
            this.lstInfo.Location = new System.Drawing.Point(254, 127);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(200, 184);
            this.lstInfo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ping Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Worlds";
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 1000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromFileToolStripMenuItem,
            this.createDemoFileToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.functionsToolStripMenuItem.Text = "Functions";
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            this.loadFromFileToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.loadFromFileToolStripMenuItem.Text = "Load worlds from file";
            this.loadFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadFromFileToolStripMenuItem_Click);
            // 
            // createDemoFileToolStripMenuItem
            // 
            this.createDemoFileToolStripMenuItem.Name = "createDemoFileToolStripMenuItem";
            this.createDemoFileToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.createDemoFileToolStripMenuItem.Text = "Create demo worlds file";
            this.createDemoFileToolStripMenuItem.Click += new System.EventHandler(this.createDemoFileToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 381);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstInfo);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnPingAll);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.lstPingOutput);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstWorlds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWorld);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "OSRS Ping Checker (Made by InvertedLux)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtWorld;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstWorlds;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstPingOutput;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Button btnPingAll;
        private System.Windows.Forms.Button btnRemove;
        private System.ComponentModel.BackgroundWorker wrkPINGALL;
        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDemoFileToolStripMenuItem;
    }
}


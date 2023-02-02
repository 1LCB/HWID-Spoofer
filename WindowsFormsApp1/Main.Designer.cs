
namespace WindowsFormsApp1
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chkProductID = new System.Windows.Forms.CheckBox();
            this.chkComputerName = new System.Windows.Forms.CheckBox();
            this.chkHWID = new System.Windows.Forms.CheckBox();
            this.chkDisks = new System.Windows.Forms.CheckBox();
            this.chkMacAddress = new System.Windows.Forms.CheckBox();
            this.chkMachineGuid = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chkInstallTime = new System.Windows.Forms.CheckBox();
            this.chkInstallDate = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://github.com/1LCB.png";
            this.pictureBox1.Location = new System.Drawing.Point(303, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(12, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Spoof";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkProductID
            // 
            this.chkProductID.AutoSize = true;
            this.chkProductID.Checked = true;
            this.chkProductID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProductID.ForeColor = System.Drawing.Color.White;
            this.chkProductID.Location = new System.Drawing.Point(12, 12);
            this.chkProductID.Name = "chkProductID";
            this.chkProductID.Size = new System.Drawing.Size(104, 24);
            this.chkProductID.TabIndex = 2;
            this.chkProductID.Text = "Product ID";
            this.chkProductID.UseVisualStyleBackColor = true;
            // 
            // chkComputerName
            // 
            this.chkComputerName.AutoSize = true;
            this.chkComputerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkComputerName.ForeColor = System.Drawing.Color.White;
            this.chkComputerName.Location = new System.Drawing.Point(12, 42);
            this.chkComputerName.Name = "chkComputerName";
            this.chkComputerName.Size = new System.Drawing.Size(144, 24);
            this.chkComputerName.TabIndex = 3;
            this.chkComputerName.Text = "Computer Name";
            this.chkComputerName.UseVisualStyleBackColor = true;
            // 
            // chkHWID
            // 
            this.chkHWID.AutoSize = true;
            this.chkHWID.Checked = true;
            this.chkHWID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHWID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHWID.ForeColor = System.Drawing.Color.White;
            this.chkHWID.Location = new System.Drawing.Point(12, 72);
            this.chkHWID.Name = "chkHWID";
            this.chkHWID.Size = new System.Drawing.Size(72, 24);
            this.chkHWID.TabIndex = 4;
            this.chkHWID.Text = "HWID";
            this.chkHWID.UseVisualStyleBackColor = true;
            // 
            // chkDisks
            // 
            this.chkDisks.AutoSize = true;
            this.chkDisks.Checked = true;
            this.chkDisks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDisks.ForeColor = System.Drawing.Color.White;
            this.chkDisks.Location = new System.Drawing.Point(162, 12);
            this.chkDisks.Name = "chkDisks";
            this.chkDisks.Size = new System.Drawing.Size(179, 24);
            this.chkDisks.TabIndex = 5;
            this.chkDisks.Text = "Disks Serial Numbers";
            this.chkDisks.UseVisualStyleBackColor = true;
            // 
            // chkMacAddress
            // 
            this.chkMacAddress.AutoSize = true;
            this.chkMacAddress.Checked = true;
            this.chkMacAddress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMacAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMacAddress.ForeColor = System.Drawing.Color.White;
            this.chkMacAddress.Location = new System.Drawing.Point(162, 42);
            this.chkMacAddress.Name = "chkMacAddress";
            this.chkMacAddress.Size = new System.Drawing.Size(121, 24);
            this.chkMacAddress.TabIndex = 7;
            this.chkMacAddress.Text = "Mac Address";
            this.chkMacAddress.UseVisualStyleBackColor = true;
            // 
            // chkMachineGuid
            // 
            this.chkMachineGuid.AutoSize = true;
            this.chkMachineGuid.Checked = true;
            this.chkMachineGuid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMachineGuid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMachineGuid.ForeColor = System.Drawing.Color.White;
            this.chkMachineGuid.Location = new System.Drawing.Point(12, 102);
            this.chkMachineGuid.Name = "chkMachineGuid";
            this.chkMachineGuid.Size = new System.Drawing.Size(126, 24);
            this.chkMachineGuid.TabIndex = 8;
            this.chkMachineGuid.Text = "Machine Guid";
            this.chkMachineGuid.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(150, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Backup";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkInstallTime
            // 
            this.chkInstallTime.AutoSize = true;
            this.chkInstallTime.Checked = true;
            this.chkInstallTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInstallTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInstallTime.ForeColor = System.Drawing.Color.White;
            this.chkInstallTime.Location = new System.Drawing.Point(162, 72);
            this.chkInstallTime.Name = "chkInstallTime";
            this.chkInstallTime.Size = new System.Drawing.Size(108, 24);
            this.chkInstallTime.TabIndex = 10;
            this.chkInstallTime.Text = "Install Time";
            this.chkInstallTime.UseVisualStyleBackColor = true;
            // 
            // chkInstallDate
            // 
            this.chkInstallDate.AutoSize = true;
            this.chkInstallDate.Checked = true;
            this.chkInstallDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInstallDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInstallDate.ForeColor = System.Drawing.Color.White;
            this.chkInstallDate.Location = new System.Drawing.Point(162, 102);
            this.chkInstallDate.Name = "chkInstallDate";
            this.chkInstallDate.Size = new System.Drawing.Size(109, 24);
            this.chkInstallDate.TabIndex = 11;
            this.chkInstallDate.Text = "Install Date";
            this.chkInstallDate.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(13, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "Current HWID Values";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(370, 233);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chkInstallDate);
            this.Controls.Add(this.chkInstallTime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chkMachineGuid);
            this.Controls.Add(this.chkMacAddress);
            this.Controls.Add(this.chkDisks);
            this.Controls.Add(this.chkHWID);
            this.Controls.Add(this.chkComputerName);
            this.Controls.Add(this.chkProductID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HWID SPOOFER";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkProductID;
        private System.Windows.Forms.CheckBox chkComputerName;
        private System.Windows.Forms.CheckBox chkHWID;
        private System.Windows.Forms.CheckBox chkDisks;
        private System.Windows.Forms.CheckBox chkMacAddress;
        private System.Windows.Forms.CheckBox chkMachineGuid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkInstallTime;
        private System.Windows.Forms.CheckBox chkInstallDate;
        private System.Windows.Forms.Button button3;
    }
}


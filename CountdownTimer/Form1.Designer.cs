
namespace CountdownTimer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numGio = new System.Windows.Forms.NumericUpDown();
            this.numPhut = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeLeft = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numAlert = new System.Windows.Forms.NumericUpDown();
            this.btBatdau = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numGio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // numGio
            // 
            this.numGio.Location = new System.Drawing.Point(22, 20);
            this.numGio.Name = "numGio";
            this.numGio.Size = new System.Drawing.Size(64, 22);
            this.numGio.TabIndex = 0;
            // 
            // numPhut
            // 
            this.numPhut.Location = new System.Drawing.Point(144, 20);
            this.numPhut.Name = "numPhut";
            this.numPhut.Size = new System.Drawing.Size(64, 22);
            this.numPhut.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giờ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phút";
            // 
            // timeLeft
            // 
            this.timeLeft.AutoSize = true;
            this.timeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeLeft.Location = new System.Drawing.Point(2, 51);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(270, 69);
            this.timeLeft.TabIndex = 7;
            this.timeLeft.Text = "00:00:00";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(22, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 22);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Nhắc nhở sau (phút)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numAlert
            // 
            this.numAlert.Location = new System.Drawing.Point(208, 122);
            this.numAlert.Name = "numAlert";
            this.numAlert.Size = new System.Drawing.Size(64, 22);
            this.numAlert.TabIndex = 9;
            this.numAlert.Visible = false;
            this.numAlert.ValueChanged += new System.EventHandler(this.numAlert_ValueChanged);
            // 
            // btBatdau
            // 
            this.btBatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBatdau.Location = new System.Drawing.Point(281, 21);
            this.btBatdau.Name = "btBatdau";
            this.btBatdau.Size = new System.Drawing.Size(89, 49);
            this.btBatdau.TabIndex = 10;
            this.btBatdau.Text = "Bắt đầu";
            this.btBatdau.UseVisualStyleBackColor = true;
            this.btBatdau.Click += new System.EventHandler(this.btBatdau_Click);
            // 
            // btHuy
            // 
            this.btHuy.Enabled = false;
            this.btHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.Location = new System.Drawing.Point(281, 83);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(89, 49);
            this.btHuy.TabIndex = 11;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CountdownTimer.Properties.Resources.clock2;
            this.ClientSize = new System.Drawing.Size(381, 151);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btBatdau);
            this.Controls.Add(this.numAlert);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPhut);
            this.Controls.Add(this.numGio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hẹn giờ đếm ngược";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize_1);
            ((System.ComponentModel.ISupportInitialize)(this.numGio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numGio;
        private System.Windows.Forms.NumericUpDown numPhut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeLeft;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numAlert;
        private System.Windows.Forms.Button btBatdau;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}


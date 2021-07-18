
namespace PingPong23
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.background = new System.Windows.Forms.Panel();
            this.result = new System.Windows.Forms.Label();
            this.gameball = new System.Windows.Forms.PictureBox();
            this.gamepanel = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loose = new System.Windows.Forms.Label();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamepanel)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.SystemColors.Info;
            this.background.Controls.Add(this.loose);
            this.background.Controls.Add(this.result);
            this.background.Controls.Add(this.gameball);
            this.background.Controls.Add(this.gamepanel);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(800, 450);
            this.background.TabIndex = 0;
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Showcard Gothic", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.result.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.result.Location = new System.Drawing.Point(521, 23);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(186, 44);
            this.result.TabIndex = 2;
            this.result.Text = "Result: 0";
            // 
            // gameball
            // 
            this.gameball.BackColor = System.Drawing.Color.MediumAquamarine;
            this.gameball.Location = new System.Drawing.Point(172, 166);
            this.gameball.Name = "gameball";
            this.gameball.Size = new System.Drawing.Size(50, 50);
            this.gameball.TabIndex = 1;
            this.gameball.TabStop = false;
            // 
            // gamepanel
            // 
            this.gamepanel.BackColor = System.Drawing.Color.Teal;
            this.gamepanel.Location = new System.Drawing.Point(253, 403);
            this.gamepanel.Name = "gamepanel";
            this.gamepanel.Size = new System.Drawing.Size(276, 35);
            this.gamepanel.TabIndex = 0;
            this.gamepanel.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loose
            // 
            this.loose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loose.AutoSize = true;
            this.loose.Font = new System.Drawing.Font("Segoe Script", 31F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.loose.Location = new System.Drawing.Point(144, 180);
            this.loose.Name = "loose";
            this.loose.Size = new System.Drawing.Size(529, 99);
            this.loose.TabIndex = 3;
            this.loose.Text = "Вы проиграли";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamepanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.PictureBox gameball;
        private System.Windows.Forms.PictureBox gamepanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label loose;
    }
}


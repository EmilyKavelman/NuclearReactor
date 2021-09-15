
namespace NuclearReactor
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.Reactor01Label = new System.Windows.Forms.Label();
            this.Reactor02Label = new System.Windows.Forms.Label();
            this.r1label = new System.Windows.Forms.Label();
            this.r2label = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AccessibleName = "titleLabel";
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLabel.Location = new System.Drawing.Point(121, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(546, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nuclear Reactor Control";
            // 
            // Reactor01Label
            // 
            this.Reactor01Label.AccessibleName = "reactor1Label";
            this.Reactor01Label.AutoSize = true;
            this.Reactor01Label.BackColor = System.Drawing.SystemColors.ControlText;
            this.Reactor01Label.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactor01Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reactor01Label.Location = new System.Drawing.Point(119, 92);
            this.Reactor01Label.Name = "Reactor01Label";
            this.Reactor01Label.Size = new System.Drawing.Size(214, 32);
            this.Reactor01Label.TabIndex = 1;
            this.Reactor01Label.Text = "Reactor 01";
            this.Reactor01Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // Reactor02Label
            // 
            this.Reactor02Label.AccessibleName = "reactor2Label";
            this.Reactor02Label.AutoSize = true;
            this.Reactor02Label.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactor02Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reactor02Label.Location = new System.Drawing.Point(450, 92);
            this.Reactor02Label.Name = "Reactor02Label";
            this.Reactor02Label.Size = new System.Drawing.Size(214, 32);
            this.Reactor02Label.TabIndex = 2;
            this.Reactor02Label.Text = "Reactor 02";
            // 
            // r1label
            // 
            this.r1label.AccessibleName = "stateLabel1";
            this.r1label.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.r1label.BackColor = System.Drawing.Color.LimeGreen;
            this.r1label.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r1label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.r1label.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.r1label.Location = new System.Drawing.Point(125, 133);
            this.r1label.Name = "r1label";
            this.r1label.Size = new System.Drawing.Size(208, 134);
            this.r1label.TabIndex = 3;
            // 
            // r2label
            // 
            this.r2label.AccessibleName = "stateLabel1";
            this.r2label.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.r2label.BackColor = System.Drawing.Color.LimeGreen;
            this.r2label.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r2label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.r2label.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.r2label.Location = new System.Drawing.Point(450, 133);
            this.r2label.Name = "r2label";
            this.r2label.Size = new System.Drawing.Size(208, 134);
            this.r2label.TabIndex = 4;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(333, 294);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(117, 46);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(791, 414);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.r2label);
            this.Controls.Add(this.r1label);
            this.Controls.Add(this.Reactor02Label);
            this.Controls.Add(this.Reactor01Label);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "NuclearReactor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label Reactor01Label;
        private System.Windows.Forms.Label Reactor02Label;
        private System.Windows.Forms.Label r1label;
        private System.Windows.Forms.Label r2label;
        private System.Windows.Forms.Button StartButton;
    }
}


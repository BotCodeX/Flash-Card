namespace Flash_Card
{
    partial class FlashCard
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
            this.addNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addtoExist = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNew
            // 
            this.addNew.Font = new System.Drawing.Font("Augustus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNew.Location = new System.Drawing.Point(304, 169);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(178, 43);
            this.addNew.TabIndex = 0;
            this.addNew.Text = "ADD NEW";
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Augustus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "FLASHCARD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addtoExist
            // 
            this.addtoExist.Font = new System.Drawing.Font("Augustus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtoExist.Location = new System.Drawing.Point(269, 229);
            this.addtoExist.Name = "addtoExist";
            this.addtoExist.Size = new System.Drawing.Size(245, 43);
            this.addtoExist.TabIndex = 2;
            this.addtoExist.Text = "Add to existing card";
            this.addtoExist.UseVisualStyleBackColor = true;
            this.addtoExist.Click += new System.EventHandler(this.addtoExist_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Augustus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(304, 343);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(178, 42);
            this.exit.TabIndex = 3;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Augustus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(269, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FlashCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.addtoExist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addNew);
            this.Name = "FlashCard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FlashCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addtoExist;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button1;
    }
}


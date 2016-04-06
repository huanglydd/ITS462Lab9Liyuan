namespace DronesListClient
{
    partial class ServiceClient
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
            this.labelText = new System.Windows.Forms.Label();
            this.comboSelect = new System.Windows.Forms.ComboBox();
            this.textDisplay_Large = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Small = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(72, 28);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(41, 13);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "List By:";
            // 
            // comboSelect
            // 
            this.comboSelect.FormattingEnabled = true;
            this.comboSelect.Location = new System.Drawing.Point(134, 25);
            this.comboSelect.Name = "comboSelect";
            this.comboSelect.Size = new System.Drawing.Size(121, 21);
            this.comboSelect.TabIndex = 1;
            this.comboSelect.SelectedIndexChanged += new System.EventHandler(this.comboSelect_SelectedIndexChanged);
            // 
            // textDisplay_Large
            // 
            this.textDisplay_Large.Location = new System.Drawing.Point(198, 90);
            this.textDisplay_Large.Multiline = true;
            this.textDisplay_Large.Name = "textDisplay_Large";
            this.textDisplay_Large.Size = new System.Drawing.Size(362, 277);
            this.textDisplay_Large.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Detailed Information";
            // 
            // listBox_Small
            // 
            this.listBox_Small.FormattingEnabled = true;
            this.listBox_Small.Location = new System.Drawing.Point(13, 90);
            this.listBox_Small.Name = "listBox_Small";
            this.listBox_Small.Size = new System.Drawing.Size(162, 277);
            this.listBox_Small.TabIndex = 5;
            this.listBox_Small.SelectedIndexChanged += new System.EventHandler(this.listBox_Small_SelectedIndexChanged);
            // 
            // ServiceClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 393);
            this.Controls.Add(this.listBox_Small);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDisplay_Large);
            this.Controls.Add(this.comboSelect);
            this.Controls.Add(this.labelText);
            this.Name = "ServiceClient";
            this.Text = "Service Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.ComboBox comboSelect;
        private System.Windows.Forms.TextBox textDisplay_Large;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Small;
    }
}


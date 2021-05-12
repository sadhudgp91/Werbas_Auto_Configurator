namespace SchemaValidator
{
    partial class ValidateSchema
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtXMLFileName = new System.Windows.Forms.TextBox();
            this.btnBrowseXML = new System.Windows.Forms.Button();
            this.btnBrowseXSD = new System.Windows.Forms.Button();
            this.txtXSDFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter XML File Name: ";
            // 
            // txtXMLFileName
            // 
            this.txtXMLFileName.Location = new System.Drawing.Point(144, 19);
            this.txtXMLFileName.Name = "txtXMLFileName";
            this.txtXMLFileName.Size = new System.Drawing.Size(257, 20);
            this.txtXMLFileName.TabIndex = 1;
            // 
            // btnBrowseXML
            // 
            this.btnBrowseXML.Location = new System.Drawing.Point(407, 17);
            this.btnBrowseXML.Name = "btnBrowseXML";
            this.btnBrowseXML.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseXML.TabIndex = 2;
            this.btnBrowseXML.Text = "Browse...";
            this.btnBrowseXML.UseVisualStyleBackColor = true;
            this.btnBrowseXML.Click += new System.EventHandler(this.btnBrowseXML_Click);
            // 
            // btnBrowseXSD
            // 
            this.btnBrowseXSD.Location = new System.Drawing.Point(407, 46);
            this.btnBrowseXSD.Name = "btnBrowseXSD";
            this.btnBrowseXSD.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseXSD.TabIndex = 5;
            this.btnBrowseXSD.Text = "Browse...";
            this.btnBrowseXSD.UseVisualStyleBackColor = true;
            this.btnBrowseXSD.Click += new System.EventHandler(this.btnBrowseXSD_Click);
            // 
            // txtXSDFileName
            // 
            this.txtXSDFileName.Location = new System.Drawing.Point(144, 48);
            this.txtXSDFileName.Name = "txtXSDFileName";
            this.txtXSDFileName.Size = new System.Drawing.Size(257, 20);
            this.txtXSDFileName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Schema File Name: ";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(144, 74);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 6;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(326, 75);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ValidateSchema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 110);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnBrowseXSD);
            this.Controls.Add(this.txtXSDFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseXML);
            this.Controls.Add(this.txtXMLFileName);
            this.Controls.Add(this.label1);
            this.Name = "ValidateSchema";
            this.Text = "Schema_Validate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXMLFileName;
        private System.Windows.Forms.Button btnBrowseXML;
        private System.Windows.Forms.Button btnBrowseXSD;
        private System.Windows.Forms.TextBox txtXSDFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnReset;
    }
}


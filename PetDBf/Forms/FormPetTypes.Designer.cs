namespace PetDBf.Forms
{
    partial class FormPetTypes
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
            dataGridViewPetTypes = new DataGridView();
            textBoxPetType = new TextBox();
            buttonAddPetType = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPetTypes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPetTypes
            // 
            dataGridViewPetTypes.AllowUserToAddRows = false;
            dataGridViewPetTypes.AllowUserToDeleteRows = false;
            dataGridViewPetTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPetTypes.Location = new Point(12, 12);
            dataGridViewPetTypes.Name = "dataGridViewPetTypes";
            dataGridViewPetTypes.ReadOnly = true;
            dataGridViewPetTypes.RowHeadersWidth = 51;
            dataGridViewPetTypes.Size = new Size(280, 426);
            dataGridViewPetTypes.TabIndex = 0;
            // 
            // textBoxPetType
            // 
            textBoxPetType.Location = new Point(321, 12);
            textBoxPetType.Name = "textBoxPetType";
            textBoxPetType.Size = new Size(216, 27);
            textBoxPetType.TabIndex = 1;
            // 
            // buttonAddPetType
            // 
            buttonAddPetType.Location = new Point(321, 58);
            buttonAddPetType.Name = "buttonAddPetType";
            buttonAddPetType.Size = new Size(216, 75);
            buttonAddPetType.TabIndex = 2;
            buttonAddPetType.Text = "Add";
            buttonAddPetType.UseVisualStyleBackColor = true;
            buttonAddPetType.Click += buttonAddPetType_Click;
            // 
            // FormPetTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 450);
            Controls.Add(buttonAddPetType);
            Controls.Add(textBoxPetType);
            Controls.Add(dataGridViewPetTypes);
            Name = "FormPetTypes";
            Text = "PetTypes";
            Load += PetTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPetTypes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewPetTypes;
        private TextBox textBoxPetType;
        private Button buttonAddPetType;
    }
}
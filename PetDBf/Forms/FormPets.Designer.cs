namespace PetDBf.Forms
{
    partial class FormPets
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
            dataGridViewPets = new DataGridView();
            comboBoxFilterAdoption = new ComboBox();
            comboBoxFilterType = new ComboBox();
            labelAdoptionStatus = new Label();
            labelAnimalType = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            labelType = new Label();
            comboBoxType = new ComboBox();
            comboBoxGender = new ComboBox();
            labelGender = new Label();
            textBoxAge = new TextBox();
            labelAgeMonth = new Label();
            labelDescription = new Label();
            richTextBoxDescription = new RichTextBox();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonAddType = new Button();
            buttonAddPet = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPets).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPets
            // 
            dataGridViewPets.AllowUserToAddRows = false;
            dataGridViewPets.AllowUserToDeleteRows = false;
            dataGridViewPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPets.Location = new Point(12, 90);
            dataGridViewPets.Name = "dataGridViewPets";
            dataGridViewPets.ReadOnly = true;
            dataGridViewPets.RowHeadersWidth = 51;
            dataGridViewPets.Size = new Size(413, 429);
            dataGridViewPets.TabIndex = 0;
            dataGridViewPets.SelectionChanged += DataGridViewPets_SelectionChanged;
            // 
            // comboBoxFilterAdoption
            // 
            comboBoxFilterAdoption.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterAdoption.Location = new Point(134, 22);
            comboBoxFilterAdoption.Name = "comboBoxFilterAdoption";
            comboBoxFilterAdoption.Size = new Size(151, 28);
            comboBoxFilterAdoption.TabIndex = 1;
            comboBoxFilterAdoption.SelectionChangeCommitted += comboBoxFilterAdoption_SelectionChangeCommitted;
            // 
            // comboBoxFilterType
            // 
            comboBoxFilterType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterType.FormattingEnabled = true;
            comboBoxFilterType.Location = new Point(134, 56);
            comboBoxFilterType.Name = "comboBoxFilterType";
            comboBoxFilterType.Size = new Size(151, 28);
            comboBoxFilterType.TabIndex = 2;
            comboBoxFilterType.SelectionChangeCommitted += comboBoxFilterType_SelectionChangeCommitted;
            // 
            // labelAdoptionStatus
            // 
            labelAdoptionStatus.AutoSize = true;
            labelAdoptionStatus.Location = new Point(12, 25);
            labelAdoptionStatus.Name = "labelAdoptionStatus";
            labelAdoptionStatus.Size = new Size(114, 20);
            labelAdoptionStatus.TabIndex = 3;
            labelAdoptionStatus.Text = "Adoption status";
            // 
            // labelAnimalType
            // 
            labelAnimalType.AutoSize = true;
            labelAnimalType.Location = new Point(12, 59);
            labelAnimalType.Name = "labelAnimalType";
            labelAnimalType.Size = new Size(89, 20);
            labelAnimalType.TabIndex = 4;
            labelAnimalType.Text = "Animal type";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(537, 90);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(157, 27);
            textBoxName.TabIndex = 5;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(442, 93);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 6;
            labelName.Text = "Name";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(442, 172);
            labelType.Name = "labelType";
            labelType.Size = new Size(64, 20);
            labelType.TabIndex = 7;
            labelType.Text = "Pet Type";
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(537, 169);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(121, 28);
            comboBoxType.TabIndex = 8;
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(537, 128);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(157, 28);
            comboBoxGender.TabIndex = 12;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(442, 131);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(57, 20);
            labelGender.TabIndex = 11;
            labelGender.Text = "Gender";
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(537, 208);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(157, 27);
            textBoxAge.TabIndex = 14;
            // 
            // labelAgeMonth
            // 
            labelAgeMonth.AutoSize = true;
            labelAgeMonth.Location = new Point(442, 211);
            labelAgeMonth.Name = "labelAgeMonth";
            labelAgeMonth.Size = new Size(89, 20);
            labelAgeMonth.TabIndex = 13;
            labelAgeMonth.Text = "Age(month)";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(442, 245);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(85, 20);
            labelDescription.TabIndex = 15;
            labelDescription.Text = "Description";
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(442, 268);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(252, 119);
            richTextBoxDescription.TabIndex = 16;
            richTextBoxDescription.Text = "";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(442, 393);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(122, 60);
            buttonUpdate.TabIndex = 17;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(572, 393);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(122, 60);
            buttonDelete.TabIndex = 18;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAddType
            // 
            buttonAddType.Location = new Point(665, 169);
            buttonAddType.Name = "buttonAddType";
            buttonAddType.Size = new Size(29, 29);
            buttonAddType.TabIndex = 19;
            buttonAddType.Text = "+";
            buttonAddType.UseVisualStyleBackColor = true;
            buttonAddType.Click += buttonAddType_Click;
            // 
            // buttonAddPet
            // 
            buttonAddPet.Location = new Point(442, 459);
            buttonAddPet.Name = "buttonAddPet";
            buttonAddPet.Size = new Size(252, 60);
            buttonAddPet.TabIndex = 20;
            buttonAddPet.Text = "Add Pet";
            buttonAddPet.UseVisualStyleBackColor = true;
            buttonAddPet.Click += buttonAddPet_Click;
            // 
            // FormPets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 548);
            Controls.Add(buttonAddPet);
            Controls.Add(buttonAddType);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(richTextBoxDescription);
            Controls.Add(labelDescription);
            Controls.Add(textBoxAge);
            Controls.Add(labelAgeMonth);
            Controls.Add(comboBoxGender);
            Controls.Add(labelGender);
            Controls.Add(comboBoxType);
            Controls.Add(labelType);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelAnimalType);
            Controls.Add(labelAdoptionStatus);
            Controls.Add(comboBoxFilterType);
            Controls.Add(comboBoxFilterAdoption);
            Controls.Add(dataGridViewPets);
            Name = "FormPets";
            Text = "Pets";
            Load += Pets_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPets;
        private ComboBox comboBoxFilterAdoption;
        private ComboBox comboBoxFilterType;
        private Label labelAdoptionStatus;
        private Label labelAnimalType;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelType;
        private ComboBox comboBoxType;
        private ComboBox comboBoxGender;
        private Label labelGender;
        private TextBox textBoxAge;
        private Label labelAgeMonth;
        private Label labelDescription;
        private RichTextBox richTextBoxDescription;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonAddType;
        private Button buttonAddPet;
    }
}
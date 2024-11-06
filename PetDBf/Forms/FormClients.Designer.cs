namespace PetDBf.Forms
{
    partial class FormClients
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
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            textBoxPhone = new TextBox();
            labelPhone = new Label();
            comboBoxGender = new ComboBox();
            labelGender = new Label();
            labelName = new Label();
            textBoxName = new TextBox();
            dataGridViewClients = new DataGridView();
            textBoxAdress = new TextBox();
            labelAdress = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            buttonAdopt = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(439, 295);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(252, 60);
            buttonAdd.TabIndex = 39;
            buttonAdd.Text = "Add Client";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(569, 229);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(122, 60);
            buttonDelete.TabIndex = 37;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(439, 229);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(122, 60);
            buttonUpdate.TabIndex = 36;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(534, 130);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(157, 27);
            textBoxPhone.TabIndex = 33;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(439, 133);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(50, 20);
            labelPhone.TabIndex = 32;
            labelPhone.Text = "Phone";
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(534, 50);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(157, 28);
            comboBoxGender.TabIndex = 31;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(439, 53);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(57, 20);
            labelGender.TabIndex = 30;
            labelGender.Text = "Gender";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(439, 15);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 27;
            labelName.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(534, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(157, 27);
            textBoxName.TabIndex = 26;
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.AllowUserToAddRows = false;
            dataGridViewClients.AllowUserToDeleteRows = false;
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Location = new Point(14, 12);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.ReadOnly = true;
            dataGridViewClients.RowHeadersWidth = 51;
            dataGridViewClients.Size = new Size(413, 497);
            dataGridViewClients.TabIndex = 21;
            dataGridViewClients.SelectionChanged += DataGridViewClients_SelectionChanged;
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(534, 163);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(157, 27);
            textBoxAdress.TabIndex = 41;
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Location = new Point(439, 166);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(53, 20);
            labelAdress.TabIndex = 40;
            labelAdress.Text = "Adress";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(534, 196);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(157, 27);
            textBoxEmail.TabIndex = 43;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(439, 199);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 42;
            labelEmail.Text = "Email";
            // 
            // buttonAdopt
            // 
            buttonAdopt.Location = new Point(439, 449);
            buttonAdopt.Name = "buttonAdopt";
            buttonAdopt.Size = new Size(252, 60);
            buttonAdopt.TabIndex = 44;
            buttonAdopt.Text = "Adopt Pet";
            buttonAdopt.UseVisualStyleBackColor = true;
            buttonAdopt.Click += buttonAdopt_Click;
            // 
            // FormClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 525);
            Controls.Add(buttonAdopt);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxAdress);
            Controls.Add(labelAdress);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(textBoxPhone);
            Controls.Add(labelPhone);
            Controls.Add(comboBoxGender);
            Controls.Add(labelGender);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(dataGridViewClients);
            Name = "FormClients";
            Text = "FormClients";
            Load += FormClients_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private Button buttonAddType;
        private Button buttonDelete;
        private Button buttonUpdate;
        private TextBox textBoxPhone;
        private RichTextBox richTextBoxDescription;
        private Label labelDescription;
        private TextBox textBoxAge;
        private Label labelPhone;
        private ComboBox comboBoxGender;
        private Label labelGender;
        private ComboBox comboBoxType;
        private Label labelType;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelAnimalType;
        private Label labelAdoptionStatus;
        private ComboBox comboBoxFilterType;
        private ComboBox comboBoxFilterAdoption;
        private DataGridView dataGridViewClients;
        private TextBox textBoxAdress;
        private Label labelAdress;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Button buttonAdopt;
    }
}
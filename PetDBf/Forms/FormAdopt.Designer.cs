namespace PetDBf.Forms
{
    partial class FormAdopt
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
            labelGreeting = new Label();
            dataGridViewAdopted = new DataGridView();
            labelHasAdopted = new Label();
            labelToAdopt = new Label();
            buttonAdopt = new Button();
            dataGridViewToAdopt = new DataGridView();
            buttonReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdopted).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewToAdopt).BeginInit();
            SuspendLayout();
            // 
            // labelGreeting
            // 
            labelGreeting.AutoSize = true;
            labelGreeting.Font = new Font("Segoe UI", 20F);
            labelGreeting.Location = new Point(137, 22);
            labelGreeting.Name = "labelGreeting";
            labelGreeting.Size = new Size(536, 46);
            labelGreeting.TabIndex = 0;
            labelGreeting.Text = "Name, welcome on adoption page";
            // 
            // dataGridViewAdopted
            // 
            dataGridViewAdopted.AllowUserToAddRows = false;
            dataGridViewAdopted.AllowUserToDeleteRows = false;
            dataGridViewAdopted.AllowUserToResizeColumns = false;
            dataGridViewAdopted.AllowUserToResizeRows = false;
            dataGridViewAdopted.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAdopted.Location = new Point(23, 106);
            dataGridViewAdopted.MultiSelect = false;
            dataGridViewAdopted.Name = "dataGridViewAdopted";
            dataGridViewAdopted.ReadOnly = true;
            dataGridViewAdopted.RowHeadersWidth = 51;
            dataGridViewAdopted.Size = new Size(442, 465);
            dataGridViewAdopted.TabIndex = 1;
            dataGridViewAdopted.SelectionChanged += dataGridViewAdopted_SelectionChanged;
            // 
            // labelHasAdopted
            // 
            labelHasAdopted.AutoSize = true;
            labelHasAdopted.Location = new Point(23, 83);
            labelHasAdopted.Name = "labelHasAdopted";
            labelHasAdopted.Size = new Size(169, 20);
            labelHasAdopted.TabIndex = 3;
            labelHasAdopted.Text = "Already adopted by You";
            // 
            // labelToAdopt
            // 
            labelToAdopt.AutoSize = true;
            labelToAdopt.Location = new Point(471, 83);
            labelToAdopt.Name = "labelToAdopt";
            labelToAdopt.Size = new Size(101, 20);
            labelToAdopt.TabIndex = 4;
            labelToAdopt.Text = "Pets To Adopt";
            // 
            // buttonAdopt
            // 
            buttonAdopt.Location = new Point(944, 393);
            buttonAdopt.Name = "buttonAdopt";
            buttonAdopt.Size = new Size(141, 81);
            buttonAdopt.TabIndex = 5;
            buttonAdopt.Text = "Adopt";
            buttonAdopt.UseVisualStyleBackColor = true;
            buttonAdopt.Click += buttonAdopt_Click;
            // 
            // dataGridViewToAdopt
            // 
            dataGridViewToAdopt.AllowUserToAddRows = false;
            dataGridViewToAdopt.AllowUserToDeleteRows = false;
            dataGridViewToAdopt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewToAdopt.Location = new Point(471, 106);
            dataGridViewToAdopt.Name = "dataGridViewToAdopt";
            dataGridViewToAdopt.ReadOnly = true;
            dataGridViewToAdopt.RowHeadersWidth = 51;
            dataGridViewToAdopt.Size = new Size(442, 465);
            dataGridViewToAdopt.TabIndex = 6;
            dataGridViewToAdopt.SelectionChanged += dataGridViewToAdopt_SelectionChanged;
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(944, 490);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(141, 81);
            buttonReturn.TabIndex = 7;
            buttonReturn.Text = "ReturnBack";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // FormAdopt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 583);
            Controls.Add(buttonReturn);
            Controls.Add(dataGridViewToAdopt);
            Controls.Add(buttonAdopt);
            Controls.Add(labelToAdopt);
            Controls.Add(labelHasAdopted);
            Controls.Add(dataGridViewAdopted);
            Controls.Add(labelGreeting);
            Name = "FormAdopt";
            Text = "FormAdopt";
            Load += FormAdopt_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdopted).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewToAdopt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGreeting;
        private DataGridView dataGridViewAdopted;
        private Label labelHasAdopted;
        private Label labelToAdopt;
        private Button buttonAdopt;
        private DataGridView dataGridViewToAdopt;
        private Button buttonReturn;
    }
}
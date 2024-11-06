namespace PetDBf
{
    partial class HomePage
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
            label1 = new Label();
            clients = new Button();
            petTypes = new Button();
            pets = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(131, 44);
            label1.Name = "label1";
            label1.Size = new Size(555, 46);
            label1.TabIndex = 1;
            label1.Text = "Welcome to the PetHome Database";
            // 
            // clients
            // 
            clients.Font = new Font("Segoe UI", 20F);
            clients.Location = new Point(475, 227);
            clients.Name = "clients";
            clients.Size = new Size(211, 64);
            clients.TabIndex = 0;
            clients.Text = "Clients";
            clients.UseVisualStyleBackColor = true;
            clients.Click += clients_Click;
            // 
            // petTypes
            // 
            petTypes.Font = new Font("Segoe UI", 20F);
            petTypes.Location = new Point(131, 193);
            petTypes.Name = "petTypes";
            petTypes.Size = new Size(211, 64);
            petTypes.TabIndex = 2;
            petTypes.Text = "Pet Types";
            petTypes.UseVisualStyleBackColor = true;
            petTypes.Click += petTypes_Click;
            // 
            // pets
            // 
            pets.Font = new Font("Segoe UI", 20F);
            pets.Location = new Point(131, 275);
            pets.Name = "pets";
            pets.Size = new Size(211, 64);
            pets.TabIndex = 3;
            pets.Text = "Pets";
            pets.UseVisualStyleBackColor = true;
            pets.Click += pets_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pets);
            Controls.Add(petTypes);
            Controls.Add(label1);
            Controls.Add(clients);
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button clients;
        private Button petTypes;
        private Button pets;
    }
}

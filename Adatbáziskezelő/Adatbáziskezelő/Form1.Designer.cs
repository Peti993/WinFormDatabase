namespace Adatbáziskezelő
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tablegroup = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tools = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refresh = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.address_text = new System.Windows.Forms.TextBox();
            this.firstName_text = new System.Windows.Forms.TextBox();
            this.lastName_text = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.idpersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tablegroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tools.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idpersonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tablegroup
            // 
            resources.ApplyResources(this.tablegroup, "tablegroup");
            this.tablegroup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tablegroup.Controls.Add(this.dataGridView1);
            this.tablegroup.Name = "tablegroup";
            this.tablegroup.TabStop = false;
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            // 
            // tools
            // 
            resources.ApplyResources(this.tools, "tools");
            this.tools.Controls.Add(this.comboBox1);
            this.tools.Controls.Add(this.groupBox1);
            this.tools.Controls.Add(this.label3);
            this.tools.Controls.Add(this.label2);
            this.tools.Controls.Add(this.label1);
            this.tools.Controls.Add(this.address_text);
            this.tools.Controls.Add(this.firstName_text);
            this.tools.Controls.Add(this.lastName_text);
            this.tools.Controls.Add(this.id_label);
            this.tools.Name = "tools";
            this.tools.TabStop = false;
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.refresh);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // refresh
            // 
            resources.ApplyResources(this.refresh, "refresh");
            this.refresh.Name = "refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // add
            // 
            resources.ApplyResources(this.add, "add");
            this.add.Name = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            resources.ApplyResources(this.delete, "delete");
            this.delete.Name = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            resources.ApplyResources(this.update, "update");
            this.update.Name = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // address_text
            // 
            resources.ApplyResources(this.address_text, "address_text");
            this.address_text.Name = "address_text";
            this.address_text.ReadOnly = true;
            // 
            // firstName_text
            // 
            resources.ApplyResources(this.firstName_text, "firstName_text");
            this.firstName_text.Name = "firstName_text";
            this.firstName_text.ReadOnly = true;
            // 
            // lastName_text
            // 
            resources.ApplyResources(this.lastName_text, "lastName_text");
            this.lastName_text.Name = "lastName_text";
            this.lastName_text.ReadOnly = true;
            // 
            // id_label
            // 
            resources.ApplyResources(this.id_label, "id_label");
            this.id_label.Name = "id_label";
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // idpersonBindingSource
            // 
            this.idpersonBindingSource.DataSource = typeof(Adatbáziskezelő.id_person);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.tools);
            this.Controls.Add(this.tablegroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tablegroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.idpersonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox tablegroup;
        private GroupBox tools;
        private GroupBox groupBox1;
        private Button delete;
        private Button update;
        //private Button newdata;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox address_text;
        private TextBox firstName_text;
        private TextBox lastName_text;
        private Label id_label;
        private ComboBox comboBox1;
        private ContextMenuStrip contextMenuStrip1;
        private BindingSource idpersonBindingSource;
        private DataGridView dataGridView1;
        private Button add;
        private FontDialog fontDialog1;
        private Button refresh;
    }
}
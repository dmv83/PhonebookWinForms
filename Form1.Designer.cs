
namespace PhonebookWinForms {
  partial class Form1 {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.dvg_Persons = new System.Windows.Forms.DataGridView();
      this.phonebookDataSet = new PhonebookWinForms.PhonebookDataSet();
      this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.personsTableAdapter = new PhonebookWinForms.PhonebookDataSetTableAdapters.PersonsTableAdapter();
      this.dgv_Phone = new System.Windows.Forms.DataGridView();
      this.btAdd = new System.Windows.Forms.Button();
      this.btUpdate = new System.Windows.Forms.Button();
      this.btDelPerson = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.tbFirstName = new System.Windows.Forms.TextBox();
      this.tbBirthDate = new System.Windows.Forms.TextBox();
      this.tbPartonymic = new System.Windows.Forms.TextBox();
      this.tbLastName = new System.Windows.Forms.TextBox();
      this.tbCity = new System.Windows.Forms.TextBox();
      this.tbState = new System.Windows.Forms.TextBox();
      this.tbZipCode = new System.Windows.Forms.TextBox();
      this.tbStreet = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.tbSearch = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label12 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lbStarFN = new System.Windows.Forms.Label();
      this.lbStarLN = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dvg_Persons)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.phonebookDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Phone)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dvg_Persons
      // 
      this.dvg_Persons.AllowUserToOrderColumns = true;
      this.dvg_Persons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dvg_Persons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dvg_Persons.Location = new System.Drawing.Point(10, 201);
      this.dvg_Persons.Margin = new System.Windows.Forms.Padding(1);
      this.dvg_Persons.Name = "dvg_Persons";
      this.dvg_Persons.RowHeadersWidth = 20;
      this.dvg_Persons.Size = new System.Drawing.Size(772, 163);
      this.dvg_Persons.TabIndex = 1;
      // 
      // phonebookDataSet
      // 
      this.phonebookDataSet.DataSetName = "PhonebookDataSet";
      this.phonebookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // personsBindingSource
      // 
      this.personsBindingSource.DataMember = "Persons";
      this.personsBindingSource.DataSource = this.phonebookDataSet;
      // 
      // personsTableAdapter
      // 
      this.personsTableAdapter.ClearBeforeFill = true;
      // 
      // dgv_Phone
      // 
      this.dgv_Phone.AllowUserToOrderColumns = true;
      this.dgv_Phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgv_Phone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_Phone.Location = new System.Drawing.Point(368, 105);
      this.dgv_Phone.Name = "dgv_Phone";
      this.dgv_Phone.Size = new System.Drawing.Size(306, 80);
      this.dgv_Phone.TabIndex = 10;
      // 
      // btAdd
      // 
      this.btAdd.Location = new System.Drawing.Point(3, 69);
      this.btAdd.Name = "btAdd";
      this.btAdd.Size = new System.Drawing.Size(102, 29);
      this.btAdd.TabIndex = 11;
      this.btAdd.Text = "Add (A)";
      this.btAdd.UseVisualStyleBackColor = true;
      this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
      // 
      // btUpdate
      // 
      this.btUpdate.Location = new System.Drawing.Point(3, 112);
      this.btUpdate.Name = "btUpdate";
      this.btUpdate.Size = new System.Drawing.Size(102, 29);
      this.btUpdate.TabIndex = 12;
      this.btUpdate.Text = "Update (S)";
      this.btUpdate.UseVisualStyleBackColor = true;
      this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
      // 
      // btDelPerson
      // 
      this.btDelPerson.Location = new System.Drawing.Point(3, 155);
      this.btDelPerson.Name = "btDelPerson";
      this.btDelPerson.Size = new System.Drawing.Size(102, 29);
      this.btDelPerson.TabIndex = 13;
      this.btDelPerson.Text = "Delete (D)";
      this.btDelPerson.UseVisualStyleBackColor = true;
      this.btDelPerson.Click += new System.EventHandler(this.btDelPerson_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 79);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(57, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "First Name";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 109);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(58, 13);
      this.label4.TabIndex = 0;
      this.label4.Text = "Last Name";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 139);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(59, 13);
      this.label5.TabIndex = 0;
      this.label5.Text = "Patronymic";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(12, 169);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(54, 13);
      this.label6.TabIndex = 0;
      this.label6.Text = "Birth Date";
      // 
      // tbFirstName
      // 
      this.tbFirstName.Location = new System.Drawing.Point(76, 75);
      this.tbFirstName.Name = "tbFirstName";
      this.tbFirstName.ReadOnly = true;
      this.tbFirstName.Size = new System.Drawing.Size(100, 20);
      this.tbFirstName.TabIndex = 2;
      // 
      // tbLastName
      // 
      this.tbLastName.Location = new System.Drawing.Point(76, 105);
      this.tbLastName.Name = "tbLastName";
      this.tbLastName.ReadOnly = true;
      this.tbLastName.Size = new System.Drawing.Size(100, 20);
      this.tbLastName.TabIndex = 3;
      // 
      // tbPartonymic
      // 
      this.tbPartonymic.Location = new System.Drawing.Point(77, 135);
      this.tbPartonymic.Name = "tbPartonymic";
      this.tbPartonymic.ReadOnly = true;
      this.tbPartonymic.Size = new System.Drawing.Size(100, 20);
      this.tbPartonymic.TabIndex = 4;
      // 
      // tbBirthDate
      // 
      this.tbBirthDate.Location = new System.Drawing.Point(77, 165);
      this.tbBirthDate.Name = "tbBirthDate";
      this.tbBirthDate.ReadOnly = true;
      this.tbBirthDate.Size = new System.Drawing.Size(100, 20);
      this.tbBirthDate.TabIndex = 5;
      // 
      // tbStreet
      // 
      this.tbStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbStreet.Location = new System.Drawing.Point(252, 75);
      this.tbStreet.Name = "tbStreet";
      this.tbStreet.ReadOnly = true;
      this.tbStreet.Size = new System.Drawing.Size(422, 20);
      this.tbStreet.TabIndex = 6;
      // 
      // tbCity
      // 
      this.tbCity.Location = new System.Drawing.Point(252, 105);
      this.tbCity.Name = "tbCity";
      this.tbCity.ReadOnly = true;
      this.tbCity.Size = new System.Drawing.Size(100, 20);
      this.tbCity.TabIndex = 7;
      // 
      // tbState
      // 
      this.tbState.Location = new System.Drawing.Point(253, 135);
      this.tbState.Name = "tbState";
      this.tbState.ReadOnly = true;
      this.tbState.Size = new System.Drawing.Size(100, 20);
      this.tbState.TabIndex = 8;
      // 
      // tbZipCode
      // 
      this.tbZipCode.Location = new System.Drawing.Point(253, 165);
      this.tbZipCode.Name = "tbZipCode";
      this.tbZipCode.ReadOnly = true;
      this.tbZipCode.Size = new System.Drawing.Size(100, 20);
      this.tbZipCode.TabIndex = 9;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(196, 169);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(50, 13);
      this.label7.TabIndex = 23;
      this.label7.Text = "Zip Code";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(196, 139);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(32, 13);
      this.label8.TabIndex = 22;
      this.label8.Text = "State";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(196, 109);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(24, 13);
      this.label9.TabIndex = 21;
      this.label9.Text = "City";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(196, 79);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(35, 13);
      this.label10.TabIndex = 20;
      this.label10.Text = "Street";
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "First Name or Last Name",
            "Phone Number"});
      this.comboBox1.Location = new System.Drawing.Point(15, 31);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(161, 21);
      this.comboBox1.TabIndex = 29;
      // 
      // tbSearch
      // 
      this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbSearch.Location = new System.Drawing.Point(183, 31);
      this.tbSearch.Name = "tbSearch";
      this.tbSearch.Size = new System.Drawing.Size(491, 20);
      this.tbSearch.TabIndex = 30;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(3, 26);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(102, 29);
      this.button1.TabIndex = 31;
      this.button1.Text = "Search";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(15, 7);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(75, 13);
      this.label12.TabIndex = 32;
      this.label12.Text = "Search criteria";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btUpdate);
      this.panel1.Controls.Add(this.btAdd);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.btDelPerson);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel1.Location = new System.Drawing.Point(680, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(116, 374);
      this.panel1.TabIndex = 33;
      // 
      // lbStarFN
      // 
      this.lbStarFN.AutoSize = true;
      this.lbStarFN.ForeColor = System.Drawing.Color.Coral;
      this.lbStarFN.Location = new System.Drawing.Point(65, 79);
      this.lbStarFN.Name = "lbStarFN";
      this.lbStarFN.Size = new System.Drawing.Size(11, 13);
      this.lbStarFN.TabIndex = 34;
      this.lbStarFN.Text = "*";
      this.lbStarFN.Visible = false;
      // 
      // lbStarLN
      // 
      this.lbStarLN.AutoSize = true;
      this.lbStarLN.ForeColor = System.Drawing.Color.Coral;
      this.lbStarLN.Location = new System.Drawing.Point(65, 109);
      this.lbStarLN.Name = "lbStarLN";
      this.lbStarLN.Size = new System.Drawing.Size(11, 13);
      this.lbStarLN.TabIndex = 35;
      this.lbStarLN.Text = "*";
      this.lbStarLN.Visible = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(796, 374);
      this.Controls.Add(this.lbStarLN);
      this.Controls.Add(this.lbStarFN);
      this.Controls.Add(this.dvg_Persons);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.tbSearch);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.tbCity);
      this.Controls.Add(this.tbState);
      this.Controls.Add(this.tbZipCode);
      this.Controls.Add(this.tbStreet);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.tbLastName);
      this.Controls.Add(this.tbPartonymic);
      this.Controls.Add(this.tbBirthDate);
      this.Controls.Add(this.tbFirstName);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.dgv_Phone);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load_1);
      ((System.ComponentModel.ISupportInitialize)(this.dvg_Persons)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.phonebookDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Phone)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dvg_Persons;
    private PhonebookDataSet phonebookDataSet;
    private System.Windows.Forms.BindingSource personsBindingSource;
    private PhonebookDataSetTableAdapters.PersonsTableAdapter personsTableAdapter;
    private System.Windows.Forms.DataGridView dgv_Phone;
    private System.Windows.Forms.Button btAdd;
    private System.Windows.Forms.Button btUpdate;
    private System.Windows.Forms.Button btDelPerson;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox tbFirstName;
    private System.Windows.Forms.TextBox tbBirthDate;
    private System.Windows.Forms.TextBox tbPartonymic;
    private System.Windows.Forms.TextBox tbLastName;
    private System.Windows.Forms.TextBox tbCity;
    private System.Windows.Forms.TextBox tbState;
    private System.Windows.Forms.TextBox tbZipCode;
    private System.Windows.Forms.TextBox tbStreet;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.TextBox tbSearch;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lbStarFN;
    private System.Windows.Forms.Label lbStarLN;
  }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhonebookWinForms {


  public partial class Form1 : Form {

    BindingSource _bsPerson = new BindingSource();
    BindingSource _bsPhone = new BindingSource();
    public Form1() {
      InitializeComponent();


      dvg_Persons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dvg_Persons.AllowUserToOrderColumns = true;
      dvg_Persons.AllowUserToResizeColumns = true;
      dvg_Persons.ReadOnly = true;
      dvg_Persons.AutoGenerateColumns = false;
      dvg_Persons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dvg_Persons.MultiSelect = false;
      dvg_Persons.ColumnCount = 9;

      dvg_Persons.Columns[0].HeaderText = "Id";
      dvg_Persons.Columns[1].HeaderText = "FirstName";
      dvg_Persons.Columns[2].HeaderText = "LastName";
      dvg_Persons.Columns[3].HeaderText = "Patronymic";
      dvg_Persons.Columns[4].HeaderText = "BirthDate";
      dvg_Persons.Columns[5].HeaderText = "Street";
      dvg_Persons.Columns[6].HeaderText = "City";
      dvg_Persons.Columns[7].HeaderText = "State";
      dvg_Persons.Columns[8].HeaderText = "ZipCode";

      dvg_Persons.Columns[0].DataPropertyName = "Id";
      dvg_Persons.Columns[1].DataPropertyName = "FirstName";
      dvg_Persons.Columns[2].DataPropertyName = "LastName";
      dvg_Persons.Columns[3].DataPropertyName = "Patronymic";
      dvg_Persons.Columns[4].DataPropertyName = "BirthDate";
      dvg_Persons.Columns[5].DataPropertyName = "Street";
      dvg_Persons.Columns[6].DataPropertyName = "City";
      dvg_Persons.Columns[7].DataPropertyName = "State";
      dvg_Persons.Columns[8].DataPropertyName = "ZipCode";

      dgv_Phone.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dgv_Phone.AllowUserToOrderColumns = true;
      dgv_Phone.AllowUserToResizeColumns = true;
      dgv_Phone.ReadOnly = true;
      dgv_Phone.AutoGenerateColumns = false;
      dgv_Phone.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dgv_Phone.MultiSelect = false;
      dgv_Phone.ColumnCount = 1;
      //dgv_Phone.Columns[0].HeaderText = "IdPerson";
      dgv_Phone.Columns[0].HeaderText = "Number";
      //dgv_Phone.Columns[0].DataPropertyName = "IdPerson";
      dgv_Phone.Columns[0].DataPropertyName = "Number";

    }

    private void Form1_Load_1(object sender, EventArgs e) {
      _bsPerson.PositionChanged += delegate (object obj, EventArgs ea) {
        LoadCard();
        LoadPhones();
      };
      LoadPersons();
    }

    void LoadPersons(long id = 1) {
      long size = 25;
      using (var conn = new SqlConnection(Globals.PhonebookConnString)) {
        var personList = new List<Person>();
        if (id > 1) {
          personList.Add(PhonebookWinForms.Person.Get(id));
        } else {
          for (var i = 1; i < size; i++) {
            var Person = PhonebookWinForms.Person.Get(i);
            personList.Add(Person);
          }
        }
        _bsPerson.DataSource = personList;
        dvg_Persons.DataSource = _bsPerson;
      }
    }

    void LoadCard() {
      Person person = _bsPerson.Current as Person;
      if (person != null) {
        tbFirstName.Text = person.FirstName;
        tbLastName.Text = person.LastName;
        tbPartonymic.Text = person.Patronymic;
        tbBirthDate.Text = person.BirthDate?.ToShortDateString();
        tbStreet.Text = person.Street;
        tbCity.Text = person.City;
        tbState.Text = person.State;
        tbZipCode.Text = person.ZipCode;
      } else {
        ClearCard();
      }
    }

    void ClearCard() {
      tbFirstName.Clear();
      tbLastName.Clear();
      tbPartonymic.Clear();
      tbBirthDate.Clear();
      tbStreet.Clear();
      tbCity.Clear();
      tbState.Clear();
      tbZipCode.Clear();
    }

    void ReadOnlyCard(bool flag) {
      tbFirstName.ReadOnly = flag;
      tbLastName.ReadOnly = flag;
      tbPartonymic.ReadOnly = flag;
      tbBirthDate.ReadOnly = flag;
      tbStreet.ReadOnly = flag;
      tbCity.ReadOnly = flag;
      tbState.ReadOnly = flag;
      tbZipCode.ReadOnly = flag;
    }

    void LoadPhones() {
      Person person = _bsPerson.Current as Person;
      if (person != null) {
        using (var conn = new SqlConnection(Globals.PhonebookConnString)) {
          var PhoneList = PhonebookWinForms.Phone.Get(person.ID);
          _bsPhone.DataSource = PhoneList;
          _bsPhone.Position = 0;
          dgv_Phone.DataSource = _bsPhone;
        }
      } else
        _bsPhone.DataSource = null;
    }

    private void btDelPerson_Click(object sender, EventArgs e) {
      DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete Person confirmation", MessageBoxButtons.YesNo);
      if (dialogResult == DialogResult.Yes) {
        var person = (Person)_bsPerson.Current;
        PhonebookWinForms.Person.Delete(person.ID);
        LoadPersons();
        ClearCard();
      }
    }

    private void button1_Click(object sender, EventArgs e) {
      if (comboBox1.SelectedIndex == 0) {
        var personList = PhonebookWinForms.Person.SearchByName(tbSearch.Text);
        _bsPerson.DataSource = personList;
        dvg_Persons.DataSource = _bsPerson;
        LoadCard();
        LoadPhones();
        dvg_Persons.Focus();
      } else {
        var personList = PhonebookWinForms.Phone.SearchByNumber(tbSearch.Text);
        _bsPerson.DataSource = personList;
        dvg_Persons.DataSource = _bsPerson;
        LoadCard();
        LoadPhones();
        dvg_Persons.Focus();
      }
      
    }

    private void btUpdate_Click(object sender, EventArgs e) {
      if (tbFirstName.ReadOnly) {
        LoadFormUpd(false);
        tbFirstName.Focus();
      } else {
        DialogResult dialogResult = MessageBox.Show("Are you sure?", "Add Person confirmation", MessageBoxButtons.YesNoCancel);
        if (dialogResult == DialogResult.Yes) {
          if (String.IsNullOrEmpty(tbFirstName.Text)) {
            tbFirstName.Focus();
          } else if (String.IsNullOrEmpty(tbLastName.Text)) {
            tbLastName.Focus();
          } else {
            Person newPerson = new Person() {
              FirstName = tbFirstName.Text,
              LastName = tbLastName.Text,
              Patronymic = tbPartonymic.Text,
              //BirthDate = !(String.IsNullOrEmpty(tbBirthDate.Text)) ? Convert.ToDateTime(tbBirthDate.Text) : null;
              BirthDate = Convert.ToDateTime(tbBirthDate.Text),
              Street = tbStreet.Text,
              City = tbCity.Text,
              State = tbState.Text,
              ZipCode = tbZipCode.Text
            };
            Person person = _bsPerson.Current as Person;
            Person.Update(person.ID, newPerson);
            LoadPersons(person.ID);
            LoadFormUpd(true);
          }
        } else if (dialogResult == DialogResult.No) {
          return;
        } else if (dialogResult == DialogResult.Cancel) {
          Person person = _bsPerson.Current as Person;
          LoadPersons(person.ID);
          LoadCard();
          LoadFormUpd(true);
        }
      }
    }

    void LoadFormUpd(bool flag) {
      ReadOnlyCard(flag);
      btDelPerson.Enabled = flag;
      btAdd.Enabled = flag;
      button1.Enabled = flag;
      comboBox1.Enabled = flag;
      tbSearch.Enabled = flag;
      dvg_Persons.Enabled = flag;
      lbStarFN.Visible = !flag;
      lbStarLN.Visible = !flag;
    }

    void LoadFormAdd(bool flag) {
      ReadOnlyCard(flag);
      btDelPerson.Enabled = flag;
      btUpdate.Enabled = flag;
      button1.Enabled = flag;
      comboBox1.Enabled = flag;
      tbSearch.Enabled = flag;
      dvg_Persons.Enabled = flag;
      lbStarFN.Visible = !flag;
      lbStarLN.Visible = !flag;
    }



    private void btAdd_Click(object sender, EventArgs e) {
      if (tbFirstName.ReadOnly) {
        ClearCard();
        LoadFormAdd(false);
        tbFirstName.Focus();
      } else {
        DialogResult dialogResult = MessageBox.Show("Are you sure?", "Add Person confirmation", MessageBoxButtons.YesNoCancel);
        if (dialogResult == DialogResult.Yes) {
          if (String.IsNullOrEmpty(tbFirstName.Text)) {
            tbFirstName.Focus();
          } else if (String.IsNullOrEmpty(tbLastName.Text)) {
            tbLastName.Focus();
          } else {
            Person newPerson = new Person() {
              FirstName = tbFirstName.Text,
              LastName = tbLastName.Text,
              Patronymic = tbPartonymic.Text,
              BirthDate = Convert.ToDateTime(tbBirthDate.Text),
              Street = tbStreet.Text,
              City = tbCity.Text,
              State = tbState.Text,
              ZipCode = tbZipCode.Text
            };
            long id = Person.Add(newPerson);
            LoadPersons(id);
            LoadFormAdd(true);
          }
        } else if (dialogResult == DialogResult.No) {
          return;
        } else if (dialogResult == DialogResult.Cancel) {
          Person person = _bsPerson.Current as Person;
          LoadPersons(person.ID);
          LoadCard();
          LoadFormAdd(true);
        }  
      }

    }
  }
}

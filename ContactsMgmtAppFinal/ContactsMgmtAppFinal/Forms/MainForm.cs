using ContactsMgmtAppFinal.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsMgmtAppFinal.DataLayer;

namespace ContactsMgmtAppFinal
{
    public partial class MainForm : Form
    {
        private ContactsDB _contactsDB;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEditContacts_Click(object sender, EventArgs e)
        {
            ContactTypesForm contactTypesForm = new ContactTypesForm();
            contactTypesForm.Show();
            
                
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            String strConn = System.Configuration.ConfigurationManager.ConnectionStrings["SQLServer"].ToString();
            _contactsDB = new ContactsDB(strConn);

            _contactsDB.Open();
            bsContacts.DataSource = _contactsDB.getContacts();
            _contactsDB.Close();
        }

        private void editContactInfoBtn_Click(object sender, EventArgs e)
        {
            SelectandEdit();

        }

        

        private void SelectandEdit()
        {
            _contactsDB.Open();
            ContactEditForm frmEdit = new ContactEditForm();
            DataTable dtHeader = _contactsDB.getContacts();
            frmEdit.LoadData(dtHeader, bsContacts);
            _contactsDB.Close();

            DialogResult dr;
            dr = frmEdit.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                _contactsDB.Open();
                _contactsDB.updateContactHeaderData(_contactsDB.ContactsHeaderTable);
                _contactsDB.refreshContactData();
                _contactsDB.Close();
               
            }
        }
        private void InsertContactInfo()
        {
            _contactsDB.Open();
            ContactEditForm frmEdit = new ContactEditForm();
            DataTable dtHeader = _contactsDB.getContacts();
            
            bsContacts.AddNew();

            _contactsDB.Close();

            frmEdit.LoadData(dtHeader, bsContacts);


            DialogResult dr;
            dr = frmEdit.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                _contactsDB.Open();
                _contactsDB.updateContactHeaderData(_contactsDB.ContactsHeaderTable);
                _contactsDB.refreshContactData();
                _contactsDB.Close();
            }
        }
        private void DeleteContactInfo()
        {

            if (MessageBox.Show($"Are you sure you want to Delete {mainDGV.CurrentRow.Cells[1].Value} - {mainDGV.CurrentRow.Cells[0].Value} - {mainDGV.CurrentRow.Cells[1].Value}", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bsContacts.RemoveCurrent();
                _contactsDB.Open();
                _contactsDB.updateContactHeaderData(_contactsDB.ContactsHeaderTable);
                _contactsDB.refreshContactData();
                _contactsDB.Close();
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteContactInfo();

        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertContactInfo();
        }
    }
}

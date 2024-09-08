using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using ContactsMgmtAppFinal.DataLayer;

namespace ContactsMgmtAppFinal.Forms
{
    public partial class ContactTypesForm : Form
    {
        private ContactsDB _contactsDB;

        public ContactTypesForm()
        {
            InitializeComponent();
        }

        private void ContactTypesForm_Load(object sender, EventArgs e)
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["SQLServer"].ToString();
            _contactsDB = new ContactsDB(connString);

            _contactsDB.Open();
            bsContactType.DataSource = _contactsDB.getContactTypes();
            _contactsDB.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveData()
        {
            if (MessageBox.Show(ContactsRes.editFormSave, "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bsContactType.EndEdit();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertContactType();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteContactType();
        }

        

        private void DeleteContactType()
        {

            if (MessageBox.Show($"Are you sure you want to Delete {contactTypeDGV.CurrentRow.Cells[1].Value} - {contactTypeDGV.CurrentRow.Cells[0].Value} - {contactTypeDGV.CurrentRow.Cells[1].Value}", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bsContactType.RemoveCurrent();
                _contactsDB.Open();
                _contactsDB.updateContactTypesData(_contactsDB.ContactTypesTable);
                _contactsDB.refreshContactsTypeData();
                _contactsDB.Close();
            }

        }

        private void InsertContactType()
        {
            _contactsDB.Open();
            DataTable dtContactType = _contactsDB.ContactTypesTable;
            bsContactType.AddNew();
            _contactsDB.Close();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            InsertContactType();
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {
            DeleteContactType();
        }
    }
}

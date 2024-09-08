using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsMgmtAppFinal.Forms
{
    public partial class ContactEditForm : Form
    {
        public DataTable contactsPersInfoTable;
        public ContactEditForm()
        {
            InitializeComponent();
        }

        public void LoadData(DataTable contactHeader, BindingSource ContactsBindingSource)
        {
            bsContacts = ContactsBindingSource;

        }

        private void ContactEditForm_Load(object sender, EventArgs e)
        {
            textBoxID.DataBindings.Add(new Binding("Text", bsContacts, "ContactID"));
            textBoxFirstName.DataBindings.Add(new Binding("Text", bsContacts, "FirstName"));
            textBoxLastName.DataBindings.Add(new Binding("Text", bsContacts, "LastName"));
            textBoxNickName.DataBindings.Add(new Binding("Text", bsContacts, "NickName"));
            textBoxDOB.DataBindings.Add(new Binding("Text", bsContacts, "DateOfBirth"));
            textBoxStreetName.DataBindings.Add(new Binding("Text", bsContacts, "AddressStreet"));
            textBoxStreetNum.DataBindings.Add(new Binding("Text", bsContacts, "AddressStreetNumber"));
            textBoxCity.DataBindings.Add(new Binding("Text", bsContacts, "AddressCity"));
            textBoxPostalCode.DataBindings.Add(new Binding("Text", bsContacts, "AddressPostalCode"));
            textBoxCountry.DataBindings.Add(new Binding("Text", bsContacts, "AddressCountry"));


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {

            if (ValidateData())
            {
                if (MessageBox.Show(ContactsRes.editFormSave, "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bsContacts.EndEdit();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private bool ValidateData()
        {
            epDetails.Clear();

            if (string.IsNullOrEmpty(textBoxFirstName.Text))
            {
                textBoxFirstName.Focus();
                epDetails.SetError(textBoxFirstName, ErrorRes.error_FN);
                MessageBox.Show(ErrorRes.error_FN, ErrorRes.errMessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxLastName.Text))
            {
                textBoxLastName.Focus();
                epDetails.SetError(textBoxLastName, ErrorRes.error_LN);
                MessageBox.Show(ErrorRes.error_LN, ErrorRes.errMessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxNickName.Text))
            {
                textBoxNickName.Focus();
                epDetails.SetError(textBoxNickName, ErrorRes.error_NN);
                MessageBox.Show(ErrorRes.error_NN, ErrorRes.errMessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxDOB.Text))
            {
                textBoxDOB.Focus();
                epDetails.SetError(textBoxDOB, ErrorRes.error_DOB);
                MessageBox.Show(ErrorRes.error_NN, ErrorRes.errMessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxStreetName.Text))
            {
                textBoxStreetName.Focus();
                epDetails.SetError(textBoxStreetName, ErrorRes.error_SA);
                MessageBox.Show(ErrorRes.error_SA, ErrorRes.errMessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxStreetNum.Text))
            {
                textBoxStreetNum.Focus();
                epDetails.SetError(textBoxStreetNum, ErrorRes.error_SN);
                MessageBox.Show(ErrorRes.error_SN, ErrorRes.errMessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxCity.Text))
            {
                textBoxCity.Focus();
                epDetails.SetError(textBoxCity, ErrorRes.error_City);
                MessageBox.Show(ErrorRes.error_City, ErrorRes.errMessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxPostalCode.Text))
            {
                textBoxPostalCode.Focus();
                epDetails.SetError(textBoxPostalCode, ErrorRes.error_PC);
                MessageBox.Show(ErrorRes.error_PC, ErrorRes.errMessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxCountry.Text))
            {
                textBoxCountry.Focus();
                epDetails.SetError(textBoxCountry, ErrorRes.error_Country);
                MessageBox.Show(ErrorRes.error_Country, ErrorRes.errMessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}

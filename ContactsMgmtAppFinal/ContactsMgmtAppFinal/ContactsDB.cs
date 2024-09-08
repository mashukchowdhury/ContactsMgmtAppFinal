using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ContactsMgmtAppFinal.DataLayer
{
    class ContactsDB
    {
        private SqlConnection _conn;
        private DataSet _ContactsDS;

        private SqlDataAdapter _contactHeaderDataAdapter;
        private SqlDataAdapter _contactDetailsDataAdapter;
        private SqlDataAdapter _contactTypesDataAdapter;


        public DataTable ContactsHeaderTable { get => _ContactsDS.Tables["ContactHeader"]; }
        public DataTable ContactsDetailsTable { get => _ContactsDS.Tables["ContactDetails"]; }
        public DataTable ContactTypesTable { get => _ContactsDS.Tables["ContactTypes"]; }
        
        public ContactsDB(string connectionString)
        {
            _conn = new SqlConnection(connectionString);
            _ContactsDS = new DataSet("ContactsDBProd");
            ContactHeaderDataAdapter();
/*            ContactDetailsDataAdapter();
*/            ContactTypesDataAdapter();
        }

   /*     private void ContactDetailsDataAdapter()
        {
            throw new NotImplementedException();
        }
*/
        private void ContactHeaderDataAdapter()
        {
            _contactHeaderDataAdapter = new SqlDataAdapter();

            String selectSQL = $"SELECT * FROM ContactHeader";
            /*
                        String selectSQL = $"SELECT CH.FirstName, CH.LastName, CD.ContactData AS Email " +
                                           $"FROM ContactHeader CH " +
                                           $"JOIN ContactDetails CD ON CH.ContactID = CD.ContactID " +
                                           $"JOIN ContactTypes CT ON CD.ContactTypeID = CT.ContactTypeID " +
                                           $"WHERE CT.ContactTypeDesc = 'Email'";*/

            SqlCommand contactsSelectCmd = new SqlCommand(selectSQL, _conn);

            _contactHeaderDataAdapter.SelectCommand = contactsSelectCmd;

            String updateSQL = $"UPDATE ContactHeader SET FirstName = @pFirstName, " +
                               $"LastName = @pLastName, Nickname = @pNickname, DateOfBirth = @pDateOfBirth " +
                               $"Street = @pStreet, StreetNumber = @pStreetNumber, City = @pCity, PostalCode = @pPostalCode, Country = @pCountry " +
                               $"WHERE ContactID = @pContactID";

            SqlCommand contactsUpdateCmd = new SqlCommand(updateSQL, _conn);


            // SQL UPdate Parameters
            SqlParameter pUpFirstName = new SqlParameter("pFirstName", SqlDbType.NVarChar, 50, "FirstName");
            SqlParameter pUpLastName = new SqlParameter("pLastName", SqlDbType.NVarChar, 50, "LastName");
            SqlParameter pUpNickname = new SqlParameter("pNickname", SqlDbType.NVarChar, 50, "Nickname");
            SqlParameter pUpDateOfBirth = new SqlParameter("pDateOfBirth", SqlDbType.NVarChar, 50, "DateOfBirth");
            SqlParameter pUpStreet = new SqlParameter("pStreet", SqlDbType.NVarChar, 50, "Street");
            SqlParameter pUpStreetNumber = new SqlParameter("pStreetNumber", SqlDbType.NVarChar, 50, "StreetNumber");
            SqlParameter pUpCity = new SqlParameter("pCity", SqlDbType.NVarChar, 50, "City");
            SqlParameter pUpPostalCode = new SqlParameter("pPostalCode", SqlDbType.NVarChar, 50, "PostalCode");
            SqlParameter pUpCountry = new SqlParameter("pCountry", SqlDbType.NVarChar, 50, "Country");
            SqlParameter pUpdContactID = new SqlParameter("pContactID", SqlDbType.Int, 0, "ContactID");

            //Bind Parms
            SqlParameter[] upParms = { pUpFirstName, pUpLastName, pUpNickname, pUpDateOfBirth, pUpStreet, pUpStreetNumber, pUpCity, pUpPostalCode, pUpCountry, pUpdContactID };
            contactsUpdateCmd.Parameters.AddRange(upParms);

            _contactHeaderDataAdapter.UpdateCommand = contactsUpdateCmd;

            // Insert Query
            String InsSQL = $"INSERT INTO ContactHeader " +
                            $"(FirstName, LastName, Nickname, DateOfBirth, Street, StreetNumber, City, PostalCode, Country) " +
                            $"VALUES (@pFirstName, @pLastName, @pNickname, @pDateOfBirth, @pStreet, @pStreetNumber, @pCity, @pPostalCode, @pCountry) " +
                            $"SET @NewContactID = SCOPE_IDENTITY()";

            SqlCommand insCommand = new SqlCommand(InsSQL, _conn);

            //SQL Insert Parameters
            SqlParameter pInsFirstName = new SqlParameter("@pFirstName", SqlDbType.NVarChar, 50, "FirstName");
            SqlParameter pInsLastName = new SqlParameter("@pLastName", SqlDbType.NVarChar, 50, "LastName");
            SqlParameter pInsNickname = new SqlParameter("@pNickname", SqlDbType.NVarChar, 50, "Nickname");
            SqlParameter pInsDateOfBirth = new SqlParameter("@pDateOfBirth", SqlDbType.NVarChar, 50, "DateOfBirth");
            SqlParameter pInsStreet = new SqlParameter("@pStreet", SqlDbType.NVarChar, 50, "Street");
            SqlParameter pInsStreetNumber = new SqlParameter("@pStreetNumber", SqlDbType.NVarChar, 50, "StreetNumber");
            SqlParameter pInsCity = new SqlParameter("@pCity", SqlDbType.NVarChar, 50, "City");
            SqlParameter pInsPostalCode = new SqlParameter("@pPostalCode", SqlDbType.NVarChar, 50, "PostalCode");
            SqlParameter pInsCountry = new SqlParameter("@pCountry", SqlDbType.NVarChar, 50, "Country");
            SqlParameter pOutNewContactID = new SqlParameter("@NewContactID", SqlDbType.Int, 0, "ContactID");

            pOutNewContactID.Direction = ParameterDirection.Output;

            SqlParameter[] insParms = { pOutNewContactID, pInsFirstName, pInsLastName, pInsNickname, pInsDateOfBirth, pInsStreet, pInsStreetNumber, pInsCity, pInsPostalCode, pInsCountry };
            insCommand.Parameters.AddRange(insParms);
            _contactHeaderDataAdapter.InsertCommand = insCommand;


            //Delete Query
            String delSQL = $"DELETE FROM ContactHeader WHERE ContactID = @pContactID";

            SqlCommand delCommand = new SqlCommand(delSQL, _conn);
            SqlParameter pdelehID = new SqlParameter("pVehID", SqlDbType.Int, 0, "veh_ID");
            delCommand.Parameters.Add(pdelehID);
            _contactHeaderDataAdapter.DeleteCommand = delCommand;


        }

        void ContactTypesDataAdapter()
        {
            _contactTypesDataAdapter = new SqlDataAdapter();

            string selectSQL = $"SELECT * FROM ContactTypes";

            SqlCommand contactTypesSelectCommand = new SqlCommand(selectSQL, _conn);

            _contactTypesDataAdapter.SelectCommand = contactTypesSelectCommand;

            String updateSQL = $"UPDATE ContactTypes SET ContactTypeDesc = @pContactTypeDesc " +
                               $"WHERE ContactTypeID = @pContactTypeID ";


            SqlCommand contactTypesUpdateCmd = new SqlCommand(updateSQL, _conn);

            //Update Parameters
            SqlParameter pUpContactTypeDesc = new SqlParameter("pUpContactTypeDesc", SqlDbType.NVarChar, 50, "ContactTypeDesc");
            SqlParameter pUpContactTypeID = new SqlParameter("pContactTypeID", SqlDbType.Int, 0, "ContactTypeID");

            SqlParameter[] upParms = { pUpContactTypeDesc, pUpContactTypeID };
            contactTypesUpdateCmd.Parameters.AddRange(upParms);

            _contactTypesDataAdapter.UpdateCommand = contactTypesUpdateCmd;

            //Insert

            String InsertSQL = $"INSERT INTO ContactTypes " + 
                               $"(ContactTypeDesc) " +
                               $"VALUES (@pContactTypeDesc)" +
                               $"SET @NewContactTypeID = SCOPE_IDENTITY()";

            SqlCommand contactTypesInsCommand = new SqlCommand(InsertSQL, _conn);

            SqlParameter pInsContactType = new SqlParameter("pContactTypeDesc", SqlDbType.NVarChar, 50, "ContactTypeDesc");
            SqlParameter pOutContactTypeID = new SqlParameter("NewContactTypeID", SqlDbType.Int, 0, "ContactTypeID");

            pOutContactTypeID.Direction = ParameterDirection.Output;

            SqlParameter[] insParms = { pInsContactType, pOutContactTypeID };
            contactTypesInsCommand.Parameters.AddRange(insParms);

            _contactTypesDataAdapter.UpdateCommand = contactTypesInsCommand;

            //Delete

            String deleteSQL = $"DELETE FROM ContactTypes WHERE ContactTypeID = @pContactTypeID";

            SqlCommand delCommand = new SqlCommand(deleteSQL, _conn);
            SqlParameter pdelID = new SqlParameter ("pContactTypeID", SqlDbType.Int, 0, "ContactTypeID");
            delCommand.Parameters.Add(pdelID);
            _contactTypesDataAdapter.DeleteCommand = delCommand;
        }

        public DataTable getContactTypes()
        {
            DataTable dtContactTypes = new DataTable("ContactTypes");
            _contactTypesDataAdapter.Fill(dtContactTypes);
            DataColumn[] primaryKey = { dtContactTypes.Columns["ContactTypeID"] };
            dtContactTypes.PrimaryKey = primaryKey;
            dtContactTypes.Columns["ContactTypeID"].AllowDBNull = true;
            _ContactsDS.Tables.Add(dtContactTypes);

            return dtContactTypes;

        }

        public DataTable getContacts()
        {
            DataTable dtContactHeader = new DataTable("ContactHeader");
            _contactHeaderDataAdapter.Fill(dtContactHeader);
            DataColumn[] primaryKey = { dtContactHeader.Columns["ContactID"] };
            dtContactHeader.PrimaryKey = primaryKey;
            dtContactHeader.Columns["ContactID"].AllowDBNull = true;
            /*_ContactsDS.Tables.Add(dtContactHeader);*/
            /*
                        DataTable dtContactDetails = new DataTable("ContactDetails");
                        _contactDetailsDataAdapter.Fill(dtContactDetails);
                        DataColumn[] detailsPrimaryKey = { dtContactDetails.Columns["ContactTypeID"], dtContactDetails.Columns["ContactID"] };
                        dtContactDetails.PrimaryKey = primaryKey;
                        dtContactDetails.Columns["ContactID"].AllowDBNull = true;

                        _ContactsDS.Tables.Add(dtContactDetails);

                        HeaderDetailsDataRelation();*/

            return dtContactHeader;
        }

        public void updateContactHeaderData(DataTable ctHeaderData)
        {
            _contactHeaderDataAdapter.Update(ctHeaderData);
        }

        public void refreshContactData()
        {
            _contactHeaderDataAdapter.Fill(ContactsHeaderTable);
        }

        public void updateContactTypesData(DataTable ctData)
        {
            _contactTypesDataAdapter.Update(ctData);
        }

        public void refreshContactsTypeData()
        {
            _contactTypesDataAdapter.Fill(ContactTypesTable);
        }
        public void Open()
        {
            if (_conn.State != ConnectionState.Open)
            {
                _conn.Open();
            }
        }

        public void Close()
        {
            if (_conn.State == ConnectionState.Open)
            {
                _conn.Close();
            }
        }

        public void HeaderDetailsDataRelation()
        {
            DataColumn parentColumn = this.ContactsHeaderTable.Columns["ContactID"];
            DataColumn childColumn = this.ContactsDetailsTable.Columns["ContactID"];
            /*DataRelation relation = new DataRelation("ContactHeader_ContactDetails", ContactsHeaderTable.Columns["ContactID"], ContactsDetailsTable.Columns["ContactID"]);
            ContactsHeaderTable.Columns["ContactID"], C*/
            DataRelation contactsRel = new DataRelation("contactsRel", parentColumn, childColumn);

            _ContactsDS.Relations.Add(contactsRel);

            contactsRel.ChildKeyConstraint.DeleteRule = Rule.Cascade;



        }

    }

   
}

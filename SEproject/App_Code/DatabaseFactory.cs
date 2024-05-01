using Newtonsoft.Json.Linq;
using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


public class DatabaseFactory
{

    public static DatabaseFactory UniqueIns;

    private DatabaseFactory()
    {
    }

    public static DatabaseFactory getInstance()
    {
        if (UniqueIns == null)
        {
            UniqueIns = new DatabaseFactory();
        }
        return UniqueIns;
    }

    public Student getPersonalDetailsofStudent(string userName)
    {
        Student student = new Student();

        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string mainQuery = "SELECT NAME,DOB,FATHERNAME,BATCH,CNIC,NATIONALITY,CONTACT,CAMPUS FROM student S JOIN users U ON S.studentID= U.ID WHERE S.studentID = @userName";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(mainQuery, connection))
            {
                command.Parameters.AddWithValue("@userName", userName);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        student.setName(reader["NAME"].ToString());
                        student.setDOB(reader["DOB"].ToString());
                        student.setFatherName(reader["FATHERNAME"].ToString());
                        student.setBatch(reader["BATCH"].ToString());
                        student.setCNIC(reader["CNIC"].ToString());
                        student.setNationality(reader["NATIONALITY"].ToString());
                        student.setContact(reader["CONTACT"].ToString());
                        student.setCampus(reader["CAMPUS"].ToString());
                    }
                }
            }
        }
        return student;
    }


    public OneStopAdmin getPersonalDetailsofAdmin(string userName)
    {

        OneStopAdmin admin = new OneStopAdmin();

        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string mainQuery = "SELECT NAME,DOB,BLOODGROUP,GENDER,CNIC,NATIONALITY,CONTACT,CAMPUS FROM OneStopAdmin A JOIN users U ON A.adminID= U.ID WHERE A.adminID = @userName";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();


            using (SqlCommand command = new SqlCommand(mainQuery, connection))
            {
                command.Parameters.AddWithValue("@userName", userName);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        admin.setName(reader["NAME"].ToString());
                        admin.setDOB(reader["DOB"].ToString());
                        admin.setBloodGroup(reader["BLOODGROUP"].ToString());
                        admin.setGender(reader["GENDER"].ToString());
                        admin.setCNIC(reader["CNIC"].ToString());
                        admin.setNationality(reader["NATIONALITY"].ToString());
                        admin.setContact(reader["CONTACT"].ToString());
                        admin.setCampus(reader["CAMPUS"].ToString());
                    }
                }
            }
        }
        return admin;
    }


    public Director getPersonalDetailsofDirector(string userName)
    {

        Director director = new Director();

        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string mainQuery = "SELECT NAME,DOB,BLOODGROUP,GENDER,CNIC,NATIONALITY,CONTACT,CAMPUS FROM Director D JOIN users U ON D.directorID= U.ID WHERE D.directorID = @userName";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(mainQuery, connection))
            {
                command.Parameters.AddWithValue("@userName", userName);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        director.setName(reader["NAME"].ToString());
                        director.setDOB(reader["DOB"].ToString());
                        director.setBloodGroup(reader["BLOODGROUP"].ToString());
                        director.setGender(reader["GENDER"].ToString());
                        director.setCNIC(reader["CNIC"].ToString());
                        director.setNationality(reader["NATIONALITY"].ToString());
                        director.setContact(reader["CONTACT"].ToString());
                        director.setCampus(reader["CAMPUS"].ToString());
                    }
                }
            }
        }

        return director;
    }

    public Finance getPersonalDetailsofFinance(string userName)
    {
        Finance finance = new Finance();

        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string mainQuery = "SELECT NAME,DOB,BLOODGROUP,GENDER,CNIC,NATIONALITY,CONTACT,CAMPUS FROM financeDepartment F JOIN users U ON F.departmentID= U.ID WHERE F.departmentID = @userName";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();


            using (SqlCommand command = new SqlCommand(mainQuery, connection))
            {
                command.Parameters.AddWithValue("@userName", userName);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        finance.setName(reader["NAME"].ToString());
                        finance.setDOB(reader["DOB"].ToString());
                        finance.setBloodGroup(reader["BLOODGROUP"].ToString());
                        finance.setGender(reader["GENDER"].ToString());
                        finance.setCNIC(reader["CNIC"].ToString());
                        finance.setNationality(reader["NATIONALITY"].ToString());
                        finance.setContact(reader["CONTACT"].ToString());
                        finance.setCampus(reader["CAMPUS"].ToString());
                    }
                }
            }
        }

        return finance;
    }

    public FYP getPersonalDetailsofFYP(string userName)
    {

        FYP fyp = new FYP();

        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string mainQuery = "SELECT NAME,DOB,BLOODGROUP,GENDER,CNIC,NATIONALITY,CONTACT,CAMPUS FROM FYPdepartment F JOIN users U ON F.departmentID= U.ID WHERE F.departmentID = @userName";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();


            using (SqlCommand command = new SqlCommand(mainQuery, connection))
            {
                command.Parameters.AddWithValue("@userName", userName);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        fyp.setName(reader["NAME"].ToString());
                        fyp.setDOB(reader["DOB"].ToString());
                        fyp.setBloodGroup(reader["BLOODGROUP"].ToString());
                        fyp.setGender(reader["GENDER"].ToString());
                        fyp.setCNIC(reader["CNIC"].ToString());
                        fyp.setNationality(reader["NATIONALITY"].ToString());
                        fyp.setContact(reader["CONTACT"].ToString());
                        fyp.setCampus(reader["CAMPUS"].ToString());

                    }
                }
            }
        }
        return fyp;
    }

    public void insertComplaint(ComplaintForm complaintForm)
    {

        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string insertQuery = "INSERT INTO complaints VALUES (@userName,@complaint,@department,@status)";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@userName", complaintForm.getID());
                insertCommand.Parameters.AddWithValue("@complaint", complaintForm.getComplaint());
                insertCommand.Parameters.AddWithValue("@department", complaintForm.getDepartment());
                insertCommand.Parameters.AddWithValue("@status", complaintForm.getStatus());

                insertCommand.ExecuteNonQuery();
                MessageBox.Show("          COMPLAINT RECORDED SUCCESSFULLY          ");

            }
        }

        catch (SqlException e)
        {
            MessageBox.Show("          AN ERROR OCCURRED          ");
        }
    }

    public void insertDataChangeRequest(DataChangeForm dataChangeForm)
    {
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string insertQuery = "INSERT INTO dataChangeRequest VALUES (@userName,@requestOption,@requestValue)";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@userName", dataChangeForm.getID());
                insertCommand.Parameters.AddWithValue("@requestOption", dataChangeForm.getRequestOption());
                insertCommand.Parameters.AddWithValue("@requestValue", dataChangeForm.getRequestValue());

                insertCommand.ExecuteNonQuery();
                MessageBox.Show("          REQUEST RECORDED SUCCESSFULLY          ");

            }
        }

        catch (SqlException e)
        {
            MessageBox.Show("          AN ERROR OCCURRED          ");

        }
    }

    public void InitiateDegreeRequest(DegreeForm degreeForm)
    {

        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string insertQuery = "INSERT INTO degreeRequests(ID,name,batch,FYPapproval,financeApproval,finalStatus,outstandingDues,degreeFee) VALUES (@userName,@name,@batch,'pending','pending','pending','none','paid')";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@userName", degreeForm.GetID());
                insertCommand.Parameters.AddWithValue("@name", degreeForm.GetName());
                insertCommand.Parameters.AddWithValue("@batch", degreeForm.GetBatch());
                insertCommand.ExecuteNonQuery();

                MessageBox.Show("          DEGREE REQUEST INITIATED SUCCESSFULLY          ");
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show("          SOMETHING WENT WRONG          ");

        }
    }

    public void insertFeedback(FeedbackForm feedbackForm)
    {
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";


        string checkQuery = "select finalStatus from degreeRequests where ID = @userName";
        string finalStatus = null;

        string insertQuery = "INSERT INTO feedback VALUES (@userName,@feedback)";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@userName", feedbackForm.getID());

                object result = checkCommand.ExecuteScalar();

                if (result != null)
                {
                    finalStatus = result.ToString();
                }
                if (finalStatus == "approved")
                {
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@userName", feedbackForm.getID());
                    insertCommand.Parameters.AddWithValue("@feedback", feedbackForm.getFeedback());
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("          FEEDBACK RECORDED SUCCESSFULLY          ");

                }
                else
                {
                    MessageBox.Show("          SOMETHING WENT WRONG          ");

                }
            }
        }
        catch (SqlException e)
        {
            MessageBox.Show("          SOMETHING WENT WRONG          ");
        }
    }


    public void GenerateIneligibleforFYP(DegreeForm form)
    {
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                string updateQuery = "Update degreeRequests set FYPapproval = 'not approved', FYPTime = @FYPTime,FYPDate = @FYPDate where ID = @id";

                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("FYPTime", form.GetFYPTime());
                updateCommand.Parameters.AddWithValue("FYPDate", form.GetFYPDate());
                updateCommand.Parameters.AddWithValue("id", form.GetID());
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("          SUCCESSFUL          ");

            }
        }
        catch (SqlException e)
        {
            MessageBox.Show("          AN ERROR OCCURED          ");

        }
    }

    public void generateEligibleforFYP(DegreeForm form)
    {
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "Update degreeRequests set FYPapproval = 'approved', FYPTime = @FYPTime,FYPdate = @FYPDate where ID = @id";

                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("FYPTime", form.GetFYPTime());
                updateCommand.Parameters.AddWithValue("FYPDate", form.GetFYPDate());
                updateCommand.Parameters.AddWithValue("id", form.GetID());
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("          SUCCESSFUL          ");

            }
        }
        catch (SqlException e)
        {
            MessageBox.Show("          AN ERROR OCCURRED          ");

        }
    }

    public void degreeFeeNotPaid(DegreeForm form)
    {
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "Update degreeRequests set degreeFee = 'not paid' where ID = @id";

                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("id", form.GetID());
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("          SUCCESSFUL          ");

            }
        }

        catch (SqlException e)
        {
            MessageBox.Show("          AN ERROR OCCURRED          ");

        }
    }

    public void OutstandingDuesRemaining(DegreeForm form)
    {

        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "Update degreeRequests set outstandingDues = 'remaining' where ID = @id";

                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("id", form.GetID());
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("          SUCCESSFUL          ");

            }
        }

        catch (SqlException e)
        {
            MessageBox.Show("          AN ERROR OCCURRED          ");

        }
    }

    public void generateEligibleforFinance(DegreeForm form)
    {
        string dues = null, fee = null;

        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string checkQuery = "SELECT OUTSTANDINGDUES, DEGREEFEE FROM DEGREEREQUESTS WHERE ID = @id";

                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("id", form.GetID());
                SqlDataReader reader = checkCommand.ExecuteReader();

                while (reader.Read())
                {
                    dues = reader["OUTSTANDINGDUES"].ToString();
                    fee = reader["DEGREEFEE"].ToString();
                }
                reader.Close();

                if (dues == "none" && fee == "paid")
                {
                    string updateQuery = "Update degreeRequests set Financeapproval = 'approved', financeTime = @FinanceTime,financeDate = @financeDate where ID = @id";

                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("FinanceTime", form.GetFinanceTime());
                    updateCommand.Parameters.AddWithValue("financeDate", form.GetFinanceDate());
                    updateCommand.Parameters.AddWithValue("id", form.GetID());
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("          SUCCESSFUL          ");

                }
                else
                {
                    MessageBox.Show("          AN ERROR OCCURRED          ");

                }
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show("          AN ERROR OCCURRED          ");

        }
    }

    public void setFinalStatus(DegreeForm form)
    {
        string fyp = null, finance = null;

        string query = "select FYPapproval,FinanceApproval from degreeRequests where ID = @id";
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", form.GetID());
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    fyp = reader["FYPapproval"].ToString();
                    finance = reader["FinanceApproval"].ToString();
                    reader.Close();
                }
                if (fyp == "approved" && finance == "approved")
                {
                    string updateQuery = "update degreeRequests set finalStatus = 'approved' where ID = @id";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@id", form.GetID());
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("          SUCCESSFUL          ");

                }
                else
                {
                    MessageBox.Show("          AN ERROR OCCURRED          ");

                }
            }
        }

        catch(SqlException ex)
        {
            MessageBox.Show("          AN ERROR OCCURRED          ");

        }
    }

    public void generateToken(DegreeForm form)
    {
        int tokenID;

        string query = "select top 1 tokenID from degreeRequests order by tokenID desc";

        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    tokenID = Convert.ToInt32(result.ToString());
                }
                else
                {
                    tokenID = 0;
                }
                tokenID++;


                string checkQuery = "select tokenID from degreeRequests where ID = @id";

                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("id", form.GetID());
                object checkToken = checkCommand.ExecuteScalar();
                if (checkToken != null && checkToken != DBNull.Value)
                {
                    MessageBox.Show("          TOKEN ALREADY GENERATED          ");
                }
                else
                {
                    string updateQuery = "Update degreeRequests set tokenID = @tokenID, tokenTime = @tokenTime,tokenDate = @tokenDate,FYPapproval='pending',financeApproval = 'pending' where ID = @id";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("tokenID", tokenID);
                    updateCommand.Parameters.AddWithValue("tokenTime", form.GetTokenTime());
                    updateCommand.Parameters.AddWithValue("tokenDate", form.GetTokenDate());
                    updateCommand.Parameters.AddWithValue("id", form.GetID());
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("          SUCCESSFUL          ");

                }
            }
        }

        catch(SqlException sqlEx)
        {
            MessageBox.Show("          AN ERROR OCCURRED          ");

        }
    }

    public void DataChangeAccepted(DataChangeForm form)
    {

        string query = null;

        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        if (form.getRequestOption() == "name")
        {
            query = "Update users set name = @requestValue where ID = @id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@requestValue", form.getRequestValue());
                    command.Parameters.AddWithValue("@id", form.getID());
                    command.ExecuteNonQuery();

                    string deleteQuery = "delete from dataChangeRequest where ID=@id and requestOption = @requestOption";

                    SqlCommand deletecommand = new SqlCommand(deleteQuery, connection);
                    deletecommand.Parameters.AddWithValue("@id", form.getID());
                    deletecommand.Parameters.AddWithValue("@requestOption", form.getRequestOption());
                    deletecommand.ExecuteNonQuery();
                    MessageBox.Show("          SUCCESSFUL          ");

                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("          AN ERROR OCCURRED          ");

            }
        }
        else
        {
            query = $"UPDATE student SET {form.getRequestOption()} = @requestValue WHERE studentID = @id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@requestValue", form.getRequestValue());
                    command.Parameters.AddWithValue("@id", form.getID());
                    command.ExecuteNonQuery();

                    string deleteQuery = "DELETE FROM dataChangeRequest WHERE ID = @id AND requestOption = @requestOption";

                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@id", form.getID());
                    deleteCommand.Parameters.AddWithValue("@requestOption", form.getRequestOption());
                    deleteCommand.ExecuteNonQuery();
                    MessageBox.Show("          SUCCESSFUL          ");

                }
            }

            catch(SqlException ex)
            {
                MessageBox.Show("          AN ERROR OCCURRED          ");

            }

        }
    }

    public void resolveComplaint(ComplaintForm form)
    {
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "Update Complaints set status = 'Solved' where ID = @id AND complaint = @complaint";

                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("id", form.getID());
                updateCommand.Parameters.AddWithValue("complaint", form.getComplaint());
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("          SUCCESSFUL          ");


            }
        }

        catch(SqlException ex)
        {
            MessageBox.Show("          AN ERROR OCCURRED          ");

        }

    }

}
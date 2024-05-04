using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Image = iTextSharp.text.Image;

public partial class DesignLayer_Student_studentTrackActivity : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string query = "SELECT NAME,FINANCEAPPROVAL,FYPAPPROVAL,FINALSTATUS,OUTSTANDINGDUES,DEGREEFEE FROM DEGREEREQUESTS where ID = @username";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("username", Session["username"].ToString());
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["NAME"].ToString();
                string fyp = reader["FYPAPPROVAL"].ToString();
                string finance = reader["FINANCEAPPROVAL"].ToString();
                string outStanding = reader["OUTSTANDINGDUES"].ToString();
                string fee = reader["DEGREEFEE"].ToString();
                string final = reader["FINALSTATUS"].ToString();


                // Creating a new table row
                TableRow row = new TableRow();

                // Creating table cells and adding them to the row
                TableCell cellName = new TableCell();
                cellName.Text = name;
                row.Cells.Add(cellName);

                TableCell cellFYP = new TableCell();
                cellFYP.Text = fyp;
                row.Cells.Add(cellFYP);

                TableCell cellfinance = new TableCell();
                cellfinance.Text = finance;
                row.Cells.Add(cellfinance);

                TableCell cellOut = new TableCell();
                cellOut.Text = outStanding;
                row.Cells.Add(cellOut);

                TableCell cellFee = new TableCell();
                cellFee.Text = fee;
                row.Cells.Add(cellFee);


                TableCell cellfinal = new TableCell();
                cellfinal.Text = final;
                row.Cells.Add(cellfinal);

                // Add the row to the table
                dataTable.Rows.Add(row);

                if (final == "approved")
                {
                    generate.Visible = true;
                }
            }

            reader.Close();
        }
    }

    protected void generate_Click(object sender, EventArgs e)
    {
        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);

        pdfDoc.Open();

        // Create a font for the paragraph
        BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
        Font font = new Font(baseFont, 18, Font.BOLD, BaseColor.BLACK);

        // Create a paragraph with the title content
        Paragraph title = new Paragraph("NATIONAL UNIVERSITY OF COMPUTING AND EMERGING SCIENCES\n\n\n", font);
        // Set alignment to center
        title.Alignment = Element.ALIGN_CENTER;

        pdfDoc.Add(title);

        Paragraph subtitle = new Paragraph("DEGREE CERTIFICATE\n\n\n");
        subtitle.Alignment = Element.ALIGN_CENTER;
        pdfDoc.Add(subtitle);


        // Add a table to the PDF document
        PdfPTable pdfTable = new PdfPTable(4);
        pdfTable.WidthPercentage = 100;

        // Add table headers
        pdfTable.AddCell(new PdfPCell(new Phrase("Roll Number")));
        pdfTable.AddCell(new PdfPCell(new Phrase("Name")));
        pdfTable.AddCell(new PdfPCell(new Phrase("Father Name")));
        pdfTable.AddCell(new PdfPCell(new Phrase("Batch")));

        string connectionString = "Data Source=DESKTOP-LQH1JMA\\SQLEXPRESS;Initial Catalog=OneStop;Integrated Security=True;Encrypt=False;";

        string mainQuery = "SELECT NAME,FATHERNAME,BATCH FROM student S JOIN users U ON S.studentID= U.ID WHERE S.studentID = @userName";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(mainQuery, connection))
            {
                command.Parameters.AddWithValue("@userName", Session["username"].ToString());

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    pdfTable.AddCell(new PdfPCell(new Phrase(Session["username"].ToString())));
                    pdfTable.AddCell(new PdfPCell(new Phrase(reader["NAME"].ToString())));
                    pdfTable.AddCell(new PdfPCell(new Phrase(reader["FATHERNAME"].ToString())));
                    pdfTable.AddCell(new PdfPCell(new Phrase(reader["BATCH"].ToString())));
                }
            }

        }

        pdfDoc.Add(pdfTable);
        pdfDoc.Close();

        Response.ContentType = "application/pdf";
        Response.AppendHeader("Content-Disposition", "attachment;filename=Degree.pdf");
        Response.Write(pdfDoc);
        Response.End();

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsFormsApp1
{
    public partial class frmExport : Form
    {
        public frmExport()
        {
            InitializeComponent();
        }

        private void frmExport_Load(object sender, EventArgs e)
        {
            SqlConnection sqlCon;
            string conString = null;
            string sqlQuery = null;

            conString = "Data Source.;Initial Catalog = Quanlybanhang; Intergrated Security = SSPI;";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            sqlQuery = "Select * From tblSanPham";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlCon);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvExport.DataSource = dataTable;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(dgvExport.Rows.Count > 0)
            {
                
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf) | *.pdf";
                saveFileDialog.FileName = "File.pdf";
                bool fileError = false;
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if(File.Exists(saveFileDialog.FileName))
                    {
                        try
                        {
                            File.Delete(saveFileDialog.FileName);
                        }
                        catch(IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa! Mô tả lỗi: " + ex.Message);
                        }
                    }
                    if(!fileError)
                    {
                        try
                        {
                            PdfPTable pdfPTable = new PdfPTable(dgvExport.Rows.Count);
                            pdfPTable.DefaultCell.Padding = 3;
                            pdfPTable.WidthPercentage = 100;
                            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach(DataGridViewColumn dataGridViewColumn in dgvExport.Columns)
                            {
                                PdfPCell pdfPCell = new PdfPCell(new Phrase(dataGridViewColumn.HeaderText));
                                pdfPTable.AddCell(pdfPCell);
                            }

                            foreach(DataGridViewRow dataGridViewRow in dgvExport.Rows)
                            {
                                foreach(DataGridViewCell dataGridViewCell in dataGridViewRow.Cells)
                                {
                                    pdfPTable.AddCell(dataGridViewCell.Value.ToString());
                                }
                            }

                            using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                                PdfWriter.GetInstance(pdfDoc, fileStream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfPTable);
                                pdfDoc.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Export dữ liệu thành công!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mô tả lỗi: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào được Export!", "Info");
            }
        }
    }
}

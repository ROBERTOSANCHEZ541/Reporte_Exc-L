using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Linq.Expressions;
using ClosedXML.Excel;

namespace Reporte_Exc_L
{
    public partial class ReporteExcel : Form
    {
        private Variables instVar;
        public ReporteExcel()
        {
            InitializeComponent();
            instVar = new Variables();
        }
        private void PbExcel_Click(object sender, EventArgs e)
        {                
            if (string.IsNullOrEmpty(CbTipo.Text))
                {
                    MessageBox.Show("Seleccione un tipo");
                }
                else
                {
                Microsoft.Office.Interop.Excel.Application m_Excel;              
                string ruta = @"F:\source\Reporte_Xlsx\Resources\instr_ext.xlsx";
                    m_Excel = new Microsoft.Office.Interop.Excel.Application();
                    m_Excel.Visible = false;
                    Microsoft.Office.Interop.Excel.Workbook objLibroExcel;
                    Microsoft.Office.Interop.Excel.Worksheet objHojaExcel;
                    objLibroExcel = m_Excel.Workbooks.Open(ruta, ReadOnly: true, Editable: false);              
                    OleDbConnection objSQLconect = new OleDbConnection("Provider=SQLOLEdb; data source=DESKTOP-6ECTDJR\\SQLEXPRESS; initial catalog=Capacitacion; integrated security=SSPI; persist security info=false; trusted connection=yes;");
                instVar.Query = "select Id_Instructor,Nombre,Tipo from Instructor WHERE Tipo='" + CbTipo.Text + "' And Id_Instructor In(Select Id_Instructor from Ctr_Cursos  WHERE  EstatuCurso In('A'))";             
                OleDbDataAdapter objSQLAdapter = new OleDbDataAdapter(instVar.Query, objSQLconect);
                    DataSet objSQLDataSet = new DataSet("ExcelTest");
                    objSQLAdapter.Fill(objSQLDataSet, "ReporteInstructor");
                    // Creamos una hoja en excel
                    objHojaExcel = (Microsoft.Office.Interop.Excel.Worksheet)objLibroExcel.Worksheets.get_Item(1);
                    objHojaExcel.Cells[1, "I"] = "";
                    instVar.i = 9;
                    objHojaExcel.Cells[6, 10].Value = DtpFecha.Text;                  
                    if (objSQLDataSet != null && objSQLDataSet.Tables.Count > 0 && objSQLDataSet.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow objrow in objSQLDataSet.Tables[0].Rows)
                        {
                            // Asigna los valores de los registros a la celda
                            objHojaExcel.Cells[instVar.i, "I"] = objrow["Id_Instructor"];
                            objHojaExcel.Cells[instVar.i, "J"] = objrow["Nombre"];
                            objHojaExcel.Cells[instVar.i, "K"] = objrow["Tipo"];
                            // Avanzamos una fila
                           instVar.i++;
                        }
                        MessageBox.Show("Reporte realizado correctamente");
                        m_Excel.Visible = true;
                        objHojaExcel.Visible = XlSheetVisibility.xlSheetVisible;
                    }
                    else
                    {
                        this.Focus();
                        MessageBox.Show("No contiene datos");
                        return;
                    }
                }
            }
        } 
    }


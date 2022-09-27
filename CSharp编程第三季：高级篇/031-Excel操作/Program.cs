using System.Data;
using System.Data.OleDb;

namespace _031_Excel操作
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string fileName = "装备信息.xls";
            string connectionStr = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + fileName + ";" + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";

            //创建连接对象
            OleDbConnection oleDbConnection = new OleDbConnection(connectionStr);

            //打开连接
            oleDbConnection.Open();

            //SQL语句
            string sql = "select * from [Sheet1$]";

            //创建连接
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sql, oleDbConnection);

            //创建数据集和
            DataSet excelData = new DataSet();

            //填充数据
            oleDbDataAdapter.Fill(excelData);

            //关闭连接
            oleDbConnection.Close();

            //获取表格
            DataTableCollection tableCollection = excelData.Tables;
            DataTable table = tableCollection[0];
            //行
            DataRowCollection rowCollection = table.Rows;
            foreach (DataRow row in rowCollection)
            {
                //列
                for (int i = 0; i < 8; i++)
                {
                    Console.Write(row[i] + " ");
                }
                Console.WriteLine();
            }

            /*
             * Json更方便
             */
        }
    }
}
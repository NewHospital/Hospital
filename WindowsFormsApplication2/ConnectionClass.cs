using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Hospital
{
    public enum ExecuteReaderOrNonQuery { executeReader = 1, executeNonQuery = 2, executeScalar = 3 };

    static class ConnectionClass
    {
        public static SqlConnection MyCOnnection;
        public static DataTable MyDataTable;
        public static List<SqlParameter> ParameterList;

        public static string Serial="";


        public static void Connection(string conn)
        {
            MyCOnnection = new SqlConnection(conn);

        }

        public static void Parameters(params SqlParameter[] MyParameters)
        {
            ParameterList = new List<SqlParameter>();

            foreach (var item in MyParameters)
            {
                ParameterList.Add(item);
            }
        }


        public static void SQLCommand(string CommandText, CommandType CT, ExecuteReaderOrNonQuery Ex)
        {
            MyCOnnection.Open();
            SqlCommand MyCommand = new SqlCommand(CommandText, MyCOnnection);

            switch (CT)
            {
                case CommandType.Text:
                    MyCommand.CommandType = CommandType.Text;

                    switch (Ex)
                    {
                        case ExecuteReaderOrNonQuery.executeReader:
                            SqlDataReader DataReader = MyCommand.ExecuteReader();
                            MyDataTable = new DataTable();
                            MyDataTable.Load(DataReader);
                            break;

                        case ExecuteReaderOrNonQuery.executeNonQuery:
                            MyCommand.Parameters.AddRange(ParameterList.ToArray());
                            MyCommand.ExecuteNonQuery();
                            break;

                        case ExecuteReaderOrNonQuery.executeScalar:
                            MyCommand.Parameters.AddRange(ParameterList.ToArray());
                            MyCommand.ExecuteScalar();
                            break;
                    }
                    ParameterList.Clear();
                    break;

                case CommandType.StoredProcedure:
                    {
                        MyCommand.CommandType = CommandType.StoredProcedure;
                        switch (Ex)
                        {
                            case ExecuteReaderOrNonQuery.executeReader:
                                SqlDataReader DataReader = MyCommand.ExecuteReader();
                                MyDataTable = new DataTable();
                                MyDataTable.Load(DataReader);
                                break;
                            case ExecuteReaderOrNonQuery.executeNonQuery:
                                MyCommand.Parameters.AddRange(ParameterList.ToArray());
                                MyCommand.ExecuteNonQuery();
                                break;

                            case ExecuteReaderOrNonQuery.executeScalar:
                                MyCommand.Parameters.AddRange(ParameterList.ToArray());
                                MyCommand.ExecuteScalar();
                                break;
                        }
                        ParameterList.Clear();
                        break;
                    }
            }
            MyCOnnection.Close();
        }



        public static string SerialNumber()
        {
            SqlConnection CON= new SqlConnection("Data Source=.;Initial Catalog=hospital;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            CON.Open();
            SqlCommand Command = new SqlCommand("select next value for seq", CON);
            Command.CommandType = CommandType.Text;
            int x = Convert.ToInt32(Command.ExecuteScalar());
            DateTime date =  DateTime.Now;
            string Date = date.Year.ToString();
            CON.Close();
            return string.Concat ((x.ToString ("00000")), "/", Date);
        }

        public static void SQLCommandWithoutParameters (string CommandText, CommandType CT, ExecuteReaderOrNonQuery Ex)
        {
            MyCOnnection.Open();
            SqlCommand MyCommand = new SqlCommand(CommandText, MyCOnnection);

            switch (CT)
            {
                case CommandType.Text:
                    MyCommand.CommandType = CommandType.Text;

                    switch (Ex)
                    {
                        case ExecuteReaderOrNonQuery.executeReader:
                            SqlDataReader DataReader = MyCommand.ExecuteReader();
                                MyDataTable = new DataTable();
                                MyDataTable.Load(DataReader);
                                                    break;

                        case ExecuteReaderOrNonQuery.executeNonQuery:
                            MyCommand.ExecuteNonQuery();
                            break;

                        case ExecuteReaderOrNonQuery.executeScalar:
                            MyCommand.ExecuteScalar();
                            break;
                    }
                    break;

                case CommandType.StoredProcedure:
                    {
                        MyCommand.CommandType = CommandType.StoredProcedure;
                        switch (Ex)
                        {
                            case ExecuteReaderOrNonQuery.executeReader:
                                SqlDataReader DataReader = MyCommand.ExecuteReader();
                                 MyDataTable = new DataTable();
                              MyDataTable.Load(DataReader);
                                break;
                            case ExecuteReaderOrNonQuery.executeNonQuery:
                                MyCommand.ExecuteNonQuery();
                                break;

                            case ExecuteReaderOrNonQuery.executeScalar:
                                MyCommand.ExecuteScalar();
                                break;
                        }
                        break;
                    }
            }
            MyCOnnection.Close();
        } 
    }
}


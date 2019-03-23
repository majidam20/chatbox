using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

public class DAL
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;
   

    public DAL()
    {
        cmd = new SqlCommand();
        con = new SqlConnection();
        da = new SqlDataAdapter();
        cmd.Connection = con;
        da.SelectCommand = cmd;
    }
    public void Connect()
    {
        con.ConnectionString = "Data Source=MAJIDPC\\SQLEXPRESS;Initial Catalog=Chat_CODie;Integrated Security=False;User Id=sa;Password=codie;";
        if (con.State != ConnectionState.Open)
            con.Open();
    }
    public void Disconnect()
    {
        if (con.State == ConnectionState.Open)
            con.Close();
    }
    public DataTable Select(string sql)
    {
        DataTable dt = new DataTable();
        cmd.CommandText = sql;
        da.Fill(dt);
        return dt;
    }

    public DataTable Select<T>(string sql, string paramName, DbType type, T value)
     {
        DataTable dt = new DataTable();
        cmd.CommandText = sql;
        var param = cmd.CreateParameter();
           
        param.DbType = type;
        param.Value = value;

        param.ParameterName = paramName;
        cmd.Parameters.Add(param);
        //if (cmd.Parameters.Contains("@data") ==false)
        //{
        //    
        //}

        da.Fill(dt);
        cmd.Parameters.Remove(param);
       
        return dt;
        
    }
    public void DoCommand(string sql)
    {
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
}

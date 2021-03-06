using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

public class UsersClass
{
    DAL DA = new DAL();
    public void Add(string name, string family, string position,string UserName, string Password)
    {                                                                           
        string sql = $"INSERT INTO users (name, family, position, UserName,Password,Online_Status) " +
            $"values ('{name}','{family}','{position}','{UserName}','{Password}',{0})";
       
        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();

    }

    public void Edit(int Id,string name, string family, string position,  string UserName, string Password)
    {
        string sql = $"UPDATE users SET name ='{name}',family ='{family}' ,UserName ='{UserName}',Password ='{Password}'" +
            $"WHERE id ={Id}";

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }

    public void Delete(int Id)
    {
        string Sql = $"delete from users where id ={Id}";
        DA.Connect();
        DA.DoCommand(Sql);
        DA.Disconnect();
    }

    internal void LogIn(int uid)
    {
        string Sql = $"update users set Online_Status = '{1}' where id={uid}";
        DA.Connect();
        DA.DoCommand(Sql);
        DA.Disconnect();
    }
    internal void LogOut(int uid)
    {
        string Sql = $"update users set Online_Status = '{0}' where id= {uid}";
        DA.Connect();
        DA.DoCommand(Sql);
        DA.Disconnect();
    }

    /// <summary>
    /// Jemand muss hier mal was schreiben
    /// </summary>
    //public int? GetFirstFreeUserId(IEnumerable<int> concurrentProcessIDs)
    //{
        
    //    string Sql = $"select top 1 id from users where p_id not in ({(concurrentProcessIDs.Any() ? String.Join(",", concurrentProcessIDs) : "-1")}) or p_id is null";
    //    DA.Connect();
    //    var dt = DA.Select(Sql);
    //    DA.Disconnect();
    //    if (dt.Rows.Count > 0)
    //    {
    //        return (int)dt.Rows[0][0];
    //    }
    //    else
    //    {
    //        return null;
    //    }
    //}


    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Position { get; set; }
        public int? P_Id { get; set; }
        public int?  Online_Status { get; set; }
        public string Photo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }  
        public override string ToString() => $"{Name} {Family}";


    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Dictionary<int, User> FetchSenderUsers()
    {
        string Sql = $"select * from Users";

        DA.Connect();
        var users = DA.Select(Sql).Rows
            .OfType<DataRow>()
            .Select(r => new User
            {
                Id = (int)r["Id"],
                Name = (string)r["Name"],
                Family = (string)r["Family"],
                Position = (r["Position"] == DBNull.Value) ? "" : (string)r["Position"],
                P_Id = ((r["P_Id"] == DBNull.Value) ? (int?)null : (int)r["P_Id"]),
                Online_Status = ((r["Online_Status"] == DBNull.Value) ? (int?)null : (int)r["Online_Status"]),
                Photo = (r["Photo"] == DBNull.Value) ? "" : (string)r["Photo"],
                UserName = (r["UserName"] == DBNull.Value) ? "" : (string)r["UserName"],
                Password = (r["Password"] == DBNull.Value) ? "" : (string)r["Password"]


            }
        );
        DA.Disconnect();

        return users.ToDictionary(u => u.Id);
    }


    public DataTable Search()
    {
        string Sql = "select   Id, Name, Family, Position, Online_Status,UserName,password from users";

        DataTable dt = new DataTable();
        DA.Connect();
        dt = DA.Select(Sql);
        DA.Disconnect();
        if (dt.Rows.Count > 0)
        {
            return dt;
        }
        else
        {
            return null;
        }

    }


    public DataTable Search(int? uid)
    {

        string Sql = $"select * from Users where id={uid}";

        DA.Connect();
        var dt = DA.Select(Sql);
        DA.Disconnect();
        if (dt.Rows.Count > 0)
        {
            return dt;
        }
        else
        {
            return null;
        }
    }


    public DataTable Search(string UserName, string Password)
    {

        string Sql = $"select * from Users where UserName ='{UserName}' and Password ='{Password}'";

        DA.Connect();
        var dt = DA.Select(Sql);
        DA.Disconnect();
        if (dt.Rows.Count > 0)
        {
            return dt;
        }
        else
        {
            return null;
        }
    }

    public DataTable Search(string UserName )
    {

        string Sql = $"select * from Users where UserName ='{UserName}'";

        DA.Connect();
        var dt = DA.Select(Sql);
        DA.Disconnect();
        if (dt.Rows.Count > 0)
        {
            return dt;
        }
        else
        {
            return null;
        }
    }



    //public void Edit(string name, string family, string upass, string part_name_fk, string uid)
    //{
    //    string sql = @"UPDATE users SET name =N'{0}', family =N'{1}', upass =N'{2}',
    //    part_name_fk =N'{3}' WHERE uid =N'{4}'";

    //    sql = string.Format(sql, name, family, upass, part_name_fk, uid);

    //    DA.Connect();
    //    DA.DoCommand(sql);
    //    DA.Disconnect();


    //}



    //public void Delete(string uid)
    //{
    //    string Sql = "delete from users where uid='" + uid + "'";
    //    DA.Connect();
    //    DA.DoCommand(Sql);
    //    DA.Disconnect();
    //}


}


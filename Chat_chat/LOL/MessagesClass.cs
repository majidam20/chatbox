using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

public class MessagesClass
{
    DAL DA = new DAL();
    /// <summary>
    /// Jemand muss hier mal was schreiben
    /// </summary>
    public void Add(int Sender_Id, int Room_Id, string Message,int Reading_Status, int Answer_Status )
    {
        string sql= $"insert into Messages(Sender_Id, Room_Id, date, Message,Reading_Status,Answer_Status) " +
            $"values({Sender_Id}, {Room_Id}, getdate(), '{Message}',{Reading_Status}, {Answer_Status})";

        DA.Connect();
        DA.DoCommand(sql);
        DA.Disconnect();
    }


    public List<Message> GetMessagesOfRoom(int RoomId)
    {
        var dt = SearchMessagesOfRoom(RoomId);
        if (dt == null)
        {
            return new List<Message>();
        }
        else
        {
            return dt.Rows
            .OfType<DataRow>()
            .Select(r => new Message
            {
                Id = (int)r["Id"],
                Sender_Id = (int)r["Sender_Id"],
                Room_Id = (int)r["Room_Id"],
                Date = (DateTime)r["Date"],
                Text = (string)r["Message"],
                Reading_Status = ((r["Reading_Status"] == DBNull.Value) ? (int?)null : (int)r["Reading_Status"]),
                Answer_Status = ((r["Answer_Status"] == DBNull.Value) ? (int?)null : (int)r["Answer_Status"]),
               
            }).ToList();
        }
    }
    public List<Message> GetMessagesOfRoom(int SenderId,int RoomId)
    {
        var dt = SearchMessagesOfRoom(SenderId,RoomId);
        if (dt == null)
        {
            return new List<Message>();
        }
        else
        {
            return dt.Rows
            .OfType<DataRow>()
            .Select(r => new Message
            {
                Id = (int)r["Id"],
                Sender_Id = (int)r["Sender_Id"],
                Room_Id = (int)r["Room_Id"],
                Date = (DateTime)r["Date"],
                Text = (string)r["Message"],
                Reading_Status = ((r["Reading_Status"] == DBNull.Value) ? (int?)null : (int)r["Reading_Status"]),
                Answer_Status = ((r["Answer_Status"] == DBNull.Value) ? (int?)null : (int)r["Answer_Status"]),

            }).ToList();
        }
    }

    public List<Message> GetMessagesOfRoom(int RoomId, DateTime date)
    {
        var dt = SearchNewDate(RoomId, date);
        if (dt == null)
        {
            return new List<Message>();
        }
        else
        {
            return dt.Rows
            .OfType<DataRow>()
            .Select(r => new Message
            {
                Id = (int)r["Id"],
                Sender_Id = (int)r["Sender_Id"],
                Room_Id = (int)r["Room_Id"],
                Date = (DateTime)r["Date"],
                Text = (string)r["Message"],
                Reading_Status = ((r["Reading_Status"] == DBNull.Value) ? (int?)null : (int)r["Reading_Status"]),
                Answer_Status = ((r["Answer_Status"] == DBNull.Value) ? (int?)null : (int)r["Answer_Status"]),
               
            }).ToList();
        }
    }

    public Dictionary<int, Rooms> FetchRooms()
    {
        string Sql = $"select  rooms.id,rooms.Name,rooms.Photo,COUNT(Memberships.Room_Id)AS NumberOfMembers from rooms" +
            $" join Memberships on rooms.id= Memberships.room_id group by rooms.id,Rooms.Name,rooms.Photo ";

        DA.Connect();
        var rooms = DA.Select(Sql).Rows
            .OfType<DataRow>()
            .Select(r => new Rooms
            {
                Id = (int)r["Id"],
                NumberOfMembers=(int)r["NumberOfMembers"],
                Name = (string)r["Name"],
                Photo = (r["Photo"] == DBNull.Value) ? "" : (string)r["Photo"],
            }
        );
        DA.Disconnect();

        return rooms.ToDictionary(u => u.Id);
    }


    public DataTable Search_Rooms()
    {
        string Sql = $"select  rooms.id,rooms.Name,rooms.Photo,COUNT(Memberships.Room_Id)AS NumberOfMembers from rooms" +
            $" join Memberships on rooms.id= Memberships.room_id group by rooms.id,Rooms.Name,rooms.Photo order by NumberOfMembers,rooms.Name";


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

    public DataTable SearchMessagesOfRoom(int? RoomId)
    {
        string Sql = $"select * from Messages where room_id={RoomId} order by date";

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

    public DataTable SearchMessagesOfRoom(int SenderId,int? RoomId)
    {
        string Sql = $"select * from Messages where sender_id={SenderId} and room_id={RoomId}   order by date";

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

    public DataTable MembershipsWithRoomId(int? RoomId)
    {
        string Sql = $"select user_id from Memberships where room_id={RoomId} ";

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
   


    public DataTable MembershipsWithUserId(int? UserId)
    {
        string Sql = $"select DISTINCT  memberships.room_id from memberships join users on {UserId}=memberships.user_id ";

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

    public DataTable CompareUserNameAndRoomName(int? RoomId)
    {
        string Sql = $"select rooms.id, Users.Name from Rooms join Users on Rooms.Name= Users.Name where Rooms.id= {RoomId}";

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

    //public DataTable Search(int? uid)
    //{
    //    string Sql = $"select * from Messages where Receiver_Id={uid}";

    //    DA.Connect();
    //    var dt = DA.Select(Sql);
    //    DA.Disconnect();
    //    if (dt.Rows.Count > 0)
    //    {
    //        return dt;
    //    }
    //    else
    //    {
    //        return null;
    //    }
    //}

    private DataTable SearchNewDate(int? RoomId, DateTime date)
    {
        string Sql = $"select * from Messages where room_id={RoomId} and Date > @date order by date ";

        DA.Connect();
        var dt = DA.Select(Sql, "@date", DbType.DateTime, date);
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

    public class Message
    {
        public int Id { get; set; }
        public int Sender_Id { get; set; }
        public int Room_Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int? Reading_Status { get; set; }
        public int? Answer_Status { get; set; }
      

        public override string ToString() =>$"{Text}"; 
    }


    public class Rooms
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public int NumberOfMembers { get; set; }
        

        public override string ToString() => $"{Name}({NumberOfMembers})";
     
    }
}


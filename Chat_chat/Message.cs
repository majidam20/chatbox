using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chat_CODie.LOL;

namespace Chat_CODie
{
    
    public partial class MessageForm : Form
    {
        Dictionary<int, int> InboxIndexId = new Dictionary<int, int>();
        Dictionary<int, int> SenderIndexId = new Dictionary<int, int>();
        
        public int CurrentUserID;
        DateTime PollMessagesSince = DateTime.Now;
        int i = 0;
        int j = 0;
        MessagesClass.Rooms roomsx = new MessagesClass.Rooms();
        int NumberOfMembers;
        int currentUserRoomId;
        public MessageForm()
        {
            InitializeComponent();
        }

        private void btn_alert_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            var rooms= new MessagesClass.Rooms();
            if (cmb_rooms.SelectedIndex==-1 || cmb_rooms.Text == "")
            {
                MessageBox.Show("please Select Receiver Room!");
                return;
            }


           
           if (rtb_newmessage.Text != "" && cmb_rooms.SelectedIndex != -1 )
            {
                rooms = (MessagesClass.Rooms)cmb_rooms.Items[cmb_rooms.SelectedIndex];
            }
                    
            

            MessagesClass ms = new MessagesClass();
            UsersClass user = new UsersClass();
            DataTable dt = new DataTable();
        

            if (rtb_newmessage.Text == "")
            {
                MessageBox.Show("please enter text!");
                return;
            }

            if (currentUserRoomId==rooms.Id)
            {
                MessageBox.Show("you can not send message for youself, so please select another group");
                return;
            }
            if (rtb_newmessage.Text != "" && cmb_rooms.SelectedIndex != -1 && cmb_rooms.Text != "")
            {
                ms.Add(CurrentUserID, rooms.Id, rtb_newmessage.Text,1,0);
                rtb_newmessage.Text = "";
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            UsersClass user = new UsersClass();
            MessagesClass ms = new MessagesClass();

            var Users = user.FetchSenderUsers();
            var Rooms = ms.FetchRooms();
            var currentUser = Users[CurrentUserID];
            
            HashSet<MessagesClass.Rooms> rooms = new HashSet<MessagesClass.Rooms>();
            HashSet<UsersClass.User> usersWithMessages = new HashSet<UsersClass.User>();

            foreach (DataRow membership in ms.MembershipsWithUserId(CurrentUserID).Rows)
            {
                DataTable dt = new DataTable();
                dt = ms.CompareUserNameAndRoomName((int)membership["room_id"]);

                if (dt!=null)
                {
                var RoomId=(int)dt.Rows[0]["id"];
                    roomsx.Id = RoomId;
                    currentUserRoomId = RoomId;
                    foreach (var message in ms.GetMessagesOfRoom(RoomId))
                    {
                        //InboxIndexId.Add(i, message.Sender_Id);
                        //i++;
                        //lst_inbox.Items.Add(message);
                        usersWithMessages.Add(Users[message.Sender_Id]);
                    }
                    //var list = lst_inbox.Items.Cast<MessagesClass.Message>().OrderBy(item => item.Date).ToList();
                    //lst_inbox.Items.Clear();
                    //foreach (MessagesClass.Message listItem in list)
                    //{
                    //    lst_inbox.Items.Add(listItem);
                    //}
                }


            }

            foreach (var usr in usersWithMessages)
            {
                //SenderIndexId.Add(usr.Id, j);
                //j++;
                lst_sender.Items.Add(usr);
            }


            foreach (DataRow dr in ms.Search_Rooms().Rows)
            {
                
                    rooms.Add(Rooms[(int)dr["id"]]);
               
            }

         
            foreach (var room in rooms)
               
            {
                cmb_rooms.Items.Add(room);
            }

           

            btn_CountOfInbox.Text = lst_inbox.Items.Count.ToString();

            lbl_welcomed.Text = "Hi " + currentUser.Name+" "+ currentUser.Family;
        }
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            UsersClass user = new UsersClass();
            user.LogOut(CurrentUserID);
            LogIn l = new LogIn();
            l.Show();
        }

  

       
        //HashSet<UsersClass.User> usersWithMessages = new HashSet<UsersClass.User>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            //    //timer1.Enabled=false;
               UsersClass user = new UsersClass();
              MessagesClass ms = new MessagesClass();
              var Users = user.FetchSenderUsers();

               HashSet<UsersClass.User> usersWithMessages = new HashSet<UsersClass.User>();

            ////foreach (var message in ms.GetMessagesOfUser(CurrentUserID, PollMessagesSince))
            //    ////{
            //    ////    InboxIndexId.Add(i, message.Sender_Id);
            //    ////    i++;
            //    ////    lst_inbox.Items.Add(message);
            //    ////    usersWithMessages.Add(Users[message.Sender_Id]);
            //    ////}





            //    ////foreach (var usr in usersWithMessages)
            //    ////{
            //    ////    if (SenderIndexId.ContainsKey(usr.Id) == false)
            //    ////    {
            //    ////        SenderIndexId.Add(usr.Id, j);
            //    ////        j++;
            //    ////        lst_sender.Items.Add(usr);
            //    ////    }


            //    ////}
            //    ////btn_CountOfInbox.Text = lst_inbox.Items.Count.ToString();



            //    ////################################

            //lst_inbox.Items.Clear();
            //DataTable dtUserId = new DataTable();
            //dtUserId = ms.MembershipsWithRoomId(roomsx.Id);
            //var UserId = (int)dtUserId.Rows[0]["user_id"];

            //foreach (var messageRecieved0 in ms.GetMessagesOfRoom(usr.Id, roomsx.Id))
            //{

            //    if (roomsx.Id == messageRecieved0.Room_Id)
            //    {
            //        //lst_inbox.Items.Add(messageRecieved + " *recieved*");
            //        messageRecievedSent.Add(messageRecieved0);

            //    }
            //}


            //foreach (DataRow membership in ms.MembershipsWithUserId(usr.Id).Rows)
            //{
            //    DataTable dtRoomId = new DataTable();
            //    dtRoomId = ms.CompareUserNameAndRoomName((int)membership["room_id"]);

            //    if (dtRoomId != null)
            //    {

            //        var RoomId = (int)dtRoomId.Rows[0]["id"];

            //        foreach (var messageSent0 in ms.GetMessagesOfRoom(UserId, RoomId))

            //        {
            //            if (roomsx.Id != messageSent0.Room_Id)
            //            {
            //                //lst_inbox.Items.Add(messageSent + " *sent*");
            //                messageRecievedSent.Add(messageSent0);
            //            }


            //        }
            //    }
            //}

            //foreach (var item in messageRecievedSent)
            //{

            //    lst_inbox.Items.Add(item);

            //}

            //var list = lst_inbox.Items.Cast<MessagesClass.Message>().OrderBy(i => i.Date).ToList();
            //lst_inbox.Items.Clear();
            //foreach (MessagesClass.Message listItem in list)
            //{
            //    lst_inbox.Items.Add(listItem.Text + " (" + listItem.Date + ")");
            //}
//###################################################

            DateTime next = DateTime.Now;

            var rooms = new MessagesClass.Rooms();


            if (cmb_rooms.SelectedIndex == -1)
            {
                foreach (DataRow membership in ms.MembershipsWithUserId(CurrentUserID).Rows)
                {
                    DataTable dt = new DataTable();
                    dt = ms.CompareUserNameAndRoomName((int)membership["room_id"]);

                    if (dt != null)
                    {
                        var RoomId = (int)dt.Rows[0]["id"];
                        roomsx.Id = RoomId;

                        foreach (var message in ms.GetMessagesOfRoom(RoomId, PollMessagesSince))
                        {
                            //InboxIndexId.Add(i, message.Sender_Id);
                            //i++;
                            //lst_inbox.Items.Add(message);
                            usersWithMessages.Add(Users[message.Sender_Id]);
                        }
                        //var list = lst_inbox.Items.Cast<MessagesClass.Message>().OrderBy(i => i.Date).ToList();
                        //lst_inbox.Items.Clear();
                        //foreach (MessagesClass.Message listItem in list)
                        //{
                        //    lst_inbox.Items.Add(listItem.Text + " (" + listItem.Date + ")");
                        //}
                        //var list2 = lst_sender.Items.Cast<UsersClass.User>().OrderBy(item => item.Name).ToList();
                        //lst_sender.Items.Clear();
                        //foreach (UsersClass.User listItem in list2)
                        //{
                        //    lst_sender.Items.Add(listItem);
                        //}
                    }


                    foreach (var usr in usersWithMessages)
                    {
                        List<string> x = new List<string>();
                        //if (InboxIndexId.ContainsKey(usr.Id) == false)
                        //{
                        //    SenderIndexId.Add(usr.Id, j);
                        //    j++;
                        //}
                        if (lst_sender.Items.Count == 0)
                        {
                            lst_sender.Items.Add(usr);

                        }
                        else
                        {
                            for (int i = 0; i < lst_sender.Items.Count; i++)
                            {
                                x.Add(lst_sender.Items[i].ToString());


                            }
                            if (x.Contains(usr.ToString()) == false)
                            {
                                lst_sender.Items.Add(usr);
                            }

                        }
                    }
                }
            }


            //SelectedIndex!=-1
            else
            {

                rooms = (MessagesClass.Rooms)cmb_rooms.Items[cmb_rooms.SelectedIndex];
                //var Rooms = ms.FetchRooms();

                //lst_inbox.Items.Clear();
                //lst_sender.Items.Clear();

                if (rooms.NumberOfMembers == 1)
                {
                    DataTable dt = new DataTable();
                    dt = ms.MembershipsWithRoomId(rooms.Id);
                    foreach (DataRow membership in ms.MembershipsWithUserId((int)dt.Rows[0]["user_id"]).Rows)
                    {

                        foreach (var message in ms.GetMessagesOfRoom((int)membership["room_id"], PollMessagesSince))
                        {
                            //InboxIndexId.Add(i, message.Sender_Id);
                            //i++;

                            lst_inbox.Items.Add(message);

                            usersWithMessages.Add(Users[message.Sender_Id]);
                        }
                    }

                    //var list = lst_inbox.Items.Cast<MessagesClass.Message>().OrderBy(i => i.Date).ToList();
                    //lst_inbox.Items.Clear();
                    //foreach (MessagesClass.Message listItem in list)
                    //{
                    //    lst_inbox.Items.Add(listItem.Text + " (" + listItem.Date + ")");
                    //}



                    foreach (var usr in usersWithMessages)
                    {
                        List<string> x = new List<string>();
                        //if (InboxIndexId.ContainsKey(usr.Id) == false)
                        //{
                        //    SenderIndexId.Add(usr.Id, j);
                        //    j++;
                        //}
                        if (lst_sender.Items.Count == 0)
                        {
                            lst_sender.Items.Add(usr);

                        }
                        else
                        {
                            for (int i = 0; i < lst_sender.Items.Count; i++)
                            {
                                x.Add(lst_sender.Items[i].ToString());
                            }

                            if (x.Contains(usr.ToString()) == false)
                            {
                                lst_sender.Items.Add(usr);
                            }

                        }
                    }

                    //var list2 = lst_sender.Items.Cast<UsersClass.User>()/*.OrderBy(item => item.Name).ToList()*/;
                    //lst_sender.Items.Clear();
                    //foreach (UsersClass.User listItem in list2)
                    //{
                    //    lst_sender.Items.Add(listItem);
                    //}
                }

                //NumberOfMembers > 1
                else
                {
                    foreach (var message in ms.GetMessagesOfRoom(rooms.Id, PollMessagesSince))
                    {
                        //if (InboxIndexId.ContainsKey(i) == false)
                        //{
                        //    InboxIndexId.Add(i, message.Sender_Id);
                        //    i++;
                        //}

                        lst_inbox.Items.Add(message);
                        usersWithMessages.Add(Users[message.Sender_Id]);
                    }
                

                    //var list = lst_inbox.Items.Cast<MessagesClass.Message>().OrderBy(i => i.Date).ToList();
                    //lst_inbox.Items.Clear();
                    //foreach (MessagesClass.Message listItem in list)
                    //{
                    //    lst_inbox.Items.Add(listItem.Text + " (" + listItem.Date + ")");
                    //}

                    //var list = lst_inbox.Items.Cast<MessagesClass.Message>().OrderBy(item => item.Date).ToList();
                    //lst_inbox.Items.Clear();
                    //foreach (MessagesClass.Message listItem in list)
                    //{
                    //    lst_inbox.Items.Add(listItem);
                    //}

                    //var list2 = lst_sender.Items.Cast<UsersClass.User>().OrderBy(item => item.Name).ToList();
                    //lst_sender.Items.Clear();
                    //foreach (UsersClass.User listItem in list2)
                    //{
                    //    lst_sender.Items.Add(listItem);
                    //}

                    foreach (var usr in usersWithMessages)
                    {
                        List<string> x = new List<string>();
                        //if (InboxIndexId.ContainsKey(usr.Id) == false)
                        //{
                        //    SenderIndexId.Add(usr.Id, j);
                        //    j++;
                        //}
                        if (lst_sender.Items.Count == 0)
                        {
                            lst_sender.Items.Add(usr);

                        }
                        else
                        {
                            for (int i = 0; i < lst_sender.Items.Count; i++)
                            {
                                x.Add(lst_sender.Items[i].ToString());


                            }
                            if (x.Contains(usr.ToString()) == false)
                            {
                                lst_sender.Items.Add(usr);
                            }

                        }
                    }



                }

            }


            PollMessagesSince = next;
            //    //btn_CountOfInbox.Text = lst_inbox.Items.Count.ToString();


            //    //################################
        }






        private void lst_sender_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<MessagesClass.Message> messageRecievedSent = new List<MessagesClass.Message>();
            HashSet<MessagesClass.Message> messageSent = new HashSet<MessagesClass.Message>();

            var usr = new UsersClass.User();
            MessagesClass ms = new MessagesClass();
   
            if (lst_sender.SelectedIndex==-1)
            {
                return;
            }
            usr = (UsersClass.User)lst_sender.Items[lst_sender.SelectedIndex];
            if (NumberOfMembers > 1)
            {
                return;
            }

            else
            {
                lst_inbox.Items.Clear();
                DataTable dtUserId = new DataTable();
                dtUserId = ms.MembershipsWithRoomId(roomsx.Id);
                var UserId = (int)dtUserId.Rows[0]["user_id"];

                foreach (var messageRecieved0 in ms.GetMessagesOfRoom(usr.Id, roomsx.Id))
                {

                    if (roomsx.Id == messageRecieved0.Room_Id)
                    {
                        //lst_inbox.Items.Add(messageRecieved + " *recieved*");
                        messageRecievedSent.Add(messageRecieved0);
                        
                    }
                }


                foreach (DataRow membership in ms.MembershipsWithUserId(usr.Id).Rows)
                {
                    DataTable dtRoomId = new DataTable();
                    dtRoomId = ms.CompareUserNameAndRoomName((int)membership["room_id"]);

                    if (dtRoomId != null)
                    {

                        var RoomId = (int)dtRoomId.Rows[0]["id"];

                        foreach (var messageSent0 in ms.GetMessagesOfRoom(UserId, RoomId))

                        {
                            if (roomsx.Id != messageSent0.Room_Id)
                            {
                                //lst_inbox.Items.Add(messageSent + " *sent*");
                                messageRecievedSent.Add(messageSent0);
                              
                            }


                        }
                    }
                }

                foreach (var item in messageRecievedSent)
                {

                    lst_inbox.Items.Add(item);
                    
                }

                var list = lst_inbox.Items.Cast<MessagesClass.Message>().OrderBy(i => i.Date).ToList();
                lst_inbox.Items.Clear();
                foreach (MessagesClass.Message listItem in list)
                {
                    lst_inbox.Items.Add(listItem.Text+" ("+listItem.Date+")");
                }

            }

        }
     
        private void cmb_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            UsersClass user = new UsersClass();
            MessagesClass ms = new MessagesClass();

            roomsx = (MessagesClass.Rooms)cmb_rooms.Items[cmb_rooms.SelectedIndex];

            var Users = user.FetchSenderUsers();
            var Rooms = ms.FetchRooms();
          
            HashSet<UsersClass.User> usersWithMessages = new HashSet<UsersClass.User>();

            lst_inbox.Items.Clear();
            lst_sender.Items.Clear();
            if (cmb_rooms.SelectedIndex==-1)
            {
                return;
            }
            else
            {
                
                var rooms = (MessagesClass.Rooms)cmb_rooms.Items[cmb_rooms.SelectedIndex];
                NumberOfMembers = rooms.NumberOfMembers;

                //if (rooms.NumberOfMembers > 1)
                //{
                    foreach (var message in ms.GetMessagesOfRoom(rooms.Id))
                    {
                    //if (InboxIndexId.ContainsKey(i) == false)
                    //{
                    //    InboxIndexId.Add(i, message.Sender_Id);
                    //    //i++;
                    //}
                    if (rooms.NumberOfMembers != 1)
                    {
                        lst_inbox.Items.Add(message);
                    }
                        usersWithMessages.Add(Users[message.Sender_Id]);
                    }
                    foreach (var usr in usersWithMessages)
                    {
                        //if (SenderIndexId.ContainsKey(usr.Id) == false)
                        //{
                        //    SenderIndexId.Add(usr.Id, j);
                        //    j++;
                        //}

                        lst_sender.Items.Add(usr);
                    }
               // }

                //else
                //{
                //    foreach (var message in ms.GetMessagesOfRoom(roomsx.Id))
                //    {
                //        //if (InboxIndexId.ContainsKey(i) == false)
                //        //{
                //        //    InboxIndexId.Add(i, message.Sender_Id);
                //        //    //i++;
                //        //}

                //        //lst_inbox.Items.Add(message);
                //        usersWithMessages.Add(Users[message.Sender_Id]);
                //    }
                //    foreach (var usr in usersWithMessages)
                //    {
                //        //if (SenderIndexId.ContainsKey(usr.Id) == false)
                //        //{
                //        //    SenderIndexId.Add(usr.Id, j);
                //        //    j++;
                //        //}

                //        lst_sender.Items.Add(usr);
                //    }
                //}


            }


            //btn_CountOfInbox.Text = lst_inbox.Items.Count.ToString();

        }

        private void lst_inbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var usr = new MessagesClass.Message();
            
            //usr = (MessagesClass.Message)lst_inbox.Items[lst_inbox.SelectedIndex];

            //if (SenderIndexId.ContainsKey(usr.Sender_Id))
            //{
            //    lst_sender.SetSelected(SenderIndexId[usr.Sender_Id], true);
           
            //}
            

        }

       
        private void btn_CountOfInbox_Click_1(object sender, EventArgs e)
        {
           
            
            
        }
    }
    }


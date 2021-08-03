using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class_Moderation.BLL;
using System.Data;
using System.Data.SqlClient;

namespace Class_Moderation.DAL
{
    public class ClassModerationDAL
    {
        public static string ConnectionString = "Data Source=.;Initial Catalog=ClassModeration;Integrated Security=True";

        public static int Login(string User, string Pass)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Select Count(Username) From [User] Where Username='{0}' And Password='{1}'", User, Pass);

                int Counter = (int)Command.ExecuteScalar();
                return Counter;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }
        
        public static void NewUser(ClassModeration.BLL.User oUser)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText ="Insert into [User] Select @Username, @Password";

                Command.Parameters.AddWithValue("@Username", oUser.Username);
                Command.Parameters.AddWithValue("@Password", oUser.Password);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static DataTable GetAllUsers()
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Select * From [User]");

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                return Table;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void DeleteUser(int id)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Delete From [User] Where ID={0}", id);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void UpdateClassStatus(string oClock)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = "Update ClassDetails Set Status='تشکیل شد' Where DueTime < '" + oClock + "' AND Status = 'ــــ'";

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static DataTable GetEntries()
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.Text;
                Command.CommandText = "Select * From Book";

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();

                Table.Load(Reader);
                return Table;
            }
            finally
            {
                if (Connection.State!=ConnectionState.Closed)
                {
                    Connection.Close();
                }
            }
        }

        public static DataTable GetClassDetailsEntries(int book_Id)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.Text;
                Command.CommandText = string.Format("Select * From ClassDetails Where Book_ID={0}", book_Id);

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();

                Table.Load(Reader);
                return Table;
            }
            finally
            {
                if (Connection.State != ConnectionState.Closed)
                {
                    Connection.Close();
                }
            }
        }

        /// <summary>
        /// InsertLesson Method
        /// </summary>
        /// <param name="oLesson"></param>
        public static void InsertLesson(Lesson oLesson)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();

            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"InsertLesson";

                Command.Parameters.Add("@BookCode", SqlDbType.NVarChar, 50);
                Command.Parameters.Add("@BookName", SqlDbType.NVarChar, 50);
                Command.Parameters.Add("@Workable", SqlDbType.NVarChar, 10);
                Command.Parameters.Add("@Theoric", SqlDbType.NVarChar, 10);
                Command.Parameters.Add("@Subject", SqlDbType.NVarChar, 50);
                Command.Parameters.Add("@LessonType", SqlDbType.NVarChar, 20);
                Command.Parameters.Add("@TeacherName", SqlDbType.NVarChar, 50);
                Command.Parameters.Add("@Lecture", SqlDbType.NVarChar, 10);

                if (!String.IsNullOrEmpty(oLesson.BookCode))
                {
                    Command.Parameters["@BookCode"].Value = oLesson.BookCode;
                }
                else
                {
                    Exception e = new Exception("لطفا کد درس را وارد کنید");
                    throw e;
                }

                if (!String.IsNullOrEmpty(oLesson.BookName))
                {
                    Command.Parameters["@BookName"].Value = oLesson.BookName;
                }
                else
                {
                    Exception e = new Exception("لطفا نام درس را وارد کنید");
                    throw e;
                }

                if (!String.IsNullOrEmpty(oLesson.WorkableUnit))
                {
                    Command.Parameters["@Workable"].Value = oLesson.WorkableUnit;
                }
                else
                {
                    Exception e = new Exception("لطفا تعداد واحدعملی درس را وارد کنید");
                    throw e;
                }
                
                if (!String.IsNullOrEmpty(oLesson.TheoricUnit))
                {
                    Command.Parameters["@Theoric"].Value = oLesson.TheoricUnit;
                }
                else
                {
                    Exception e = new Exception("لطفا تعداد واحدتئوری درس را وارد کنید");
                    throw e;
                }

                if (!String.IsNullOrEmpty(oLesson.SubjectName))
                {
                    Command.Parameters["@Subject"].Value = oLesson.SubjectName;
                }
                else
                {
                    Exception e = new Exception("لطفا رشته مربوطه را وارد کنید");
                    throw e;
                }

                if (true)
                {
                    Command.Parameters["@LessonType"].Value = oLesson.LessonType;
                }
                else
                {
                    Exception e = new Exception("لطفا نوع درس را انتخاب کنید");
                    throw e;
                }

                if (!String.IsNullOrEmpty(oLesson.TeacherName))
                {
                    Command.Parameters["@TeacherName"].Value = oLesson.TeacherName;
                }
                else
                {
                    Exception e = new Exception("لطفا نام استاد را وارد کنید");
                    throw e;
                }

                if (!String.IsNullOrEmpty(oLesson.Lecture))
                {
                    Command.Parameters["@Lecture"].Value = oLesson.Lecture;
                }
                else
                {
                    Exception e = new Exception("لطفا تعداد جلسات برگزاری کلاس را وارد کنید");
                    throw e;
                }


                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }
        /// <summary>
        /// Delete Lesson Method
        /// </summary>
        /// <param name="oLesson"></param>
        public static void DeleteLesson(int inID)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"DeleteLesson";

                Command.Parameters.Add("@id", SqlDbType.Int);
                Command.Parameters["@id"].Value=inID;

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void DeleteRowDetails(int inID)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();

            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"DeleteRowDetails";

                Command.Parameters.Add("@ID", SqlDbType.Int);
                Command.Parameters["@ID"].Value = inID;

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void InsertClassDetails(int inID, ClassDetails oClassDetails)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try 
	        {	        
		        Connection.Open();
                Command.Connection=Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"InsertClassDetails";

                Command.Parameters.Add("@ID", SqlDbType.Int);
                Command.Parameters.Add("@DayName", SqlDbType.NVarChar, 20);
                Command.Parameters.Add("@DueDate", SqlDbType.NVarChar, 20);
                Command.Parameters.Add("@DueTime", SqlDbType.NVarChar, 20);
                Command.Parameters.Add("@ClassNo", SqlDbType.NVarChar, 10);
                Command.Parameters.AddWithValue("@Status", oClassDetails.Status);

                Command.Parameters["@ID"].Value = inID;
                if(!String.IsNullOrEmpty(oClassDetails.DayName))
                {
                    Command.Parameters["@DayName"].Value = oClassDetails.DayName;
                }
                else
	            {
                    Exception e= new Exception("لطفا روز را وارد کنید");
                    throw e;
	            }

                if (!String.IsNullOrEmpty(oClassDetails.ClassDate))
                {
                    Command.Parameters["@DueDate"].Value = oClassDetails.ClassDate;
                }
                else
                {
                    Exception e = new Exception("لطفا تاریخ را وارد کنید");
                    throw e;
                }

                if (!String.IsNullOrEmpty(oClassDetails.ClassTime))
                {
                    Command.Parameters["@DueTime"].Value=oClassDetails.ClassTime;
                }
                else
                {
                    Exception e = new Exception("لطفا ساعت برگزاری کلاس را وارد کنید");
                    throw e;
                }

                if (!String.IsNullOrEmpty(oClassDetails.ClassNo))
                {
                    Command.Parameters["@ClassNo"].Value = oClassDetails.ClassNo;
                }
                else
                {
                    Exception e = new Exception("لطفا شماره کلاس را وارد کنید");
                    throw e;
                }


                Command.ExecuteNonQuery();
	        }
            finally
            {
                if (Connection.State==ConnectionState.Open)
	            {
		            Connection.Close();
	            }
            }
        }

        public static ClassDetails Retrieve(int id)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"Retrieve";

                Command.Parameters.Add("@ID", SqlDbType.Int);
                Command.Parameters["@ID"].Value = id;

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                ClassDetails oClassDetails = new ClassDetails();
                oClassDetails.DayName = Convert.ToString(Table.Rows[0]["DayName"]);
                oClassDetails.ClassDate = Convert.ToString(Table.Rows[0]["DueDate"]);
                oClassDetails.ClassTime = Convert.ToString(Table.Rows[0]["DueTime"]);
                oClassDetails.ClassNo = Convert.ToString(Table.Rows[0]["ClassNo"]);
                oClassDetails.Status = Convert.ToString(Table.Rows[0]["Status"]);

                return oClassDetails;
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static Lesson RetrieveLesson(int id)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"RetrieveLesson";

                Command.Parameters.Add("@ID", SqlDbType.Int);
                Command.Parameters["@ID"].Value = id;

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                Lesson oLesson = new Lesson();
                oLesson.BookCode = Convert.ToString(Table.Rows[0]["BookCode"]);
                oLesson.BookName = Convert.ToString(Table.Rows[0]["BookName"]);
                oLesson.SubjectName = Convert.ToString(Table.Rows[0]["Subject"]);
                oLesson.LessonType = Convert.ToString(Table.Rows[0]["LessonType"]);
                oLesson.Lecture = Convert.ToString(Table.Rows[0]["Lecture"]);
                oLesson.TeacherName = Convert.ToString(Table.Rows[0]["TeacherName"]);
                oLesson.WorkableUnit = Convert.ToString(Table.Rows[0]["WorkableUnit"]);
                oLesson.TheoricUnit = Convert.ToString(Table.Rows[0]["TheoricUnit"]);

                return oLesson;
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void UpdateLesson(int id, Lesson oLesson)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"UpdateLesson";

                Command.Parameters.Add("@ID", SqlDbType.Int);
                Command.Parameters.Add("@BookCode", SqlDbType.NVarChar, 50);
                Command.Parameters.Add("@BookName", SqlDbType.NVarChar, 50);
                Command.Parameters.Add("@Workable", SqlDbType.NVarChar, 10);
                Command.Parameters.Add("@Theoric", SqlDbType.NVarChar, 10);
                Command.Parameters.Add("@Subject", SqlDbType.NVarChar, 50);
                Command.Parameters.Add("@LessonType", SqlDbType.NVarChar, 20);
                Command.Parameters.Add("@TeacherName", SqlDbType.NVarChar, 50);
                Command.Parameters.Add("@Lecture", SqlDbType.NVarChar, 10);

                Command.Parameters["@ID"].Value = id;

                if (!String.IsNullOrEmpty(oLesson.BookCode))
                {
                    Command.Parameters["@BookCode"].Value = oLesson.BookCode;
                }
                else
                {
                    Exception e = new Exception("لطفا کد درس را وارد کنید");
                    throw e;
                }

                if (!String.IsNullOrEmpty(oLesson.BookName))
                {
                    Command.Parameters["@BookName"].Value = oLesson.BookName;
                }
                else
                {
                    Exception e = new Exception("لطفا نام درس را وارد کنید");
                    throw e;
                }

                if (!String.IsNullOrEmpty(oLesson.WorkableUnit))
                {
                    Command.Parameters["@Workable"].Value = oLesson.WorkableUnit;
                }
                else
                {
                    Exception e = new Exception("لطفا تعداد واحدعملی درس را وارد کنید");
                    throw e;
                }

                if (!String.IsNullOrEmpty(oLesson.TheoricUnit))
                {
                    Command.Parameters["@Theoric"].Value = oLesson.TheoricUnit;
                }
                else
                {
                    Exception e = new Exception("لطفا تعداد واحدتئوری درس را وارد کنید");
                    throw e;
                }

                if (!String.IsNullOrEmpty(oLesson.SubjectName))
                {
                    Command.Parameters["@Subject"].Value = oLesson.SubjectName;
                }
                else
                {
                    Exception e = new Exception("لطفا رشته مربوطه را وارد کنید");
                    throw e;
                }

                if (true)
                {
                    Command.Parameters["@LessonType"].Value = oLesson.LessonType;
                }
                else
                {
                    Exception e = new Exception("لطفا نوع درس را انتخاب کنید");
                    throw e;
                }

                if (!String.IsNullOrEmpty(oLesson.TeacherName))
                {
                    Command.Parameters["@TeacherName"].Value = oLesson.TeacherName;
                }
                else
                {
                    Exception e = new Exception("لطفا نام استاد را وارد کنید");
                    throw e;
                }

                if (!String.IsNullOrEmpty(oLesson.Lecture))
                {
                    Command.Parameters["@Lecture"].Value = oLesson.Lecture;
                }
                else
                {
                    Exception e = new Exception("لطفا تعداد جلسات برگزاری کلاس را وارد کنید");
                    throw e;
                }


                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void UpdateDetails(int id, ClassDetails oClassDetails)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"UpdateDetails";

                Command.Parameters.Add("@ID", SqlDbType.Int);
                Command.Parameters.Add("@DayName", SqlDbType.NVarChar, 20);
                Command.Parameters.Add("@DueDate", SqlDbType.NVarChar, 20);
                Command.Parameters.Add("@DueTime", SqlDbType.NVarChar, 20);
                Command.Parameters.Add("@ClassNo", SqlDbType.NVarChar, 10);
                Command.Parameters.AddWithValue("@Status", oClassDetails.Status);

                Command.Parameters["@ID"].Value = id;

                if (!String.IsNullOrEmpty(oClassDetails.DayName))
                {
                    Command.Parameters["@DayName"].Value = oClassDetails.DayName;
                }
                else
                {
                    Exception e = new Exception("لطفا روز را وارد کنید");
                    throw e;
                }

                if (!String.IsNullOrEmpty(oClassDetails.ClassDate))
                {
                    Command.Parameters["@DueDate"].Value = oClassDetails.ClassDate;
                }
                else
                {
                    Exception e = new Exception("لطفا تاریخ را وارد کنید");
                    throw e;
                }

                if (!String.IsNullOrEmpty(oClassDetails.ClassTime))
                {
                    Command.Parameters["@DueTime"].Value = oClassDetails.ClassTime;
                }
                else
                {
                    Exception e = new Exception("لطفا ساعت برگزاری کلاس را وارد کنید");
                    throw e;
                }

                if (!String.IsNullOrEmpty(oClassDetails.ClassNo))
                {
                    Command.Parameters["@ClassNo"].Value = oClassDetails.ClassNo;
                }
                else
                {
                    Exception e = new Exception("لطفا شماره کلاس را وارد کنید");
                    throw e;
                }

                Command.ExecuteNonQuery();

            }
            finally
            {
                if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }
    }
}

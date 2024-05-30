using LMSDreams.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDreams.BS_Layer
{
    public class BLData
    {
        BLUser bLUser = null;
        BLUserInfor bLUserInfor = null;
        BLUserRole bLUserRole = null;
        BLStudent bLStudent = null;
        BLTeacher bLTeacher = null;
        BLDataBaseImageTable bLImage = null;
        BLOtp bLOtp = null;
        BLFaculty bLFaculty = null;
        BLTrainingForm bLTrainingForm = null;
        BLSubject bLSubject = null;
        BLSemeter bLSemeter = null;
        BLSubjectClass bLSubjectClass = null;
        BLScore bLScore = null;
        BLStudentClass bLStudentClass = null;
        BLNotification bLNotification = null;
        DBMain db = null;
        public BLData()
        {
            db = new DBMain();
            init();
        }
        private void init()
        {
            bLUser = new BLUser();
            bLImage = new BLDataBaseImageTable();
            bLOtp = new BLOtp();
            bLStudent = new BLStudent();
            bLTeacher = new BLTeacher();
            bLUserInfor = new BLUserInfor();
            bLUserRole = new BLUserRole();
            bLFaculty = new BLFaculty();
            bLTrainingForm = new BLTrainingForm();
            bLSubject = new BLSubject();
            bLSemeter = new BLSemeter(); 
            bLSubjectClass = new BLSubjectClass();
            bLScore = new BLScore();
            bLStudentClass = new BLStudentClass();
            bLNotification = new BLNotification();
        }

        public DataSet GetAdminUser()
        {
            string sqlString = "select [USER].Username, [USER].Password, USERINFOR.Fullname,USERINFOR.Sex,USERROLE.Role\r\nfrom [USER], USERINFOR, USERROLE\r\nwhere [USER].IdInfo = USERINFOR.Id and [USER].IdRole = USERROLE.Id";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        public string GetIdRoleByUser(string user)
        {
            return bLUser.GetColumnByUser(user, 5);
        }
        public List<string> GetFaculty()
        {
            List<string> list = new List<string>();
            DataSet ds = bLFaculty.GetFaculty();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                list.Add(row[1].ToString());
            }
            return list;
        }

        public List<string> GetSubject()
        {
            List<string> list = new List<string>();
            DataSet ds = bLSubject.GetSubject();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }
        public List<string> GetTrainingForm()
        {
            List<string> list = new List<string>();
            DataSet ds = bLTrainingForm.GetTrainingForm();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                list.Add(row[1].ToString());
            }
            return list;
        }

        public List<string> GetTrainingFormId()
        {
            List<string> list = new List<string>();
            DataSet ds = bLTrainingForm.GetTrainingForm();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }

        
        public List<string> GetTeacher()
        {
            List<string> list = new List<string>();
            DataSet ds = bLTeacher.GetTeacher();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }

        public List<string> GetSemeter()
        {
            List<string> list = new List<string>();
            DataSet ds = bLSemeter.GetSemeter();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }
        public string GetFacultyByUser(string user)
        {
            if (user[0].ToString() == "1")
                return "-1";
            string faculty = "";
            if (user[0].ToString() == "2")
                faculty = bLTeacher.GetColumnByUser(user, 1);
            else
                faculty = bLStudent.GetColumnByUser(user, 1);
            return bLFaculty.GetColumnById(faculty, 1);
        }

        public string GetfacultyByName(string name)
        {
            return bLFaculty.SearchFacultyByName(name).Tables[0].Rows[0][0].ToString();
        }

        public string GetTrainingFormByName(string name)
        {
            return bLTrainingForm.GetTrainingFormByName(name).Tables[0].Rows[0][0].ToString();
        }
        public string GetTraingFormByUser(string user)
        {
            string traingform = bLStudent.GetColumnByUser(user, 2);
            return bLTrainingForm.GetColumnById(traingform, 1);
        }
        public string GetSexByUser(string user)
        {
            string sqlString = "select USERINFOR.Sex\r\nfrom [USER], USERINFOR\r\nwhere [USER].IdInfo = USERINFOR.Id and [USER].Username = '" + user + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows[0][0].ToString();
        }
        public bool UpdateUser(string user, string pass, string name, string sex)
        {
            string infor = bLUser.GetColumnByUser(user, 2);
            return bLUserInfor.UpdateUserInfor(infor, name, (sex == "True") ? "1" : "0") && bLUser.UpdatePass(user, pass);
        }
        public List<string> IdRamdom(string role)
        {
            string user = bLUser.CreateRamdomUsername(role);
            string infor = bLUserInfor.CreateRamdomIdInfor();
            string otp = bLOtp.CreateRamdomOtp();
            string image = bLImage.CreateRamdomImage();
            string pass = "123@";
            return new List<string>(new string[] { user, pass, infor, otp, image });
        }
        public DataSet SearchIdUser(string user)
        {
            if (bLUser.CheckUser(user) == false)
            {
                return null;
            }
            string sqlString = "select [USER].Username, [USER].Password, USERINFOR.Fullname,USERINFOR.Sex,USERROLE.Role\r\nfrom [USER], USERINFOR, USERROLE\r\nwhere [USER].IdInfo = USERINFOR.Id and [USER].IdRole = USERROLE.Id and [USER].Username like '%" + user + "%'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        private void createUser(string role, string user, string pass, string name, string sex)
        {
            List<string> IDs = IdRamdom(role);
            bLUserInfor.AddUserInfor(IDs[2], name, sex);
            bLOtp.AddOtp(IDs[3], "11111", "60");
            bLImage.AddDataBaseImageTable(IDs[4], bLImage.GetImageString("AV001"));
            bLUser.AddUser(user, IDs[3], IDs[2], pass, IDs[4], role);
        }
        public bool CreateStudent(string user, string pass, string name, string sex, string faculty, string trainingform)
        {
            createUser("3", user, pass, name, sex);
            bLStudent.AddStudent(user, faculty, trainingform, "1");
            return true;
        }
        public bool CreateTeacher(string user, string pass, string name, string sex, string faculty)
        {
            createUser("2", user, pass, name, sex);
            bLTeacher.AddTeacher(user, faculty);
            return true;
        }
        public bool CreateAdmin(string user, string pass, string name, string sex)
        {
            createUser("1", user, pass, name, sex);
            return true;
        }
        public bool DeleteUser(string role, string user)
        {
            string otp = bLUser.GetColumnByUser(user, 1);
            string infor = bLUser.GetColumnByUser(user, 2);
            string image = bLUser.GetColumnByUser(user, 4);

            bLUser.DeleteUser(user);

            bLUserInfor.DeleteUserInfor(infor);
            bLImage.DeleteDataBaseImageTable(image);
            bLOtp.DeleteOtp(otp);

            if (role == "2")
            {
                bLTeacher.DeleteTeacher(user);
            }
            if (role == "3")
            {
                bLStudent.DeleteStudent(user);
            }

            return true;
        }

        public DataSet GetStudentInClass(string id)
        {
            return bLSubjectClass.GetLstStudentInClass(id);
        }

        public bool DeleteStudentInClass(string student, string idclass)
        {
            string subject = bLSubjectClass.GetColumnById(idclass, 2);
            bLScore.DeleteScoreSdtuent(student, subject);
            bLStudentClass.DeleteStudentClass(student, idclass);
            return true;
        }

        public bool AddStudentToClass(string student, string idclass, string score)
        {
            string subject = bLSubjectClass.GetColumnById(idclass, 2);
            string semeter = bLSubjectClass.GetColumnById(idclass, 4);
            bLScore.AddScore(student, semeter, subject, score);
            bLStudentClass.AddStudentClass(student, idclass);
            return true;
        }

        public bool UpdateScoreByUser(string student, string idClass, string score)
        {
            string subject = bLSubjectClass.GetColumnById(idClass, 2);
            string semeter = bLSubjectClass.GetColumnById(idClass, 4);
            bLScore.UpdateScore(student, semeter, subject, score);
            return true;
        }

        public bool CheckUser(string user, string role)
        {
            if (bLUser.CheckUser(user))
            {
                return GetIdRoleByUser(user) == role;
            }
            return false;
        }

        public bool CheckStudentInClass(string student, string idclass)
        {
            foreach (DataRow row in bLSubjectClass.GetLstStudentInClass(idclass).Tables[0].Rows)
            {
                if (row[0].ToString() == student)
                {
                    return true;
                }
            }
            return false;
        }

        public string GetNameByUser(string user)
        {
            string infor = bLUser.GetColumnByUser(user, 2);
            return bLUserInfor.GetColumnById(infor, 1);
        }

        public DataSet SearchStudentByClass(string student, string idClass)
        {
            string sqlString = "select STUDENT_CLASS.IdStudent, Fullname, Sex, Score\r\nfrom  [USER], USERINFOR, SCORE, STUDENT_CLASS, CLASS\r\nwhere [USER].IdInfo = USERINFOR.Id and STUDENT_CLASS.IdStudent = [USER].Username \r\n\tand STUDENT_CLASS.IdClass = CLASS.Id and\r\n\tCLASS.IdSubject = SCORE.IdSubject and \r\n\tSCORE.IdStudent = STUDENT_CLASS.IdStudent\r\n\tand CLASS.Id = '" + idClass + "' and [USER].Username = '" + student + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataSet GetLstNotificationOfUser(string user)
        {
            string sqlstring = "select Id, Topic, IdUserSender\r\nfrom NOTIFICATION\r\nwhere IdUserReceiver = '" + user + "'";
            return db.ExecuteQueryDataSet(sqlstring, CommandType.Text);
        }

        public string GetContentById(string id)
        {
            return bLNotification.GetContentByID(id);
        }

        public List<string> GetLstClassByTeacher(string teaacher)
        {
            List<string> lst = new List<string>();
            foreach (DataRow row in bLSubjectClass.SearchSubjectClassByTeacherId(teaacher).Tables[0].Rows)
            {
                lst.Add(row[0].ToString());
            }
            return lst;
        }

        public string GetRandomIdNotification()
        {
            return bLNotification.GetIDRamdom();
        }

        public bool CreateNotification(string id, string topic, string content, string send, string receive)
        {
            return bLNotification.CreateNotification(id, topic, content, send, receive);
        }

        public List<string> GetlstIdUserByFaculty(string faculty)
        {
            List<string> lst = new List<string>();
            string sqlstring1 = "select STUDENT.Id\r\nfrom  STUDENT\r\nwhere STUDENT.IdFaculty = '" + faculty + "'";
            DataSet ds1 = db.ExecuteQueryDataSet(sqlstring1, CommandType.Text);

            string sqlstring2 = "select TEACHER.Id\r\nfrom  TEACHER\r\nwhere TEACHER.IdFaculty = '" + faculty + "'";
            DataSet ds2 = db.ExecuteQueryDataSet(sqlstring2, CommandType.Text);

            foreach (DataRow row in ds1.Tables[0].Rows)
            {
                lst.Add(row[0].ToString());
            }
            foreach (DataRow row in ds2.Tables[0].Rows)
            {
                lst.Add(row[0].ToString());
            }
            return lst;
        }

        public List<string> GetIdTeacherByFaculty(string faculty)
        {
            List<string> lst = new List<string>();
            foreach (DataRow row in bLTeacher.GetTeacher().Tables[0].Rows)
            {
                if (row[1].ToString() == faculty)
                    lst.Add(row[0].ToString());
            }
            return lst;
        }

        public List<string> GetIdStudentByFaculty(string faculty)
        {
            List<string> lst = new List<string>();
            foreach (DataRow row in bLStudent.GetStudent().Tables[0].Rows)
            {
                if (row[1].ToString() == faculty)
                    lst.Add(row[0].ToString());
            }
            return lst;
        }

        public List<string> GetIdTeacher()
        {
            List<string> lst = new List<string>();
            foreach (DataRow row in bLTeacher.GetTeacher().Tables[0].Rows)
            {
                lst.Add(row[0].ToString());
            }
            return lst;
        }

        public List<string> GetIdStudentByFacultyTrainingForm(string faculty, string trainingform)
        {
            List<string> lst = new List<string>();
            foreach (DataRow row in bLStudent.GetStudent().Tables[0].Rows)
            {
                if (row[1].ToString() == faculty && row[2].ToString() == trainingform)
                    lst.Add(row[0].ToString());
            }
            return lst;
        }

        public List<string> GetIdStudent()
        {
            List<string> lst = new List<string>();
            foreach (DataRow row in bLStudent.GetStudent().Tables[0].Rows)
            {
                lst.Add(row[0].ToString());
            }
            return lst;
        }

        public string GetIdTrainingFormByStudent(string student)
        {
            return bLStudent.GetColumnByUser(student, 2);
        }

        public DataSet GetLstClassByTrainingForm(string traingingform)
        {
            string sqlString = "select CLASS.Id,  [SUBJECT].Displayname, Fullname as Teacher, Credit, Quantity\r\nfrom CLASS, [SUBJECT], [USER], USERINFOR\r\nwhere IdTrainingForm = '" + traingingform + "' and CLASS.IdSubject = [SUBJECT].Id and CLASS.IdTeacher = [USER].Username and [USER].IdInfo = USERINFOR.Id\r\n";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataSet GetLstSelectedClassByStudent(string student, string trainingform)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(new DataTable());

            ds.Tables[0].Columns.Add("Id");
            ds.Tables[0].Columns.Add("Displayname");
            ds.Tables[0].Columns.Add("Teacher");
            ds.Tables[0].Columns.Add("Credit");
            ds.Tables[0].Columns.Add("Quantity");

            List<string> idclass = new List<string>();

            foreach (DataRow row in bLStudentClass.GetStudentClassByIdStudent(student).Tables[0].Rows)
            {
                idclass.Add(row[1].ToString());
            }

            foreach (DataRow row in GetLstClassByTrainingForm(trainingform).Tables[0].Rows)
            {
                string id = row[0].ToString();
                if (idclass.Contains(id))
                {
                    ds.Tables[0].ImportRow(row);
                }
            }
            return ds;
        }

    }
}

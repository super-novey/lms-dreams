using LMSDreams.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSDreams.CustomControls
{
    public partial class SubjectClassItem : UserControl
    {
        public SubjectClassItem(string idClass, string teacherName, string quantity)
        {
            InitializeComponent();
            SubjectClassID = idClass;
            SubjectClassTeacherName = teacherName;
            SubjectClassQuantity = quantity;
        }

        public static string temp_id;

        public static bool isSelect = false;


        private string teacherName = "label1";

        public string SubjectClassTeacherName
        {
            get { return teacherName; }
            set {
                teacherName = value;
                this.Invalidate();
            }
        }

        private string quantity = "0";

        public string SubjectClassQuantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                this.Invalidate();
            }
        }

        private string idClass = "";
        public string SubjectClassID
        {
            get { return idClass; }
            set
            {
                idClass = value;
                this.Invalidate();
            }
        }

        private string nameSubject;
        public string NameSubject
        {
            get { return nameSubject; }
            set { nameSubject = value; 
            }
        }

        private string idSubject;
        public string IdSubject
        {
            get { return idSubject; }
            set { idSubject = value; 
            }
        }

        private string trainingForm;
        public string TrainingForm
        {
            get { return trainingForm; }
            set { trainingForm = value; 
            }
        }

        private string semeter;
        public string Semeter
        {
            get { return semeter; }
            set { semeter = value; 
            }
        }


        private void SubjectClassItem_Paint(object sender, PaintEventArgs e)
        {
            lblTeacherName.Text = SubjectClassTeacherName;
            lblQuantity.Text = SubjectClassQuantity;
            lblIdClass.Text = SubjectClassID;
        }

        public static bool isViewDetailClass = false;
        private void btnShowDetail_Click_1(object sender, EventArgs e)
        {
           temp_id = this.SubjectClassID;
           isViewDetailClass = true;
        }
       
        
        private void pbClass_Click(object sender, EventArgs e)
        {
            isSelect = true;
            temp_id = this.SubjectClassID;
        }

       
    }
}

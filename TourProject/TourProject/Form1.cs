using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourProject.Model;

namespace TourProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TourDbContext context = new TourDbContext();
            var query = context.Tourists.Where(x => x.Gender.GenderDescription == "Woman").Select(x => new { x.FirstName, x.LastName, x.Gender.GenderDescription }).ToList();
            var q1 = context.Guides.Join(context.TouristGuidePlaces,
                                            x => x.GuideID,
                                            a => a.GuideID,
                                            (x, a) => new
                                            {

                                                ad = x.FirstName,
                                                soyad = x.LastName,
                                                tID = a.TouristID
                                            }).Join(context.Tourists,
                                            x => x.tID,
                                            g => g.TouristID,
                                            (x, g) => new
                                            {
                                                x.ad,
                                                x.soyad

                                            }).ToList();

            var q2 = context.Tourists.Join(context.Nationalities,
                                           t => t.NationalityID,
                                           n => n.NationalityID,
                                           (t, n) => new
                                           {
                                               ad = t.FirstName + " " + t.LastName,
                                               Uyruk = n.NationalityDescription,
                                               n1ID = t.NationalityID,
                                               n2ID = n.NationalityID
                                           }).Where(x => x.n1ID == x.n2ID).ToList();
            dataGridView1.DataSource = q2;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            label1.Text = dataGridView1.Rows.Count.ToString();

        }
    }
}

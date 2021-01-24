using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExampleFormsApp.Data;

namespace ExampleFormsApp
{
    public partial class Form1 : Form
    {
        private AppDbContext _context;
        public Form1()
        {
            _context = new AppDbContext();
          
            InitializeComponent();
        }

        private void btnGetStudents_Click(object sender, EventArgs e)
        {
            Console.WriteLine(string.Join(",", _context.Students.Select(s => s.Name).ToList().ToArray()));
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            _context.Students.Add(new Student { Name = "Test_" + Guid.NewGuid().ToString() });
            _context.SaveChanges();
        }
    }
}

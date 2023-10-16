using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.Price
{
    public partial class ApplyFactor : Form
    {
        public ApplyFactor()
        {
            InitializeComponent();
        }
        public static List<TimeApplyFactor> timeApplyFactors;
        public static List<WeekDay> weekDay;
        private void ApplyFactor_Load(object sender, EventArgs e)
        {
            LoadFile();
            CheckWeekDay();
            DateTime d = DateTime.Now;
            dtpStarTime.Value = new DateTime(d.Year, d.Month, d.Day, 5, 0, 0);
            dtpEndTime.Value = new DateTime(d.Year, d.Month, d.Day, 22, 0, 0);
            BindGrid();
        }
        private void BindGrid()
        {
            dgvTime.Rows.Clear();
            if (timeApplyFactors.Count == 0)
                return;
            foreach(TimeApplyFactor item in timeApplyFactors) 
            {
                int i = dgvTime.Rows.Add();
                dgvTime.Rows[i].Cells[0].Value = item.NumericOrder;
                dgvTime.Rows[i].Cells[1].Value = (item.StartTime / 60).ToString() +":"+ (item.StartTime % 60).ToString();
                dgvTime.Rows[i].Cells[2].Value = (item.EndTime / 60).ToString() + ":" + (item.EndTime % 60).ToString();
            }
        }
        private void CheckWeekDay()
        {
            if(weekDay.Count == 0) 
                return;
            List<WeekDay> wd = weekDay.ToList();
            foreach(WeekDay d in wd)
            {
                if(d.Day == DayOfWeek.Monday)
                {
                    chbMonday.Checked = true;
                    continue;
                }
                if(d.Day == DayOfWeek.Tuesday)
                {
                    chbTuesday.Checked = true;
                    continue;
                }
                if (d.Day == DayOfWeek.Wednesday)
                {
                    chbWednesday.Checked = true;
                    continue;
                }
                if (d.Day == DayOfWeek.Thursday)
                {
                    chbThursday.Checked = true;
                    continue;
                }
                if (d.Day == DayOfWeek.Friday)
                {
                    chbFriday.Checked = true;
                    continue;
                }
                if (d.Day == DayOfWeek.Saturday)
                {
                    chbSaturday.Checked = true;
                    continue;
                }
                if (d.Day == DayOfWeek.Sunday)
                {
                    chbSunday.Checked = true;
                    continue;
                }
            }
        }
        private int GetTheMinute(DateTime d)
        {
            return d.Hour * 60 + d.Minute;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TimeApplyFactor item = new TimeApplyFactor();
            item.NumericOrder = timeApplyFactors.Count;
            item.StartTime = GetTheMinute(dtpStarTime.Value);
            item.EndTime = GetTheMinute(dtpEndTime.Value);
            timeApplyFactors.Add(item);
            SaveFile(timeApplyFactors);
            BindGrid();
        }
        public static void LoadFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Binary file|*.dat";
            string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string filePath = Path.Combine(parentDirectory, "TimeApplyFactor", "TimeApplyFactor");
            timeApplyFactors = IOHelper.Load<TimeApplyFactor>(filePath);
            filePath = Path.Combine(parentDirectory, "WeekDay", "WeekDay");
            weekDay = IOHelper.Load<WeekDay>(filePath);
        }
        private void SaveFile(List<TimeApplyFactor> T)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Binary file|*.dat";
            string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string filePath = Path.Combine(parentDirectory, "TimeApplyFactor", "TimeApplyFactor");
            IOHelper.Save(filePath, T);    
        }
        private void SaveFile(List<WeekDay> T)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Binary file|*.dat";
            string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string filePath = Path.Combine(parentDirectory, "WeekDay", "WeekDay");
            IOHelper.Save(filePath, T);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvTime.Rows.Count == 0)
                return;
            int i = dgvTime.SelectedRows.Count - 1;
            DataGridViewRow row = dgvTime.SelectedRows[i];
            TimeApplyFactor item = timeApplyFactors.FirstOrDefault(p => p.NumericOrder == int.Parse(row.Cells[0].Value.ToString()));
            timeApplyFactors.Remove(item);
            SaveFile(timeApplyFactors);
            BindGrid();
        }

        private void chbMonday_CheckedChanged(object sender, EventArgs e)
        {
            weekDay.Clear();
            if(chbMonday.Checked == true)
            {
                WeekDay w = new WeekDay();
                w.Day = DayOfWeek.Monday;
                weekDay.Add(w);
            }
            if (chbTuesday.Checked == true)
            {
                WeekDay w = new WeekDay();
                w.Day = DayOfWeek.Tuesday;
                weekDay.Add(w);
            }
            if (chbWednesday.Checked == true)
            {
                WeekDay w = new WeekDay();
                w.Day = DayOfWeek.Wednesday;
                weekDay.Add(w);
            }
            if (chbThursday.Checked == true)
            {
                WeekDay w = new WeekDay();
                w.Day = DayOfWeek.Thursday;
                weekDay.Add(w);
            }
            if (chbFriday.Checked == true)
            {
                WeekDay w = new WeekDay();
                w.Day = DayOfWeek.Friday;
                weekDay.Add(w);
            }
            if (chbSaturday.Checked == true)
            {
                WeekDay w = new WeekDay();
                w.Day = DayOfWeek.Saturday;
                weekDay.Add(w);
            }
            if (chbSunday.Checked == true)
            {
                WeekDay w = new WeekDay();
                w.Day = DayOfWeek.Sunday;
                weekDay.Add(w);
            }
            SaveFile(weekDay);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

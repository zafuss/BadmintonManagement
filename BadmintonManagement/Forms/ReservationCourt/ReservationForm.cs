﻿using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.ReservationCourt
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }
        private void ReservationForm_Load(object sender, EventArgs e)
        {
            dtpStartDay.Value = DateTime.Now;
            dtpEndDay.Value = DateTime.Now;
           ModelBadmintonManage context = new ModelBadmintonManage();
            List<RESERVATION> listRev = context.RESERVATION.ToList();
            bindGrid(listRev);
            pnlFunction.Visible = true;
        }

        private void bindGrid(List<RESERVATION> listRev)
        {
            foreach (RESERVATION item in listRev)
            {
                int i = dgvReservation.Rows.Add();
                dgvReservation.Rows[i].Cells[0].Value = item.ReservationNo;
                dgvReservation.Rows[i].Cells[1].Value = item.Username;
                if (item.PhoneNumber != null)
                {
                    dgvReservation.Rows[i].Cells[2].Value = item.PhoneNumber;
                    dgvReservation.Rows[i].Cells[3].Value = item.CUSTOMER.FullName;
                }
        
                dgvReservation.Rows[i].Cells[4].Value = item.Deposite;
                dgvReservation.Rows[i].Cells[5].Value = item.CreateDate;
                dgvReservation.Rows[i].Cells[6].Value = item.BookingDate;
            }
        }

        private void loadRevData(string revNo, string userName, string phoneNumber, string courtID, decimal deposite, DateTime createDate, DateTime bookingDate)
        {
           ModelBadmintonManage context = new ModelBadmintonManage();
            RESERVATION rev = new RESERVATION();
            rev.ReservationNo = revNo;
            rev.Username = userName;
            rev.PhoneNumber = phoneNumber;
     
            rev.Deposite = deposite;
            rev.BookingDate = bookingDate;
            rev.CreateDate = createDate;
            context.RESERVATION.Add(rev);
            context.SaveChanges();

        }

        private void dtpStartDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpEndDay_ValueChanged(object sender, EventArgs e)
        {/*
            for(int i=0;i<dgvReservation.Rows.Count;i++)
            {
                DateTime d = new DateTime();
                d = DateTime.Parse(dgvReservation.Rows[i].Cells[5].Value.ToString());
                if (DateTime.Compare(d, dtpEndDay.Value) <= 0 && DateTime.Compare(d, dtpStartDay.Value) >= 0)
                    dgvReservation.Rows[i].Visible = true;
                else
                    dgvReservation.Rows[i].Visible=false;
            }*/
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            if (pnlFunction.Visible)
                pnlFunction.Visible = false;
            else
                pnlFunction.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (pnlSearch.Visible)
                pnlSearch.Visible = false;
            else
                pnlSearch.Visible = true;
        }

        private void txtSearchByPhoneNumber_TextChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < dgvReservation.Rows.Count - 1; i++)
            {
                if (dgvReservation.Rows[i].Cells[2].Value != null)
                {
                    if (dgvReservation.Rows[i].Cells[2].Value.ToString().Contains(txtSearchByPhoneNumber.Text))
                        dgvReservation.Rows[i].Visible = true;
                    else
                        dgvReservation.Rows[i].Visible = false;
                }
                else
                {
                    if (txtSearchByPhoneNumber.TextLength > 0)
                        dgvReservation.Rows[i].Visible = false;
                    else
                        dgvReservation.Rows[i].Visible = true;
                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchByPhoneNumber_Click(object sender, EventArgs e)
        {
            txtSearchByPhoneNumber.SelectAll();
        }

        private void qLSanCauLongDataSetBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

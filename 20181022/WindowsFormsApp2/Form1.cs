﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var font = FontFamily.Families;
            foreach (FontFamily f in font)
            {
                comFont.Items.Add(f.Name);
            }
        }

            void ChangeFont()
            {
                //선택한 폰트가 없는 경우
                if (comFont.SelectedIndex < 0)
                {
                    return;
                }
                //FontStyle을 초기화
                FontStyle fs = FontStyle.Regular;

                //굵게가 체크 되었다면
                if (chkBold.Checked)
                {
                    fs |= FontStyle.Bold; // 기존 폰트에 논리합 수행
                }
                // 이탤릭체가 체크 되었다면
                if (chkItalic.Checked)
                {
                    fs |= FontStyle.Italic;
                }
                txtMessage.Font = new Font((string)comFont.SelectedItem, 10, fs);
            }

            enum Sports : int
        {
            축구, 야구, 농구, 태권도
        }
        private Sports selectedSports;

        private void comFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void rdooSoccer_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedSports = (Sports)0; // 축구
            IBISports.Text = selectedSports + "(을)를 선택했습니다.";
        }

        private void rdoBaseball_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedSports = (Sports)1; //야구
            IBISports.Text = selectedSports + "(을)를 선택했습니다.";
        }

        private void rdoBasketball_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedSports = (Sports)2; //농구
            IBISports.Text = selectedSports + "(을)를 선택했습니다.";
        }

        private void rdoTkd_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedSports = (Sports)3; //태권도
            IBISports.Text = selectedSports + "(을)를 선택했습니다.";
        }
    }
}

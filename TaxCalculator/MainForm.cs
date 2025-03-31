using System.Globalization;

namespace TaxCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void SampleLklb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(JanuaryTbx.Text))
            {
                MessageBox.Show("������һ�·ݹ���");
                return;
            }

            if (!IsWageValid(JanuaryTbx.Text))
            {
                MessageBox.Show("��������ȷ�Ĺ���");
                return;
            }

            FebruaryTbx.Text = JanuaryTbx.Text;
            FebruaryTbx.Text = JanuaryTbx.Text;
            MarchTbx.Text = JanuaryTbx.Text;
            AprilTbx.Text = JanuaryTbx.Text;
            MayTbx.Text = JanuaryTbx.Text;
            JuneTbx.Text = JanuaryTbx.Text;
            JulyTbx.Text = JanuaryTbx.Text;
            AugustTbx.Text = JanuaryTbx.Text;
            SeptemberTbx.Text = JanuaryTbx.Text;
            OctoberTbx.Text = JanuaryTbx.Text;
            NovemberTbx.Text = JanuaryTbx.Text;
            DecemberTbx.Text = JanuaryTbx.Text;
        }

        private void ClearLklb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            JanuaryTbx.Text = string.Empty;
            FebruaryTbx.Text = string.Empty;
            MarchTbx.Text = string.Empty;
            AprilTbx.Text = string.Empty;
            MayTbx.Text = string.Empty;
            JuneTbx.Text = string.Empty;
            JulyTbx.Text = string.Empty;
            AugustTbx.Text = string.Empty;
            SeptemberTbx.Text = string.Empty;
            OctoberTbx.Text = string.Empty;
            NovemberTbx.Text = string.Empty;
            DecemberTbx.Text = string.Empty;
        }

        private void BeforeSocialInsuranceLklb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(JanuaryInsuranceTbx.Text))
            {
                MessageBox.Show("������һ�·�����һ��");
                return;
            }

            if (!IsWageValid(JanuaryInsuranceTbx.Text))
            {
                MessageBox.Show("��������ȷ������һ��");
                return;
            }

            FebruaryInsuranceTbx.Text = JanuaryInsuranceTbx.Text;
            MarchInsuranceTbx.Text = JanuaryInsuranceTbx.Text;
            AprilInsuranceTbx.Text = JanuaryInsuranceTbx.Text;
            MayInsuranceTbx.Text = JanuaryInsuranceTbx.Text;
            JuneInsuranceTbx.Text = JanuaryInsuranceTbx.Text;
        }

        private void AfterSocialInsuranceLklb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(JulyInsuranceTbx.Text))
            {
                MessageBox.Show("���������·�����һ��");
                return;
            }

            if (!IsWageValid(JulyInsuranceTbx.Text))
            {
                MessageBox.Show("��������ȷ������һ��");
                return;
            }

            AugustInsuranceTbx.Text = JulyInsuranceTbx.Text;
            SeptemberInsuranceTbx.Text = JulyInsuranceTbx.Text;
            OctoberInsuranceTbx.Text = JulyInsuranceTbx.Text;
            NovemberInsuranceTbx.Text = JulyInsuranceTbx.Text;
            DecemberInsuranceTbx.Text = JulyInsuranceTbx.Text;
        }

        private void ClearSocialInsuranceLklb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            JanuaryInsuranceTbx.Text = string.Empty;
            FebruaryInsuranceTbx.Text = string.Empty;
            MarchInsuranceTbx.Text = string.Empty;
            AprilInsuranceTbx.Text = string.Empty;
            MayInsuranceTbx.Text = string.Empty;
            JuneInsuranceTbx.Text = string.Empty;
            JulyInsuranceTbx.Text = string.Empty;
            AugustInsuranceTbx.Text = string.Empty;
            SeptemberInsuranceTbx.Text = string.Empty;
            OctoberInsuranceTbx.Text = string.Empty;
            NovemberInsuranceTbx.Text = string.Empty;
            DecemberInsuranceTbx.Text = string.Empty;
        }

        private void InitializeListView()
        {
            // ����ListView����ͼģʽΪ��ϸ��Ϣģʽ
            TaxDetailLtv.View = View.Details;
            TaxDetailLtv.GridLines = true; // ��ʾ������
            TaxDetailLtv.FullRowSelect = true; // ��������λ��ѡ������
            TaxDetailLtv.MultiSelect = true; // �����ѡ

            // �����
            TaxDetailLtv.Columns.Add("�·�", 50, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("˰ǰ����", 90, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("����һ��", 90, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("�ۼƹ���", 90, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("�ۼ�����һ��", 120, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("�ۼ�ר��ӿ۳�", 160, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("�ۼƼ�������", 120, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("Ӧ��˰���ö�", 120, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("Ԥ��˰��", 90, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("����۳���", 120, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("�ۼ�Ӧ��˰��", 120, HorizontalAlignment.Center);
            //TaxDetailLtv.Columns.Add("�ۼ��ѽ���˰��", 150, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("����Ӧ��˰��", 120, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("˰����", 90, HorizontalAlignment.Center);
        }

        private void CalculatorBtn_Click(object sender, EventArgs e)
        {
            TaxDetailLtv.Items.Clear();
            // �����˰��ϸ
            AddTaxDetail(1, JanuaryTbx.Text, JanuaryInsuranceTbx.Text);
            AddTaxDetail(2, FebruaryTbx.Text, FebruaryInsuranceTbx.Text);
            AddTaxDetail(3, MarchTbx.Text, MarchInsuranceTbx.Text);
            AddTaxDetail(4, AprilTbx.Text, AprilInsuranceTbx.Text);
            AddTaxDetail(5, MayTbx.Text, MayInsuranceTbx.Text);
            AddTaxDetail(6, JuneTbx.Text, JuneInsuranceTbx.Text);
            AddTaxDetail(7, JulyTbx.Text, JulyInsuranceTbx.Text);
            AddTaxDetail(8, AugustTbx.Text, AugustInsuranceTbx.Text);
            AddTaxDetail(9, SeptemberTbx.Text, SeptemberInsuranceTbx.Text);
            AddTaxDetail(10, OctoberTbx.Text, OctoberInsuranceTbx.Text);
            AddTaxDetail(11, NovemberTbx.Text, NovemberInsuranceTbx.Text);
            AddTaxDetail(12, DecemberTbx.Text, DecemberInsuranceTbx.Text);

            // ����ͳ����Ϣ
            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            // ����ͳ����Ϣ
            decimal taxedTotal = 0;
            decimal beforeTaxTotal = 0;
            decimal afterTaxTotal = 0;
            decimal insuranceTaxTotal = 0;

            foreach (ListViewItem item in TaxDetailLtv.Items)
            {
                if (item.Tag == null || item.Tag.ToString() != "Statistics") // ����ͳ����
                {
                    taxedTotal += decimal.Parse(item.SubItems[11].Text);
                    beforeTaxTotal += decimal.Parse(item.SubItems[1].Text);
                    afterTaxTotal += decimal.Parse(item.SubItems[12].Text);
                    insuranceTaxTotal += decimal.Parse(item.SubItems[2].Text);
                }
            }

            if (IsOneComputorCbx.Checked)
            {
                decimal annualBonus = decimal.Parse(AnnualBonusTbx.Text);
                decimal avgAnnual = annualBonus / 12;
                if (avgAnnual > 80000)
                {
                    taxedTotal += annualBonus * 0.45m - 15160;
                }
                else if (avgAnnual > 55000)
                {
                    taxedTotal += annualBonus * 0.35m - 7160;
                }
                else if (avgAnnual > 35000)
                {
                    taxedTotal += annualBonus * 0.3m - 4410;
                }
                else if (avgAnnual > 25000)
                {
                    taxedTotal += annualBonus * 0.25m - 2660;
                }
                else if (avgAnnual > 12000)
                {
                    taxedTotal += annualBonus * 0.2m - 1410;
                }
                else if (avgAnnual > 3000)
                {
                    taxedTotal += annualBonus * 0.1m - 210;
                }
                else
                {
                    taxedTotal += annualBonus * 0.03m;
                }
            }

            // ���ͳ����
            var statisticsItem = new ListViewItem();
            if (IsOneComputorCbx.Checked) 
            {
                beforeTaxTotal += decimal.Parse(AnnualBonusTbx.Text);
            }
            statisticsItem.SubItems.Add("˰ǰ�����룺");
            statisticsItem.SubItems.Add(beforeTaxTotal.ToString());
            statisticsItem.SubItems.Add("˰�������룺");
            statisticsItem.SubItems.Add(afterTaxTotal.ToString());
            statisticsItem.SubItems.Add("�籣�����룺");
            statisticsItem.SubItems.Add(insuranceTaxTotal.ToString());
            statisticsItem.SubItems.Add("Ӧ��˰��");
            statisticsItem.SubItems.Add((decimal.Parse(TaxAmountTbx.Text) - taxedTotal).ToString());
            statisticsItem.Tag = "Statistics"; // ���Ϊͳ����
            TaxDetailLtv.Items.Add(statisticsItem);

            // ����ͳ���е�������ɫΪ��ɫ
            statisticsItem.ForeColor = Color.Red;
        }

        private void AddTaxDetail(int month, string salary, string insurance)
        {
            // ����һ���µ�ListViewItem����
            var item = new ListViewItem($"{month}��");
            if (!IsOneComputorCbx.Checked)
            {
                salary = Math.Round(decimal.Parse(AnnualBonusTbx.Text) / 12 + decimal.Parse(salary), 2).ToString();
            }
            item.SubItems.Add(salary);
            item.SubItems.Add(insurance);
            #region salaryTotal
            decimal salaryTotal = month switch
            {
                1 => decimal.Parse(JanuaryTbx.Text),
                2 => decimal.Parse(JanuaryTbx.Text) + decimal.Parse(FebruaryTbx.Text),
                3 => decimal.Parse(JanuaryTbx.Text) + decimal.Parse(FebruaryTbx.Text) + decimal.Parse(MarchTbx.Text),
                4 => decimal.Parse(JanuaryTbx.Text) + decimal.Parse(FebruaryTbx.Text) + decimal.Parse(MarchTbx.Text) + decimal.Parse(AprilTbx.Text),
                5 => decimal.Parse(JanuaryTbx.Text) + decimal.Parse(FebruaryTbx.Text) + decimal.Parse(MarchTbx.Text) + decimal.Parse(AprilTbx.Text) + decimal.Parse(MayTbx.Text),
                6 => decimal.Parse(JanuaryTbx.Text) + decimal.Parse(FebruaryTbx.Text) + decimal.Parse(MarchTbx.Text) + decimal.Parse(AprilTbx.Text) + decimal.Parse(MayTbx.Text) + decimal.Parse(JuneTbx.Text),
                7 => decimal.Parse(JanuaryTbx.Text) + decimal.Parse(FebruaryTbx.Text) + decimal.Parse(MarchTbx.Text) + decimal.Parse(AprilTbx.Text) + decimal.Parse(MayTbx.Text) + decimal.Parse(JuneTbx.Text) + decimal.Parse(JulyTbx.Text),
                8 => decimal.Parse(JanuaryTbx.Text) + decimal.Parse(FebruaryTbx.Text) + decimal.Parse(MarchTbx.Text) + decimal.Parse(AprilTbx.Text) + decimal.Parse(MayTbx.Text) + decimal.Parse(JuneTbx.Text) + decimal.Parse(JulyTbx.Text) + decimal.Parse(AugustTbx.Text),
                9 => decimal.Parse(JanuaryTbx.Text) + decimal.Parse(FebruaryTbx.Text) + decimal.Parse(MarchTbx.Text) + decimal.Parse(AprilTbx.Text) + decimal.Parse(MayTbx.Text) + decimal.Parse(JuneTbx.Text) + decimal.Parse(JulyTbx.Text) + decimal.Parse(AugustTbx.Text) + decimal.Parse(SeptemberTbx.Text),
               10 => decimal.Parse(JanuaryTbx.Text) + decimal.Parse(FebruaryTbx.Text) + decimal.Parse(MarchTbx.Text) + decimal.Parse(AprilTbx.Text) + decimal.Parse(MayTbx.Text) + decimal.Parse(JuneTbx.Text) + decimal.Parse(JulyTbx.Text) + decimal.Parse(AugustTbx.Text) + decimal.Parse(SeptemberTbx.Text) + decimal.Parse(OctoberTbx.Text),
               11 => decimal.Parse(JanuaryTbx.Text) + decimal.Parse(FebruaryTbx.Text) + decimal.Parse(MarchTbx.Text) + decimal.Parse(AprilTbx.Text) + decimal.Parse(MayTbx.Text) + decimal.Parse(JuneTbx.Text) + decimal.Parse(JulyTbx.Text) + decimal.Parse(AugustTbx.Text) + decimal.Parse(SeptemberTbx.Text) + decimal.Parse(OctoberTbx.Text) + decimal.Parse(NovemberTbx.Text),
               12 => decimal.Parse(JanuaryTbx.Text) + decimal.Parse(FebruaryTbx.Text) + decimal.Parse(MarchTbx.Text) + decimal.Parse(AprilTbx.Text) + decimal.Parse(MayTbx.Text) + decimal.Parse(JuneTbx.Text) + decimal.Parse(JulyTbx.Text) + decimal.Parse(AugustTbx.Text) + decimal.Parse(SeptemberTbx.Text) + decimal.Parse(OctoberTbx.Text) + decimal.Parse(NovemberTbx.Text) + decimal.Parse(DecemberTbx.Text),
                _ => throw new NotImplementedException(),
            };
            if (!IsOneComputorCbx.Checked)
            {
                salaryTotal += Math.Round(decimal.Parse(AnnualBonusTbx.Text) / 12 * month);
            }
            #endregion
            item.SubItems.Add(salaryTotal.ToString());
            #region insuranceTotal
            decimal insuranceTotal = month switch
            {
                1 => decimal.Parse(JanuaryInsuranceTbx.Text),
                2 => decimal.Parse(JanuaryInsuranceTbx.Text) + decimal.Parse(FebruaryInsuranceTbx.Text),
                3 => decimal.Parse(JanuaryInsuranceTbx.Text) + decimal.Parse(FebruaryInsuranceTbx.Text) + decimal.Parse(MarchInsuranceTbx.Text),
                4 => decimal.Parse(JanuaryInsuranceTbx.Text) + decimal.Parse(FebruaryInsuranceTbx.Text) + decimal.Parse(MarchInsuranceTbx.Text) + decimal.Parse(AprilInsuranceTbx.Text),
                5 => decimal.Parse(JanuaryInsuranceTbx.Text) + decimal.Parse(FebruaryInsuranceTbx.Text) + decimal.Parse(MarchInsuranceTbx.Text) + decimal.Parse(AprilInsuranceTbx.Text) + decimal.Parse(MayInsuranceTbx.Text),
                6 => decimal.Parse(JanuaryInsuranceTbx.Text) + decimal.Parse(FebruaryInsuranceTbx.Text) + decimal.Parse(MarchInsuranceTbx.Text) + decimal.Parse(AprilInsuranceTbx.Text) + decimal.Parse(MayInsuranceTbx.Text) + decimal.Parse(JuneInsuranceTbx.Text),
                7 => decimal.Parse(JanuaryInsuranceTbx.Text) + decimal.Parse(FebruaryInsuranceTbx.Text) + decimal.Parse(MarchInsuranceTbx.Text) + decimal.Parse(AprilInsuranceTbx.Text) + decimal.Parse(MayInsuranceTbx.Text) + decimal.Parse(JuneInsuranceTbx.Text) + decimal.Parse(JulyInsuranceTbx.Text),
                8 => decimal.Parse(JanuaryInsuranceTbx.Text) + decimal.Parse(FebruaryInsuranceTbx.Text) + decimal.Parse(MarchInsuranceTbx.Text) + decimal.Parse(AprilInsuranceTbx.Text) + decimal.Parse(MayInsuranceTbx.Text) + decimal.Parse(JuneInsuranceTbx.Text) + decimal.Parse(JulyInsuranceTbx.Text) + decimal.Parse(AugustInsuranceTbx.Text),
                9 => decimal.Parse(JanuaryInsuranceTbx.Text) + decimal.Parse(FebruaryInsuranceTbx.Text) + decimal.Parse(MarchInsuranceTbx.Text) + decimal.Parse(AprilInsuranceTbx.Text) + decimal.Parse(MayInsuranceTbx.Text) + decimal.Parse(JuneInsuranceTbx.Text) + decimal.Parse(JulyInsuranceTbx.Text) + decimal.Parse(AugustInsuranceTbx.Text) + decimal.Parse(SeptemberInsuranceTbx.Text),
                10 => decimal.Parse(JanuaryInsuranceTbx.Text) + decimal.Parse(FebruaryInsuranceTbx.Text) + decimal.Parse(MarchInsuranceTbx.Text) + decimal.Parse(AprilInsuranceTbx.Text) + decimal.Parse(MayInsuranceTbx.Text) + decimal.Parse(JuneInsuranceTbx.Text) + decimal.Parse(JulyInsuranceTbx.Text) + decimal.Parse(AugustInsuranceTbx.Text) + decimal.Parse(SeptemberInsuranceTbx.Text) + decimal.Parse(OctoberInsuranceTbx.Text),
                11 => decimal.Parse(JanuaryInsuranceTbx.Text) + decimal.Parse(FebruaryInsuranceTbx.Text) + decimal.Parse(MarchInsuranceTbx.Text) + decimal.Parse(AprilInsuranceTbx.Text) + decimal.Parse(MayInsuranceTbx.Text) + decimal.Parse(JuneInsuranceTbx.Text) + decimal.Parse(JulyInsuranceTbx.Text) + decimal.Parse(AugustInsuranceTbx.Text) + decimal.Parse(SeptemberInsuranceTbx.Text) + decimal.Parse(OctoberInsuranceTbx.Text) + decimal.Parse(NovemberInsuranceTbx.Text),
                12 => decimal.Parse(JanuaryInsuranceTbx.Text) + decimal.Parse(FebruaryInsuranceTbx.Text) + decimal.Parse(MarchInsuranceTbx.Text) + decimal.Parse(AprilInsuranceTbx.Text) + decimal.Parse(MayInsuranceTbx.Text) + decimal.Parse(JuneInsuranceTbx.Text) + decimal.Parse(JulyInsuranceTbx.Text) + decimal.Parse(AugustInsuranceTbx.Text) + decimal.Parse(SeptemberInsuranceTbx.Text) + decimal.Parse(OctoberInsuranceTbx.Text) + decimal.Parse(NovemberInsuranceTbx.Text) + decimal.Parse(DecemberInsuranceTbx.Text),
                _ => throw new NotImplementedException(),
            };
            #endregion
            item.SubItems.Add(insuranceTotal.ToString());
            decimal specialTotal = month * decimal.Parse(SpecialTbx.Text);
            item.SubItems.Add(specialTotal.ToString());
            decimal costTotal = 5000 * month;
            item.SubItems.Add(costTotal.ToString());
            decimal tax = salaryTotal - insuranceTotal - specialTotal - costTotal;
            item.SubItems.Add(tax.ToString());
            #region salaryTotal
            decimal taxRate = 0m;
            int baseCost = 0;
            if (tax > 960000)
            {
                taxRate = 0.45m;
                baseCost = 181920;
            }
            else if (tax > 660000)
            {
                taxRate = 0.35m;
                baseCost = 85920;
            }
            else if (tax > 420000)
            {
                taxRate = 0.3m;
                baseCost = 52920;
            }
            else if (tax > 300000)
            {
                taxRate = 0.25m;
                baseCost = 31920;
            }
            else if (tax > 140000)
            {
                taxRate = 0.2m;
                baseCost = 16920;
            }
            else if (tax > 36000)
            {
                taxRate = 0.1m;
                baseCost = 2520;
            }
            else
            {
                taxRate = 0.03m;
                baseCost = 0;
            }
            #endregion
            item.SubItems.Add(taxRate.ToString());
            item.SubItems.Add(baseCost.ToString());

            decimal taxTotal = Math.Round(tax * taxRate - baseCost, 2);
            item.SubItems.Add(taxTotal.ToString());

            decimal taxedTotal = 0m;
            #region taxedTotal
            if (month != 1)
            {
                ListViewItem previousItem = TaxDetailLtv.Items[month - 2];
                string previousRowValue = previousItem.SubItems[10].Text;
                taxedTotal = decimal.Parse(previousRowValue);
            }
            #endregion
            //item.SubItems.Add(taxedTotal.ToString());

            decimal monthTax = taxTotal - taxedTotal;
            item.SubItems.Add(monthTax.ToString());

            decimal netSalary = decimal.Parse(salary) > 0 && decimal.Parse(insurance) > 0 ? decimal.Parse(salary) - decimal.Parse(insurance) - monthTax : 0m;
            item.SubItems.Add(netSalary.ToString());

            // ����item��ӵ�ListView��
            TaxDetailLtv.Items.Add(item);
        }

        #region Common Methods

        /// <summary>
        /// �Ƿ���Ч����
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private bool IsWageValid(string input)
        {
            // ���Խ������ַ�������Ϊdecimal����
            if (decimal.TryParse(input, out decimal wage))
            {
                // ��ȡС������λ��
                int decimalPlaces = GetDecimalPlaces(wage);

                // ���С������λ���Ƿ񲻳�����λ
                return decimalPlaces <= 2;
            }

            // ����޷�����Ϊdecimal������false
            return false;
        }

        private int GetDecimalPlaces(decimal value)
        {
            // ��decimalֵת��Ϊ�ַ�����ȥ��ǰ����β�����
            string decimalString = value.ToString("G29", CultureInfo.InvariantCulture);

            // ����Ƿ���С����
            int decimalPointIndex = decimalString.IndexOf('.');

            // ���û��С���㣬С��λ��Ϊ0
            if (decimalPointIndex == -1)
            {
                return 0;
            }

            // ����С������λ��
            return decimalString.Length - decimalPointIndex - 1;
        }

        #endregion
    }
}

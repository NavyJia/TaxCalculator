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
                MessageBox.Show("请输入一月份工资");
                return;
            }

            if (!IsWageValid(JanuaryTbx.Text))
            {
                MessageBox.Show("请输入正确的工资");
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
                MessageBox.Show("请输入一月份五险一金");
                return;
            }

            if (!IsWageValid(JanuaryInsuranceTbx.Text))
            {
                MessageBox.Show("请输入正确的五险一金");
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
                MessageBox.Show("请输入七月份五险一金");
                return;
            }

            if (!IsWageValid(JulyInsuranceTbx.Text))
            {
                MessageBox.Show("请输入正确的五险一金");
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
            // 设置ListView的视图模式为详细信息模式
            TaxDetailLtv.View = View.Details;
            TaxDetailLtv.GridLines = true; // 显示网格线
            TaxDetailLtv.FullRowSelect = true; // 单击任意位置选中整行
            TaxDetailLtv.MultiSelect = true; // 允许多选

            // 添加列
            TaxDetailLtv.Columns.Add("月份", 50, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("税前工资", 90, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("五险一金", 90, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("累计工资", 90, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("累计五险一金", 120, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("累计专项附加扣除", 160, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("累计减除费用", 120, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("应纳税所得额", 120, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("预扣税率", 90, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("速算扣除数", 120, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("累计应纳税额", 120, HorizontalAlignment.Center);
            //TaxDetailLtv.Columns.Add("累计已缴纳税额", 150, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("当月应纳税额", 120, HorizontalAlignment.Center);
            TaxDetailLtv.Columns.Add("税后工资", 90, HorizontalAlignment.Center);
        }

        private void CalculatorBtn_Click(object sender, EventArgs e)
        {
            TaxDetailLtv.Items.Clear();
            // 添加纳税明细
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

            // 更新统计信息
            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            // 计算统计信息
            decimal taxedTotal = 0;
            decimal beforeTaxTotal = 0;
            decimal afterTaxTotal = 0;
            decimal insuranceTaxTotal = 0;

            foreach (ListViewItem item in TaxDetailLtv.Items)
            {
                if (item.Tag == null || item.Tag.ToString() != "Statistics") // 跳过统计行
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

            // 添加统计行
            var statisticsItem = new ListViewItem();
            if (IsOneComputorCbx.Checked) 
            {
                beforeTaxTotal += decimal.Parse(AnnualBonusTbx.Text);
            }
            statisticsItem.SubItems.Add("税前总收入：");
            statisticsItem.SubItems.Add(beforeTaxTotal.ToString());
            statisticsItem.SubItems.Add("税后总收入：");
            statisticsItem.SubItems.Add(afterTaxTotal.ToString());
            statisticsItem.SubItems.Add("社保总收入：");
            statisticsItem.SubItems.Add(insuranceTaxTotal.ToString());
            statisticsItem.SubItems.Add("应退税：");
            statisticsItem.SubItems.Add((decimal.Parse(TaxAmountTbx.Text) - taxedTotal).ToString());
            statisticsItem.Tag = "Statistics"; // 标记为统计行
            TaxDetailLtv.Items.Add(statisticsItem);

            // 设置统计行的字体颜色为灰色
            statisticsItem.ForeColor = Color.Red;
        }

        private void AddTaxDetail(int month, string salary, string insurance)
        {
            // 创建一个新的ListViewItem对象
            var item = new ListViewItem($"{month}月");
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

            // 将该item添加到ListView中
            TaxDetailLtv.Items.Add(item);
        }

        #region Common Methods

        /// <summary>
        /// 是否有效工资
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private bool IsWageValid(string input)
        {
            // 尝试将输入字符串解析为decimal类型
            if (decimal.TryParse(input, out decimal wage))
            {
                // 获取小数点后的位数
                int decimalPlaces = GetDecimalPlaces(wage);

                // 检查小数点后的位数是否不超过两位
                return decimalPlaces <= 2;
            }

            // 如果无法解析为decimal，返回false
            return false;
        }

        private int GetDecimalPlaces(decimal value)
        {
            // 将decimal值转换为字符串，去掉前导和尾随的零
            string decimalString = value.ToString("G29", CultureInfo.InvariantCulture);

            // 检查是否有小数点
            int decimalPointIndex = decimalString.IndexOf('.');

            // 如果没有小数点，小数位数为0
            if (decimalPointIndex == -1)
            {
                return 0;
            }

            // 计算小数点后的位数
            return decimalString.Length - decimalPointIndex - 1;
        }

        #endregion
    }
}

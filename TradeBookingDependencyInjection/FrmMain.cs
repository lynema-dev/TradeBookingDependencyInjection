using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace TradeBookingDependencyInjection
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.cboPortfolio.Items.Add("Portfolio1");
            this.cboPortfolio.Items.Add("Portfolio2");

            this.cboCurrency.Items.Add("GBP");
            this.cboCurrency.Items.Add("USD");
            this.cboCurrency.Items.Add("EUR");

            this.cboSwapType.Items.Add("InterestRateSwap");
            this.cboSwapType.Items.Add("InflationSwap");
            this.cboSwapType.Items.Add("OvernightIndexSwap");

            this.cboSwapDirection.Items.Add("Pay");
            this.cboSwapDirection.Items.Add("Rec");

            this.cboPortfolio.Select();

        }

        public static new readonly IServiceProvider Container = new ContainerBuilder().Build();

        private void btnBookTrade_Click(object sender, EventArgs e)
        {
            string returnmessage;

            try
            {
                SwapIdentifier swapid = new SwapIdentifier();

                Swap swap = new Swap();
                swap.swapidentifier = swapid.swapidentifer();
                swap.currency = this.cboCurrency.SelectedItem.ToString();
                swap.portfolio = this.cboPortfolio.SelectedItem.ToString();
                swap.swaptype = this.cboSwapType.SelectedItem.ToString();
                swap.direction = this.cboSwapDirection.SelectedItem.ToString();
                swap.notional = Convert.ToDouble(this.txtNotional.Text);
                swap.effectivedate = Convert.ToDateTime(this.txtEffective.Text);
                swap.maturitydate = Convert.ToDateTime(this.txtMaturity.Text);
                swap.fixedrate = Convert.ToDouble(this.txtFixedRate.Text);

                var tradeprocessor = Container.GetService<ITradeProcessor>();
                tradeprocessor.submitTrade(swap, out returnmessage);
                this.txtMessage.Text = Environment.NewLine + returnmessage;

                this.lblSwapID.Text = @"Swap ID :" + swap.swapidentifier;


            }
            catch (Exception ex)
            {
                this.txtMessage.Text = @"Trade Process Failure : " + ex.Message; 
            }

        }
    }
}

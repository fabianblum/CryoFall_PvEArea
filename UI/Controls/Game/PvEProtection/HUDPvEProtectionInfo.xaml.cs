namespace AtomicTorch.CBND.CoreMod.UI.Controls.Game.PvEProtection
{
    using System.Windows;
    using System.Windows.Input;
    using AtomicTorch.CBND.CoreMod.Systems.PvEProtection;
    using AtomicTorch.CBND.CoreMod.UI.Controls.Core.Menu;
    using AtomicTorch.CBND.CoreMod.UI.Controls.Game.PvEProtection.Data;
    using AtomicTorch.CBND.CoreMod.UI.Controls.Game.Social;
    using AtomicTorch.GameEngine.Common.Client.MonoGame.UI;

    public partial class HUDPvEProtectionInfo : BaseUserControl
    {
        private const double ExpandOrCollapseDelay = 0.1;

        private int expandedStateRefreshScheduledNumber;

        private FrameworkElement layoutRoot;

        private ViewModelHUDPvEProtectionInfo viewModel;

        protected override void InitControl()
        {
            this.layoutRoot = this.GetByName<FrameworkElement>("LayoutRoot");
        }

        protected override void OnLoaded()
        {
            this.UpdateLayout();

            this.viewModel = new ViewModelHUDPvEProtectionInfo();
            this.viewModel.RequiredHeight = (float)this.GetByName<FrameworkElement>("Description")
                                                       .ActualHeight;
            this.DataContext = this.viewModel;

            this.expandedStateRefreshScheduledNumber = 0;

            VisualStateManager.GoToElementState(this.layoutRoot,
                                                "Collapsed",
                                                useTransitions: false);

            this.MouseEnter += this.MouseEnterOrLeaveHandler;
            this.MouseLeave += this.MouseEnterOrLeaveHandler;
            this.MouseDown += MouseDownHandler;
        }

        protected override void OnUnloaded()
        {
            this.DataContext = null;
            this.viewModel.Dispose();
            this.viewModel = null;
        }

        private static void MouseDownHandler(object sender, MouseButtonEventArgs e)
        {

        }

        private void MouseEnterOrLeaveHandler(object sender, MouseEventArgs e)
        {

        }

        private void NewbieProtectionTimeRemainingReceivedHandler(double obj)
        {

        }

        private void RefreshState(int refreshNumber)
        {

        }

        private void RefreshTimeRemaining()
        {

        }
    }
}
namespace AtomicTorch.CBND.CoreMod.UI.Controls.Game.PvEProtection.Data
{
    using System.Windows;
    using AtomicTorch.CBND.CoreMod.Helpers.Client;
    using AtomicTorch.CBND.CoreMod.UI.Controls.Core;

    public class ViewModelHUDPvEProtectionInfo : BaseViewModel
    {
        private double timeRemaining;

        public ViewModelHUDPvEProtectionInfo()
        {
        }

        public string ProtectionTimeRemainingText { get; set; }

        public float RequiredHeight { get; set; }

        public Visibility Visibility { get; private set; }

        public void Setup(double timeRemaining)
        {
        }

        protected override void DisposeViewModel()
        {
            base.DisposeViewModel();
        }

        private void UpdateText()
        {
            if (this.IsDisposed)
            {
                return;
            }
        }

        private void UpdateTimerOnly()
        {
            this.Visibility = Visibility.Visible;
        }
    }
}
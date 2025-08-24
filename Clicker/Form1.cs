using Timer = System.Windows.Forms.Timer;

namespace Clicker
{
    public partial class Form1 : Form
    {
        private Timer FormTimer;
        private CancellationTokenSource CancellationTokenSource;

        private bool IsScriptRunning = false;
        private object RunningLocker = new object();

        public Form1()
        {
            InitializeComponent();
            SetupCursorTracking();
        }

        private void SetupCursorTracking()
        {
            FormTimer = new Timer();
            FormTimer.Interval = 10;
            FormTimer.Tick += CursorTimer_Tick;
            FormTimer.Start();
        }

        private void SetOutputTextBoxText(string text)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(SetOutputTextBoxText), text);
            }
            else
            {
                OutputTextBox.Text = text;
            }
        }

        private void CursorTimer_Tick(object sender, EventArgs e)
        {
            XValueLabel.Text = DI._inputService.GetCursorPosition().x.ToString();
            YValueLabel.Text = DI._inputService.GetCursorPosition().y.ToString();
        }

        private async Task ExecuteScriptAsync(string script, CancellationToken cancellationToken)
        {
            try
            {
                await DI._roslynExecutor.ExecuteAsync(script, DI._scriptService, cancellationToken: cancellationToken);
                SetOutputTextBoxText("Script finished");
            }
            catch (OperationCanceledException)
            {
                SetOutputTextBoxText("Script cancelled");
            }
            catch (Exception ex)
            {
                SetOutputTextBoxText(ex.Message);
            }

            lock (RunningLocker)
            {
                IsScriptRunning = false;
            }
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            var script = ScriptTextBox.Text;

            if (!string.IsNullOrWhiteSpace(script))
            {
                try
                {
                    if (IsScriptRunning) return;

                    lock (RunningLocker)
                    {
                        IsScriptRunning = true;
                    }

                    CancellationTokenSource = DI._scriptService.CreateCancellationTokenSource();
                    Task.Run(() => ExecuteScriptAsync(script, CancellationTokenSource.Token));
                    SetOutputTextBoxText("Script started");
                }
                catch (Exception ex)
                {
                    lock (RunningLocker)
                    {
                        IsScriptRunning = false;
                    }

                    SetOutputTextBoxText(ex.Message);
                }
            }
            else
            {
                SetOutputTextBoxText(string.Empty);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormTimer?.Stop();
            FormTimer?.Dispose();
            CancellationTokenSource?.Cancel();
            CancellationTokenSource?.Dispose();

            base.OnFormClosing(e);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            lock (RunningLocker)
            {
                if (IsScriptRunning && CancellationTokenSource != null && !CancellationTokenSource.IsCancellationRequested)
                {
                    SetOutputTextBoxText("Cancelling script...");
                    CancellationTokenSource.Cancel();
                }
            }
        }
    }
}

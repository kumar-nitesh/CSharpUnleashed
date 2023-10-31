using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitCSharp5
{
    public partial class AsyncAwait : Form
    {
        public AsyncAwait()
        {
            InitializeComponent();
        }

        // Method I - General Synchronous Call.
        private void button1_Click(object sender, EventArgs e)
        {
            DisableButton();
            RunTask();
            AfterTaskEnds();
        }

        private void DisableButton()
        {
            button1.Text = "Task In Progress...";
            button1.Enabled = false;
            label1.Visible = false;
        }

        private void RunTask()
        {
            Thread.Sleep(5000);
        }

        private void AfterTaskEnds()
        {
            button1.Text = "Start Task";
            label1.Visible = true;
            label1.Text = "Task Done..!!";
            button1.Enabled = true;
        }

        // Method II - Using Threads.
        private void button2_Click(object sender, EventArgs e)
        {
            DisableThreadButton();
            Thread thread = new Thread(RunThreadTask);
            thread.Start();
        }

        private void DisableThreadButton()
        {
            button2.Text = "Task In Progress...";
            button2.Enabled = false;
            label2.Visible = false;
        }

        private void RunThreadTask()
        {
            Thread.Sleep(5000);
            BeginInvoke(new Action(AfterThreadTaskEnds));
        }

        private void AfterThreadTaskEnds()
        {
            button2.Text = "Start Task";
            label2.Visible = true;
            label2.Text = "Task Done..!!";
            button2.Enabled = true;
        }

        // Method III - Async Feature of C# 5.0.
        private async void button3_Click(object sender, EventArgs e)
        {
            DisableAsyncButton();
            string result = await RunAsyncTask();
            AfterAsyncTaskEnds();
        }

        private void DisableAsyncButton()
        {
            button3.Text = "Task In Progress...";
            button3.Enabled = false;
            label5.Visible = false;
        }

        private async Task<string> RunAsyncTask()
        {
            await Task.Delay(10000);
            return "Task Complete.";
        }

        private void AfterAsyncTaskEnds()
        {
            button3.Text = "Start Task";
            label5.Visible = true;
            label5.Text = "Task Done..!!";
            button3.Enabled = true;
        }

        private void AsyncAwait_Load(object sender, EventArgs e)
        {

        }
    }
}

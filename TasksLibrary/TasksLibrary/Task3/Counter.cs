namespace TasksLibrary
{
    using System;
    using System.Threading;

    public class CounterEventArgs : EventArgs
    {
        public CounterEventArgs(string message, int time)
        {
            Message = message;
            WaitTime = time;
        }

        public string Message { get; set; }

        public int waitTime;
        public int WaitTime
        {
            get
            {
                return waitTime;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException();

                waitTime = value;
            }
        }
    }

    public class Counter
    {
        public event EventHandler<CounterEventArgs> onTimeOver;

        public void CountDown(int seconds, string message)
        {
            if (seconds < 0)
                throw new ArgumentException();

            Thread.Sleep(1000 * seconds);

            onTimeOver(this, new CounterEventArgs(message, seconds));
        }
    }
}

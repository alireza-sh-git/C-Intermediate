namespace Lessons
{
    public class Stopwatch
    {
        private DateTime start;
        private DateTime stop;
        public bool IsRunning { get; private set; }


        public void Start()
        {

            start = DateTime.Now;
            IsRunning = true;

        }
        public void Stop()
        {
            stop = DateTime.Now;
            IsRunning = false;
        }
        public TimeSpan Display()
        {
            TimeSpan timeSpan = stop - start;
            return timeSpan;
        }
    }
}
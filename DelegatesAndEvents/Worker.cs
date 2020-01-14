using System;

namespace DelegatesAndEvents
{
    public class Worker
    {
        public event EventHandler<WorkPerfornedEventArgs> WorkPerformed;
        public event EventHandler WorkComplete;

        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i < hours; i++) {
                OnWorkPerformed(i + 1, workType);
            }

            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            var del = WorkPerformed as EventHandler<WorkPerfornedEventArgs>;
            if(del != null)
            {
                del(this, new WorkPerfornedEventArgs(hours, workType));
            }
        }

        protected virtual void OnWorkCompleted()
        {
            var del = WorkComplete as EventHandler;
            if (del != null)
            {
                del(this, EventArgs.Empty);
            }
        }
    }
}

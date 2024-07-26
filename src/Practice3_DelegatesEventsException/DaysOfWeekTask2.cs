namespace Practice3_DelegatesEventsExceptions
{
    delegate string NextDay();

    internal class DaysOfWeekTask2
    {
        private string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        private int ind = 0;
        private NextDay nextDay;

        public DaysOfWeekTask2()
        {
            nextDay = delegate ()
            {
                if (ind == days.Length)
                {
                    ind = 0;
                }
                return days[ind++];
            };
        }

        public string CallDelegate() => nextDay();
    }
}

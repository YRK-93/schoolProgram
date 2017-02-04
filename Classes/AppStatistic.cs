namespace SHKOLA
{
    class StatPatameter<T>
    {
        T paramValue;

        public StatPatameter()
        {
        }

        public StatPatameter(T value)
        {
            paramValue = value;
        }

        public void Inc()
        {
            if (paramValue is int)
                paramValue = (T)(object)(((int)(object)paramValue) + 1);
            if (paramValue is float)
                paramValue = (T)(object)(((float)(object)paramValue) + 1);
            if (paramValue is double)
                paramValue = (T)(object)(((double)(object)paramValue) + 1);
        }

        public void Dec()
        {
            if (paramValue is int && (((int)(object)paramValue) > 0))
                paramValue = (T)(object)(((int)(object)paramValue) - 1);
            if (paramValue is float && (((float)(object)paramValue) > 0))
                paramValue = (T)(object)(((float)(object)paramValue) - 1);
            if (paramValue is double && (((double)(object)paramValue) > 0))
                paramValue = (T)(object)(((double)(object)paramValue) - 1);
        }

        public T ReadValue()
        {
            return paramValue;
        }
    }

    class AppStatistic
    {
        public static StatPatameter<int> atemptsToAnswerWrong;
        public static StatPatameter<int> rightAnswersCount;


        public static void ResetStatistic()
        {
            atemptsToAnswerWrong = new StatPatameter<int>(0);
            rightAnswersCount = new StatPatameter<int>(0);
        }
    }
}

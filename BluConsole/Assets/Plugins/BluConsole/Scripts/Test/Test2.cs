﻿using BluConsole.Core;


namespace BluConsole.Test
{

    public static class Test2
    {

        public static void LogLevelTwo(string message, BluLogType type = BluLogType.Normal)
        {
            TestManager.Log(message, type);
        }

        public static void LogLevelThree(string message, BluLogType type = BluLogType.Normal)
        {
            Test3.LogLevelThree(message, type);
        }

        public static void LogLevelFour(string message, BluLogType type = BluLogType.Normal)
        {
            Test3.LogLevelFour(message, type);
        }

        public static void LogLevelFive(string message, BluLogType type = BluLogType.Normal)
        {
            Test3.LogLevelFive(message, type);
        }

    }

}

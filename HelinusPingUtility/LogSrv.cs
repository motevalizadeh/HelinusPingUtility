﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelinusPingUtility
{
  internal  class LogSrv
    {
      private string logPath;
        public LogSrv(string startupPath)
        {
            logPath = startupPath + "\\Logs\\";
            DirectoryInfo di = new DirectoryInfo(logPath);
            if (!di.Exists) 
                di.Create();
        }
        public static string LogMessageCreator(string message)
        {
            message = DateTime.Now.ToString("yyyy-MM-dd   HH:mm:ss").ToUpper() + "     " + message + System.Environment.NewLine;
            return message;
        }
        public  void LogIt(string message)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(
                        logPath + "//PingUtility-" +
                        ExtraDateTime.ConvertDateTimeToDate(DateTime.UtcNow.Date) + ".txt", true))
                {
                    //sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd   HH:mm:ss.fff") + "    "+ message);
                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd   HH:mm:ss").ToUpper() + "    " + message);
                }
            }
            catch { }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerSuperIO.Log
{
    /// <summary>
    /// Console Log
    /// </summary>
    internal class ConsoleLog : ILog
    {
        private string m_Name;

        private const string m_MessageTemplate = "{0}-{1}: {2}";

        private const string m_Debug = "DEBUG";

        private const string m_Error = "ERROR";

        private const string m_Fatal = "FATAL";

        private const string m_Info = "INFO";

        private const string m_Warn = "WARN";

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleLog"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public ConsoleLog(string name)
        {
            m_Name = name;
        }

        /// <summary>
        /// Gets a value indicating whether this instance is debug enabled.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is debug enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsDebugEnabled
        {
            get { return true; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is error enabled.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is error enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsErrorEnabled
        {
            get { return true; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is fatal enabled.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is fatal enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsFatalEnabled
        {
            get { return true; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is info enabled.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is info enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsInfoEnabled
        {
            get { return true; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is warn enabled.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is warn enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsWarnEnabled
        {
            get { return true; }
        }

        public string GetDataTimeLog(string log)
        {
            return String.Format("[{0}]>>{1}", DateTime.Now.ToString("yy-MM-dd HH:mm:ss"), log);
        }

        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="message">The message.</param>
        public void Debug(bool isWriteFile, object message)
        {
            string log = GetDataTimeLog(message.ToString());
            Console.WriteLine(m_MessageTemplate, m_Name, m_Debug, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Debug, log);
            }
        }

        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Debug(bool isWriteFile, object message, Exception exception)
        {
            string log =GetDataTimeLog(message + Environment.NewLine + exception.Message + exception.StackTrace);
            Console.WriteLine(m_MessageTemplate, m_Name, m_Debug, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Debug, log);
            }
        }

        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        public void DebugFormat(bool isWriteFile, string format, object arg0)
        {
            string log = GetDataTimeLog(string.Format(format, arg0));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Debug, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Debug, log);
            }
        }

        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void DebugFormat(bool isWriteFile, string format, params object[] args)
        {
            string log = GetDataTimeLog(string.Format(format, args));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Debug, string.Format(format, args));
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Debug, log);
            }
        }

        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void DebugFormat(bool isWriteFile, IFormatProvider provider, string format, params object[] args)
        {
            string log = GetDataTimeLog(string.Format(format, args));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Debug, string.Format(provider, format, args));
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Debug, log);
            }
        }

        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        public void DebugFormat(bool isWriteFile, string format, object arg0, object arg1)
        {
            string log = GetDataTimeLog(string.Format(format, arg0, arg1));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Debug, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Debug, log);
            }
        }

        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        public void DebugFormat(bool isWriteFile, string format, object arg0, object arg1, object arg2)
        {
            string log = GetDataTimeLog(string.Format(format, arg0, arg1, arg2));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Debug, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Debug, log);
            }
        }

        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="message">The message.</param>
        public void Error(bool isWriteFile, object message)
        {
            string log = GetDataTimeLog(message.ToString());
            Console.WriteLine(m_MessageTemplate, m_Name, m_Error, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Error, log);
            }
        }

        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Error(bool isWriteFile, object message, Exception exception)
        {
            string log = GetDataTimeLog(message + Environment.NewLine + exception.Message + exception.StackTrace);
            Console.WriteLine(m_MessageTemplate, m_Name, m_Error, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Error,log);
            }
        }

        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        public void ErrorFormat(bool isWriteFile, string format, object arg0)
        {
            string log = GetDataTimeLog(string.Format(format, arg0));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Error, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Error, log);
            }
        }

        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void ErrorFormat(bool isWriteFile, string format, params object[] args)
        {
            string log = GetDataTimeLog(string.Format(format, args));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Error,log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Error, log);
            }
        }

        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void ErrorFormat(bool isWriteFile, IFormatProvider provider, string format, params object[] args)
        {
            string log = GetDataTimeLog(string.Format(provider, format, args));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Error, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Error, log);
            }
        }

        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        public void ErrorFormat(bool isWriteFile, string format, object arg0, object arg1)
        {
            string log = GetDataTimeLog(string.Format(format, arg0, arg1));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Error,log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Error, log);
            }
        }

        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        public void ErrorFormat(bool isWriteFile, string format, object arg0, object arg1, object arg2)
        {
            string log = GetDataTimeLog(string.Format(format, arg0, arg2));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Error, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Error, log);
            }
        }

        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="message">The message.</param>
        public void Fatal(bool isWriteFile, object message)
        {
            string log = GetDataTimeLog(message.ToString());
            Console.WriteLine(m_MessageTemplate, m_Name, m_Fatal, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name,m_Fatal,log);
            }
        }

        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Fatal(bool isWriteFile, object message, Exception exception)
        {
            string log = GetDataTimeLog(message + Environment.NewLine + exception.Message + exception.StackTrace);
            Console.WriteLine(m_MessageTemplate, m_Name, m_Fatal, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Fatal, log);
            }
        }

        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        public void FatalFormat(bool isWriteFile, string format, object arg0)
        {
            string log = GetDataTimeLog(string.Format(format, arg0));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Fatal, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Fatal, log);
            }
        }

        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void FatalFormat(bool isWriteFile, string format, params object[] args)
        {
            string log = GetDataTimeLog(string.Format(format, args));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Fatal,log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Fatal, log);
            }
        }

        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void FatalFormat(bool isWriteFile, IFormatProvider provider, string format, params object[] args)
        {
            string log = GetDataTimeLog(string.Format(provider, format, args));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Fatal, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Fatal, log);
            }
        }

        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        public void FatalFormat(bool isWriteFile, string format, object arg0, object arg1)
        {
            string log = GetDataTimeLog(string.Format(format, arg0, arg1));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Fatal, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Fatal, log);
            }
        }

        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        public void FatalFormat(bool isWriteFile, string format, object arg0, object arg1, object arg2)
        {
            string log = GetDataTimeLog(string.Format(format, arg0, arg1, arg2));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Fatal, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Fatal, log);
            }
        }

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="message">The message.</param>
        public void Info(bool isWriteFile,object message)
        {
            string log = GetDataTimeLog(message.ToString());
            Console.WriteLine(m_MessageTemplate, m_Name, m_Info, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name,m_Info,log);
            }
        }

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Info(bool isWriteFile, object message, Exception exception)
        {
            string log = GetDataTimeLog(message + Environment.NewLine + exception.Message + exception.StackTrace);
            Console.WriteLine(m_MessageTemplate, m_Name, m_Info, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Info, log);
            }
        }

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        public void InfoFormat(bool isWriteFile, string format, object arg0)
        {
            string log = GetDataTimeLog(string.Format(format, arg0));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Info, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Info, log);
            }
        }

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void InfoFormat(bool isWriteFile, string format, params object[] args)
        {
            string log = GetDataTimeLog(string.Format(format, args));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Info, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Info, log);
            }
        }

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void InfoFormat(bool isWriteFile, IFormatProvider provider, string format, params object[] args)
        {
            string log = GetDataTimeLog(string.Format(provider, format, args));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Info, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Info, log);
            }
        }

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        public void InfoFormat(bool isWriteFile, string format, object arg0, object arg1)
        {
            string log = GetDataTimeLog(string.Format(format, arg0, arg1));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Info, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Info, log);
            }
        }

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        public void InfoFormat(bool isWriteFile, string format, object arg0, object arg1, object arg2)
        {
            string log = GetDataTimeLog(string.Format(format, arg0, arg1, arg2));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Info,log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Info, log);
            }
        }

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="message">The message.</param>
        public void Warn(bool isWriteFile,object message)
        {
            string log = GetDataTimeLog(message.ToString());
            Console.WriteLine(m_MessageTemplate, m_Name, m_Warn, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name,m_Warn,log);
            }
        }

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Warn(bool isWriteFile, object message, Exception exception)
        {
            string log = GetDataTimeLog(message + Environment.NewLine + exception.Message + exception.StackTrace);
            Console.WriteLine(m_MessageTemplate, m_Name, m_Warn, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Warn, log);
            }
        }

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        public void WarnFormat(bool isWriteFile, string format, object arg0)
        {
            string log = GetDataTimeLog(string.Format(format, arg0));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Warn, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Warn, log);
            }
        }

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void WarnFormat(bool isWriteFile, string format, params object[] args)
        {
            string log = GetDataTimeLog(string.Format(format, args));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Warn, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Warn, log);
            }
        }

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void WarnFormat(bool isWriteFile, IFormatProvider provider, string format, params object[] args)
        {
            string log = GetDataTimeLog(string.Format(provider, format, args));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Warn, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Warn, log);
            }
        }

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        public void WarnFormat(bool isWriteFile, string format, object arg0, object arg1)
        {
            string log = GetDataTimeLog(string.Format(format, arg0, arg1));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Warn, log);
            if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Warn, log);
            }
        }

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="isWriteFile"></param>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        public void WarnFormat(bool isWriteFile, string format, object arg0, object arg1, object arg2)
        {
            string log = GetDataTimeLog(string.Format(format, arg0, arg1, arg2));
            Console.WriteLine(m_MessageTemplate, m_Name, m_Warn, log);
             if (isWriteFile)
            {
                LogUtil.WriteLogFile(m_Name, m_Warn, log);
            }
        }
    }
}

using Common.Logging.Simple;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Common.Logging.Demo
{
    internal class Program
    {
        /// <summary>
        /// net-commons/common-logging（原始项目地址）：https://github.com/net-commons/common-logging
        /// 项目文档：http://net-commons.github.io/common-logging/
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Adapter 支持的参数有：
            // level - 全局支持
            // showDateTime - 全局支持
            // showLogName - 全局支持
            // showLevel - 全局支持
            // dateTimeFormat - 全局支持
            // useColor - ConsoleOutLoggerFactoryAdapter特有
            // useTraceSource - TraceLoggerFactoryAdapter特有


            //// 设置日志适配器，通过此方式配置文件的配置将被忽略
            //LogManager.Adapter = new ConsoleOutLoggerFactoryAdapter(LogLevel.Trace, showDateTime: true, showLogName: false, showLevel: true, dateTimeFormat: "yyyy-MM-dd HH:mm.fff", useColor: true);

            var log = LogManager.GetLogger(typeof(Program));
            log.Fatal("Fatal Log");
            log.Error("Error Log");
            log.Warn("Warn Log");
            log.Info("Info Log");
            log.Debug("Debug Log");
            log.Trace("Trace Log");
            Console.ReadKey();
        }
    }
}

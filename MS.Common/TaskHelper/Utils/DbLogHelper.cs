﻿namespace MS.Common.TaskHelper
{
    using MS.Common.ConfigHelper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MS.Common.LogHelper;

    public class DbLogHelper
    {
        //public static LogBLL log = new LogBLL();

        /// <summary>
        /// 记录task 的运行日志
        /// </summary>
        /// <param name="taskName"></param>
        /// <param name="taskId"></param>
        /// <param name="result"></param>
        public static void WriteRunInfo(string taskName, string taskId, string result)
        {
            // 1. 记录文本日志
            LogHelper.CreateInstance().Info(String.Format("任务 {0} {1} {2}", taskName, taskId, result));

            //if (SysConfig.StorageMode == 1)
            //{
            //    // 2. 记录到数据库中
            //    var task = new Task(() => log.WriteRunInfo(taskName, taskId, result));
            //    task.Start();
            //}
        }

        /// <summary>
        /// 记录task 的错误日志
        /// </summary>
        /// <param name="ex"></param>
        public static void WriteErrorInfo(Exception ex)
        {
            // 1. 记录文本日志
            LogHelper.CreateInstance().Error("任务执行失败.", ex);

            //if (SysConfig.StorageMode == 1)
            //{
            //    // 2. 记录到数据库中
            //    var task = new Task(() => log.WriteErrorInfo("ERROR", ex.Message, ex.StackTrace, "Weiz.TaskManager.TaskSet"));
            //    task.Start();
            //}
        }
    }
}

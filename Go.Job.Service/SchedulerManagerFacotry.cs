﻿using Go.Job.Service.Config;
using Go.Job.Service.Logic;
using Quartz.Impl;

namespace Go.Job.Service
{

    /// <summary>
    /// 调度器启动类
    /// </summary>
    public sealed class SchedulerManagerFactory
    {
        /// <summary>
        /// 创建调度器管理者
        /// </summary>
        /// <returns></returns>^
        public static SchedulerManager CreateSchedulerManager()
        {
            SchedulerManager.Singleton.Scheduler = new StdSchedulerFactory().GetScheduler().Result;
            return SchedulerManager.Singleton;
        }
    }
}

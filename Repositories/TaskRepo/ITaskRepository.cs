﻿using System;
using System.Collections.Generic;
using System.Linq;
using xZoneAPI.Models.TaskModel;


namespace xZoneAPI.Repositories.TaskRepo
{
    public interface ITaskRepository
    {
        ICollection<AppTask> GetTasks(int userId);
        public int GetActiveDays(int userId);
        int GetFinishedTasks(int userId);
        AppTask GetTask(int TaskId);
        AppTask GetTask(string TaskName);
        //public AppTask AddTask(int UserId, TaskDto _TaskDto);
        public AppTask AddTask(AppTask task); // user add
        public bool DeleteTask(AppTask task);
        public bool UpdateTask(AppTask task);
        bool IsTaskExists(AppTask task);
        // share
        bool Save();
        public ICollection<DateTime> GetListOfActiveDays(int userId);
    }
}

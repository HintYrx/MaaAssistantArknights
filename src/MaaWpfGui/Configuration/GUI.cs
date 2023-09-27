﻿using System;
using System.ComponentModel;
using MaaWpfGui.Helper;
using MaaWpfGui.Models;

namespace MaaWpfGui.Configuration
{
    public class GUI : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DarkModeType DarkMode { get; set; } = DarkModeType.SyncWithOs;

        public bool UseNotify { get; set; } = true;

        public string Localization { get; set; } = LocalizationHelper.DefaultLanguage;

        public bool MinimizeToTray { get; set; } = false;

        public bool HideCloseButton { get; set; } = false;

        public bool UseLogItemDateFormat { get; set; } = false;

        public string LogItemDateFormat { get; set; } = "HH:mm:ss";

        public WindowPlacement? WindowPlacement { get; set; } = null;

        public bool LoadWindowPlacement { get; set; } = true;

        public bool SaveWindowPlacement { get; set; } = true;

        public bool UseAlternateStage { get; set; } = false;

        public bool HideUnavailableStage { get; set; } = true;

        public bool CustomStageCode { get; set; } = false;

        public InverseClearType InverseClearMode { get; set; } = InverseClearType.Clear;

        public string WindowTitlePrefix { get; set; } = string.Empty;

        public void OnPropertyChanged(string propertyName, object before, object after)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventDetailArgs(propertyName, before, after));
        }
    }

    /// <summary>
    /// 表示深色模式的类型。
    /// </summary>
    public enum DarkModeType
    {
        /// <summary>
        /// 明亮的主题。
        /// </summary>
        Light,

        /// <summary>
        /// 暗黑的主题。
        /// </summary>
        Dark,

        /// <summary>
        /// 与操作系统的深色模式同步。
        /// </summary>
        SyncWithOs,
    }

    public enum InverseClearType
    {
        Clear,
        Inverse,
        ClearInverse,
    }
}

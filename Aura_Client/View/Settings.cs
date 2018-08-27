using System;
using System.Collections.Generic;
using System.Configuration;

namespace Aura_Client.View
{
    //сохрание и загрузка пользовательских настроек колонок в таблицах

    internal sealed class DataGridViewSetting : ApplicationSettingsBase
    {
        private static DataGridViewSetting _defaultInstance =
            (DataGridViewSetting)Synchronized(new DataGridViewSetting());

        public static DataGridViewSetting Default
        {
            get { return _defaultInstance; }
        }

        [UserScopedSetting]
        [SettingsSerializeAs(SettingsSerializeAs.Binary)]
        [DefaultSettingValue("")]
        public Dictionary<string, List<ColumnOrderItem>> ColumnOrder
        {
            get { return this["ColumnOrder"] as Dictionary<string, List<ColumnOrderItem>>; }
            set { this["ColumnOrder"] = value; }
        }


    }

    [Serializable]
    public sealed class ColumnOrderItem
    {
        public int DisplayIndex { get; set; }
        public int Width { get; set; }
        public bool Visible { get; set; }
        public int ColumnIndex { get; set; }

    }

}

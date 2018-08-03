using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aura_Client.Controller
{
    /// <summary>
    /// Класс для создания строковых команд для БД
    /// </summary>
    class CommandStringCreator
    {
        private string tableName;               //название таблицы в БД, с которой нужно работать
        private string objectID;                //ID объекта в БД
        private Dictionary<string, string> changes;     //key - название поля, value - его новое значение

        public CommandStringCreator(string nameOfTable, string id="-1")
        {
            tableName = nameOfTable;
            changes = new Dictionary<string, string>();
            objectID = id;
        }

        public void Add(string columnName, string value)
        {
            if (changes.ContainsKey(columnName))
                changes[columnName] = value;

            else changes.Add(columnName, value);
        }

        public string ToNew()
        {
            //создать строку для добавления нового объекта в БД
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO ");
            sb.Append(tableName);
            sb.Append(" (");
            foreach (var pair in changes)
            {
                sb.Append("'");
                sb.Append(pair.Key);
                sb.Append("', ");

            }
            sb.Length--;
            sb.Length--;

            sb.Append(") VALUES (");
            foreach (var pair in changes)
            {
                sb.Append("'");
                sb.Append(pair.Value);
                sb.Append("', ");
            }
            sb.Length--;
            sb.Length--;
            sb.Append(")");

            return sb.ToString();

        }

        public string ToUpdate()
        {
            //отредактировать имеющийся объект в БД
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE ");
            sb.Append(tableName);
            sb.Append(" SET ");
            foreach (var pair in changes)
            {
                sb.Append(pair.Key);
                sb.Append(" = '");
                sb.Append(pair.Value);
                sb.Append("', ");                
            }
            sb.Length--;
            sb.Length--;

            sb.Append(" WHERE ID = ");
            sb.Append(objectID);

            return sb.ToString();

        }

    }
}

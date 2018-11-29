using System.Collections.Generic;
using System.Text;

namespace Aura_Client.Controller
{
    /// <summary>
    /// Класс для создания строковых команд для БД
    /// </summary>
    public class CommandStringCreator
    {
        private string tableName;                       //название таблицы в БД, с которой нужно работать
        private string objectID;                        //ID объекта в БД
        private Dictionary<string, string> changes;     //key - название поля, value - его новое значение
        private Dictionary<string, string> filters;     //настройка фильтрации для одного запроса
        private List<string> fields;                    //поля, которые нужны для вывода

        public CommandStringCreator(string nameOfTable, string id)
        {
            //использование для добавления / изменения значений в БД
            tableName = nameOfTable;
            changes = new Dictionary<string, string>();
            objectID = id;
        }

        public CommandStringCreator(string nameOfTable)
        {
            //использование для получения отфильтрованных данных
            tableName = nameOfTable;
            filters = new Dictionary<string, string>();

        }

        public CommandStringCreator()
        {
            //использование для получения файлов. Можно менять таблицу в процессе
            fields = new List<string>();
            filters = new Dictionary<string, string>();
        }


        public void AddChange(string columnName, string value)
        {
            if (changes.ContainsKey(columnName))
                changes[columnName] = value;

            else changes.Add(columnName, value);
        }

        public void AddFilter(string columnName, string value)
        {
            if (filters.ContainsKey(columnName))
                filters[columnName] = value;

            else filters.Add(columnName, value);

        }

        public void AddFilter(string columnName, List<string> values)
        {
            //добавить фильтрацию типа "одно значение из списка"

            StringBuilder sb = new StringBuilder();
            var header = columnName + " IN ";

            sb.Append("(");

            foreach (var str in values)
            {
                sb.Append("'");
                sb.Append(str);
                sb.Append("', ");
            }

            sb.Length -= 2;
            sb.Append(")");

            if (filters.ContainsKey(header))
                filters[header] = sb.ToString();

            else filters.Add(header, sb.ToString());
        }

        public void RemoveFilter(string columnName)
        {           
            if (filters.ContainsKey(columnName))
                filters.Remove(columnName);

           
        }

        public void AddField(string fieldName)
        {
            if (!fields.Contains(fieldName))
                fields.Add(fieldName);
        }

        public void RemoveField(string fieldName)
        {
            if (fields.Contains(fieldName))
                fields.Remove(fieldName);
        }

        public void SetTableName(string tableName)
        {
            this.tableName = tableName;
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

        public string ToFilterCommand()
        {
            //запрос на получение отфильтрованной информации
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT ");
            sb.Append(GetFields());
            sb.Append(" FROM ");
            sb.Append(tableName);

            sb.Append(GetFilters());

            return sb.ToString();

        }



        private string GetFields()
        {
            if (fields != null && fields.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var field in fields)
                {
                    sb.Append(field);
                    sb.Append(", ");
                }
                sb.Length -= 2;
                return sb.ToString();
            }

            else return "*";

        }

        private string GetFilters()
        {
            if (filters != null && filters.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(" WHERE ");
                foreach (var pair in filters)
                {
                    sb.Append(ToFilterString(pair.Key, pair.Value));
                    sb.Append(" AND ");
                }

                sb.Length -= 5;
                return sb.ToString();
            }

            else return string.Empty;
        }



       


        private string ToFilterString(string columnName, string value)
        {
            FilterTypes type;
            string nameOfField;

            if (columnName.Contains("_Equal"))
            {
                type = FilterTypes.Equally;
                nameOfField = columnName.Replace("_Equal", "");
            }

            else if (columnName.Contains("_Min"))
            {
                type = FilterTypes.Above;
                nameOfField = columnName.Replace("_Min", "");

            }

            else if (columnName.Contains("_Max"))
            {
                type = FilterTypes.Less;
                nameOfField = columnName.Replace("_Max", "");

            }

            else if (columnName.Contains(" IN "))
            {
                type = FilterTypes.InList;
                nameOfField = columnName;
            }

            else
            {
                type = FilterTypes.Contains;
                nameOfField = columnName;

            }


            FilterNode node = new FilterNode(nameOfField, type, value);
            return node.ToString();

        }

        public void ClearChanges()
        {
            changes.Clear();
        }

        public void ClearFilters()
        {
            filters.Clear();
        }

        public void ClearFields()
        {
            fields.Clear();
        }


        public bool ChangesIsNotEmpty()
        {
            //Добавлялись ли значения для изменения
            return changes.Count > 0;
        }

        public bool FiltersInNotEmpty()
        {
            //добавлялись ли поля для фильтрации
            return filters.Count > 0;
        }

    }

    internal class FilterNode
    {
        //класс, хранящий одно условие для сравнения

        private string fieldName;           //название поля, по которому нужно отфильтровать
        private string fieldValue;          //значение поля, по которому нужно отфильтровать    
        private string secondFieldValue;    //второе значение, если нужно отфильтровать "от... до..."
        private FilterTypes filterType;     //тип фильтрации

        public FilterNode(string fieldName, FilterTypes filterType, string fieldValue, string secondFieldValue = "")
        {
            this.fieldName = fieldName;
            this.fieldValue = fieldValue;
            this.secondFieldValue = secondFieldValue;
            this.filterType = filterType;

        }

        public override string ToString()
        {
            switch (filterType)
            {
                case FilterTypes.Equally:
                    return ToEquallyString();

                case FilterTypes.Less:
                    return ToLessString(fieldValue);

                case FilterTypes.Above:
                    return ToAboveString(fieldValue);

                case FilterTypes.Between:
                    return ToBetweenString();

                case FilterTypes.InList:
                    return ToInListString();

                default:
                    return ToContainsString();
            }

        }


        private string ToEquallyString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("(");
            sb.Append(fieldName);
            sb.Append(") = (");
            sb.Append("'");
            sb.Append(fieldValue);
            sb.Append("')");
            return sb.ToString();

        }

        private string ToLessString(string comparingField)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("(");
            sb.Append(fieldName);
            sb.Append(") <= (");
            sb.Append("'");
            sb.Append(comparingField);
            sb.Append("')");
            return sb.ToString();

        }

        private string ToAboveString(string comparingField)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("(");
            sb.Append(fieldName);
            sb.Append(") >= (");
            sb.Append("'");
            sb.Append(comparingField);
            sb.Append("')");
            return sb.ToString();

        }

        private string ToBetweenString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("(");
            sb.Append(ToAboveString(fieldValue));
            sb.Append(" AND ");
            sb.Append(ToLessString(secondFieldValue));
            sb.Append(")");
            return sb.ToString();

        }

        private string ToInListString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(fieldName);
            sb.Append(fieldValue);
            return sb.ToString();

        }

        private string ToContainsString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("UPPER (");
            sb.Append(fieldName);
            sb.Append(") LIKE UPPER ('%");
            sb.Append(fieldValue);
            sb.Append("%')");
            return sb.ToString();

        }

    }

    internal enum FilterTypes
    {
        Equally,        //равно
        Less,           //меньше
        Above,          //больше
        Between,        //между двух значений
        Contains,       //содержит часть текста
        InList,          //значение из списка значений

    };
}

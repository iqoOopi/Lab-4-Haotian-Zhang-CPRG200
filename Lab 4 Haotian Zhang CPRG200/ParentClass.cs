using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
    public abstract class ParentClass
    {
        public string FieldToSqlSyntax()
        {
            StringBuilder builder = new StringBuilder();
            PropertyInfo[] properties = GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                builder.Append(property.Name).Append(",");
            }
            builder.Length--;//remove the last ","
            return builder.ToString();
        }
        public abstract string KeyFieldName();
    }
}

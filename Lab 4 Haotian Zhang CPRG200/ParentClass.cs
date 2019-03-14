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
        public string FieldToSqlSet()
        {
            StringBuilder builder = new StringBuilder();
            PropertyInfo[] properties = GetType().GetProperties();
            properties = properties.Skip(4).ToArray();//skip the primary key
            foreach (PropertyInfo property in properties)
            {
                builder.Append(property.Name).Append("=@New").Append(property.Name).Append(",");
            }
            builder.Length--;//remove the last ","
            return builder.ToString();
        }
        public abstract string KeyFieldName();


        //"WHERE SampleID = @OldSampleID " + // identifies record
        //                             "AND (Description = @OldDescription " + // optimistic concurrency
        //                             "  OR Description IS NULL AND @OldDescription IS NULL) " 
        public string FieldToSqlWhere()
        {
            StringBuilder builder = new StringBuilder();
            PropertyInfo[] properties = GetType().GetProperties();


            //PropertyInfo property = properties[0];
            //builder.Append("(" + property.Name + "=@Old" + property.Name + " OR ")
            //        .Append(property.Name + " IS NULL AND @Old" + property.Name + " IS NULL)");
            foreach (PropertyInfo property in properties)
            {
                builder.Append("(" + property.Name + "=@Old" + property.Name + " OR ")
                    .Append(property.Name + " IS NULL AND @Old" + property.Name + " IS NULL)")


                    .Append(" AND ");
            }
            builder.Length = builder.Length - 5;//remove the last " AND "
            return builder.ToString();
        }
    }
}

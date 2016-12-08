using System.Linq;
using System.Reflection;

namespace germ13
{
    public abstract class WintegrateEntity : MyEntity
    {
        public abstract void parse(string row);

        public void getFields()
        {

        }

        public PropertyInfo[] getProperties()
        {
            var props = (base.GetType()).GetProperties();
            int count = props.Length;
            PropertyInfo[] pi = new PropertyInfo[count];
            count = 0;
            foreach (var p in props)
            {
                pi[count] = p;
                count++;
            }
            return pi;
        }

        public PropertyInfo[] getFieldProperty(int position)
        {
            var query = from property in base.GetType().GetProperties()
                        let orderAttribute = property.GetCustomAttributes(typeof(FieldAttribute), false).SingleOrDefault() as FieldAttribute
                        where property.GetMethod != null  && orderAttribute.Position == position// filter for public properties
                        orderby orderAttribute.Position
                        select property;
            return query.ToArray();
        }

    }
}
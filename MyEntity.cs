using System.Reflection;

namespace germ13{

public interface MyEntity{
    void parse(string row);
}

public abstract class WintegrateEntity : MyEntity {
  public abstract void parse(string row);

  public void getFields(){

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
}
}
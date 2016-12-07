using System;

namespace germ13{
  [AttributeUsage( AttributeTargets.Property |
  AttributeTargets.Method,
  AllowMultiple = true)]
  public class FieldAttribute: Attribute {
      private int position;

      public int Position {get {return position;}}

      public FieldAttribute(int position) {
          this.position = position;
      }
  }
}
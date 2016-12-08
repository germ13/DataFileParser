using System;

namespace germ13{
  [AttributeUsage( AttributeTargets.Property |
  AttributeTargets.Method,
  AllowMultiple = true)]
  public sealed class FieldAttribute: Attribute {
      // TODO : take into account non-attributed properties -- public static int count = 0;
      private readonly int position;
      public int Position {get {return position;}}

      public FieldAttribute(int position) {
          this.position = position;
      }
  }
}
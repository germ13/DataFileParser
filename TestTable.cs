using System;

namespace germ13{
  public class TheTable : WintegrateEntity
  {
      [Field(1)]
      public string Id { get; set; }
      public string JobNumber { get; set; }
      public int DeploymentNumber { get; set; }
      [Field(3)]
      public DateTime Description { get; set; }
      [Field(3)]
      public string Description2{get;set;}
      public double AmountPaid { get; set; }
      public double? AmountExpected { get; set; }
      public bool isPaid { get; set; }

      public override void parse(string rowString){

      }
  }
}
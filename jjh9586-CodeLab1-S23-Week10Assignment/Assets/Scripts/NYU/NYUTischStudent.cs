using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUTischStudent : NYUStudent
{
   public string program;

   public NYUTischStudent(string name, string netId, float gpa, int credits, string program) : base(name,netId,gpa,credits)
   {
      this.program = program;

      type = "NYU Student";
   }
   
   public override string ShowRecord()
   {
      return base.ShowRecord() + "Program: " + program;
   }
}

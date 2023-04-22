using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUFaculty : NYUStaff
{
   public int classesTaught = 4;

   public NYUFaculty(string name, string netId, float salary, int classesTaught) : base(name, netId, salary)
   {
      this.classesTaught = classesTaught;
   }

   public override string ShowRecord()
   {
      return base.ShowRecord() + "Classes Taught: " + classesTaught;
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NYUSupervisor : NYUStaff
{
    private string department;

    public NYUSupervisor(string name, string netId, float salary, string department) : base(name, netId, salary)
    {
        this.department = department;
    }
    public override string ShowRecord()
    {
        return base.ShowRecord() + "Department: " + department;
    }

}

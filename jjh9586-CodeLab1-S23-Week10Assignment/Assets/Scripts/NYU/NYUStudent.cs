using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class NYUStudent : NYUPerson
{
    public float gpa = 4.0f;
    public int credits = 0;

    public NYUStudent(string name, string netID, float gpa, int credits) : base(name, netID) 
    //this will use the base constructor from NYU Person and allows me to add more. It will pass what is in the base for name and netID
    {
        this.gpa = gpa;
        this.credits = credits;

        type = "NYU Student";
        //everything in NYUPerson can be used in NYU Student. We never made a type variable, but that exists in NYU Person
    }

    public override string ShowRecord()
    {
        return base.ShowRecord() + "GPA: " + gpa;
    }
}

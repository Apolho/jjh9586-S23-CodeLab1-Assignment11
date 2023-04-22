using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Directory : MonoBehaviour
{
    public Text text; //variable for component that displays the text

    //NOTE: notice that this is a list of NYUPerson, but can still hold all subclasses. THAT'S POLYMORPHISM, BABY!
    public List<NYUPerson> nyuPeopleList; //list of people at nyu

    int recordNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        nyuPeopleList = new List<NYUPerson>();

        //make a new NYUFaculty 
        NYUPerson mattParker = new NYUStaff("Matt Parker", "mp612", 999.12f);
        NYUPerson diane = new NYUStudent("diane wang", "rw2356", 3.7f, 16);
        NYUPerson winnie = new NYUFaculty("Winnie Song", "ws4832", 300.02f, 5);
        NYUPerson tyler = new NYUTischStudent("Tyler Coe", "tc4759", 3.8f, 12, "Game Design");
        NYUPerson jack = new NYUSupervisor("Jack Taylor", "jt475", 3000000f, "IT");
        
        nyuPeopleList.Add(mattParker); //add mattParker to the nyuPeopleList
        nyuPeopleList.Add(diane);
        nyuPeopleList.Add(winnie);
        nyuPeopleList.Add(tyler);
        nyuPeopleList.Add(jack);
        
        
        UpdateRecord(); //update the text display to show the the info from the first person in the list
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){ //if space is pressed
            UpdateRecord(); //change the record to display the next person in the list
        }
    }

    void UpdateRecord(){
        NYUPerson person = nyuPeopleList[recordNum % nyuPeopleList.Count]; //grab the object a person in the list (use % to wrap around)

        text.text = person.ShowRecord(); //display the info for this object

        recordNum++; //increase the recordNum so we show the next person next time through
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownGender : MonoBehaviour
{
    List<string> names = new List<String>() { "SelectGender", "Male", "Female", "Other" };
    public Dropdown DropGender;
    public QuestionsScript ExportQ;
    public Text GenderSelected;

    private string GenderString;
    public void DropDown_GettingValue(int index)
    {

        GenderSelected.text = names[index];

        GenderString = GenderSelected.text;
        ExportQ.SetGender(GenderString);
        if (index == 0)
        {
            GenderSelected.color = Color.red;

        }
        else
        {
            GenderSelected.color = Color.white;

        }
        //Debug.Log(index);

    }

    // Start is called before the first frame update
    void Start()
    {

        PopulateList();


    }

    void PopulateList()
    {

        DropGender.AddOptions(names);
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class DropAges : MonoBehaviour
{
    enum Ages
    {
        SelectAge,
        From_12_To_15,
        From_15_To_18,
        From_18_To_23,
        From_23_To_28,
        From_28_To_33,
        From_33_To_38,
        From_38_To_43,
        From_43_To_48,
    }
    public Dropdown DroppYears;
    public Text YearsSelected;
    public QuestionsScript ExportQ;

    private string ResponseAge;


    public void Dropdown_IndexChanged(int index)
    {
        Ages name = (Ages)index;
        YearsSelected.text = name.ToString();
        ResponseAge = YearsSelected.text;
        ExportQ.SetAge(ResponseAge);
        if (index == 0)
        {
            YearsSelected.color = Color.red;
        }
        else
        {
            YearsSelected.color = Color.white;
        }
    }
    void Start()
    {
        PopulateList();
    }
    void PopulateList()
    {
        string[] enumNames = Enum.GetNames(typeof(Ages));
        List<string> names = new List<string>(enumNames);
        DroppYears.AddOptions(names);


    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectGender : MonoBehaviour
{
    public GameObject Male;
    public GameObject Female;
    public GameObject SelectMale;
    public GameObject SelectFemale;


    public void ShowAvatar(int Actual)
    {
        if (Actual == 1)//--------------------------1=Male
        {
            Male.SetActive(true);
            Female.SetActive(false);
        }
        if(Actual==2)//---------------------2=Female
        {
            Female.SetActive(true);
            Male.SetActive(false);
           
        }
    }
}

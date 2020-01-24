using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectGender : MonoBehaviour
{
    public GameObject Male;
    public GameObject Female;
    public GameObject SelectMale;
    public GameObject SelectFemale;


    public void ShowAvatar()
    {
        if (SelectMale.activeInHierarchy==false && SelectFemale.activeInHierarchy == false)
        {
            Male.SetActive(false);
            Female.SetActive(false);
            Debug.Log("Entro al primer caso");
        }
       if(SelectMale.activeInHierarchy == true)
            {

           
                Male.SetActive(true);
                Debug.Log("Entro al segundo caso");
            Debug.Log(SelectFemale);
        }
        else
        {
     
                Female.SetActive(true);
                Debug.Log("Entro al tercer caso");
            Debug.Log(SelectFemale);
        }
    }
}

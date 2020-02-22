using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingHairAccesories : MonoBehaviour
{
    public ExportingHairs ExportH;
    public GameObject HaAccess1;
    public GameObject HaAccess2;
    public GameObject HaAccess3;
    public GameObject HaAccess4;
    public GameObject HaAccess5;




    public void PutHaAccess(int HaAccessSelected)
    {
        ExportH.SetFHAccess(HaAccessSelected);
        switch (HaAccessSelected)
        {
            case 1:
                HideHaAccess();
                HaAccess1.SetActive(true);

                break;
            case 2:
                HideHaAccess();
                HaAccess2.SetActive(true);
                break;
            case 3:
                HideHaAccess();
                HaAccess3.SetActive(true);
                break;
            case 4:
                HideHaAccess();
                HaAccess4.SetActive(true);
                break;
            case 5:
                HideHaAccess();
                HaAccess5.SetActive(true);
                break;



            default:
                break;

        }
    }
    public void HideHaAccess()
    {
        HaAccess1.SetActive(false);
        HaAccess2.SetActive(false);
        HaAccess3.SetActive(false);
        HaAccess4.SetActive(false);
        HaAccess5.SetActive(false);



    }
}

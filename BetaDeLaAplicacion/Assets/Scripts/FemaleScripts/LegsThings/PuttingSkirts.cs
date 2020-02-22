using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingSkirts : MonoBehaviour
{
    public ExportingHairs ExportH;
    public GameObject Skirt1;
    public GameObject Skirt2;
    public GameObject Skirt3;
    public GameObject Skirt4;
    public GameObject Skirt5;
    public GameObject Skirt6;
    public GameObject Skirt7;
    public void PutSkirt(int SkirtSelected)
    {
        ExportH.SetFSkirts(SkirtSelected);
        switch (SkirtSelected)
        {
            case 1:
                HideSkirt();
                Skirt1.SetActive(true);


                break;
            case 2:
                HideSkirt();
                Skirt2.SetActive(true);

                break;
            case 3:
                HideSkirt();
                Skirt3.SetActive(true);

                break;
            case 4:
                HideSkirt();
                Skirt4.SetActive(true);

                break;
            case 5:
                HideSkirt();
                Skirt5.SetActive(true);

                break;
            case 6:
                HideSkirt();
                Skirt6.SetActive(true);
                break;


            default:
                break;
        }
    }
    public void HideSkirt()
    {
        Skirt1.SetActive(false);
        Skirt2.SetActive(false);
        Skirt3.SetActive(false);
        Skirt4.SetActive(false);
        Skirt5.SetActive(false);
        Skirt6.SetActive(false);

    }
}

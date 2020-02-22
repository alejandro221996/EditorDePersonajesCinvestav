using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingFeHairs : MonoBehaviour
{
    public ExportingHairs ExportH;
    public GameObject FeHair1;
    public GameObject FeHair2;
    public GameObject FeHair3;
    public GameObject FeHair4;
    public GameObject FeHair5;
    public GameObject FeHair6;
    public GameObject FeHair7;
    public GameObject FeHair8;
    public GameObject FeHair9;
    public GameObject FeHair10;
    public GameObject FeHair11;
    public GameObject FeHair12;
    public GameObject FeHair13;


    public void PutFeHair(int FeHairSelected)
    {
        ExportH.SetFeHair(FeHairSelected);
        switch (FeHairSelected)
        {
            case 1:
                HideAll();
                FeHair1.SetActive(true);


                break;
            case 2:
                HideAll();
                FeHair2.SetActive(true);


                break;
            case 3:
                HideAll();
                FeHair3.SetActive(true);


                break;
            case 4:
                HideAll();
                FeHair4.SetActive(true);


                break;
            case 5:
                HideAll();
                FeHair5.SetActive(true);


                break;
            case 6:
                HideAll();
                FeHair6.SetActive(true);


                break;
            case 7:
                HideAll();
                FeHair7.SetActive(true);


                break;
            case 8:
                HideAll();
                FeHair8.SetActive(true);


                break;
            case 9:
                HideAll();
                FeHair9.SetActive(true);


                break;
            case 10:
                HideAll();
                FeHair10.SetActive(true);


                break;
            case 11:
                HideAll();
                FeHair11.SetActive(true);


                break;
            case 12:
                HideAll();
                FeHair12.SetActive(true);


                break;
            case 13:
                HideAll();
                FeHair13.SetActive(true);


                break;



            default:
                HideAll();
                break;


        }
    }
    public void HideAll()
    {
        FeHair1.SetActive(false);
        FeHair2.SetActive(false);
        FeHair3.SetActive(false);
        FeHair4.SetActive(false);
        FeHair5.SetActive(false);
        FeHair6.SetActive(false);
        FeHair7.SetActive(false);
        FeHair8.SetActive(false);
        FeHair9.SetActive(false);
        FeHair10.SetActive(false);
        FeHair11.SetActive(false);
        FeHair12.SetActive(false);
        FeHair13.SetActive(false);


    }
}

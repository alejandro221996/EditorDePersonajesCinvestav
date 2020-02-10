using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingFrHair : MonoBehaviour
{
    public GameObject FrHair1;
    public GameObject FrHair2;
    public GameObject FrHair3;
    public GameObject FrHair4;
    public GameObject FrHair5;
    public GameObject FrHair6;
    public GameObject FrHair7;
    public GameObject FrHair8;
    
    public GameObject FrHair10;
    public GameObject FrHair11;
    public GameObject FrHair12;
    public GameObject FrHair13;


    public void PutFrHair(int FrHairSelected)
    {
        switch (FrHairSelected)
        {
            case 1:
                HideAllFHair();
                FrHair1.SetActive(true);


                break;
            case 2:
                HideAllFHair();
                FrHair2.SetActive(true);


                break;
            case 3:
                HideAllFHair();
                FrHair3.SetActive(true);


                break;
            case 4:
                HideAllFHair();
                FrHair4.SetActive(true);


                break;
            case 5:
                HideAllFHair();
                FrHair5.SetActive(true);


                break;
            case 6:
                HideAllFHair();
                FrHair6.SetActive(true);


                break;
            case 7:
                HideAllFHair();
                FrHair7.SetActive(true);


                break;
            case 8:
                HideAllFHair();
                FrHair8.SetActive(true);


                break;
            case 9:
                HideAllFHair();
                FrHair8.SetActive(true);


                break;



            case 10:
                HideAllFHair();
                FrHair10.SetActive(true);


                break;
            case 11:
                HideAllFHair();
                FrHair11.SetActive(true);


                break;
            case 12:
                HideAllFHair();
                FrHair12.SetActive(true);


                break;
            case 13:
                HideAllFHair();
                FrHair13.SetActive(true);


                break;


               
            default:
                HideAllFHair();
                break;


        }
    }
    public void HideAllFHair()
    {
        FrHair1.SetActive(false);
        FrHair2.SetActive(false);
        FrHair3.SetActive(false);
        FrHair4.SetActive(false);
        FrHair5.SetActive(false);
        FrHair6.SetActive(false);
        FrHair7.SetActive(false);
        FrHair8.SetActive(false);
       
        FrHair10.SetActive(false);
        FrHair11.SetActive(false);
        FrHair12.SetActive(false);
        FrHair13.SetActive(false);


    }
}

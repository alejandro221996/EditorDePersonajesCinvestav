using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingFHairs : MonoBehaviour
{
    public GameObject FHair1;
    public GameObject FHair2;
    public GameObject FHair3;
    public GameObject FHair4;
    public GameObject FHair5;
    public GameObject FHair6;
    public GameObject FHair7;
    

    public void PutFhair(int FHairSelected)
    {
        switch (FHairSelected)
        {
            case 1:
                HideFHair();
                FHair1.SetActive(true);

                break;
            case 2:
                HideFHair();
                FHair2.SetActive(true);
                break;
            case 3:
                HideFHair();
                FHair3.SetActive(true);
                break;
            case 4:
                HideFHair();
                FHair4.SetActive(true);
                break;
            case 5:
                HideFHair();
                FHair5.SetActive(true);
                break;
            case 6:
                HideFHair();
                FHair6.SetActive(true);
                break;
            case 7:
                HideFHair();
                FHair7.SetActive(true);
                break;
           
            default:
                break;

        }
    }
    public void HideFHair()
    {
        FHair1.SetActive(false);
        FHair2.SetActive(false);
        FHair3.SetActive(false);
        FHair4.SetActive(false);
        FHair5.SetActive(false);
        FHair6.SetActive(false);
        FHair7.SetActive(false);
        
    }
}

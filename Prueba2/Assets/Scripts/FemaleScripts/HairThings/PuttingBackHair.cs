using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingBackHair : MonoBehaviour
{
    public GameObject BHair1;
    public GameObject BHair2;
    public GameObject BHair3;
    public GameObject BHair4;
    public GameObject BHair5;
   



    public void PutBHair(int BHairSelected)
    {
        switch (BHairSelected)
        {
            case 1:
                HideBHair();
                BHair1.SetActive(true);

                break;
            case 2:
                HideBHair();
                BHair2.SetActive(true);
                break;
            case 3:
                HideBHair();
                BHair3.SetActive(true);
                break;
            case 4:
                HideBHair();
                BHair4.SetActive(true);
                break;
            case 5:
                HideBHair();
                BHair5.SetActive(true);
                break;
          


            default:
                break;

        }
    }
    public void HideBHair()
    {
        BHair1.SetActive(false);
        BHair2.SetActive(false);
        BHair3.SetActive(false);
        BHair4.SetActive(false);
        BHair5.SetActive(false);
       


    }
}

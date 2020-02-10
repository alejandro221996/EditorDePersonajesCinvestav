using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingBAccesories : MonoBehaviour
{
    public GameObject BAccess1;
    public GameObject BAccess2;
    public GameObject BAccess3;
    public GameObject BAccess4;
    public GameObject BAccess5;
    public GameObject BAccess6;
    public GameObject BAccess7;
   public GameObject BAccess8;
    public GameObject BAccess9;
    public GameObject BAccess10;
    public GameObject BAccess11;
    public GameObject BAccess12;
    public GameObject BAccess13;
 



    public void PutBAccess(int BAccessSelected)
    {
        switch (BAccessSelected)
        {
            case 1:
                HideBAccess();
                BAccess1.SetActive(true);

                break;
            case 2:
                HideBAccess();
                BAccess2.SetActive(true);
                break;
            case 3:
                HideBAccess();
                BAccess3.SetActive(true);
                break;
            case 4:
                HideBAccess();
                BAccess4.SetActive(true);
                break;
            case 5:
                HideBAccess();
                BAccess5.SetActive(true);
                break;
            case 6:
                HideBAccess();
                BAccess6.SetActive(true);
                break;
              case 7:
                  HideBAccess();
                BAccess7.SetActive(true);
                  break;
              case 8:
                  HideBAccess();
                BAccess8.SetActive(true);
                  break;
            case 9:
                HideBAccess();
                BAccess9.SetActive(true);
                break;
            case 10:
                HideBAccess();
                BAccess10.SetActive(true);
                break;
            case 11:
                HideBAccess();
                BAccess11.SetActive(true);
                break;
            case 12:
                HideBAccess();
                BAccess12.SetActive(true);
                break;
            case 13:
                HideBAccess();
                BAccess13.SetActive(true);
                break;
       

            default:
                break;

        }
    }
    public void HideBAccess()
    {
        BAccess1.SetActive(false);
        BAccess2.SetActive(false);
        BAccess3.SetActive(false);
        BAccess4.SetActive(false);
        BAccess5.SetActive(false);
        BAccess6.SetActive(false);
        BAccess7.SetActive(false);
        BAccess8.SetActive(false);
        BAccess9.SetActive(false);
        BAccess10.SetActive(false);
        BAccess11.SetActive(false);
        BAccess12.SetActive(false);
        BAccess13.SetActive(false);
     

    }
}

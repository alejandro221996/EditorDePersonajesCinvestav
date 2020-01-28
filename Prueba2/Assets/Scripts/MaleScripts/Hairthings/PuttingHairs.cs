using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingHairs : MonoBehaviour
{
    public GameObject Hair1;
    public GameObject Hair2;
    public GameObject Hair3;
    public GameObject Hair4;
    public GameObject Hair5;
    public GameObject Hair6;
    public GameObject Hair7;
    public GameObject Hair8;
    public GameObject Hair9;
    public GameObject Hair10;
    public GameObject Hair11;
    public GameObject Hair12;
    public GameObject Hair13;
    public GameObject Hair14;
    public GameObject Hair15;

    public void PutHair(int HairSelected)
    {
        switch (HairSelected)
        {
            case 1:
                HideAll();
                Hair1.SetActive(true);


                break;
            case 2:
                HideAll();
                Hair2.SetActive(true);


                break;
            case 3:
                HideAll();
                Hair3.SetActive(true);


                break;
            case 4:
                HideAll();
                Hair4.SetActive(true);


                break;
            case 5:
                HideAll();
                Hair5.SetActive(true);


                break;
            case 6:
                HideAll();
                Hair6.SetActive(true);


                break;
            case 7:
                HideAll();
                Hair7.SetActive(true);


                break;
            case 8:
                HideAll();
                Hair8.SetActive(true);


                break;
            case 9:
                HideAll();
                Hair9.SetActive(true);


                break;
            case 10:
                HideAll();
                Hair10.SetActive(true);


                break;
            case 11:
                HideAll();
                Hair11.SetActive(true);


                break;
            case 12:
                HideAll();
                Hair12.SetActive(true);


                break;
            case 13:
                HideAll();
                Hair13.SetActive(true);


                break;
            case 14:
                HideAll();
                Hair14.SetActive(true);


                break;
            case 15:
                HideAll();
                Hair15.SetActive(true);


                break;
            default:
                HideAll();
                break;


        }
    }
    public void HideAll()
    {
        Hair1.SetActive(false);
        Hair2.SetActive(false);
        Hair3.SetActive(false);
        Hair4.SetActive(false);
        Hair5.SetActive(false);
        Hair6.SetActive(false);
        Hair7.SetActive(false);
        Hair8.SetActive(false);
        Hair9.SetActive(false);
        Hair10.SetActive(false);
        Hair11.SetActive(false);
        Hair12.SetActive(false);
        Hair13.SetActive(false);
        Hair14.SetActive(false);
        Hair15.SetActive(false);

    }
}

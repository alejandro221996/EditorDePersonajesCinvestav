using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingHairs : MonoBehaviour
{

    public ExportingHairs ExportH;
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
    private string HairSelect;
    private string valueMHaire;



    public void PutHair(int HairSelected)
    {
        ExportH.SetHair(HairSelected);
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
                // HairSelect = "3";

                break;
            case 4:
                HideAll();
                Hair4.SetActive(true);
                //HairSelect = "4";

                break;
            case 5:
                HideAll();
                Hair5.SetActive(true);
                // HairSelect = "5";

                break;
            case 6:
                HideAll();
                Hair6.SetActive(true);
                // HairSelect = "6";

                break;
            case 7:
                HideAll();
                Hair7.SetActive(true);
                // HairSelect = "7";

                break;
            case 8:
                HideAll();
                Hair8.SetActive(true);
                // HairSelect = "8";

                break;
            case 9:
                HideAll();
                Hair9.SetActive(true);
                // HairSelect = "9";

                break;
            case 10:
                HideAll();
                Hair10.SetActive(true);
                // HairSelect = "10";

                break;
            case 11:
                HideAll();
                Hair11.SetActive(true);
                // HairSelect = "11";

                break;
            case 12:
                HideAll();
                Hair12.SetActive(true);
                // HairSelect = "12";

                break;
            case 13:
                HideAll();
                Hair13.SetActive(true);
                // HairSelect = "13";

                break;
            case 14:
                HideAll();
                Hair14.SetActive(true);
                //HairSelect = "14";

                break;
            case 15:
                HideAll();
                Hair15.SetActive(true);
                //HairSelect = "15";

                break;
            default:
                HideAll();
                // HairSelect = "none";
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




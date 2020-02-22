using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingTorsos : MonoBehaviour
{
    public ExportingHairs ExportH;
    public GameObject Torso1;
    public GameObject Torso2;
    public GameObject Torso3;
    public GameObject Torso4;
    public GameObject Torso5;
    public GameObject Torso6;
    //public GameObject Torso7;
    // public GameObject Torso8;
    public GameObject Torso9;
    public GameObject Torso10;
    public GameObject Torso11;
    public GameObject Torso12;
    public GameObject Torso13;
    public GameObject Torso14;
    public GameObject Torso15;
    public GameObject Torso16;



    public void PutTorso(int TorsoSelected)
    {
        ExportH.SetTorso(TorsoSelected);
        switch (TorsoSelected)
        {
            case 1:
                HideTorso();
                Torso1.SetActive(true);

                break;
            case 2:
                HideTorso();
                Torso2.SetActive(true);
                break;
            case 3:
                HideTorso();
                Torso3.SetActive(true);
                break;
            case 4:
                HideTorso();
                Torso4.SetActive(true);
                break;
            case 5:
                HideTorso();
                Torso5.SetActive(true);
                break;
            case 6:
                HideTorso();
                Torso6.SetActive(true);
                break;
            /*  case 7:
                  HideTorso();
                  Torso7.SetActive(true);
                  break;
              case 8:
                  HideTorso();
                  Torso8.SetActive(true);
                  break;*/
            case 9:
                HideTorso();
                Torso9.SetActive(true);
                break;
            case 10:
                HideTorso();
                Torso10.SetActive(true);
                break;
            case 11:
                HideTorso();
                Torso11.SetActive(true);
                break;
            case 12:
                HideTorso();
                Torso12.SetActive(true);
                break;
            case 13:
                HideTorso();
                Torso13.SetActive(true);
                break;
            case 14:
                HideTorso();
                Torso14.SetActive(true);
                break;
            case 15:
                HideTorso();
                Torso15.SetActive(true);
                break;
            case 16:
                HideTorso();
                Torso16.SetActive(true);
                break;

            default:
                break;

        }
    }
    public void HideTorso()
    {
        Torso1.SetActive(false);
        Torso2.SetActive(false);
        Torso3.SetActive(false);
        Torso4.SetActive(false);
        Torso5.SetActive(false);
        Torso6.SetActive(false);
        // Torso7.SetActive(false);
        // Torso8.SetActive(false);
        Torso9.SetActive(false);
        Torso10.SetActive(false);
        Torso11.SetActive(false);
        Torso12.SetActive(false);
        Torso13.SetActive(false);
        Torso14.SetActive(false);
        Torso15.SetActive(false);
        Torso16.SetActive(false);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingOuters : MonoBehaviour
{
    public ExportingHairs ExportH;
    public GameObject Outer1;
    public GameObject Outer2;
    public GameObject Outer3;
    public GameObject Outer4;
    public GameObject Outer5;
    public GameObject Outer6;
    public GameObject Outer7;
    public GameObject Outer8;

    public void PutOuter(int OuterSelected)
    { ExportH.SetOuters(OuterSelected);
        switch (OuterSelected)
        {
            case 1:
                HideOuter();
                Outer1.SetActive(true);

                break;
            case 2:
                HideOuter();
                Outer2.SetActive(true);
                break;
            case 3:
                HideOuter();
                Outer3.SetActive(true);
                break;
            case 4:
                HideOuter();
                Outer4.SetActive(true);
                break;
            case 5:
                HideOuter();
                Outer5.SetActive(true);
                break;
            case 6:
                HideOuter();
                Outer6.SetActive(true);
                break;
            case 7:
                HideOuter();
                Outer7.SetActive(true);
                break;
            case 8:
                HideOuter();
                Outer8.SetActive(true);
                break;
            default:
                break;

        }
    }
    public void HideOuter()
    {
        Outer1.SetActive(false);
        Outer2.SetActive(false);
        Outer3.SetActive(false);
        Outer4.SetActive(false);
        Outer5.SetActive(false);
        Outer6.SetActive(false);
        Outer7.SetActive(false);
        Outer8.SetActive(false);
    }
}

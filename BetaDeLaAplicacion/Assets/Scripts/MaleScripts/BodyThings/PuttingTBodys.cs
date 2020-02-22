using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingTBodys : MonoBehaviour
{ public ExportingHairs ExportH;
    public GameObject TBody1;
    public GameObject TBody2;
    public GameObject TBody3;
    public GameObject TBody4;
    public GameObject TBody5;
    public GameObject TBody6;



    public void PutTBody(int TBodySelected)
    {
        ExportH.SetTBody(TBodySelected);
        switch (TBodySelected)
        {
            case 1:
                HideTBody();
                TBody1.SetActive(true);

                break;
            case 2:
                HideTBody();
                TBody2.SetActive(true);
                break;
            case 3:
                HideTBody();
                TBody3.SetActive(true);
                break;
            case 4:
                HideTBody();
                TBody4.SetActive(true);
                break;
            case 5:
                HideTBody();
                TBody5.SetActive(true);
                break;
            case 6:
                HideTBody();
                TBody6.SetActive(true);
                break;


            default:
                break;

        }
    }
    public void HideTBody()
    {
        TBody1.SetActive(false);
        TBody2.SetActive(false);
        TBody3.SetActive(false);
        TBody4.SetActive(false);
        TBody5.SetActive(false);
        TBody6.SetActive(false);


    }
}

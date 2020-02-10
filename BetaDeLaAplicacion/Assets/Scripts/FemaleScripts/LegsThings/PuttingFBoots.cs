using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingFBoots : MonoBehaviour
{

    public GameObject FBoots1;
    public GameObject FBoots2;
    public GameObject FBoots3;
    public GameObject FBoots4;
    public GameObject FBoots5;
    public GameObject FBoots6;
    public GameObject FBoots7;
    public void PutFBoots(int FBootsSelected)
    {
        switch (FBootsSelected)
        {
            case 1:
                HideFBoots();
                FBoots1.SetActive(true);


                break;
            case 2:
                HideFBoots();
                FBoots2.SetActive(true);

                break;
            case 3:
                HideFBoots();
                FBoots3.SetActive(true);

                break;
            case 4:
                HideFBoots();
                FBoots4.SetActive(true);

                break;
            case 5:
                HideFBoots();
                FBoots5.SetActive(true);

                break;
            case 6:
                HideFBoots();
                FBoots6.SetActive(true);
                break;
            case 7:
                HideFBoots();
                FBoots7.SetActive(true);

                break;
            default:
                break;
        }
    }
    public void HideFBoots()
    {
        FBoots1.SetActive(false);
        FBoots2.SetActive(false);
        FBoots3.SetActive(false);
        FBoots4.SetActive(false);
        FBoots5.SetActive(false);
        FBoots6.SetActive(false);
        FBoots7.SetActive(false);
    }
}

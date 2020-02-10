using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingGauntlets : MonoBehaviour
{
    public GameObject Gaunt1;
    public GameObject Gaunt2;
    public GameObject Gaunt3;
    public GameObject Gaunt4;
    public GameObject Gaunt5;
    public GameObject Gaunt6;
    public GameObject Gaunt7;


    public void PutGaunt(int GauntSelected)
    {
        switch (GauntSelected)
        {
            case 1:
                HideGaunt();
                Gaunt1.SetActive(true);

                break;
            case 2:
                HideGaunt();
                Gaunt2.SetActive(true);
                break;
            case 3:
                HideGaunt();
                Gaunt3.SetActive(true);
                break;
            case 4:
                HideGaunt();
                Gaunt4.SetActive(true);
                break;
            case 5:
                HideGaunt();
                Gaunt5.SetActive(true);
                break;
            case 6:
                HideGaunt();
                Gaunt6.SetActive(true);
                break;
            case 7:
                HideGaunt();
                Gaunt7.SetActive(true);
                break;

            default:
                break;

        }
    }
    public void HideGaunt()
    {
        Gaunt1.SetActive(false);
        Gaunt2.SetActive(false);
        Gaunt3.SetActive(false);
        Gaunt4.SetActive(false);
        Gaunt5.SetActive(false);
        Gaunt6.SetActive(false);
        Gaunt7.SetActive(false);

    }
}

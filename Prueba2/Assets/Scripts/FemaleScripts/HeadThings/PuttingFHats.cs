using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingFHats : MonoBehaviour
{
    public GameObject Hat1;
    public GameObject Hat2;
    public GameObject Hat3;
    public GameObject Hat4;
    public GameObject Hat5;
    public GameObject Hat6;
    public GameObject Hat7;

    public void PutHat(int HatSelected)
    {
        switch (HatSelected)
        {
            case 1:
                HideFHats();
                Hat1.SetActive(true);

                break;
            case 2:
                HideFHats();
                Hat2.SetActive(true);
                break;
            case 3:
                HideFHats();
                Hat3.SetActive(true);
                break;
            case 4:
                HideFHats();
                Hat4.SetActive(true);
                break;
            case 5:
                HideFHats();
                Hat5.SetActive(true);
                break;
            case 6:
                HideFHats();
                Hat6.SetActive(true);
                break;
            case 7:
                HideFHats();
                Hat7.SetActive(true);
                break;

            default:
                break;

        }
    }
    public void HideFHats()
    {
        Hat1.SetActive(false);
        Hat2.SetActive(false);
        Hat3.SetActive(false);
        Hat4.SetActive(false);
        Hat5.SetActive(false);
        Hat6.SetActive(false);
        Hat7.SetActive(false);
    }
}

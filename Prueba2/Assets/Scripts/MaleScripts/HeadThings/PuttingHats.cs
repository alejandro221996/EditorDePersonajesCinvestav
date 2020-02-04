using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingHats : MonoBehaviour
{
    public GameObject Hat1;
    public GameObject Hat2;
    public GameObject Hat3;
    public GameObject Hat4;

    public void PutHat(int HatSelected)
    {
        switch (HatSelected)
        {
            case 1:
                HideHats();
                Hat1.SetActive(true);

                break;
            case 2:
                HideHats();
                Hat2.SetActive(true);
                break;
            case 3:
                HideHats();
                Hat3.SetActive(true);
                break;
            case 4:
                HideHats();
                Hat4.SetActive(true);
                break;

            default:
                break;

        }
    }
    public void HideHats()
    {
        Hat1.SetActive(false);
        Hat2.SetActive(false);
        Hat3.SetActive(false);
        Hat4.SetActive(false);

    }
}

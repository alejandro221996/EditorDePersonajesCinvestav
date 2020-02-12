using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingMHats : MonoBehaviour
{
    public GameObject MHat1;
    public GameObject MHat2;
    public GameObject MHat3;
    public GameObject MHat4;

    public void PutMHat(int MHatSelected)
    {
        switch (MHatSelected)
        {
            case 1:
                HideMHats();
                MHat1.SetActive(true);

                break;
            case 2:
                HideMHats();
                MHat2.SetActive(true);
                break;
            case 3:
                HideMHats();
                MHat3.SetActive(true);
                break;
            case 4:
                HideMHats();
                MHat4.SetActive(true);
                break;

            default:
                break;

        }
    }
    public void HideMHats()
    {
        MHat1.SetActive(false);
        MHat2.SetActive(false);
        MHat3.SetActive(false);
        MHat4.SetActive(false);

    }
}

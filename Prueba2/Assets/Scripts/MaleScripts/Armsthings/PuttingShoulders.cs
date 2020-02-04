using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingShoulders : MonoBehaviour
{
    public GameObject Shoulder1;
    public GameObject Shoulder2;
    public GameObject Shoulder3;
    public GameObject Shoulder4;


    public void PutShoulder(int ShoulderSelected)
    {
        switch (ShoulderSelected)
        {
            case 1:
                HideShoulder();
                Shoulder1.SetActive(true);

                break;
            case 2:
                HideShoulder();
                Shoulder2.SetActive(true);
                break;
            case 3:
                HideShoulder();
                Shoulder3.SetActive(true);
                break;
            case 4:
                HideShoulder();
                Shoulder4.SetActive(true);
                break;


            default:
                break;

        }
    }
    public void HideShoulder()
    {
        Shoulder1.SetActive(false);
        Shoulder2.SetActive(false);
        Shoulder3.SetActive(false);
        Shoulder4.SetActive(false);

    }
}

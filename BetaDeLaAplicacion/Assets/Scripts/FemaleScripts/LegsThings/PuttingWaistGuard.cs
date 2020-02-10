using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingWaistGuard : MonoBehaviour
{
    public GameObject Waist1;
    public GameObject Waist2;
    public GameObject Waist3;
    public void PutWaist(int WaistSelected)
    {
        switch (WaistSelected)
        {
            case 1:
                HideWaist();
                Waist1.SetActive(true);


                break;
            case 2:
                HideWaist();
                Waist2.SetActive(true);

                break;
            case 3:
                HideWaist();
                Waist3.SetActive(true);

                break;
            default:
                break;
        }
    }
    public void HideWaist()
    {
        Waist1.SetActive(false);
        Waist2.SetActive(false);
        Waist3.SetActive(false);
    }
}

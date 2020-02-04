using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingWings : MonoBehaviour
{
    public GameObject Wing1;
    public GameObject Wing2;
    public GameObject Wing3;
    public GameObject Wing4;
    

    public void PutWing(int WingSelected)
    {
        switch (WingSelected)
        {
            case 1:
                HideWings();
                Wing1.SetActive(true);

                break;
            case 2:
                HideWings();
                Wing2.SetActive(true);
                break;
            case 3:
                HideWings();
                Wing3.SetActive(true);
                break;
            case 4:
                HideWings();
                Wing4.SetActive(true);
                break;
           

            default:
                break;

        }
    }
    public void HideWings()
    {
        Wing1.SetActive(false);
        Wing2.SetActive(false);
        Wing3.SetActive(false);
        Wing4.SetActive(false);

    }
}

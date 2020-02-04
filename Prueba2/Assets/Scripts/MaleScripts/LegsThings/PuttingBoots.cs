using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingBoots : MonoBehaviour
{
    public GameObject Boot1;
    public GameObject Boot2;
    public GameObject Boot3;
    public GameObject Boot4;
    public GameObject Boot5;
    public GameObject Boot6;
    


    public void PutBoot(int BootSelected)
    {
        switch (BootSelected)
        {
            case 1:
                HideBoots();
                Boot1.SetActive(true);

                break;
            case 2:
                HideBoots();
                Boot2.SetActive(true);
                break;
            case 3:
                HideBoots();
                Boot3.SetActive(true);
                break;
            case 4:
                HideBoots();
                Boot4.SetActive(true);
                break;
            case 5:
                HideBoots();
                Boot5.SetActive(true);
                break;
            case 6:
                HideBoots();
                Boot6.SetActive(true);
                break;
     

            default:
                break;

        }
    }
    public void HideBoots()
    {
        Boot1.SetActive(false);
        Boot2.SetActive(false);
        Boot3.SetActive(false);
        Boot4.SetActive(false);
        Boot5.SetActive(false);
        Boot6.SetActive(false);
       

    }
}

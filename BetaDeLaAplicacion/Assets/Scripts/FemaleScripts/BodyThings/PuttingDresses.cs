using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingDresses : MonoBehaviour
{
    public ExportingHairs ExportH;
    public GameObject Dress1;
    public GameObject Dress2;
    public GameObject Dress3;
    public GameObject Dress4;
    public GameObject Dress5;
    public GameObject Dress6;




    public void PutDress(int DressSelected)
    {
        ExportH.SetDress(DressSelected);
        switch (DressSelected)
        {
            case 1:
                HideDress();
                Dress1.SetActive(true);

                break;
            case 2:
                HideDress();
                Dress2.SetActive(true);
                break;
            case 3:
                HideDress();
                Dress3.SetActive(true);
                break;
            case 4:
                HideDress();
                Dress4.SetActive(true);
                break;
            case 5:
                HideDress();
                Dress5.SetActive(true);
                break;
            case 6:
                HideDress();
                Dress6.SetActive(true);
                break;



            default:
                break;

        }
    }
    public void HideDress()
    {
        Dress1.SetActive(false);
        Dress2.SetActive(false);
        Dress3.SetActive(false);
        Dress4.SetActive(false);
        Dress5.SetActive(false);
        Dress6.SetActive(false);



    }
}

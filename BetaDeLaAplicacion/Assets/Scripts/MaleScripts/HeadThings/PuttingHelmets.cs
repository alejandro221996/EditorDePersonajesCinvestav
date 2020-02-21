using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingHelmets : MonoBehaviour
{
    public ExportingHairs ExportH;
    public GameObject Helmet1;
    public GameObject Helmet2;
    public GameObject Helmet3;

    public void PutHelmet(int HelmetSelected)
    {
        ExportH.SetHelmet(HelmetSelected);
        switch (HelmetSelected)
        {
            case 1:
                HideHelmets();
                Helmet1.SetActive(true);

                break;
            case 2:
                HideHelmets();
                Helmet2.SetActive(true);
                break;
            case 3:
                HideHelmets();
                Helmet3.SetActive(true);
                break;

            default:
                break;

        }
    }
    public void HideHelmets()
    {
        Helmet1.SetActive(false);
        Helmet2.SetActive(false);
        Helmet3.SetActive(false);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingAccessH : MonoBehaviour
{
    public GameObject Access1;
    public GameObject Access2;
    public GameObject Access3;
    public GameObject Access4;
    public GameObject Access5;
    public GameObject Access6;

    public void PutAccess(int AccessSelected)
    {
        switch (AccessSelected)
        {
            case 1:
                HideAccess();
                Access1.SetActive(true);

                break;
            case 2:
                HideAccess();
                Access2.SetActive(true);
                break;
            case 3:
                HideAccess();
                Access3.SetActive(true);
                break;
            case 4:
                HideAccess();
                Access4.SetActive(true);
                break;
            case 5:
                HideAccess();
                Access5.SetActive(true);
                break;
            case 6:
                HideAccess();
                Access6.SetActive(true);
                break;
            default:
                break;

        }
    }
    public void HideAccess()
    {
        Access1.SetActive(false);
        Access2.SetActive(false);
        Access3.SetActive(false);
        Access4.SetActive(false);
        Access5.SetActive(false);
        Access6.SetActive(false);
    }
}

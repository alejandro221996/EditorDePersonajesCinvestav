using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingLegguards : MonoBehaviour
{ public ExportingHairs ExportH;
    public GameObject Leggs1;
    public GameObject Leggs2;
    public GameObject Leggs3;
    


    public void PutLeggs(int LeggsSelected)
    {ExportH.SetUpperArmor(LeggsSelected);
        switch (LeggsSelected)
        {
            case 1:
                HideLeggs();
                Leggs1.SetActive(true);

                break;
            case 2:
                HideLeggs();
                Leggs2.SetActive(true);
                break;
            case 3:
                HideLeggs();
                Leggs3.SetActive(true);
                break;
          


            default:
                break;

        }
    }
    public void HideLeggs()
    {
        Leggs1.SetActive(false);
        Leggs2.SetActive(false);
        Leggs3.SetActive(false);
   

    }
}

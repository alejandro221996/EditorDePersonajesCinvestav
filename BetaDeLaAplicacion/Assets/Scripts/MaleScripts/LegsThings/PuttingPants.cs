using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingPants : MonoBehaviour
{ public ExportingHairs ExportH;
    public GameObject Pants1;
    public GameObject Pants2;
    public GameObject Pants3;
    public GameObject Pants4;
    public GameObject Pants5;
  



    public void PutPants(int PantsSelected)
    {ExportH.SetPants(PantsSelected);
        switch (PantsSelected)
        {
            case 1:
                HidePants();
                Pants1.SetActive(true);

                break;
            case 2:
                HidePants();
                Pants2.SetActive(true);
                break;
            case 3:
                HidePants();
                Pants3.SetActive(true);
                break;
            case 4:
                HidePants();
                Pants4.SetActive(true);
                break;
            case 5:
                HidePants();
                Pants5.SetActive(true);
                break;
          

            default:
                break;

        }
    }
    public void HidePants()
    {
        Pants1.SetActive(false);
        Pants2.SetActive(false);
        Pants3.SetActive(false);
        Pants4.SetActive(false);
        Pants5.SetActive(false);
        


    }
}

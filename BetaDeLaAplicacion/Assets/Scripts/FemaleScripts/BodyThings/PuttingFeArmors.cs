using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingFeArmors : MonoBehaviour
{
    public ExportingHairs ExportH;
    public GameObject FeArmor1;
    public GameObject FeArmor2;
    public GameObject FeArmor3;





    public void PutFeArmor(int FeArmorSelected)
    {
        ExportH.SetFArmor(FeArmorSelected);
        switch (FeArmorSelected)
        {
            case 1:
                HideFeArmor();
                FeArmor1.SetActive(true);

                break;
            case 2:
                HideFeArmor();
                FeArmor2.SetActive(true);
                break;
            case 3:
                HideFeArmor();
                FeArmor3.SetActive(true);
                break;



            default:
                break;

        }
    }
    public void HideFeArmor()
    {
        FeArmor1.SetActive(false);
        FeArmor2.SetActive(false);
        FeArmor3.SetActive(false);




    }
}

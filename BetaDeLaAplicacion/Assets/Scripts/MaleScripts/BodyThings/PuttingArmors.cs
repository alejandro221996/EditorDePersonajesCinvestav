using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingArmors : MonoBehaviour
{ public ExportingHairs ExportH;
    public GameObject Armor1;
    public GameObject Armor2;
    public GameObject Armor3;

    public void PutArmor(int ArmorSelected)
    {ExportH.SetArmor(ArmorSelected);
        switch (ArmorSelected)
        {
            case 1:
                HideArmor();
                Armor1.SetActive(true);

                break;
            case 2:
                HideArmor();
                Armor2.SetActive(true);
                break;
            case 3:
                HideArmor();
                Armor3.SetActive(true);
                break;

            default:
                break;

        }
    }
    public void HideArmor()
    {
        Armor1.SetActive(false);
        Armor2.SetActive(false);
        Armor3.SetActive(false);

    }
}

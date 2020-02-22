using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingBelts : MonoBehaviour
{ public ExportingHairs ExportH;
    public GameObject Belt1;

    public void PutBelts(int BeltSelected)

    {ExportH.SetBelt(BeltSelected);
        switch (BeltSelected)
        {
            case 1:
                Belt1.SetActive(true);
                break;
            default:
                break;
        }
    }
    public void HideBelt()
        {
            Belt1.SetActive(false);
        }

    }


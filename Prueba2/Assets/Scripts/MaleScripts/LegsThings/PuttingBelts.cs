using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingBelts : MonoBehaviour
{
    public GameObject Belt1;

    public void PutBelts(int BeltSelected)

    {
        switch(BeltSelected)
        {
            case 1:
                Belt1.SetActive(true);
                break;
            default:
                break;
        }

    }
}

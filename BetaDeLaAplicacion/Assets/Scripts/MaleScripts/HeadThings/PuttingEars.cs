using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingEars : MonoBehaviour
{
    public GameObject Ears1;
    public GameObject Ears2;
    public GameObject Ears3;

        public void PutEars(int EarsSelected)
    {
        switch (EarsSelected)
        {
            case 1:
                HideEars();
                Ears1.SetActive(true);

                break;
            case 2:
                HideEars();
                Ears2.SetActive(true);
                break;
            case 3:
                HideEars();
                Ears3.SetActive(true);
                break;
            
            default:
                break;

        }
    }
    public void HideEars()
    {
        Ears1.SetActive(false);
        Ears2.SetActive(false);
        Ears3.SetActive(false);
       
    }
}


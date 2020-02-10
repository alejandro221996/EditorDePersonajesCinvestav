using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingFGloves : MonoBehaviour
{
    public GameObject FGlove1;
    public GameObject FGlove2;

    public void PutFGlove(int FGloveSelected)
    {
        switch (FGloveSelected)
        {
            case 1:
                HideFGlove();
                FGlove1.SetActive(true);


                break;
            case 2:
                HideFGlove();
                FGlove2.SetActive(true);

                break;
            default:
                break;
        }
    }
    public void HideFGlove()
    {
        FGlove1.SetActive(false);
        FGlove2.SetActive(false);
       
    }
}

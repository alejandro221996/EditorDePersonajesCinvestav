using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingMEyes : MonoBehaviour
{
    public ExportingHairs ExportH;
    public GameObject MEyes1;
    public GameObject MEyes2;
    public GameObject MEyes3;
    public GameObject MEyes4;
    public GameObject MEyes5;
    public GameObject MEyes6;
    public GameObject MEyes7;
    public GameObject MEyes8;

    public void PutEyes(int MEyesSelected)
    {
        ExportH.SetEyes(MEyesSelected);
        switch (MEyesSelected)
        {
            case 1:
                HideMEyes();
                MEyes1.SetActive(true);

                break;
            case 2:
                HideMEyes();
                MEyes2.SetActive(true);
                break;
            case 3:
                HideMEyes();
                MEyes3.SetActive(true);
                break;
            case 4:
                HideMEyes();
                MEyes4.SetActive(true);
                break;
            case 5:
                HideMEyes();
                MEyes5.SetActive(true);
                break;
            case 6:
                HideMEyes();
                MEyes6.SetActive(true);
                break;
            case 7:
                HideMEyes();
                MEyes7.SetActive(true);
                break;
            case 8:
                HideMEyes();
                MEyes8.SetActive(true);
                break;
            default:
                break;

        }
    }
    public void HideMEyes()
    {
        MEyes1.SetActive(false);
        MEyes2.SetActive(false);
        MEyes3.SetActive(false);
        MEyes4.SetActive(false);
        MEyes5.SetActive(false);
        MEyes6.SetActive(false);
        MEyes7.SetActive(false);
        MEyes8.SetActive(false);
    }
}

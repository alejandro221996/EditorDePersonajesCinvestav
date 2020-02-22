using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingFeShoulders : MonoBehaviour
{
    public ExportingHairs ExportH;
    public GameObject FShoulder1;
    public GameObject FShoulder12;
    public GameObject FShoulder2;
    public void PutFShoulder(int FShoulderSelected)
    {
        ExportH.SetFShoulder(FShoulderSelected);
        switch (FShoulderSelected)
        {
            case 1:
                HideFShoulder();
                FShoulder1.SetActive(true);
                FShoulder12.SetActive(true);

                break;
            case 2:
                HideFShoulder();
                FShoulder2.SetActive(true);

                break;
            default:
                break;
        }
    }
    public void HideFShoulder()
    {
        FShoulder1.SetActive(false);
        FShoulder12.SetActive(false);
        FShoulder2.SetActive(false);
    }

}

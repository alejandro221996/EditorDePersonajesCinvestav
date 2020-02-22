using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingTops : MonoBehaviour
{
    public ExportingHairs ExportH;
    public GameObject Top1;
    public GameObject Top2;
    public GameObject Top3;
    public GameObject Top4;
    public GameObject Top5;
    public GameObject Top6;




    public void PutTop(int TopSelected)
    {
        ExportH.SetTops(TopSelected);
        switch (TopSelected)
        {
            case 1:
                HideTop();
                Top1.SetActive(true);

                break;
            case 2:
                HideTop();
                Top2.SetActive(true);
                break;
            case 3:
                HideTop();
                Top3.SetActive(true);
                break;
            case 4:
                HideTop();
                Top4.SetActive(true);
                break;
            case 5:
                HideTop();
                Top5.SetActive(true);
                break;
            case 6:
                HideTop();
                Top6.SetActive(true);
                break;



            default:
                break;

        }
    }
    public void HideTop()
    {
        Top1.SetActive(false);
        Top2.SetActive(false);
        Top3.SetActive(false);
        Top4.SetActive(false);
        Top5.SetActive(false);
        Top6.SetActive(false);



    }
}

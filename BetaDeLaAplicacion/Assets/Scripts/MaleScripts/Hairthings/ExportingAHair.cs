using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExportingAHair : MonoBehaviour
{
   
    private string AHairSel;
    private string BASE_URL = "https://docs.google.com/forms/u/1/d/e/1FAIpQLScze40MaWVFPlt6TXTbaxnpKSG_sQ3Ztm3cx94Q83wznlyCTQ/formResponse";
    IEnumerator Post(string AHairS)//,string AHairS)
    {
        WWWForm form = new WWWForm();
       
         form.AddField("entry.925435299", AHairS);



        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;

    }

    public void SummitAHair(int AHS)
    {

        AHairSel = AHS.ToString();
        StartCoroutine(Post(AHairSel));


    }
}

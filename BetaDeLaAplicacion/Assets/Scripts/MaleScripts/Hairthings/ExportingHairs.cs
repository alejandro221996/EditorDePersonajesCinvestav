using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExportingHairs : MonoBehaviour
{
    
    public PuttingHairs PutMHairs;
    public PuttingAccessH PutMAHairs;
    public PuttingMEyes PutMEyes;
    public PuttingEars PutMEars;
    public PuttingFHairs PutMFHair;
    public PuttingHAccesories PutMHAccess;
    public PuttingHelmets PutMHelmet;
    public PuttingMHats PutMHats;
    public PuttingArmors PutMArmor;
    public PuttingWings PutMwings;
    public PuttingBAccess PutMBAcess;
    public PuttingWings PutMwings;
    public PuttingWings PutMwings;
    public PuttingWings PutMwings;

    private string HairSel="";
    private string AHairSel="";
    private string HatSel = "";
    private string EyesSel = "";
    private string EarsSel = "";
    private string HelmetSel = "";
    private string HeadAccesoriesSel = "";
    private string FacialHairSel = "";
    private string ArmorSel = "";
    private string TopSel = "";
    private string OuterSel = "";
    private string BodyAccesoriesSel = "";
    private string WingsSel = "";
    private string ShouldersSel = "";
    private string GauntletsSel = "";
    private string UpperArmorSel = "";
    private string BootsSel = "";
    private string BeltSel = "";
    private string PantsSel = "";



    private string BASE_URL = "https://docs.google.com/forms/u/1/d/e/1FAIpQLScze40MaWVFPlt6TXTbaxnpKSG_sQ3Ztm3cx94Q83wznlyCTQ/formResponse";
    IEnumerator Post(string HairS,string AHairS,string EyesS,string EarsS,string HatS,string HelmetS,string HeadAccesoriesS,string FacialHairS,string ArmorS,string TopS,string OuterS,string BodyAccesoriesS,string WingsS,string ShoulderS,string GauntletsS,string UpperArmorS, string BootsS,string BeltS,string PantsS)//,string AHairS)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1519217411", HairS);
        form.AddField("entry.925435299", AHairS);
        form.AddField("entry.2099287003", EyesS);
        form.AddField("entry.300966088", EarsS);
        form.AddField("entry.1981927951", HatS);
        form.AddField("entry.903770698", HelmetS);
        form.AddField("entry.1274864479", HeadAccesoriesS);
        form.AddField("entry.1645767087", FacialHairS);
        form.AddField("entry.1171968593", ArmorS);
        form.AddField("entry.1746483681", TopS);
        form.AddField("entry.2126977767", OuterS);
        form.AddField("entry.2137163254", BodyAccesoriesS);
        form.AddField("entry.849545229", WingsS);
        form.AddField("entry.2144217568", ShoulderS);
        form.AddField("entry.284550107", GauntletsS);
        form.AddField("entry.1743985084", UpperArmorS);
        form.AddField("entry.668614484", BeltS);
        form.AddField("entry.825399335", BootsS);
        form.AddField("entry.100998545", PantsS);
       



        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;

    }
   public void SetHair(int in_Hairs)
    {
        HairSel = in_Hairs.ToString();
    }
    public void SetAHair(int in_AHairs)
    {
        AHairSel = in_AHairs.ToString();
    }
    public void SetEyes(int in_Hat)
    {
        HatSel = in_Hat.ToString();
    }
    public void SetEars(int in_Hat)
    {
        HatSel = in_Hat.ToString();
    }
    public void Set(int in_Hat)
    {
        HatSel = in_Hat.ToString();
    }
    public void SetHat(int in_Hat)
    {
        HatSel = in_Hat.ToString();
    }
    public void SetHat(int in_Hat)
    {
        HatSel = in_Hat.ToString();
    }
    public void SetHat(int in_Hat)
    {
        HatSel = in_Hat.ToString();
    }
    public void SetHat(int in_Hat)
    {
        HatSel = in_Hat.ToString();
    }
    public void SetHat(int in_Hat)
    {
        HatSel = in_Hat.ToString();
    }
    public void SetHat(int in_Hat)
    {
        HatSel = in_Hat.ToString();
    }

    public void SummitData()
    {
        
        StartCoroutine(Post(HairSel,AHairSel,HatSel));


    }
    
  
   
}

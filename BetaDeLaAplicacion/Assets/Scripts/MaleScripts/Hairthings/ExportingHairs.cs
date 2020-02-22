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

    public PuttingOuters PutOuter;
     public PuttingTBodys PutTBody;
    public PuttingArmors PutMArmor;
    public PuttingWings PutMwings;
    public PuttingBAccess PutMBAcess;
    
    public PuttingGauntlets PutGauntlets;
    public PuttingShoulders PutShoulders;
   
    public PuttingBelts PutBelt;
    public PuttingBoots PutBoots;
    public PuttingPants PutPants;
    public PuttingLegguards PutLegguards;

    private string HairSel="";
    private string AHairSel="";
    private string HatSel = "";
    private string EyesSel = "";
    private string EarsSel = "";
    private string HelmetSel = "";
    private string HeadAccesoriesSel = "";
    private string FacialHairSel = "";
    private string ArmorSel = "";
    private string TBodySel = "";
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
    public void SetEyes(int in_Eyes)
    {
        EyesSel = in_Eyes.ToString();
    }
    public void SetEars(int in_Ears)
    {
        EarsSel = in_Ears.ToString();
    }
    public void SetHat(int in_Hat)
    {
        HatSel = in_Hat.ToString();
    }
    public void SetHelmet(int in_Helmet)
    {
        HelmetSel = in_Helmet.ToString();
    }
    public void SetHAccesories(int in_HAccess)
    {
       HeadAccesoriesSel = in_HAccess.ToString();
    }
    public void SetFHair(int in_FHair)
    {
       FacialHairSel = in_FHair.ToString();
    }
    public void SetArmor(int in_Armor)
    {
        ArmorSel = in_Armor.ToString();
    }
    public void SetTBody(int in_TBody)
    {
        TBodySel = in_TBody.ToString();
    }
    public void SetOuters(int in_Outers)
    {
        OuterSel = in_Outers.ToString();
    }
     public void SetBAccess(int in_BAccess)
    {
       BodyAccesoriesSel = in_BAccess.ToString();
    }
     public void SetWings(int in_Wings)
    {
        WingsSel = in_Wings.ToString();
    }
     public void SetShoulders(int in_Shoulders)
    {
        ShouldersSel  = in_Shoulders.ToString();
    }
     public void SetGauntlets(int in_Gauntlets)
    {
        GauntletsSel = in_Gauntlets.ToString();
    }
     public void SetUpperArmor(int in_UpperArmor)
    {
        UpperArmorSel = in_UpperArmor.ToString();
    }
     public void SetBelt(int in_Belt)
    {
       BeltSel = in_Belt.ToString();
    }
     public void SetBoots(int in_Boots)
    {
        BootsSel = in_Boots.ToString();
    }
     public void SetPants(int in_Pants)
    {
        PantsSel= in_Pants.ToString();
    }

    public void SummitData()
    {
        
        StartCoroutine(Post(HairSel,AHairSel,EyesSel,EarsSel,HatSel,HelmetSel,HeadAccesoriesSel,FacialHairSel,ArmorSel,TBodySel,OuterSel,BodyAccesoriesSel,WingsSel,ShouldersSel,GauntletsSel,UpperArmorSel,BeltSel,BootsSel,PantsSel));


    }
    
  
   
}

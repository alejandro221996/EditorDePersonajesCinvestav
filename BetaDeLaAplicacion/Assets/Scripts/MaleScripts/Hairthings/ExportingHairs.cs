using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExportingHairs : MonoBehaviour
{
    //MALE SCRIPTS----------------------------------
    public SelectGender PutGender;
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
    //---------------------------------------------

    //FEMALE SCRIPTS
    public PuttingFeHairs PutFeHair;
    public PuttingFrHair PutFrHair;
    public PuttingBackHair PutBackHair;

    public PuttingFEyes PutFEyes;
    public PuttingFEars PutFEars;
    public PuttingFHats PutFHats;
    public PuttingHairAccesories PutFHAccess;
    public PuttingHeadAccesories PutFHeAccess;


    public PuttingBAccesories PutFBAccess;
    public PuttingDresses PutDress;
    public PuttingFeArmors PutFArmor;
    public PuttingTops PutFTop;
    public PuttingTorsos PutTorsos;

    public PuttingFeShoulders PutFShoulders;
    public PuttingFGauntlets PutFGauntlets;
    public PuttingFGloves PutFGloves;

    public PuttingFBoots PutFBoots;
    public PuttingFPants PutFPants;
    public PuttingSkirts PutSkirts;
    public PuttingWaistGuard PutWaistGuard;
    //------
    //MALE VARIABLES
    private string GenderSel = "0";
    private string HairSel = "0";
    private string AHairSel = "0";
    private string HatSel = "0";
    private string EyesSel = "0";
    private string EarsSel = "0";
    private string HelmetSel = "0";
    private string HeadAccesoriesSel = "0";
    private string FacialHairSel = "0";
    private string ArmorSel = "0";
    private string TBodySel = "0";
    private string OuterSel = "0";
    private string BodyAccesoriesSel = "0";
    private string WingsSel = "0";
    private string ShouldersSel = "0";
    private string GauntletsSel = "0";
    private string UpperArmorSel = "0";
    private string BootsSel = "0";

    private string BeltSel = "0";
    private string PantsSel = "0";
    //-------------
    //FEMALE VARIABLES
    private string FeHairSel = "0";
    private string FrHairSel = "0";
    private string BackHairSel = "0";
    private string FEyesSel = "0";
    private string FEarsSel = "0";
    private string FHatSel = "0";
    private string FHAccessSel = "0";

    private string FHeAccessSel = "0";
    private string FBAccessSel = "0";
    private string DressSel = "0";
    private string FeArmorSel = "0";
    private string TopsSel = "0";
    private string TorsosSel = "0";
    private string FGauntletsSel = "0";
    private string FeShoulderSel = "0";
    private string FGlovesSel = "0";

    private string FBootsSel = "0";
    private string FPantsSel = "0";
    private string SkirtsSel = "0";
    private string WaistGuardSel = "0";
    //------------

    private string BASE_URL = "https://docs.google.com/forms/u/1/d/e/1FAIpQLScze40MaWVFPlt6TXTbaxnpKSG_sQ3Ztm3cx94Q83wznlyCTQ/formResponse";
    IEnumerator Post(string GenderS, string HairS, string AHairS, string EyesS, string EarsS, string HatS, string HelmetS, string HeadAccesoriesS, string FacialHairS, string ArmorS, string TopS, string OuterS, string BodyAccesoriesS, string WingsS, string ShoulderS, string GauntletsS, string UpperArmorS, string BootsS, string BeltS, string PantsS, string FeHairS, string FrHairS, string BackHairS, string FEarsS, string FEyesS, string FHatS, string FHAccessS, string FHeAS, string BAcessS, string DressS, string FeArmorS, string TopsS, string TorsosS, string FeShoulderS, string FGauntletS, string FGloveS, string FBootsS, string FPantsS, string FSkirtsS, string WaistGuardS) //,string AHairS)
    {
        WWWForm form = new WWWForm();
        //Campos de MALE
        form.AddField("entry.438211163", GenderS);
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
        //-------------------------
        //Campos de FEMALE
        form.AddField("entry.2038579242", FeHairS);
        form.AddField("entry.270731041", FrHairS);
        form.AddField("entry.32451550", BackHairS);
        form.AddField("entry.1139273813", FEyesS);
        form.AddField("entry.990494844", FEarsS);
        form.AddField("entry.169325710", FHatS);
        form.AddField("entry.1512699396", FHAccessS);
        form.AddField("entry.1538173283", FHeAS);
        form.AddField("entry.591139263", BAcessS);
        form.AddField("entry.1371308811", DressS);
        form.AddField("entry.1904753937", FeArmorS);
        form.AddField("entry.645738334", TopsS);
        form.AddField("entry.1226501494", TorsosS);
        form.AddField("entry.1346709377", FeShoulderS);
        form.AddField("entry.1465952585", FGauntletS);
        form.AddField("entry.1380912133", FGloveS);
        form.AddField("entry.58857366", FBootsS);
        form.AddField("entry.1059744120", FPantsS);
        form.AddField("entry.1939741948", FSkirtsS);
        form.AddField("entry.371006338", WaistGuardS);
        //-------------------------



        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;

    }
    //--------Funciones Male
    public void SetGender(int in_Gender)
    {
        GenderSel = in_Gender.ToString();
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
        ShouldersSel = in_Shoulders.ToString();
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
        PantsSel = in_Pants.ToString();
    }
    //------------
    //------------Funciones Female
    public void SetFeHair(int in_FeHair)
    {
        FeHairSel = in_FeHair.ToString();
    }
    public void SetFrHair(int in_FrHair)
    {
        FrHairSel = in_FrHair.ToString();
    }
    public void SetBackHair(int in_BackHair)
    {
        BackHairSel = in_BackHair.ToString();
    }
    public void SetFEyes(int in_FEyes)
    {
        FEyesSel = in_FEyes.ToString();
    }
    public void SetFEars(int in_FEars)
    {
        FEarsSel = in_FEars.ToString();
    }
    public void SetFHat(int in_FHat)
    {
        FHatSel = in_FHat.ToString();
    }
    public void SetFHAccess(int in_FHAccess)
    {
        FHAccessSel = in_FHAccess.ToString();
    }
    public void SetFHeAccess(int in_FHeAccess)
    {

        FHeAccessSel = in_FHeAccess.ToString();
    }
    public void SetFBAccess(int in_FBAccess)
    {
        FBAccessSel = in_FBAccess.ToString();
    }
    public void SetDress(int in_Dress)
    {
        DressSel = in_Dress.ToString();
    }
    public void SetFArmor(int in_FArmor)
    {
        FeArmorSel = in_FArmor.ToString();
    }
    public void SetTops(int in_Tops)
    {
        TopsSel = in_Tops.ToString();
    }
    public void SetTorso(int in_Torso)
    {
        TorsosSel = in_Torso.ToString();
    }
    public void SetFShoulder(int in_FShoulder)
    {
        FeShoulderSel = in_FShoulder.ToString();
    }
    public void SetFGauntlet(int in_FGauntlet)
    {
        FGauntletsSel = in_FGauntlet.ToString();
    }
    public void SetFGloves(int in_FGloves)
    {
        FGlovesSel = in_FGloves.ToString();
    }
    public void SetFBoots(int in_FBoots)
    {
        FBootsSel = in_FBoots.ToString();
    }
    public void SetFPants(int in_FPants)
    {
        FPantsSel = in_FPants.ToString();
    }
    public void SetFSkirts(int in_FSkirts)
    {
        SkirtsSel = in_FSkirts.ToString();
    }
    public void SetWaistGuard(int in_WaistGuard)
    {
        WaistGuardSel = in_WaistGuard.ToString();
    }

    //------------

    public void SummitData()
    {

        StartCoroutine(Post(GenderSel, HairSel, AHairSel, EyesSel, EarsSel, HatSel, HelmetSel, HeadAccesoriesSel, FacialHairSel, ArmorSel, TBodySel, OuterSel, BodyAccesoriesSel, WingsSel, ShouldersSel, GauntletsSel, UpperArmorSel, BeltSel, BootsSel, PantsSel, FeHairSel, FrHairSel, BackHairSel, FEyesSel, FEarsSel, FHatSel, FHAccessSel, FHeAccessSel, BodyAccesoriesSel, DressSel, FeArmorSel, TopsSel, TorsosSel, FeShoulderSel, FGauntletsSel, FGlovesSel, FBootsSel, FPantsSel, SkirtsSel, WaistGuardSel));

    }

}
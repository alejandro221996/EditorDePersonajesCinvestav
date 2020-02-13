using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectGender : MonoBehaviour
{
    public GameObject Male;
    public GameObject Female;
    public GameObject SelectMale;
    public GameObject SelectFemale;
    public GameObject MaleHairButton;
    public GameObject MaleHeadButton;
    public GameObject MaleBodyButton;
    public GameObject MaleLegsButton;
    public GameObject MaleArmsButton;
    public GameObject FemaHairButton;
    public GameObject FemaHeadButton;
    public GameObject FemaBodyButton;
    public GameObject FemaLegsButton;
    public GameObject FemaArmsButton;

   


    public void ShowAvatar(int Actual)
    {
        switch (Actual)
        {
            case 1:
               
                HideFemaControls();
                Male.SetActive(true);
                Female.SetActive(false);
                MaleHairButton.SetActive(true);
                MaleHeadButton.SetActive(true);
                MaleLegsButton.SetActive(true);
                MaleArmsButton.SetActive(true);
                MaleBodyButton.SetActive(true);

                break;
            case 2:
                Female.SetActive(true);
                Male.SetActive(false);
                HideMaleControls();
                
                FemaHairButton.SetActive(true);
                FemaHeadButton.SetActive(true);
                FemaLegsButton.SetActive(true);
                FemaArmsButton.SetActive(true);
                FemaBodyButton.SetActive(true);

                break;
            default:

                break;


        }
    }
    public void HideMaleControls()
    {
        MaleHairButton.SetActive(false);
        MaleHeadButton.SetActive(false);
        MaleLegsButton.SetActive(false);
        MaleArmsButton.SetActive(false);
        MaleBodyButton.SetActive(false);
    }
    public void HideFemaControls()
    {
        FemaHairButton.SetActive(false);
        FemaHeadButton.SetActive(false);
        FemaLegsButton.SetActive(false);
        FemaArmsButton.SetActive(false);
        FemaBodyButton.SetActive(false);
    }
   


}

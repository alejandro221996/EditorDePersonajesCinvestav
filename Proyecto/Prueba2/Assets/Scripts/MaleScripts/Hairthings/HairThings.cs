using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairThings : MonoBehaviour
{
  public GameObject Hairstyle;
  public GameObject Hair1;
  public GameObject Hair2;
  public GameObject Hair3;
  public GameObject Acces1;
  public GameObject Acces2;
  public GameObject Acces3;
  public GameObject HairAccesory;

  public void ShowHairThings()
  {
      if(Hairstyle!= null)
      {
          bool isActive= Hairstyle.activeSelf;

          Hairstyle.SetActive(!isActive);
      }
       if(Hair1!= null)
      {
         bool isActive= Hair1.activeSelf;

          Hair1.SetActive(!isActive);
      }
          if(Hair2!= null)
      {
         bool isActive= Hair2.activeSelf;

          Hair2.SetActive(!isActive);
      }
          if(Hair3!= null)
      {
         bool isActive= Hair3.activeSelf;

          Hair3.SetActive(!isActive);
      }
         if(Acces1!= null)
      {
         bool isActive= Acces1.activeSelf;

          Acces1.SetActive(!isActive);
      }
          if(Acces2!= null)
      {
         bool isActive= Acces2.activeSelf;

          Acces2.SetActive(!isActive);
      }
          if(Acces3!= null)
      {
         bool isActive= Acces3.activeSelf;

          Acces3.SetActive(!isActive);
      }
    
       if(HairAccesory!= null)
      {
            bool isActive= HairAccesory.activeSelf;

          HairAccesory.SetActive(!isActive);
      }
  }

}

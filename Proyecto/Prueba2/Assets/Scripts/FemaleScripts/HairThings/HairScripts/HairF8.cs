using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairF8 : MonoBehaviour
{
  public GameObject HF8;

  public void ShowHF8()
  {
       if(HF8!= null)
      {
          bool isActive= HF8.activeSelf;

          HF8.SetActive(!isActive);
      }
  }
}

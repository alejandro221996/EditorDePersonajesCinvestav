using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairF2 : MonoBehaviour
{
  public GameObject HF2;

  public void ShowHF2()
  {
       if(HF2!= null)
      {
          bool isActive= HF2.activeSelf;

          HF2.SetActive(!isActive);
      }
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairF4 : MonoBehaviour
{
  public GameObject HF4;

  public void ShowHF4()
  {
       if(HF4!= null)
      {
          bool isActive= HF4.activeSelf;

          HF4.SetActive(!isActive);
      }
  }
}

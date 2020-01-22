using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairF7 : MonoBehaviour
{
  public GameObject HF7;

  public void ShowHF7()
  {
       if(HF7!= null)
      {
          bool isActive= HF7.activeSelf;

          HF7.SetActive(!isActive);
      }
  }
}

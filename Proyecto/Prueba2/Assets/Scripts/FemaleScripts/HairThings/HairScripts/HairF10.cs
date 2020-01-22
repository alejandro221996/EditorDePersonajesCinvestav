using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairF10 : MonoBehaviour
{
  public GameObject HF10;

  public void ShowHF10()
  {
       if(HF10!= null)
      {
          bool isActive= HF10.activeSelf;

          HF10.SetActive(!isActive);
      }
  }
}

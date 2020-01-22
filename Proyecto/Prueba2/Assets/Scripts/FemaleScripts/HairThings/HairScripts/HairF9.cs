using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairF9 : MonoBehaviour
{
  public GameObject HF9;

  public void ShowHF9()
  {
       if(HF9!= null)
      {
          bool isActive= HF9.activeSelf;

          HF9.SetActive(!isActive);
      }
  }
}

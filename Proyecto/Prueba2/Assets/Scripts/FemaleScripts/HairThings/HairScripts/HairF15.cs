using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairFe15 : MonoBehaviour
{
  public GameObject HF15;

  public void ShowHF15()
  {
       if(HF15!= null)
      {
          bool isActive= HF15.activeSelf;

          HF15.SetActive(!isActive);
      }
  }
}

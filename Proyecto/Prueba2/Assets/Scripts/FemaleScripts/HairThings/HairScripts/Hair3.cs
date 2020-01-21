using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair4 : MonoBehaviour
{
  public GameObject H4;

  public void ShowH4()
  {
       if(H4!= null)
      {
          bool isActive= H4.activeSelf;

          H4.SetActive(!isActive);
      }
  }
}

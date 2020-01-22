using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair12 : MonoBehaviour
{
  public GameObject H12;

  public void ShowH12()
  {
       if(H12!= null)
      {
          bool isActive= H12.activeSelf;

          H12.SetActive(!isActive);
      }
  }
}

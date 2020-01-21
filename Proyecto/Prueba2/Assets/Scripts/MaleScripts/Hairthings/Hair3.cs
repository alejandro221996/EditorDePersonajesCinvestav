using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair3 : MonoBehaviour
{
  public GameObject H3;

  public void ShowH3()
  {
       if(H3!= null)
      {
          bool isActive= H3.activeSelf;

          H3.SetActive(!isActive);
      }
  }
}

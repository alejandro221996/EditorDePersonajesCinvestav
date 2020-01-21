using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair2 : MonoBehaviour
{
  public GameObject H2;

  public void ShowH2()
  {
       if(H2!= null)
      {
          bool isActive= H2.activeSelf;

          H2.SetActive(!isActive);
      }
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair1 : MonoBehaviour
{
  public GameObject H1;

  public void ShowH1()
  {
       if(H1!= null)
      {
          bool isActive= H1.activeSelf;

          H1.SetActive(!isActive);
      }
  }
}

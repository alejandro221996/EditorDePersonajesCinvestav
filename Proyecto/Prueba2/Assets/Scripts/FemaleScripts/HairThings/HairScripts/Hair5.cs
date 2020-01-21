using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair6 : MonoBehaviour
{
  public GameObject H6;

  public void ShowH6()
  {
       if(H6!= null)
      {
          bool isActive= H6.activeSelf;

          H6.SetActive(!isActive);
      }
  }
}
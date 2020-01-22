using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair13 : MonoBehaviour
{
  public GameObject H13;

  public void ShowH13()
  {
       if(H13!= null)
      {
          bool isActive= H13.activeSelf;

          H13.SetActive(!isActive);
      }
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair9 : MonoBehaviour
{
  public GameObject H9;

  public void ShowH9()
  {
       if(H9!= null)
      {
          bool isActive= H9.activeSelf;

          H9.SetActive(!isActive);
      }
  }
}

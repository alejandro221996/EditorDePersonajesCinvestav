using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair5 : MonoBehaviour
{
  public GameObject H5;

  public void ShowH5()
  {
       if(H5!= null)
      {
          bool isActive= H5.activeSelf;

          H5.SetActive(!isActive);
      }
  }
}

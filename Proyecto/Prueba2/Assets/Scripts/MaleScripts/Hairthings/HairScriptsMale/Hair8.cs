using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair8 : MonoBehaviour
{
  public GameObject H8;

  public void ShowH8()
  {
       if(H8!= null)
      {
          bool isActive= H8.activeSelf;

          H8.SetActive(!isActive);
      }
  }
}

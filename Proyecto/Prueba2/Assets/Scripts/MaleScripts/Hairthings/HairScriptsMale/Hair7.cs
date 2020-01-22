using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair7 : MonoBehaviour
{
  public GameObject H7;

  public void ShowH7()
  {
       if(H7!= null)
      {
          bool isActive= H7.activeSelf;

          H7.SetActive(!isActive);
      }
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair14 : MonoBehaviour
{
  public GameObject H14;

  public void ShowH14()
  {
       if(H14!= null)
      {
          bool isActive= H14.activeSelf;

          H14.SetActive(!isActive);
      }
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair10 : MonoBehaviour
{
  public GameObject H10;

  public void ShowH10()
  {
       if(H10!= null)
      {
          bool isActive= H10.activeSelf;

          H10.SetActive(!isActive);
      }
  }
}

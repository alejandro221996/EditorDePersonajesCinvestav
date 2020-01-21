using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair15 : MonoBehaviour
{
  public GameObject H15;

  public void ShowH15()
  {
       if(H15!= null)
      {
          bool isActive= H15.activeSelf;

          H15.SetActive(!isActive);
      }
  }
}

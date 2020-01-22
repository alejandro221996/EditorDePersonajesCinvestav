using UnityEngine;

public class Hairs : MonoBehaviour
{
    public GameObject[] Hair;
    public Vector3 StartPosition;
    public Vector3 CharacterHairPosition;
    public void ShowHairs()
    {
        //Arreglo para mostrar los botones
        foreach (GameObject item in Hair)
        {
            if (item != null)
            {
                item.SetActive(true);
                item.transform.position = StartPosition;
               // Time.deltaTime.
          
            }

        } //------------------------------------------------
    }
    public void ButtonPress(int ButtonID,GameObject PressedButton)
    { 
    if(ButtonID==1)
        {
            PressedButton.SetActive(true);
            
        }
    }
}


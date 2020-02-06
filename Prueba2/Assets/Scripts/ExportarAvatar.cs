using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExportarAvatar : MonoBehaviour
{
    public Texture FinalAvatar;
    public void Export()
    {
       
        //Image[] Texturas;
        Image[] Texturas = GetComponentsInChildren<Image>();
        FinalAvatar = new Texture2D (96,192);
       for (int i =0;i<Texturas.Length;i++)
            {
            Texture CurrentTexture = Texturas[i].sprite.texture;
            Debug.Log(CurrentTexture.width);
            Debug.Log(CurrentTexture.height);
           
            //Debug.Log(CurrentTexture.gameObject.name);
            
            Graphics.CopyTexture(CurrentTexture, 0, 0, 0, 0, CurrentTexture.width, CurrentTexture.height, FinalAvatar, 0, 0, 0, 0);
        }
       
        
        
        
        
        
        
        
        
        
        
        
        /*Texture FinalTexture;
        
        Texture currentTexture = ;
        CopyTexture(currentTexture, 0, 0, 0, 0, currentTexture.width, currentTexture.height, FinalTexture, 0, 0, int dstX, int dstY);
        Texture2D tex = new Texture2D(width, height, TextureFormat.RGB24, false);

        // Read screen contents into the texture
        tex.ReadPixels(new Rect(0, 0, width, height), 0, 0);
        tex.Apply();

        // Encode texture into PNG
        byte[] bytes = tex.EncodeToPNG();
        Object.Destroy(tex);*/

        // For testing purposes, also write to a file in the project folder
        // File.WriteAllBytes(Application.dataPath + "/../SavedScreen.png", bytes);



    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteMaker : MonoBehaviour
{
    SpriteRenderer Render;

    Texture2D tex;
    // Inicializar
    public void ExportarAvatar()
    {
        Render = GetComponent<SpriteRenderer>();
        //Creando la textura
        MakeTexture();
        //Creando un sprite usando esa textura
        MakeSprite();
    }

    void MakeTexture()
    {
        Image[] Imagenes=GetComponentsInChildren<Image>();
        Texture2D[] layers = new Texture2D[Imagenes.Length] ;
        Debug.Log(Imagenes.Length);
        for (int i = 0; i < Imagenes.Length; i++)
        {
           
           layers[i] = Imagenes[i].sprite.texture;
        }

           
        tex = new Texture2D(layers[0].width, layers[0].height);

        //Arreglo para guardar el destino de los pixeles obtenidos
        Color[] colorArray = new Color[tex.width * tex.height];

        //Arreglo de colores derivado de los pixeles de la textura
        Color[][] srcArray = new Color[layers.Length][];

        //Llenando el arreglo de origen con arreglos de Layer

        for (int i = 0; i < layers.Length; i++)
        {
            srcArray[i] = layers[i].GetPixels();
        }
        //Iteracion a traves de cada pixel copiando el indice de source al destino que guardara los pixeles
        for (int x = 0; x < tex.width; x++)
        {
            for (int y = 0; y < tex.height; y++)
            {
                int pixelIndex = x + (y * tex.width);
                for (int i = 0; i < layers.Length; i++)
                {

                    Color srcPixel = srcArray[i][pixelIndex];
                    if (srcPixel.a > 0)
                    {
                        colorArray[pixelIndex] = srcPixel;

                    }
                }
            }
        }
        //Transfiere el arreglo a la textura e imprime los pixeles
        tex.SetPixels(colorArray);
        tex.Apply();

        //Configuraciones de textura
        tex.wrapMode = TextureWrapMode.Clamp;
        tex.filterMode = FilterMode.Point;

    }
    void MakeSprite()
    {
        //Creando un sprite de esa textura
        Sprite newSprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), Vector2.one * 0.5f);


        //Asignando el sprite para renderizar render.sprite
        Render.sprite = newSprite;
    
     
    }
    // Update is called once per frame

}

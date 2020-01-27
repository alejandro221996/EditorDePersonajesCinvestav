using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryControl : MonoBehaviour
{
    private List<PlayerItem> playerInventory;
    [SerializeField]
    private GameObject buttonTemplate;
    [SerializeField]
    private GridLayoutGroup gridGroup;
    [SerializeField]
    private GridLayoutGroup HorizontalGroup;
    [SerializeField]
    private Sprite[] iconSprites;

    void Start()
    {
        playerInventory = new List<PlayerItem>();
        for (int i = 0; i < iconSprites.Length; i++)
        {
            Debug.Log(i);
            PlayerItem newItem = new PlayerItem();
            newItem.iconSprite = iconSprites[i];
            playerInventory.Add(newItem);
        }
        GenInventory();
        //GenInventoryH();
       
    }

    void GenInventory()
    {
        if (playerInventory.Count < 5)
        {
            gridGroup.constraintCount = playerInventory.Count;

        }
        else
        {
            gridGroup.constraintCount = 4;
        }

        foreach (PlayerItem newItem in playerInventory)
        {
           
            GameObject newButton = Instantiate(buttonTemplate) as GameObject;
            newButton.SetActive(true);
           
            newButton.GetComponent<InventoryButton>().SetIcon(newItem.iconSprite);
            newButton.transform.SetParent(buttonTemplate.transform.parent, false);
        }
    }
   /* void GenInventoryH()
    {
        if (playerInventory.Count < 5)
        {
            HorizontalGroup.constraintCount = playerInventory.Count;

        }
        else
        {
            HorizontalGroup.constraintCount = 1;
        }

        foreach (PlayerItem newItem in playerInventory)
        {

            GameObject newButton = Instantiate(buttonTemplate) as GameObject;
            newButton.SetActive(true);

            newButton.GetComponent<InventoryButton>().SetIcon(newItem.iconSprite);
            newButton.transform.SetParent(buttonTemplate.transform.parent, false);
        }
    }*/
    public class PlayerItem
    {
        public Sprite iconSprite;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDItem : MonoBehaviour
{
    public Sprite[] itemSprites;
    private Image imageItem;

    // Start is called before the first frame update
    void Start()
    {
        imageItem = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        switch(Player_Inventory.Instance.CurrentObject)
        {
            case Items.NullItem:
                ItemRefresh(itemSprites[0]);
                break;
            case Items.DoorKey1:
                ItemRefresh(itemSprites[1]);
                break;
            case Items.DoorKey2:
                ItemRefresh(itemSprites[2]);
                break;
            case Items.DoorKey3:
                ItemRefresh(itemSprites[3]);
                break;
            case Items.DoorKey4:
                ItemRefresh(itemSprites[4]);
                break;
            case Items.DoorKey5:
                ItemRefresh(itemSprites[5]);
                break;
            case Items.DoorKey6:
                ItemRefresh(itemSprites[6]);
                break;
            case Items.DoorKey7:
                ItemRefresh(itemSprites[7]);
                break;

        }
    }

    private void ItemRefresh(Sprite newSprite) 
    {
        imageItem.sprite = newSprite;
    }
}

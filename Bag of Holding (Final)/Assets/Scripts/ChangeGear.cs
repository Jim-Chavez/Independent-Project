using UnityEngine;

public class ChangeGear : MonoBehaviour
{
    private Equipment equipmentScript; 

    private void Start()
    {
        equipmentScript = GetComponent<Equipment>();
        //creates initial equipment list
        equipmentScript.InitializeEquipptedItemsList();
        //initally equips pants so the model isn't naked
       EquipItem("Legs", "pants"); 
    }

    public void EquipItem(string itemType, string itemSlug)
    {
        //iterates through the equipment list 
        for (int i = 0; i < equipmentScript.equippedItems.Count; i++)
        {
            //finds itme at specified index
            if (equipmentScript.equippedItems[i].ItemType == itemType)
            {
                //changes index to the index of the item slug
                equipmentScript.equippedItems[i] = ItemDatabase.instance.FetchItemBySlug(itemSlug);
                //updates equipment list
                equipmentScript.AddEquipment(equipmentScript.equippedItems[i]);
                break;
            }
        }
    }

    public void UnequipItem(string itemType, string itemSlug)
    {
        //iterates through the equipment list
        for (int i = 0; i < equipmentScript.equippedItems.Count; i++)
        {
            //finds item at specified index
            if (equipmentScript.equippedItems[i].ItemType == itemType)
            {
                //updates the equipment list
                equipmentScript.RemoveEquipment(equipmentScript.equippedItems[i]);
                break;
            }
        }
    }
}
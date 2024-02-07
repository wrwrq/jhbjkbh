using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class InventoryPanelSu : MonoBehaviour
{
	public GameObject slot;
	public Sprite onoffSprite;
	public Inventory inven;
	public InventoryPanel invenUi;
	public int choice;
    public void CheckInven(Inventory inven)
	{
		this.inven = inven;
	}
}

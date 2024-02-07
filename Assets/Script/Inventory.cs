using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnityEditor.Search;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int maxInevntorySize;
    Item[] items;
    private void Start()
    {
        items = new Item[maxInevntorySize];
    }
    public int ItemCount()
    {
        Sort(items);
        int temp = 0;
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i].count > 0)
            {
                temp++;
            }
        }
        return temp;
    }
    public void UpgradeSize()
    {

    }
    public Item AccessItem(int inx)
    {
        Sort(items);
        if (inx >= ItemCount())
        {
            return null;
        }
        return items[inx];
    }
    public void AddItem(Item newItem)
    {
        Sort(items);
        for (int i = 0; i <= items.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = newItem;
                return;
            }
            else if (items[i].itmeName == newItem.itmeName)
            {
                items[i].count++;
                return;
            }
        }
    }
    public void Sort(Item[] r)
    {
        for (int i = 0; i < r.Length; i++)
        {
            if (r[i] == null)
            {
                for (int p = r.Length - 1; p > i; p--)
                {
                    if (r[p] != null)
                    {
                        r[i] = r[p];
                        r[p] = null;
                        break;
                    }
                    else if (p == i)
                    {
                        return;
                    }
                }
            }
        }
    }
}

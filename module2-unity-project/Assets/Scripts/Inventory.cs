using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Inventory : MonoBehaviour, IHittable
{
    [HideInInspector]
    public UnityEvent OnItemCollected;

    public InventoryItem item;

    public void Awake()
    {
        if (OnItemCollected == null) OnItemCollected = new UnityEvent();
    }

    public void Hit(GameObject otherGameObject)
    {
        // neeeds a bit of work... maybe this is a problem? 
        // what if inventory is full?? dont destroy object
        Destroy(gameObject);
        OnItemCollected.Invoke();
    }
}


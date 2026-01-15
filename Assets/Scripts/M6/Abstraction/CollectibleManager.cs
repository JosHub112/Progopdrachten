using System.Collections.Generic;
using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    public static CollectibleManager Instance;

    private List<Pickups> pickups = new List<Pickups>();

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        pickups.AddRange(FindObjectsOfType<Pickups>());
        Debug.Log("Total collectibles: " + pickups.Count);
    }

    public void Collect(Pickups item)
    {
        if (pickups.Contains(item))
        {
            pickups.Remove(item);
            Debug.Log("Collectible collected! Remaining: " + pickups.Count);
        }
    }
}

using UnityEngine;

public class Coin : Pickups
{
public override void OnPickup()
    {
        Debug.Log("Coin picked up");
        Destroy(gameObject);
    }
}

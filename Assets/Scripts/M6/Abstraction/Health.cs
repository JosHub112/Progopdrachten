using UnityEngine;

public class Health : Pickups
{
    public override void OnPickup()
    {
        Debug.Log("Health picked");
        Destroy(gameObject);
    }
}

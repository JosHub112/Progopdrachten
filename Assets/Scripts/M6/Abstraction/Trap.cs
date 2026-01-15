using UnityEngine;

public class Trap : Pickups
{
public override void OnPickup()
    {
        Debug.Log("Trap triggered by ");
        // Implement trap logic here (e.g., reduce player health)
        Destroy(gameObject);
    }
}

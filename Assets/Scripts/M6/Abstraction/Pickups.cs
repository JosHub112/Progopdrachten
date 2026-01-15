using UnityEngine;

public abstract class Pickups : MonoBehaviour
{
    public abstract void OnPickup();
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnPickup();
            CollectibleManager.Instance.Collect(this);
        }
    }
}

using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float delay = 1f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Picked up the Package");
            hasPackage = true;
            Destroy(collision.gameObject, delay);
        }
        if (collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Delivered the Package");
            hasPackage = false;
        }
    }

}

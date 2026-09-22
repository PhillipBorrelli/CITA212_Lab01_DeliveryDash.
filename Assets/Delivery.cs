using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        //If (the tag is package)
        //then (print picked up package to console)
        if (collision.CompareTag("Package"))
        {
            Debug.Log("Picked up the Package");
        }
        if (collision.CompareTag("Customer"))
        {
            Debug.Log("Delivered the Package");
        }
    }

}

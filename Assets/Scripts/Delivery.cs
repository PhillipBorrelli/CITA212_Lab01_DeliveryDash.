using UnityEngine;
using TMPro;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float delay = 1f;
    [SerializeField] TMP_Text deliveryText;

    void Start()
    {
        deliveryText.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Picked up the Package");
            hasPackage = true;
            deliveryText.text = "PACKAGE PICKED UP!";
            deliveryText.gameObject.SetActive(true);
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject, delay);
        }

        if (collision.CompareTag("Customer") && !hasPackage)
        {
            deliveryText.text = "YOU NEED A PACKAGE!";
            deliveryText.gameObject.SetActive(true);
        }

        if (collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Delivered the Package");
            hasPackage = false;
            deliveryText.text = "DELIVERY COMPLETE!";
            deliveryText.gameObject.SetActive(true);
            GetComponent<ParticleSystem>().Stop();
            Destroy(collision.gameObject);
        }
    }
}
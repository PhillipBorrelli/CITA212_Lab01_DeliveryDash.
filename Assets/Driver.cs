using UnityEngine;
using UnityEngine.InputSystem;
public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 2f;
    [SerializeField] float moveSpeed = 0.1f;
  
    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("We Are Pushing Forward");
        }

        else if (Keyboard.current.sKey.isPressed)
        {
            Debug.Log("We Are Pushing Backwards");
        }

        if (Keyboard.current.aKey.isPressed)
        {
            Debug.Log("We Are Pushing Left");
        }

        else if (Keyboard.current.dKey.isPressed)
        {
            Debug.Log("We Are Pushing Right");
        }
        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0, moveSpeed, 0);
    }
}

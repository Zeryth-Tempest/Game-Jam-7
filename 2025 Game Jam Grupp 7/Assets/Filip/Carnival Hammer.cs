using UnityEngine;
using UnityEngine.InputSystem;

public class CarnivalHammer : MonoBehaviour
{
    private float Charge = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void Press(InputValue value)
    {
        if (value.isPressed)
        {
            Charge += 5f;
        }
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarnivalHammer : MonoBehaviour
{
    private float Charge;

    void Start()
    {
        float Charge = 0f;
    }

    void FixedUpdate()
    {
        if (Charge >= 0f)
        {
            Charge -= 0.05f;
        }

        Debug.Log("Charge");
    }

    private void OnButtonOne(InputValue value)
    {
        if (value.isPressed)
        {
            Charge += 5f;
        }

        StartCoroutine(Swing(Charge));
    }

    private IEnumerator Swing(float Charge)
    {
        yield return null;
    }
}
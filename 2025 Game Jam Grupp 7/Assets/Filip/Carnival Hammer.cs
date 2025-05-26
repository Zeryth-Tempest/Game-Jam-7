using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarnivalHammer : MonoBehaviour
{
    private float charge;
    private float score;

    void Start()
    {
        float charge = 0f;
        StartCoroutine(Swing(charge));
    }

    void FixedUpdate()
    {
        if (charge >= 0f)
        {
            charge -= 0.06f;
        }

        Debug.Log(charge);
    }

    private void OnButtonOne(InputValue value)
    {
        if (value.isPressed)
        {
            charge += 5f;
        }
    }

    private IEnumerator Swing(float Charge)
    {
        yield return new WaitForSeconds(5f);

        score += charge;

        Debug.Log(score);
    }
}
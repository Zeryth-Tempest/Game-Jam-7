using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class ReactionLeader : MonoBehaviour
{
    public int ChosenDirection;

    private void Start()
    {
        StartCoroutine(Choose());
    }

    IEnumerator Choose()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3f));
        ChosenDirection = Random.Range(1, 5);
        Debug.Log(ChosenDirection);
    }
}

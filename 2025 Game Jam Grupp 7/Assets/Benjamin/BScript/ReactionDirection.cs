using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class ReactionDirection : MonoBehaviour
{
    Vector2 ButtonInput;
    int ChosenDirection;
   void OnMove(InputValue InputValue)
   {
        ButtonInput = InputValue.Get<Vector2>();
        Debug.Log(ButtonInput);
        ChosenDirection = GameObject.Find("Reaction Leader").GetComponent<ReactionLeader>().ChosenDirection;
   }

    private void Update()
    {
        if (ChosenDirection == 1)
        {
            if (ButtonInput == Vector2.left)
            {
                Debug.Log("Win");
            }
            else
            {
                Debug.LogError("Fail");
            }
        }
        else if (ChosenDirection == 2)
        {
            if (ButtonInput == Vector2.right)
            {
                Debug.Log("Win");
            }
            else
            {
                Debug.LogError("Fail");
            }
        }
        else if (ChosenDirection == 3)
        {
            if (ButtonInput == Vector2.up)
            {
                Debug.Log("Win");
            }
            else
            {
                Debug.LogError("Fail");
            }
        }
        else if (ChosenDirection == 4)
        {
            if (ButtonInput == Vector2.down)
            {
                Debug.Log("Win");
            }
            else 
            {
                Debug.LogError("Fail");
            }
        }
        else if (ButtonInput != new Vector2(0, 0))
        {
            Debug.LogError("Fail");
        }
    }

}

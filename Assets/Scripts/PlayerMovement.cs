using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public void TouchMove(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
            Debug.Log(ctx.ReadValue<Vector2>());
    }
}

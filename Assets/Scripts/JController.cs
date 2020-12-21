using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class JController : MonoBehaviour
{

    [SerializeField]
    FixedJoystick MoveJoystick;
    [SerializeField]
    Joybutton JumpButton;
    [SerializeField]
    FixedTouchField TouchField;


    void Update()
    {
        var fps = GetComponent<RigidbodyFirstPersonController>();

        fps.RunAxis = MoveJoystick.Direction;
        fps.JumpAxis = JumpButton.Pressed;
        fps.mouseLook.LookAxis = TouchField.TouchDist;

    }
}

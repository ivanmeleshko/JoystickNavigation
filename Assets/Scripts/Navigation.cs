using UnityEngine;


public class MyScript : MonoBehaviour
{

    protected Joystick joystick;
    protected Joybutton joybutton;
    protected bool jump;


    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();
    }


    void Update()
    {
        var rigidBody = GetComponent<Rigidbody>();

        rigidBody.velocity = new Vector3(joystick.Horizontal * 100f + Input.GetAxis("Horizontal") * 100f,
                                         rigidBody.velocity.y,
                                         joystick.Vertical * 100f+ Input.GetAxis("Vertical") * 100f);

        if (!jump && (joybutton.Pressed || Input.GetButton("Fire2")))
        {
            jump = true;
            rigidBody.velocity += Vector3.up * 20f;
        }

        if (jump && !joybutton.Pressed || Input.GetButton("Fire2"))
        {
            jump = false;
        }

    }
}

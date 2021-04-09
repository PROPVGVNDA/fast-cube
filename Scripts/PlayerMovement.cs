using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float forwardForce;
    [SerializeField] float sidewaysForce;
    private Rigidbody playerRb;
    private bool pressedA;
    private bool pressedD;

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Movement();   
    }

    private void Update()
    {
        IsSidewayButtonPressed();
    }

    private void IsSidewayButtonPressed()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) pressedD = true;
        else pressedD = false;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) pressedA = true;
        else pressedA = false;
    }

    private void Movement()
    {
        playerRb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (pressedD)
        {
            playerRb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (pressedA)
        {
            playerRb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}

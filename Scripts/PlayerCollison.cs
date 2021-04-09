using System;
using UnityEngine;

public class PlayerCollison : MonoBehaviour
{
    [SerializeField] PlayerMovement playerMovement;
    public event Action GameOver;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            playerMovement.enabled = false;
            GameOver.Invoke();
        }
    }

    private void Update()
    {
        if (OutOfBounds()) GameOver.Invoke(); 
    }

    private bool OutOfBounds()
    {
        return gameObject.transform.position.y <= -1f;
    }
}

using System;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public event Action LevelComplete;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            LevelComplete.Invoke();
        }
    }
}

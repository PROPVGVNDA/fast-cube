using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    private Vector3 cameraOffset = new Vector3(0, 1f, -5f);

    private void Update()
    {
        transform.position = playerTransform.position + cameraOffset;
    }

}

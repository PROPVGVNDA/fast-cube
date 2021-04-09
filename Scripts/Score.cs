using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] TextMeshProUGUI scoreText;

    private void Update()
    {
        scoreText.text = playerTransform.position.z.ToString("0");
    }
}

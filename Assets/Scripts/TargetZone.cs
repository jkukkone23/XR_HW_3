using UnityEngine;

public class TargetZone : MonoBehaviour
{
    public int points = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Throwable"))
        {
            GameManager.instance.AddScore(points);
            Debug.Log("Hit! +" + points);
        }
    }
}
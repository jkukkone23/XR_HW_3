using UnityEngine;

public class TargetZone : MonoBehaviour
{
    public int points = 1;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Throwable"))
        {
            // Tarkistetaan ettei sama objekti lis‰‰ pisteit‰ uudestaan
            if (!other.gameObject.TryGetComponent<HitMarker>(out _))
            {
                GameManager.instance.AddScore(points);

                // Lis‰t‰‰n merkki, jotta ei tule tupla-pisteit‰
                other.gameObject.AddComponent<HitMarker>();

                // Soitetaan osuma‰‰ni, jos on AudioSource
                if (audioSource != null)
                    audioSource.Play();

                // Tuhoaa objektin heti
                Destroy(other.gameObject);

                Debug.Log("Hit! +" + points);
            }
        }
    }
}

// Tyhj‰ komponentti est‰m‰‰n tupla-pisteet
public class HitMarker : MonoBehaviour { }
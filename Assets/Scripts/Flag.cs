using UnityEngine;

public class Flag : MonoBehaviour
{
    AuduiManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AuduiManager>();
    }
    

    private void OnTriggerEnter(Collider other)
    {

        audioManager.PlaySFX(audioManager.star);

        Player player = other.gameObject.GetComponent<Player>();

        if (player == null)
            return;

        player.Point += 10;

        UIManager.Instance.ShowNotiText($"+10 points <3\nPoints: {player.Point}");
        Destroy(gameObject);
    }
}

using UnityEngine;

public class Finish : MonoBehaviour
{

    AuduiManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AuduiManager>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        audioManager.PlaySFX(audioManager.eating);

        Player p = other.GetComponent<Player>();

        if (p == null)
            return;

        UIManager.Instance.ShowNotiText($"YOU WIN yay<3!\nPoints: {p.Point}");
    }
}

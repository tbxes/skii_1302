using UnityEngine;

public class AuduiManager : MonoBehaviour
{
    [Header ("───────────── Audio Source ─────────────")]
    [SerializeField]
    AudioSource musicSource;

    [SerializeField]
    AudioSource SFXsource;

    [Header("───────────── Audio Clip ─────────────")]
    public AudioClip background;
    public AudioClip star;
    public AudioClip eating;

    public AudioClip hit;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXsource.PlayOneShot(clip);
    }
}

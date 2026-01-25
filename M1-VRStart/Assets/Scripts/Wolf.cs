using UnityEngine;

public class Wolf : MonoBehaviour
{
    public ParticleSystem wolfAlert;
    public AudioClip wolfAudio;
    private AudioSource audioSource; 

    MoveToTarget move;

    private void Awake()
    {
        move = GetComponent<MoveToTarget>();
        audioSource = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter");
        move.enabled = true;
        wolfAlert.gameObject.SetActive(false);
        audioSource.PlayOneShot(wolfAudio);
    }
}


using UnityEngine;

public class Audiomanager : MonoBehaviour
{
  [Header("----------------Audio Source ---------------------")]
  [SerializeField] private AudioSource musicSource;
  [SerializeField] private AudioSource sfxSource;

  [Header("----------------Audio Clips ---------------------")]
  public AudioClip background;
  public AudioClip pickup;

  private void Start()
  {
       musicSource.clip = background;
       musicSource.Play();
  }

  public void Playsfx(AudioClip clip)
  {
      sfxSource.PlayOneShot(pickup);
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioBackground : MonoBehaviour
{
    //public AudioClip thisAudioClip;
    public AudioSource pessimisticAudioSource;
    //public AudioSource optimisticAudioSource;

    public AudioClip audioClipPessimistic;
    //public AudioClip audioClipOptimistic;

    //[SerializeField] public bool pausedPessimistic { get; private set; }
    //[SerializeField] public bool pausedOptimistic { get; private set; }

    void Start()
    {
        pessimisticAudioSource = GetComponent<AudioSource>();
        //optimisticAudioSource = GetComponent<AudioSource>();

        //pessimisticAudioSource.Play();
        //optimisticAudioSource.Pause();

        //pausedPessimistic = false;
        //pausedOptimistic = true;

        pessimisticAudioSource.Play();
    }
    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.E))
    //    {
    //        Debug.Log("Pause pessimistic music");
    //    }
    //    if (Input.GetKey(KeyCode.E))
    //    {
    //        UseOptimisticMusic();
    //    }
    //}
    //public void UseOptimisticMusic()
    //{
    //    pausedOptimistic = false;
    //    pausedPessimistic = true;
    //    optimisticAudioSource.UnPause();
    //    pessimisticAudioSource.Pause();
    //    StartCoroutine(MusicCooldown());
    //}
    //IEnumerator MusicCooldown()
    //{
    //    yield return new WaitForSeconds(3f);
    //    UsePessimisticMusic();
    //}
    //public void UsePessimisticMusic()
    //{
    //    pausedOptimistic = true;
    //    pausedPessimistic = false;
    //    pessimisticAudioSource.UnPause();
    //    optimisticAudioSource.Stop();
    //    Debug.Log("Optimistic music paused");
    //}
}

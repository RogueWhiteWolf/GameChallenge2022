using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioBackground : MonoBehaviour
{
    //public OptimismGlasses optimismGlasses;
    //public AudioClip thisAudioClip;
    public AudioSource pessimisticAudioSource;
    public AudioSource optimisticAudioSource;

    public AudioClip audioClipPessimistic;
    public AudioClip audioClipOptimistic;

    [SerializeField] public bool pausedPessimistic { get; private set; }
    [SerializeField] public bool pausedOptimistic { get; private set; }

    void Start()
    {
        //audioSourcePessimistic = GetComponent<AudioSource>();
        //audioSourceOptimistic = GetComponent<AudioSource>();
        //thisAudioSource = GetComponent<AudioSource>();
        //thisAudioSource = UnityEngine.Object.FindObjectsOfType<AudioSource>();
        //thisAudioSource[0].Play();
        //thisAudioSource[1].Pause();

        pessimisticAudioSource = GetComponent<AudioSource>();
        optimisticAudioSource = GetComponent<AudioSource>();

        pessimisticAudioSource.Play();
        optimisticAudioSource.Pause();

        pausedPessimistic = false;
        pausedOptimistic = true;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Pause pessimistic music");
        }
        if (Input.GetKey(KeyCode.E))
        {
            UseOptimisticMusic();
        }
    }
    public void UseOptimisticMusic()
    {
        pausedOptimistic = false;
        pausedPessimistic = true;
        optimisticAudioSource.UnPause();
        pessimisticAudioSource.Pause();
        StartCoroutine(MusicCooldown());
    }
    IEnumerator MusicCooldown()
    {
        yield return new WaitForSeconds(3f);
        UsePessimisticMusic();
    }
    public void UsePessimisticMusic()
    {
        pausedOptimistic = true;
        pausedPessimistic = false;
        pessimisticAudioSource.UnPause();
        optimisticAudioSource.Stop();
        Debug.Log("Optimistic music paused");
    }
}

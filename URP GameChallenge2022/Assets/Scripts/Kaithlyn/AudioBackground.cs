using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioBackground : MonoBehaviour
{
    float timePassed;
    bool shouldTime;
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
        //optimisticAudioSource.Pause();

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

        if (Input.GetKeyDown(KeyCode.L))
        {
            shouldTime = true;
            UseOptimisticMusic();
        }
        if (shouldTime == true)
        {
            timePassed += Time.deltaTime;
        }
        if (timePassed >= 5f)
        {
            shouldTime = false;
            timePassed = 0;
            UsePessimisticMusic();
        }
    }
    public void UseOptimisticMusic()
    {
        pausedOptimistic = false;
        pausedPessimistic = true;
        optimisticAudioSource.Play();
        pessimisticAudioSource.Pause();
        //StartCoroutine(MusicCooldown());
    }
    public void UsePessimisticMusic()
    {
        pausedOptimistic = true;
        pausedPessimistic = false;
        pessimisticAudioSource.UnPause();
        optimisticAudioSource.Stop();
        Debug.Log("Optimistic music paused");
    }
    IEnumerator MusicCooldown()
    {
        UsePessimisticMusic();
        yield return new WaitForSeconds(3f);
    }
}

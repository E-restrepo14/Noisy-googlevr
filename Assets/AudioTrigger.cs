using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour {

    [SerializeField]
    private AudioClip aveRuidosaEscondida;
    [SerializeField]
    private AudioClip aveRuidosaExpuesta;
    [SerializeField]
    private AudioClip aveSilenciosa;
    [SerializeField]
    private AudioClip aveSolitaria;
    [SerializeField]
    private AudioClip avesYGrillos;
    [SerializeField]
    private AudioClip ranasCantando;
    [SerializeField]
    private AudioClip gavilan;
    [SerializeField]
    private AudioClip gavilanMasLucido;

    public AudioSource source;
    private float volRange = 0.8f;


    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Tucaneta"))
        {
            source.Stop();
            source.clip = aveRuidosaEscondida;
            source.volume = 0.08f;
            source.Play();
            

        }
        else

        if (other.gameObject.CompareTag("Cristofue"))
        {
            source.Stop();
            source.clip = aveRuidosaExpuesta;
            source.volume = 0.04f;
            source.Play();
            

        }
        else

        if (other.gameObject.CompareTag("Gorrion"))
        {
            source.Stop();
            source.clip = aveSilenciosa;
            source.volume = 0.8f;
            source.Play();
           

        }
        else

        if (other.gameObject.CompareTag("Barranquero"))
        {
            source.Stop();
            source.clip = aveSolitaria;
            source.volume = volRange;
            source.Play();
            

        }
        else

        if (other.gameObject.CompareTag("Grillos"))
        {
            source.Stop();
            source.clip = avesYGrillos;
            source.volume = 0.5f;
            source.Play();
            

        }
        else

        if (other.gameObject.CompareTag("Ranas"))
        {
            source.Stop();
            source.clip = ranasCantando;
            source.volume = volRange;
            source.Play();
            

        }

        else

        if (other.gameObject.CompareTag("Gavilan"))
        {
            source.Stop();
            source.clip = gavilanMasLucido;
            source.volume = volRange;
            source.Play();

            

        }
        else

        if (other.gameObject.CompareTag("Gavilansin"))
        {
            source.Stop();
            source.clip = gavilan;
            source.volume = volRange;
            source.Play();

           

        }

    }

   

}

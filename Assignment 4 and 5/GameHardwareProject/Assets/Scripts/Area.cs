using UnityEngine;

public class Area : MonoBehaviour
{
    public GameObject button;
    public int colour;
    public GameObject particle;
    public AudioClip sound;
    private void OnTriggerStay(Collider other)
    {
       
        if (other.gameObject.tag == "note" && button.GetComponent<Buttons>().isPressed[colour]) 
        {
            GetComponent<AudioSource>().clip = sound;
            GetComponent<AudioSource>().Play();
           particle.GetComponent<ParticleSystem>().Play();
            Destroy(other.gameObject);
        }

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

using UnityEngine;

public class Notes : MonoBehaviour
{
    public Transform start;
    public GameObject note;
    public Transform end;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newnote = Instantiate(note, start);
            newnote.GetComponent<NewNote>().start = start;
            newnote.GetComponent<NewNote>().end = end;
        }

    }
}

using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject[] springs = new GameObject[5];
    public GameObject[] physicalNote = new GameObject[5];
    public bool[] isPressed;

    private float endRotation = 10;
    private float rotateInterval = 0.5f;

    private float startScale = 1.0f;
    private float endScale = 0.5f;
    private float springInterval = 0.1f;

    public void moveNoteDown(GameObject note, GameObject spring)
    {
        if (spring.transform.localScale.z > endScale)
        {
            spring.transform.localScale -= new Vector3(0, 0, springInterval);
        }

        // Debug.Log(endRotation);
        // Debug.Log(note.transform.eulerAngles.y);
        // if (note.transform.localRotation.eulerAngles.y >endRotation)
        //  {
        //Vector3 temp = note.transform.localRotation.eulerAngles;

        //temp = new Vector3(0, temp.y +rotateInterval,0);
        // note.transform.localEulerAngles = temp;

        float rY = Mathf.PingPong(rotateInterval, endRotation) + 10;
        note.transform.localRotation = Quaternion.Euler(0, rY, 0);

        //   _tempTime += Time.deltaTime;
        //    transform.localEulerAngles = new Vector3(-Mathf.PingPong(_tempTime * rotSpeed, rot), 0,
        // }

        //note.transform.rotation 
    }

    public void moveNoteUp(GameObject note, GameObject spring)
    {

        if (spring.transform.localScale.z < startScale)
        {
            spring.transform.localScale += new Vector3(0, 0, springInterval);
        }

        float rY = Mathf.PingPong(rotateInterval, -endRotation) + 20;
        note.transform.localRotation = Quaternion.Euler(0, rY, 0);

        //if (note.transform.localRotation.eulerAngles.y< startRotation)
        //{
        //    Vector3 temp = note.transform.localRotation.eulerAngles;
        //   temp = new Vector3(0, temp.y - rotateInterval,0);
        //    note.transform.localEulerAngles = temp;
        //}

        // if (Input.GetKeyDown(KeyCode.E))
        //  Debug.Log(note.transform.localRotation.y);
    }


    // Update is called once per frame
    void Update()
    {
        //down green
        if (Input.GetKey(KeyCode.A))
        {
            moveNoteDown(physicalNote[0], springs[0]);
            isPressed[0] = true;
        }
        //up green
        if (!Input.GetKey(KeyCode.A))
        {
            moveNoteUp(physicalNote[0], springs[0]);
            isPressed[0] = false;
        }

        //down red
        if (Input.GetKey(KeyCode.S))
        {
            moveNoteDown(physicalNote[1], springs[1]);
            isPressed[1] = true;
        }
        //up red
        if (!Input.GetKey(KeyCode.S))
        {
            moveNoteUp(physicalNote[1], springs[1]);
            isPressed[1] = false;
        }

        //down yellow
        if (Input.GetKey(KeyCode.D))
        {
            moveNoteDown(physicalNote[2], springs[2]);
            isPressed[2] = true;
        }
        //up yellow
        if (!Input.GetKey(KeyCode.D))
        {
            moveNoteUp(physicalNote[2], springs[2]);
            isPressed[2] = false;
        }

        //down blue
        if (Input.GetKey(KeyCode.F))
        {
            moveNoteDown(physicalNote[3], springs[3]);
            isPressed[3] = true;
        }
        //up blue
        if (!Input.GetKey(KeyCode.F))
        {
            moveNoteUp(physicalNote[3], springs[3]);
            isPressed[3] = false;
        }

        //down orange
        if (Input.GetKey(KeyCode.G))
        {
            moveNoteDown(physicalNote[4], springs[4]);
            isPressed[4] = true;
        }
        //up orange
        if (!Input.GetKey(KeyCode.G))
        {
            moveNoteUp(physicalNote[4], springs[4]);
            isPressed[4] = false;
        }


        //down start
        if (Input.GetKey(KeyCode.E))
        {
            moveNoteDown(physicalNote[5], springs[5]);
            isPressed[5] = true;
        }

        //up start
        if (!Input.GetKey(KeyCode.E))
        {
            isPressed[5] = false;
            moveNoteUp(physicalNote[5], springs[5]);
        }

        //down exit
        if (Input.GetKey(KeyCode.R))
        {
            moveNoteDown(physicalNote[6], springs[6]);
            isPressed[6] = true;
        }

            //up exit
            if (!Input.GetKey(KeyCode.R))
        {
            moveNoteUp(physicalNote[6], springs[6]);
            isPressed[6] = false;
        }

    }
}

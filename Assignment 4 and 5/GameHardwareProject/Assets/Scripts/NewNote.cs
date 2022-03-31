using UnityEngine;

public class NewNote : MonoBehaviour
{
    public Transform end;
    public Transform start;

    // Movement speed in units per second.
    public float speed = 1.0F;
    // Time when the movement started.
    private float startTime;
    // Total distance between the markers.
    private float journeyLength;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        // Calculate the journey length.
        journeyLength = Vector3.Distance(start.position, end.position);
    }

    // Update is called once per frame
    void Update()
    {
        // Distance moved equals elapsed time times speed..
        float distCovered = (Time.time - startTime) * speed;

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;

        // Set our position as a fraction of the distance between the markers.
        transform.position = Vector3.Lerp(start.position, end.position, fractionOfJourney);
    }
}

using UnityEngine;

public class OneBallBehaviour : MonoBehaviour
{
    public float XRotation = 0;
    public float YRotation = 1;
    public float ZRotation = 0;
    public float DegreesPerSecond = 180;


    void Start()
    {
        transform.position = new Vector3(3 - Random.value * 6,
            3 - Random.value * 6, 3 - Random.value * 6);
    }

    void Update()
    {
        Vector3 axis = new Vector3(XRotation, YRotation, ZRotation);
        transform.RotateAround(Vector3.zero, axis, DegreesPerSecond * Time.deltaTime);
    }

    
}

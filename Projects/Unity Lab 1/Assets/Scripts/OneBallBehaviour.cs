using UnityEngine;

public class OneBallBehaviour : MonoBehaviour
{
    public float XSpeed = 0;
    public float YSpeed = 0;
    public float ZSpeed = 0;
    public float Multiplier = 0.75F;
    public int TooFar = 5;

    

    static int BallCount = 0;
    public int BallNumber;


    

    void OnMouseDown()
    {
        GameController controller = Camera.main.GetComponent<GameController>();
        if (!controller.GameOver)
        {
            controller.ClickedOnBall();
            Destroy(gameObject);
        }
    }

    void Start()
    { 
        BallCount++;
        BallNumber = BallCount;
        ResetBall();
    }

    public void ResetBall()
    {
        XSpeed = Multiplier - Random.value * Multiplier * 2;
        YSpeed = Multiplier - Random.value * Multiplier * 2;
        ZSpeed = Multiplier - Random.value * Multiplier * 2;

        transform.position = new Vector3(3 - Random.value * 6,
           3 - Random.value * 6, 3 - Random.value * 6);
    }

    void Update()
    {
        transform.Translate(Time.deltaTime * XSpeed, Time.deltaTime * YSpeed, Time.deltaTime * ZSpeed);

        XSpeed += Multiplier - Random.value * Multiplier * 2;
        YSpeed += Multiplier - Random.value * Multiplier * 2;
        ZSpeed += Multiplier - Random.value * Multiplier * 2;

        
        if ((Mathf.Abs(transform.position.x) > TooFar) ||
            (Mathf.Abs(transform.position.y) > TooFar) ||
            (Mathf.Abs(transform.position.z) > TooFar))
        {
            ResetBall();
        }
    }

    
}

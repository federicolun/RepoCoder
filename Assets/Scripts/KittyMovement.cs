using UnityEngine;

public class KittyMovement : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float speed = 20;

    public GameObject camOne;
    public GameObject camTwo;

    void Start()
    {
        
    }

    void Update()
    {
        Movement();

        if (Input.GetKeyDown(KeyCode.J))
        {
            ChangeCamera();
        }
    }

    void Movement()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime);
    }

    void ChangeCamera()
    {
        if (camOne.activeInHierarchy)
        {
            camOne.SetActive(false);
            camTwo.SetActive(true);
        }
        else
        {
            camOne.SetActive(true);
            camTwo.SetActive(false);
        }
    }
}

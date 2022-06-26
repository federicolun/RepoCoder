using UnityEngine;

public class ScaleAndMovement : MonoBehaviour
{
    public float speed = 5.0f;

    public Vector3 movementObject;
    public Vector3 scaleObject;

    void Start()
    {
        Debug.Log("Se modificó la escala del objecto");
        transform.localScale += scaleObject;
    }

    void Update()
    {
        MovementPlayer();
    }

     void MovementPlayer()
    {
        Debug.Log("Objeto moviendose");
        transform.Translate(movementObject * speed * Time.deltaTime);
    }
}

using System.Collections;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject prefabBullet;

    public Transform spawnPosition;

    public float speed;

    public Vector3 direction;

    public int damage;

    public float timeOfLive;

    private Vector3 doubleScale = new Vector3(2, 2, 2);

    private void Start()
    {

    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
        DuplicateScale();
        Destroy(gameObject, timeOfLive);
    }

    void DuplicateScale()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale += doubleScale;
        }
    }
}

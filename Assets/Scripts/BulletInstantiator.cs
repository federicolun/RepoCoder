using System.Collections;
using UnityEngine;

public class BulletInstantiator : MonoBehaviour
{
    public GameObject prefabBullet;

    public float timeForShoot;
    private float time;

    void Start()
    {

    }
    private void Update()
    {
        TimerForShooting();
        //ShootTwo();
        //ShootThree();
        //ShootFour();
    }

    void ResetTime()
    {
        time = timeForShoot;
    }

    void TimerForShooting()
    {
        time -= Time.deltaTime;
        if(time <= 0)
        {
            Shoot();
            ResetTime();
        }

    }

    void Shoot()
    {
        Instantiate(prefabBullet, transform.position, transform.rotation);
    }

    void ShootTwo()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            StartCoroutine(ShootTwoBullet());
        }
    }

    void ShootThree()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            StartCoroutine(ShootThreeBullet());
        }
    }

    void ShootFour()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            StartCoroutine(ShootFourBullet());
        }
    }

    IEnumerator ShootTwoBullet()
    {
        Instantiate(prefabBullet, transform.position, transform.rotation);

        yield return new WaitForSeconds(0.5f);

        Instantiate(prefabBullet, transform.position, transform.rotation);

    }

    IEnumerator ShootThreeBullet()
    {
        Instantiate(prefabBullet, transform.position, transform.rotation);

        yield return new WaitForSeconds(0.5f);

        Instantiate(prefabBullet, transform.position, transform.rotation);

        yield return new WaitForSeconds(0.5f);

        Instantiate(prefabBullet, transform.position, transform.rotation);

    }

    IEnumerator ShootFourBullet()
    {
        Instantiate(prefabBullet, transform.position, transform.rotation);

        yield return new WaitForSeconds(0.5f);

        Instantiate(prefabBullet, transform.position, transform.rotation);

        yield return new WaitForSeconds(0.5f);

        Instantiate(prefabBullet, transform.position, transform.rotation);

        yield return new WaitForSeconds(0.5f);

        Instantiate(prefabBullet, transform.position, transform.rotation);

    }

}

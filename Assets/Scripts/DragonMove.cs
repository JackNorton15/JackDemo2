using UnityEngine;

public class DragonMove : MonoBehaviour
{
    public float speed = 5;
    public bool goingUp = true;

    //rat/fireball timers
    private float ratWait = 1, fireballWait = 2, knifeWait = 1;
    private float ratTimer = 0, fireballTimer = 0, knifeTimer = 0;

    public GameObject rat;
    public GameObject fireball;
    public GameObject knife;
    
    void Update()
    {
        //spawning
        ratTimer += Time.deltaTime;
        fireballTimer += Time.deltaTime;
        knifeTimer += Time.deltaTime;

        if(ratTimer > ratWait)
        {
            Instantiate(rat, transform.position, Quaternion.identity);
            ratTimer = 0;
            ratWait = Random.Range(1f, 2f);
        }

        if (fireballTimer > fireballWait)
        {
            Instantiate(fireball, transform.position, Quaternion.identity);
            fireballTimer = 0;
            fireballWait = Random.Range(2f, 3f);
        }

        if (knifeTimer > knifeWait)
        {
            Instantiate(knife, transform.position, Quaternion.identity);
            knifeTimer = 0;
            knifeWait = Random.Range(1f, 2f);
        }

        transform.Translate(transform.up * speed * Time.deltaTime);

        if(transform.position.y > 4 && goingUp == true)

        {
            goingUp = false;
            speed *= -1;
        }

        if (transform.position.y < -4 && goingUp == false)

        {
            goingUp = true;
            speed *= -1;
        }
    }
}

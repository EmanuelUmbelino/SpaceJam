using UnityEngine;
using System.Collections;

public class FireManager : MonoBehaviour
{
    public float speed;
    private float startTime;

    void Start()
    {
        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

        startTime = Time.fixedTime;
    }


    void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    void FixedUpdate()
    {
        Move();
        if (Time.fixedTime - startTime > 3)
            Destroy(this.gameObject);
    }
}
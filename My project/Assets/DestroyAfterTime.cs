using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float lifeSpan = 2.0f;
    private float lifeTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3 (Random.Range(-1,1), Random.Range(-1,1), Random.Range(1,1));  
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime += Time.deltaTime;
        if (lifeTime > lifeSpan) Destroy(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Match;
using UnityEngine.UI;

public class TouchHit : MonoBehaviour
{
    public GameObject spherePrefab;
    public GameObject cubePrefab;
    public float scale = 0.01f;
    public Text posTxt;
    public Material[] mats;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Input.mousePosition;
            for (int i = 0; i < 3; i++)
            {

                Vector3 position = new Vector3((mousePosition.x - Screen.width / 2f) * scale, (mousePosition.y - Screen.height / 2f) * scale, -1);
                Vector3 randomDrift = new Vector3(Random.Range(-.1f, .1f), Random.Range(-.1f, .1f), Random.Range(-.1f,.1f));
                GameObject temp = Instantiate(spherePrefab, position + randomDrift, Quaternion.identity);
                randomDrift = new Vector3(Random.Range(-.1f, .1f), Random.Range(-.1f, .1f), 0);
                temp.GetComponent<MeshRenderer>().material = mats[Random.Range(0, mats.Length)];
                temp = Instantiate(spherePrefab, position, Quaternion.identity);
                temp.GetComponent<MeshRenderer>().material = mats[Random.Range(0, mats.Length)];
                randomDrift = new Vector3(Random.Range(-.1f, .1f), Random.Range(-.1f, .1f), 0);
                temp = Instantiate(cubePrefab, position, Quaternion.identity);
                temp.GetComponent<MeshRenderer>().material = mats[Random.Range(0, mats.Length)];
                randomDrift = new Vector3(Random.Range(-.1f, .1f), Random.Range(-.1f, .1f), 0);
                temp = Instantiate(cubePrefab, position, Quaternion.identity);
                temp.GetComponent<MeshRenderer>().material = mats[Random.Range(0, mats.Length)];

                posTxt.text = position.ToString();
            }
            //Instantiate(spherePrefab, Vector3.zero, Quaternion.identity);
        }
    }
}

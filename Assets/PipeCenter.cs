using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipeCenter : MonoBehaviour
{
    public float speed;
    public GameObject pipe;
    public GameObject text;

    private static int score;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pipe.transform.Translate(Vector3.left * speed * Time.deltaTime); // makes the pipe move to the left at a constant speed
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            score++;
            text.GetComponent<Text>().text = score.ToString();
        }
    }

}

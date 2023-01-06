using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ToNewScene : MonoBehaviour
{
    private Transform other;
    private float dist;
    private GameObject player;
    private bool check;
    static int i = 20;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        other = player.GetComponent<Transform>();

        check = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (other)
        {
            dist = Vector3.Distance(transform.position, other.position);
            if ((dist < 7) && (Input.GetKey(KeyCode.Return)))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                check = true;
            }

        }
    }
}

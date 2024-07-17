using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;

public class MoveT : MonoBehaviour
{
    public float move = 0.01f;
    public AutoMoveAndRotate a;
    public GameObject interfejsP;
    public GameObject interfejsW;
    public GameObject sternik;
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-move, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(move, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quitting game...");
            Application.Quit();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        enabled = false;
        a.enabled = false;
        Debug.Log("Zderzenie");
        sternik.GetComponent<Animator>().speed = 0;
        if (collision.gameObject.name == "Most")
        {
            interfejsW.SetActive(true);
        }
        else
        {
            interfejsP.SetActive(true);
        }
    }
}

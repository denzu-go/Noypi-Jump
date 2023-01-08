using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Character"))
        {
            Finish();
        }

    }

    private void Finish()
    {
        this.gameObject.GetComponent<Animator>().SetTrigger("finish");
    }

    private void nextLevel()
    {
        SceneManager.LoadScene(3);
    }
}

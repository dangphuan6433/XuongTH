using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject WinUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
             Debug.Log("Win!");
            WinUI.SetActive(true);
        }
    }
}
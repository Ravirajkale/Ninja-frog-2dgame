using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    private int oranges = 0;
    [SerializeField] private AudioSource collectSoundEffect;
    [SerializeField] private TextMeshProUGUI orangesText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("orange"))
        {
            Destroy(collision.gameObject);
            oranges++;
            orangesText.text = "Oranges:" + oranges;
            collectSoundEffect.Play();
        }
    }
}

using UnityEngine;

public class VolumeTrigger : MonoBehaviour
{
    [SerializeField] private GameObject text;
    [SerializeField] private GameObject firework;
    [SerializeField] private GameObject debris;

    private void OnTriggerEnter(Collider other)
    {
        text.SetActive(true);
        firework.SetActive(true);
        debris.SetActive(true);
    }
}
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class DestroyableObject : MonoBehaviour
{
    [SerializeField]
    private int defaultHealth;
    [SerializeField]
    private bool resetInNewRound;
    [SerializeField]
    private bool bombOnly;
    [HideInInspector]
    public int health;
    [SerializeField]
    private AudioClip[] destroyClips;
    [HideInInspector]
    public GameObject destroyableObject;
}

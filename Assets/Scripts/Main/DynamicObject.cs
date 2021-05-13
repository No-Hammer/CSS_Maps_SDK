using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class DynamicObject : MonoBehaviour
{
    public AudioClip[] collisionClips;
    public bool resetInNewRound;
    private Vector3 defaultPos;
    private Quaternion defaultRot;
    public bool disableDynamic;
}

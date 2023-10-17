using UnityEngine;
using Vuforia;

public class DistanceChecker : MonoBehaviour
{
    public GameObject lionTarget;
    public GameObject tigerTarget;

    private Animator lionAnimator;
    private Animator tigerAnimator;
    private float thresholdDistance = 100.0f;

    void Start()
    {
        lionAnimator = lionTarget.GetComponentInChildren<Animator>();
        tigerAnimator = tigerTarget.GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (lionTarget.activeSelf && tigerTarget.activeSelf)
        {
            float distance = Vector3.Distance(lionTarget.transform.position, tigerTarget.transform.position);

            if (distance < thresholdDistance)
            {
                lionAnimator.SetTrigger("TrAttack");
                tigerAnimator.SetTrigger("TrAttack");
            }
            else
            {
                lionAnimator.SetTrigger("TrIdle");
                tigerAnimator.SetTrigger("TrIdle");
            }
        }
    }
}

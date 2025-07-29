using System;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public StateBehavior state;
    [SerializeField] Animator animator;
    private void Start()
    {
        StateBehavior[] sbs = animator.GetBehaviours<StateBehavior>();
        Debug.Log(sbs.Length);
        foreach(var sb in sbs)
        {
            sb.setUpState(animator);
        }
    }
    private void FixedUpdate()
    {
        state?.FixedUpdateState();
    }

    // Update is called once per frame
    void Update()
    {
        state?.UpdateState();
    }
}

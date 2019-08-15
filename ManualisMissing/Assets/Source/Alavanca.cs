using UnityEngine;

public class Alavanca : MonoBehaviour {

    public static int LeverState = 0;

    private Animator animator;

    private void Start() {
        animator = GetComponent<Animator>();
    }

    private void OnMouseOver() {
        if (Input.GetMouseButtonDown(0))
        {
            LeverState = LeverState >= 2 ? 0 : ++LeverState;
            animator.SetInteger("LeverState", LeverState);
        }
    }
}

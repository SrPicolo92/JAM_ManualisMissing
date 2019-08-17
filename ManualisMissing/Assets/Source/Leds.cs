using UnityEngine;

public class Leds : MonoBehaviour {
    public static int LedState = 0;

    private Animator animator;

    private void Start() {
        animator = GetComponent<Animator>();
    }

    private void Update() {
        animator.SetInteger("LedState", Mathf.Clamp(LedState, 0, 4));
    }
}

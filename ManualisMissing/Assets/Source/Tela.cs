using UnityEngine;

public class Tela : MonoBehaviour {
    private Animator animator;

    private void Start() {
        animator = GetComponent<Animator>();
    }

    private void Update() {
        animator.SetInteger("LeverState", Alavanca.LeverState);
    }
}

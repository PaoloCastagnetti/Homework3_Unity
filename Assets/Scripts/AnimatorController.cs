using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Animator animator;

    private bool _isWalkingForward;
    private bool _isWalkingBackward;
    private int _isWalkingForwardHash;
    private int _isWalkingBackwardHash;

    void Start() {
        animator = GetComponent<Animator>();
        _isWalkingForwardHash = Animator.StringToHash("isWalkingForward");
        _isWalkingBackwardHash = Animator.StringToHash("isWalkingBackward");
    }

    private void Update() {
        _isWalkingForward = animator.GetBool(_isWalkingForwardHash);
        if (!_isWalkingForward && Input.GetKeyDown(KeyCode.W)) {
            animator.SetBool(_isWalkingForwardHash, true);
        }
        if (_isWalkingForward && Input.GetKeyUp(KeyCode.W)) {
            animator.SetBool(_isWalkingForwardHash, false);
        }

        _isWalkingBackward = animator.GetBool(_isWalkingBackwardHash);
        if (!_isWalkingBackward && Input.GetKeyDown(KeyCode.S)) {
            animator.SetBool(_isWalkingBackwardHash, true);
        }
        if (_isWalkingBackward && Input.GetKeyUp(KeyCode.S)) {
            animator.SetBool(_isWalkingBackwardHash, false);
        }

    }
}

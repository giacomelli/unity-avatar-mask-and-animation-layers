using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationStateController : MonoBehaviour
{
    Animator _anim;
 
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    public void ToggleParameter(string name)
    {
        _anim.SetBool(name, !_anim.GetBool(name));
    }
}

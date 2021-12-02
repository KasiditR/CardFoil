using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Rotate : MonoBehaviour
{
    public Transform obj;
    public Vector3 targetRotate;
    public float duration;
    public Ease ease;
    void Start()
    {
        obj.DOLocalRotate(targetRotate,duration,RotateMode.LocalAxisAdd).SetEase(ease).SetLoops(-1);
        Debug.Log("Rotate!!");
    }
}

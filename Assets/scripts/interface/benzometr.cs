﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class benzometr : MonoBehaviour {

    public float _start; // начальное положение стрелки по оси Z

    public float maxSpeed = 42; // максимальная скорость на спидометре

    public RectTransform arrow; // стрелка спидометра

    public enum ProjectMode { Project3D = 0, Project2D = 1 };
    public ProjectMode projectMode = ProjectMode.Project3D;

    public Transform target; // объект с которого берем скорость

    public float velocity; // текущее реальное колво топлива объекта

    private Rigidbody _3D;
    private Rigidbody2D _2D;
    private float speed;
    public float benz;
    public GameObject Panel;

    void Start()
    {
        arrow.localRotation = Quaternion.Euler(0, 0, _start);
        if (projectMode == ProjectMode.Project3D) _3D = target.GetComponent<Rigidbody>();
        else _2D = target.GetComponent<Rigidbody2D>();
        Panel.transform.localScale =  new Vector3(benz, 1 , 0);
    }

    void Update()
    {
        if (projectMode == ProjectMode.Project3D) velocity = _3D.velocity.magnitude; else velocity = _2D.velocity.magnitude;//
        if (velocity > maxSpeed) velocity = maxSpeed;
        speed = _start + velocity; // + velocity ????????????
        arrow.localRotation = Quaternion.Euler(0, 0, speed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform _compTransform;
    private SpriteRenderer _compSpriteRenderer;
    public float speed;
    public int directionX;
    public int directionY;
    void Awake()
    {
        _compTransform = GetComponent<Transform>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _compTransform.position = new Vector2(_compTransform.position.x + speed * directionX * Time.deltaTime, _compTransform.position.y + speed * directionY * Time.deltaTime);
        if(_compTransform.position.x > 5.25f)
        {
            directionX = -1;
            _compSpriteRenderer.flipX = true;
        }
        if(_compTransform.position.x < -5.25f)
        {
            directionX = 1;
            _compSpriteRenderer.flipX = false;
        }
        if(_compTransform.position.y > 2.9f)
        {
            directionY = -1;
            _compSpriteRenderer.flipY = true;
        }
        if(_compTransform.position.y < -2.9f)
        {
            directionY = 1;
            _compSpriteRenderer.flipY = false;
        }
    }
}

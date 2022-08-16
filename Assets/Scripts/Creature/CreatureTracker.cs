using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureTracker : MonoBehaviour
{
    [SerializeField] private Creature _creature;
    [SerializeField] private float _xOffset;

    private void Update()
    {
        transform.position = new Vector3(_creature.transform.position.x + _xOffset, transform.position.y, transform.position.z);
    }
}

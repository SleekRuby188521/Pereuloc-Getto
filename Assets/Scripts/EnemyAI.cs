using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{

    
    public PlayerController player;
    public float viewAngle;
    public float damage = 30;
    private PlayerHealth _playerHealth;

    public NavMeshAgent _navMeshAgent;
    private bool _isPlayerNoticed;
    // Start is called before the first frame update
    private void Start()
    {
        InitComponentLinks();
        
    }

    private void InitComponentLinks()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _playerHealth = player.GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    private void Update()
    {
        NoticePlayerUpdate();
        ChaseUpdate();
        AttackUpdate();
        
    }

    private void AttackUpdate()
    {
        if (_isPlayerNoticed)
        {
            if (_navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
            {
                _playerHealth.GetComponent<PlayerHealth>().DealDamage(damage * Time.deltaTime);
            }    
        }
    }

    private void ChaseUpdate()
    {
        if (_isPlayerNoticed)
        {
            _navMeshAgent.destination = player.transform.position;
        }
    }

    private void NoticePlayerUpdate()
    {
        var direction = player.transform.position - transform.position;
        _isPlayerNoticed = false;
        if (Vector3.Angle(transform.forward, direction) < viewAngle)
        {

            RaycastHit hit;
            if (Physics.Raycast(transform.position + Vector3.up, direction, out hit))
            {
                if (hit.collider.gameObject == player.gameObject)
                {
                    _isPlayerNoticed = true;
                }

            }

        }
    }


}

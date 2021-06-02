using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
	NavMeshAgent move;
	public GameObject player;
	Transform player_transform;
	Animator anim;

	int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        move = GetComponent<NavMeshAgent>();
        player_transform = player.GetComponent<Transform>();
        anim = GetComponent<Animator>();
        move = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
    	Debug.DrawRay(transform.position, transform.forward *2f, Color.red);
    	float dist = Vector3.Distance(player.transform.position, transform.position);
    	print(dist);
    	if(dist <=10f)
    	{
    		move.SetDestination(player.transform.position);
    	}
    }

    void OnCollisionEnter(Collision collision_object)
    {
    	if(collision_object.gameObject.tag== "player")
    	{
    		anim.SetTrigger("attack");
    	}

       if(collision_object.gameObject.tag == "Bullet")
        {
            score = score + 1;
            Destroy(gameObject);
            if(score == 5)
            {
                SceneManager.LoadScene("scene3");
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject[] platform;
	public GameObject[] enemy;
	public GameObject player;
	Player playerobj;

	private void Start()
	{
		foreach (GameObject pl in platform)
		{
			Platform obj = pl.GetComponent<Platform>();
			obj.SetPosition();
		}
		foreach (GameObject pl in enemy)
		{
			Enemy obj = pl.GetComponent<Enemy>();
			obj.SetPosition();
		}
		playerobj = player.GetComponent<Player>();
	}
	private void Update()
	{
		foreach (GameObject pl in platform)
		{
			Platform obj = pl.GetComponent<Platform>();
			obj.Move();
			if (obj.transform.position.y < player.transform.position.y - 12)
			{
				Vector3 vector = obj.transform.position;
				vector.y += Random.Range(16, 20);
				vector.x = Random.Range(player.transform.position.x - 10, player.transform.position.x + 10);
				obj.transform.position = vector;
				obj.resetXY();
				playerobj.store += 1;
			}
		}
		if (playerobj.transform.position.y < -6)
		{
			Debug.Log("You Looose, your Store:" + playerobj.store);
			player.SetActive(false);
		}
		foreach (GameObject pl in enemy)
		{
			Enemy obj = pl.GetComponent<Enemy>();
			obj.Move();
			if (obj.transform.position.y < player.transform.position.y - 12)
			{
				Vector3 vector = obj.transform.position;
				vector.y += Random.Range(26, 30);
				vector.x = Random.Range(player.transform.position.x - 10, player.transform.position.x + 10);
				obj.transform.position = vector;
				obj.resetXY();
				playerobj.store += 1;
			}
		}
	}
}

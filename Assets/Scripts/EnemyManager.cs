using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    [SerializeField] private int enemyCount = 5;
    [SerializeField] private FollowEnemy enemyPrefab;
    [SerializeField] private float rotationSmoothingRange = 0.1f;
    [SerializeField] private float speedRange = 1;

    BoxCollider2D box;

    void Start() {
        box = GetComponent<BoxCollider2D>();

        for (int i = 0; i < enemyCount; i++)
        {
            float x = Random.Range(box.bounds.min.x, box.bounds.max.x);
            float y = Random.Range(box.bounds.min.y, box.bounds.max.y);

            FollowEnemy enemy = Instantiate(enemyPrefab, new Vector2(x, y), Quaternion.identity);
            enemy.rotationSmoothing += Random.Range(-rotationSmoothingRange, rotationSmoothingRange);
            enemy.speed += Random.Range(-speedRange, speedRange);
        }
    }

}

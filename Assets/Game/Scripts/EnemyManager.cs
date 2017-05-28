using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    
    void Update()
    {
        if (GameManager.IsPlaying)
        {
            float aleatorio = Random.Range(2, 12);
            for(int i = 0; i < aleatorio; i++)
            {
                CreateEnemy();
            }
        }
    }

    private void CreateEnemy()
    {
        var prefab = Resources.Load("Prefabs/Enemy");
        var enemy = (GameObject)Instantiate(prefab);

        int aletorioX = Random.Range(-500, 500);
        int aletorioY = Random.Range(-500, 500);

        enemy.transform.position = new Vector3(aletorioX,aletorioY,0);
        
    }
}
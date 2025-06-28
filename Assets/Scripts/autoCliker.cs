using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class autoCliker : MonoBehaviour
{
    public GameObject[] spawnableObjects; // Масив префабів об'єктів для спавну
    public RectTransform canvasTransform; // Canvas для спавну об'єктів
    public Vector2[] spawnPositions; // Масив позицій для спавну об'єктів
    public float spawnInterval = 1f; // Інтервал між спавнами в секундах
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnRandomObject();
            timer = 0f;
        }
    }

    public void SpawnRandomObject()
    {
        if (spawnableObjects.Length > 0 && spawnPositions.Length > 0)
        {
            int randomObjectIndex = Random.Range(0, spawnableObjects.Length);
            int randomPositionIndex = Random.Range(0, spawnPositions.Length);

            GameObject newObject = Instantiate(spawnableObjects[randomObjectIndex]);

            RectTransform rectTransform = newObject.GetComponent<RectTransform>();
            if (rectTransform != null)
            {
                // Встановлюємо батьківський об'єкт для UI об'єкта
                rectTransform.SetParent(canvasTransform, false);
                // Перетворюємо Vector2 позицію в позицію UI
                rectTransform.anchoredPosition = spawnPositions[randomPositionIndex];
            }
        }
    }
}

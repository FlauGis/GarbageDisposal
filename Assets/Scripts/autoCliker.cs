using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class autoCliker : MonoBehaviour
{
    public GameObject[] spawnableObjects; // ����� ������� ��'���� ��� ������
    public RectTransform canvasTransform; // Canvas ��� ������ ��'����
    public Vector2[] spawnPositions; // ����� ������� ��� ������ ��'����
    public float spawnInterval = 1f; // �������� �� �������� � ��������
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
                // ������������ ����������� ��'��� ��� UI ��'����
                rectTransform.SetParent(canvasTransform, false);
                // ������������ Vector2 ������� � ������� UI
                rectTransform.anchoredPosition = spawnPositions[randomPositionIndex];
            }
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class SpawnObject : MonoBehaviour
{
    public GameObject[] imagePrefabs; // Array of prefabs of the images to spawn
    public Canvas canvas; // Reference to the Canvas
    public Vector2[] spawnPositions; // Array of positions where to spawn the image

    public void SpawnImage()
    {
        // Choose a random spawn position from the array
        Vector2 spawnPosition = spawnPositions[Random.Range(0, spawnPositions.Length)];

        // Choose a random image prefab from the array
        GameObject imagePrefab = imagePrefabs[Random.Range(0, imagePrefabs.Length)];

        // Instantiate the image prefab at the chosen position
        GameObject newImage = Instantiate(imagePrefab, canvas.transform);
        RectTransform rectTransform = newImage.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = spawnPosition;

        // Apply random rotation
        float randomRotation = Random.Range(0f, 360f);
        rectTransform.rotation = Quaternion.Euler(0, 0, randomRotation);
    }
}

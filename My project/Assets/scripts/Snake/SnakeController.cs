using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SnakeController : MonoBehaviour
{
    public float moveSpeed = 1f;
    public Text scoreText;
    public Button leftButton;
    public Button rightButton;

    private int score = 0;
    private bool canChangeDirection = true;

    void Start()
    {
        StartCoroutine(MoveSnake());

        // Add button click listeners
        leftButton.onClick.AddListener(MoveLeft);
        rightButton.onClick.AddListener(MoveRight);
    }

    void Update()
    {
        // You can handle additional input logic here if needed.
    }

    IEnumerator MoveSnake()
    {
        while (true)
        {
            Vector3 newPosition = transform.position + transform.right * moveSpeed;
            transform.position = newPosition;

            yield return new WaitForSeconds(0.1f); // Adjust the delay based on your desired speed
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Food"))
        {
            Destroy(other.gameObject); // Assuming "Food" is tagged appropriately

            // Increase score and update UI
            score++;
            scoreText.text = "Score: " + score;
        }
        else if (other.CompareTag("Wall"))
        {
            // Game over logic (you can implement your game over screen or reset logic here)
            Debug.Log("Game Over");
            // Example: Reload scene after a delay
            StartCoroutine(ReloadSceneAfterDelay(2f));
        }
    }

    void MoveLeft()
    {
        if (canChangeDirection)
        {
            transform.Rotate(Vector3.forward * 90f);
            canChangeDirection = false;
            StartCoroutine(EnableDirectionChange());
        }
    }

    void MoveRight()
    {
        if (canChangeDirection)
        {
            transform.Rotate(Vector3.back * 90f);
            canChangeDirection = false;
            StartCoroutine(EnableDirectionChange());
        }
    }

    IEnumerator EnableDirectionChange()
    {
        yield return new WaitForSeconds(0.1f); // Adjust the delay based on your desired responsiveness
        canChangeDirection = true;
    }

    IEnumerator ReloadSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DiceRolling : MonoBehaviour
{
    public GameObject dice; // Reference to the dice GameObject
    public Text resultText; // UI element to display dice result
    public AudioSource diceRollSound; // Optional: Sound effect for dice rolling
    private bool isRolling = false;
    public GameObject answerAbackGreen;
    public GameObject answerBbackGreen;
    public GameObject answerCbackGreen;
    public GameObject answerDbackGreen;

    public void RollDice()
    {
        if (isRolling) return; // Prevent multiple rolls at the same time

        isRolling = true;
        StartCoroutine(RollAnimation());
    }

    private IEnumerator RollAnimation()
    {
        diceRollSound?.Play();

        // Simulate the dice rolling animation for 1 second
        for (int i = 0; i < 10; i++)
        {
            int randomRoll = Random.Range(1, 7); // Random number between 1 and 6
            resultText.text = "Rolling... " + randomRoll;
            yield return new WaitForSeconds(0.1f);
        }

        int finalRoll = Random.Range(1, 7); // Final dice roll
        resultText.text = "You rolled: " + finalRoll;
        isRolling = false;

        // Trigger hint based on the dice roll
        TriggerHint(finalRoll);
    }

    private void TriggerHint(int roll)
    {
        switch (roll)
        {
            case 1:
                Debug.Log("Hint: The answer is NOT A.");
                break;
            case 2:
                Debug.Log("Hint: The answer is NOT B.");
                break;
            case 3:
                Debug.Log("Hint: The answer is NOT C.");
                break;
            case 4:
                Debug.Log("Hint: The answer is NOT D.");
                break;
            case 5:
                Debug.Log("Hint: Eliminate two wrong answers.");
                break;
            case 6:
                Debug.Log("Hint: The correct answer is highlighted!");
                HighlightCorrectAnswer();
                break;
            default:
                Debug.Log("No hint available.");
                break;
        }
    }

    private void HighlightCorrectAnswer()
    {
        // Example: Highlight the correct answer
        // string correctAnswer = QuestionGenerate.actualAnswer;
        
    string correctAnswer = 
        QuestionGenerate.displayingQuestion ? QuestionGenerate.actualAnswer :
        QuestionEnt.displayingQuestion ? QuestionEnt.actualAnswer :
        QuestionFoodCulture.displayingQuestion ? QuestionFoodCulture.actualAnswer :
        QuestionHistoryNature.displayingQuestion ? QuestionHistoryNature.actualAnswer :
        null; // Fallback if no question is active

    // Check if a correct answer was retrieved
    if (correctAnswer == null)
    {
        Debug.LogWarning("No active question found to highlight the correct answer.");
        return;
    }

        // Example: Change the button color of the correct answer
        if (correctAnswer == "A") answerAbackGreen.SetActive(true);
        if (correctAnswer == "B") answerBbackGreen.SetActive(true);
        if (correctAnswer == "C") answerCbackGreen.SetActive(true);
        if (correctAnswer == "D") answerDbackGreen.SetActive(true);
    }
}

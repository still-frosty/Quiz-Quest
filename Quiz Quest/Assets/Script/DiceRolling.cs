using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    public Text remainingRollsText; // UI element to display remaining rolls
    public int maxRolls = 3; // Maximum number of times the dice can be used
    private int remainingRolls; // Tracks the remaining rolls

    public TMP_Text pointsText; // UI element to display points
    private int points = 0; // Player's current points
    public TMP_Text bestScoreText; // UI element to display the best score
    private int bestScore = 0; // Player's best score
    private string bestScoreKey = "BestScore";

    public int costPerRoll = 10; // Points required to buy one extra roll

    void Start()
    {
        // Initialize the remaining rolls with maxRolls value
        remainingRolls = maxRolls;
        UpdateRemainingRollsText();
        UpdatePointsText(); // Update the points display

        // Load the best score from PlayerPrefs
        bestScore = PlayerPrefs.GetInt(bestScoreKey, 0);
        // bestScoreText.text = "Best: " + bestScore; // Update the best score display

        if (resultText == null)
        {
            resultText = GameObject.Find("ResultText")?.GetComponent<Text>();
            if (resultText == null)
            {
                Debug.LogError("ResultText GameObject is not found. Please assign it in the Inspector.");
            }
        }
    }
     void Update()
    {
        // Optionally check if rolls are used up and offer to buy more rolls
        if (remainingRolls <= 0)
        {
            BuyMoreRolls();
        }
    }

    public void RollDice()
    {
        if (isRolling || remainingRolls <= 0) return; // Prevent rolling if already rolling or if no rolls left

        isRolling = true;
        StartCoroutine(RollAnimation());
    }

    private IEnumerator RollAnimation()
    {
        // diceRollSound?.Play();

        // Simulate the dice rolling animation for 1 second
        for (int i = 0; i < 10; i++)
        {
            int randomRoll = Random.Range(1, 7); // Random number between 1 and 6
            resultText.text = "Rolling... " + randomRoll;

            // Rotate the dice to simulate rolling
            dice.transform.Rotate(Random.Range(10f, 50f), Random.Range(10f, 50f), Random.Range(10f, 50f));

            yield return new WaitForSeconds(0.1f);
        }

        int finalRoll = Random.Range(1, 7); // Final dice roll
        resultText.text = "You rolled: " + finalRoll;
        isRolling = false;

        // Trigger hint based on the dice roll
        TriggerHint(finalRoll);

        // Reset the dice rotation (set to a fixed value or stop it at a certain angle)
        dice.transform.rotation = Quaternion.Euler(0, 0, 0);  // Reset rotation to initial state (you can adjust as needed)

        // Decrease the number of remaining rolls
        remainingRolls--;
        UpdateRemainingRollsText(); // Update the UI to show remaining rolls

        // Set isRolling back to false, allowing the next roll
        isRolling = false;
    }

    private void TriggerHint(int roll)
    {
        string hintMessage = "";

        switch (roll)
        {
            case 1:
                hintMessage = "Hint: The answer is NOT A.";
                break;
            case 2:
                hintMessage = "Hint: The answer is NOT B.";
                break;
            case 3:
                hintMessage = "Hint: The answer is NOT C.";
                break;
            case 4:
                hintMessage = "Hint: The answer is NOT D.";
                break;
            case 5:
                hintMessage = "Try again next time!";
                break;
            case 6:
                hintMessage = "Hint: The correct answer is highlighted!";
                HighlightCorrectAnswer();
                break;
            default:
                hintMessage = "No hint available.";
                break;
        }

        resultText.text = hintMessage;
    }

    private void HighlightCorrectAnswer()
    {

    string correctAnswer = 
        QuestionGenerate.displayingQuestion ? QuestionGenerate.actualAnswer :
        QuestionEnt.displayingQuestion ? QuestionEnt.actualAnswer :
        QuestionFoodCulture.displayingQuestion ? QuestionFoodCulture.actualAnswer :
        QuestionHistoryNature.displayingQuestion ? QuestionHistoryNature.actualAnswer :
        QuestionsScienceAndTech.displayingQuestion ? QuestionsScienceAndTech.actualAnswer :
        QuestionSportAndGame.displayingQuestion ? QuestionSportAndGame.actualAnswer :
        // QuestionTravelAndCulture.displayingQuestion ? QuestionTravelAndCulture.actualAnswer :
        null; // Fallback if no question is active

    // Check if a correct answer was retrieved
    if (correctAnswer == null)
    {
        Debug.LogWarning("No active question found to highlight the correct answer.");
        return;
    }

        // Example: Change the button color of the correct answer
        if (correctAnswer == "A" && answerAbackGreen != null) answerAbackGreen.SetActive(true);
        if (correctAnswer == "B" && answerBbackGreen != null) answerBbackGreen.SetActive(true);
        if (correctAnswer == "C" && answerCbackGreen != null) answerCbackGreen.SetActive(true);
        if (correctAnswer == "D" && answerDbackGreen != null) answerDbackGreen.SetActive(true);
    }

        // Update the remaining rolls UI
    private void UpdateRemainingRollsText()
    {
        remainingRollsText.text = "Remaining Rolls: " + remainingRolls;
    }

    // Update the points UI
    private void UpdatePointsText()
{
    if (pointsText != null)
    {
        pointsText.text = "Points: " + points;
    }
    else
    {
        Debug.LogError("pointsText is not assigned in the Inspector.");
    }
    // bestScoreText.text = "Best: " + bestScore;
}

    // Add points (you can call this method based on game actions)
    public void AddPoints(int amount)
    {
        points += amount;
        UpdatePointsText(); // Update the points UI
    }

    // Buy more rolls with points
    private void BuyMoreRolls()
    {
        if (bestScore >= costPerRoll) // Ensure player has enough bestScore to buy rolls
        {
            bestScore -= costPerRoll; // Deduct points from bestScore
            remainingRolls++; // Increase remaining rolls
            PlayerPrefs.SetInt(bestScoreKey, bestScore); // Save the updated bestScore in PlayerPrefs
            UpdatePointsText(); // Update the points UI
            UpdateRemainingRollsText(); // Update the remaining rolls UI
            bestScoreText.text = "Best: " + bestScore; // Update best score display
            Debug.Log("You bought more rolls!");
        }
        else
        {
            Debug.Log("Not enough points to buy more rolls!");
        }
    }

}

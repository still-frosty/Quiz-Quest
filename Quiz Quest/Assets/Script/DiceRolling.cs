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
    // public int maxRolls = 3; // Maximum number of times the dice can be used
    private int remainingRolls = 3; // Tracks the remaining rolls
    public TMP_Text cooldownText; 
    private int bestScore = 0; // Player's best score
    private string bestScoreKey = "BestScore";

    public int costPerRoll = 10; // Points required to buy one extra roll
    private bool isOnCooldown = false;         // Track cooldown status
    private float cooldownDuration = 2700f;    // 45 minutes in seconds
    private float cooldownTimeRemaining = 0f;

    void Start()
    {
        UpdateRemainingRollsText();

        if (cooldownText != null)
        {
            cooldownText.text = ""; // Hide cooldown text initially
        }

        if (resultText != null)
        {
            resultText.gameObject.SetActive(false); // Hide result text initially
        }
    }

     void Update()
    {
        if (isOnCooldown)
        {
            // Decrease cooldown time and update the UI
            cooldownTimeRemaining -= Time.deltaTime;
            UpdateCooldownText();

            // If cooldown is over, reset rolls
            if (cooldownTimeRemaining <= 0)
            {
                ResetDiceRolls();
            }
        }
    }

    public void RollDice()
    {
        // Prevent rolling if already rolling, no rolls left, or on cooldown
        if (isRolling || remainingRolls <= 0 || isOnCooldown)
        {
            if (remainingRolls <= 0 && !isOnCooldown)
            {
                StartCooldown();
            }
            return;
        }

        // Decrement remaining rolls immediately, and update the UI
        remainingRolls--;
        UpdateRemainingRollsText();

        // Start the dice rolling process
        StartCoroutine(RollAnimation());
        UpdateUI();
    }

    private System.Collections.IEnumerator SimulateDiceRoll()
    {
        Debug.Log("Rolling the dice...");
        yield return new WaitForSeconds(1); // Simulate rolling delay
        Debug.Log("Dice roll complete.");
        isRolling = false; // Allow rolling again
    }

    private IEnumerator RollAnimation()
    {
        isRolling = true;

        // Simulate dice rolling animation (you can replace this with your animation logic)
        for (int i = 0; i < 10; i++)
        {
            int randomRoll = Random.Range(1, 7); // Random number between 1 and 6
            resultText.text = "Rolling... " + randomRoll;

                // Rotate the dice to simulate rolling
            dice.transform.Rotate(Random.Range(10f, 50f), Random.Range(10f, 50f), Random.Range(10f, 50f));

            yield return new WaitForSeconds(0.1f);
        }

        int diceResult = Random.Range(1, 7); // Roll a number between 1 and 6
        resultText.text = "You rolled: " + diceResult;
        isRolling = false;

        // Trigger hint based on the dice roll
        TriggerHint(diceResult);
        // Reset the dice rotation (set to a fixed value or stop it at a certain angle)
        dice.transform.rotation = Quaternion.Euler(0, 0, 0);  // Reset rotation to initial state (you can adjust as needed)
        Debug.Log("You rolled: " + diceResult);

        // Check if rolls are exhausted and start cooldown
        if (remainingRolls <= 0 && !isOnCooldown)
        {
            StartCooldown();
        }

        DisplayResultText(resultText.text);

        isRolling = false;
    }

     private void DisplayResultText(string hintMessage)
    {
        if (resultText != null)
        {
            resultText.gameObject.SetActive(true); // Make result text visible
            resultText.text = hintMessage;

            // Wait for 5 seconds before hiding the result
            StartCoroutine(HideResultText());
        }
    }

    private IEnumerator HideResultText()
    {
        yield return new WaitForSeconds(5f); // Wait for 1 seconds
        if (resultText != null)
        {
            resultText.gameObject.SetActive(false); // Hide result text
        }
    }

    private void StartCooldown()
    {
        isOnCooldown = true;
        cooldownTimeRemaining = cooldownDuration;
        UpdateCooldownText();
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

    private void ResetDiceRolls()
    {
        isOnCooldown = false;
        remainingRolls = 3;
        UpdateRemainingRollsText();

        if (cooldownText != null)
        {
            cooldownText.text = ""; // Clear cooldown text
        }

        Debug.Log("Dice rolls reset! You can roll again.");
    }

    private void UpdateCooldownText()
    {
        if (cooldownText != null)
        {
            if (cooldownTimeRemaining > 0)
            {
                int minutes = Mathf.FloorToInt(cooldownTimeRemaining / 60);
                int seconds = Mathf.FloorToInt(cooldownTimeRemaining % 60);
                cooldownText.text = $"Next Roll In: {minutes:D2}:{seconds:D2}";
            }
            else
            {
                cooldownText.text = "";
            }
        }
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
        // remainingRollsText.text = "Remaining Rolls: " + remainingRolls;
        if (remainingRollsText != null)
        {
            remainingRollsText.text = "Remaining Rolls: " + remainingRolls;
        }
    }

    // Buy more rolls with points
    private void BuyMoreRolls()
    {
        if (bestScore >= costPerRoll) // Ensure player has enough bestScore to buy rolls
        {
            bestScore -= costPerRoll; // Deduct points from bestScore
            remainingRolls++; // Increase remaining rolls
            PlayerPrefs.SetInt(bestScoreKey, bestScore); // Save the updated bestScore in PlayerPrefs
            // UpdatePointsText(); // Update the points UI
            UpdateRemainingRollsText(); // Update the remaining rolls UI
            // bestScoreText.text = "Best: " + bestScore; // Update best score display
            Debug.Log("You bought more rolls!");
        }
        else
        {
            Debug.Log("Not enough points to buy more rolls!");
        }
        UpdateUI();
    }

    private void UpdateUI()
    {
        // Update the UI elements to reflect current rolls and points
        remainingRollsText.text = "Rolls: " + remainingRolls;
        // pointsText.text = "Points: " + points;
    }

}

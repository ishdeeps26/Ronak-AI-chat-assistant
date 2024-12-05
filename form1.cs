using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Threading;

namespace personal_assistant
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(CurrentUser))
            {
                MessageBox.Show("Access Denied. Please log in first.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                this.Close(); // Close the application if accessed directly
            }
            else
            {
                // Optional: Display a welcome message
                MessageBox.Show($"Welcome, {CurrentUser}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                    
                    ;

            }

            EventHandler form1_load = null;
            this.Load += form1_load;

        }
        public void Form1_Load(object sender, EventArgs e)
        {
            // Add the initial message to the panel after the form is fully loaded
            AddMessageBubble("Hi, how are you? I'm your personal assistant. I can help you.", false);
        }

        
        
            private void AddMessageBubble(string message, bool isUser)
            {
                Console.WriteLine($"Adding message bubble: {message} (isUser: {isUser})");

                Label messageBubble = new Label
                {
                    Text = message,
                    AutoSize = true,
                    MaximumSize = new Size(pnlchathistory.Width - 20, 0), // Wrap text within panel width
                    BackColor = isUser ? Color.LightBlue : Color.LightGray,
                    ForeColor = Color.Black,
                    Padding = new Padding(10),
                    Margin = new Padding(5),
                    BorderStyle = BorderStyle.FixedSingle,
                    TextAlign = isUser ? ContentAlignment.MiddleRight : ContentAlignment.MiddleLeft
                };

                pnlchathistory.Controls.Add(messageBubble); // Add the label to the FlowLayoutPanel
            }

        

        private static readonly HttpClient client = new HttpClient();
       /* private async Task<string> GetChatGPTResponse(string input)
        {
            string apiKey = "your-api-key"; // Replace with your OpenAI API key
            string url = "https://api.openai.com/v1/chat/completions";

            try
            {
                var requestBody = new
                {
                    model = "gpt-4",
                    messages = new[]
                    {
                new { role = "system", content = "You are a helpful assistant." },
                new { role = "user", content = input }
            }
                };

                string json = JsonSerializer.Serialize(requestBody);
                Console.WriteLine("Request Payload: " + json);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                HttpResponseMessage response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Raw Response: " + responseBody);

                var responseObject = JsonSerializer.Deserialize<JsonElement>(responseBody);
                return responseObject.GetProperty("choices")[0]
                                     .GetProperty("message")
                                     .GetProperty("content")
                                     .GetString();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("HTTP Request Error: " + ex.Message);
                return "Network error. Please try again.";
            }
            catch (JsonException ex)
            {
                Console.WriteLine("JSON Parsing Error: " + ex.Message);
                return "Error parsing the response.";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
                return "An unexpected error occurred.";
            }
        }
       */


        public static string CurrentUser { get; set; }

        private void btnsend_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Send button clicked.");

    string userInput = txtuserinput.Text.ToLower(); // Convert input to lowercase for case-insensitive matching

    if (!string.IsNullOrWhiteSpace(userInput))
    {
        // Display the user's message
        AddMessageBubble(userInput, true);

        txtuserinput.Clear(); // Clear the input box

        // Check for a predefined response
        if (hardcodedResponses.ContainsKey(userInput))
        {
            string response = hardcodedResponses[userInput];
            AddMessageBubble(response, false); // Display the assistant's response
        }
        else
        {
            AddMessageBubble("I'm sorry, I don't understand that question.", false); // Default response
        }
    }
    else
    {
        Console.WriteLine("Empty input detected.");
        MessageBox.Show("Please enter a message.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
           /* Console.WriteLine("Send button clicked.");

            string userInput = txtuserinput.Text;

            if (!string.IsNullOrWhiteSpace(userInput))
            {
                // Display the user's message
                AddMessageBubble(userInput, true);

                txtuserinput.Clear(); // Clear the input box

                try
                {
                    Console.WriteLine("Calling API with user input...");
                    string assistantResponse = await GetChatGPTResponse(userInput);

                    // Display the assistant's response
                    AddMessageBubble(assistantResponse, false);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    AddMessageBubble($"Error: {ex.Message}", false);
                }
            }
            else
            {
                Console.WriteLine("Empty input detected.");
                MessageBox.Show("Please enter a message.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Dictionary<string, string> hardcodedResponses = new Dictionary<string, string>
{
    { "hi", "Hello! How can I assist you today?" },
    { "how are you", "I'm just a program, but I'm here to help you!" },
    { "what is the name of the president of america", "The current president of the United States is Donald Trumph." },
    { "what is ai", "AI stands for Artificial Intelligence, the simulation of human intelligence by machines." },
    { "goodbye", "Goodbye! Have a great day!" },
    {"who are you?","I am Ronak AI made for school project. Let me know how can I help you"},
    {"who is your favourite singer", "Diljit Dosanjh is my favourite singer" },
    {"what is your favourite food","I am a AI, I don't eat anything" }

};

    }


}


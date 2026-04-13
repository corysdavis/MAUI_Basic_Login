using System;
using Microsoft.Maui.Graphics;

namespace MauiBasicLogin;

public partial class MainPage : ContentPage
{
    private const string VALID_USER = "Davis";
    private const string VALID_PASS = "Password1";

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        string user = UserNameEntry.Text?.Trim();
        string pass = PasswordEntry.Text;

        if (user == VALID_USER && pass == VALID_PASS)
        {
            ResultLabel.Text = $"Login successful: {user}";
            ResultLabel.TextColor = Colors.Green;
        }
        else
        {
            ResultLabel.Text = $"Login failed: {user}";
            ResultLabel.TextColor = Colors.Red;
        }
    }

    private void OnCancelClicked(object sender, EventArgs e)
    {
        UserNameEntry.Text = string.Empty;
        PasswordEntry.Text = string.Empty;
        ResultLabel.Text = string.Empty;
    }
}
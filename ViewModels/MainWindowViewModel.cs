using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GulmayMC.Models;

namespace GulmayMC.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private string dynamicText = "Initial Text"; // Bound to the new TextBlock (from Lesson 1)

    public string Greeting { get; } = "Welcome to Avalonia!";

    [ObservableProperty] private double selectedNumber = 5.0; // For NumericUpDown (Lesson 2)

    [ObservableProperty] private string? selectedOption; // For ComboBox (Lesson 2)

    public List<string> Options { get; } = new() { "Option 1", "Option 2", "Option 3" }; // For ComboBox (Lesson 2)

    [ObservableProperty] private double sliderValue = 50.0; // For Slider (Lesson 3)

    [ObservableProperty] private string inputText = string.Empty;

    [ObservableProperty] private bool isChecked;

    [RelayCommand]
    private void UpdateText()
    {
        DynamicText =
            $"Text: {InputText} | Checked: {IsChecked} | Selected: {SelectedOption} | Number: {SelectedNumber}";
    }
    
    public ObservableCollection<ItemModel> Items { get; } = new();

    [RelayCommand]
    private void AddItem()
    {
        Items.Add(new ItemModel { Name = InputText, Value = SelectedNumber });
    }
}

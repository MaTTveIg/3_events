using System;

Button button = new(15, true);

button.ChangeSize(5);
button.PushButton();

class Button
{
    public event Action? Notify;
    public int Size { get; set; }
    public bool IsActive { get; set; }
    public Button(int size, bool active)
    {
        Size = size;
        IsActive = active;
    }

    public void ChangeSize(int size)
    {
        Size = size;
        Notify += () => Console.WriteLine($"Size was changed. Size is {Size}");
        Notify.Invoke();
    }

    public void PushButton()    
    {
        if (IsActive == true)
            IsActive = false;
        else IsActive = true;
        Notify += () => Console.WriteLine($"Button was pushed. Button is {IsActive}");
        Notify.Invoke();
    }
}

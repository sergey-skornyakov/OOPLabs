namespace Lab_2;

public struct Time
{
    public int hours;
    public int minutes;
    public int seconds;

    public Time(int hours, int minutes, int seconds)
    {
        this.hours = hours;
        this.minutes = minutes;
        this.seconds = seconds;
    }

    public override string ToString()
    {
        return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
    }

    public void AddSeconds(int secondsToAdd)
    {
        seconds += secondsToAdd;
        while (seconds >= 60)
        {
            seconds -= 60;
            minutes++;
        }
        while (minutes >= 60)
        {
            minutes -= 60;
            hours++;
        }
        while (hours >= 24)
        {
            hours -= 24;
        }
    }
}
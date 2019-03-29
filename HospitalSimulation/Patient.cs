using System;

public class Patient
{
    private int rating, roomTime;
    private static int totalPatientNum;
    private float delayTime;
    Random rnd = new Random();

    public Patient()
	{
        rating = 2;
        roomTime = 45;
        totalPatientNum++;
	}

    public Patient(int[] severityRatings, int[] roomTimes, float[] waitDelays)
    {
        SetRating(severityRatings);
        SetRoomTime(roomTimes);
        SetDelayTime(waitDelays);
    }

    public int GetRating()
    {
        return rating;
    }

    public float GetDelayTime()
    {
        return delayTime;
    }

    public int GetPatientNum()
    {
        return totalPatientNum;
    }

    private void SetRating(int[] severityRatings)
    {
        int rand = rnd.Next(1, 100);
        for (int i = 0; i < severityRatings.Length; i++)
        {
            if (rand < severityRatings[i])
            {
                rating = i;
                break;
            }
            else rand -= severityRatings[i];
        }
    }

    private void SetRoomTime(int[] roomTimes)
    {

        switch (rating)
        {        //Sets roomTimer based on priority rating
            case 1:
                roomTime = roomTimes[0];
                break;
            case 2:
                roomTime = roomTimes[1];
                break;
            case 3:
                roomTime = roomTimes[2];
                break;
            case 4:
                roomTime = roomTimes[3];
                break;
            default:
                roomTime = 0;
                break;
        }

        if (rnd.Next(100) < 20)     //20% chance of extra time
            roomTime += (int)((float)roomTime * ((float)rnd.Next(100) / 200.0));   //Add up to 50% more time
    }

    private void SetDelayTime(float[] waitDelays)
    {
        float totalDelay = waitDelays[1] - waitDelays[0];
        delayTime = totalDelay * (rnd.Next(100) / (float)100.0);
    }
}

using System;

public class Patient
{
    public int roomTime;
    private int 
        rating, 
        arrivalTime,
        waitLength,
        priorityNum;
    private static int totalPatientNum;
    private float delayTime;
    Random rnd = new Random();

    //Default constructor 
    public Patient()
	{
        rating = 2;
        roomTime = 45;
        totalPatientNum++;
	}

    //Constructor used to crete random patient
    public Patient(ref int[] severityRatings, ref int[] roomTimes, ref float[] waitDelays)
    {
        SetRating(ref severityRatings);
        SetRoomTime(ref roomTimes);
        SetDelayTime(ref waitDelays);
    }

    //returns rating of patient
    public int GetRating()
    {
        return rating;
    }

    //returns time gap between patients
    public float GetDelayTime()
    {
        return delayTime;
    }

    //returns patient number by when it arrived
    public int GetPatientNum()
    {
        return totalPatientNum;
    }

    //Get Priority Number
    public int GetPriorityNum()
    {
        return priorityNum;
    }
    public void AddWaitLength(int time)
    {
        waitLength += time;
    }

    //sets the time the patient arrived at the hospital
    public void SetArrivalTime(ref int localTime)
    {
        arrivalTime = localTime;
    }

    //Determines how long a patient waited and returns how long it will be in a room
    public int Roomed(ref int localTime)
    {
        waitLength = localTime - arrivalTime;
        return roomTime;
    }

    //randomly assigns a rating to the patient
    private void SetRating(ref int[] severityRatings)
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

    //Assigns appropriate room time with a chance of increased time
    private void SetRoomTime(ref int[] roomTimes)
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

    //randomly assigns time gap between patients
    private void SetDelayTime(ref float[] waitDelays)
    {
        float totalDelay = waitDelays[1] - waitDelays[0];
        delayTime = (totalDelay * (rnd.Next(100) / (float)100.0));
    }
}

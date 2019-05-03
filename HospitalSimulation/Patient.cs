using System;

public class Patient
{
    public int roomTimeManip;
    private int 
        rating, 
        arrivalTime,
        roomedTime,
        waitLength,
        priorityNum,
        patientNumber,
        roomTime;
    private static int totalPatientNum;
    private float delayTime;
    Random rnd;

    //Default constructor 
    public Patient()
	{
        rating = 2;
        roomTime = 45;
        totalPatientNum++;
	}

    public Patient(Boolean createNew)
    {
        rating = 0;
        roomTime = 0;
        waitLength = 0;
        delayTime = 0;
    }

    //Constructor used to crete random patient
    public Patient(ref int[] severityRatings, ref int[] roomTimes, ref float[] waitDelays, ref Random rnd)
    {
        this.rnd = rnd;
        SetRating(ref severityRatings);
        SetRoomTime(ref roomTimes);
        SetDelayTime(ref waitDelays);
        totalPatientNum++;
        roomTimeManip = roomTime;
    }

    public Patient(ref int[] severityRatings, ref int[] roomTimes, ref float[] waitDelays, int patientNumber, ref Random rnd)
    {
        this.rnd = rnd;
        SetRating(ref severityRatings);
        SetRoomTime(ref roomTimes);
        SetDelayTime(ref waitDelays);
        totalPatientNum++;
        this.patientNumber = patientNumber;
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
        return patientNumber;
    }

    public int GetTotalPatients()
    {
        return totalPatientNum;
    }

    //Get Priority Number
    public int GetPriorityNum()
    {
        return priorityNum;
    }

    public int GetPriority(int localTime)
    {
        return (localTime - arrivalTime) * rating;
    }

    public int GetPriorityQueue(int localTime)
    {
        return ((localTime - arrivalTime) * 4 + rating * 100) / ((localTime - arrivalTime) + 100);
    }

    public int GetWaitTime(ref int localTime)
    {
        return localTime - arrivalTime;
    }

    public float GetWaitLength(float time)
    {
        System.Diagnostics.Debug.Write("wait time:\t");
        System.Diagnostics.Debug.Write(time +" "+ arrivalTime);
        System.Diagnostics.Debug.WriteLine("\t" + rating);
        return time-arrivalTime - roomTime;
    }
    public float GetWaitLengthFinal(float time)
    {
        System.Diagnostics.Debug.Write("wait time:\t");
        System.Diagnostics.Debug.Write(time - arrivalTime);
        System.Diagnostics.Debug.WriteLine("\t" + rating+" Final");
        return time - arrivalTime + (roomTimeManip - roomTime);
    }
    //sets the time the patient arrived at the hospital
    public void SetArrivalTime(int localTime)
    {
        arrivalTime = localTime;
    }

    public int GetArrivalTime()
    {
        return arrivalTime;
    }
    //Determines how long a patient waited and returns how long it will be in a room
    public int Roomed(ref int localTime)
    {
        waitLength = localTime - arrivalTime;
        roomedTime = localTime;
        return roomTime;
    }

    public Boolean TimeUp(int localTime)
    {
        if(localTime > (roomedTime + (roomTime * 10)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //randomly assigns a rating to the patient
    private void SetRating(ref int[] severityRatings)
    {
        int rand = rnd.Next(1, 100);
        for (int i = 0; i < severityRatings.Length; i++)
        {
            if (rand < severityRatings[i])
            {
                rating = (i + 1);
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

       // if (rnd.Next(100) < 20)     //20% chance of extra time
       //     roomTime += (int)((float)roomTime * ((float)rnd.Next(100) / 200.0));   //Add up to 50% more time
    }

    //randomly assigns time gap between patients
    private void SetDelayTime(ref float[] waitDelays)
    {
        float totalDelay = waitDelays[1] - waitDelays[0];
        delayTime = waitDelays[0] + (totalDelay * (rnd.Next(100) / (float)100.0));
    }
}

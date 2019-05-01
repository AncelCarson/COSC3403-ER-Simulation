using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSimulation
{
    class PatientQueue
    {
        
        private int size;
        private int index;
        private Patient[] queue;
        private Patient[] tempQ;
        private Patient tempP;
        private int rooms;
        private float rat1 = 0;
        private float rat2 = 0;
        private float rat3 = 0;
        private float rat4 = 0;
        private float wait1 = 0;
        private float wait2 = 0;
        private float wait3 = 0;
        private float wait4 = 0;
        private Random rnd;

        public PatientQueue(int rooms, ref Random rnd)
        {
            this.rooms = rooms;
            size = 50;
            index = 0;
            queue = new Patient[size];
            this.rnd = rnd;
        }

        public Patient AddPatient(ref int[] severityRatings, ref int[] roomTimes, ref float[] waitDelays)
        {
            System.Diagnostics.Debug.WriteLine(index);
            if (size == index + 1)
            {
                Resize();
            }
            if (index < rooms - 1)
            {
                for (int i = 0; i < index; i++)
                {
                    if (queue[i] == null)
                    {
                        queue[i] = new Patient(ref severityRatings, ref roomTimes, ref waitDelays, ref rnd);
                        return queue[index];
                    }
                }

                queue[index] = new Patient(ref severityRatings, ref roomTimes, ref waitDelays, ref rnd);
                index++;
                return queue[index];
            }
            else
            {
                queue[index] = new Patient(ref severityRatings, ref roomTimes, ref waitDelays, ref rnd);
                index++;
                return queue[index];
            }
        }

        private void Resize()
        {
            tempQ = queue;
            queue = new Patient[size+(int)size/20];
            size = size + (int)size / 20;
            for(int i = 0; i <= index; i++)
            {
                queue[i] = tempQ[i];
            }
        }

        public int GetSize()
        {
            return index;
        }

        public Patient GetPatient (int position)
        {
            return queue[position - 1];
        }

        public void SortQueue(int time)
        {
            //Might need to be >=
            for(int i = index-1; i >= rooms; i--)
            {
                System.Diagnostics.Debug.WriteLine(i);
                if (queue[i].GetRating() == 4)
                {
                    if (queue[i-1].GetRating() != 4)
                    {
                        tempP = queue[i - 1];
                        queue[i - 1] = queue[i];
                        queue[i] = tempP;
                    }
                }
                else if(queue[i].GetPriority(time) > queue[i - 1].GetPriority(time))
                {
                    tempP = queue[i - 1];
                    queue[i - 1] = queue[i];
                    queue[i] = tempP;
                }
            }
        }

        public void RemovePatient(int position)
        {

            switch (queue[position-1].GetRating())
            {
                case 1: rat1++; wait1 += queue[position - 1].GetWaitLength(); break;
                case 2: rat2++; wait2 += queue[position - 1].GetWaitLength(); break;
                case 3: rat3++; wait3 += queue[position - 1].GetWaitLength(); break;
                case 4: rat4++; wait4 += queue[position - 1].GetWaitLength(); break;
            }
            if (queue[rooms] != null)
            {
                queue[position - 1] = queue[rooms];
                for(int i = rooms; i < index; i++)
                {
                    queue[i] = queue[i + 1];
                }
                index--;
            }
            else
            {
                queue[position - 1] = null;
            }
        }

        private void FinishAdding()
        {
            for(int i = 0; i > rooms; i++)
            {
                switch (queue[i].GetRating())
                {
                    case 1: rat1++; wait1 += queue[i].GetWaitLength(); break;
                    case 2: rat2++; wait2 += queue[i].GetWaitLength(); break;
                    case 3: rat3++; wait3 += queue[i].GetWaitLength(); break;
                    case 4: rat4++; wait4 += queue[i].GetWaitLength(); break;
                }
            }
        }

        public float GetAvgWait1()
        {

            return (wait1) / rat1;
        }
        public float GetAvgWait2()
        {
            return (wait2) / rat2;
        }
        public float GetAvgWait3()
        {
            return (wait3) / rat3;
        }
        public float GetAvgWait4()
        {
            return (wait4) / rat4;
        }

    }
}

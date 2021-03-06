﻿using System;
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
        private float finishTime;

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
                /*if (queue[i].GetRating() == 4)
                {
                    if (queue[i-1].GetRating() != 4)
                    {
                        tempP = queue[i - 1];
                        queue[i - 1] = queue[i];
                        queue[i] = tempP;
                    }
                }
                else*/ if(queue[i].GetArrivalTime() <= time)
                {
                    if(queue[i].GetPriorityQueue(time) > queue[i - 1].GetPriorityQueue(time))
                    {
                        tempP = queue[i - 1];
                        queue[i - 1] = queue[i];
                        queue[i] = tempP;
                    }
                }
            }
        }

        public void RemovePatient(int position, float time)
        {
            //System.Diagnostics.Debug.Write("remove time: ");
            //System.Diagnostics.Debug.WriteLine(time);
            switch (queue[position-1].GetRating())
            {
                case 1: rat1++; wait1 += queue[position - 1].GetWaitLength(time); break;
                case 2: rat2++; wait2 += queue[position - 1].GetWaitLength(time); break;
                case 3: rat3++; wait3 += queue[position - 1].GetWaitLength(time); break;
                case 4: rat4++; wait4 += queue[position - 1].GetWaitLength(time); break;
            }
            if (queue[rooms] != null)
            {
                queue[position - 1] = queue[rooms];
                //System.Diagnostics.Debug.WriteLine(queue[rooms].GetArrivalTime());
                for (int i = rooms; i < index; i++)
                {
                    //System.Diagnostics.Debug.WriteLine(queue[i].GetArrivalTime());
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
            for(int i = 0; i < rooms; i++)
            {
                if (queue[i] != null)
                {
                    switch (queue[i].GetRating())
                    {
                        case 1: rat1++; wait1 += queue[i].GetWaitLengthFinal(finishTime); break;
                        case 2: rat2++; wait2 += queue[i].GetWaitLengthFinal(finishTime); break;
                        case 3: rat3++; wait3 += queue[i].GetWaitLengthFinal(finishTime); break;
                        case 4: rat4++; wait4 += queue[i].GetWaitLengthFinal(finishTime); break;
                    }
                }
            }
        }

        public int GetAvgWait1(float time)
        {
            finishTime = time;
            FinishAdding();
            System.Diagnostics.Debug.Write(wait1 + " ");
            System.Diagnostics.Debug.WriteLine(rat1);
            if (wait1==0 && rat1 ==0)
            {
                return 0;
            }
            return (int)((wait1) / rat1);
        }
        public int GetAvgWait2()
        {
            System.Diagnostics.Debug.Write(wait2+" ");
            System.Diagnostics.Debug.WriteLine(rat2);
            if (wait2 == 0 && rat2 == 0)
            {
                return 0;
            }
            return (int)((wait2) / rat2);
        }
        public int GetAvgWait3()
        {
            System.Diagnostics.Debug.Write(wait3+" ");
            System.Diagnostics.Debug.WriteLine(rat3);
            if (wait3 == 0 && rat3 == 0)
            {
                return 0;
            }
            return (int)((wait3) / rat3);
        }
        public int GetAvgWait4()
        {
            System.Diagnostics.Debug.Write(wait4+" ");
            System.Diagnostics.Debug.WriteLine(rat4);
            if (wait4 == 0 && rat4 == 0)
            {
                return 0;
            }
            return (int)((wait4) / rat4);
        }

    }
}

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

        public PatientQueue(int rooms)
        {
            this.rooms = rooms;
            size = 50;
            index = 0;
            queue = new Patient[size];
        }

        public Patient AddPatient(ref int[] severityRatings, ref int[] roomTimes, ref float[] waitDelays)
        {
            if(size == index + 1)
            {
                Resize();
            }
            if (index < rooms - 1)
            {
                for (int i = 0; i < index; i++)
                {
                    if (queue[i] == null)
                    {
                        queue[i] = new Patient(ref severityRatings, ref roomTimes, ref waitDelays);
                        return queue[index];
                    }
                }

                queue[index] = new Patient(ref severityRatings, ref roomTimes, ref waitDelays);
                index++;
                return queue[index];
            }
            else
            {
                queue[index] = new Patient(ref severityRatings, ref roomTimes, ref waitDelays);
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
            return size;
        }

        public Patient GetPatient (int position)
        {
            return queue[position - 1];
        }

        public void SortQueue()
        {
            //Might need to be >=
            for(int i = index; i >= rooms; i--)
            {
                if (queue[i].GetPriorityNum() > queue[i - 1].GetPriorityNum())
                {
                    tempP = queue[i - 1];
                    queue[i - 1] = queue[i];
                    queue[i] = tempP;
                }
            }
        }

        public void RemovePatient(int position)
        {
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

    }
}

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

        PatientQueue(int rooms)
        {
            this.rooms = rooms;
            size = 50;
            index = 0;
            queue = new Patient[size];
        }

        public float AddPatient(ref int[] severityRatings, ref int[] roomTimes, ref float[] waitDelays)
        {
            if(size == index + 1)
            {
                Resize();
            }
            queue[index] = new Patient(ref severityRatings, ref roomTimes, ref waitDelays);
            index++;
            return 8;
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

        public Patient GetPatient (int position)
        {
            return queue[position - 1];
        }

        public void SortQueue()
        {
            //Might need to be >=
            for(int i = index; i >= this.rooms; i--)
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
                    queue[i + 1] = queue[i];
                }
            }
            else
            {
                queue[position - 1] = null;
            }
        }

    }
}

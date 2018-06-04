using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rs232app
{
    class Frame
    {
        public String Begin { get; set; } = String.Empty;
        public String Length { get; set; } = String.Empty;
        public String Command { get; set; } = String.Empty;
        public List<UInt16> DataList { get; set; } = new List<UInt16>();
        public String CheckSumOne { get; set; } = String.Empty;
        public String CheckSumTwo { get; set; } = String.Empty;

        public String PrintFrame()
        {
            String frame = String.Empty;
            frame += "[";
            frame += Begin;
            frame += "|";
            frame += Length;
            frame += "|";
            frame += Command;
            frame += "|";
            foreach (UInt16 i in DataList)
            {
                String hexValue = String.Format("{0:x2}", i);
                frame += hexValue;
                frame += "|";
            }
            frame += CheckSumOne;
            frame += "|";
            frame += CheckSumTwo;
            frame += "]";
            return frame;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement_Loop_Generator_2._0
{
    struct DataStruct
    {
        public string Name;
        public string Author;
        public float XLoc;
        public float YLoc;
        public float ZLoc;
        public int Speed;
        public int Delay;
        public string Function;


        public DataStruct(string name, string author, float xloc, float yloc, float zloc, int speed, int delay, string function)
        {
            Name = name;
            Author = author;
            XLoc = xloc;
            YLoc = yloc;
            ZLoc = zloc;
            Speed = speed;
            Delay = delay;
            Function = function;
        }

        public string mName
        {
            get { return Name; }
            set { Name = value; }
        }
        public float mXLoc
        {
            get { return XLoc; }
            set { XLoc = value; }
        }
        public float mYLoc
        {
            get { return YLoc; }
            set { YLoc = value; }
        }
        public float mZLoc
        {
            get { return ZLoc; }
            set { ZLoc = value; }
        }
        public int mSpeed
        {
            get { return Speed; }
            set { Speed = value; }
        }
        public int mDelay
        {
            get { return Delay; }
            set { Delay = value; }
        }
        public string mFunction
        {
            get { return Function; }
            set { Function = value; }
        }
    }
}
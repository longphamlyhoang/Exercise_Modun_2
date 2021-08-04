using System;
namespace Object
{
    class Shape
    {
        private string color = "green";
        private bool filled = true;
        public Shape()
        {

        }
        public Shape( String color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }
        public String GetColor()
        {
            return this.color;
        }
        public void SetColor(String color)
        {
            this.color = color;
        }
        public bool GetFilled()
        {
            return this.filled;
        }
        public void SetFilled(bool filled)
        {
            this.filled = filled;
        }
        public override String ToString()
        {
            return $"A shape with color of {GetColor()} and {(GetFilled()?"filled":"not filled")}";
        }

    }
}
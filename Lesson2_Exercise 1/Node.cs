namespace Lesson2_Exercise_1
{

    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
        public int Count { get; set; }

        public Node(int value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return Value.ToString();
        }

    }
}

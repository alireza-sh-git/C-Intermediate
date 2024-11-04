namespace Lessons
{
    public class Stack
    {
        private List<object> list;

        public Stack()
        {
            list = new List<object>();
        }
        public void Push(object input)
        {
            list.Add(input);
        }
        public object Pop()
        {
            if (list.Count > 0)
            {
                object output = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                return output;
            }
            else throw new InvalidOperationException("List is empty.");

        }
        public void Clear()
        {
            list.Clear();
        }
    }




}
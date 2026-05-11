namespace DoubleList;

public class DoubleLinkedList<T>
{
    private Node<T> _head;
    private Node<T> _tail;

    public DoubleLinkedList()
    {
        _head = null;
        _tail = null;
    }

    public void AddOccurrence(T data)
    {
        var newNode = new Node<T>(data);

        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
            return;
        }

        Node<T> current = _head;

        if (Comparer<T>.Default.Compare(data, _head.Data) < 0)
        {
            newNode.Next = _head;
            _head.Previous = newNode;
            _head = newNode;
            return;
        }

        while (current.Next != null &&
               Comparer<T>.Default.Compare(current.Next.Data, data) < 0)
        {
            current = current.Next;
        }

        newNode.Next = current.Next;
        newNode.Previous = current;

        if (current.Next != null)
        {
            current.Next.Previous = newNode;
        }
        else
        {
            _tail = newNode;
        }

        current.Next = newNode;
    }

    public string ShowForward()
    {
        if (_head == null)
            return "null";

        var current = _head;
        string result = "";

        while (current != null)
        {
            result += $"{current.Data} -> ";
            current = current.Next;
        }

        result += "null";

        return result;
    }

    public void ShowBackward()
    {
        Node<T>? previous = null;
        var current = _head;

        while (current != null)
        {
            var next = current.Next;
            current.Next = previous;
            previous = current;
            current = next;
        }

        _head = previous;
    }

    public void ToOrder()
    {
        var current = _head;

        while (current != null)
        {
            var temp = current.Next;
            current.Next = current.Previous;
            current.Previous = temp;

            current = temp;
        }

        var aux = _head;
        _head = _tail;
        _tail = aux;
    }

    public List<T> Fashion()
    {
        List<T> fashions = new();

        if (_head == null)
            return fashions;

        Dictionary<T, int> counts = new();

        Node<T>? current = _head;

        while (current != null)
        {
            if (counts.ContainsKey(current.Data))
                counts[current.Data]++;
            else
                counts[current.Data] = 1;

            current = current.Next;
        }

        int maxCount = 0;

        foreach (var item in counts)
        {
            if (item.Value > maxCount)
            {
                maxCount = item.Value;
            }
        }

        foreach (var item in counts)
        {
            if (item.Value == maxCount)
            {
                fashions.Add(item.Key);
            }
        }

        return fashions;
    }

    public string Chart()
    {
        if (_head == null)
            return "Lista vacía";

        Dictionary<T, int> counts = new();

        Node<T>? current = _head;

        while (current != null)
        {
            if (counts.ContainsKey(current.Data))
                counts[current.Data]++;
            else
                counts[current.Data] = 1;

            current = current.Next;
        }

        string result = "";

        foreach (var item in counts)
        {
            result += $"{item.Key} ";

            for (int i = 0; i < item.Value; i++)
            {
                result += "*";
            }

            result += "\n";
        }

        return result;
    }

    public bool ItExists(T data)
    {
        var current = _head;

        while (current != null)
        {
            if (current.Data != null && current.Data.Equals(data))
            {
                return true;
            }

            current = current.Next;
        }

        return false;
    }

    public void DeleteOccurrence(T data)
    {
        if (_head == null) return;

        if (_head.Data != null && _head.Data.Equals(data))
        {
            _head = _head.Next;

            if (_head != null)
            {
                _head.Previous = null;
            }
            else
            {
                _tail = null;
            }

            return;
        }

        var current = _head;

        while (current.Next != null)
        {
            if (current.Next.Data != null && current.Next.Data.Equals(data))
            {
                var nodeToDelete = current.Next;

                current.Next = nodeToDelete.Next;

                if (nodeToDelete.Next != null)
                {
                    nodeToDelete.Next.Previous = current;
                }
                else
                {
                    _tail = current;
                }

                return;
            }

            current = current.Next;
        }
    }

    public void RemoveAllOccurrences()
    {
        _head = null;
        _tail = null;
    }

    public override string ToString()
    {
        var current = _head;
        var result = "";

        while (current != null)
        {
            result += $"{current.Data} -> ";
            current = current.Next;
        }

        result += "null";

        return result;
    }

    public string ToStringReverse()
    {
        var current = _tail;
        var result = string.Empty;

        while (current != null)
        {
            result += $"{current.Data} -> ";
            current = current.Previous;
        }

        result += "null";

        return result;
    }
}
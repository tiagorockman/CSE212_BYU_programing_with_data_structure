public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if(value == Data)
        {
            // Do not insert duplicates
            return;
        }
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if(value == Data)
        {
            return true;
        }
        if (value < Data)
        {
            // Search to the left
            if(Left == null)
                return false;


              return Left.Contains(value);
        }
        else
        {
            // Search to the right
            if(Right == null)
                return false;
           
            return Right.Contains(value);
        }

    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int lefheight = 0;
        int righheight = 0;

        if(Left is not null )
            lefheight = Left.GetHeight();

        if( Right is not null )
            righheight = Right.GetHeight();

        return Math.Max(lefheight, righheight) + 1; // Replace this line with the correct return statement(s)
    }
}
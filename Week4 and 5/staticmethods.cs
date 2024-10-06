private static bool SearchDiagonalComplete(int[,] ints, int size, int which)
{
    //Top left to bottom right
    bool foundit = true;
    for (int i = 0; i < size; i++)
    {
        if (ints[i, i] != which)
        {
            foundit = false;
            break;
        }
    }
    if (foundit)
        return true;
    //Top right to bottom left
    foundit = true;
    for (int i = size - 1; i >= 0; i--)
    {
        if (ints[i, size - 1 - i] != which)
        {
            foundit = false;
            break;
        }
    }
    if (foundit)
        return true;
    return false;
}

private static bool SearchColsComplete(int[,] ints, int size, int which)
{
    //Search for a completed column for the specified player
    for (int i = 0; i < size; i++)
    {
       bool found = true;
        for (int j = 0; j < size; j++)
        {
            if (ints[j, i] != which)
            {
                found = false;
                break;
            }
        }
        if (found)
        {
            return true;
        }
    }
    //If a completed column has not been found here, then return false
    return false;
}

private static bool SearchRowsComplete(int[,] ints, int size, int which)
{
    for (int i = 0; i < size; i++)
    {
        bool found = true;
        for (int j = 0; j < size; j++)
        {
            if (ints[i, j] != which)
            {
                found = false;
                break;
            }
        }
        if (found)
            return true;
    }
    //If a completed row has not been found here, then return false
    return false;
}
private static bool FindinArray(int[,] ints, int size, int which)
{
    bool foundit = false;
    for (int i = 0; i < size; ++i)
    {
        for (int j = 0; j < size; j++)
        {
            if (ints[i, j] == which)
            {
                foundit = true;
                break;
            }
        }
        if (foundit)
            break;
    }
    return foundit;
}

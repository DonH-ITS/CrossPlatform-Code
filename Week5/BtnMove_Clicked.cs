private void BtnMove_Clicked(object sender, EventArgs e)
{
    int row, column;
    //Try Parse is another way to convert from string to integer, it checks whether the parse can work first instead of just crashing
    //int.TryParse(string, out) is the form of it
    //If it can parse it returns true and assigns the integer to the output variable
    //If it cannot parse it returns false and assigns 0 to the output variable
    if (!int.TryParse(EntryC.Text, out column) || !int.TryParse(EntryR.Text, out row))
    {
        //If either entry cannot be parsed, we exit out of the method by just using return;
        //No feedback will be given to the user
        return;
    }
    //We need to subtract one from each of column and row if it has got this far
    --column;
    --row;

    //Make sure we are within the limits of the grid
    if (column > numbrows || column < 0 || row > numbrows || row < 0)
        return;

    //We are going to do a loop over all the Children of the grid finding all the objects that are there, looking for a match
    foreach (var item in GridPageContent.Children)
    {
        //We only want to search borders, so ignore all other types of items
        if (item.GetType() == typeof(Border))
        {
            //Cast the object to type Border so we can use all the Frame attributes and methods
            Border border = (Border)item;

            //Search for a match, if we find one, do the move and exit out of the loop with break
            if (column == Convert.ToInt32(border.GetValue(Grid.ColumnProperty).ToString()) && row == Convert.ToInt32(border.GetValue(Grid.RowProperty).ToString()))
            {
                DoMove(border);
                break;
            }
        }
    }
}

private void DoMove(Border border){
	if (player == 1)
	{
		border.BackgroundColor = Color.FromRgb(0, 255, 0);
		player = 2;
	}
	else
	{
		border.BackgroundColor = Color.FromRgb(0, 0, 255);
		player = 1;
	}
	whichplayerlabel.Text = "Player " + player + "'s Turn";
}

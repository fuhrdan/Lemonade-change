//*****************************************************************************
//** 860. Lemonade Change  leetcode                                          **
//** Solution using a hash table.                                   -Dan     **
//*****************************************************************************

bool lemonadeChange(int* bills, int billsSize) {
    int change[4] = {0};
    for(int i = 0; i < billsSize; i++)
    {
        if(bills[i]==5) 
        {
            change[0]++;
        }
        if(bills[i]==10) 
        {
            change[1]++;
            change[0]--;
        }
        if(bills[i]==20) 
        {
            change[2]++;
            if(change[1] > 0)
            {
                change[1]--;
                change[0]--;
            }
            else
            {
                change[0]--;
                change[0]--;
                change[0]--;
            }
        }
        if(change[0] < 0) return 0;
    }
    return 1;
}
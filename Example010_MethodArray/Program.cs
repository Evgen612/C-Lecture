int [] array = {1, 9, 12, 45, 88, 102, 45, 12, 54};

int n = array.Length;
int find = 45;

int index = 0;

while (index < n)
{
        if(array[index] == find)
        {
            Console.WriteLine(index);
        } 
    index++;
}


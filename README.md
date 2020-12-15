# Optimization of memory acceessing
This simple program written on C# demonstrates how dramaticaly worse your code can perform if you not considering sequential locality.

### Before optimization
```
        int[,,] b = new int[1000, 1000, 1000];
        int res = 0;

        for (int j = 0; j < 1000; j++)
        {
            for (int i = 0; i < 1000; i++)
            {
                for (int k = 0; k < 1000; k++)
                {
                    b[k, i, j]++;
                }
            }
        }
```
![](img/img1.png) 


### After optimization
```
        int[,,] b = new int[1000, 1000, 1000];
        int res = 0;

        for (int j = 0; j < 1000; j++)
        {
            for (int i = 0; i < 1000; i++)
            {
                for (int k = 0; k < 1000; k++)
                {
                    b[j, i, k]++;
                }
            }
        }
```
![](img/img2.png) 

### Conclusion
How we can see first code performs worse. Thats because in reality n-dimensional arrays store data in 1-dimensional array and accessing it this way:
```
array[i,j,k] is the same as array[i * N + j * M + k] where N,M - sizes of dimensions
```


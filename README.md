﻿# date-range-app

Application prints date range in console accepts two input parameters:  
- [date1]: must be a earlier than [date2]  
- [date2]: must be a later than [date1]

[date1] and [date2] arguments must contain the representation of a date dd.MM.yyyy like '01.01.2021'  
to run the application type ./DateRangeApp.exe [date1] [date2]  

exaples:  
./DateRangeApp.exe 01.01.2017 05.01.2017  
*01-05.01.2017*

./DateRangeApp.exe 01.01.2017 05.02.2017  
*01.01–05.02.2017*

./DateRangeApp.exe 01.01.2016 05.01.2017  
*01.01.2016–05.01.2017*

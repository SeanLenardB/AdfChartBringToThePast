# AdfChartBringToThePast
Very self-explanatory chart converter
If you open a chart and see an error/exception, which contains something like "value cannot be null", you might need this.

How this thing works:

Newer (>2.6.0) Adofai use true and false (booleans) to store data, while older (<2.5.0) versions use "Enabled" and "Disabled" to do so.

How to use:

Download and open the console app. Drag & Drop the .adofai file in, and hit enter, then a file with name "..._converted.adofai" can be found. Use the converted chart and Adofai will happily accept it.

Remember that although this solution works 99% of the time, it's still possible for some newer charts to use some events that are not valid in older versions, such as Icyxis True Ending which use object decorations. For those you might use a text editor to remove them in order to open them properly.

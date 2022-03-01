# NeoCortexApi - To Implement Trace SDR Method

The goal of our project is to implement the well-formatted tracing of multiple SDRs that we will get using StringifyVector() method, so they can be easily compared in the output window.


## Project Description 
In this project we have to trace out the SDr values using the below mentioned method
Helpers.StringifyVector(lyrOut.PredictiveCells.Select(c => c.Index).ToArray())

## The SDR value will get from creating a new StrongifyVector() method:
51, 76, 87, 113, 116, 118, 122, 152, 156, 163, 179, 181, 183, 186, 188, 190, 195, 210, 214, 224,
51, 76, 113, 116, 118, 156, 163, 179, 181, 182, 183, 186, 188, 190, 195, 197, 210, 214, 224, 243

After this we need to add a space or any pading text to create a well format look of SDR values and it should look lie this:
51, 76, 87, 113, 116, 118, 122, 152, 156, 163, 179, 181,  ,183, 186, 188, 190, 195,   ,210, 214, 224,
51, 76,   ,113, 116, 118,   ,156, 163, 179, 181, 182, 183, 186, 188, 190, 195, 197, 210, 214, 224, 243



## Our Approach


The Output result:

![2022-02-26_15-13-43](https://user-images.githubusercontent.com/45165287/156222474-3dca0271-0874-45c4-8197-2b8de0d385b5.png)

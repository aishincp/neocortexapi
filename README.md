# NeoCortexApi - To Implement Trace SDR Method

The goal of our project is to implement the well-formatted tracing of multiple SDRs that we will get using StringifyVector() method, so they can be easily compared in the output window.


## Project Description 
In this project we have to trace out the SDr values using the below mentioned method
Helpers.StringifyVector(lyrOut.PredictiveCells.Select(c => c.Index).ToArray())

## The SDR value will get from creating a new StrongifyVector() method:
51, 76, 87, 113, 116, 118, 122, 152, 156, 163, 179, 181, 183, 186, 188, 190, 195, 210, 214, 224,

51, 76, 113, 116, 118, 156, 163, 179, 181, 182, 183, 186, 188, 190, 195, 197, 210, 214, 224, 243

After this we need to add a space or any pading text to create a well format look of SDR values and it should look like what we got in our output result.



## Our Approach

To print this SDR values as mentioned above, we created a new Stringify() method with two sdrs in list such like this:

![2022-02-26_15-14-06](https://user-images.githubusercontent.com/45165287/156222938-6feee543-24c4-4b81-b7f2-f16b58bdd9d1.png)

The Output result:

![2022-02-26_15-13-43](https://user-images.githubusercontent.com/45165287/156222474-3dca0271-0874-45c4-8197-2b8de0d385b5.png)


## New Improvizations

Now the Output is well-formatted with a space/padding as shown: 
![2022-03-06_20-51-26](https://user-images.githubusercontent.com/45165287/156941160-ac866d63-f13b-43ff-8635-f16950a09f77.png)

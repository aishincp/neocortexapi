# Implement Trace SDR Method

#### The goal of this project is to implement the well-formatted tracing of multiple SDRs 

## Project Description 
## Aim:
In Hirarchical Temporal Memory, the underlying Spatial Pooler algorithms generates continuous SDR which are encoded with some input or sequence. The activation of neurons is not always the same for every sequence. This experiment aims to describe the two SDR sequences  taken to investigate the two slightly different sets of encoded inputs by using a new method that will differentiate the SDR values and manifest the dissimilarity in both the traced sequences SDR. The different sets of inputs in both SDR lists have semantic similar inputs. Every bits in SDR are not designated with any value or names, but it has a semantic meaning which are to be learned [4]. The experiment we did here, shows the work of the two SDRs which has the active bits on the similar locations and in some locations there are dissimilar or inactive bits and both SDR sets allot the same semantic attributes because of the active bits in same place. The investigation we proposed here, there is an overlap between both the SDRs as they have somewhere same set of active bits, so we can immediately compare between the two representations which are semantically similar and differentiate the parts or bits which are dissimilar. Within one set of neurons, an SDR at one point in time can associatively link to the next occurring SDR.

## Architecture:
### Part I:

The StringifyVector method, which is already implemented generates or trace out the SDRs. The following line of code is used

> **_Code Line:_**  Helpers.StringifyVector(lyrOut.PredictiveCells.Select(c => c.Index).ToArray())

This method produces the output such as two sets of SDR. The method produces outputs like following one:

---

**Output of StringifyVector method**

51, 76, 87, 113, 116, 118, 122, 152, 156, 163, 179, 181, 183, 186, 188, 190, 195, 210, 214, 224, 

51, 76, 113, 116, 118, 156, 163, 179, 181, 182, 183, 186, 188, 190, 195, 197, 210, 214, 224, 243

---
The result of above mentioned method, shows indexes of bits that are active. Now, the output of SDR are similar, then it is challenging to see the difference in both the SDRs. Hence, we constructed a new method called Stringify_TraceSDR. The following new method Stringify_TraceSDR shows how to differ between two SDR sets in a well arranged index.

---

**Block of Code**

string Stringify_TraceSDR(List<int[]> sdrs)
{

     var heads = new List<int>(newint[sdrs.Count]);
     
     var outputs = new StringBuilder[sdrs.Count]);
}
---







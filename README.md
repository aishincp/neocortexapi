# ML 21/22 - Implement Trace SDR Method

#### The goal of this project is to implement the well-formatted tracing of multiple SDRs 

## Project Description 
## Aim:
In Hierarchical Temporal Memory, the underlying Spatial Pooler algorithms generates continuous SDR which are encoded with some input or sequence. The activation of neurons is not always the same for every sequence. This experiment aims to describe the two SDR sequences  taken to investigate the two slightly different sets of encoded inputs by using a new method that will differentiate the SDR values and manifest the dissimilarity in both the traced sequences SDR. The different sets of inputs in both SDR lists have semantic similar inputs. Every bits in SDR are not designated with any value or names, but it has a semantic meaning which are to be learned. The experiment we did here, shows the work of the two SDRs which has the active bits on the similar locations and in some locations there are dissimilar or inactive bits and both SDR sets allot the same semantic attributes because of the active bits in same place. The investigation we proposed here, there is an overlap between both the SDRs as they have somewhere same set of active bits, so we can immediately compare between the two representations which are semantically similar and differentiate the parts or bits which are dissimilar. Within one set of neurons, an SDR at one point in time can associatively link to the next occurring SDR.

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

### Part II:

The index of bit that are active are provided into Stringify_TraceSDR method and, now we further examine to create a well formatted SDRs. The implied method stores every bits of active column as a string. 

The next step of our approach was to differentiate between the two SDRs which have similar index bit of active neurons, we create better results by adding gaps or space at places that have not the same index or inactive bits in the SDRs. Following code shows how to fill the space in place of missing index bit which are inactive. 

---

**Block of Code**


var numOfSpaces = minActiveColumn.ToString().Length; 

                for (var j = 0; j < numOfSpaces; j++)
                {
                    outputs[i].Append(" ");
                }
                outputs[i].Append(", ");
---

## Result:
The final result of our experiment, the SDR output creates spaces at those places where the representations do not have the same index. 

![2022-03-30_05-25-16](https://user-images.githubusercontent.com/45165287/160745547-ddec4a29-db59-4a7f-a5c3-6f7a75ce11c0.png)


## Unit Test Project:
A Unit Test project has been also implemented for our project, tested out the Stringify_TraceSDR method case to make sure major requirements of the module are being validated.

---
**Code**:

![2022-03-30_05-31-36](https://user-images.githubusercontent.com/45165287/160746004-8a239b6c-0858-4f29-a778-817a91e726e3.png)

---

The Documentation of this project will be accessible from here.

The code of this project will be accessible from here.

# TieSim

An exploration of using the Oculus Rift DK2 with head mounted Leap Motion V2 as a means for input 
in a virtual world. It was determined that while cool, the leap does not allow for precise enough input 
on small scales to accurately allow the completion of the original project (learning how to tie a tie on 
a robot). Future work would include phasing out the Leap and replacing it with a different more accurate
input device to actually tie the tie and perform a study to see if the simulation is an effective 
teaching mechanism. 

## Hardware

This project runs with the Oculus Rift DK2 (latest firmware) and Leap Motion V2 (latest firmware).
Both must be installed to run (though the sim does work with just the DK2 if no leap is available).

## Software

Built in Unity3D simply import this project and find the scene "main" to edit the sim. To build
new versions simply go to build settings and replace the "main" exe (be sure to delete the direct to
rift version first as it will also be replaced). 

## How to use

To run the project simply run either the main.exe or the direct to rift option. Even though the 
instruction board says to press "space" to advance, simply use the F keys to navigate the instruction
wall.

## LaTeX

Included in this repo is the full LaTeX file set used for my thesis paper. To compile simply open the "thesis.tex" file, and first run its typeset through BibTex to create the "thesis.bbl", next simply compile the file with the LaTeX typeset. Important note, you must compile multiple times with the LaTeX typeset in order to get the table of contents and figures to load in properly. 

Credit for the "asu.cls" and overall markup of the "thesis.tex" goes to Michael Crawford with his undergrad-thesis files over at https://github.com/mbcrawfo/undergrad-thesis. 

## License

MIT: http://mit-license.org/

Copyright 2015 Brian Clee

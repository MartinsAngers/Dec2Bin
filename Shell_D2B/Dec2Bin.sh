#! /bin/bash

Dec2Bin=({0..1}{0..1}{0..1}{0..1}{0..1}{0..1}{0..1}{0..1}{0..1}{0..1})
read Num
echo ${Dec2Bin[$Num]}

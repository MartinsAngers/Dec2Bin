#! /bin/bash
read Num
bc <<< "obase=2;$Num"

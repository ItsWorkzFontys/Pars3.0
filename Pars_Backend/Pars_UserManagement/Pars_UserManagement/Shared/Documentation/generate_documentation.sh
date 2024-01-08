#!/bin/bash

#Get all .puml files and export those to .png with the same basename
for file in diagrams/*.puml; do
    filename=$(basename -- "$file")
    filename="${filename%.*}"
    puml generate $file -o "diagrams/$filename.png"
    echo -e "Created $filename.png"
done
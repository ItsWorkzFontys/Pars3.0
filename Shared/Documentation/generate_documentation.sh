#!/bin/bash

#Get all .puml files and export those to .png with the same basename
for file in diagrams/*.puml; do
    filename=$(basename -- "$file")
    filename="${filename%.*}"
    echo -e "Found $filename.png"
    puml generate $file -o "diagrams/$filename.png"
    echo -e "Created $filename.png"
done

#Get the .adoc files and export them to .html with the same basename
for file2 in text/*.adoc; do
    filename2=$(basename -- "$file2")
    filename2="${filename2%.*}"
    echo -e "Found $filename2.adoc"
    asciidoctor "text/$filename2.adoc"
    echo -e "Created $filename2.adoc"
done
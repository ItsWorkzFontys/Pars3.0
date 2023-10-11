#!/bin/bash

cd Shared/Documentation

#Get all .puml files and export those to .png with the same basename
for file in *.puml; do
    filename=$(basename -- "$file")
    filename="${filename%.*}"
    echo -e "Found $filename.puml"
    puml generate $file -o "$filename.png"
    echo -e "Created $filename.png"
done

#Get the .adoc files and export them to .html with the same basename
for file2 in *.adoc; do
    filename2=$(basename -- "$file2")
    filename2="${filename2%.*}"
    echo -e "Found $filename2.adoc"
    asciidoctor "$filename2.adoc"
    echo -e "Created $filename2.html"
done
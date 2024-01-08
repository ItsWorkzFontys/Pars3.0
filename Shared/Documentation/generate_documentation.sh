#!/bin/bash

cd Shared/Documentation

#Get all .puml files and export those to .png with the same basename
for file in *.puml; do
    filename=$(basename -- "$file")
    filename="${filename%.*}"
    echo -e "Found $filename.puml"
    java -jar plantuml.jar "$filename.puml"
    
    # Check if the .png file was created successfully
    if [ -f "$filename.png" ]; then
        echo -e "Created $filename.png"
    else
        echo -e "Failed to create $filename.png"
    fi
done

#Get the .adoc files and export them to .html with the same basename
for file2 in *.adoc; do
    filename2=$(basename -- "$file2")
    filename2="${filename2%.*}"
    echo -e "Found $filename2.adoc"
    asciidoctor "$filename2.adoc"
    
    # Check if the .html file was created successfully
    if [ -f "$filename2.html" ]; then
        echo -e "Created $filename2.html"
    else
        echo -e "Failed to create $filename2.html"
    fi
done


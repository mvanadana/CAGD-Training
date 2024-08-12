# Geometry Visualization Application

## Overview

This C# console application is designed to visualize polygons by allowing users to input coordinates, apply transformations, and perform triangulation. The application supports basic geometric operations and outputs the results in a format suitable for further processing.

## Features

- **Polygon Input**: Enter a set of coordinates to define the vertices of a polygon.
- **Transformations**: Apply translation, scaling, rotation, or combinations of these transformations.
- **Triangulation**: Convert the polygon into a set of triangles using the ear clipping algorithm.
- **Output**: Write the resulting triangles for further processing or visualization.

## Usage

1. **Run the Application**:
   - Compile and run the application from the command line or an IDE.

2. **Input Coordinates**:
   - Enter the number of vertices for the polygon.
   - Input the x and y coordinates for each vertex.

3. **Choose Transformations**:
   - Specify whether you want to apply:
     - Translation
     - Scaling
     - Rotation
     - All three transformations
     - None

4. **Transformation Details**:
   - Depending on your choice, provide the required transformation parameters:
     - Translation X and Y
     - Scaling X and Y
     - Rotation angle (in degrees)

5. **Triangulation**:
   - The application will automatically triangulate the polygon and process the results.

6. **Output**:
   - The resulting triangles are written to an output file or displayed as per the implementation.
   - An output file viewed in GNU Plot for a polygon with 7 vertices 
![output file](https://github.com/user-attachments/assets/263e00ac-ee59-4169-9d4e-7d3072d864d3)


## Code Structure

### `Program` Class

- Manages user input and application flow.
- Applies transformations based on user choices.
- Invokes the triangulation process.

### `Triangulation` Class

- Contains the logic for triangulating the polygon using the simple traingle detection algorithm.
- Provides methods for checking triangle validity and calculating areas.

### Transformation Methods

- Transformation methods (`Transform.Translate`, `Transform.Scale`, `Transform.Rotate`) are used to modify the polygon based on user input. These methods are assumed to be implemented elsewhere.





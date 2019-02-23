
# Graph
 - Implement a Graph
## Challenge
Implement your own Graph. The graph should be represented as an adjacency list, and should include the following methods:

- AddVertex()
    - Adds a new vertex to the graph
    - Takes in the value of that vertex
    - Returns the added vertex
    
- AddEdge()
  - Adds a new edge between two verticies in the graph
  - Include the ability to have a “weight”
  - Takes in the two verticies to be connected by the edge
    - Both verticies should already be in the Graph
    
- GetVertexes()
  - Returns all of the verticies in the graph as a collection (set, list, or similar)
  
- GetNeighbors()
  - Returns a collection of verticies connected to the given vertex
  - Takes in a given vertex
  - Include the weight of the connection in the returned collection
  
- GetSize()
  - Returns the total number of verticies in the graph


## Approach & Efficiency
### Approach
Vertex Class
- Attributes
  - object Value (so that data can be generic)
  
- Constructor Method
  - Input = object value
  - Creates a new Vertex with Value = value

Edge Class
- Attributes
  - Vertex vertex
  - int Weight
- Constructor Method
  - Input = Vertex neighbor, int weight
  - Creates a new Edge with Vertex = neighbor and Weight = weight

Graph Class
  - Attributes
    - int Size (Total amount of Verticies present in Graph)
    - Dictionary(Vertex, LinkedList(Edge)) _AdjacencyList (Holds all of the Verticies as the Key values and each Verticies corresponding neighbors in a linked list as a Value)

  - Constructor Method
    - Creates the _AdjacenyList and sets the Size of the Graph to 0.
    
  - AddVertex Method
    - Input = Vertex vertex
    - Output = Vertex vertex (It is really expensive to output a key from a dictionary so I am just returning the input because there really is no reason to return the value when its added...)
    - Creates a new Linked List that holds Edges called neighbors.
    - Adds vertex and neighbors to _AdjacencyList
    - Increases Size of graph by 1
    - Returns vertex
    
  - AddEdge Method
    - Input = Vertex startVertex, Vertex endVertex, int weight (defaults to 0 if no input is entered)
    - Checks _AdjacenyList to see if startVertex and endVertex exist.
      - If either value does not exist then an exception is thrown
    - A new Edge is created with input values of endVertex and weight.
    - A LinkedList called neighbors is instantiated.
    - The _AdjacencyList is then accessed using TryGetValue with the input key = startVertex and the output = neighbors
    - The Edge is then added to the head of the linked list neighbors.
    - The _AdjacencyList is then accessed at startVertex and the existing value is replaced with neighbors.

  - GetVerticies Method
    - Output = List of Verticies contained in Graph
    - Checks if Graph has Verticies (Size > 0)
      - if true then returns all verticies within the graph as a list of Verticies using _AdjacencyList.Keys.ToList(); (Thanks Dictionary for making life easy ;) )
      - else the method will return null
      
  - GetNeighbors Method
    - Input = Vertex vertex
    - Output = List of Edges (neighbors) of input vertex or Exception if vertex isn't in graph
    - Checks _AdjacenyList to see if vertex exists.
      - If vertex isn't in _AdjacencyList then exeption is thrown
    - A LinkedList called neighbors is instantiated.
    - The _AdjacencyList is then accessed using TryGetValue with the input key = vertex and the output = neighbors
    - The neighbors Linked List is then returned as a list.
        
  - GetSize Method
    - Output = int amount of Verticies in Graph
    - Accesses Size property and returns it.

### Efficiency

#### AddVertex Method
##### Time
O(1)
##### Space
O(1)
#### AddEdge Method
##### Time
O(1)
##### Space
O(1)
#### GetVerticies Method
##### Time
O(n)
##### Space
O(n)
#### GetNeighbors Method
##### Time
O(1)
##### Space
O(n)
#### GetSize Method
##### Time
O(1)
##### Space
O(1)

## API
### Class Graph Required Classes
- Graph requires Edge class and Vertex class.


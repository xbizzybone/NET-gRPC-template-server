# gRPC Service for Book Management

This gRPC service is designed for book management, providing basic operations such as create, read, update, and delete books.

## Prerequisites
To run this service, you need to have the following software installed:

- MongoDB

### MongoDB Installation
1. Download and install MongoDB from the official [mongo-db] website.
2. Follow the installation instructions for your operating system.
3. Once MongoDB is installed, make sure the MongoDB server is running.

## Installation
1. Clone this repository to your local machine:
```bash
git clone https://github.com/xbizzybone/NET-gRPC-template-server.git
```
2. Navigate to the project directory:
```bash
cd Solution gRPC.template.server
```
3. Build the project using the dotnet build command:
```bash
dotnet build
```
4. Run the project using the dotnet run command:
```bash
dotnet run
```

The gRPC service will be available at https://localhost:7092 & http://localhost:5026

## Usage
This gRPC service provides the following operations:

CreateBook: Creates a new book with the provided data.
ReadBook: Reads the information of a specific book.
ReadBooks: Gets the list of all books.
UpdateBook: Updates the information of an existing book.
DeleteBook: Deletes an existing book.

## Contributions
Contributions are welcome! If you find any issue or have an improvement to suggest, feel free to open an issue or submit a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE] file for more information.

[//]: # (These are reference links used in the body of this note and get stripped out when the markdown processor does its job. There is no need to format nicely because it shouldn't be seen. Thanks SO - http://stackoverflow.com/questions/4823468/store-comments-in-markdown-syntax)

   [LICENSE]: <https://www.mit.edu/~amini/LICENSE.md>
   [mongo-db]: <https://www.mongodb.com/>

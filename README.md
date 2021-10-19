## [ORM](#)
#### Object–relational mapping (ORM, O/RM, and O/R mapping tool) in computer science is a programming technique for converting data between incompatible type systems using object-oriented programming languages. This creates, in effect, a "virtual object database" that can be used from within the programming language.

##### In this repo you will see that I used 2 ORM Tools: Entity Framework and Dapper

![alt text](https://csharpcorner-mindcrackerinc.netdna-ssl.com/article/crud-operation-using-dapper-in-c-sharp/Images/CRUD%20Operation%20Using%20Dapper2.png)

### [1. Entity Framework](#)

##### Microsoft Entity Framework is an ORM (Object-relational mapping). Being an ORM, Entity Framework is a data access framework provided by Microsoft that helps to establish a relation between objects and data structure in the application. 

##### It is built over traditional ADO.NET and acts as a wrapper over ADO.NET and is an enhancement over ADO.NET that provides the data access in a more automated way, thereby, reducing a developer’s effort to struggle with connections, data readers, or datasets. 

##### It is an abstraction over all those and is more powerful with the offerings it makes. A developer can have more control over what data he needs, in which form and how much. A developer having no database development background can leverage Entity framework along with LINQ capabilities to write an optimized query to perform DB operations. The SQL or DB query execution would be handled by Entity Framework in the background and it will take care of all the transactions and concurrency issues that may occur.

#### [Entity Framework Approaches](#)

* Model First
* Database First
* Code First

#### Model First

##### Using a Model-First approach, a developer may not need to write any code for generating a database. Entity Framework provides the designer tools that could help you make a model and then generate a database out of it. 

#### Database First

##### We use the Database-First approach when we already have an existing database and need to access that in our application. Establishing the data access methodology for existing database with Entity Framework will help us to generate the context and classes in our solution through which we can access the database.

#### Code First

##### Using the Code-First approach, a developer’s focus is only on the code and not on the database or data model. The developer can define classes and their mapping in the code itself and since now Entity Framework supports inheritance, it is easier to define relationships. EF takes care of creating or re-creating the database for you.

### [2. Dapper](#)

##### Dapper is a popular simple object mapping tool. It is designed primarily to be used in scenarios where you want to work with data in a strongly typed fashion - as business objects in a .NET application, but don't want to spend hours writing code to map query results from ADO.NET data readers to instances of those objects.

#### [Is Dapper an ORM?](#)

##### Dapper falls into a family of tools known as micro-ORMs. These tools perform only a subset of the functionality of full-blown Object Relations Mappers, such as Entity Framework Core. Features vary by product.

#### [When Should You Use Dapper?](#)

##### When deciding whether to use Dapper or not, one should bear in mind the primary reason for its existence - performance. The original developers of Dapper were using Entity Framework Core's predecessor - the short-lived Linq to SQL. They found that query performance wasn't good enough for the increasing traffic that the site in question (Stackoverflow) was experiencing, so they wrote their own micro ORM.

##### Dapper is therefore a good choice in scenarios where read-only data changes frequently and is requested often. It is particularly good in stateless scenarios (e.g. the web) where there is no need to persist complex object graphs in memory for any duration.

##### Dapper does not translate queries written in .NET languages to SQL like a full blown ORM. So you need to be comfortable writing queries in SQL, or have someone write them for you.

##### Dapper has no real expectation about the schema of your database. It is not reliant on conventions in the same way as Entity Framework Core, so Dapper is also a good choice where the structure of the database isn't particularly normalised.

##### Dapper works with an ADO.NET IDbConnection object, which means that it will work with any database system for which there is an ADO.NET provider.

##### There is no reason why you cannot use both an ORM and a micro ORM in the same project.









# Entitity Framework Core

Mapping Varianten:
- Database First
- Model First
- Code First --> Mapping via Code (Code only in Beta)

NHibernate wird nicht mehr wirklich verwendet sondern Entitity Framework Core

Record: deconstruct, vergleichbar, get/init

Manage NuGet Package: Entity Framework Core 5.0.7

class BookContext : DBContext

onconfiguring 
{
  optionsBuilder.UseSqlServer();
}

Manage NuGet Package: Entity Framework Core SQLServer 5.0.7



oder mit DIContainer

public BooksContext(DBContextOptions<BooksContext> options) :base(options)
public DBSet<Book> Books {get;set;}
public DBSet<Book> Books => Set<Book>();

Manage NuGet Package: Microsoft Extensions Hosting

appsettings.json:
ConnextionStrings:{
  BooksConnection:"server=..."
}
Host.CreateDefaultBuild.ConfigureServices{
  services.AddDBContext<BooksContext>(options => options.UseSQLServer();
}


EnsureCreated(); erstellt die datenbank mit den Tables


Model: Classe mit properties (Buch

Context: erbt von DBContext und gibt den connectionstring

Create Database: context.Database.EnsureCreated();

Data Seeding: 
OnModelCreating überschreiben

View -> SQLServerObject Explorer



# Creating a Model

//Annotations überschreiben Conventions
//Fluent API überschreibt Annotations


## Conventions
DBSet Property wird beim Mapping includiert
OnModelCreating --> kann man mehr Typen eintragen

## Annotation
[NotMapped]

Fluent API
modelbuilder.ignore

## Properties
mit getter und setter
modelbuilder.entity<Book>().Ignore(b => b.Loadtime

## Table Mapping

## Column Mapping


## Generated Properties

## Required
Nullable Types
[Required]
.isRequired

## MaxLength

## Shadow Properties
do not exist in entity but in DB (z.B. Discriminator bei ableitung)


##Mapping to private Fields (not properties)

modelBuilder.Entity<Book>().Property(b => b.BookId).HasField("_bookId");

## Indexes

##Inheritance - Table per Hierarchy
Wenn es  mehrere Klassen von einer Ableitung gibt wird nur ein Table erzeugt
im Table gibt es einen Discriminator, welcher den DatenTyp beinhaltet


## Table per Type Mapping

# Entity Type COnfiguration

internal class BookConfiguration : IEntityConfiguration <Book> {
  public void Configure(EntityTypeBuilder<Book> builder){
    //config
  }
}

modelBuilder.ApplyConfiguration(new BookConfiguration());
//Eigene Configuration machen, dass nicht alles im OnModelCreating drin steht!!!!!



Lab1:
Clientseitig wenn möglich Async, damit das UI nicht blockiert wird
Seit 3.1 wenn möglich immer Async

appsettings.json copy if newer

same key ==> error



#Querying data

##Tracking
.AsNoTracking erstellt ein neues Objekt

#Compiled Query
queries in einer variable

#Global Query Filter
zb. wenn isDeleted true ist soll es nicht bei einer Query ausgegeben werden
Query Filter abdrehen: IgnoreQUeryFilters() methode



# Relationships

[InverseProperty("AUthor")]

## Eager Loading
.Include um z.b. von einem Buch den Autor haben will
.ThenInclude

## Explicit Loading

booksContext.Entry(book)

.Reference (1-beziehung)
.Collection (n-beziehung)

## Lazy Loading
Properties werden erst nachgeladen, wenn darauf zugegriffen wird
proxy für lazy loading muss konfiguriert werden

options.useLazyLoadingProxies(true)
&& virtual properties
&& NuGet Package

## Owned Entities

OwnsOne
OwnsMany








































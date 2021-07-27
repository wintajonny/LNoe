"use strict";

// Object
function books1() {
    let book1 = new Object();
    book1.title = "Professional C#";
    book1.display = function () {
        console.log("display");
        console.log(book1.title);
    };

    console.log(book1.title);
    book1.display();
}

// object literal
function books2() {
    let book1 = {
        title: "Professional C#",
        publisher: "Wrox",
        display: function () {
            console.log(this.title);
        }
    };

    console.log(book1.title);
    book1.display();
}

// constructor
function books3() {
    let Book = function (title, publisher) {
        this.title = title;
        this.publisher = publisher;
        this.display = function () {
            console.log(this.title);
        }
    }

    let book3 = new Book("Professional C#", "Wrox Press");
    console.log(book3.title);
    book3.display();

    let book4 = new Book("A new book");
    boo4.display();
}

// constructor with prototypes
function books3b() {
    let Book = function (title, publisher) {
        this.title = title;
        this.publisher = publisher;
    }

    Book.prototype.display = function () {
        console.log(this.title);
    }

    let book4 = new Book("Professional C#", "Wrox Press");
    console.log(book4.title);
    book4.display();


    let book5 = new Book("a new one");
    book5.isbn = "87348743";
    book5.display = function () {
        console.log("hah, overriding the prototype!");
    }
}

function booksWithClasses() {
    class Book {
        constructor(title, publisher) {
            this.title = title;
            this.publisher = publisher;
        }

        display() {
            console.log(this.title);
        }
    }

    let book6 = new Book("Professional C#", "Wrox");
    book6.display();
}


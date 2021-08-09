package main

import (
  "database/sql"
  "fmt"

  _ "github.com/lib/pq"
)

const (
  HOST       = "localhost"
  PORT       = 5401
  USER       = "abc"
  PASSWORD   = "abc"
  DATABASE   = "postgres"
)
func main() {
  psqlInfo := fmt.Sprintf("host=%s port=%d user=%s "+
    "password=%s dbname=%s sslmode=disable",
    host, port, user, password, dbname)
  db, err := sql.Open("postgres", psqlInfo)
  if err != nil {
    panic(err)
  }
  defer db.Close()

  err = db.Ping()
  if err != nil {
    panic(err)
  }

  fmt.Println("Successfully connected!")
}
func main() {
	// Initialize connection string.
	var connectionString string = fmt.Sprintf("host=%s port=%s user=%s password=%s dbname=%s sslmode=require", HOST, PORT, USER, PASSWORD, DATABASE)

	// Initialize connection object.
	db, err := sql.Open("postgres", connectionString)
	checkError(err)

	err = db.Ping()
	checkError(err)
	fmt.Println("Successfully created connection to database")

	// Drop previous table of same name if one exists.
	_, err = db.Exec("drop table if exists smoketesttable_go;")
	checkError(err)
	fmt.Println("step 1  :  drop table successful! ")

	// Create table.
	_, err = db.Exec("create table smoketesttable_go(id int primary key,name text,gender text);")
	checkError(err)
	fmt.Println("step 2 : create table successful!")

	// Insert some data into table.
	_, err = db.Exec("insert into smoketesttable_js1 values(1,'name1','male'),(2,'name2','female'),(3,'name3','male');")
	fmt.Println("step 3 : insert table successful!")
}

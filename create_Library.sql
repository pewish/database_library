CREATE TABLE Sotr (
	id_sotr INTEGER PRIMARY KEY,
	FIO_sotr VARCHAR(50) NOT NULL,
	bday DATE NOT NULL,
	experience SMALLINT NOT NULL,
	position VARCHAR(30) NOT NULL,
	phone_num INTEGER UNIQUE,
	email VARCHAR(30) UNIQUE,
	fired VARCHAR(3) NOT NULL CHECK (fired = 'ДА' OR fired = 'НЕТ') DEFAULT 'НЕТ'
)

CREATE TABLE Publisher (
	id_publisher INTEGER PRIMARY KEY,
	name_publisher VARCHAR(20) UNIQUE,
	year_found INTEGER NOT NULL
)

CREATE TABLE Book (
	id_book INTEGER PRIMARY KEY,
	book_name VARCHAR(50) NOT NULL,
	author VARCHAR(50) NOT NULL,
	publisher VARCHAR(20) REFERENCES Publisher(name_publisher) NOT NULL,
	public_year INTEGER NOT NULL,
	description VARCHAR(100) NOT NULL,
	genre VARCHAR(20) NOT NULL,
	section VARCHAR(20) NOT NULL,
	ISBN INTEGER UNIQUE NOT NULL,
	availability VARCHAR(3) NOT NULL CHECK (availability = 'ДА' OR availability = 'НЕТ') DEFAULT 'ДА'
)

CREATE TABLE Admission (
	id_add INTEGER PRIMARY KEY,
	id_sotr INTEGER REFERENCES Sotr(id_sotr) NOT NULL,
	id_book INTEGER REFERENCES Book(id_book) NOT NULL,
	add_date DATE NOT NULL
)

CREATE TABLE Reader (
	id_reader INTEGER PRIMARY KEY,
	FIOreader VARCHAR(50) NOT NULL,
	birthday DATE NOT NULL,
	num_phone INTEGER UNIQUE
)

CREATE TABLE Giving (
	id_giving INTEGER PRIMARY KEY,
	id_book INTEGER REFERENCES Book(id_book) NOT NULL,
	id_sotr INTEGER REFERENCES Sotr(id_sotr) NOT NULL,
	id_reader INTEGER REFERENCES Reader(id_reader) NOT NULL,
	date_giving DATE NOT NULL DEFAULT CONVERT (date, GETDATE()),
	date_delivery DATE
)

CREATE TABLE Booking (
	id_reader INTEGER REFERENCES Reader(id_reader) NOT NULL,
	id_book INTEGER REFERENCES Book(id_book) NOT NULL,
	booking_date DATE NOT NULL DEFAULT CONVERT (date, GETDATE()),
	PRIMARY KEY(id_reader, id_book)
)

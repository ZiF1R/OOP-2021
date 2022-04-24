use Courses;

create table Lectors (
	id int identity(1,1) PRIMARY KEY,
	Name varchar(40),
    Surname varchar(40),
    Patronimic varchar(40)
);

create table Disciplines (
	id int identity(1,1) PRIMARY KEY,
	Name varchar(40),
    Hours int,
    Lector int constraint D_FK FOREIGN KEY references Lectors(id),
    ListenersCount int,
);

create table Students (
	Name varchar(40),
    Surname varchar(40),
    Patronimic varchar(40),
	ActiveDiscipline int constraint St_FK FOREIGN KEY references Disciplines(id),
);
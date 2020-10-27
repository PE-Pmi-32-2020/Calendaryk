CREATE TABLE Calendars
(
    id INT IDENTITY PRIMARY KEY ,
    name VARCHAR(20)
);

CREATE TABLE Events
(
    id INT IDENTITY PRIMARY KEY,
    idCalendar INT,
    description VARCHAR(50),
    startTime SMALLDATETIME,
    endTime SMALLDATETIME,
    FOREIGN KEY(idCalendar) REFERENCES Calendars(id)
);

CREATE TABLE Notifications
(
    id INT IDENTITY,
    idEvent INT ,
    notificationTime SMALLDATETIME,
    FOREIGN KEY(idEvent) REFERENCES Events(id)
);
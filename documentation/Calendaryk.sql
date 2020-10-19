CREATE  TABLE    calendars(
      idCalendar TEXT  PRIMARY KEY NOT NULL,
      name TEXT NOT NULL);

CREATE  TABLE    events(
      idEvent TEXT  PRIMARY KEY NOT NULL,
      idCalendar TEXT NOT NULL,
      description TEXT NOT NULL,
      startTime TEXT NOT NULL,
      endTime TEXT NOT NULL,
      FOREIGN KEY(idCalendar) REFERENCES calendars(idCalendar));
CREATE  TABLE    notifications(
      idNotifcation TEXT PRIMARY KEY NOT NULL ,
      idEvent TEXT NOT NULL,
      notificationTime TEXT NOT NULL,
      FOREIGN KEY(idEvent) REFERENCES events(idEvent));
CREATE  TABLE    sysdiagrams(
      name VARCHAR(3),
      principal_id INTEGER  PRIMARY KEY NOT NULL,
      version INTEGER NOT NULL,
      definition TEXT NOT NULL);
			


    

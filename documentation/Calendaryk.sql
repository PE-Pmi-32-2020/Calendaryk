CREATE	TABLE    calendars(
			idCalendar TEXT  PRIMARY KEY NOT NULL,
			name TEXT);

CREATE	TABLE    events(
			idEvent TEXT  PRIMARY KEY NOT NULL,
			idCalendar TEXT,
			description TEXT,
			startTime TEXT,
			endTime TEXT,
			FOREIGN KEY(idCalendar) REFERENCES calendars(idCalendar));
CREATE	TABLE    notifications(
			idNotifcation TEXT PRIMARY KEY NOT NULL ,
			idEvent TEXT ,
			notificationTime TEXT,
			FOREIGN KEY(idEvent) REFERENCES events(idEvent));
CREATE	TABLE    sysdiagrams(
			name VARCHAR(3),
			principal_id INTEGER,
			version INTEGER,
			difinition TEXT);
			


    

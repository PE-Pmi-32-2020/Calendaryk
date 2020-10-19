CREATE	TABLE    notifications(
			id TEXT PRIMARY KEY  NOT NULL,
			idEvent TEXT,
			notificationTime TEXT);
CREATE	TABLE    calendars(
			id TEXT,
			name TEXT,
			FOREIGN KEY(id) REFERENCES notifications(id));
CREATE	TABLE    events(
			
			id TEXT,
			idEvent TEXT,
			idCalendar TEXT,
			description TEXT,
			startTime TEXT,
			endTime TEXT,
            FOREIGN KEY(id) REFERENCES notifications(id));
CREATE	TABLE    sysdiagrams(
			name VARCHAR(3),
			principal_id INTEGER PRIMARY KEY NOT NULL,
			version INTEGER,
			difinition TEXT);


    

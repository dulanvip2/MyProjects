﻿CREATE TABLE PERSON(
LAST VARCHAR(30),
FIRST VARCHAR(30) NOT NULL,
GENDER VARCHAR(1) NOT NULL,
DOB DATE NOT NULL
);

INSERT INTO PERSON (LAST, FIRST, GENDER, DOB) VALUES('Chiranthaka','Dulan','M','22-Oct-1990');
INSERT INTO PERSON (LAST, FIRST, GENDER, DOB) VALUES('Dilhara','Kasun','M','30-Oct-1990');
INSERT INTO PERSON (LAST, FIRST, GENDER, DOB) VALUES('Madushanka','Gayan','M','26-Dec-1990');
INSERT INTO PERSON (LAST, FIRST, GENDER, DOB) VALUES('Kaushalya','Nadeesha','F','19-Sep-1994');

SELECT * FROM PERSON WHERE GENDER = 'M';
SELECT * FROM PERSON WHERE DOB > '01-Jan-1989';

UPDATE PERSON SET LAST = 'Samarasekara' WHERE FIRST = 'Dulan' AND LAST = 'Chiranthaka';
UPDATE PERSON SET DOB = '26-Dec-1990' WHERE FIRST = 'Nadeesha' AND LAST = 'Kaushalya';


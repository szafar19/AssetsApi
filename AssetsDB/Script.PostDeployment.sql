IF NOT EXISTS (SELECT 1 FROM dbo.[Asset])
BEGIN
	INSERT INTO dbo.[Asset] (Status, Name)
	VALUES (1, 'Laptop'),
	(1, 'Scissors'),
	(1, 'Printer'),
	(1, 'Scanner'),
	(1, 'Fax'),
	(1, 'Telephone'),
	(0, 'Headphones');
END

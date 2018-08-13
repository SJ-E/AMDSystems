
ALTER TABLE ip_quotes
ADD [type] int

UPDATE ip_quotes SET [type] = 0
WHERE is_quote = 1

UPDATE ip_quotes SET [type] = 1
WHERE is_quote = 0
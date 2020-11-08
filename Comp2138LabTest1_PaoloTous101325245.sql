--Student Name: Paolo Tous
--Student ID: 101325245



--Q1

SELECT 51000 AS "Starting Principal",
(51000 + (51000 * 0.10)) AS "New Principal",
(0.65 * (51000 + (51000 * 0.10))) AS "Interest",
(51000 + (51000 * 0.10)) + (0.65 * (51000 + (51000 * 0.10))) AS "Principal + Interest",
TO_CHAR(SYSDATE, 'dd-mon-yyyy hh24:mi:ss') AS "System Date"
FROM Dual;


--Q2

SELECT account_number,  account_description, COUNT(*), SUM(line_item_amt)
FROM general_ledger_accounts gl JOIN invoice_line_items li
ON gl.account_number = li.account_number
WHERE COUNT(*) > 1
GROUP BY account_description;
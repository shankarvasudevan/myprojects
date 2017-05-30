SELECT p.name, COUNT(o.order_id) as NumCopiesSold
FROM orders o
INNER JOIN product p on o.product_id = p.product_id
WHERE p.available_from > DATEADD(MONTH, -1, GETDATE())
GROUP BY COUNT(o.order_id)
HAVING COUNT(o.order_id) < 10


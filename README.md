# ComplaintApp
Complaint Application have 3 features.

1. Login User
For user help below is the CURL request of the end point

`
curl --location --request POST 'https://localhost:44388/api/auth' \
--header 'Content-Type: application/json' \
--data-raw '{"Email":"frazms@hotmail.com", "Password":"jddsue"}'
`

2. Log complaint
For user help below is the CURL request of the end point

`
curl --location --request POST 'https://localhost:44388/api/complaint' \
--header 'Content-Type: application/json' \
--data-raw '{"Complaint":"I have black screen showing after logging in"}'
`

3. Fetch complaint
For user help below is the CURL request of the end point

`
curl --location --request GET 'https://localhost:44388/api/complaint/2'
`

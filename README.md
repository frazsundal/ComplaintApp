# ComplaintApp
Complaint Application have 3 features.

1. Login User
For user help below is the CURL request of the end point

```
curl --location --request POST 'https://localhost:44388/api/auth' \
--header 'Content-Type: application/json' \
--data-raw '{"Email":"frazms@hotmail.com", "Password":"jddsue"}'
```

2. Log complaint
For user help below is the CURL request of the end point

```
curl --location --request POST 'https://localhost:44388/api/complaint' \
--header 'Content-Type: application/json' \
--data-raw '{"Complaint":"I have black screen showing after logging in"}'
```

3. Fetch complaint
For user help below is the CURL request of the end point

```
curl --location --request GET 'https://localhost:44388/api/complaint/2'
```


• Exception handling
For exception handling in web api there needs to be a standard approach for handling it. All responses from web api needs to have Data, Message, Status Code so user can handle all web api requests in same way.

• Security
Need to implement OWASP guidelines to protect web api

• API Documentation
We can use swagger for API documentation

• Testing
We can write unit test using NUnit or XUnit for web api

• Logging
In Complaint controller I have used default logging mechanism, we can log in files or windows event viewer.
I have used log4net as well for logging which can log in files as well as email errors

• Performance & Scale
We can load balance web api to handle more requests. Each API can be a separate project so we can load balance easily.
For example Complaint service will be a separate Web API and run multiple instance to handle more requests.

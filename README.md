# Microservices
User services is used get detail of USer
Order Service gives order detail.

•	Create 3 microservices (in language of your choice):-
o	User Service – Will provide a REST endpoint giving details of user (it should return your name and email id being fetched from a database of your choice)
	GET /user/1
{
  "name": "John",
  "age": "23",
  "email": "john.doe@google.com"
}
o	Orders Service – Will give a list of all orders of a user. (it should return a predefined list, no database needed in this microservice)
	GET /orders/1
{
  "orders": [
    {
      "orderId": 1,
      "orderAmount": 250,
      "orderDate": "14-Apr-2020"
    },
   {
      "orderId": 2,
      "orderAmount": 450,
      "orderDate": "15-Apr-2020"
    }
  ]
}
o	Aggregator Service – Will aggregate the response from user and orders service to give following response (should get data from user and order service’s rest endpoint)
	GET /orderdetails/1
{
  "userDetails": {
    "name": "John",
    "age": "23",
    "email": "john.doe@google.com"
  },
  "orders": [
    {
      "orderId": 1,
      "orderAmount": 250,
      "orderDate": "14-Apr-2020"
    },
    {
      "orderId": 2,
      "orderAmount": 450,
      "orderDate": "15-Apr-2020"
    }
  ]
}

•	Expose the services in following manner:-
o	Expose only Aggregator microservice externally to the internet
o	User and Order service should be exposed only internally and both should be consumed internally by the Aggregator microservice.


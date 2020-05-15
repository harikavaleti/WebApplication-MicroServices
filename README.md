# WebApplication(EventHub)-MicroServices(API)
 
Is an event manager website that allows users to create, browse and promote events. It was built using Microservices architecture, Docker Linux containers, Swagger, Redis, RabbitMQ, IdentityServer4, ASP.NET Core and C#.

All the project is Dockerized using 8 containers:
EventPicApi
EventCatalogApi
EventDetailsApi
TokenServiceApi
CartApi
OrderApi
OrderSummaryApi
WebMvc
Mssqlserver
RedisCache
RabbitMQ
Asignments
Assignment 3a
YouTubelink: https://www.youtube.com/watch?v=DJ7ZB40gS6U
Another link: https://www.youtube.com/watch?v=Ad9Y6ICOFho&feature=youtu.be

Communication between services via messaging using RabbitMQ
Microservice Cart was modified and now is using use as cache Redis to save/update the user's cart.
Microservice Order was added to the project
Pages added to the project:
Orders Page
Upcoming orders
Past orders
Canceled orders
Assignment 3b
Youtubelink: https://youtu.be/-EDA6RugJ_8

All the project is Dockerized we are using 6 containers:

eventcatalog
wishlist
eventticket
tokenservice
webmvc
mssqlserver
The TokenServiceAPI is integrated in the application and the user can register, login and logout from the app.

The WebApp has 4 pages:

Main Page
Event Detail
Thing to do in a City
Search Anything




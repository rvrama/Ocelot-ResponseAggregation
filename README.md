## Using Ocelot for Response aggregation as part of API Gateway acting as BFF (or facade layer) 

1. Clone this project
2. Set up Multi-Startup project setup in Visual Studio 2022 to make sure both the API and API Gateway host runs (in differnt ports)
3. Go to the URL mentioned in the Upstream path section of each of the API (content, comment) to view the api responses.
   Ideally http://localhost:5151/blog/content will route internally to http://localhost:5001/api/content
5. Go to the URL mentioned in the Aggregates section Upstream path for Response Aggregation.
   Visiting http://localhost:5151/cms/blog should return the aggregated response from both /blog/content and /blog/comment

Note: Ratelimiting is also possible through Ocelot as API Gateway.  Follow Ocelot documentation or have a look at APIGatewayEx_ClientConsumer repo

   ##Happy Coding

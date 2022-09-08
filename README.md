
## Ocelot API Gateway Project <br></br>
In this project, we sent a request to 2 different API projects from a different project using API Gateway and got the answers.<br></br>
By sending a request to our Gateway project, we can get both the answers to the API requests in the BarAPI project and the answers to the API requests in the RestaurantAPI project from the APIGateway project.
<br></br>
> BarAPI project on port 5001, <br></br>
> There is a RestaurantAPI project on port 5002.<br></br>
> You will be able to access both ports with requests from port 5000. <br></br>

You can limit the number of API requests. (I configured it so that you can only make 10 requests in 10 minutes, but you can change it)

```
This project was built using .Net 6 and using the Ocelot library
```

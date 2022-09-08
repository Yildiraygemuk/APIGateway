
## Ocelot API Gateway Project <br></br>
![This is an image](https://static.wixstatic.com/media/0fcaa4_67ba44b7cbb8447da66efaf372d8c526~mv2.png/v1/fill/w_925,h_334,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/0fcaa4_67ba44b7cbb8447da66efaf372d8c526~mv2.png)
<br></br>
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

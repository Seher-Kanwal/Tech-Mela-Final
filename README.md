# Tech Mela 

## Description: 
It’s a website that will assist the technology related peoples to find there 
interest related different technologies events that are happing soon. User 
can register for online event as well as for physical events too. 

> # Use Cases:
> 
> 
> - User can create, view, update and delete their profile. 
> - User can join the already existing communities like web, android technologies. 
> - User can also create a community page too. 
> - User can view the status of the event online 
> - User can made payment for the event. 
> - User can made reservation for the event in advance 
> - User can generate the receipt after the payment 
> - User can get Study related material of the event 
> - User can track the location of event too (If we do implementation with map) 
> - User can earn points, badges and swags by attending events. 
> - Only the admin of the community is able to add, modify and delete the event. 
> - Community page admin can view the members of the community 
> - Admin can send alert of the event through emails to the register user of the event. 
> - Admin can assign different type of access to community members (admin moderators) 
> - Admin can add the details about the speakers and sponsors of the event. 
> - Admin can design a quiz in order to make session or event more attractive. 
> - Admin can upload the code labs and other study stuff. 
> - Admin can generate certificates for the attendant of the event. 



## Technology Used For Project :
we are using **Dot Net Framework with C#** for the Development of the project



# Working Details Till Now:

## Data Source:
For now, we are using json file as a data source that contains the details about different events.
> ## Elemets in the Data Source:
>
> - **Id** :<br>
> Unique identity of each Event
>
> - **Image** :<br>
> Contains the url of the poster that belongs to an event 
>
> - **Category** :<br>
> It contains the info about the category of the event we have different options here:
>
>>   - Web Development
>>   - Application Development 
>>   - Git and Github
>>   - Open Soucrce Contribution
>>   - Machine Learning & AI
>
> - **Speaker Name** :<br>
> Contains the name of the speaker who is going to entertain the attendees event 
>
> - **Heading** :<br>
> Contains the main line that represents the actuall aim of the event
>
> - **Description** :<br>
> Contains the whole details about the event it includes the agenda and all the other information for example if the event include workshop than which tools and
> technolgies the attendee needs to have


# Description about Project Design:

We didn't start a MVC project. We started from a simple template than we are creating each MVC componet seperately to understand the working of MVC properply for this
we are creating different folders for different functions. For example:
- Model (from mapping data to data source)
- Controllers (for Css, for Form)
- Services (For getting data from Data source)
- View (for displaying data to the User)

## Model :

We create a model with some parameter of json property type to get and set values within the data source.

![model code](https://user-images.githubusercontent.com/92606737/198924509-9226e465-e364-4128-88c5-513a77f60ab9.PNG)


and we know that our data source is in json. So we used JsonSeriliazer to convert our data into Json formate. For this purpose we just override a function 
**ToString()**


![json tostring](https://user-images.githubusercontent.com/92606737/198924839-2056c8f2-016a-40bb-8d12-8e1c7b7e3c18.PNG)


# Services:
We are write services in order to perform various task on our data. And than using all these services in controllers insteading of writting each function again and again. We are using the same services in the controller to perform operations just by creating the object of the service class.
#### Service in the project:
- jsonEventDetailsService
- CssService

### jsonEventDetailsService
This service perform different operation on data. The functions are defined in that services are given below:
#### getpath():
As our data is residing in our project directory. To perform operations on this data we need to have it's path. This Function actually gets the path of data file dynamically. It utillizing the  IWebHostEnvironment data type to get the root of the directory than by using the __combine function__ it's take the few arguments and than return the path of the data source.

![getpath fn](https://user-images.githubusercontent.com/92606737/199370155-59f03e05-0fbf-4514-acf8-67b30a159805.PNG)


### CssService
Here in our project, instead of passing the directly CSS file address. We are passing a link that leads to the CSS file in the layout file. So to read the Data from the CSS file we write a service that do this task efficiently. Whenever we need our CSS for use, instead of writting all code again we just create an obj of service than call it's getCSS function that return a string from the CSS file.


![css service](https://user-images.githubusercontent.com/92606737/199659439-63b7d981-b996-4ccd-be35-5eb7d988470d.PNG)

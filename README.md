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
- Controllers (for Css, for Form)
- Services (For getting data from Data source)
- View (for displaying data to the User)

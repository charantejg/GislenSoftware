using System;
using System.Threading;
using System.Threading.Tasks;
 
public class Program
{
	public static void Main()
	{
		// Creating Instance of Publisher
            Publisher youtube = new Publisher("Youtube.Com", 2000);
            Publisher facebook = new Publisher("Facebook.com", 1000);
 
            //Create Instances of Subscribers
            Subscriber sub1 = new Subscriber("Florin");
            Subscriber sub2 = new Subscriber("Piagio");
            Subscriber sub3 = new Subscriber("Shawn");
 
            //Pass the publisher obj to their Subscribe function
            sub1.Subscribe(facebook);
            sub3.Subscribe(facebook);
 
            sub1.Subscribe(youtube);
            sub2.Subscribe(youtube);
 
            //sub1.Unsubscribe(facebook);
 
 
            //Concurrently running multiple publishers thread
            Task task1 = Task.Factory.StartNew(() => youtube.Publish());
            Task task2 = Task.Factory.StartNew(() => facebook.Publish());
            Task.WaitAll(task1, task2);

            Task task3 = Task.Factory.StartNew(()=> youtube.Publish());
            

	}
}
 
public class NotificationEvent{
 
    public string NotificationMessage { get; private set; }
 
    public DateTime NotificationDate { get; private set; }
 
    public NotificationEvent(DateTime _dateTime, string _message)
    {
        NotificationDate = _dateTime;
        NotificationMessage = _message;
    }
 
}
 
public class Publisher{
    public string PublisherName { get; private set; }
    public int NotificationInterval { get; private set; }
 
    //** Declare an Event...
    // declare a delegate with any name
    public delegate void Notify(Publisher p, NotificationEvent e);
    // declare a variable of the delegate with event keyword
    public event Notify OnPublish;
 
 
    public Publisher(string _publisherName, int _notificationInterval){
        PublisherName = _publisherName;
        NotificationInterval = _notificationInterval;
    }
 
    //publish function publishes a Notification Event
    public void Publish(){
        while (true){
 
            Thread.Sleep(NotificationInterval); // fire event after certain interval
 
            if (OnPublish != null)
            {
                NotificationEvent notificationObj = new NotificationEvent(DateTime.Now, "New Notification Arrived from");
                OnPublish(this, notificationObj);
            }
            Thread.Yield();
        }
    }
}
 
public class Subscriber{

    public string SubscriberName { get; private set; }

    public Subscriber(string _subscriberName){
        SubscriberName = _subscriberName;
    }
    
    // This function subscribe to the events of the publisher
    public void Subscribe(Publisher p){

        // register OnNotificationReceived with publisher event
        p.OnPublish += OnNotificationReceived;  // multicast delegate 

    }

    // This function unsubscribe from the events of the publisher
    public void Unsubscribe(Publisher p){

        // unregister OnNotificationReceived from publisher
        p.OnPublish -= OnNotificationReceived;  // multicast delegate 
    }

    // It get executed when the event published by the Publisher
    protected virtual void OnNotificationReceived(Publisher p, NotificationEvent e){
    
        Console.WriteLine("Hey " + SubscriberName + ", " + e.NotificationMessage +" - "+ p.PublisherName + " at " + e.NotificationDate);
    }
}
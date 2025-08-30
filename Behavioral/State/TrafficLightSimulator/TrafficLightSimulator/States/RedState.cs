namespace TrafficLightSimulator.States
{
    public class RedState : ITrafficLightState
    {
        public void ChangeColor(TrafficLight trafficLight)
        {
            Console.WriteLine("Red");

            trafficLight.SetState(new GreenState());
        }

    }
}

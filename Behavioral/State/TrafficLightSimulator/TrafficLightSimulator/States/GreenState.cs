namespace TrafficLightSimulator.States
{
    public class GreenState : ITrafficLightState
    {
        public void ChangeColor(TrafficLight trafficLight)
        {
            Console.WriteLine("Green");

            trafficLight.SetState(new YellowState());
        }
    }
}

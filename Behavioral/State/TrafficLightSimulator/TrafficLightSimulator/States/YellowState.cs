namespace TrafficLightSimulator.States
{
    public class YellowState : ITrafficLightState
    {
        public void ChangeColor(TrafficLight trafficLight)
        {
            Console.WriteLine("Yellow");

            trafficLight.SetState(new RedState());
        }
    }
}

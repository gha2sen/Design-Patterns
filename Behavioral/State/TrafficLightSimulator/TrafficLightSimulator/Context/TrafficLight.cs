namespace TrafficLightSimulator.Context
{
    public class TrafficLight(ITrafficLightState lightState)
    {

        public bool IsTrafficLightOn { get; private set; }

        private ITrafficLightState _lightState = lightState;

        private void ChangeColor() => _lightState.ChangeColor(this);

        private async Task WaitAsync() => await Task.Delay(1000);

        public void SetState(ITrafficLightState state) => _lightState = state;

        public async Task OnAsync()
        {
            if (IsTrafficLightOn) return;

            IsTrafficLightOn = true;
            while (IsTrafficLightOn)
            {
                await WaitAsync();
                ChangeColor();
            }
        }

        public void Off() => IsTrafficLightOn = false;
    }
}

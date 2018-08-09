using ApiAiSDK;
using System;

namespace TravelAssistant
{

    public class TravesysAI
    {
        private ApiAi apiAi;


        public TravesysAI()
        {
            var config = new AIConfiguration("c17f20ba9bdd40a5ba438cde602efdc0", SupportedLanguage.English);
            apiAi = new ApiAi(config);

            Console.WriteLine("How may i help you?");
            var inputText = Console.ReadLine();
            var response = apiAi.TextRequest(inputText);

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(response?.Result?.Fulfillment?.Speech);

            foreach (var item in response.Result.Parameters)
            {
                Console.WriteLine($"{item.Key} ,  {item.Value}");
            }
        }

    }
}

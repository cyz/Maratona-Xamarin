// ApiService.cs
// 
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Evntr.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Evntr.Core.Services
{
    public class ApiService : IApiService
	{
		private const string BaseUrl = "https://monkey-hub-api.azurewebsites.net/api/";
        private Speaker mahmoud = new Speaker
        {
            Name = "Mahmoud Ali",
            Title = "Developer",
            MiniBio = "Desenvolvedor Web e Mobile na Lambda3, Xamarin Certified Mobile Developer, Microsoft Specialist em C#, entusiasta open source, com 7 anos de experiência com Xamarin",
            AvatarUrl = "mahmoud.jpeg"
        };
        private Speaker letticia = new Speaker
        {
            Name = "Letticia Nicoli",
            Title = "Microsoft MVP",
            MiniBio = "22 anos, Microsoft MVP, desenvolvedora mobile e web na Lambda3, Xamarin Certified Mobile Developer, contribui no coletivo Marialab. Adepta às boas práticas ágeis e novas tecnologias, busca compartilhar seus conhecimentos na área para empoderar mais pessoas",
            AvatarUrl = "letticia.jpeg"
        };
        private Speaker william = new Speaker
        {
            Name = "William Rodriguez",
            Title = "Microsoft MVP",
            MiniBio = "Pai de três meninas e um menino, professor, aluno de mestrado, desenvolvedor móvel, entusiasta de comunidades, único brasileiro reconhecido como Microsoft e Xamarin MVP, Xamarin Certified Mobile Developer, Co-Fundador e Host Monkey Nights Dev e Organizador da Open Dev Community",
            AvatarUrl = "william.jpeg"
        };
        private Speaker angelo = new Speaker
        {
            Name = "Angelo Belchior",
            Title = "Microsoft MVP",
            MiniBio = "Desenvolvedor há 15 anos, participou de projetos Desktop, Web e agora Mobile utilizando Xamarin. É Microsoft MVP em Visual Studio e Tecnologias, MCPD em Web e Lead Software Developer na ESX",
            AvatarUrl = "angelo.png"
        };

		public async Task<List<Talk>> GetSchedule()
		{
            return new List<Talk>
            {
                new Talk
                {
                    Title = "Introdução ao Xamarin.Forms",
                    Description= "Introdução mostrando como utilizar Xamarin.Forms",
                    ScheduleDay = ScheduleDay.One,
                    Speaker = william
                },
                new Talk
                {
                    Title = "Styles reaproveitáveis no Xamarin.Forms",
                    Description= "Como organizar e melhorar a parte visual do seu aplicativo com styles reaproveitáveis. Menos código repetido e mais controle sobre o aspecto visual!",
                    ScheduleDay = ScheduleDay.One,
                    Speaker = letticia
                },
                new Talk
                {
                    Title = "Animações com Xamarin.Forms",
                    Description= "Animações estão presentes nos aplicativos mais bem avaliados das lojas, elas dão a sensação de fluidez e qualidade. O Xamarin.Forms tratou isso como algo importante e trouxe uma API de animações compartilhada poderosa que é capaz de gerar animações nativas nas plataformas Android, iOS e UWP. Além disso, temos suporte da comunidade adicionando mais recursos às animações para que nossos aplicativos tenham uma melhor experiência de uso.",
                    ScheduleDay = ScheduleDay.One,
                    Speaker = mahmoud
                },
                new Talk
                {
                    Title = "Binding e MVVM com Xamarin.Forms",
                    Description= "Crie aplicativos utilizando binding e MVVM para facilitar a escrita e aumentar a testabilidade de apps Xamarin.Forms",
                    ScheduleDay = ScheduleDay.One,
                    Speaker = william
                },
                new Talk
                {
                    Title = "MVVM com Prism",
                    Description = "Deixe o Prism trabalhar por você! Simples, prático e rápido. Depois que você usa uma vez, nunca mais começará um projeto sem ele!",
                    ScheduleDay = ScheduleDay.One,
                    Speaker = angelo
                }
            };
		}

		public async Task<Event> GetEvent()
		{
            return new Event
            {
                Name = "XAMARIN SUMMIT 2018",
                Description = "O Xamarin Summit é a celebração e o grande encontro da comunidade de desenvolvedores Xamarin no Brasil, uma grande festa e uma forma do Monkey Nights contribuir com o desenvolvimento de pessoas.",
                LogoUrl = "xamarinsummit.png",
                Slogan = "O maior encontro de desenvolvedores Xamarin da América Latina",
                When = "7 e 8 de Junho",
                Where = "Microsoft, São Paulo",
                FullAddress = "Av. das Nações Unidas, 12901 - Brooklin Novo, São Paulo - SP, 04578-910",
                Speakers = new List<Speaker>
                {
                    mahmoud, letticia, william, angelo
                }
            };
		}
	}
}

// EventRepository.cs
// 
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Evntr.Models;

namespace Evntr.Api.Repositories
{
	public interface IEventRepository
	{
		Task<Event> Get();
		Task<List<Talk>> GetSchedule();
	}

	public class EventRepository : IEventRepository
	{
		private static Event CurrentEvent = new Event
		{
			Name = "XAMARIN SUMMIT 2018",
			Description = "O Xamarin Summit é a celebração e o grande encontro da comunidade de desenvolvedores Xamarin no Brasil, uma grande festa e uma forma do Monkey Nights contribuir com o desenvolvimento de pessoas.",
			LogoUrl = "https://scontent.fbfh2-1.fna.fbcdn.net/v/t1.0-9/28870393_628212297517780_2323710921085139892_n.png?_nc_cat=0&_nc_eui2=v1%3AAeHkvH0hCGmniP_62unYLYxZ1T0O_4AsTnhu5f4-h3mkor2p5m696aKZUQ5H55XB4xuHnjxZ6RjlzmRnpx9oz8F1NWDWaSUbs4MT-PUusXJ0sg&oh=8b5767fe5428357073d626e4bb2c4dc4&oe=5B2C955E",
			Slogan = "O maior encontro de desenvolvedores Xamarin da América Latina",
			When = "7 e 8 de Junho",
			Where = "Microsoft, São Paulo",
			FullAddress = "Av. das Nações Unidas, 12901 - Brooklin Novo, São Paulo - SP, 04578-910"
		};

		private static List<Talk> CurrentEventSchedule = new List<Talk>
		{
			new Talk
			{
				EventId = CurrentEvent.Id,
				Title = "IoC da forma certa!",
				Description ="Porquê IoC (Inversion of Control, ou Inversão de Controle) é tão importante num projeto? Já parou para pensar o porque? Ele é importante! Porquê não acessamos o banco de dados diretamente da View? Existe um motivo para tudo isso! Nesta palestra veremos como fazer isso da forma certa, criando suas ViewModels com dependências corretas e bem estruturadas.",
				ScheduleDay = ScheduleDay.One,
				Speaker = new Speaker
				{
					Name = "Alexandre Chohfi",
					Title = "Microsoft",
					MiniBio = "Software Engineer @Microsoft PAX New Devices Team! Former-MicrosoftMVP. UWP, Xamarin, MVVMCross, MonoGame!",
					AvatarUrl = "http://xamarinsummit.com.br/2017/img/palestrante/chohfi.png",
				}
			},
			new Talk
			{
				EventId = CurrentEvent.Id,
				Title = "Xamarin e Acessibilidade",
				Description ="Além das APIs nativas o que o Xamarin tem a nos oferecer do ponto de vista do desenvolvimento d aplicações acessíveis a pessoas com deficiencia?",
				ScheduleDay = ScheduleDay.Two,
				Speaker = new Speaker
				{
					Name = "Alexandre Santos Costa",
					Title = "Microsoft MVP",
					MiniBio = "Microsoft MVP desenvolvedor con deficiência visual apaixonado po r tecnologia",
					AvatarUrl = "http://xamarinsummit.com.br/2017/img/palestrante/magoo.jpg",
				}
			},
		};

		public Task<Event> Get()
		{
			return Task.FromResult(CurrentEvent);
		}

		public Task<List<Talk>> GetSchedule()
		{
			return Task.FromResult(CurrentEventSchedule);
		}
	}
}
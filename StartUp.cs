using CardGame.Entities;
using CardGame.Games;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class StartUp
    {
        /// <summary>
        /// Configure method to services
        /// </summary>
        /// <returns></returns>
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddTransient<CardGameApp>();
            services.AddScoped<IDeck,Deck>();
            services.AddTransient<ISimpleCardGame, SimpleCardGame>();

        }
    }
}

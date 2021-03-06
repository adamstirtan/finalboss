﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using AutoMapper;

using FinalBoss.Api.Dto;
using FinalBoss.Database.Services;
using FinalBoss.ObjectModel;

namespace FinalBoss.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ApiController<Game, GameDto, IGameService>
    {
        public GamesController(
            ILogger<GamesController> logger,
            IMapper mapper,
            IGameService gameService)
            : base(logger, mapper, gameService)
        { }

        protected override string RouteName => "games";
    }
}
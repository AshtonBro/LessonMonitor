﻿using System;
using Microsoft.AspNetCore.Mvc;
using LessonMonitor.Core.Services;
using LessonMonitor.API.Contracts;
using System.Threading.Tasks;
using AutoMapper;
using System.Net;

namespace LessonMonitor.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionsService _questionsService;
        private readonly IMapper _mapper;

        public QuestionsController(IQuestionsService questionsService, IMapper mapper)
        {
            _questionsService = questionsService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Create(NewQuestion request)
        {
            var question = _mapper.Map<NewQuestion, Core.CoreModels.Question>(request);

            var questionId = await _questionsService.Create(question);

            if (questionId != default)
            {
                return Ok( new CreatedQuestion() { QuestionId = questionId } );
            }
            else
            {
                return NotFound(new { Error = "Question is not created" });
            }
        }

        [HttpGet("GetQuestionById")]
        public async Task<Question> Get(int questionId)
        {
            var question = await _questionsService.Get(questionId);

            if (question is not null)
            {
                return _mapper.Map<Core.CoreModels.Question, Question>(question);
            }
            else
            {
                return null;
            }
        }

        [HttpGet("GetAllQuestions")]
        [ProducesResponseType(typeof(Question[]), (int)HttpStatusCode.OK)]
        public async Task<QuestiosArray> Get()
        {
            var getQuestions = await _questionsService.Get();

            if (getQuestions.Length != 0 || getQuestions is null)
            {
                var questions = _mapper.Map<Core.CoreModels.Question[], Question[]>(getQuestions);

                return new QuestiosArray() { Questions = questions };
            }
            else
            {
                throw new ArgumentNullException("No one question has been created!");
            }
        }
    }
}

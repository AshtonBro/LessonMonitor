using System;
using System.Threading.Tasks;
using LessonMonitor.Core.CoreModels;
using LessonMonitor.Core.Exceptions;
using LessonMonitor.Core.Repositories;
using LessonMonitor.Core.Services;

namespace LessonMonitor.BusinessLogic
{
    public class HomeworksService : IHomeworksService
    {
        public const string HOMEWORK_IS_INVALID = "Homework is invalid!";
        private readonly IHomeworksRepository _homeworksRepository;

        public HomeworksService(IHomeworksRepository homeworksRepository)
        {
            _homeworksRepository = homeworksRepository;
        }

        public async Task<int> Create(Homework homework)
        {
            // валидация
            if (homework is null)
            {
                throw new ArgumentNullException(nameof(homework));
            }

            var isInvalid = homework.Link == null
                || string.IsNullOrWhiteSpace(homework.Title);

            if (isInvalid)
            {
                throw new BusinessException(HOMEWORK_IS_INVALID);
            }

            var homeworkId = await _homeworksRepository.Add(homework);

            return homeworkId;
        }

        public async Task<bool> Delete(int homeworkId)
        {
            if (homeworkId == default)
                throw new ArgumentException("Argument should be greater than 0", nameof(homeworkId));

            await _homeworksRepository.Delete(homeworkId);

            return true;
        }

        public Task<Homework> Get(int homeworkId)
        {
            throw new NotImplementedException();
        }

        public Task<Homework[]> Get()
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Homework homework)
        {
            throw new NotImplementedException();
        }
    }
}

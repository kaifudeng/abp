using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Acme.SimpleTaskApp.Tasks;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace Acme.SimpleTaskApp
{
    public interface ITaskAppService : IApplicationService
    {
        Task<ListResultDto<TaskListDto>> GetAll(GetAllTasksInput input);
    }
}

using AutoMapper;
using ToDoAppAPI.Dtos;
using ToDoAppLibrary;

namespace ToDoAppAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateTaskDto, TaskModel>();
        }
    }
}

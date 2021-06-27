using AutoMapper;
using Its.Jenuiue.Api.Models.Organization;
using Its.Jenuiue.Api.ModelsViews.Organization;

namespace Its.Jenuiue.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MProduct, MVProduct>();
            CreateMap<MVProduct, MProduct>();
        }
    }
}
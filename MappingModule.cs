using AutoMapper;
using Solid.Practices.Modularity;

namespace AutoMapperSample
{
    class MappingModule : IPlainCompositionModule
    {
        public void RegisterModule()
        {
            Mapper.Initialize(x => x.AddProfile<MappingProfile>());
        }
    }
}

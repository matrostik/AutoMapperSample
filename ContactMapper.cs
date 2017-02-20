using AutoMapper;

namespace AutoMapperSample
{
    static class ContactMapper
    {
        internal static IContact MapToContact(ContactDTO itemDTO)
        {
            return Mapper.Map<Contact>(itemDTO);
        }
    }
}

namespace handlers;

public class MapperProfile: AutoMapper.Profile
{
  public MapperProfile()
  {
    this.CreateMap<Model.Chat, core.dto.ChatInfo>().ReverseMap();
  }
  
}
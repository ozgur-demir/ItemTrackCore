using AutoMapper;
using IT.Core.DTOs;
using IT.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT.Service.Mapping
{
    public class MapProfile :Profile
    {
        public MapProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<ItemMedia, ItemMediaDto>().ReverseMap();
            CreateMap<ItemDetail, ItemDetailDto>().ReverseMap();
            CreateMap<ItemKey, ItemKeyDto>().ReverseMap();
            CreateMap<ItemCategory, ItemCategoryDto>().ReverseMap();
            CreateMap<Item, ItemDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();

        }
    }
}

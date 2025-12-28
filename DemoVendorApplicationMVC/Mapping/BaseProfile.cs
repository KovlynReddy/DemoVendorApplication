using AutoMapper;
using DemoVendorApplicationDLL.Domain.Models;
using DemoVendorApplicationMVC.Models.RequestModel;
using DemoVendorApplicationMVC.Models.ViewModels;
using System;

namespace DemoVendorApplicationMVC.Mapping;

public class BaseProfile : Profile
{
    public BaseProfile()
    {
        CreateMap<CreateVendorViewModel, Vendor>();

        CreateMap<Vendor, CreateVendorResponse>();
    }
}
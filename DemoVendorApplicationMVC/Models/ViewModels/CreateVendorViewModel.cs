using DemoVendorApplicationDLL.Domain.Models;
using DemoVendorApplicationMVC.Models.RequestModel;
using MediatR;
using System;

namespace DemoVendorApplicationMVC.Models.ViewModels;

public class CreateVendorViewModel : Vendor, IRequest<CreateVendorResponse>
{
    public IFormFile UploadedImage { get; set; }
}

using AutoMapper;
using Azure.Core;
using DemoVendorApplicationMVC.Interfaces;
using DemoVendorApplicationMVC.Models.RequestModel;
using DemoVendorApplicationMVC.Models.ViewModels;
using DemoVendorApplicationDLL.Domain.Models;
using MediatR;
using System;

namespace DemoVendorApplicationMVC.Handlers.Vendor;

public class PostVendorRequestHandler : IRequestHandler<CreateVendorViewModel, CreateVendorResponse>
{
    private readonly IVendorService _vendorService;
    private readonly IMapper _mapper;
    private readonly IWebHostEnvironment _env;

    public PostVendorRequestHandler(IVendorService vendorService, IMapper mapper, IWebHostEnvironment env)
    {
        this._vendorService = vendorService;
        this._mapper = mapper;
        this._env = env;

    }

    public async Task<CreateVendorResponse> Handle(CreateVendorViewModel request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<DemoVendorApplicationDLL.Domain.Models.Vendor>(request);

        entity.Image = await ProccessImage(request);

        var result =  await _vendorService.PostVendor(entity);

        var response =  _mapper.Map<CreateVendorResponse>(result);

        return response;
    }

    private async Task<string> ProccessImage(CreateVendorViewModel request)
    {
        var uploadsFolder = Path.Combine(_env.WebRootPath, "uploads");
        Directory.CreateDirectory(uploadsFolder);

        var fileName = Guid.NewGuid() + Path.GetExtension(request.UploadedImage.FileName);
        var filePath = Path.Combine(uploadsFolder, fileName);

        using var stream = new FileStream(filePath, FileMode.Create);
        await request.UploadedImage.CopyToAsync(stream);

        return fileName;
    }
}

﻿using Microsoft.AspNetCore.Http;
using ShoeStore.Application.Catalog.ProductImages;
using ShoeStore.Application.Catalog.Products.DTOS;
using ShoeStore.Application.DTOS;

namespace ShoeStore.Application.Catalog.Products
{
    public interface IProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(ProductDeleteRequest request);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        //trả về một model mà có đầy đủ các thông tin 
        Task<PagedResult<ProductViewModel>> GetAllPagingProducts(GetProductPagingRequest request);
        Task<int> AddImage(int productId, ProductImageCreateRequest request);
        Task<int> RemoveImage(int imageId);
        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);
        Task<List<ProductImageViewModel>> GetListImage(int productId);
        Task<ProductViewModel> getByProductId(int productId);

        Task<ProductImageViewModel> GetImageById(int imageId);
    }
}

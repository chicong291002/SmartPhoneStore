﻿using ShoeStore.Application.Common;
using ShoeStore.Application.DTOS;
using ShoeStore.Application.System.Users.DTOS;

namespace ShoeStore.Application.System.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);
        Task<ApiResult<bool>> Register(RegisterRequest request);

        Task<ApiResult<bool>> Update(Guid id,UserUpdateRequest request);
        Task<ApiResult<PagedResult<UserViewModel>>> GetUsersPaging(GetUserPagingRequest request);

        Task<ApiResult<UserViewModel>> GetById(Guid id);
    }
}

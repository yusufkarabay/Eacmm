using AutoMapper.Internal.Mappers;
using Eacmm.Core.DTOs.AuthDto;
using Eacmm.Core.Entities.Abstract;
using Eacmm.Core.Services;
using Eacmm.Services.Mapping;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Services.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;

        public UserService(UserManager<User> userManager)
        {
            _userManager=userManager;
        }

        //diğer apiden gelen userların hesap oluşturma servisi


        //public string UserName { get; set; }
        //public string Password { get; set; }
        //public string Email { get; set; }
        //public string CityPlateCode { get; set; }



        //user oluşturma
        public async Task<CustomResponseDto<UserDto>> CreateUserAsync(CreateUserDto createUserDto)
        {
            //bu satıda kullancıdan username,maili,plaka kodunu aldık fakat passwor almadık. Bunu veritabanında tutmamak için hashleme işlemi gerçekleşecek
            var user = new User { Email=createUserDto.Email, UserName=createUserDto.UserName, CityPlateCode=createUserDto.CityPlateCode };

            //user oluşturduk . yanına haslanmış  passwordu ekledik veritabanına öyle gönderdik
            var result = await _userManager.CreateAsync(user, createUserDto.Password);

            //başarılı oladıysa
            if (!result.Succeeded)
            {
                //başarılı olmama sebebini oluşturuyoruz
                var errors = result.Errors.Select(x => x.Description).ToList();

                //oluşan hataları dönderiyoruz
                return CustomResponseDto<UserDto>.Fail(new ErrorDto(errors, true), 400);

            }

            //başarılıysa userappdtoyuı dönüyoruz !!!!! userappdtodan usernamei kaldırdım!!!! bunu daha sonra incele
            ///username tc olacağı için
            return CustomResponseDto<UserDto>.Success(ObjectMapper.Mapper.Map<UserDto>(user), 201);
        }


        //TC numarasına göre kullancı çekme
        public async Task<CustomResponseDto<UserDto>> GetUserByUserNameAsync(string userName)
        {
            //gelen tcye göre userı sorguladık
            var user = await _userManager.FindByNameAsync(userName);

            if (user==null)
            {
                //yoksa hata ver. Kullanıcı bulunamadı 404 
                return CustomResponseDto<UserDto>.Fail("User Name Not Found", 404, true);
            }

            //varsa userı döner fakat tcyi dönmüyor. 


            //!!!!!!!!!!!!!!! eğer ihtiyaç varsa yeni bi dtto oluştur içerisinde tc olan.
            return CustomResponseDto<UserDto>.Success(ObjectMapper.Mapper.Map<UserDto>(user), 200);
        }
    }
}


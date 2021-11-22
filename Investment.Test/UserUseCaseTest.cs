using AutoMapper;
using Investment.Core.UseCases;
using Investment.Infra.Settings;
using Investment.Test.Repositories;
using NUnit.Framework;

namespace Investment.Test
{
    public class UserUseCaseTest
    {
        private UserUseCase _userUseCase;
        private IMapper _mapper;

        public UserUseCaseTest()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new AutoMapperProfiles());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
        }

        [SetUp]
        public void Setup()
        {
            _userUseCase = new UserUseCase(_mapper,new UserFakeRepository());
        }

        [Test]
        public void VerifySummarizedEquity()
        {
            var userDto = _userUseCase.GetUser("1").Result;

            Assert.That(userDto.SummarizedEquity, Is.EqualTo(55));
        }
    }
}
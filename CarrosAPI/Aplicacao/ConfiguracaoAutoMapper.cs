using AutoMapper;
using CarrosAPI.Data.VO;
using CarrosAPI.Models;

namespace CarrosAPI.Aplicacao
{
    public class ConfiguracaoAutoMapper : Profile
    {
        public ConfiguracaoAutoMapper()
        {
            #region VO para Domínio
            CreateMap<CarroVO, Carro>();
            #endregion

            #region Domínio para VO
            CreateMap<Carro, CarroVO>();
            #endregion
        }
    }
}

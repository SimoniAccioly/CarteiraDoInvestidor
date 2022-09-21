using AutoMapper;
using CarteiraDoInvestidor.Application.Carteira.Dto;
using CarteiraDoInvestidor.CrossCuting.Infrastructure;
using CarteiraDoInvestidor.Domain.Carteira;
using CarteiraDoInvestidor.Domain.Carteira.Repository;

namespace CarteiraDoInvestidor.Application.Carteira.Service
{
    public class AtivoService : IAtivoService
    {
        private readonly IAtivoRepository ativoRepository;
        private readonly IMapper mapper;
        private IHttpClientFactory httpClientFactory;
        private AzureBlobStorage storage;

        public AtivoService(IAtivoRepository ativoRepository, IMapper mapper, IHttpClientFactory httpClientFactory, AzureBlobStorage storage)
        {
            this.ativoRepository = ativoRepository;
            this.mapper = mapper;
            this.httpClientFactory = httpClientFactory;
            this.storage = storage;
        }

        public async Task<AtivosOutputDto> Create(AtivosInputDto dto)
        {
            var ativo = this.mapper.Map<Ativos>(dto);  
                     
            HttpClient httpClient = this.httpClientFactory.CreateClient();

            using var response = await httpClient.GetAsync(ativo.ArquivoExcel);

            if (response.IsSuccessStatusCode)
            {
                using var stream = await response.Content.ReadAsStreamAsync();
                var filename = $"{Guid.NewGuid()}.xlsx";
                var pathStorage = await this.storage.UploadFile(filename, stream);
                ativo.ArquivoExcel = pathStorage;
            }
            await this.ativoRepository.Save(ativo);

            return this.mapper.Map<AtivosOutputDto>(ativo);
        }

        public async Task<List<AtivosOutputDto>> GetAll()
        {
            var ativo = await this.ativoRepository.GetAll();

            return this.mapper.Map<List<AtivosOutputDto>>(ativo);
        }

        public async Task<AtivosOutputDto> Edit(AtivosInputDto dto)
        {
            var ativo = this.mapper.Map<Ativos>(dto);

            await this.ativoRepository.Update(ativo);

            return this.mapper.Map<AtivosOutputDto>(ativo);
        }

        public async Task<AtivosOutputDto> Delete(Guid id)
        {
            var ativo = await this.ativoRepository.Get(id);

            await this.ativoRepository.Delete(ativo);

            return this.mapper.Map<AtivosOutputDto>(ativo);
        }
        public async Task<AtivosOutputDto> GetId(Guid id)
        {
            var result = await this.ativoRepository.Get(id);

            return this.mapper.Map<AtivosOutputDto>(result);
        }
    }
}

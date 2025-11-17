using Dev.Dominio.interfaces.Repositorio;
using Dev.Dominio.interfaces.Servico;
using Dev.Dominio.modelos;
namespace Dev.Dominio.Servico

{
    public class PagamentoServico (IPagamentoRepositorio _pagamentoRepositorio): IPagamentoServico //DI
    {
        public async Task Adicionar(Pagamento pagamento) //parametro
        {
           if (pagamento is null)

                throw new Exception("O pagamento nao pode ser nulo");

            await _pagamentoRepositorio.Adicionar(pagamento);
        }

        public async Task Atualizar(Pagamento pagamento)
        {
            if (pagamento is null)

                throw new Exception("O pagamento nao pode ser nulo");
            var pagamentoDb = await _pagamentoRepositorio.LerPorId(pagamento.Id);

              pagamentoDb.FormaPagamento = pagamento.FormaPagamento;
              pagamentoDb.StatusPagamento = pagamento.StatusPagamento;
              pagamentoDb.DataPagamento = pagamento.DataPagamento;
 

            await _pagamentoRepositorio.Atualizar(pagamentoDb);
        }

        public async Task<IList<Pagamento>> Ler()
        {
           return await _pagamentoRepositorio.Ler();
        }

        public async Task<Pagamento> LerPorId(int id)
        {
           return await _pagamentoRepositorio.LerPorId(id);
        }

        public async Task Remover(int id)
        {
            var pagamentoDb = await _pagamentoRepositorio.LerPorId(id);

            if (pagamentoDb is null)

                throw new Exception("O pagamento nao pode ser nulo");
                
            await _pagamentoRepositorio.Remover(id);
        }

     
    }

}
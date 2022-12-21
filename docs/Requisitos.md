# Requisitos ShopDemo

<details>
    <summary>
        <strong>
            Funcionalidade 1
        </strong>
    </summary>

**Descrição:** Importação de Cliente

**Como** usuário administrator do e-commerce

**Eu quero** poder importar clientes

**Para que** esses clientes possam ser usados dentro do sistema

### Cenário 1: Cliente novo

**Dado** um cliente que não possua o e-mail cadastrado

**Quando** a importação for solicitada

**Então** o cliente deve ser importado com sucesso

### Cenário 2: Cliente existente

**Dado** em cliente que já possua o e-mail cadastrado na base

**Quando** a importação for solicitada

**Então** a importação deve ser recusada

**E** um aviso de e-mail já cadastrado deve ser retornado

### Cenário 3: Cliente com informações inválidas

**Dado** um cliente que possua as informações inválidas

**Quando** a importação for solicitada

**Então** a importação deve ser recusada

**E** um aviso para cada informação inválida deve ser retornado

### Dados

O cliente possuí:

- nome: Texto obrigatório de até 50 caracteres
- sobrenome: Texto obrigatório de até 150 caracteres
- data de nascimento: Data obrigatória menor ou igual a data atual
- e-mail: Texto obrigatório até 256 caracteres

---

### Tarefas

- [ ] Criar uma branch a partir da branch "features/1-importacao-cliente" com o
      padrao "features/1-importacao-cliente-seu-nome"
- [ ] Criar uma solution chamada McbEdu.Mentorias.ShopDemo
- [ ] Criar um projeto asp.net core web api chamado
      McbEdu.Mentorias.ShopDemo.WebApi (os demais projetos como application,
      domain, infra.data e etc, fica a critério aberto)
- [ ] Desenvolver todos os requisitos funcionais a partir do projeto
      McbEdu.Mentorias.ShopDemo.WebApi
- [ ] O banco de dados é de livre escolha.

</details>

<details>
    <summary>
        <strong>
            Funcionalidade 2
        </strong>
    </summary>

**Descrição:** Importação de cliente em lote

**Como** usuário administrator do e-commerce

**Eu quero** poder importar clientes em lote

**Para que** esses clientes possam ser usados dentro do sistema

### Cenário 1: Importação com sucesso

**Dado** um lote de clientes

**Quando** a importação em lote for solicitada

**Então** os clientes devem ser importados se todos os clientes do lotem tiverem
sucesso

### Cenário 2: Importação com falha

**Dado** um lote de clientes

**Quando** a importação em lote for solicitada

**Então** nenhum cliente deve ser importado caso qualquer um deles apresente
algum erro

**E** deve ser retornado qual o motivo do não processamento

---

### Tarefas

- [ ] Criar uma branch a partir da branch da issue #1 chamada
      "features/1-importacao-cliente-lote" com o padrao
      "features/2-importacao-cliente-lote-seu-nome"
- [ ] No projeto McbEdu.Mentorias.ShopDemo.WebApi, adicionar a importação em
    lote seguindo os requisitos apresentados
</details>

<details>
    <summary>
        <strong>
            Funcionalidade 3
        </strong>
    </summary>

**Descrição:** Importação de pedido

**Como** usuário administrator do e-commerce

**Eu quero** poder importar pedidos

**Para que** esses pedidos possam ser usados dentro do sistema

### Cenário 1: Pedido novo

**Dado** um pedido que não possua o código cadastrado

**Quando** a importação for solicitada

**Então** o produto deve ser importado com sucesso

**E**, caso o cliente associado ao produto não exista, o cliente deve ser
cadastrado

**E**, caso o cliente associado ao pedido exista, mas com dados diferentes, a
importação deve ser feita, porém, um aviso de que o cliente existe com outros
dados deve ser retornado

**E**, caso os produtos associado ao pedido existam, mas com dados diferentes, a
importação deve ser feita, porém, um aviso de que o produto existe com outros
dados deve ser retornado.

**E**, caso existam dois itens ou mais com o mesmo produto, somente um item de
produto deve ser importado contendo a soma de todas as quantidades, a média dos
valores e a junção das descrições.

### Cenário 2: Pedido existente

**Dado** um pedido que já possua o código cadastrado na base

**Quando** a importação for solicitada

**Então** a importação deve ser recusada

**E** um aviso de código já cadastrado deve ser retornado

### Cenário 3: Pedido com informações inválidas

**Dado** um pedido que possua as informações inválidas

**Quando** a importação for solicitada

**Então** a importação deve ser recusada

**E** um aviso para cada informação inválida deve ser retornado

### Dados

O pedido possuí:

- código: Texto obrigatório de até 150 caracteres
- data: Data e Hora
- cliente: dados do cliente
- items: os itens do produto possuem as informações do produto, sequência,
  descrição, quantidade e valor unitário

---

### Tarefas

- [ ] Criar uma branch a partir da branch "features/10-importacao-pedido" da
      issue #4 com o padrao "features/4-importacao-pedido-seu-nome"
- [ ] Desenvolver essa funcionalidade a partir do projeto
    McbEdu.Mentorias.ShopDemo.WebApi
</details>

<details>
    <summary>
        <strong>
            Funcionalidade 4
        </strong>
    </summary>

**Descrição:** Importação de produto

**Como** usuário administrator do e-commerce

**Eu quero** poder importar produtos

**Para que** esses produtos possam ser usados dentro do sistema

### Cenário 1: Produto novo

**Dado** um produto que não possua o código cadastrado

**Quando** a importação for solicitada

**Então** o produto deve ser importado com sucesso

### Cenário 2: Produto existente

**Dado** um produto que já possua o código cadastrado na base

**Quando** a importação for solicitada

**Então** a importação deve ser recusada

**E** um aviso de código já cadastrado deve ser retornado

### Cenário 3: Produto com informações inválidas

**Dado** um produto que possua as informações inválidas

**Quando** a importação for solicitada

**Então** a importação deve ser recusada

**E** um aviso para cada informação inválida deve ser retornado

### Dados

O produto possuí:

- código: Texto obrigatório de até 150 caracteres
- descrição: Texto obrigatório de até 500 caracteres

---

### Tarefas

- [ ] Criar uma branch a partir da branch "features/3-importacao-produto" da
      issue #2 com o padrao "features/3-importacao-produto-seu-nome"
- [ ] Desenvolver essa funcionalidade a partir do projeto
      McbEdu.Mentorias.ShopDemo.WebApi

</details>

<details>
    <summary>
        <strong>
            Funcionalidade 5
        </strong>
    </summary>

**Descrição:** Importação de produto em lote

**Como** usuário administrator do e-commerce

**Eu quero** poder importar produtos em lote

**Para que** esses produtos possam ser usados dentro do sistema

### Cenário 1: Importação com sucesso

**Dado** um lote de produtos

**Quando** a importação em lote for solicitada

**Então** os produtos devem ser importados se todos os produtos do lotem tiverem
sucesso

### Cenário 2: Importação com falha

**Dado** um lote de produtos

**Quando** a importação em lote for solicitada

**Então** nenhum produto deve ser importado caso qualquer um deles apresente
algum erro

**E** deve ser retornado qual o motivo do não processamento

---

### Tarefas

- [ ] Criar uma branch a partir da branch da issue #3 chamada
      "features/4-importacao-produto-lote" com o padrao
      "features/4-importacao-produto-lote-seu-nome"
- [ ] No projeto McbEdu.Mentorias.ShopDemo.WebApi, adicionar a importação em
    lote seguindo os requisitos apresentados
</details>

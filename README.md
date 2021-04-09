<h1 style="text-align: center;">Repositório Pessoal</h1>

<h2>🚀 Tecnologias</h2>
<ul>
    <li>HTML</li>
    <li>CSS
        <ul>
            <li>Boostrap</li>
        </ul>
    </li>
    <li>Javascript
        <ul>
            <li>Jquery</li>
        </ul>
    </li>
    <li>AspNetCore</li>
    <li>EntityFrameworkCore</li>
    <li>SqlServer</li>
</ul>

<h2>📝 Como Utilizar</h2>
<p>Após feito o Clone, é preciso que tenha .Net Core 3.1 instalado em sua máquina, caso queira somente rodar o programa basta baixar o Runtime! Tanto a versão SDK(para desenvolvimento) quando o Runtime estão disponíveis em:
    <a href="https://dotnet.microsoft.com/download">https://dotnet.microsoft.com/download</a>
</p>

<h2>💻 Projeto</h2>
<p>Repositório Pessoal é uma aplicação com finalidade de facilitar seu estudo. Tornando simples a anotação, organização e busca de registros! É possível criar um repositório para gravar anotações especificas, edita-las e formata-las da forma como desejar!</p>

<h4>Tela de Login</h4>
<img style="width: 800px;" src="./reameImages/login.png" alt="Imagem de login">
<p>Ao acessar o sistema, a tela inicial é a de login, caso o usuário não estja cadastrado no sistema é possível também que ele de cadastre clicando em "Não Possuo Cadastro"!</p>

<h4>Tela de Cadastro</h4>
<img style="width: 800px;" src="./reameImages/cadastro.png" alt="Imagem de cadastro">
<p>Preenchendo os campos corretamente, o usuário é adicionado ao sistema! </p>

<h4>Repositórios</h4>
<img style="width: 800px;" src="./reameImages/telaRepositorios.png" alt="Imagem de Tela Inicial">
<p>Nesta imagem temos um pefil com 15 repositórios já criados!</p>

<h4>Navegação Repositórios Para Notas</h4>
<img style="width: 800px;" src="./reameImages/navNotas.gif" alt="Navegação Repositórios Para Notas">
<p>Estamos procurando em nossos repositórios o repositório com o assunto "BOOSTRAP", entretanto não encontramos, para facilitar nossa busca, em nosso campo de pesquisa pesquisamos pelo seu nome!</p>

<h4>Busca Avançada</h4>
<img style="width: 800px;" src="./reameImages/buscaAvancada.gif" alt="Exemplificação de busca avançada!">
<p>Na situação acima, temos um repositório com 7 notas, e nosso usuário está tentando achar uma anotação sobre códigos de "Alerta", entretanto, não se lembra do título que atribuiu, por conta disso em nosso campo de busca simples, ele não encontra a anotção
    desejada. Para isso temos o campo de busca avançada! Este campo consulta em nosso banco de dados todas as notas que possuem dentro do título ou do seu próprio conteúdo a palavra chave, neste caso "Alerta". Como retorno recebemos a anotação "Mensagens
    de feedback", que continha comando de alerta utilizando bootstrap! </p>

<h4>Criando um repositório</h4>
<img style="width: 800px;" src="./reameImages/criaRepositorio.gif" alt="Criando um repositório">
<p>Neste exemplo estamos pegando uma conta com zero repositórios, e estamos adicionando o Repositório 1!</p>

<h4>Excluindo um repositório</h4>
<img style="width: 800px;" src="./reameImages/excluiRepositorio.gif" alt="Criando um repositório">
<p>Neste exemplo estamos excluindo o segundo repositório!</p>

<h4>Criando uma nota</h4>
<img style="width: 800px;" src="./reameImages/criaAnotacao.gif" alt="Criando um anotação!">
<p>Neste exemplo estamos criando uma anotação!</p>

<h4>Exibição da nota</h4>
<img style="width: 800px;" src="./reameImages/exibeNota.png" alt="Criando um anotação!">
<p>Exibição e nossa nota!</p>

<h4>Segurança de dados</h4>
<img style="width: 800px;" src="./reameImages/segurançaExcluir.gif" alt="Criando um anotação!">
<p>Pensando na segurança de nossos usuários, para prevenir que percam seus dados, bloqueamos a Função deletar em repositórios povoados, desta forma para excluir um repositório povoado, nosso usuário precisa excluior todas as notas presentes no mesmo!</p>
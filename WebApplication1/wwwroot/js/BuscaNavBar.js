var campoFiltro = document.querySelector(".form-control");

campoFiltro.addEventListener("input", () => {
    //console.log(campoFiltro.value);
    var repositorios = document.querySelectorAll(".list-group-item");
    if (campoFiltro.value.length > 0) {
        //console.log("Deu Certo")


        repositorios.forEach(repositorio => {
            var item = repositorio.querySelector(".Campo-De-Busca")
            var nome = item.textContent;

            var expressao = new RegExp(campoFiltro.value, "i")//criando expressão regular case insensitive, ignoramso se etá maiúsculo ou minúsculo
            if (!expressao.test(nome)) {//testando se a expressão(busca digitada) é diferente de nome
                repositorio.classList.add("d-none");
            } else {
                repositorio.classList.remove("d-none");
            }
        })

    } else {
        repositorios.forEach(repositorio => {
            repositorio.classList.remove("d-none");
        });
    }
});
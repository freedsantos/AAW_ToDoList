


var app = new Vue({
    el: '#app',
    data: {
        msg: "Hello World",
        dias: ['Domingo', 'Segunda', 'Terça', 'Quarta', 'Quinta', 'Sexta', 'Sábado'],
        meses: ['Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho', 'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro'],
        tarefas: [],
        tarefa: '',
    },
    computed: {
        hoje: function () {
            let novaData = new Date()
            return `${this.dias[novaData.getDay()]}, ${novaData.getDate()} de ${this.meses[novaData.getMonth()]}`
        }
    },
    methods: {
        adicionarTarefa() {
            if (this.tarefa != null) {
                let nova_tarefa = { 'description': this.tarefa, 'checked': false };
                this.tarefas.push(nova_tarefa);
                axios.post('http://localhost:50575/api/tarefas/tarefa/', nova_tarefa)
            }
            this.tarefa = "";
        },
        check(index) {
            this.tarefas[index]['checked'] = !this.tarefas[index]['checked']
        },
        remover(index) {
            this.tarefas.splice(index, 1)
            axios.delete('http://localhost:50575/api/tarefas/tarefa/' + index)
        }
    },
    mounted() {
        axios
            .get('http://localhost:50575/api/tarefas/')
            .then(response => (this.tarefas = JSON.parse(response)))
    }
});

//function Calcular(operation) {
//    var valor1 = $("#Valor1").val();
//    var valor2 = $("#Valor2").val();

//    $.post("Home/RealizarCalculo/", { Valor1: valor1, Valor2: valor2, Operacao: operation }, function (data) {
//        app.resultadoCalculo = data;
//    });
//}
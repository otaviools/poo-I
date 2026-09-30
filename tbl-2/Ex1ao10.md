## 1. O que significa polimorfismo?

- Capacidade de uma mesma operação apresentar comportamentos diferentes.

## 2. Qual é a função da palavra-chave virtual

- Virtual informa que a classe derivada poderá substituir o comportamento desse método.

## 3. Qual é a função da palavra-chave override ?

- Override indica que a classe derivada está substituindo a implementação herdada da classe base.

## 4. O que acontece quando chamamos um método sobrescrito através de uma referência da classe base?

- O tipo de referência pode ser Veiculo, enquanto o objeto real pode ser Carro ou Bicicleta. O comportamento executado depende do objeto real.

## 5. Qual é a diferença entre implementar uma interface e herdar de uma classe?

- A interface determina que uma classe que a implementar deverá fornecer o método.
- Herança representa especialização
- Interface representa um contrato ou capacidade.

## 6. Por que uma classe abstrata não pode ser instanciada?

- Pois uma classe abstrata é criada para servir de base. Objetos concretos devem ser criados a partir de classes derivadas concretas.

## 7. Qual é a diferença entre um método concreto e um método abstrato?

- Método concreto: Possui implementação, o código dentro do método determina o comportamento que será executado.
- Método Abstrato: Apenas declara a operação.

## 8. Qual é a diferença entre virtual e abstract ?

- Virtual: Define um comportamento, possui implementação e a sobrescrita é opcional;
- Abstract: Define uma obrigação para a classe derivada, não possui implementação, a implmentação é obrigatória para classes concretas derivadas.

## 9. Por que uma List<Funcionario> pode armazenar objetos Gerente e Programador ?

- A lista trabalha com o tipo comum Funcionario, mas cada objeto executa sua própria implementação de CalcularSalario().

## 10. Qual é a principal vantagem de utilizar polimorfismo em sistemas maiores?

- Facilidade de escalabilidade, reaproveitando métodos, classes, consequentemente, otimizando a estrutura do código.

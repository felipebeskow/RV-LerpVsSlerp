# Estudo do LERP

## Trabalho de Realidade Virtual sobre Lerp dentro do Unity

O Lerp é um algoritmo de interpolação entre dois pontos. Ele se caracteriza pelo trajetoria de uma linha reta entre os dois pontos.

<img src="https://raw.githubusercontent.com/felipebeskow/RV-LerpVsSlerp/main/src-img/Video.Guru_20210317_223447086.gif" width="500">

O que define em que ponto de interpolação deve estar é um fator que vai 0 a 1 para dentro da área definida e menor de -1 e mair que 1 para fora da área definida.

Um exemplo do uso do Lerp é colocar uma bola quicando, ou uma chuva.

<img src="https://raw.githubusercontent.com/felipebeskow/RV-LerpVsSlerp/main/src-img/Video.Guru_20210317_223259096.gif" width="500">

### Mas porque utilizar Lerp se a física pode fazer isso? 
O problema da física é que ela é muito custosa, ainda mais quando se tem muitos objetos.

### Como usar o Lerp no tranform de objetos

O processo é bem simples bastando usar a seguinte linha:

```csharp
transform.position = Vector3.Lerp(inicio.position, fim.position, porcentPosition);
```


## Referencias:
* https://tiborstanko.sk/lerp-vs-slerp.html
* http://www.faustofonseca.com/tutorial/unity-vector3-lerp-vs-vector3-slerp
* https://www.youtube.com/watch?v=Dl9iQ8UBi-g

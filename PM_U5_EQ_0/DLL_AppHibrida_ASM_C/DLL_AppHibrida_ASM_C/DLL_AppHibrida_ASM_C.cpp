// DLL_AppHibrida_ASM_C.cpp : Define las funciones exportadas de la aplicación DLL.
//

#include "stdafx.h"

//#include "stdio.h"
//#include "conio.h"

#include "iostream"

using namespace std;

int __stdcall suma(int a, int b) {
	//data
	int resultado;

	_asm {  //ensamblador inline

		mov eax, a
		add eax, b

		mov resultado, eax
	}

	return resultado;
}

int __stdcall resta(int a, int b) {

	int resultado;

	_asm {

		mov eax, a
		sub eax, b

		mov resultado, eax
	}

	return resultado;
}

int __stdcall multiplicacion(int a, int b) {

	int resultado;

	_asm {

		mov eax, a
		mul b

		mov resultado, eax
	}

	return resultado;
}

double __stdcall division(int a, int b) {

	int cociente;
	int residuo;

	_asm {
		mov edx, 0
		mov eax, a
		div b

		mov cociente, eax  //cociente
		mov residuo, edx //residuo
	}
	// 5/2  = 2 enteros + 1/2    ---> 1 = residuo    2 = divisor   
	return cociente + residuo / (double)b;
}

#pragma region PROGRAMA EJEMPLO _ puede votar
	//Checar si una persona puede votar
	
int __stdcall puedoVotar(int edad) {
	int resultado = 0; // 0 si no se puede, y 1 si se puede

	_asm {
	
		mov eax, edad

		cmp eax, 18

		Jl continuar
		
			mov resultado, 1

		continuar:
	}

	return resultado;
}

#pragma endregion

#pragma region PROGRAMA EJEMPLO _ discriminante
//obtener el discriminante de una ecuacionde segundo grado
// b^2 - 4 * a * c

int __stdcall discriminante(int a, int b, int c) {
	int resultado = 0; 

	_asm {

			mov eax, b
			mul eax

			mov b,eax

			mov eax, 4
			mul a
			mul c

			xchg b, eax

			sub eax, b

			mov resultado, eax
	}

	return resultado;
}

#pragma endregion

#pragma region PROGRAMA EJEMPLO _ IMC

// IMC = peso / (altura * altura)

int __stdcall calc_IMC(int peso, int altura) {
	int resultado = 0; 

	_asm {

		mov eax, altura
		mul eax; altura al cuadrado

		mov ebx, eax		; altura al cuadrado

		mov edx, 0

		mov eax, peso

		div ebx   ;eax/ebx 

		mov resultado, eax

	}

	return resultado;
}

#pragma endregion

#pragma region PROGRAMA EJEMPLO _ Manhattan

// |P1_xi - P2_xi|

int __stdcall calc_difAbs(int P1_xi, int P2_xi) {
	int resultado = 0; 

	_asm {
		mov eax, P1_xi
		mov ebx, P2_xi

		sub eax, ebx

		cmp eax, 0

		jL Ml
		jmp continuar

		Ml:
			mov ecx, -1
			mul ecx

		continuar:
				mov resultado, eax

	}

	return resultado;
}

#pragma endregion

#pragma region PROGRAMA EJEMPLO _ SumaDosNumeros

// 

int __stdcall SumaDosNumeros(int P1, int P2) {
	int resultado = 0;

	_asm {
		
		mov eax, P1
		add eax, P2

		mov resultado, eax

	}

	return resultado;
}

#pragma endregion

#pragma region PROGRAMA EJEMPLO _ Identificar Si X se encuentra en el intervalo [Z-Y]

// 

int __stdcall ChecarX(int X, int Z, int Y) {
	int resultado = 0; //0 no se encuentra 1, se encuentra

	_asm {
		mov eax, X

		cmp eax, Z

		jl ending
		; si es mayor o igual

		cmp eax, Y
		ja ending
		; si es menor o igual
		
		mov resultado, 1

		ending:

	}

	return resultado;
}

#pragma endregion

#pragma region EJEMPLO CON ARREGLOS

int* __stdcall enviar_arreglo() //int[]
{
	int tot_elementos = 3;
	int *arreglo = new int[tot_elementos + 1];
	arreglo[0] = tot_elementos; //La primera posicion se emplea para indicar la cantidad de elementos del arreglo
	arreglo[1] = 11;
	arreglo[2] = 9;
	arreglo[3] = 19;

	return arreglo;
}

int __stdcall LiberarMemoria(int* arreglo)
{
	delete[] arreglo;
	return 0;
}


//Ejemplo de arreglo recibido como argumento
double __stdcall promedio(int *arreglo)
{
	double prom = 0;
	
	for (int i = 0; i < sizeof(arreglo); i++)
	{
		prom += arreglo[i];
	}
	
	prom /= sizeof(arreglo);

	return prom;
}

//Consumo con asm inline de arreglo recibido como argumento
int* __stdcall asm_prueba(int *arreglo)
{	
	//arreglo[2] = ?;
	
	_asm {
		mov esi, arreglo 
		mov eax, 20
		mov dword ptr[esi+8], eax
	}
	

	return arreglo;
}

#pragma endregion

#pragma region EJEMPLO CON STRING

int __stdcall largo_cadena(const char* str) {	
	int len = strlen(str);
	return len;
}

//Reescribir el contenido de una cadena que se obtuvo desde c#
int __stdcall escribir_cadena(char* str, int len_buffer) {
	const char* aux = "GARUCO Te MATARA"; //debe ser menor que len_buffer
	int len = strlen(aux);
	for (int i = 0; i < len; i++)
	{
		str[i] = aux[i];
	}
	return len;
}

#pragma endregion

#pragma region PROGRAMAS 2023 1

int __stdcall promedioDeUsuario(char* nombre, int cal1, int cal2, int cal3) {
		//a nombre no se le hara ningun cambio en este programa ...
	
	int prom;
	int pDecimal;

	_asm {
		mov eax, 0
		add eax, cal1
		add eax, cal2
		add eax, cal3

		mov edx, 0
		mov ecx, 3
		div ecx

		mov pDecimal, edx
		mov prom, eax
	}

	prom += pDecimal / 3;
	return prom;
}


int __stdcall promUsuario(char* cadRes,char* nombre, int cal1, int cal2, int cal3) {
	//a nombre no se le hara ningun cambio en este programa ...

	int prom;
	int pDecimal;

	_asm {
		mov eax, 0
		add eax, cal1
		add eax, cal2
		add eax, cal3

		mov edx, 0
		mov ecx, 3
		div ecx

		mov pDecimal, edx
		mov prom, eax
	}

	prom += pDecimal / 3;

	int c = 0;
	const char* aux = " tienes un promedio de: "; //debe ser menor que len_buffer

	//cadRes = ""
	//agregar a cadRes el nombre del alumno
	// cadRes = cadRes + nombre
	int len = strlen(nombre);
	for (int i = 0; i < len; i++)
	{
		cadRes[c] = nombre[i];
		c++;
	}
	
	//cadRes = cadRes + aux
	//agregar el contenido de aux a cadRes...
	len = strlen(aux);
	for (int i = 0; i < len; i++)
	{
		cadRes[c] = aux[i];
		c++;
	}

	//cadRes = cadRes + prom
	if (prom == 10) {
		cadRes[c] = 49;
		c++;
		cadRes[c] = 48;
	}
	else {
		cadRes[c] = prom + 48;
	}

	c++;  //retorna la cantidad de caracteres en la palabra ...

		return c;
}


int __stdcall fibunacci(int t0, int t1) {
	int tn;

	_asm {
		mov eax, t0
		mov ebx, t1

		add eax, ebx
		mov tn, eax
		
	}
	return tn;
}


int __stdcall velocidad(char* cadRes, char* nombre, int distancia, int tiempo) {
	//a nombre no se le hara ningun cambio en este programa ...
	
	//velocidad = distancia / tiempo

	int velocidad;
	int pDecimal;

	_asm {
		mov eax, distancia
		mov ebx, tiempo
		
		mov edx, 0

		div ebx // eax / ebx  => distancia / tiempo

		mov pDecimal, edx
		mov velocidad, eax
	}

	//velocidad += pDecimal / tiempo;

	int c = 0; //inicio de la cadena resultado 	

	c += addCadena2Cadena(cadRes, c, nombre);

	const char* aux = " tiene una velociad de: "; //debe ser menor que len_buffer
	c += addCadena2Cadena(cadRes, c, aux);

	
	//Params: cadena en la que se concatenara, posicion de inicio del numero, numero a concatenar 
	c += addNum2Cadena(cadRes, c, velocidad);
	//retorna la cantidad de caracteres en la palabra ...	
	return c;
}


int* __stdcall sumaNumerosVector(char* cadRes, char* nombre, int* vector) {	

	//dword = int

	_asm {
		mov esi, vector	//almacena la ubicacion de memoria del vector (donde inicia)
		mov edi, esi //respaldo de la posicion de iniciio del vector..

		//como en nuestro vector la primera posicion es cuantos elementos tenemos, entonces
		//se mueve a ecx, la primera posicion para obtener la 
		mov ecx, dword ptr[esi] //cantidad de elementos que tiene el arreglo

		//la primera posicion "activa" / util para el vector, es la tercera posicion
		// como empieza en cero, la tercera posicion es igual a sumarle 8 a la posicion inicial
		// 0 = 1era   4 = 2da pos  8 = 3era pos...
		add esi, 8  //apartir de aqui operar con arreglo....

		//se va  usar eax, como un acumulador , entonces por eso se inicializa en 0
		mov eax, 0

		//inicio del ciclo
		ciclo:
			add eax, dword ptr[esi] //obtiene el valor de la posicion actual del apuntador..y lo suma al acumulado
			add esi, 4 //se le suma 4 a esi, porque cada elemento en el vector se separa por 4 bytes
			loop ciclo //repite el acceso al vector para realizar la suma la cantidad de elementos "activos" que tenga el vector

		//a la posicion de origen respaldada (edi) se le esta sumana 4, para acceder a la segunda posicion del vector
		//asociada al acumulador...una vez en esta posicion se almacena en ella la suma de los digitos del vector
		mov dword ptr[edi+4], eax 
	}

	return vector;
}


int* __stdcall comparaNumeros(char* cadRes, char* nombre, int* vector) {

	int c = 0;

	_asm {
		mov esi, vector
		mov edi, esi

		mov ecx, dword ptr[esi] //cantidad de elementos que tiene el arreglo
		add esi, 8  //apartir de aqui operar con arreglo....

		mov eax, 0
		ciclo:
		add eax, dword ptr[esi]
			add esi, 4
			loop ciclo

			mov dword ptr[edi + 4], eax
	}

	return vector;
}



int __stdcall addCadena2Cadena(char* cadRes, int indice, const char* cadena) {
	
	int len = strlen(cadena);
	for (int i = 0; i < len; i++) //recorre cada caracter del nombre del carrito
	{
		cadRes[indice] = cadena[i];
		indice++;
	}
	return len;
}


int __stdcall addNum2Cadena(char* cadRes, int indice, int numero) {
	//buscar cuantos digitos tiene la variables
	int tempNumero = numero;
	int cont = 0; //almacena el total de digitos-1
	while (tempNumero >= 10) {
		tempNumero /= 10;
		cont++;
	}

	//X  = 1
	//XX =  10
	//XXX = 100
	//XXXX = 1000

	if (cont >= 1) { //se entra solo cuando son dos o mas digitos los que componen al numero
		int div = 10;
		for (int i = 0; i < cont - 1; i++) { //busca encontrar al divisor
			div = div * 10;
		}

		while (numero > 10) { //obtener el digito mas a la izquierda ... 
			int t = numero / div;
			cadRes[indice] = t + 48;
			indice++;
			numero = numero % div;
			div = div / 10;
		}
		cadRes[indice] = numero + 48;
		indice++;

	}
	else { //con  = 0
		cadRes[indice] = numero + 48;
		indice++;
	}

	return cont+1;
}



#pragma endregion

#pragma region ProyectoIntegrador
int __stdcall valida_num(int* vector) {
	//1 = valido    0 = no valido
	int res;

	//total de iteraciones que realizara cada ciclo... para un mejor entendimiento
	int t_ciclo1; 
	int t_ciclo2;

	int backup; //para almacenar el indice en los ciclos anidados
	//debido a que no se puede usar la pila y mul puede afectar a edx

	_asm {
		mov esi, vector	//almacena la ubicacion de memoria del vector (donde inicia)		

		//como en nuestro vector la primera posicion corresponde al total de elementos que tenemos,
		// entonces, se mueve a eax, la primera posicion para obtener la 
		//cantidad de elementos que tiene el arreglo
		mov eax, dword ptr[esi] 
		mov t_ciclo2, eax; //cantitdad total de elementos
		dec eax
		mov t_ciclo1, eax // para no desperdiciar iteraciones (el ultimo se comparara con nadie)

		cmp t_ciclo2, 0 //comprueba cuantos elementos tiene el arreglo

		//si la cantidad de elementos es mayor de 0, entonces procede a validar, sino, devuelve 0 (no valido)
		jg valida_numero
			// si es menor igual hara esto: 
			jmp no_valido

		valida_numero :
		
		//la primera posicion "activa" / util para el vector, es la segunda posicion
		// como empieza en cero, la segunda posicion es igual a sumarle 4 a la posicion inicial
		// 0 = 1era   4 = 2da pos  8 = 3era pos...
		add esi, 4  //apartir de aqui operar con arreglo....

		mov ecx, 0  //indice del ciclo
			
		//inicio del ciclo
			ciclo1:
				mov backup, ecx; respalda
				mov eax, 4
				mul ecx
				mov ebx, dword ptr[esi + eax]
				inc ecx

				ciclo2 :
					mov eax, 4
					mul ecx
					mov eax, dword ptr[esi + eax]

					cmp ebx, eax

					jz no_valido

					inc ecx
					cmp ecx, t_ciclo2

					jl ciclo2

			mov ecx, backup
			inc ecx
			cmp ecx, t_ciclo1
			jl ciclo1

			mov res, 1

			jmp salir

		no_valido :
			mov res, 0

		salir :			
		
	}

	return res;
}

int __stdcall contar_fijas(int* num_pc, int* num_user) {	
	int fijas = 0;
	
	int t_digits;	
	
	_asm {
		mov esi, num_pc	//almacena la ubicacion de memoria del vector (donde inicia)
		mov edi, num_user

		//como en nuestro vector la primera posicion corresponde al total de elementos que tenemos,
		// entonces, se mueve a eax, la primera posicion para obtener la 
		//cantidad de elementos que tiene el arreglo
		mov eax, dword ptr[esi]
		mov t_digits, eax; //cantitdad total de elementos
		
		//la primera posicion "activa" / util para el vector, es la segunda posicion
		// como empieza en cero, la segunda posicion es igual a sumarle 4 a la posicion inicial
		// 0 = 1era   4 = 2da pos  8 = 3era pos...
		add esi, 4  //apartir de aqui operar con arreglo....
		add edi, 4

		mov ecx, 0  //indice del ciclo

		//inicio del ciclo
		ciclo:			
			mov eax, 4
			mul ecx

			//digito 1
			mov edx, dword ptr[esi + eax]

			//digito 2
			mov ebx, dword ptr[edi + eax]

			cmp edx, ebx

			jnz continuar
				//si es igual
				inc fijas	

			continuar:

				inc ecx
				cmp ecx, t_digits
				jl ciclo
					
	}

	return fijas;                                                                                                                                          
}

int __stdcall contar_picas(int* num_pc, int* num_user) {	
	int picas = 0;

	//total de iteraciones que realizara cada ciclo... para un mejor entendimiento
	int t_digits;	

	int backup; //para almacenar el indice en los ciclos anidados
	//debido a que no se puede usar la pila y mul puede afectar a edx

	_asm {
		mov esi, num_pc	//almacena la ubicacion de memoria del vector (donde inicia)
		mov edi, num_user

		//como en nuestro vector la primera posicion corresponde al total de elementos que tenemos,
		// entonces, se mueve a eax, la primera posicion para obtener la 
		//cantidad de elementos que tiene el arreglo
		mov eax, dword ptr[esi]
		mov t_digits, eax; //cantitdad total de elementos
		
		//la primera posicion "activa" / util para el vector, es la segunda posicion
		// como empieza en cero, la segunda posicion es igual a sumarle 4 a la posicion inicial
		// 0 = 1era   4 = 2da pos  8 = 3era pos...
		add esi, 4  //apartir de aqui operar con arreglo....
		add edi, 4

		mov ecx, 0  //indice del ciclo

		//inicio del ciclo
		ciclo1:
			mov backup, ecx // respalda
			mov eax, 4
			mul ecx
			//digito 1
			mov ebx, dword ptr[esi + eax]
			
			mov ecx, 0

			ciclo2 :
				mov eax, 4
				mul ecx
				//digito 2
				mov edx, dword ptr[edi + eax]

				cmp ebx, edx

				jnz continuar 
					//si es igual
					cmp ecx, backup
					// si no es pica salta el incremento
					jz break_
						inc picas
					break_: // entra aqui siempre
						mov ecx, t_digits // para somper el ciclo2


				continuar :
					inc ecx
					cmp ecx, t_digits
					jl ciclo2

			mov ecx, backup
			inc ecx
			cmp ecx, t_digits
			jl ciclo1
			
	}

	return picas;
}

int __stdcall valida_solucion(char* cadena_resultado, int* num_pc, int* num_user) {
		
	//return ## <-- largo de la cadena resultado

	int c = 0; //inicio de la cadena resultado 	
	
	int fijas = contar_fijas(num_pc, num_user);
	int picas = contar_picas(num_pc, num_user);
	const char* separador = "-"; //debe ser menor que len_buffer

	c += addNum2Cadena(cadena_resultado, c, fijas);

	c += addCadena2Cadena(cadena_resultado, c, separador);

	c += addNum2Cadena(cadena_resultado, c, picas);
	
	//retorna la cantidad de caracteres en la palabra ...	
	return c;
}


#pragma endregion
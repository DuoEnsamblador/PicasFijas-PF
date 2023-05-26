// stdafx.h: archivo de inclusión de los archivos de inclusión estándar del sistema,
// o archivos de inclusión específicos de un proyecto utilizados frecuentemente, pero
// son rara vez modificados
//

#pragma once

#include "targetver.h"

#define WIN32_LEAN_AND_MEAN             // Excluir material rara vez utilizado de encabezados de Windows
// Archivos de encabezado de Windows
#include <windows.h>

int __stdcall addNum2Cadena(char* cadRes, int indice, int numero);
int __stdcall addCadena2Cadena(char* cadRes, int indice, const char* cadena);

// hacer referencia aquí a los encabezados adicionales que el programa necesita
extern "C" __declspec(dllexport) int __stdcall suma(int a, int b);
extern "C" __declspec(dllexport) int __stdcall resta(int a, int b);
extern "C" __declspec(dllexport) int __stdcall multiplicacion(int a, int b);
extern "C" __declspec(dllexport) double __stdcall division(int a, int b);

extern "C" __declspec(dllexport) int __stdcall puedoVotar(int edad);
extern "C" __declspec(dllexport) int __stdcall discriminante(int a, int b, int c);
extern "C" __declspec(dllexport) int __stdcall calc_IMC(int peso, int altura);
extern "C" __declspec(dllexport) int __stdcall calc_difAbs(int P1_xi, int P2_xi);
extern "C" __declspec(dllexport) int __stdcall SumaDosNumeros(int P1, int P2);
extern "C" __declspec(dllexport) int __stdcall ChecarX(int X, int Z, int Y);

extern "C" __declspec(dllexport) int __stdcall largo_cadena(const char* str);
extern "C" __declspec(dllexport) int __stdcall escribir_cadena(char* str, int len_buffer);

extern "C" __declspec(dllexport) int* __stdcall enviar_arreglo();
extern "C" __declspec(dllexport) int __stdcall LiberarMemoria(int* arreglo);
extern "C" __declspec(dllexport) double __stdcall promedio(int *arreglo);
extern "C" __declspec(dllexport) int* __stdcall asm_prueba(int *arreglo);

//Programas unidad 4 - 2023-1
extern "C" __declspec(dllexport) int __stdcall promedioDeUsuario(char* nombre, int cal1, int cal2, int cal3);

extern "C" __declspec(dllexport) int __stdcall promUsuario(char* cadRes, char* nombre, int cal1, int cal2, int cal3);

extern "C" __declspec(dllexport) int __stdcall fibunacci(int t0, int t1);

extern "C" __declspec(dllexport) int __stdcall velocidad(char* cadRes, char* nombre, int distancia, int tiempo);

extern "C" __declspec(dllexport) int* __stdcall sumaNumerosVector(char* cadRes, char* nombre, int* vector);

extern "C" __declspec(dllexport) int* __stdcall comparaNumeros(char* cadRes, char* nombre, int* vector);


//proyecto ingrador
extern "C" __declspec(dllexport) int __stdcall valida_num(int* vector);

extern "C" __declspec(dllexport) int __stdcall contar_fijas(int* num_pc, int* num_user);

extern "C" __declspec(dllexport) int __stdcall contar_picas(int* num_pc, int* num_user);

extern "C" __declspec(dllexport) int __stdcall valida_solucion(char* cadena_resultado, int* num_pc, int* num_user);
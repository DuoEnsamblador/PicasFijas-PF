TITLE Trabajo 1
;DESCRPICI�N 
;Objetivo: Primera ejec�ci�n de masm
;
; Autore(s):
;         Garc�a Ruiz Alejandro H.
; Semestre: 8vo Semestre ISC 
;FIN DESCRPICI�N
INCLUDE Irvine32.inc  
.data
; �rea de Declaraci�n de Variables
fijas dword ? 
t_digits dword ? 
num_pc dword 4, 1, 5, 6, 8
num_user dword 4, 1, 4, 6, 8                

.code
	mainP2 PROC
		;L�gica del Programa

		mov esi, offset num_pc	
		mov edi, offset num_user
		
		mov eax, dword ptr[esi]
		mov t_digits, eax; 
				
		add esi, 4
		add edi, 4

		mov ecx, 0 
		
		ciclo:			
		mov eax, 4
			mul ecx

		
			mov edx, dword ptr[esi + eax]
	
			mov ebx, dword ptr[edi + eax]

			cmp edx, ebx

			jnz continuar
				inc fijas	

			continuar:

				inc ecx
				cmp ecx, t_digits
				jl ciclo
					


		exit	

	mainP2 ENDP
	END mainP2
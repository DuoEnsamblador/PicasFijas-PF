import ctypes    #incluido en las librerias base de python 3.0+

testDLL = ctypes.WinDLL("SubCarpeta/DLL_AppHibrida_ASM_C.dll")

print(testDLL.suma(12,4))
print(testDLL.resta(12,4))
print(testDLL.multiplicacion(12,4))
print(testDLL.division(12,4))

######################################################################################

print("\n",testDLL.division(10,3))

testDLL.division.restype = ctypes.c_double
res = testDLL.division(10,3)
print(res)


######################################################################################

import numpy
testDLL.promedio.restype = ctypes.c_double
#                            [ctypes.c_int, numpy.ctypeslib.ndpointer(dtype=numpy.int32)]
testDLL.promedio.argtypes =  [(numpy.ctypeslib.ndpointer(dtype=numpy.int32))]

array = numpy.array([8, 5, 7,6])

resultado = testDLL.promedio(array)
print("\n",resultado)

######################################################################################

testDLL.enviar_arreglo.restype = numpy.ctypeslib.ndpointer(dtype=ctypes.c_int32, shape=(4,))
resultado = testDLL.enviar_arreglo()

print("\n",resultado)
#include "LinkedList.h"
#ifndef EMPLEADO_H_INCLUDED
#define EMPLEADO_H_INCLUDED

struct S_Empleado
{
  int id;
  char nombre[128];
  int horasTrabajadas;
  int sueldo;
};
typedef struct S_Empleado Empleado;

int employee_generaId(void);
void employee_setIdInicial(int value);

Empleado* employee_new();
Empleado* employee_newParametrosInt(int id,char* nombreStr,int horasTrabajadas);
Empleado* employee_newParametros(char* idStr,char* nombreStr,char* horasTrabajadasStr);
int employee_delete(Empleado* this);

int employee_setId(Empleado* this,int id);
int employee_setIdStr(Empleado* this,char* id);
int employee_getId(Empleado* this,int* id);

int employee_setNombre(Empleado* this,char* nombre);
int employee_getNombre(Empleado* this,char* nombre);

int employee_setHorasTrabajadas(Empleado* this,int horasTrabajadas);
int employee_setHorasTrabajadasStr(Empleado* this,char* horasTrabajadas);
int employee_getHorasTrabajadas(Empleado* this,int* horasTrabajadas);

int employee_findEmployeeById(LinkedList* pArrayListEmployee, int id);
int employee_comparaPorNombre(void *this,void *that);

int controller_PrintEmployee(LinkedList* pArrayListEmployee, int index);
void em_calcularSueldo(void* p);

#endif // EMPLEADO_H_INCLUDED

################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
../src/Empleado.c \
../src/LinkedList.c \
../src/Parser.c \
../src/controller.c \
../src/main.c \
../src/utn.c 

OBJS += \
./src/Empleado.o \
./src/LinkedList.o \
./src/Parser.o \
./src/controller.o \
./src/main.o \
./src/utn.o 

C_DEPS += \
./src/Empleado.d \
./src/LinkedList.d \
./src/Parser.d \
./src/controller.d \
./src/main.d \
./src/utn.d 


# Each subdirectory must supply rules for building sources it contributes
src/%.o: ../src/%.c
	@echo 'Building file: $<'
	@echo 'Invoking: GCC C Compiler'
	gcc -O0 -g3 -Wall -c -fmessage-length=0 -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '



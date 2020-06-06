#include "FirstTwoVariablesFunction.h"

FirstTwoVariablesFunction::FirstTwoVariablesFunction(double x, double y){
	this->x = x;
	this->y = y;
}

double FirstTwoVariablesFunction::Calculate(){
	return (x * x + sqrt(3 * y * y * y));
}

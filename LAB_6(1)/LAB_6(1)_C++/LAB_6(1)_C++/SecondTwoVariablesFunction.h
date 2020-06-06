#pragma once
#include "TwoVariablesFunction.h"
class SecondTwoVariablesFunction : public TwoVariablesFunction {
private:
	double x, y;
public:
	SecondTwoVariablesFunction(double x, double y);
	double Calculate();
};


#pragma once
#include "TwoVariablesFunction.h"
#include <cmath>

class FirstTwoVariablesFunction : public TwoVariablesFunction {
public:
	FirstTwoVariablesFunction(double x, double y);
	double Calculate();

private:
	double x, y;
};


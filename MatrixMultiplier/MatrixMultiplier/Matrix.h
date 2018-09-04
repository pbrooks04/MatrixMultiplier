#pragma once
#include <iostream>
#include <cmath>

class MatrixMxN {
public:
	MatrixMxN();
	MatrixMxN(int rows, int columns);

	int getNumRows();
	int getNumColumns();
	
	double getValue(int row, int col);
	void setValue(int row, int col, double value);

private:
	double *m_data;
	int num_rows;
	int num_cols;
};

MatrixMxN operator *(MatrixMxN& A, MatrixMxN& B);
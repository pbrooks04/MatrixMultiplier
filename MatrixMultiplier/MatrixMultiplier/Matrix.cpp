#include "Matrix.h"

MatrixMxN::MatrixMxN() {

}

MatrixMxN::MatrixMxN(int rows, int cols) {
	num_rows = rows;
	num_cols = cols;
	m_data = new double[rows*cols];
	for (int i = 0; i < rows*cols; ++i) {
		m_data[i] = 0.0;
	}
}

int MatrixMxN::getNumRows() {
	return num_rows;
}

int MatrixMxN::getNumColumns() {
	return num_cols;
}

double MatrixMxN::getValue(int row, int col) {
	return m_data[num_cols*row + col];
}

void MatrixMxN::setValue(int row, int col, double value) {
	m_data[num_cols*row + col] = value;
}

MatrixMxN operator *(MatrixMxN& a, MatrixMxN& b) {
	int rows = a.getNumRows();
	int cols = b.getNumColumns();
	int steps = a.getNumColumns();


	if (a.getNumColumns() != b.getNumRows()) {
		exit(1);
	}

	MatrixMxN ret(rows, cols);

	for (size_t i = 0; i < rows; ++i) {
		for (size_t j = 0; j < cols; ++j) {
			double result = 0.0;
			for (int k = 0; k < steps; ++k) {
				result += a.getValue(i, k) * b.getValue(k, j);
			}
			ret.setValue(i, j, result);
		}
	}

	return ret;
}
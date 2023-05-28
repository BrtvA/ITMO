import multiprocessing

'''
Реализации алгоритма DGEMM
'''


def transpose_matrix(matrix):
    transposed_matrix = [[0 for col in range(len(matrix))] for row in range(len(matrix[0]))]
    for row in range(len(matrix)):
        for col in range(len(matrix[0])):
            transposed_matrix[col][row] = matrix[row][col]
    return transposed_matrix


def multiply_part(items):
    row, matrix_a, matrix_b = items
    part_result = [0 for row in range(len(matrix_a[0]))]
    for col in range(len(matrix_b[0])):
        for idx in range(len(matrix_b)):
            part_result[col] += matrix_a[row][idx] * matrix_b[idx][col]
    return part_result


def multiply_matrices_parallel(matrix_a, matrix_b, thread_count):
    result = []
    with multiprocessing.Pool(processes=thread_count) as pool:
        items = [(row, matrix_a, matrix_b) for row in range(len(matrix_a))]
        for row in pool.map(multiply_part, items):
            result.append(row)
    return result


def multiply_matrices(matrix_a, matrix_b):
    result = [[0 for col in range(len(matrix_b[0]))] for row in range(len(matrix_a))]
    for row in range(len(matrix_a)):
        for col in range(len(matrix_b[0])):
            for idx in range(len(matrix_b)):
                result[row][col] += matrix_a[row][idx] * matrix_b[idx][col]
    return result


def add_matrices(matrix_a, matrix_b):
    for row in range(len(matrix_a)):
        for col in range(len(matrix_a[0])):
            matrix_a[row][col] += matrix_b[row][col]
    return matrix_a


def multiply_by_scalar(matrix, scalar):
    for row in range(len(matrix)):
        for col in range(len(matrix[0])):
            matrix[row][col] *= scalar
    return matrix


# def dgemm(matrix_a, matrix_b, trans_a, trans_b, alfa, betta, start_count):
#     if trans_a != 0:
#         matrix_a = transpose_matrix(matrix_a)
#     if trans_b != 0:
#         matrix_b = transpose_matrix(matrix_b)
#
#     result = []
#     for idx in range(start_count):
#         expression = multiply_by_scalar(multiply_matrices(matrix_a, matrix_b), alfa)
#         if idx == 0:
#             result = expression
#         else:
#             result = add_matrices(expression,
#                                   multiply_by_scalar(result, betta))
#
#     return result


def dgemm(matrix_a, matrix_b, trans_a, trans_b, alfa, betta, thread_count, result):
    if trans_a != 0:
        matrix_a = transpose_matrix(matrix_a)
    if trans_b != 0:
        matrix_b = transpose_matrix(matrix_b)

    if thread_count > 0:
        mult_result = multiply_matrices_parallel(matrix_a, matrix_b, thread_count)
    else:
        mult_result = multiply_matrices(matrix_a, matrix_b)
    expression = multiply_by_scalar(mult_result, alfa)
    if result == []:
        result = expression
    else:
        result = add_matrices(expression,
                              multiply_by_scalar(result, betta))

    return result

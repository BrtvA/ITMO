def get_count_neighbours(matrix, pos_y, pos_x, width, height):
    count = 0

    for idx_i in range(-1, 2):
        for idx_j in range(-1, 2):
            col = (pos_x + idx_i + width) % width
            row = (pos_y + idx_j + height) % height
            is_self_checking = col == pos_x and row == pos_y

            has_life = matrix[row][col]
            if has_life and not is_self_checking:
                count += 1

    return count


def generate_frame(matrix):
    row_count = len(matrix)
    col_count = len(matrix[0])

    for idx_i in range(0, row_count):
        for idx_j in range(0, col_count):
            neighbours_count = get_count_neighbours(matrix, idx_i, idx_j, col_count, row_count)
            has_life = matrix[idx_i][idx_j]

            if not has_life and neighbours_count == 3:
                matrix[idx_i][idx_j] = True
            elif has_life and (neighbours_count < 2 or neighbours_count > 3):
                matrix[idx_i][idx_j] = False
            else:
                matrix[idx_i][idx_j] = matrix[idx_i][idx_j]

    return matrix

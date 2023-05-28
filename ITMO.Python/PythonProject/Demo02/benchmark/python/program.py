from starter import start_benchmark

'''
Основной блок программы
'''

if __name__ == '__main__':
    input_path, data_type = input("[Python] Введите входной путь => ").split()
    print("[Python] Входной путь: " + input_path)
    print(f"[Python] {start_benchmark(input_path)}")
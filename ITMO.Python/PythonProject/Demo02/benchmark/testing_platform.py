from subprocess import Popen, PIPE
from data_generator import start_data_creator
from statistics_manager import get_statistics, write_statistics_data
from graph_builder import plot_graps

is_continue = True


def start_process(config, message, encoding_standard):
    process = Popen(config, stdout=PIPE, stdin=PIPE)
    output = process.communicate(input=message.encode())[0]
    answer = output.decode(encoding_standard)
    list_answer = answer.split()
    time_result = float(list_answer[len(list_answer) - 1])
    if time_result < 0:
        raise ValueError(f"Ошибка выполнения процесса {config[0]}")
    return answer, time_result


def test_bench(path_list, data_type):
    python_list = []
    java_list = []
    csharp_list = []

    for path in path_list:
        request = f"{path} {data_type}"

        python_answer, python_result = start_process(['python', 'python/program.py'],
                                                     request, 'utf-8')
        print(python_answer)
        python_list.append(python_result)

        java_answer, java_result = start_process(['java', '-jar', 'java/out/artifacts/java_jar/java.jar'],
                                                 request, 'cp1251')
        print(java_answer)
        java_list.append(java_result)

        csharp_answer, csharp_result = start_process(['csharp/csharp/bin/Debug/net6.0/csharp.exe'],
                                                     request, 'cp866')
        print(csharp_answer)
        csharp_list.append(csharp_result)

    return python_list, java_list, csharp_list


'''
Основной блок программы
'''

# current_dir = r"D:\Practice01\PythonProject\Demo02\benchmark\csharp\csharp\bin\Debug\net6.0"
# p2 = Popen(os.path.join(current_dir, "csharp.exe"), stdout=PIPE, stdin=PIPE, stderr=PIPE)
try:
    input_list, type_name, row_list, thread_count = start_data_creator()
    python_time, java_time, csharp_time = test_bench(input_list, type_name)
except ValueError as e:
    is_continue = False
    print("\033[31m{}".format(e))

if is_continue:
    python_json = get_statistics(python_time)
    java_json = get_statistics(java_time)
    csharp_json = get_statistics(csharp_time)

    print(python_json)
    print(java_json)
    print(csharp_json)

    if (thread_count > 0):
        name_count_processing = f"multiprocessing_{thread_count}"
    else:
        name_count_processing = "singleprocessing"

    write_statistics_data(f'data/{type_name}_{name_count_processing}_statistics.csv', python_json, java_json, csharp_json)

    plot_graps(python_time, java_time, csharp_time,
               row_list, type_name, f"data/{type_name}_{name_count_processing}.png")

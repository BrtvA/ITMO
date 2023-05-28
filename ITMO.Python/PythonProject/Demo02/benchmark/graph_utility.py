import csv
import matplotlib.pyplot as plt

PATH = "data/Big_Integer/"
DATA_TYPE = "BigInteger"

filename_list = ["BigInteger_singleprocessing_statistics.csv",
                 "BigInteger_multiprocessing_2_statistics.csv",
                 "BigInteger_multiprocessing_6_statistics.csv",
                 "BigInteger_multiprocessing_8_statistics.csv"]
thread_list = [1, 2, 6, 8]


def read_csv(filename):
    rows = []
    with open(filename, "r") as fh:
        reader = csv.reader(fh)
        rows = list(reader)
    return round(float(rows[2][3]), 1), round(float(rows[4][3]), 1), round(float(rows[6][3]), 1)


def plot_graps(array_python, array_java, array_csharp, thread_list, data_type, output_path):
    dpi = 80
    fig = plt.figure(dpi=dpi, figsize=(512 / dpi, 384 / dpi))

    plt.plot(thread_list, array_python, 'ro-')
    plt.plot(thread_list, array_java, 'go-')
    plt.plot(thread_list, array_csharp, 'bo-')

    title = f"Data type - {data_type}"
    plt.suptitle(title)
    plt.xlabel('Thread count')
    plt.ylabel('Mean running time, ms')

    plt.legend(['python',
                'java',
                'csharp'], loc='upper left')

    fig.savefig(output_path)
    plt.show()


'''
Основной блок программы
'''

python_time = []
java_time = []
csharp_time = []
for filename in filename_list:
    python_value, java_value, csharp_value = read_csv(f"{PATH}{filename}")
    python_time.append(python_value)
    java_time.append(java_value)
    csharp_time.append(csharp_value)

plot_graps(python_time, java_time, csharp_time, thread_list, DATA_TYPE, f"{PATH}{DATA_TYPE}_time_thread_count.png")

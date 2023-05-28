import matplotlib.pyplot as plt


def plot_graps(array_python, array_java, array_csharp, row_list, data_type, output_path):
    dpi = 80
    fig = plt.figure(dpi=dpi, figsize=(512 / dpi, 384 / dpi))

    plt.plot(row_list, array_python, 'ro-')
    plt.plot(row_list, array_java, 'go-')
    plt.plot(row_list, array_csharp, 'bo-')

    title = f"Data type - {data_type}"
    plt.suptitle(title)
    plt.xlabel('Row (column) count')
    plt.ylabel('Time interval, ms')

    plt.legend(['python',
                'java',
                'csharp'], loc='upper left')

    fig.savefig(output_path)
    plt.show()

import csv
from statistics import mean, median, pstdev


def get_statistics(time_list):
    min_value = min(time_list)
    max_value = max(time_list)
    mean_value = mean(time_list)
    median_value = median(time_list)
    std_dev_value = pstdev(time_list)

    data = {
        "min_value": min_value,
        "max_value": max_value,
        "mean_value": mean_value,
        "median_value": median_value,
        "std_dev_value": std_dev_value,
        "time_interval": time_list
    }

    return data


def write_statistics_data(output_path, python_data, java_data, csharp_data):
    with open(output_path, 'w') as csvfile:
        fieldnames = ['min_value', 'max_value', 'mean_value', 'median_value', 'std_dev_value', 'time_interval']
        writer = csv.DictWriter(csvfile, fieldnames=fieldnames)
        writer.writeheader()
        writer.writerow(python_data)
        writer.writerow(java_data)
        writer.writerow(csharp_data)

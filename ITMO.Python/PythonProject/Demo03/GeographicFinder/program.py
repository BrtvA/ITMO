from zip_util import read_zip_all
from command_handler import start_console

DATA_PATH = 'data/zip_codes_states.csv'

zip_codes = read_zip_all(DATA_PATH)
start_console(zip_codes)

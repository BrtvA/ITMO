from PIL import Image
import numpy as np

COLOR_SHIFT = 20
DEAD_COLOR = (255, 255, 255)


def change_color(color, age):
    channel_r, channel_g, channel_b = color

    channel_b += (age * COLOR_SHIFT) % 255
    channel_g += ((age * COLOR_SHIFT) // 255) * COLOR_SHIFT
    channel_r += ((age * COLOR_SHIFT) // 255 // 255) * COLOR_SHIFT

    return channel_r, channel_g, channel_b


def draw_field(field, age, color, scale, path):
    life_pixel = change_color(color, age)
    dead_pixel = DEAD_COLOR

    width = len(field[0])
    height = len(field)

    pixels = [[dead_pixel for col in range(width)] for row in range(height)]

    for row in range(height):
        for col in range(width):
            if field[row][col]:
                pixels[row][col] = life_pixel

    array = np.array(pixels, dtype=np.uint8)

    new_image = Image.fromarray(array)
    new_image = new_image.resize((height * scale, width * scale), Image.BILINEAR)
    new_image.save(path)
    new_image.show()

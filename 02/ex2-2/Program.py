import numpy as np

width, height = 640, 480
rows, cols = 480, 640

# shape 파라미터에서 세 번째 숫자: 채널 수
color = np.zeros((height, width, 3), np.uint8)
gray = np.zeros((rows, cols, 1), np.uint8)

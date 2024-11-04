import cv2

src = cv2.imread("image.jpeg", cv2.IMREAD_GRAYSCALE)

print(src.ndim, src.shape, src.dtype)

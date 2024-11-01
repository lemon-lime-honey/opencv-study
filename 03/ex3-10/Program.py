import cv2

img = cv2.imread("image.jpeg", 0)

center = [100, 100]
red = (0, 0, 255)

cv2.circle(img, tuple(center), 30, red, 3)

cv2.imshow("img", img)

cv2.waitKey(0)

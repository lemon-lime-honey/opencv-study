import cv2

src = cv2.imread("image.jpeg", cv2.IMREAD_GRAYSCALE)
dst = cv2.Canny(src, 100, 200, apertureSize=3, L2gradient=True)

cv2.imshow("dst", dst)
cv2.waitKey(0)
cv2.destroyAllWindows()

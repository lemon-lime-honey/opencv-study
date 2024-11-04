import cv2

capture = cv2.VideoCapture("video.mp4")

while True:
    ret, frame = capture.read()

    pos_frame = capture.get(cv2.CAP_PROP_POS_FRAMES)
    frame_count = capture.get(cv2.CAP_PROP_FRAME_COUNT)

    if pos_frame == frame_count:
        capture.open("video.mp4")

    cv2.imshow("VideoFrame", frame)

    if cv2.waitKey(15) == ord("q"):
        break

capture.release()
cv2.destroyAllWindows()

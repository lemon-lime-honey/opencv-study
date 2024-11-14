import cv2
import numpy as np


def loadTrainData(image_path, label_path):
    with open(image_path, "rb") as image_data:
        images = np.frombuffer(image_data.read(), dtype=np.uint8, offset=16).reshape(
            -1, 784
        )

    with open(label_path, "rb") as label_data:
        labels = np.frombuffer(label_data.read(), dtype=np.uint8, offset=8)

    return images, labels


if __name__ == "__main__":
    train_x, train_y = loadTrainData(
        "../../models/fashion-mnist/train-images-idx3-ubyte",
        "../../models/fashion-mnist/train-labels-idx1-ubyte",
    )
    test_x, test_y = loadTrainData(
        "../../models/fashion-mnist/t10k-images-idx3-ubyte",
        "../../models/fashion-mnist/t10k-labels-idx1-ubyte",
    )

    cv2.imshow("image", train_x[0].reshape(28, 28, 1))
    cv2.waitKey(0)
    cv2.destroyAllWindows()

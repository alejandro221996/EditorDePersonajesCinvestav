import cv2
img=cv2.imread("PruebaInt.png")
print(img.shape)
width,height=96,96
imgRes=cv2.resize(img,(width,height))
print(imgRes)
print(imgRes.shape)
imgCropped=img[0:50,0:32]
cv2.imshow("Imagen",img)
cv2.imshow("Image cropped",imgCropped)
cv2.waitKey(0)
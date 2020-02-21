import cv2
import numpy as np
import matplotlib.pyplot as plt

image=cv2.imread("PruebaInt.png",-1)
imageCropped=image[0:48,0:32]
width,height=64*5,100*5
imageResized=cv2.resize(imageCropped,(width,height))
cv2.imshow("Imagen",imageResized)
print(imageResized.shape)
imageResized=cv2.cvtColor(imageResized,cv2.COLOR_BGR2RGB)
imageResized_hsv=cv2.cvtColor(imageResized,cv2.COLOR_RGB2HSV)
#Umbral Rojo1
umbral_bajo1=(170,100,100)
umbral_alto1=(179,255,255)
#Umbral Rojo2
umbral_alto2=(0,100,100)
umbral_bajo2=(10,255,255)
mask1=cv2.inRange(imageResized_hsv,umbral_bajo1,umbral_alto1)
mask2=cv2.inRange(imageResized_hsv,umbral_bajo2,umbral_alto2)
mask=mask1+mask2
res=cv2.bitwise_and(imageResized,imageResized,mask=mask)

plt.subplot(1,2,1)
plt.imshow(mask,cmap="gray")
plt.subplot(1,2,2)
plt.imshow(res)
plt.show()


cv2.waitKey(0)
cv2.destroyAllWindows()
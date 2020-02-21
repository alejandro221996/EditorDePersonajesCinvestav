import cv2
import numpy as np
image=cv2.imread('RojoCompleto.png')   #Lectura de la imagen
hsv=cv2.cvtColor(image,cv2.COLOR_BGR2HSV)   #Conversion de imagen a formato HSV de BGR

#LightGreen=np.array([49,50,50])
#DarkGreen=np.array([107,255,255])     Umbrales del color verde en HSV
#LightBlue=np.array([100,65,75],dtype=np.uint8)
#DarkBlue=np.array([130,255,255],dtype=np.uint8)
LightRed1 = np.array([0,65,75], dtype=np.uint8)
DarkRed1 = np.array([12, 255, 255], dtype=np.uint8)#Umbrales de colores (bajo y alto del color rojo en HSV
LightRed2 = np.array([240,65,75], dtype=np.uint8)
DarkRed2 = np.array([255, 255, 255], dtype=np.uint8)

#GreenMask=cv2.inRange(hsv,LightGreen,DarkGreen)
Red2Mask=cv2.inRange(hsv,LightRed2,DarkRed2)
Red1Mask=cv2.inRange(hsv,LightRed1,DarkRed1)    #Mascara del color para poder hacer operaciones con ellas
#BlueMask=cv2.inRange(hsv,LightBlue,DarkBlue)

mask=cv2.add(Red1Mask,Red2Mask)    #Mascara del color con ambos umbrales
#mask=cv2.add(mask,GreenMask)      #Suma de las demas mascara para obtener mas salidas
#mask=cv2.add(mask,BlueMask)

avrg_color_in_a_row=np.average(image,axis=0)
avrg_color_in_image=np.average(avrg_color_in_a_row,axis=0)
print(avrg_color_in_image)

cv2.imshow('ImagenProcesada',mask)
cv2.imshow('ImagenOriginal',image)

while(1):
    inp=cv2.waitKey(5) & 0xFF
    if inp==27:
        break
cv2.destroyAllWindows()


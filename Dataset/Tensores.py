import cv2
import gspread
import glob
import numpy as np
from oauth2client.service_account import ServiceAccountCredentials
from PIL import Image
import h5py

scope = ["https://spreadsheets.google.com/feeds", 'https://www.googleapis.com/auth/spreadsheets',
         "https://www.googleapis.com/auth/drive.file", "https://www.googleapis.com/auth/drive"]
credentials = ServiceAccountCredentials.from_json_keyfile_name("TestEsperoQueSirva.json", scope)
client = gspread.authorize(credentials)
sheet = client.open("TexturasElegidas").sheet1
data = sheet.get_all_records()
AvatarNumber = len(data)
c = 0
Avatar = []
for i in range(2, AvatarNumber + 2):
    Avatar.append(sheet.row_values(i))
    Avatar[i - 2] = list(map(int, Avatar[i - 2][1:]))

Gender_data = []
Gender = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Gender/*.PNG")
for GenderFile in Gender:
    print(GenderFile)
    Genderimage = cv2.imread(GenderFile)
    Gender_data.append(Genderimage)

Hairs_data = []
Hairs = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Male/Hair/*.PNG")
for HairsFile in Hairs:
    print(HairsFile)
    Hairsimage = cv2.imread(HairsFile)
    Hairs_data.append(Hairsimage)

AHairs_data = []
AHairs = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Male/HairAccesories/*.PNG")
for AHairsFile in AHairs:
    print(AHairsFile)
    AHairsimage = cv2.imread(AHairsFile)
    AHairs_data.append(AHairsimage)

Eyes_data = []
Eyes = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Male/Eyes/*.PNG")
for EyesFile in Eyes:
    print(EyesFile)
    Eyesimage = cv2.imread(EyesFile)
    Eyes_data.append(Eyesimage)

Ears_data = []
Ears = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Male/Ears/*.PNG")
for EarsFile in Ears:
    print(EarsFile)
    Earsimage = cv2.imread(EarsFile)
    Ears_data.append(Earsimage)

Helmet_data = []
Helmet = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Male/Headwear/Helmet/*.PNG")
for HelmetFile in Helmet:
    print(HelmetFile)
    Helmetimage = cv2.imread(HelmetFile)
    Helmet_data.append(Helmetimage)

HeadA_data = []
HeadA = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Male/Headwear/HeadAccesories/*.PNG")
for HeadAFile in HeadA:
    print(HeadAFile)
    HeadAimage = cv2.imread(HeadAFile)
    HeadA_data.append(HeadAimage)

Hat_data = []
Hat = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Male/Headwear/Hats/*.PNG")
for HatFile in Hat:
    print(HatFile)
    Hatimage = cv2.imread(HatFile)
    Hat_data.append(Hatimage)

FHair_data = []
FHair = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Male/FacialHair/*.PNG")
for FHairFile in FHair:
    print(FHairFile)
    FHairimage = cv2.imread(FHairFile)
    FHair_data.append(FHairimage)

Armor_data = []
Armor = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Male/Body/Armor/*.PNG")
for ArmorFile in Armor:
    print(ArmorFile)
    Armorimage = cv2.imread(ArmorFile)
    Armor_data.append(Armorimage)

BA_data = []
BA = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Male/Body/BodyAccesories/*.PNG")
for BAFile in BA:
    print(BAFile)
    BAimage = cv2.imread(BAFile)
    BA_data.append(BAimage)

Outer_data = []
Outer = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Male/Body/Outer/*.PNG")
for OuterFile in Outer:
    print(OuterFile)
    Outerimage = cv2.imread(OuterFile)
    Outer_data.append(Outerimage)

Top_data = []
Top = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Male/Body/Top/*.PNG")
for TopFile in Top:
    print(TopFile)
    Topimage = cv2.imread(TopFile)
    Top_data.append(Topimage)

Wings_data = []
Wings = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Male/Body/Wings/*.PNG")
for WingsFile in Wings:
    print(WingsFile)
    Wingsimage = cv2.imread(WingsFile)
    Wings_data.append(Wingsimage)

Shoulders_data = []
Shoulders = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Male/Shoulders/Shoulders/*.PNG")
for ShouldersFile in Shoulders:
    print(ShouldersFile)
    Shouldersimage = cv2.imread(ShouldersFile)
    Shoulders_data.append(Shouldersimage)

Gauntlets_data = []
Gauntlets = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Male/Gauntlets/*.PNG")
for GauntletsFile in Gauntlets:
    print(GauntletsFile)
    Gauntletsimage = cv2.imread(GauntletsFile)
    Gauntlets_data.append(Gauntletsimage)

LegsMale_data = []
LegsMale = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Male/Legguards/*.PNG")
for LegsMaleFile in LegsMale:
    print(LegsMaleFile)
    Legsimage = cv2.imread(LegsMaleFile)
    LegsMale_data.append(Legsimage)

Boots_data = []
Boots = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Male/Boots/*.PNG")
for BootsFile in Boots:
    print(BootsFile)
    Bootsimage = cv2.imread(BootsFile)
    Boots_data.append(Bootsimage)

Belt_data = []
Belt = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Male/Legguards/Belt/*.PNG")
for BeltFile in Belt:
    print(BeltFile)
    Beltimage = cv2.imread(BeltFile)
    Belt_data.append(Beltimage)

Pants_data = []
Pants = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Male/Pants/*.PNG")
for PantsFile in Pants:
    print(PantsFile)
    Pantsimage = cv2.imread(PantsFile)
    Pants_data.append(Pantsimage)

# MALE TEXTURES--------------------------------------------------------------------------------

FemaleHair_data = []
FemaleHair = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/HairButtonThings/Hair/Hairs/*.PNG")
for FemaleHairFile in FemaleHair:
    print(FemaleHairFile)
    FemaleHairimage = cv2.imread(FemaleHairFile)
    FemaleHair_data.append(FemaleHairimage)

FrontHair_data = []
FrontHair = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/HairButtonThings/Hair/FrontHair/*.PNG")
for FrontHairFile in FrontHair:
    print(FrontHairFile)
    FrontHairimage = cv2.imread(FrontHairFile)
    FrontHair_data.append(FrontHairimage)

BackHair_data = []
BackHair = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/HairButtonThings/Hair/BackHair/*.PNG")
for BackHairFile in BackHair:
    print(BackHairFile)
    BackHairimage = cv2.imread(BackHairFile)
    BackHair_data.append(BackHairimage)

FemaleEyes_data = []
FemaleEyes = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/HeadButton/Eyes/*.PNG")
for FemaleEyesFile in FemaleEyes:
    print(FemaleEyesFile)
    FemaleEyesimage = cv2.imread(FemaleEyesFile)
    FemaleEyes_data.append(FemaleEyesimage)

FemaleEars_data = []
FemaleEars = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/HeadButton/Ears/*.PNG")
for FemaleEarsFile in FemaleEars:
    print(FemaleEarsFile)
    FemaleEarsimage = cv2.imread(FemaleEarsFile)
    FemaleEars_data.append(FemaleEarsimage)

FemaleHats_data = []
FemaleHats = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/HeadButton/Headwear/FemaleHats/*.PNG")
for FemaleHatsFile in FemaleHats:
    print(FemaleHatsFile)
    FemaleHatsimage = cv2.imread(FemaleHatsFile)
    FemaleHats_data.append(FemaleHatsimage)

FemaleHA_data = []
FemaleHA = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/HeadButton/Headwear/HairAccesories/*.PNG")
for FemaleHAFile in FemaleHA:
    print(FemaleHAFile)
    FemaleHAimage = cv2.imread(FemaleHAFile)
    FemaleHA_data.append(FemaleHAimage)

FemaleHeadA_data = []
FemaleHeadA = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/HeadButton/Headwear/HeadAccesories/*.PNG")
for FemaleHeadAFile in FemaleHeadA:
    print(FemaleHeadAFile)
    FemaleHeadAimage = cv2.imread(FemaleHeadAFile)
    FemaleHeadA_data.append(FemaleHeadAimage)

FemaleArmor_data = []
FemaleArmor = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/BodyButton/Torso/Armors/*.PNG")
for FemaleArmorFile in FemaleArmor:
    print(FemaleArmorFile)
    FemaleArmorimage = cv2.imread(FemaleArmorFile)
    FemaleArmor_data.append(FemaleArmorimage)

FemaleBA_data = []
FemaleBA = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/BodyButton/Torso/BodyAccesories/*.PNG")
for FemaleBAFile in FemaleBA:
    print(FemaleBAFile)
    FemaleBAimage = cv2.imread(FemaleBAFile)
    FemaleBA_data.append(FemaleBAimage)

Dresses_data = []
Dresses = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/BodyButton/Torso/Dresses/*.PNG")
for DressesFile in Dresses:
    print(DressesFile)
    Dressesimage = cv2.imread(DressesFile)
    Dresses_data.append(Dressesimage)

FemaleTops_data = []
FemaleTops = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/BodyButton/Torso/Tops/*.PNG")
for FemaleTopsFile in FemaleTops:
    print(FemaleTopsFile)
    FemaleTopsimage = cv2.imread(FemaleTopsFile)
    FemaleTops_data.append(FemaleTopsimage)

FemaleTorsos_data = []
FemaleTorsos = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/BodyButton/Torso/Torsos/*.PNG")
for FemaleTorsosFile in FemaleTorsos:
    print(FemaleTorsosFile)
    FemaleTorsosimage = cv2.imread(FemaleTorsosFile)
    FemaleTorsos_data.append(FemaleTorsosimage)

FemaleBoots_data = []
FemaleBoots = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/LegsButton/Bootss/*.PNG")
for FemaleBootsFile in FemaleBoots:
    print(FemaleBootsFile)
    FemaleBootsimage = cv2.imread(FemaleBootsFile)
    FemaleBoots_data.append(FemaleBootsimage)

FemalePants_data = []
FemalePants = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/LegsButton/Pants/*.PNG")
for FemalePantsFile in FemalePants:
    print(FemalePantsFile)
    FemalePantsimage = cv2.imread(FemalePantsFile)
    FemalePants_data.append(FemalePantsimage)

Femaleskirts_data = []
Femaleskirts = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/LegsButton/Skirts/*.PNG")
for FemaleskirtsFile in Femaleskirts:
    print(FemaleskirtsFile)
    Femaleskirtsimage = cv2.imread(FemaleskirtsFile)
    Femaleskirts_data.append(Femaleskirtsimage)

FemalesUpperArmor_data = []
FemalesUpperArmor = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/LegsButton/UpperArmor/*.PNG")
for FemalesUpperArmorFile in FemalesUpperArmor:
    print(FemalesUpperArmorFile)
    FemalesUpperArmorimage = cv2.imread(FemalesUpperArmorFile)
    FemalesUpperArmor_data.append(FemalesUpperArmorimage)

FemalesGauntlets_data = []
FemalesGauntlets = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/ArmsButton/Arms/*.PNG")
for FemalesGauntletsFile in FemalesGauntlets:
    print(FemalesGauntletsFile)
    FemalesGauntletsimage = cv2.imread(FemalesGauntletsFile)
    FemalesGauntlets_data.append(FemalesGauntletsimage)

FemalesGloves_data = []
FemalesGloves = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/ArmsButton/Gloves/*.PNG")
for FemalesGlovesFile in FemalesGloves:
    print(FemalesGlovesFile)
    FemalesGlovesimage = cv2.imread(FemalesGlovesFile)
    FemalesGloves_data.append(FemalesGlovesimage)

FemalesShoulders_data = []
FemalesShoulders = glob.glob("C:/Users/LENOVO/PycharmProjects/Tensores/Female/ArmsButton/Shoulders/*.PNG")
for FemalesShouldersFile in FemalesShoulders:
    print(FemalesShouldersFile)
    FemalesShouldersimage = cv2.imread(FemalesShouldersFile)
    FemalesShoulders_data.append(FemalesShouldersimage)

AllTextures = [Gender_data, Hairs_data, AHairs_data, Hat_data, Eyes_data, Ears_data, Helmet_data, HeadA_data,
               FHair_data,
               Armor_data, Top_data, Outer_data, BA_data, Wings_data, Shoulders_data, Gauntlets_data,
               LegsMale_data, Boots_data, Belt_data, Pants_data, FemaleHair_data, FrontHair_data, BackHair_data,
               FemaleEyes_data, FemaleEars_data, FemaleHats_data, FemaleHA_data, FemaleHeadA_data, FemaleBA_data,
               Dresses_data, FemaleArmor_data, FemaleTops_data, FemaleTorsos_data, FemalesShoulders_data,
               FemalesGauntlets_data, FemalesGloves_data, FemaleBoots_data, FemalePants_data, Femaleskirts_data,
               FemalesUpperArmor_data]

# SelectedEyes=AllTextures[3][Avatar[1][3]]
# AllTextures[i]----Es el arreglo donde estan guardadas todas las texturas
# [i]----------Es la categoria de imagenes que se esta seleccionando
# Avatar[i][j]
# [i]------Es el numero de personaje seleccionado
# [j]------Es la categoria seleccionada
Resultantes = []
for j in range(1, len(Avatar)):
    print("J", j)
    for i in range(0, len(AllTextures) - 1):
        print(Avatar[j][i])
        Resultantes.append(AllTextures[i][Avatar[j][i]])
        print("I", i)

pixel_data = []
# X is the pixel data for the pokemon.
for imagenes in Resultantes:
    # with Image.open(filename,'r') as image:
    Image = Resultantes[i]
    hsv = cv2.cvtColor(Image, cv2.COLOR_BGR2HSV)
    cv2.imshow("Imagen HSV", hsv)
    pixel_list = np.asarray(hsv.flatten())
    pixel_list = np.true_divide(pixel_list, 255.)  # Very important to normalize your inputs!
    print(pixel_list)
    # NOTE: Check if the pixels are triplets or are already flattened.
    print('the number of pixels each image has is: ' + str(len(pixel_list)))
    pixel_data.append(pixel_list)  # add it to the variable with all the information.

# -----------------------------------------------------------Hasta aqui solo guarda la informacion a una variable

# # Should be 809 or something.
print('The length of pixel_data is: ' + str(len(pixel_data)))  # correctly printed.
#
# # Make a 3-fold cross-validation split, so it's stable during development.
pixel_data = np.asarray(pixel_data)
#
print(Avatar[0])
print(AvatarNumber)
Personajes = []
Objeto_Personaje = []
lista_personajes = []
for i in range(0, AvatarNumber):
    Objeto_Personaje = pixel_data[i * 39: (i + 1) * 39]
    lista_personajes.append(Objeto_Personaje)
    Personajes[i] = pixel_data[i * 39: (i + 1) * 39]

# # Finally, put it into a h5f dataset and that's it.
h5f = h5py.File('avatar_dataset_HSV.h5', 'w')
h5f.create_dataset('avatars_data', data=lista_personajes)

h5f.close()
ImgResultante = Resultantes[40]
# cv2.imshow("Imagen", ImgResultante)
cv2.waitKey(0)
cv2.destroyAllWindows()

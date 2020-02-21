import gspread
from oauth2client.service_account import ServiceAccountCredentials
from pprint import pprint
scope = ["https://spreadsheets.google.com/feeds" ,'https://www.googleapis.com/auth/spreadsheets' , "https://www.googleapis.com/auth/drive.file","https://www.googleapis.com/auth/drive"]
credentials= ServiceAccountCredentials.from_json_keyfile_name("TestEsperoQueSirva.json",scope)
client=gspread.authorize(credentials)
sheet=client.open("UnityAttributes").sheet1
data=sheet.get_all_records()
row=sheet.row_values(3)
col=sheet.col_values(3)
cell=sheet.cell(2,2).value
numRows=sheet.row_count
pprint(numRows)

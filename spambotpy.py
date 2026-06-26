
import pyautogui, time, sys, keyboard,pynput
print("pokaż Debug: wpisz 1 ")
showdebug = input()
print("wybierz tryb:")
print("jezeli puste- tekst")
print("napisz cokolwiek- wklejanie")

mode = ""
mode = input()

if(mode == ""):
    if(showdebug == 1):
        print("tekst:")
        text1 = input()
        print("opoznienie:")
        text2 = input()
        time.sleep(3)
        pyautogui.typewrite("Debug: wybrany tekst: " + text1)
        pyautogui.press("enter")
        pyautogui.typewrite("Debug: wybrane opoznienie: " + text2)
        pyautogui.press("enter")
        for x in reversed(range(0, 4)):
            pyautogui.typewrite("Debug: " + str(x) + "...")
            pyautogui.press("enter")
            time.sleep(1)
            x+1
        sended = 0
        pyautogui.typewrite("Debug: rozpoczete")
        pyautogui.press("enter")
    while 0==0:
        pyautogui.typewrite(text1)
        pyautogui.press("enter")
        time.sleep(float(text2))
        sended = sended + 1
        if(keyboard.is_pressed("escape")):
            break
    if(showdebug == 1):
        pyautogui.typewrite("Debug: tekst wklejono: " + str(sended))
        pyautogui.press("enter")
else:
    if(showdebug == 1):
        print("opóźnienie:")
        text2 = input()
        time.sleep(3)
        pyautogui.typewrite("Debug: wklejanie ze schowka")
        pyautogui.press("enter")
        pyautogui.typewrite("Debug: wybrane opóźnienie: " + text2)
        pyautogui.press("enter")
        for x in reversed(range(0, 4)):
            pyautogui.typewrite("Debug: " + str(x) + "...")
            pyautogui.press("enter")
            time.sleep(1)
            x+1
            sended = 0
        pyautogui.typewrite("Debug: rozpoczete")
        pyautogui.press("enter")
    while 0==0:
        pyautogui.hotkey('ctrl', 'v')
        pyautogui.press("enter")
        time.sleep(float(text2))
        sended = sended + 1
        if(keyboard.is_pressed("escape")):
            break
    if(showdebug == 1):
        pyautogui.typewrite("Debug: tekst wklejono: " + str(sended))
        pyautogui.press("enter")
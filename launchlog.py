from datetime import datetime
import os
txt = open(os.path.join('C:/Users/Dajman/Desktop/python',"logi.txt"), "a")
now = datetime.now()
txt.write("komputer odpalony: " +  str(now) + "\n") 
txt.close()
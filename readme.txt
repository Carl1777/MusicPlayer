The music player application uses the SoundPlayer class within the System.Media library to play audio.
I decided to  display a prompt to the user so they can know which song genres are available for them to listen to (i.e. typing "pop" will play pop music, there are also other 
genres such as "rock" and "jazz" which can be listened to), the prompt is displayed to the user a number of times and is managed within the for loop, this is so that the user
can see the menu a number of times after listening to different songs since there is no GUI to manage this. The music player main functionality is handled in the playmusic method
which checks the genre of music and then plays the correct tune based on the user's pick. The user can also stop playing the song by typing "stop" or by typing another song genre
e.g. "jazz", alternatively the user can exit the application by typing "exit"
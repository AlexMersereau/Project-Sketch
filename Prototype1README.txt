File is too big to upload directly so I just put it on Google Drive for now: https://drive.google.com/file/d/1njQP5AjZGc5V_Y3Z9P254uKU42tlNVPH/view?usp=sharing

Link to the AR target image: http://www.dannygoodayle.com/wp-content/uploads/2013/03/AR_Marker_PNG_24.png
I'd recommend to be about a foot away as the AR integration is a little messed up due to perspective and scaling, it works but isn't close to pixel-for-pixel (ie. the collision is there but sometimes it isn't exactly matched to the platforms as the way unity handles displaying and it's actual world space is different)

The movement script does not work for touch input at all and it will be probably be easier in the next iteration to create it from scratch instead of importing the 2D platformer files since a lot of them are unnecessary and make things more complicated than they need to be (should be fairly easy with Touch.GetInput I just don't have time to look into it)

Animations weren't working immediately (probably due to me manually transferring the files it was using) and I didn't really care to look into it since we'll probably rewrite most of it with our own scripts - animations are not critical at the moment anyways



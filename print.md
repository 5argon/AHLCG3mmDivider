# How to layout dividers for printing

Here I show how to use Windows and macOS to create PDF file that you can send to print shop or your printer. These examples uses A4 paper.

## macOS

![macOS printing](./Images/print-1.png)

- Open "Photos" program.
- Drag 1 divider folder to it to import all images inside.
- Highlight all images you just imported.
- Press `Cmd + P` to bring up print dialog.
- Setup like in the image : A4, Color, Aspect Ratio : Custom, Photo Size : 93 x 68 mm. Then press Print.
- The next dialog, do not press Print, but press the dropdown saying "PDF" then select the "PDF" choice to save a file out of it instead.
- After it finished saving PDF, you can now go back and press delete to remove the highlighted images. If there are more than 8 images, the produced PDF will be multi-page.

## Windows

I can't believe it is so difficult on Windows 10 to do this!! The new Photos app has only paper size adjustment but not the size of individual image. "Restoring" the old Windows Photo Viewer via Registry Editor also similarly lacks control. Paint, Paint .NET, GIMP requires manually laying out each image on the page.

The only good solution I found is this external program [IrfanView](https://www.irfanview.com/).

- Download and install [IrfanView](https://www.irfanview.com/). This program is extremely small but really capable.
- On Desktop, execute "IrfanView 64 Thumbnails" shortcut (Not the regular "IrfanView 64").

  ![Windows printing](./Images/print-2.png)

- Go to where your dividers are and highlight all you want to print. For example, I want to print these 10 images. (Can overflow 8, and can be any number not just multiple of 8. So you are free to mix just dividers you want from different folders.)
- File > **Create contact sheet from selected files...**

  ![Windows printing](./Images/print-3.png)

- Setup like this : 
  - Press A4 button.
  - Set DPI to 300 and Portrait.
  - 2 Columns, 4 Rows to get 8 dividers in one page.
  - **Do not tick** that stretch checkbox.
  - I think you can leave spacing and margin at 30 pixels.
  
    But, depending on how tight on the edge your printer can perform, you may want to increase the margin. But beware that if margin is too large, **it will start shrinking images** to honor that margin and required columns and rows per page.
	
    On 300 DPI A4, size is 3508 x 2480. One divider is 1098 x 804. So on portrait A4 with 2 columns and 4 rows, remaining horizontal space is `2480 - (1098 * 2) = 284` and remaining vertical space is `3508 - (804 * 4) = 292`. Therefore, max margin before shrinking occurs is horizontal 142 and vertical 146, which when combined with spacings both 0, all dividers will stick tightly together at the center. (You may want to purposefully do this to reduce number of cuts, but missed cut will eat into the graphic of the other divider.)

  - On the Output section, use "Save all pages as files". Select destination and choose **PNG** as the format. PDF is there but I believe requires installing a plugin from this program's homepage, so PNG should be easier.
  - Press "Create" and check the output files. More than 8 files should overflow correctly to more sheets. Check one last time if they are all at size 3508 x 2480 or not. (If not, you may forgot to specify 300 DPI earlier.)

    ![Windows printing](./Images/print-4.png)
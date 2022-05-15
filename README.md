# AH:LCG 3mm Dividers

Card divider graphics you can print out and cut up to use with [Arkham Horror : The Card Game (LCG)](https://www.fantasyflightgames.com/en/products/arkham-horror-the-card-game/).

![Preview 1](./Images/main-1.jpg)

![Preview 2](./Images/main-2.jpg)

![Preview 3](./Images/main-3.jpg)

Unlike other dividers, they have a bit of unusual traits that leads to me making them on my own : 

- **As small as possible** : Size is 93mm x 68mm. In comparison, the size of standard size card is 89mm x 64mm, which gets +1mm to 90mm x 65mm when fitted with perfect sleeves. (+0.5mm for each side.)
  
  The 3mm difference becomes the name of this project : it utilizes just that tiny 3mm difference to display all of divider's graphics and texts.
  
  Tiny texts are actually great when reading at lower angle, you can see more dividers behind it. Very useful when there are a lot of categories with as few as 2-4 cards in this game.
  
  These dividers are best if you use perfect fit sleeves on all your cards or not sleeving at all, otherwise the cards maybe too tall and obscure the dividers.
- **High compatibility** : When the divider is not much taller than the cards, it is mostly compatible with any box you used for your cards without folding it. Using these dividers in the Revised Core Set box won't add too much height. The box still closes just fine even with that left over token punch-out cardboard in the box. I have tested with Ultimate Guard Boulder and Sidewinder and those boxes can still close.
- **Can be sleeved** : This 93mm x 68mm number is chosen for one more reason : You can sleeve the divider with "outer sleeve" designed to cover character sleeves in one more layer.

  KMC Character Sleeve Guard has dimension 94mm x 69mm, which will make this 93mm x 68mm a perfect fit inside it.

  This eliminates the need of lamination machine to reinforce your dividers if you want to.
- **Dual orientations** : It has graphics for both landscape and portrait arrangement. This gives you flexibility in your storage solution which may change in the future as your collection grows.
- **Easy to work on** : The graphics are generated from applied usage of Unity game engine (also hosted in this repository), which makes them consistent in layout, easy to add more in the future, or batch-modifying mistakes on all previous ones less tedious. It also works really well with generating many localizations. All this make sure it is easy for me to continue maintaining the project with minimal effort when FFG releases new products.

## More images

See them in the [gallery page](./gallery.md) to see if they would work in your storage solution or not.

## Attributions

All encounter icons were obtained from combined effort in [this thread](https://boardgamegeek.com/thread/1671881/article/38760017#38760017).

Card graphics was remixed from official FFG print-and-play PDF. I didn't design anything other than putting texts, icons, and recolor a bit.

## Languages

- English
- German (Contributed by : [@empty0911](https://boardgamegeek.com/user/empty0911), [@Miriamelbgg](https://boardgamegeek.com/user/Miriamelbgg))
- Italian (Contributed by : [@fabioflx](https://boardgamegeek.com/user/fabioflx))
- Russian (Unknown contributor)
- Spanish (Contributed by : [@colococolo](https://boardgamegeek.com/user/colococolo), [@Fran77](https://boardgamegeek.com/user/Fran77)
- French (Contributed by : [@retsnimel](https://boardgamegeek.com/user/retsnimel)

If translation is missing, file is still rendered but text area will be empty.

### Contributing translations

This is a spredsheet which Unity can load and generate the dividers : https://docs.google.com/spreadsheets/d/1jA8786alNXLDSA-LVSh4HzJ6gza1JqO1_XyImz7ncaE/edit#gid=0

Other than several left columns and `en`, you can freely edit the rest. You can contribute by filling in the other language if you would like dividers in that language generated.

Note that there is no fallback to `en`, it will be blank if there is no text in that cell.

After you have added some translations, you can ping me somewhere, like in [BGG forum thread](https://boardgamegeek.com/thread/2766339/3mm-divider-designs-available-download), and I will regenerate the graphics.

## Overview

- `Design` : Affinity Designer file that exports graphics for `Unity` folder.
- `Unity` : Unity game engine project that would output divider graphics for `Dividers` folder.
- `Dividers` : Individual divider `.png` files for printing. You should print multiple files in one sheet, depending on your printer.
- `Images` : Store preview photos shown in this page and in the [gallery page](./gallery.md).

## List of Dividers

Graphics inside `Dividers` folder support various organizing methods and there are overlaps. You can gather and print out just the one that matches what you want your box to look like. [See explanation of each set in a separated page](./list.md).

## How to use

### 1. Download

Download everything as a `.zip` by clicking the **green button** on around top-right corner of this page then select "Download ZIP". Alternatively you can try [this direct link](https://github.com/5argon/AHLCG3mmDivider/archive/refs/heads/main.zip).

Look inside `Dividers` folder. Inside you will find a folder representing a language code, then category folders ending in number of dividers inside that folder (e.g. `8x`, `16x`). Dividers in the same folder are meant to be grouped in the same paper when you send to print shop, as they are likely used together. (e.g. for the same campaign box.)

And notice that file number is a multiple of 8, because A4 is a common size of paper and that size could fit at most 8 dividers per sheet. If some category is not quite at the multiple of 8 yet, they are filled with some extra dividers until it is a multiple of 8. If you use bigger or smaller size of paper than A4, you can try merging multiple folders or take out those extra generic dividers as needed.

### 2. Layout, print, and cut

Send items in the same folder into any program that can laid them out on paper size then save a merged image for printing. Make sure size of each divider is physically 93mm x 68mm on the paper (1098x804 px at 300 DPI), some programs like to offer scaling to fit. Make sure that is off.

- [See examples of using "Photos" app in macOS or "IrfanView Thumbnails" on Windows to do this.](./print.md)

After that you can cut them up. You will be making skill test (4) on cutting since there is little room for error before the text is also trimmed off. I also forgot to make the graphic bleed outside of cut line to accommodate cutting errors.

### 3. Finishing touch

You may use rounded corner punch on them and maybe sleeve to make them last longer.

The printed size 93mm x 68mm can fit inside KMC Character Sleeve just right. The trick to get it in is using the corner of divider or small ruler to stretch open up the 2 entry corners of the sleeve a bit. If you can get both corners in at the same time, the rest will be easy.

## Making custom graphics

`Unity` folder can be used to generate new graphics by opening it with Unity game engine. But it is likely only make sense to me since I hadn't putting in that much effort to make the project understandable.

If you don't know how to use Unity and have any requests of new graphics, it maybe easier if you contact me. (pyasry@gmail.com, [BGG forum thread](https://boardgamegeek.com/thread/2766339/3mm-divider-designs-available-download), here in the Issues section, etc.) If I have time I maybe able to quickly update the renders.

I only own the Revised Core Set at the moment, so I myself isn't in a hurry to print more dividers... I likely be getting expansions released in new format starting from Edge of the Earth and add more dividers accordingly.

### Brief explanation of the Unity project

Assuming you know how to use Unity, you can use the project to generate custom dividers with any text and icons. These can help you understand the project structure faster : 

- Right click `Asset` menu has an asset called `GenPdf`, which the `Runner` on the scene has `GenPdf[]` exposed. Follow the script of `GenPdf` and you should understand the rest.
- In Play Mode, `Runner` object will run a coroutine that "apply" the `GenPdf` one by one per frame. You will see various graphics flashes rapidly.
- The project has [Unity Recorder](https://docs.unity3d.com/Packages/com.unity.recorder@latest/manual/index.html) installed. Recorder is run by script instead of button in Unity UI, because this way I could vary the path and file name as desired.
- Game view and Recorder should be set to 1098x804. (Becomes 93mm x 68mm at 300 DPI)
- [Localization package](https://docs.unity3d.com/Packages/com.unity.localization@latest) is also used, which has Google Sheet service connected to [this spreadsheet](https://docs.google.com/spreadsheets/d/1jA8786alNXLDSA-LVSh4HzJ6gza1JqO1_XyImz7ncaE/edit#gid=0).
- Finally, it exits Play Mode immediately after everything is over. Therefore what you do to regenerate the `Dividers` folder is just press enter Play Mode and wait until it exits.

## Extras

I have made other printable stuff outside of the dividers : [Print and Play](./PrintAndPlay/README.md)
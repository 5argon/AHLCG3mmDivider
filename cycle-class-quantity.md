# Collection based on Cycle-Class-Quantity (CCQ)

A collection that maximizes deck teardown speed while maintaining great deck construction speed, assuming that the deck was made from ArkhamDB. (No browsing, you already know the complete list of cards to take out.) It is inspired from the encounter sets.

It gives the player cards an easy to identify "set" **just like how the encounter set has an icon**, and in one kind of icon contains cards of managable size that you can count. (e.g. Ancient Evils contains 3 cards. False Lead contains 4 cards.) The missing piece is this quantity count inside the set, and the set dividing criteria.

My dividers will provide those missing information that will enable this kind of collection. I wrote a script that iterate through card database in ArkhamDB to automatically determine this count, accounted for cards that the game gives you only 1 copy or more than 2 copies already for you.

Set criteria is : cycle (same icon at the corner meant the same cycle), then class (the card's color). Thats it, this is why it is called cycle-class-quantity (CCQ).

To illustrate the point, each divider looks like one of these rows :

| Cycle (printed as an icon) | Class (as color on the corner) | Quantity |
|:--|:--|--:|
| Revised Core Set | Guardian | 32 |
| Revised Core Set | Seeker | 32 |
| Revised Core Set | Rogue | 32 |
| Revised Core Set | Mystic | 32 |
| Revised Core Set | Survivor | 32 |
| Revised Core Set | Neutral | 60 |
| The Dunwich Legacy | Guardian | 34 |
| The Dunwich Legacy | Seeker | 34 |
| The Dunwich Legacy | Rogue | 34 |
| The Dunwich Legacy | Mystic | 34 |
| The Dunwich Legacy | Survivor | 34 |
| The Dunwich Legacy | Neutral | 18 |
| ... | ... | ... |

The stongest point of having quantity printed on the divider like this is that it provide **lost-proof** feature similar to the encounter set even when cards are put inside this chunk **at random**.

Random order inside the set is what **maximizes deck teardown speed**, and on the inverse side, **deck construction speed doesn't suffer much** if we ensure the set's size is small enough for searching.

Deck construction is surely faster if inside each set, the cards are further ordered in a certain way. But that would slow down deck teardown significantly. It is not worth it if you want to play the game and try out different decks as often as possible.

## Why it might not be for you

It maximizes speed so much that collecting and browsing aspect suffers.

I understand that some players also lean towards the collecting side and requires the ordering to be neat. They might want to browse and take a good look at all the cards in the collection physically as a hobby. They might want to do some offline building without help from ArkhamDB. For them, this game is not all about playing and deckbuilding.

This method is not suitable for these players as ordering is completely random. Perhaps storing in a binder (so no dividers required, moving the problem to different "dimension".) is better.

Personally I think box storage with dividers is already weak at browsing and collecting aspect. Why not go all the way and make what it does best, the speed, the fastest?

## How to tear down decks at record-breaking time in parallel

With the right "pipeline" we can teardown decks of multiple players very fast, just like how you can clean up the game by dividing the encounter deck to all players at the table and ask them to separate based on icons.

Our set criteria is obvious and simple, requiring low cognitive load. Just look at icon at the corner, then look at card's color.

It goes like this in steps :

- After the campaign is finished, all players hold their own deck in the hand. Designate a common area on the table with each spot for each cycle (icon).
- Each person iterate through their own deck looking at only the icon. Throw the card onto the right pile. Table now has accumulating rainbow piles, how many depending on how many cycles of Investigator Expansion you purchased.
- No one should touch these cycle-piles yet even if they finished disassembled the deck first. This is one small bottleneck in the pipeline that worth the wait, trust me.
- When everyone finished, then each person pick a cycle-pile to help out. Designate a small personal area on the table and divide cards into classes. Just look at the card's color and nothing else.
- Each person takes their class-piles of the same cycles to the box and find the dividers matching them. Put all cards into each divider's area joining with the previous cards with no further ordering.
- This person takes out the joined set and count the cards if it matches the printed quantity or not. If the bottleneck step above is properly waited, this must match the printed number or it means you have lose the card.
- This step is optional but recommended : make the counted set sorted by asset/event/skill. When counting your quantity instead of doing it on 2 hands floating, put the cards one by one on the table on 3 piles of asset, event, and skill, by looking at the shape of artwork's border while counting. After you finished counting you will have a random ordering only inside the respective card type, not in an entire cycle-class. This improve search speed when constructing the deck.

## How to assemble the deck at good speed

As mentioned, this kind of collection requires deckbuilding with ArkhamDB. As it is difficult to browse with ordering completely random, and cards of the same classes are separated to different cycles, making it hard to match with investigator's deckbuilding requirements compared to if they are not separated by cycles.

After you built the deck on ArkhamDB, press the sorting dropdown and choose **"by Set, then Number"**. If the app has "by Set, then Class" that would be exactly what we want here, but this is acceptable too.

The UI will then have dividers based on set. In each set you can see each card's class by the color of text and class icons.

Pick out the cards based on those by :

- Going to that set's divider. If 2 players are assembling at the same time, have one go from first to last and another go from last to first so you are not holding the same chunk of cards.
- **Linearly search** for the cards you want from this divider, since the ordering inside each divider is currently random.

The 2nd step sounds unwieldly, but this is countered by ensuring each set having small size that it is possible to fan out the chunk and take a look where they are. If when counting on teardown you sort by asset/event/skill too, then search space is even smaller to just about 10 cards. This is just like if I ask you to get the "Your House" card from "The Midnight Mask" divider, it shouldn't take long to find despite you don't know where it is inside the divider, by fanning the cards out and looking at the graphics.

## Subjective sub-sets

Sometimes dividing just by cycle then class still cause the chunk to be too large to comfortable count and search for a card when deckbuilding. The following **3 exceptions** are subjectively sub-chunked again :

| Cycle | Class | Quantity | Becomes | Quantity |
|:--|:--|--:|:--|--:|
| Core Set | Neutral | 26 | Neutral [Knife, Flashlight, Emergency Cache]| 12 |
| | | | Neutral [Remaining]| 14 |
| Revised Core Set | Neutral | 60 | Neutral [Knife, Flashlight, Emergency Cache]| 30 |
| | | | Neutral [Remaining]| 30 |
| Edge of the Earth | Multi-Class | 82 | Multi-Class [Guardian First]| 28 |
| | | | Multi-Class [Seeker First]| 22 |
| | | | Multi-Class [Rogue First]| 14 |
| | | | Multi-Class [Remaining]| 18 |

The person tearing down Core Set and Edge of the Earth should be taught these exceptions by the collection's owner. The original big set's divider is also included just in case you don't want to follow these exceptions.

## Exceptions

- Investigator cards (they are in front of each cycle) are not included in the quantity count. Otherwise Neutral count would be messy as investigator's signature cards are mostly neutral.
- Weakness cards are separated and stored in its divider as these are meant to be shuffled together regardless of cycle. (Print this divider in an another folder, it is not here.)
- Player cards from Return To are only separated by cycle (the icon) but not class, since it gives you only a few cards of the same class. Better make this a single rainbow set. It is small enough so you can search for what you want.
- Player cards from Investigator Starter Deck is of the same color, so it makes a single set of 50+ cards which isn't helpful. Instead, Investigator Starter Deck is subsetted by 3 card types. (Asset, Event, Skill) This produces an acceptable set size of Asset and Event but perhaps a too tiny set of Skill, but still better than a set of 50+ cards.
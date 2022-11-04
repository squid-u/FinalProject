// gaming gaming gaming gaming
class game
{
    public static void PileNumber()
    {
        Random random = new Random();
        int rannumber = random.Next(1, 421);
        Console.Write(rannumber);
    }
    public static void BiggerPileNumber()
    {
        Random random = new Random();
        int rannumber = random.Next(421, 2422);
        Console.Write(rannumber);
    }
    static void Main(String[] args)
    {
        restart:
        Console.ForegroundColor = ConsoleColor.White;
        bool alive = true;
        while (alive == true)
        {
            Console.WriteLine("please use completely lower case to answer unless prompted.");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("you are in a forest. do you go left or right?");
            didntdietoapit: string directionI = Console.ReadLine();
            if (directionI == "left")
            {
                Console.WriteLine(" ");
                Console.WriteLine("you turn and walk to the left.");
                Console.WriteLine("do you continue forward?");
                string pitdeath = Console.ReadLine();
                if (pitdeath == "yes")
                {
                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("you continue walking, and fall directly into a massive pit.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" ");
                    Console.WriteLine("ending 'uncushioned' 1/11");
                    alive = false;
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("you backtrack to where you started. do you go left or right?");
                    goto didntdietoapit;
                }
            }
            else if (directionI == "right")
            {
                Console.WriteLine(" ");
                Console.WriteLine("you turn and walk to the right.");
                Console.WriteLine("you see a pile of bones in a clearing. do you go back or approach?");
                string rightI = Console.ReadLine();
                if (rightI == "go back" || rightI == "back")
                {
                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("you turn away from the bones, walking into the nearby foliage. you exit the forest, and the world, by falling into a pit of snakes.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" ");
                    Console.WriteLine("ending 'noodles!' 2/11");
                    alive = false;
                }
                else if (rightI == "approach")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("you walk towards the pile of bones. there is an unidentifiable avian skull on the top that would fit over your head. do you put it on?");
                    string skull = Console.ReadLine();
                    if (skull == "yes")
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("you pick up the sun bleached skull, and place it onto your head.");
                        Console.WriteLine("you black out.");
                        Console.WriteLine(" ");
                        Console.WriteLine("slowly blinking awake, you find yourself kneeling before a red-cloaked figure.");
                        Console.WriteLine("you don't- can't- look up and away from the fawn you hold in your grasp.");
                        Console.WriteLine("you are holding an obsidian dagger, carefully carved with the visage of a woodpecker.");
                        Console.WriteLine("do you continue?");
                        string bloodbath = Console.ReadLine();
                        if (bloodbath == "yes")
                        {
                            Console.WriteLine(" ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("you drag the weapon through the pathetic little thing's throat, and it paints the stone a bloody red.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("it twitches briefly, but quickly falls limp in your arms.");
                            Console.WriteLine("something thrumms through the ground, softly glowing lines spreading out from the blood to surround you.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("your vision fades out to the sound of birdsong.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" ");
                            Console.WriteLine("ending 'birds of a feather' 3/11");
                            alive = false;
                        }
                        else if (bloodbath == "no")
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("you let go of the helpless creature, and it writhes on the ground, bleating pathetically.");
                            Console.WriteLine("the figure before you sighs in annoyance, snapping closed a book that it was holding.");
                            Console.WriteLine("it slams the heavy, metal bound thing up into your jaw.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("your vision fades out to the sound of murmuring and rustling feathers.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" ");
                            Console.WriteLine("ending 'failed ritual' 4/11");
                            alive = false;
                        }
                    }
                    else if (skull == "no")
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("you walk around the bones and scare off a flock of various birds that were foraging on the ground behind it. you walk for a time, and hit another fork. left or right?");
                        string whereGo = Console.ReadLine();
                        Console.WriteLine(" ");
                        Console.WriteLine("you walk to the " + whereGo + " and admire the clusters of white flowers growing on the path. your feet sink into the muddy ground, and you soon find yourself at the bank of a river.");
                        Console.WriteLine("as you look at the river, you see a line of slick stones that lead to the other bank. looking to your side, you see a dead, brittle tree. how do you get across?");
                        string justpickstones = Console.ReadLine();
                        if (justpickstones == "tree" || justpickstones == "brittle tree")
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("you push the tree, and it creaks before it shatters and lands over the river. you climb atop it, and begin to walk across.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("halfway through, your foot breaks into a hollow and snaps the tree in half. you fall into the river, slam against the stones, and are shoved underwater. you do not resurface.");
                            Console.WriteLine(" ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("ending 'swimming with the fishes' 5/11");
                            alive = false;
                        }
                        else if (justpickstones == "stones" || justpickstones == "stone" || justpickstones == "slick stones" || justpickstones == "rock" || justpickstones == "rocks")
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("you turn from the tree and instead try your luck on the water-polished stones. you, somehow, don't end up dead on the bottom of a lake.");
                            Console.WriteLine("you reach dry land on the other bank, and see a well worn trail lit by lanternlight. do you go down it?");
                            string pathyesorno = Console.ReadLine();
                            if (pathyesorno == "yes")
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("you walk down the path, looking up at the sky to see it beginning to turn indigo. ");
                                Console.WriteLine("as night falls, the shadows writhe. you watch them as you walk down the path.");
                                Console.WriteLine("the path opens up into a well-lit clearing with a house at the other side. you stare up at it's cobble tower as you creep towards the door. a small garden of various plants is situated to either side of the door.");
                                Console.WriteLine("you come up to the door. do you knock?");
                                string doorknock = Console.ReadLine();
                                if (doorknock == "yes")
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("you knock on the wooden door. you wait.");
                                    Console.WriteLine("you knock again.");
                                    Console.WriteLine("you-");
                                    Console.WriteLine(" ''Hello?''");
                                    Console.WriteLine("you spin around to face the voice, and take in the creature before you.");
                                    Console.WriteLine("it has the head of a crow, beady white eyes staring you down. it's body is covered by a blood red cloak that has a golden clasp, but you can see it's clawed feet below the fabric.");
                                    Console.WriteLine(" ''Ah-- apologies, I forgot how jarring a sight I am to outsiders. It's unfortunately common here. Come, come, get inside- the forest gets quite ravenous at night!''");
                                    Console.WriteLine("the thing ushers you inside, the door swinging closed behind the two of you.");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" ''Sit down, sit down- would you like some tea? Snacks? Please forgive me not being at the door, it's been so long since I've actually had to entertain guests! Rusts your manners, you know.''");
                                    Console.WriteLine("you sit down on the couch as the creature mills about the kitchen, looking back at you every few steps. Suddenly, it stops, triumphantly holding up an unlabeled tin.");
                                    Console.WriteLine(" ''There it is! I knew I had some left!'' it opens the metallic box and tilts it towards you, letting you see the loose-leaf tea inside. it has dusty purple petals in it.");
                                    Console.WriteLine(" ''Would you like some? I planned on having some myself after an excursion, but it'd be rude to not offer some to my guest!''");
                                    string teatime = Console.ReadLine();
                                    string name = "friend";
                                    if (teatime == "yes")
                                    {
                                        Console.WriteLine(" ");
                                        Console.WriteLine("it gives you the closest version of a smile that it can muster, which is particularly disturbing given it has a beak.");
                                        Console.WriteLine(" ''Alright! I'll get the tea going, and we can chat while we wait.''");
                                        Console.WriteLine(" ");
                                        Console.WriteLine("it sits down beside you, leaning back against the couch cusions and clasping its hands.");
                                        Console.WriteLine(" ''Well, I'm not quite sure what to talk about- but you are an outsider, so... is there anything that you would like to know about?''");
                                        Console.WriteLine(" ");
                                        Console.WriteLine("(input any word/words you are wondering about in lowercase. certain words have certain answers, ex. 'shadows' (this example gives lore))");
                                        bool introduced = false;
                                        bool tearefused = false;
                                    back: string big = Console.ReadLine();
                                        if (big == "cult" || big == "bird cult")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''Ah, that. Well- it's... it's certainly something. Magic, blood rituals, transformation- all that.'' it waves a hand dismissively.");
                                            Console.WriteLine(" ''Since you're here, though? You don't have to worry about them.'' it assures.");
                                            Console.WriteLine(" ''Is there something else you'd like to know about?''");
                                            big = "";
                                            goto back;
                                        }
                                        else if (big == "you" || big == "yourself" || big == "who are you" || big == "what are you")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''Wha- oh, me?'' it laughs softly, ''I suppose I forgot to introduce myself. I'm Harry, Harry Birdman- though I don't find much use for my last name.'");
                                            Console.WriteLine(" ''What is your name?''");
                                            name = Console.ReadLine();
                                            Console.WriteLine(" ''" + name + "? Nice to meet you, then!''");
                                            Console.WriteLine(" ''Well, introductions are out of the way- so what would you like to talk about?''");
                                            introduced = true;
                                            big = "";
                                            goto back;
                                        }
                                        else if (big == "me")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''...You? Why are you asking about yourself?''");
                                            Console.WriteLine(" ''You're... you're a human? I'm not sure what else you want me to say.''");
                                            Console.WriteLine(" ''AAaaanyways... is there anything else you'd like to talk about?''");
                                            big = "";
                                            goto back;
                                        }
                                        else if (big == "")
                                        {
                                            goto back;
                                        }
                                        else if (big == "bird" || big == "birds")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''Birds are nice creatures, I think. I am a bit biased, though, if you couldn't tell.''");
                                            Console.WriteLine(" ''I'm quite fond of the painted bunting, though!''");
                                            Console.WriteLine(" ''Is there anything else you would like to talk about?''");
                                            big = "";
                                            goto back;
                                        }
                                        else if (big == "bird men" || big == "birdmen" || big == "bird man" || big == "birdman")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''Oh, you've seen them before? I didn't think that they went that close to the edge of the forest... Ah, well.''");
                                            Console.WriteLine(" ''Yes, a significant portion of this forest's inhabitants are avian in nature. Bird heads, talons- all that. No wings though.''");
                                            Console.WriteLine(" ''If you're able to, I'd keep away from any of them. Most are an unfriendly sort, unlike me.''");
                                            Console.WriteLine(" ''Nothing to be done about it, though.''");
                                            Console.WriteLine(" ''Is there anything else you'd like to talk about?''");
                                            big = "";
                                            goto back;
                                        }
                                        else if (big == "shadow" || big == "shadows" || big == "forest shadow" || big == "hungry shadow" || big == "hungry shadows" || big == "hungry forest" || big == "ravenous forest")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''Oh, them.' it sighs, leaning forward and resting its elbows on its knees.");
                                            Console.WriteLine(" ''Yes, the shadows. They're... generally inert at night, but the latent magic of this place allows fragments of unfathomable things to cut through into our realm.''");
                                            Console.WriteLine(" ''I've known of a few who take to worshipping them in places they manage to catch hold, but the shadows are generally just unpleasant in my opinion.''");
                                            Console.WriteLine(" ''The shadows also leave a... residue, of sorts. It's a black liquid that has no shine. It's nearly impossible to work with, too, since it eats through organic material like mould.''");
                                            Console.Write(" ''It has no official name, so I just call it");
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.Write(" the Blight.");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.Write("''");
                                            Console.WriteLine("");
                                            Console.WriteLine(" ''I've seen the results of it's poisoning. It attacks the soft tissues first- though I don't know if its for being easier to consume or a preference.''");
                                            Console.WriteLine(" ''Before it's able to reach there, though, it's usually taken in through a cut on a finger- and that is how it will appear.''");
                                            Console.WriteLine(" ''Your fingertips will gradually turn black as if they were afflicted with necrosis, and it'll visibly turn your veins black.''");
                                            Console.Write(" ''It's always fatal. Once it hits the brain, you go down- and that's where the");
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.Write(" Blight ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.Write("will grow from.");
                                            Console.WriteLine("");
                                            Console.Write(" ''It usually appears as thick black vines that grow outwards from the afflicted corpse. The body's eyes will have already been consumed at that point- so liquid");
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.Write(" Blight ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.Write("will pour from the sockets.''");
                                            Console.WriteLine("");
                                            Console.Write(" ''It's a slow, painful way to die, so I'd reccomend ");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write("staying away from any odd-looking shadows.''");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("");
                                            Console.WriteLine(" ''...''");
                                            Console.WriteLine(" ''Well... enough about that. Is there anything else you'd like to talk about?''");
                                            big = "";
                                            goto back;
                                        }
                                        else if (big == "number" || big == "random number" || big == "random" || big == "#")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''Think of a random number? Hm... ''");
                                            Console.Write(" ''");
                                            PileNumber();
                                            Console.Write("!''");
                                            Console.WriteLine("");
                                            Console.WriteLine(" ''That's a pretty good number, don't you think?''");
                                            Console.WriteLine(" ''Well, anyways, what would you like to talk about?''");
                                            big = "";
                                            goto back;
                                        }
                                        else if (big == "books" || big == "book" || big == "journal" || big == "journals" || big == "novel" || big == "novels")
                                        {
                                            Console.WriteLine(" ''Oh, I enjoy all sorts of reading! I'll admit that I am partial to scientific journals, though.'");
                                            Console.WriteLine(" ''I like to write down my own discoveries in journals of my own, too! I don't usually research something actively, though. And certainly not as professionally!''");
                                            Console.WriteLine(" ''Science is quite interesting. I'm sure you're getting bored, though, so is there anything else you'd like to talk about?''");
                                            big = "";
                                            goto back;
                                        }
                                        else if (big == "tea" || big == "what is the tea" || big == "what tea")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''The tea? It's made with the leaves and flowers of this nice bush-like plant. It has these dull purple bell-shaped flowers, which you saw in the tin, and it has these glossy black berries that I've seen birds peck at- and I've had a few myself, too, and they're quite good!''");
                                            Console.WriteLine(" ''It usually makes me quite tired, so I sleep after having the tea. Works like a charm!''");
                                            Console.WriteLine(" ''I do hope you like it when it's ready. It's my favorite!''");
                                            Console.WriteLine(" ''You... do still want it, right?''");
                                            string tearefuse2 = Console.ReadLine();
                                            if (tearefuse2 == "yes")
                                            {
                                                Console.WriteLine(" ");
                                                Console.WriteLine(" ''Oh, good, good! I do hope that you'll like it- it's one of my favorites.''");
                                                Console.WriteLine(" ''Is there anything else you'd like to talk about?''");
                                                big = "";
                                                goto back;
                                            }
                                            else
                                            {
                                                Console.WriteLine(" ");
                                                Console.WriteLine(" ''Ah, alright. I'll get you a glass of water instead when the tea is ready.''");
                                                tearefused = true;
                                                Console.WriteLine(" ''Is there anything else you'd like to talk about?''");
                                                big = "";
                                                goto back;
                                            }
                                        }
                                        else if (big == "map")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''Ah, maps. I'd offer you one, but they don't usually stay the same. The forest doesn't either.''");
                                            Console.WriteLine(" ''It's hard enough to follow any sort of map as a native of this place, but an outsider? They'll be illegible");
                                        }
                                        else if (big == "nature" || big == "trees" || big == "tree" || big == "water" || big == "earth" || big == "ice" || big == "fire" || big == "dirt" || big == "air")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''The nature in this forest is... relatively normal. Sort of.''");
                                            Console.WriteLine(" ''There are a few places where the veil between worlds is much thinner than the rest.''");
                                            Console.WriteLine(" ''Sometimes they can be bound to one place, but it's usually not permenantly. They close and open at random, too.''");
                                            Console.WriteLine(" ''Some veils like to drift about at the pace of a snail. Hm... I think I remember some sort of story about playing keep-away with a snail...''");
                                            Console.WriteLine(" ''Ah, it probably doesn't matter.''");
                                            Console.WriteLine(" ''Is there anything else you'd like to talk about?''");
                                            big = "";
                                            goto back;
                                        }
                                        else if (big == "monke" || big == "monkes" || big == "Monke" || big == "Monkes" || big == "monkey" || big == "monkeys" || big == "Monkeys" || big == "Monkey")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''Monkeys? I've heard of them on occasion. Little humanoids with tails and fur, and big ears, right?''");
                                            Console.WriteLine(" ''They sound quite cute! Though... their described behaviors leave much to be desired.''");
                                            Console.WriteLine(" ''A shame... well, is there anything else you'd like to talk about?''");
                                            big = "";
                                            goto back;
                                        }
                                        else if (big == "bird flu" || big == "flu" || big == "disease" || big == "plague")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''While my kind seems to be less susceptible to illnesses than most, we unfortunately can still get sick. Those diseases are usually magical in origin, though.''");
                                            Console.WriteLine(" ''You didn't enter the forest while any curses were going around, thankfully, since they seem to be decently fatal to humans.''");
                                            Console.WriteLine(" ''There's a whole variety of them- enough that I won't bother to bore you by listing them all off.''");
                                            Console.WriteLine(" ''Is there anything else you'd like to talk about?''");
                                            big = "";
                                            goto back;
                                        }
                                        else if (big == "covid")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''Covid? Can't say I've heard of that before. Sounds kind of like corvid. Cool!''");
                                            Console.WriteLine(" ''Is there anything else you'd like to talk about?''");
                                            big = "";
                                            goto back;
                                        }
                                        else if (big == "nightshade" || big == "deadly nightshade" || big == "belladonna" || big == "atropa belladonna")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''...Hm, " + big + "? Ah... I think I may have seen that mentioned in a few survivor's guides I found.''");
                                            Console.WriteLine(" ''They were all too damaged to see any images or descriptions, though.''");
                                            Console.WriteLine(" ''Why do you ask?''");
                                            string oopspoison = Console.ReadLine();
                                            if (oopspoison == "tea" || oopspoison == "the tea" || oopspoison == "poison tea" || oopspoison == "poisonous tea")
                                            {
                                                Console.WriteLine(" ");
                                                Console.WriteLine(" ''Oh, that's what the plant I use for my tea is called? Hm! Good to know!''");
                                                Console.WriteLine(" ''...But why are you so worried? It's just a plant.''");
                                                string heehoopoison = Console.ReadLine();
                                                if (heehoopoison == "poison" || heehoopoison == "poisonous" || heehoopoison == "toxic")
                                                {
                                                    Console.WriteLine(" ");
                                                    Console.WriteLine(" ''What do you mean? It's not poisonous! It certainly hasn't killed me, and I haven't found any corpses around it.''");
                                                    Console.WriteLine(" ''If you really feel uncomfortable having the tea, though, you certainly don't have to have it.''");
                                                    Console.WriteLine(" ''Do you still want the tea?''");
                                                    string tearefuse1 = Console.ReadLine();
                                                    if (tearefuse1 == "yes")
                                                    {
                                                        Console.WriteLine(" ");
                                                        Console.WriteLine(" ''Oh! Alright then! I'm not sure why you brought it up, then, but thank you for putting a name to a beloved plant!''");
                                                        Console.WriteLine(" ''Well, is there anything else you'd like to talk about?''");
                                                        big = "";
                                                        goto back;
                                                    }
                                                    else if (tearefuse1 == "no")
                                                    {
                                                        Console.WriteLine(" ");
                                                        Console.WriteLine(" ''Ah, alright. Well- I can get you a glass of water instead, when the tea is ready.''");
                                                        Console.WriteLine(" ''Is there anything else you'd like to talk about?''");
                                                        tearefused = true;
                                                        big = "";
                                                        goto back;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine(" ");
                                                    Console.WriteLine(" ''Hm. Okay.''");
                                                    Console.WriteLine(" ''Is there anything else you'd like to talk about?''");
                                                    big = "";
                                                    goto back;
                                                }
                                            }
                                        }
                                        else if (big == "poison")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''Poison in all types is fascinating, if gruesome. Why do you think I know so much about the effects of void?''");
                                            Console.WriteLine(" ''Hah, I'm only kidding- or am I?'' it smirks, then laughs and lets its smirk fade.");
                                            Console.WriteLine(" ''Fascinating stuff, poison. It also isn't venom, no matter what those kids keep saying.''");
                                            Console.WriteLine(" ''Is there anything else you'd like to talk about?''");
                                            big = "";
                                            goto back;
                                        }
                                        else if (big == "money")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''Money? It's very shiny, and I quite like it. It sparkles nicely if you polish it.''");
                                            Console.WriteLine(" ''We don't really use it in this forest, unfortunately- nobody is able to agree on a coin design, what with all the gods or higher beings or what-have-yous.''");
                                            Console.WriteLine(" ''I'm fond of the simple coins with a square hole in the center, myself.''");
                                            Console.WriteLine(" ''Is there anything else you'd like to talk about?''");
                                            big = "";
                                            goto back;
                                        }
                                        else if (big == "life" || big == "life here" || big == "your life")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''My life here? It's decently nice, I think. I don't exactly have much of a reference point, though.''");
                                            Console.WriteLine(" ''I usually forage or hunt for my own food, and it's easy enough to get water from the river. Generally clean, too!''");
                                            Console.WriteLine(" ''I also collect the bits and pieces of outside the forest from unfortunate hikers. It's why my bookshelves are so dissapointingly sparse- it's not like there's any actual bookstores.''");
                                            Console.WriteLine(" ''It... can get a bit repetitive, but this is the only life I actually have, so I try my best to enjoy it.''");
                                            Console.WriteLine(" ''Well, is there anything else you'd like to talk about?''");
                                            big = "";
                                            goto back;
                                        }
                                        else if (big == "kid" || big == "kids" || big == "child" || big == "children")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''Kids? Ah, yes, children certaintly... are.''");
                                            Console.WriteLine(" ''I don't know if you've met them- probably not -but there are children that live in the forest. Most certainly not human, but nobody dares ask what they are.''");
                                            Console.WriteLine(" ''As long as we let them do what they please, though, they're content to not do anything too disastrous.''");
                                            Console.WriteLine(" ''Just...");
                                            Console.Write(" ah... ");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write("don't tell them your actual name");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.Write(", okay?''");
                                            Console.WriteLine("");
                                            Console.WriteLine(" ''I- I know it's probably irrational, but- so much about them lines up just right with stories of fair folk I've found!''");
                                            Console.WriteLine("you stare incredulously at the bird without saying anything for a hot minute. it fidgets nervously.");
                                            Console.WriteLine(" ''Don't look at me like that! Just... be careful, okay?''");
                                            Console.WriteLine(" ''...''");
                                            Console.WriteLine(" ''Is there anything else you'd like to ask about?''");
                                            big = "";
                                            goto back;
                                        }
                                        else if (big == "no")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''Oh, no? Alright, well-'' a sharp whistle sounded from the kitchen. ''Oh! Well, I suppose we didn't have time for any more questions anyways!''");
                                            Console.WriteLine("");
                                            Console.Write(" it pops up from the couch, striding to the kitchen. it returns quickly with");
                                            if (tearefused == true)
                                            {
                                                Console.Write(" a glass of water and a teacup on a tray.");
                                                Console.WriteLine("");
                                                Console.WriteLine("it sets down the tray, bringing it's teacup with it as it sits back down beside you.");
                                                Console.WriteLine(" ''Sorry that the tea didn't appeal to you, friend- I'd've offered something else if I actually had anything that tasted good.''");
                                                Console.WriteLine("it takes a long sip of tea.");
                                                if (introduced == false)
                                                {
                                                    Console.WriteLine(" ''By the way, I don't think I ever told you my name! Quite rude of me, honestly. I'm Harry Birdman, but I don't find much use for my last name.''");
                                                    Console.WriteLine(" ''What is your name?''");
                                                    name = Console.ReadLine();
                                                    Console.WriteLine(" ''" + name + "? That's a good name. Nice to meet you!''");
                                                    goto continued;
                                                }
                                                else
                                                {
                                                    goto continued;
                                                }
                                                continued: Console.WriteLine("he sighs, looking away from you.");
                                                Console.WriteLine(" ''I must apologize, but you can't stay here after tonight. I've another excursion planned, and I'm not very comfortable with the idea of leaving somebody alone unsupervised in my house.''");
                                                Console.WriteLine(" ''I can still offer you a bed for tonight, though. It's just the couch, unfortunately, but I can give you a pillow and blanket for the night.''");
                                                Console.WriteLine("stay the night?");
                                                string eepy = Console.ReadLine();
                                                if (eepy == "yes")
                                                {
                                                    Console.WriteLine(" ");
                                                    Console.WriteLine("the crow clasps his hands together happily.");
                                                    Console.WriteLine(" ''Wonderful! I can go get you that blanket and pillow now- it's getting late. I don't know about you, but I'm rather tired.''");
                                                    Console.WriteLine("he leaves the room. you look down at your hands, and twiddle your thumbs. something screams outside.");
                                                    Console.WriteLine("Harry returns with a comforter and a pillow, and hands you the blanket. he fluffs the pillow and places it at the head of the couch.");
                                                    Console.WriteLine(" ''I'll be turning in now. Sleep well!''");
                                                    Console.WriteLine("you wave to the bird as he goes to bed, and you settle down on the couch with the blanket wrapped around you.");
                                                    Console.WriteLine("you fall asleep.");
                                                    Console.WriteLine(" ");
                                                    Console.ForegroundColor = ConsoleColor.Gray;
                                                    Console.WriteLine("you are standing in a void.");
                                                    Console.WriteLine("there is no visible floor, nor visible walls or ceiling.");
                                                    Console.WriteLine("you return to looking before you, and the floor writhes.");
                                                    Console.WriteLine("you step back a pace. you bump into something.");
                                                    Console.WriteLine("turning, you see two rapidly fleeing childlike figures.");
                                                    Console.WriteLine("they gleam with yellowish light not unlike sunlight.");
                                                    Console.WriteLine("you reach for them, but shadowed tendrils restrain you.");
                                                    Console.WriteLine("you-");
                                                    Console.WriteLine(" ");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("wake up.");
                                                    Console.WriteLine(" ");
                                                    Console.WriteLine("you blink up at the beamed ceiling. the room is bright with sunlight.");
                                                    Console.WriteLine("sitting up, you listen to the quiet sounds of wildlife and the sounds of shuffling coming from the kitchen. you finally register that some kind of food is being cooked, and groggily stand.");
                                                    Console.WriteLine("you wander to the kitchen. Harry is cooking what looks like a purple egg. you don't think about it too hard.");
                                                    Console.WriteLine("he turns to look at you, and you realize that he's wearing a pinstriped blue and white nightgown with a matching hat that has a pompom on the tip. on a nearby counter, a candle sits in a metal holder.");
                                                    Console.WriteLine(" ''Oh! Good morning, " + name + "! Did you sleep well?''");
                                                    string sweetdream = Console.ReadLine();
                                                    if (sweetdream == "yes")
                                                    {
                                                        Console.WriteLine(" ");
                                                        Console.WriteLine(" ''Oh, that's good! I'm glad that you didn't find the couch too uncomfortable.''");
                                                        goto sweetdreams;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine(" ");
                                                        Console.WriteLine(" ''Ah, that's a shame. The couch has never been good for the prolonged health of spines.''");
                                                        goto sweetdreams;
                                                    }
                                                    sweetdreams: Console.WriteLine(" ''Well, I've made some breakfast so you don't have to hit the path hungry! Enjoy!''");
                                                    Console.WriteLine("he tosses the sunny-side-up egg to you, and it lands squarely in your mouth as you yawn. it tastes like pork-flavored jello.");
                                                    Console.WriteLine(" ''I'm afraid that, other than that, I only have one other thing I can give you.''");
                                                    Console.WriteLine("Harry puts the pan down, and grabs a hooded lantern. he hands it to you.");
                                                    Console.WriteLine(" ''That should help keep anything unsavory from eating you in the night. The shadows, at least. I can't speak for anything else.''");
                                                    Console.WriteLine(" ''I truly am sorry that I can't give you anything else- but I also need to survive here, and I don't have infinite resources.''");
                                                    Console.WriteLine("he smiles at you, patting your shoulder. ''Good luck out there, okay? Dying here is particularly unpleasant.''");
                                                    Console.WriteLine("you nod, holding the lantern tightly.");
                                                    Console.WriteLine(" ''Goodbye!''");
                                                    Console.WriteLine("you wave to Harry as you walk to the door.");
                                                    Console.WriteLine(" ");
                                                    Console.WriteLine("you open it, and you stride into the bright light. the door drifts shut behind you.");
                                                    Console.WriteLine(" ");
                                                    Console.WriteLine("ending 'to be continued' 11/11");
                                                }
                                                else
                                                {
                                                    Console.WriteLine(" ");
                                                    Console.WriteLine(" ''Oh, alright. Well- um- good luck out there, I suppose?''");
                                                    Console.WriteLine("Harry waves as you stand from the couch. you approach the door.");
                                                    Console.WriteLine("you reach towards the handle-");
                                                    Console.Write("");
                                                    Console.ForegroundColor = ConsoleColor.Gray;
                                                    Console.Write("the door bursts open, ");
                                                    BiggerPileNumber();
                                                    Console.Write(" pounds of something sharp and slimy crushing you under its weight.");
                                                    Console.WriteLine(" ");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("ending 'frazzled hospitality' 10/11");
                                                    alive = false;
                                                }
                                            }
                                            else
                                            {
                                                bool brokenotherwise = false;
                                                Console.Write(" two teacups full of steaming tea. a floral scent fills the room.");
                                                Console.WriteLine("");
                                                Console.WriteLine(" ''Here's the tea! I really do hope you like it.'' it sits back down beside you, pulling its cup with it.");
                                                if (introduced == false)
                                                {
                                                    Console.WriteLine(" ''By the way, I never did introduce myself- I'm Harry Birdman. I don't generally use my last name.''");
                                                    Console.WriteLine(" ''What is your name?''");
                                                    name = Console.ReadLine();
                                                    Console.WriteLine(" ''Nice to meet you, " + name + "! That's a nice name.''");
                                                    brokenotherwise = true;
                                                    if (brokenotherwise == true)
                                                    {
                                                        Console.WriteLine("he takes a long sip of tea, and you follow suit. it's sweet, and floral- it barely tastes like tea.");
                                                        Console.WriteLine("Harry lowers his cup, looking back over to you. ''So, what do you think? It's good even without anything added!''");
                                                        Console.WriteLine("you try to respond, but find that you can't control your mouth.");
                                                        Console.WriteLine(" ''..." + name + "?''");
                                                        Console.WriteLine("your head feels like it's been sandblasted with cotton. heat flashes through your body, and you dimly register yourself falling.");
                                                        Console.WriteLine("indistinct colors and shapes swim in your vision. you try to breathe, but find yourself choking on something.");
                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                        Console.WriteLine("coughing, you eventually pass out with a foam filled mouth.");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine(" ");
                                                        Console.WriteLine("ending 'belladonna atropa' 9/11");
                                                        alive = false;

                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("AAAAAAAAAAGH if this happens the game is BROKEN AUGH");
                                                        alive = false;
                                                    }
                                                }
                                                else if (introduced == true)
                                                {
                                                    brokenotherwise = true;
                                                    Console.WriteLine(" ''Enjoy!''");
                                                    Console.WriteLine("he takes a long sip of tea, and you follow suit. it's sweet, and floral- it barely tastes like tea.");
                                                    Console.WriteLine("Harry lowers his cup, looking back over to you. ''So, what do you think? It's good even without anything added!''");
                                                    Console.WriteLine("you try to respond, but find that you can barely move your mouth- it's gone numb.");
                                                    Console.WriteLine(" ''..." + name + "?''");
                                                    Console.WriteLine("your head feels like it's been sandblasted with cotton. heat flashes through your body, and you dimly register yourself falling.");
                                                    Console.WriteLine("indistinct colors and shapes swim in your vision. you try to breathe, but find yourself choking on something.");
                                                    Console.ForegroundColor = ConsoleColor.Gray;
                                                    Console.WriteLine("coughing, you eventually pass out with a foam filled mouth.");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine(" ");
                                                    Console.WriteLine("ending 'belladonna atropa' 9/11");
                                                    alive = false;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''Er... I'm not quite sure what you're talking about?''");
                                            Console.WriteLine(" ''A-anyways.. is there anything else you'd like to ask about?''");
                                            big = "";
                                            goto back;
                                        }
                                    }
                                    else if (teatime == "no")
                                    {
                                        Console.WriteLine(" ");
                                        Console.WriteLine(" ''Ah, a shame. Well, then, come with me- I might as well show you this now.''");
                                        Console.WriteLine("the creature leads you away from the entrance and down a hallway, and opens one door into a dim stairway leading downwards.");
                                        Console.WriteLine(" ''Go down there, would you? I'll follow behind.''");
                                        Console.WriteLine("descend?");
                                        string basementtime = Console.ReadLine();
                                        if (basementtime == "yes")
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''Good, good! Go on then.''");
                                            Console.WriteLine(" ");
                                            Console.WriteLine("you step inside, footsteps loud on the stone. it's too dark to see anything.");
                                            Console.WriteLine("hands grip your shoulders, and they shove you forward into something that you quickly become tangled in.");
                                            Console.WriteLine("you can see, illuminated by the house above, the thing's silhouette.");
                                            Console.WriteLine(" ''There we go.''");
                                            Console.WriteLine("it shifts past you, and you hear a match being lit. light floods from behind you.");
                                            Console.WriteLine(" ''I'll need to put you in a better position, but you're probably less concerned about that right now, hm?''");
                                            Console.WriteLine("it paces around you, holding a candle while gesturing with its other hand. a small vial holding a pitch-black liquid like the shadows around you both swirls with each movement.");
                                            Console.WriteLine(" ''Well, to put things simply, you're here to sate my curiosity.'' it said, stopping where it was and turning back towards you.");
                                            Console.WriteLine("");
                                            Console.Write(" ''See, I already know how ");
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.Write("the Blight ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.Write("effects the body when it enters through a wound.''");
                                            Console.WriteLine("");
                                            Console.WriteLine(" ''But after all I've seen, all I've tried, I never wondered-''");
                                            Console.WriteLine(" '' 'What happens if you drink it?' ''");
                                            Console.WriteLine("it walks up to you, candle flickering.");
                                            Console.WriteLine(" ''Now, I couldn't test it on myself, of course. So I resolved to bring in an outside volunteer.''");
                                            Console.WriteLine("it lifts the hand with the vial, placing a clawtip on your chest.");
                                            Console.WriteLine(" ''You, my friend, are that volunteer.''");
                                            Console.WriteLine("it smiles, pulling out the vial's stopper. ''Now try to relax and let it happen, dear,''");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.WriteLine(" ''Because this is going to hurt quite a bit.''");
                                            Console.WriteLine(" ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("ending 'dependent variable' 8/11");
                                            alive = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine(" ");
                                            Console.WriteLine(" ''No? Oh, my friend!'' it places a hand on your shoulder, laughing.");
                                            Console.WriteLine(" ''I wasn't giving you a choice.''");
                                            Console.WriteLine("it shoves you down the stairs. you land in something that you quickly become tangled in.");
                                            Console.WriteLine("you can see, illuminated by the house above, the thing's silhouette.");
                                            Console.WriteLine(" ''There we go.''");
                                            Console.WriteLine("it shifts past you, and you hear a match being lit. light floods from behind you.");
                                            Console.WriteLine(" ''I'll need to put you in a better position, but you're probably less concerned about that right now, hm?''");
                                            Console.WriteLine("it paces around you, holding a candle while gesturing with its other hand. a small vial holding a pitch-black liquid like the shadows around you both swirls with each movement.");
                                            Console.WriteLine(" ''Well, to put things simply, you're here to sate my curiosity.'' it said, stopping where it was and turning back towards you.");
                                            Console.WriteLine("");
                                            Console.Write(" ''See, I already know how ");
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.Write("the Blight ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.Write("effects the body when it enters through a wound.''");
                                            Console.WriteLine("");
                                            Console.WriteLine(" ''But after all I've seen, all I've tried, I never wondered-''");
                                            Console.WriteLine(" '' 'What happens if you drink it?' ''");
                                            Console.WriteLine("it walks up to you, candle flickering.");
                                            Console.WriteLine(" ''Now, I couldn't test it on myself, of course. So I resolved to bring in an outside volunteer.''");
                                            Console.WriteLine("it lifts the hand with the vial, placing a clawtip on your chest.");
                                            Console.WriteLine(" ''You, my friend, are that volunteer- however unwilling you were to sign up.''");
                                            Console.WriteLine("it smiles, pulling out the vial's stopper. ''Now try to relax and let it happen, dear,''");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.WriteLine(" ''Because this is going to hurt quite a bit.''");
                                            Console.WriteLine(" ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("ending 'voluntold' 9/11");
                                        }
                                    }
                                }
                                else if (doorknock == "no")
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("you lower your fist and step back from the door, inspecting it. it has lichen climbing up it, and odd gashes in the wood.");
                                    Console.WriteLine("you walk around the side of the house, and begin your walk to the back of the home. you hear a voice faintly call out to you, but you fall into the shadows anyways.");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("ending 'belated warning' 7/11");
                                    alive = false;
                                }
                            }
                            else if (pathyesorno == "no")
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("there aren't any other directions to go, but instead of following the path, you sit down against the nearest tree. when night falls, thorny vines wind around your legs and drag you into the shadows. the lanterns probably would've been safer...");
                                Console.WriteLine(" ");
                                Console.WriteLine("ending 'nyctophobia' 6/11");
                                alive = false;
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("would you like to try again?");
        string restart = Console.ReadLine();
        if (restart == "yes")
        {
            alive = true;
            Console.Clear();
            goto restart;
        }
        if (restart == "no")
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ");
            Console.WriteLine("game over, goodbye!");
            Console.WriteLine(" ");
            Environment.Exit(0);
        }
    }
}
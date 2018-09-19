using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComicStrip {

	// Use this for initialization
	public Dictionary<string, SpeechSet> comics = new Dictionary<string, SpeechSet>(){
		{ //1
			"1234",
			
			new SpeechSet (
				"Look at that view.",
				"I'm hungry.",
				"We literally \njust ate a horse.",
				"It was a unicorn, \nyou dolt."	
			)
		},
		{ //2
			"1243",
			
			new SpeechSet (
				"Whoa, is that \nthe sun?",
				"I haven't seen it \nsince yesterday",
				"...",
				"You lost \nmy shades."	
			)
		},
		{ //3
			"1342",
			
			new SpeechSet (
				"I'm not built \nfor this weather.",
				"You're not built \nfor anything.",
				"Not even love...",
				"What did \nI do now?!"	
			)
		},
		{ //4
			"1324",
			
			new SpeechSet (
				"Are we there yet?",
				"Ask that again \nand I'll...",
				"Kiss me?",
				"Fat chance..."	
			)
		},
		{ //5
			"1432",
			
			new SpeechSet (
				"Where the hell \nare we?",
				"You said you knew...",
				"I told you to \nsteal that map!",
				"Mouths don't steal, \nwe lie."	
			)
		},
		{ //6
			"1423",
			
			new SpeechSet (
				"Ah! What a day!",
				"Thank you \nfor kidnapping me.",
				"You're my eye-dol.",
				"Don't call me that."	
			)
		},
		{ //7
			"2134",
			
			new SpeechSet (
				"I think we're \nin trouble.",
				"I have no idea \nwhere we are.",
				"What did you say?",
				"I trusted you..."	
			)
		},
		{ //8
			"2143",
			
			new SpeechSet (
				"<BURP>",
				"You think \nthey heard me?",
				"Don't know, \nbut I smelled it.",
				"Do you even floss?"	
			)
		},
		{ //9
			"2314",
			
			new SpeechSet (
				"Wait so you \ndidn't like \nMetal Gear?",
				"The story is stupid.",
				"IT'S THE BEST \nTHING EVER!!!",
				"Kojima fanboy."	
			)
		},
		{ //10
			"2341",
			
			new SpeechSet (
				"Do I have \nanything in \nmy teeth?",
				"Nope.",
				"...",
				"I want some ramen."	
			)
		},
		{ //11
			"2413",
			
			new SpeechSet (
				"You should smile \nmore often.",
				"I'm always smiling.",
				"The sun says \nyou're lying.",
				"Eat sand, \nyou loudmouth."	
			)
		},
		{ //12
			"2431",
			
			new SpeechSet (
				"What did \nshe tell you?",
				"The prophecy will \nbe fulfilled...",
				"and you're \nan asshole.",
				"Some things \nnever change."	
			)
		},
		{ //13
			"3124",
			
			new SpeechSet (
				"Why is brown \nnot dark red?",
				"It sort of is,\n right?",
				"Check the \nRGB values.",
				"But the world \nis black and white..."	
			)
		},
		{ //14
			"3142",
			
			new SpeechSet (
				"Mouth, we have to\nfind Nose first.",
				"They're probably\nin that direction.",
				"I hope so.",
				"I nose so."	
			)
		},
		{ //15
			"3214",
			
			new SpeechSet (
				"Did you take a bath \nthis morning?",
				"Uh, no... why?",
				"Who cares about \nhygiene out here?",
				"I do."	
			)
		},
		{ //16
			"3241",
			
			new SpeechSet (
				"Can you take \na photo of me?",
				"NOW?!",
				"Why not.",
				"WE'RE LOST!"	
			)
		},
		{ //17
			"3412",
			
			new SpeechSet (
				"How old \nare you again?",
				"Please be 18.",
				"What is age \nbut a number?",
				"I'm old enough \nto drink."	
			)
		},
		{ //18
			"3421",
			
			new SpeechSet (
				"You left the \nrocket fuel at home?",
				"We can't get \noff-planet...",
				"We can...",
				"If you leave \nme here."	
			)
		},
		{ //19
			"4123",
			
			new SpeechSet (
				"I can't look...",
				"Trust me, \nit's a great view.",
				"... If I could \nsee that is...",
				"You can't see?"	
			)
		},
		{ //20
			"4132",
			
			new SpeechSet (
				"<GROAN>",
				"Look at \nthe bright side!",
				"THERE IS \nNO BRIGHT SIDE!",
				"Even the blind \nsee a bright side."	
			)
		},
		{ //21
			"4213",
			
			new SpeechSet (
				"Something's \nin my eye...",
				"Which eye?",
				"I can't be sure \nwith all \nthis sun...",
				"..."	
			)
		},
		{ //22
			"4231",
			
			new SpeechSet (
				"Zzz",
				"Stop sleeping...",
				"STOP STARING!",
				"Because you'll \nmiss the view!"	
			)
		},
		{ //23
			"4312",
			
			new SpeechSet (
				"Shhh",
				"I need to meditate.",
				"We have \nto keep moving!",
				"They are near."	
			)
		},
		{ //24
			"4321",
			
			new SpeechSet (
				"Eat shit.",
				"I'm just kidding.",
				"Were you, now?",
				"Let's ask \nthe horizon!"	
			)
		},
		
	};
	
	public Dictionary<string, SpeechSet> actionstar = new Dictionary<string, SpeechSet>(){
		{ //1
			"1234",
			
			new SpeechSet (
				"Rodriguez! You're under arrest!",
				"You'll never take me alive!",
				"Say hello\nto my little friend!",
				"You'll have no friends\nwhere you're going!"	
			)
		},
		{ //2
			"1243",
			
			new SpeechSet (
				"Aha! I've got you now,\nRodriguez!",
				"All you've got is \na bad moustache!",
				"It's still better \nthan that goatee!",
				"TAKE THAT BACK!"	
			)
		},
		{ //3
			"1342",
			
			new SpeechSet (
				"You were a fool to come after me, Fernando.",
				"I warned you to \nstay out of this!",
				"You'd pull a gun \non your own partner?!",
				"You're right. \nLet's settle this \nlike we're back in academy."	
			)
		},
		{ //4
			"1324",
			
			new SpeechSet (
				"Why are evil lairs \nalways in warehouses?!",
				"Because gunshots \nsound more dramatic!",
				"On second thought, \nit does get a bit too loud\neven for me.",
				"Your taste in lairs is almost \nas bad as your facial hair!"	
			)
		},
		{ //5
			"1432",
			
			new SpeechSet (
				"Where the hell \nare we?",
				"How should I know? \nYOU'RE the villain!",
				"Stop fighting, both of you!",
				"Who--?!"	
			)
		},
		{ //6
			"1423",
			
			new SpeechSet (
				"You sold all the merchandise?!",
				"I knew you weren't \nready for the responsibility.",
				"Shut up! If I didn't sell it all, \nthe pigs would be onto us!",
				"Too bad--\nbecause I'm a pig."	
			)
		},
		{ //7
			"2134",
			
			new SpeechSet (
				"All denim huh?!",
				"Whatever, mister \nsneaker-color-matches-shirt-color!",
				"Freeze, Fashion Police here!\nYou're both under arrest!",
				"You said we would be alone!"	
			)
		},
		{ //8
			"2143",
			
			new SpeechSet (
				"You said the hostages would be here!",
				"DO YOU SEE ANY HOSTAGES?!",
				"The intel said they were.\nThis isn't on me.",
				"You think I care?"	
			)
		},
		{ //9
			"2314",
			
			new SpeechSet (
				"You said there was a foam party here!",
				"TAKE ME TO \nTHE FOAM PARTY!",
				"Or all you'll have is FOMO...\ntowards the living!",
				"Did you just...? \nKill me now please."	
			)
		},
		{ //10
			"2341",
			
			new SpeechSet (
				"At last, \nwe meet again!",
				"And today you'll breathe your last!",
				"A gun? Fighting like a coward again eh?",
				"At least I won't be dead!"	
			)
		},
		{ //11
			"2413",
			
			new SpeechSet (
				"Eat my punches, Fernando!",
				"You won't even be able to eat \nlugaw when I'm \ndone with you!",
				"Fool! I'll be eating lechon \non your grave!",
				"Have a shot of my gunpowder brew first!"	
			)
		},
		{ //12
			"2431",
			
			new SpeechSet (
				"So you think you're an action hero, Fernando?!",
				"I know I am, Rodriguez.",
				"Can you split my bullet in two, then?",
				"Just try me."	
			)
		},
		{ //13
			"3124",
			
			new SpeechSet (
				"Reach for the clouds, Rodriguez!",
				"ACK!!!",
				"If you're going to beat me, \ndo it with your bare hands, \nFernando!",
				"You'll be having my bare hands for brunch!"	
			)
		},
		{ //14
			"3142",
			
			new SpeechSet (
				"Fernando!",
				"If you move a muscle, I'll--",
				"You'll what? Shoot me?",
				"No, I'll beat you \nuntil your kids can't \nrecognize you first!"	
			)
		},
		{ //15
			"3214",
			
			new SpeechSet (
				"Which of these two idiots is the undercover cop?",
				"It's Fernando! Shoot Fernando!",
				"Fernando if you don't freeze now I'll...",
				"Stupid! It's Rodriguez!\nHe smells of bribes\nand illegal gambling."
			)
		},
		{ //16
			"3241",
			
			new SpeechSet (
				"I told you I'd find you and kill you, Rodriguez.",
				"Coward, use your fists, not your firearm!",
				"'Coward', huh?",
				"You'll be cowering once your teeth meet my knuckles!"	
			)
		},
		{ //17
			"3412",
			
			new SpeechSet (
				"Did I show you my gun yet?!",
				"Dammit son, I told you not to buy one!",
				"You NEVER listen \nto your father!",
				"Pa, I'm 30 years old!"	
			)
		},
		{ //18
			"3421",
			
			new SpeechSet (
				"Do you want to see what I killed her with?",
				"Stupid! I told you to get rid of that thing!",
				"I want to keep it as a souvenir!",
				"That puts us at the murder, idiot!"	
			)
		},
		{ //19
			"4123",
			
			new SpeechSet (
				"Son of a grasshopper! \nThis place is so obviously an evil lair!",
				"But don't bad guys always use abandoned warehouses?",
				"Yes, and the hero always finds us and defeats us in places like these!",
				"AND THE HERO \nIS ALREADY HERE! \nFREEZE!"	
			)
		},
		{ //20
			"4132",
			
			new SpeechSet (
				"<GROAN>",
				"Look at \nthe bright side!",
				"THERE IS \nNO BRIGHT SIDE!",
				"Even the blind \nsee a bright side."	
			)
		},
		{ //21
			"4213",
			
			new SpeechSet (
				"I told you to stay off the case!",
				"You've been made, you idiot!",
				"It's too late, Fernando.",
				"We'll kill you both now."	
			)
		},
		{ //22
			"4231",
			
			new SpeechSet (
				"You slept with my wife?!",
				"It was for the mission, you idiot!",
				"I ought to shoot you right now!",
				"Mission or not, you shouldn't have done it!"	
			)
		},
		{ //23
			"4312",
			
			new SpeechSet (
				"Don't you get it?\nThe chief is on their payroll!",
				"Took you two \nlong enough \nto figure it out.",
				"Any last words \nfrom Manila's finest?",
				"Let's pretend \nto fight \nas a distraction!"	
			)
		},
		{ //24
			"4321",
			
			new SpeechSet (
				"You still have \na lot of rice \nto eat, boy.",
				"Freeze, both of you!",
				"Stay out of this, captain!",
				"He's mine!"	
			)
		},
		
	};

	// public Dictionary<PanelOrder, SpeechSet> comics = new Dictionary<PanelOrder, SpeechSet>(){
	// 	{ //1
	// 		new PanelOrder(
	// 			1, //the view 
	// 			2, //the mouth
	// 			3, //the two-person shot
	// 			4 //the closed eye
	// 		),
			
	// 		new SpeechSet (
	// 			"Look at that view.",
	// 			"I'm hungry.",
	// 			"We literally just ate a horse.",
	// 			"It was a unicorn, you dolt."	
	// 		)
	// 	},
	// 	{ //2
	// 		new PanelOrder(
	// 			1, 2, 4, 3
	// 		),
			
	// 		new SpeechSet (
	// 			"Whoa, is that the sun?",
	// 			"I haven't seen it since yesterday",
	// 			"...",
	// 			"You lost my shades."	
	// 		)
	// 	},
	// 	{ //3
	// 		new PanelOrder(
	// 			1, 3, 4, 2
	// 		),
			
	// 		new SpeechSet (
	// 			"I'm not built for this weather.",
	// 			"You're not built for anything.",
	// 			"Not even love...",
	// 			"What did I do now?!"	
	// 		)
	// 	},
	// 	{ //4
	// 		new PanelOrder(
	// 			1, 3, 2, 4
	// 		),
			
	// 		new SpeechSet (
	// 			"Are we there yet?",
	// 			"Ask that again and I'll...",
	// 			"Kiss me?",
	// 			"Fat chance..."	
	// 		)
	// 	},
	// 	{ //5
	// 		new PanelOrder(
	// 			1, 4, 3, 2
	// 		),
			
	// 		new SpeechSet (
	// 			"Where the hell are we?",
	// 			"You said you knew...",
	// 			"I told you to steal that map!",
	// 			"Mouths don't steal, we lie."	
	// 		)
	// 	},
	// 	{ //6
	// 		new PanelOrder(
	// 			1, 4, 2, 3
	// 		),
			
	// 		new SpeechSet (
	// 			"Ah! What a day!",
	// 			"Thank you for kidnapping me.",
	// 			"Of course, honey.",
	// 			"Don't call me that."	
	// 		)
	// 	},
	// 	{ //7
	// 		new PanelOrder(
	// 			2, 1, 3, 4
	// 		),
			
	// 		new SpeechSet (
	// 			"I think we're in trouble.",
	// 			"I have no idea where we are.",
	// 			"What did you say?",
	// 			"I trusted you..."	
	// 		)
	// 	},
	// 	{ //8
	// 		new PanelOrder(
	// 			2, 1, 4, 3
	// 		),
			
	// 		new SpeechSet (
	// 			"<BURP>",
	// 			"You think they heard me?",
	// 			"Don't know, but I smelled it.",
	// 			"Do you even floss?"	
	// 		)
	// 	},
	// 	{ //9
	// 		new PanelOrder(
	// 			2, 3, 1, 4
	// 		),
			
	// 		new SpeechSet (
	// 			"Wait so you didn't like Metal Gear?",
	// 			"The story is stupid.",
	// 			"IT'S THE BEST THING EVER!!!",
	// 			"Kojima fanboy."	
	// 		)
	// 	},
	// 	{ //10
	// 		new PanelOrder(
	// 			2, 3, 4, 1
	// 		),
			
	// 		new SpeechSet (
	// 			"Do I have anything in my teeth?",
	// 			"Nope.",
	// 			"...",
	// 			"I want some ramen."	
	// 		)
	// 	},
	// 	{ //11
	// 		new PanelOrder(
	// 			2, 4, 1, 3
	// 		),
			
	// 		new SpeechSet (
	// 			"You should smile more often.",
	// 			"I'm always smiling.",
	// 			"The sun says you're lying.",
	// 			"Eat sand, you loudmouth."	
	// 		)
	// 	},
	// 	{ //12
	// 		new PanelOrder(
	// 			2, 4, 3, 1
	// 		),
			
	// 		new SpeechSet (
	// 			"What did she tell you?",
	// 			"The prophecy will be fulfilled...",
	// 			"and you're an asshole.",
	// 			"Some things never change."	
	// 		)
	// 	},
	// 	{ //13
	// 		new PanelOrder(
	// 			3, 1, 2, 4
	// 		),
			
	// 		new SpeechSet (
	// 			"Why is brown not dark red?",
	// 			"It sort of is, right?",
	// 			"Check the RGB values.",
	// 			"But the world is black and white..."	
	// 		)
	// 	},
	// 	{ //14
	// 		new PanelOrder(
	// 			3, 1, 4, 2
	// 		),
			
	// 		new SpeechSet (
	// 			"Mouth, we have to find Nose first.",
	// 			"They're probably in that direction.",
	// 			"I hope so.",
	// 			"I nose so."	
	// 		)
	// 	},
	// 	{ //15
	// 		new PanelOrder(
	// 			3, 2, 1, 4
	// 		),
			
	// 		new SpeechSet (
	// 			"Did you take a bath this morning?",
	// 			"Uh, no... why?",
	// 			"Who cares about hygiene out here?",
	// 			"I do."	
	// 		)
	// 	},
	// 	{ //16
	// 		new PanelOrder(
	// 			3, 2, 4, 1
	// 		),
			
	// 		new SpeechSet (
	// 			"Can you take a photo of me?",
	// 			"NOW?!",
	// 			"Why not.",
	// 			"WE'RE LOST!"	
	// 		)
	// 	},
	// 	{ //17
	// 		new PanelOrder(
	// 			3, 4, 1, 2
	// 		),
			
	// 		new SpeechSet (
	// 			"How old are you again?",
	// 			"Please be 18.",
	// 			"What is age but a number?",
	// 			"I'm old enough to drink."	
	// 		)
	// 	},
	// 	{ //18
	// 		new PanelOrder(
	// 			3, 4, 2, 1
	// 		),
			
	// 		new SpeechSet (
	// 			"You left the rocket fuel at home?",
	// 			"We can't get off-planet...",
	// 			"We can...",
	// 			"If you leave me here."	
	// 		)
	// 	},
	// 	{ //19
	// 		new PanelOrder(
	// 			4, 1, 2, 3
	// 		),
			
	// 		new SpeechSet (
	// 			"I can't look...",
	// 			"Trust me, it's a great view.",
	// 			"... If I could see that is...",
	// 			"You can't see?"	
	// 		)
	// 	},
	// 	{ //20
	// 		new PanelOrder(
	// 			4, 1, 3, 2
	// 		),
			
	// 		new SpeechSet (
	// 			"<GROAN>",
	// 			"Look at the bright side!",
	// 			"THERE IS NO BRIGHT SIDE!",
	// 			"Even the blind see a bright side."	
	// 		)
	// 	},
	// 	{ //21
	// 		new PanelOrder(
	// 			4, 2, 1, 3
	// 		),
			
	// 		new SpeechSet (
	// 			"Something's in my eye...",
	// 			"Which eye?",
	// 			"I can't be sure with all this sun...",
	// 			"..."	
	// 		)
	// 	},
	// 	{ //22
	// 		new PanelOrder(
	// 			4, 2, 3, 1
	// 		),
			
	// 		new SpeechSet (
	// 			"Zzz",
	// 			"WAKE UP!",
	// 			"Why must you shout?",
	// 			"You'll miss the view!"	
	// 		)
	// 	},
	// 	{ //23
	// 		new PanelOrder(
	// 			4, 3, 1, 2
	// 		),
			
	// 		new SpeechSet (
	// 			"Shhh",
	// 			"I need to meditate.",
	// 			"We have to keep moving!",
	// 			"They are near."	
	// 		)
	// 	},
	// 	{ //24
	// 		new PanelOrder(
	// 			4, 3, 2, 1
	// 		),
			
	// 		new SpeechSet (
	// 			"Eat shit.",
	// 			"I'm just kidding.",
	// 			"Were you, now?",
	// 			"Let's ask the horizon!"	
	// 		)
	// 	},
		
	// };
}

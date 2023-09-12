﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace explorestl.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Entities",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.InsertData(
                table: "Entities",
                columns: new[] { "Id", "City", "Description", "Name", "State", "Type" },
                values: new object[,]
                {
                    { new Guid("0006a6b1-b388-4bbc-b8d4-7d95b38f18d4"), "Mesa Verde", "This area is an ancient ruin of the Anasazi Indians. Several ghosts walking among the ruins. Very little is known about this specific ruin. Just standing inside the ruins one can feel the spirits.", "Balcony House", "CO", "Ghost" },
                    { new Guid("0044c8f7-8175-40fd-b41d-7f5e19db552e"), "Memphis", "when you walk up to the church night or day there is nothing there but as you drive past the church you see flames in the back window. This place could be haunted by and evil spirit this will only happen at night during the day you can not see the flames", "Fire Church", "TN", "Ghost" },
                    { new Guid("007abd1d-1acb-433c-81dd-0c475950be75"), "Providence", "On the bottom floor in one the rooms closer to the front  a ghost dressed in old clothes from approx the late 1700's with a triangle shaped hat. Weathered  leathery looking face. Dressed as a farmer not military. Stands in face and mumbles no words could be made out.", "Fairfield Inn", "RI", "Ghost" },
                    { new Guid("00c83289-0063-41a4-bc3f-1e5d4a2fcedc"), "Anson", "Illuminated sphere moving very fast overhead in a straight line of travel from horizon to horizon. Object seemed close and possibly hal", "Sphere", "ME", "Alien" },
                    { new Guid("01437f51-7ccb-4a69-9d5a-baa93e9942e2"), "Ouray", "On a woman’s wedding night she was brutally murdered by her new husband. So now she walks on every quarter of the moon at 2:15 a.m. all over the house in search of her husband. and on the anniversary of her death you can see her being killed  but you can’t ever see her husband just her  like she is dieing by herself. her husband stabs her twice in the chest and once in the leg. he then drug her down the service flight of stairs  where he proceeded to drag through the hallway and then hung her in a door frame  so don’t ever go on the third floor by yourself.", "Beaumont Hotel", "CO", "Ghost" },
                    { new Guid("017469ee-d7d1-4211-8c6e-3bf4a55b5bea"), "Vinita", "I saw a bright cigar shaped object hover in the sky  then speed off away from me at a very high rate of speed.", "Cigar Shape", "OK", "Alien" },
                    { new Guid("018ee894-de65-4d61-804a-0730afd67155"), "Point Pleasant", "\"A monster or demon known as \"\"the Bird-Man\"\" or \"\"the Moth-Man\"\" has been spotted at various times by numerous people in this small town  usually in the vicinity of a former TNT dump along the Ohio River  once maintained by the federal government.  It has also been seen along roads around Point Pleasant.  It is described as a man with large wings; some witnesses have also said that it had horns and a tail  and big vicious teeth.  Strangely  it is usually sighted several times in rapid succession  then followed by some sort of catastrophe.  For example  it was sighted before devastating floods  and before the collapse of a traffic-laden bridge crossing the Ohio River.  Some say the creature is the manifestation of a curse placed on the town by a Native American chief who was tortured to death in Point Pleasant by British troops during the French and Indian War.\"", "Former munitions dump", "WV", "Ghost" },
                    { new Guid("020536ad-323a-417a-af67-d6410ff19c52"), "West Point", "Legend has it that a conductor was walking down the tracks holding a lantern when a train passed by. A chain was hanging off of the train and t decapitated the man. Supposedly you can see the lantern swinging back and forth going up and down the tracks searching for his head. Also  if you look up in the trees  you can see a white light hiding in the trees. I've seen a black figure on the side of the tracks that comes toward the car from the left and it will cross the tracks and you can see it go toward to the other end of town. Sometimes the thing will follow you to Churchville road and ten turn around. There has also been a sighting of the old day train cars that took 2 people to move. The cars that look like they have a seesaw  which moves the train car.", "Railroad tracks", "VA", "Ghost" },
                    { new Guid("02203c32-6b42-4785-b372-25c04972156c"), "The following sighting occurred at Argyle Lake State Park", "\"When the sighting happened we had come down into a bottom near a stream.  The main thing we first noticed was that the entire woods had gone silent.  Before we had heard bird calls and insects throughout the woods.  The silence was really unsettling and we felt like we were being watched.  We got a little unnerved and began to walk quicker towards where we had parked the car.  As we walked the road back we could hear something about 20-30 feet behind and off to the side of us moving through the brush and undergrowth.  Then at one point we had a rather nasty smell blow through the area  similar to a skunk or fox when they musk or spray.  At one point we know it crossed the road behind us and rather quickly because the noises changed which side of the road they were coming from.  At one point we were certain it was going to walk out into the open right in front of us but then all the sound stopped for a short period of time until we went down the next hill.  When we got ready to go around the last bend to where we had parked I took a look back and saw \"\"something\"\" squatting on a point next to a dead blackened tree which stood  around three to four feet tall.  The top of it came to right around the top of the dead tree and it was fairly wide.  The only thing I could misidentify it as was a black bear and they haven't been seen in our area for well over 50-100 years.  I caught a quick glance at it and then turned back around told my friend I saw something and to just keep walking quickly straight ahead and for the car.  Once we got around the bend we ran for the car  jumped in and took off.  Since then we've never really talked about it.\"", "Report 40995: Possible sighting of animal playing peek-a-boo at Argyle Lake State Park.", "IL", "Bigfoot" },
                    { new Guid("02afc222-5290-48d3-80f5-30387a39ba10"), "Grandparents property.  Request location not be listed  but will gladly show area to a researcher.", "This incident involved hearing and smelling what my brothers and I can only describe as Bigfoot.  It happened on my Grandparents property when I was approx. 14 years old.  Our Grandparents had given all three of us 3-wheelers for Christmas the following year.  It had to be sometime between February and July of 1985 (Est. year  can not recall exact date).  My brothers (at the time ages 12 and 9)  were all on our 3-wheelers down by the creek behind my Grandparents home.  We had just gotten off of the ATV's and were going to cut through the woods to go up to my Grandmothers antique store  when we smelled something so putrid  it reminded us of sewage.  I remember telling my brothers that something really stank at about the time they smelled the odor.  Seconds later  we all heard a very loud  gutterral roar.  We froze in terror  looking at one another for what may have been only seconds  but seemed like several minutes.  Then we all raced up the hill to our Grandparents house  leaving our ATV's down by the creek.  We told our Grandparents and parents what we had smelled and heard  and we went back down to the creek with our Father and Grandfather  but could not find anything.  The odor was still in the air  and my Father and Grandfather could both smell it.  We took our ATV's back up to the house  and went home shortly after that.  That evening  it rained  and the next day  our eperience still racing in our minds  we went back to the creek to look for footprints.  We did not find any down there  but while riding on another section of the property  we found what appeared to be very large footprints  resembling a human foot  only much longer and wider and deeper.  The prints were located in a new driveway at the front of my Grandparents property.  The drive was made of black cinders  and the prints were very noticeable.  We returned to the house  and got a ruler and our Mom  who went with us to see the prints.  Frankly  she was amazed.  I imagine she was quite suprised to see actual prints  and if she had any doubts about the story we told the day before  they vanished when she took us to the local Jacks store to get Plaster of Paris to make plaster casts of the prints.  Unfortunately  the casts did not set up well in the black cinder  probably due to how hot the cinders got in the sun  and when we tried to remove the plaster casts  the casts crumbled.  We had measured the prints prior to the casting  and they measured 13 inches long by 8 inches wide by 2.5 inches deep.  My Grandpa  whom at the time weighed roughly 250 lbs.  could not even leave a print in the cinders.  We guessed that whatever made the tracks must have weighed around 400 to 600 lbs.  We never mentioned it to anyone outside the family  mostly because we were afraid of skepticism.  When one of my brothers  who is now 28 and a Deputy Sheriff  got hooked up to the internet recently  showed me your site  I decided to report our incident.", "Report 3049: Atv riders hear daytime vocalization and find tracks near Keokuk", "IA", "Bigfoot" },
                    { new Guid("030bc30f-2596-4a6e-97fc-94eebd21bafc"), "we were fishing on a sandy clearing just to the right of the floating dock at the Northshore boatramp EastFork Lake State Park", "while fishing early in the morning at Eastfork Lake near batavia ohio my nephew and I heard first an owl hooting a couple of times and I told Cody that I'd never heard one there before.It was around 3 am After a few more hoots all of a sudden a loud noise came from the woods.A noise that I've only heard in a jungle scene in a movie.The sound was of chimps in trees warning of danger present it was very strange.After about an hour had pasted we heard the owl noise again and then broke out in a loud low scream over and over we heard this scream.then it went into what sounded like dogs barking maybe a few dogs and then the barking went into yelping like they were being hurt.Then it stopped.We didn't hear anything again.Occasionally we'd hear the sound of a large rock being thrown into the water about 100 yards away.We left alittle later after all that went on.", "Report 26149: Fishermen experience possible early morning vocalizations and rock throwing at East Fork Lake", "OH", "Bigfoot" },
                    { new Guid("03414189-ae2b-4cb1-b6d3-6d3d833f1842"), "Fall River", "I observed two white lights above the highway  out of the ordinary in terms of size and distance apart.", "Circle", "MA", "Alien" },
                    { new Guid("034b1ff6-7e5e-473b-97ba-0e960e0055d6"), "North Adams", "warning - The tunnel is very active - not recommend the 4-mile trip  trains do come through. And it is monitored by the local Police. 186 men were killed in a nitro blast that was unexpected. Built in the 1800s this tunnel holds a bit of a story on being haunted. Reports of seeing a lantern.", "The Hoosac Tunnel", "MA", "Ghost" },
                    { new Guid("03b23a09-2aee-40ec-8ac8-f025290e1fc7"), "Witness requested location be kept confidential.", "These incidents have occurred over a period of approximately 7 years. The occurrences have not been limited to a particular time of year. I have never  nor has any in our group  sighted a creature. Most have experienced hearing knocks  LOUD branch breaks  hearing bi-pedal footsteps emanating from a creature much larger than a human would make  smelled noxious odors  and had that inexplicable feeling of being watched. The place is a cabin which has been in my son-in-law’s family for 4 generations. It is located on the edge of the Allegheny National Forest  off the summit of a mountain. Across the lane from the cabin is a large meadow  belonging to a local doctor. This is sometimes planted in grain crops  other times allowed to remain fallow. There are other cabins scattered along the lane; none within eye-sight of the other. My first trip was in October of 2006. There was no other activity at the other camps. My son-in-law (Eric) and I arrived about 8-8:30 at night in the darkness. Upon exiting the Jeep  I had an immediate feeling of being watched. I have spent a good deal of time in the woods  hunting  fishing  and hiking. I am not easily spooked.  After dinner  cleaning up  and sitting up a bit talking we turned in about midnight. Around 2 A.M. I was awakened by the sound of the old wooden table and chairs being pushed about on the deck. We determined it must be a bear  and went back to sleep. Approximately 2 hours later we heard something rustling about the fire pit. We did NOT cook any food outdoors  we brought in all our empty bottles and such when we came in to discourage bears and other critters. In the morning  we found the table and chairs had been moved about  which a bear or even a large raccoon could have done. However  the fire pit had been scattered about  some of the smoldering logs rolled aside. Another time  we were hunting in the forest behind the cabin. The topography is typical Appalachian mountain; rugged  steep slopes  ravines  small streams and bogs. Here and there are small oil seeps as well. We had just descended into a fairly open area which promised grouse. This was early November  crisp but not cold. We were each carrying shotguns loaded with upland game shells. We were walking approximately 50 yards apart when we stopped  looked at one another and asked “What is that smell?” From out of no-where came the most putrid  overpowering smell. It was not the oil-seeps  which have their own sulfur like smell. This was horrid! It was like a skunk on steroids  with a good measure of open septic tank  and some rotten garbage added for good measure.  We continued on our way  the smell dissipated after about 100 feet.  We tried to tell one another it was a dead deer or something; but we both knew better. I worked in a funeral home while in college; and have never experienced anything that nauseating.   We also had an unnerving feeling of being watched the entire time we were there. Upon relating the above to my daughter  Eric’s wife  she stated she has smelled awful odors for no apparent reason as well and felt like she was being watched several times. We have heard howls  far in the distance  and others within a quarter mile  or so of the cabin. There are coyotes in the area  yet these are much longer in duration  and have more range. Some start low  and rise toward nearly a falsetto pitch. Others have been more monotone yet will waver somewhat. Others will start low  and culminate in a scream. This is not a bob-cat  not a coyote  and all members of our party are accounted for. In March of 2014  a group of us went for Spring Opening. There were 5 of us there. As darkness set in  I decided to venture out to the open meadow to observe the Winter constellations. This is about 100 yards from the cabin. The cabin is situated on the downward slope from the summit  which is the meadow. The area behind and on both sides of the cabin is a fairly steep slope. It is heavily grown with second growth trees  brush  and scrub. There are also a lot of blow-down branches which makes walking even in daylight difficult. At night  it is an invitation for a sprained ankle at best. As I was observing the stars and enjoying the silence  I heard footsteps. Not in the trail  not in the meadow  but coming UP the slope to the south of the cabin. My initial thought was a bear. As I listened  it was apparent the foot falls were from a biped. I called out if it was any of our group and received no reply. Then the steps would start again. I called again  louder  and the steps stopped for a moment.  Then  they began again  finally stopping by the edge of the lane. There were no lights showing  the moon was in the final phase of its final quarter  and just a sliver. I started to return to the cabin. I was about 20 yards from where I heard the steps stop along the edge of the lane. As I drew parallel to that area  I heard shuffling of the underbrush  as if whatever it was had turned it’s entire body sideways to watch me pass. When I entered the cabin  everyone was where I had left them. There were no new leafs  mud or debris in the doorway. When I asked if they heard anything  they all said no  as they were watching Planes  Trains and Automobiles on VHS. Finally  this past Spring  a group of us went up for a weekend. While sitting about the rear deck  enjoying a fire and talking  a member of our party was encouraged to do their howl. They did. Then about 30 seconds later  the sound of a very large tree limb snapping came from down the slope behind the cabin. Could it have been a bear stepping on a branch? Perhaps  but that would be very coincidental to step on a limb just after a howl. I KNOW there is something in those mountains. I can’t prove it physically; it one of those things that you know that you know. Please keep this location undisclosed. We would hate to see a bunch of people go hunting for these creatures. They don’t deserve to be pursued and bothered. I have been needing to share this with someone who won't think I am off my rocker. Thank you.", "Report 49903: Several possible incidents over the years in the Allegheny National Forest", "PA", "Bigfoot" },
                    { new Guid("03d35449-9ba7-426c-a3eb-5ab149cc5a8b"), "Fort Worth", "I saw what I thought was a bright star outside my apartment. That thing followed me in my work truck staying on my side of the truc", "Circle", "TX", "Alien" },
                    { new Guid("03f158d6-5717-48ec-877d-f438be4e9496"), "Lafayette", "Walking my dog looked up and saw what I thought was a balloon floating by but as I watched it I noticed it zoomed back and forth.", "Star Shape", "LA", "Alien" },
                    { new Guid("041658c4-e838-49a5-8112-e7ab1fc73f59"), "Willow", "Bright ball of light", "Circle", "AK", "Alien" },
                    { new Guid("042f1013-ba22-4e74-8aea-2bee3c2769f1"), "Medora", "One of the rooms on the top floor is said to be haunted by a young boy. You can hear a child's laughter  the toilets flush when there is nobody in the room.", "The Rough Rider Hotel", "ND", "Ghost" },
                    { new Guid("051a90c0-2c1b-49a2-b57c-a480de0cdfd8"), "Brentwood", "I saw three lights forming a V shape in the night sky about 300 feet in the air. There was no noise and they were moving slowly in an e", "Formation", "CA", "Alien" },
                    { new Guid("053e8509-f1c8-4cf4-a557-20afdc5123de"), "El Paso", "Reports of six students which went to the place at night and heart footsteps in back of them and herd someone screaming on the dark hall.", "Henderson Middle School", "TX", "Ghost" },
                    { new Guid("0563c1ab-69d3-4bcf-8009-d825121c758f"), "Norwalk", "While walking home  over the I-95 Yankee doodle bridge a witness saw a grayish white mist with a woman’s face travel across the highway off ramp through the woods in to the cemetery.", "Cemetery behind Mathews Mansion", "CT", "Ghost" },
                    { new Guid("05972b8e-34d0-41b1-8fea-3d1c2abf98a7"), "go north on 208 from 80 pass newmansvill and take a right. next right turn right and drivr into the Allegheny National Forest. first left on paved road  turns to dirt and dirve two miles.", "While fore of us were exploring an abandond farm house heard one loud roar that was so loud it echoed. the sound lasted about ten seconds and only happed once. it came from a tree line in a field at least 3oo yards from where we stood. we stoped turned around and got into our car and drove away.", "Report 6836: Early afternoon vocalization heard by four people", "PA", "Bigfoot" },
                    { new Guid("06086f1a-4258-40d5-94c6-de1915b203c3"), "3 mi. from Lavalette  WV an unincorporated area.", "\"To start off I've been interested in cryptozoology since i was about twelve years old. I was about fourteen yrs. old and living on Mt. union rd. at the time. It was about 9:00pm on a fall night. My cousin and I were sitting on the hill next to our storage building smoking a cigarette and looking down into the holler next to the road. All of a sudden we heard something move down over the hill so I whispered \"\"shush  if we’re quiet we may see a deer.\"\" We continued to sit there  about 2 min  until a car came down the hill and its lights flashed on something tall standing near the bottom. It turns to its side quickly then looks up the hill towards us. After the car had passed it was dark again and he heard something huff and puff and then it sounded like it took off up the hill running towards us so we ran to the house about 30 yards away. We ran inside the house and never heard anything the rest of the night.\"", "Report 28382: Possible activity outside a residence near Lavalette", "WV", "Bigfoot" },
                    { new Guid("06141bc3-e9f7-4bde-825b-f9245af36b3c"), "Conroe", "There was a very dim light moving extremely fast while star gazing. It headed north east and shot up fast shortly after leaving my view", "Light", "TX", "Alien" },
                    { new Guid("066b892c-1707-4db2-b1fc-70c5dce7a1d2"), "Glendale", "A large shadow moved over the house. It literally darkened the inside was well  passed across and the power went out for a few seconds", "Chevron Shape", "AZ", "Alien" },
                    { new Guid("071a9037-cde1-4b0f-bbc6-75e9d8c484b4"), "Kitty Hawk", "I actually took a photo of the crescent moon and didn’t notice the ufo until later", "Oval", "NC", "Alien" },
                    { new Guid("07f99d60-1a11-4e24-938f-0c393b897ab0"), "Sebastian", "William O. Darby Jr. High School - The staircase in the old part of the building between the third and second floor is haunted by a student that choked to death in the 1960's or 70's. Also  the attic is haunted by a janitor that had a heart attack while peeking through the peephole  watching the cheerleaders. They say you can hear him call out from the balcony of the auditorium  if you are in there alone. Also  the practice field was once a cemetery  and it was stated that even though all remains have been removed  that some of the unmarked graves still remain. On foggy nights  you can see these ghostly figures  looking for the other graves that were marked.", "Fort Smith", "AR", "Ghost" },
                    { new Guid("08a7c582-d3d6-41bc-982c-adc4736f357b"), "Cedarville / Fairton", "many strange thing have been reported here such as ghostly faces on head stones  organ music hear coming from the church late in the morning hours with no electrical sources going to the building. by rs2", "the old stone church", "NJ", "Ghost" },
                    { new Guid("08dba54a-a00f-4157-ac10-980045ba6c5b"), "Union Mills", "on the way into Hana.  On the railroad tracks on 600 w. Around 2:30-3:30 a.m. There has been a blue-tinted shadowy figure  that looks as if is carrying a lantern  walking on the railroad tracks into Hana.....In 1987  a man was coming home from work at est. 3:00 a.m. and was hit by a train........", "Old U.S. 30", "IN", "Ghost" },
                    { new Guid("0912ebb4-37c0-4f19-9f12-bdc92486a647"), "Hammond", "People say there are 2 women owners who died there and they haunt the place. You can hear people walking around upstairs if no one is there. There have also been sightings seen in the forest behind the mansion. People have seen 2 unknown women working in the background. This usually happens when they are setting up for Reaper's Realm.", "Old Botanical Gardens/Reaper's Realm", "IN", "Ghost" },
                    { new Guid("091a466a-cd42-427b-840d-8b18fc5e2af0"), "Leo", "During a severe thunderstorm a single light appeared moving unevenly (up and down) from east to west.", "Light", "IN", "Alien" },
                    { new Guid("0952d8dc-1b7d-4147-9cb9-0d0d938dbb37"), "Alliance", "\"Believed to be haunted by a female ghost some call \"\"Mary\"\". Mary was an excellent actress  she performed every act with skill. But for one show it was curtain time for the last time. Mary was playing in a love story  she played as the bride. It was near a happy ending for the performance  or so they thought. She walked up to the stage when tragedy struck. One of the light fixtures fell on top of Mary. The angel of death has claimed a victim. She died of the immense weight and electric shock. To this day  after hours  he spirit roams the stage waiting for the applause of her fans. But sadly no one is there.\"", "The Alliance Theater", "NE", "Ghost" },
                    { new Guid("096753ac-b359-4e8d-ad22-5f80ebdb72de"), "Lake Ridge Drive  Sumner", "With friend Scott Piveral  at about 7:30 AM on way to school  saw two white creatures that smelled like skunks  just standing at edge of woods on a hill  they then meanered back into woods. The creatures stood under a treelimb later measured as being 15' high and so could estimate that they were half that height. They made out that they were human like in basic shape. In the area they found 3 nests. They were on a slight hill with a flat spot. The upper hill side had 12' brush that was bent and broken over the flat area  leaving a 6' H x 8' W area beneath.", "Report 1730: Lake Tapps", "WA", "Bigfoot" },
                    { new Guid("096bc17e-3d02-4a4a-aade-165e3c563fbe"), "Westminster", "Various sightings of a woman in green colonial dress. Pictures jumping off of walls  objects falling from the back of shelves  ghostly voices and more.", "Cockeys Tavern", "MD", "Ghost" },
                    { new Guid("09b9bcd6-8293-4d8d-8bdc-d604f7acfeb8"), "Gales Creek", "\"Agaard road is on the right side of highway 6 heading to Tillamook from forest grove. between the times of 2 am and 5 am on most mornings a man named Lazlo in flannel fishing wear can be seen where the creek runs under the road. he fishes and smokes his pipe and doesn't harm anyone. just sits there. across the road his wife Helen waits for him with hands on hips and an annoyed expression on her face. during this time smoke is sometimes seen rising from the house in which the couple used to live. lights can also be seen in the windows. the electricity in the hose has been turned off since the late 90's. Also the apparition of a young boy in blue shorts and a striped t-shirt can be spotted on the highway side bank of the creek. he is blue in the face and has water dripping from him (the water never makes spots on the rocks). he has been named Joey. he is usually seen in the late summer in mid- afternoon by the swimming hole. he whimpers and cries for his \"\"mommy and daddy\"\" sometimes Joey is only heard calling for his parents. when someone tries to follow hi he leads you up the side of the bank and disappears before the highway.\"", "Agaard Road", "OR", "Ghost" },
                    { new Guid("09c09121-7f54-4772-862a-7d694cad2476"), "McDonald-Dunn State forest  west on 99 north of Corvallis  near Peavy Arboretum.", "\"While on a hike during this nice sunny day  I heard a low grumbling sound. My husband was leading me along the trail and he did not hear this sound. I stopped him and described the sound to him as a sort of \"\"wild boar\"\" type sound. It was VERY hard to describe. The sound was low  deep  like a vibrating growl or snort. We looked around and listened. When we didn't hear anything for quite a few minutes  we began walking again. Not more than 3 or 4 steps down the trail we hear a rustle noise and I quickly turned to see a rock or something rather large  dark and round fall to the ground with a large THUMP! The item had landed just where I was standing only a moment before. My husband heard this large item hit the ground and we stood stunned for a moment trying to figure out where it came from. I looked around the area and found a rock about the size of a baseball sitting where the item had hit the ground. My husband and I could NOT figure out where it had come from. Was a rock in the tree and it just now fell? Did something throw that rock at us? We were a bit jumpy but kept on down the trail. About 1/4 mile along the trail we hear a loud \"\"whomp  whomp\"\" like wood against wood sound ahead of us up on the hill. I asked my husband what that was and he decided it was probably just some people doing work on the trail. I didn't believe that's what it was. It sounded too heavy to be man made. Maybe machinery  but there was no motor sound and it was a Sunday evening. I doubt workers were on duty at this time and on this day. Just then we heard the sound move and we turned to hear the same wood on wood \"\"whomp\"\" noise behind us on the trail and still above us on the hill. My husband remarked  \"\"If that was bigfoot I don't know how he moved that quickly!\"\" I told him that we could rule out trail workers and that it was quite possible that it was TWO bigfoot communicating with each other. We joked about it  but we were both very shaken. We just could not come up with a more reasonable explanation for this sound. My husband describes this sound as a person hitting a tree quite hard with a large log. After yet another few minutes of looking around and hoping to see something  we walked along the trail without answers. After this we heard nothing more and came across several hikers on the last mile of the trail. Several hikers had dogs and we didn't hear any dogs going wild barking at anything unusual. My husband and I were going to stop some hikers to ask if they had heard anything  but we didn't want to look crazy or scare them away from the trail. Other than the rock being thrown at us we didn't feel as though we were in any kind of danger. When I got home I called my father who is quite familiar with forest animals and noises. He couldn't explain where the rock would have come from  but he believes that the wood on wood sound could possibly be deer or elk. I doubt that it was deer or elk just because the trail was so populated. They would have been spooked by the hikers and the dogs... besides  the \"\"whomp\"\" sound was SO heavy and SO loud that I can't imagine a deer making such a large sound. We didn't smell anything  we didn't see footprints...but I can't think of anything else that would explain these noises and the rock being thrown at us. I just really feel as though it could have been \"\"Bigfoot\"\".\"", "Report 10928: Hikers hear growl  wood  knocking  have rock thrown at them.", "OR", "Bigfoot" },
                    { new Guid("09cc4d4c-df80-4505-a53b-07c6bab44aef"), "Pace", "A strange light was seen around a cell tower just east of Wal Mart behind Chic Filet. Strange lights have been reported.", "Just east of Wal Mart", "FL", "Ghost" },
                    { new Guid("0a00c710-f701-445c-abcc-c70147a48f0d"), "Hwy 88 to Blue Lakes Rd.   I think.  Its been 17 years since I've been there.", "While walking cross-country  looking for possible home sites from the early 19th and late 18 hundreds  I was walking the base of a small ridge between two lakes Lower Blue and Twin Lake. On the ridge side it was mostly open forest on the Twin Lake side the brush got thicker. As I was walking I heard a loud two tone whistle [low to high pitch] that was not a bird or any animal I know. The sound came from ground level and behind me to my left. The whistle was loud and sounded in my opinion from a mammal. I turned and called out thinking a hunter [in a place he should not have been][no hunting zone] but no one answered  I whistled back but nothing called. Wondering what it was  I investigated the area 'till i could get no farther  the brush was too thick. I was standing within 10 feet from where the whistle came from  nothing in sight not in the trees on the ground not anywhere  no bird's where flying and no animals in sight either. It was a little spooky but at the time i was cross-country running almost 5 miles a day at 8000 feet as well as boxing training and being a good bow hunter nothing scared me at that time. I was 20 with a good outdoor understanding and other people were the only things that scared me. I remember after I got back to the cabin and asked my Dad what animal out there [if he knew] that whistled like us but much louder  he didn’t know of any. I did not think anything about bigfoot even though I was interested in the subject  I thought they were all up north in the Shasta and up area. I did not know that BF made whistling sounds until I went through the BFRO website.", "Report 7336: Runner Hears Unusual Whistle Near Woodsford", "CA", "Bigfoot" },
                    { new Guid("0a3027f2-436a-4c82-be8f-715e29bc6264"), "Port Townsend", "Has been removed by owner's request. there are no hauntings.", "Holly Hill House", "WA", "Ghost" },
                    { new Guid("0a351f31-ba06-4df4-8df8-51102db7d862"), "Oxford", "\"The Adina Indian Mound - This is very easy to get to all you need is a flash light because it does require a bit of walking. This Medina Indian mound is dated back to sometime in the BC’s there is a little plaque before you get to it that tells you the dates so you can find that out if you go check it. you might feel this strong sensation of being held back. Witnesses claim to have taken pictures from the top and had strange glowing figures  and ectomist. Go to the Heuston woods campground. You don't have to pay just go straight thru. its at the end of row b just park on the road. you have to walk through a big field but if you just go straight you'll run smack into it. The Adena Indians were \"\"Mound Builders\"\" of prehistoric time date estimating from approximately 1000 B.C.-700 A.D. along with the Hopewell Indians whose appearance is estimated at approximately 400 B.C. The name came from Adena  the Chillicothe  Ohio estate of Thomas Worthington  governor of Ohio from 1814-1818. (The Mound Builders by Robert Silverberg  Ohio University Press  Athens)\"", "Heuston Woods", "OH", "Ghost" },
                    { new Guid("0a35baa9-bff0-4829-84a2-134def6183ac"), "Go down highway 5 north to Connie dr just at the outskirts of town.", "While driving to check on my dogs that were being kept at my aunts house in a fenced in area with a ten by ten out building. An adolescent bigfoot ran out of the woods and into my aunts yard it ran between the house and the garage. It was approximately three and a half to four foot tall. I pulled in to the drive but was to afraid to get out of the car had the feeling that something was watching me from the woods. The dogs were yapping but ok so I left because I was afraid.", "Report 1637: Backyard sighting near Mountain Home.", "AR", "Bigfoot" },
                    { new Guid("0a3bea6d-506f-46f7-b82a-4e611c74df0b"), "Cave Spring", "\"In downtown Cave Spring Ga. there is an old school for the Deaf which has buildings that were used during the Civil War. One of there buildings is a former infirmary. There are still bloodstains on the walls and floor and footsteps and crying can be heard. A physic was hired to investigate the building but refused to enter when she arrived because she said \"\"There were to many evil spirits present\"\". There is also a ghost of a lady that can be seen wandering through the vast fields of kudzu around the campus. People report having seen her usually after they see herds of deer standing and then running away.\"", "Old School for the Deaf", "GA", "Ghost" },
                    { new Guid("0ac7b6ad-afc3-46ba-9716-aca4d294d7aa"), "Sherman oaks", "Several triangle shaped objects soaring into different flight formations.", "Formation", "CA", "Alien" },
                    { new Guid("0ac9f3c8-16f1-4cfa-aaf6-269e3e3bfec1"), "Jefferson City", "Jefferson Inn is what it was last called  but now it is the home of Lisa Sczcesny and Scott Arnold. I have stayed there myself and the place is very haunted. Built during the Civil War it was called the colonial hotel. Many deaths have occurred there. One man is said to have shot his self in the kitchen  another was pushed down the stairs by his wife and killed. a slave hung herself in the basement. Sometimes at night you can hear a woman screaming on the stairs and shutters opening and closing. And once and a while you see images in mirrors and guns going off.", "Jefferson City Inn", "TN", "Ghost" },
                    { new Guid("0aee7704-49d4-45cb-b9db-d1073a4ead6f"), "Mandaree", "Some say that in the girls locker room you can hear voices and see people. Also basketballs bouncing around in the gym  people walking around  voices and other odd things. Plus all around Mandaree it is haunted with witches  spirits and little people.", "Mandaree Public School", "ND", "Ghost" },
                    { new Guid("0b1c00b9-ae92-4c10-9169-81941fe45d46"), "Pensacola", "This is a large cemetery that was started when Pensacola was settled. This cemetery contains famous people and people that helped to shape Florida in history  politics  and commerce. People say they have seen lights circling gravestones. They have also heard voices inside the cemetery at night.", "St. Michael’s Cemetery", "FL", "Ghost" },
                    { new Guid("0b47d38a-8da7-4127-863c-bd01f8f880d9"), "Myrtle Beach", "Green object hovers then rapidly changes elevation and direction.", "Cigar Shape", "SC", "Alien" },
                    { new Guid("0bab6451-b303-4a90-92bb-c5d18d3c4920"), "Kingman", "About two or three miles southeast of downtown Kingman  there is a place known as Launa's Canyon. This is how the story starts goes: During the 1800s  a soon to be family of four(husband  wife(Launa)  and husband’s two daughters)  traveled out to (Old Town) Kingman to search for gold. In time  the family soon built a large house near a deep  narrow canyon. The man's daughters despised the young  soon-to-be mother and wife  for the way she had treated them. Launa wanted their father all to herself. So on the night before her wedding  in order for her to get their father  Launa murdered the two young girls. She hid the murdered children in the house. When she regained her sanity later that night  she came back screaming and moaning through the canyon  begging for forgiveness for the sickening killings. To this day  it is said that you can still hear Launa's moaning throughout the c anyons during the hours of 12:00AM – 3AM.", "Launa's Canyon", "AZ", "Ghost" },
                    { new Guid("0badc05d-dbcc-4e0d-be87-a72653df8cdc"), "N. Adams", "throughout the construction of the Hoosac Tunnel  nearly 200 workers died. it is said that the tunnel is haunted by many of these souls. there was even an alleged murder that took place  and the ghosts of the victims are said to also haunt the tunnel.", "Hoosac Tunnel", "MA", "Ghost" },
                    { new Guid("0bbdd4f1-43bf-454e-ac45-8befa5948d81"), "Jericho", "Greenish pulse of light caught my attention. I captured one minute of video.", "Unknown Shape", "VT", "Alien" },
                    { new Guid("0bce51ad-9ec4-4f77-b2c5-d07e46884e53"), "Stillwater", "Three of us saw a high flying jet/airplane begin zig-zagging across the sky for about 30 seconds.", "Light", "OK", "Alien" },
                    { new Guid("0be2608f-d71b-4cb1-8466-159345315cf5"), "Edited out at witnesses request.", "This sighting had happened when me and my girlfriend were driving on one of the dirt trails off Route 72.  We had just gotten on the trail and I wanted to stop for a second.  After being stopped for a few minutes  I looked up and noticed my girlfriend looked like she had just seen a ghost.  She said that she just saw something tall and light brown walk across the road we were on.  So I said it was probably just a deer or something. I got out and looked around  and I saw some bushes moving and heard some rustling.  As soon as I turned my head I saw this face of an animal about 6 feet high looking straight at me through this big pile of brush.  The face itself was black but the hair was a dark sandy to light brown color.  It looked like the face of an ape.  The hair on the top of its head was somewhat long. After looking at it for a few seconds I shook my head to see if i had seen what I thought I had  while I was doing so the animal had run away.  I saw it running for a second but then I turned back  to my car and got in.  Once I was in I asked her what she thought she saw.  She said that it was the same thing she had seen when we went camping six months prior to this. We went camping near Tuckerton but we had taken a detour to Apple Pie Hill.  There is a ranger lookout tower there  so went to the top and she looked down and said what the hell is that.  I pointed my flashlight in the direction but didn't see anything.  She said she saw something running in front of the tower and it looked like the same thing she had seen. But once I had gotten back into my car I looked around for it again but didn't see it.  So I put my window down and started driving  I could hear something running toward my car so I stopped and turned off my car again.  I still heard something coming my way  it sounded like a human or something running on two feet as opposed to a animal on 4 feet galloping through the woods.  After a few minutes of listening she was getting nervous so I had turned around and headed home.", "Report 13515: Late afternoon sighting in the Pine Barrens", "NJ", "Bigfoot" },
                    { new Guid("0bfbdfba-6d42-425c-852b-ed1b9c5f02d4"), "This was taken near my property at our hunting camp. In Burnham Maine.", "It was a picture captured on a trail camera. I had never noticed it before until now. It appears to be hiding behind a small fur tree and shows no other signs of it self. I have just one picture but it is very clear and detailed. It appears to be younger.", "Report 51005: Trail camera captures unknown creature on hunting property near Burnham", "ME", "Bigfoot" },
                    { new Guid("0c36370e-6957-47b7-ad52-08efb6124f3f"), "Nightmute", "There is said that there is a little girl roaming and haunting the whole school. Staff members and students have seen and heard her. She would sometimes hum  appear in both the boys and girls bathrooms  turns lights off and on  and bounce a basketball. No one really knows how she died but it is said that there is a grave under the classroom 106  and she is mostly in that classroom.", "Nightmute High School", "AK", "Ghost" },
                    { new Guid("0cc865b7-9d52-479a-8089-1d435d8ae962"), "Bettendorf", "I saw a pair of strange lights in the early morning sky that disappeared in a strange fashion.", "Light", "IA", "Alien" },
                    { new Guid("0d040fee-87e3-4cd1-bd8c-78d346a41cae"), "United States  state of North Carolina in Stanly County between the towns of Oakboro and Aquadale.  On Old School Road off Hwy 138", "While driving down the road about 10:30 pm I saw something standing on the left side of the road where the road curves to the right.  I threw my headlights on bright and turned the wheel to the left and drove streight to it. I was sideways in  the road. As I neared it I stopped and I had a clear view of it.  It was so tall that I had to lean closer to the steering wheel to look up into its face.  I could see him (clearly a male) from just above his knees to the top of his head.  I looked streight into his eyes.  He seemed to be comunicating with me though his eyes.  He let me get a good look at him and then he gave a nod and I knew I was to go. He was at least 7ft tall or more with silver and black hair some of it at least 4 to 5 inches long and dark outdoors type skin (where it was exposed. His eyes resembled that of a dogs and were the color of a alaskain husky and wide flat nose and a wide thin mouth like a mans. He never opend his mouth. Just stood there and looked at me and blinked some and make jesters with his head and eyes. When he knodded at me I knew it was time to leave so I turned the steering wheel very slowly ( I felt dazed) and drove on down the road.  I estimated the time I set there about 15 to 20 mnutes.  I went home about 1/4 miles up the road.Then I trembled  was so excited I could hardly walk.  I never was afraid.", "Report 3337: Woman witnesses a 7 foot tall  silver-black sasquatch while driving", "NC", "Bigfoot" },
                    { new Guid("0d6effee-1fd4-42e2-93b6-e619083939ac"), "Westbrook", "Saw this orange globe and if he came see-through and turn colors and you can see the purple potion in the video", "Changing Shape", "CT", "Alien" },
                    { new Guid("0dc133b2-950a-48ba-905c-74a58806d893"), "Dahlonega", "I saw a large green fireball like object with a red tail or streak.", "Fireball", "GA", "Alien" },
                    { new Guid("0dcbe3bc-4e69-4a7c-a47d-4e5fb0146a82"), "This happened on the farm we manage just outside of Errol  NH. We are 2.2 miles past Errol  heading towards Colebrook  NH.", "Possible vocalizations on the 1400 acre farm we manage. This happened in the fall of 2014. I was outside on the deck and was listening to the coyotes out back. They were quite loud. I heard a howl like I have never heard before. I heard it 2 more times and then quiet. I have been out in the woods for most of my life. I have hunted extensively and never heard anything like this.", "Report 48403: Farmer hears possible nighttime vocalizations outside Errol", "NH", "Bigfoot" },
                    { new Guid("0e1af43e-72dd-4921-9692-a52a2b58db47"), "El Paso", "Many employees have reported seeing Indians and also a lady dressed in white. While opening the museum doors for the public one morning  we witnessed a very tall Indian man dressed like a chief staring at us from inside the exhibit hall  and then he disappeared instantly. The elevator sometimes goes up and down by itself and exhibits seem to turn off and on randomly by themselves  too. There is an eerie feeling of not being alone at night.", "Insights El Paso Science Museum", "TX", "Ghost" },
                    { new Guid("0e1d3317-c2b1-4dc9-98c7-75fbcb06de54"), "Amidon", "Not only a fine place to dine  Georgia's and the Owl is home to several paranormal activities.  A little boy has been reported to run around the restaurant  playing and bumping into people.  Occasionally  music and voices can be heard.  Potato chip bags clipped to a rack have been found strewn about the floor when the restaurant was opened for the day.  A local team of investigators has conducted extensive investigations here and has recorded some strange muttering voices.", "Georgia's and the Owl", "ND", "Ghost" },
                    { new Guid("0e35a887-227e-4175-91e8-79dac4438d01"), "Pickens", "It was once a jail in the early 1800s. Many people died there and they say you can see some ghostly figures and hear some moaning during the night.", "Pickens County Museum", "SC", "Ghost" },
                    { new Guid("0e6e4eae-8707-4604-b216-b66753e010fd"), "", "\"Our family was driving home from vacation last August when I saw something unusual in a cornfield. We were roughly 40-45 minutes north of Bethany Beach  Delaware traveling on Route 1 passing through farm country at the time.  We had rented a minivan and my husband was seated upfront driving with his Father next to him in the passenger's seat. They were busy talking.  My daughter and mother-in-law were seated in the row of seats behind them.  My mother-in-law was reading a book to my daughter at the time.  I was seated in the very last row of seats in the minivan and sat on the passenger's side of the car. As we were driving along and everyone else was busy either talking or reading  I was looking out the window at the passing countryside.  We were going through farm country at the time and as we drove past one corn field  something caught my eye.  The thing that initially got my attention was the fact that the corn stalks were now dried and yellow and it appeared that something dark brown was standing there in the middle of the corn stalks.  The roadway was slightly elevated above this particular field so I was essentially looking down onto the tops of cornstalks rather than them being level with the van. Having an interest in the subject of Bigfoot  I immediately went into observation mode and noted the following:  What I saw was medium to dark brown in color  it was taller than the cornstalks  it appeared to be about 3 feet wide and I may have been looking at a head and shoulders and it definitely wasn't a piece of farm equipment  a scarecrow or a human.  In fact  I noted that there were no humans around on the farm at the time.  I was able to observe this for roughly 5-10 seconds as our minivan drove past this large field.  The brown \"\"thing\"\" was roughly 300 feet in off the road in the cornfield by itself. I quickly tried to note the general location of where we were at the time.  I do not live in Delaware and was not familiar with the precise location.  However  not long after that  I spotted a sign for the Milton  Delaware exit off of Route 1.\"", "Report 28720: Traveler observes a tall biped in a cornfield north of Bethany Beach", "DE", "Bigfoot" },
                    { new Guid("0ebe9309-0316-44ac-a907-ebac5d5b38f3"), "", "This happened at Oubache State Park near Bluffton Indiana either the summer of 1989 or 1990. I was working as a night watchman at the front gate and had been watching television when I decided that I needed to get something out of my Ford Bronco. The area leading up to the park is heavily forested with trees that had been planted by the Civilian Conservation Corps during the Depression. The road leading into the park was about a third of a mile long. As I stepped outside the booth and was crossing the road to the parking lot  I heard the most terrifying scream that I have ever heard in my life about 250 yards to the southwest of my location. At the same time that I heard the scream I also heard a tree snap and break and fall to the ground. The tree sounded to be quite large. The weather that night was very calm and there was no wind at all which could account for this tree falling down. I quickly turned around and headed back for my booth and sat down to think about what just happened. I felt like I was in a daze for a few minutes as I was trying to think what a logical explaination of this event could be. I sat there for about 45 minutes and after I had settled down a bit  I decided that it must have been my imagination playing tricks on me and I proceeded to head back out to my truck. I was walking toward my truck and had gotten to the exact same spot that I was in previously when I heard the horrible scream when I heard it once again and this time it was about 50 yards away from my booth. I once again quickly retreated to my booth and sat there until daylight. Once day light arrived I walked out in the woods to investigate but found nothing out of the ordinary. I didn't walk far enough out to find the tree as I was still quite unsettled by what I heard. I have heard screech owls and bobcats but nothing  absoultely nothing  that compares to the sound that I heard that night. I can't say to this day what it might have been  but this has bothered me for about 16 years and I still think of it evey now and then. Reading about some of the other sighitngs that people have heard and the sounds that they said this creature made makes me think of my own experience and I wonder if I too actually had an encounter.", "Report 15926: Possible vocalization/intimidation at Ouabache State Park", "IN", "Bigfoot" },
                    { new Guid("0eebdf7a-9d4b-4748-879d-6bb2fb1214cd"), "Williamston", "It was reported that on Halloween night a woman was on her way home from picking up her baby after a Halloween party. She was dressed as a cat and had red contacts in. She was going around the curve right before the bridge and was tuning her radio when her car missed the curve and ran off the side of the bridge clearing through some trees and landing in the water below. The screaming bridge got its name because some people have heard a woman screaming when they were around the bridge. Other people have reported seeing her red  glowing eyes.", "Screaming Bridge", "NC", "Ghost" },
                    { new Guid("0f1434d7-f2b8-456e-82a1-425e9269792c"), "Findlay", "\"College students and teachers reported seeing a child's face appearing upstairs windows after the center is closed  lights turning on themselves when the teachers lock up the place  cold spots on second floor  door closing by themselves in storage room  child's giggles can be heard  food mysteriously appeared after everyone claimed they never \"\"made it\"\"  sometimes it'll disappeared. This place was said to be haunted by 2 young girls who died upstairs due to carbon monoxide poisoning or fire. These activities seems to increase in Spring time  between March-May.\"", "Owens Community College Child Care Center", "NC", "Ghost" },
                    { new Guid("0fbd8b44-e266-4186-b320-11473bc1ab59"), "Warren", "the old Moore Building - A shadow of a man climbing the stairway to the second story of the building above the ground level shop's. Store keeper's hearing noises and footstep's in the second level and rear of building's first level leading to the basement of the building. Some storekeeper's tell of walking in to cold spots and areas where the hair on your arms and neck stand on edge.", "Historic District", "MI", "Ghost" },
                    { new Guid("0fc4b5cf-d09b-4353-bb70-820be10e4505"), "Kahului", "Bright Star or Planet when magnified turns out to be metallic saucer shaped object.", "Disk", "HI", "Alien" },
                    { new Guid("101d1aa2-62de-4b61-8eef-cf376576fbe0"), "Hammond", "Circus Train - In the 1920's or 1930's the big top circus was traveling through town. The train was involved in a crash and all the animals aboard the train burned to death. The animals' remains were buried in a nearby cemetery. It is said that if you go by you can still hear all the animals cry.", "Robertsdale", "IN", "Ghost" },
                    { new Guid("103757ae-64fc-4db4-bc3f-d461cb994088"), "Cedarville", "in the woods - There is a tree out in the woods of Back Rd. that is an old KKK tree. If you go out there and examine the tree you will see rope burn on one of the branches from where they used to hang people. Footsteps can be heard and if your back there for long enough for a split second you will see a young man being hanged.", "Newport", "NJ", "Ghost" },
                    { new Guid("10cee965-432f-4de8-b331-29afaa112b83"), "Milton", "A picture taken picked up a thin shadow image in the distance.", "Milton Graveyard", "FL", "Ghost" },
                    { new Guid("10d9fb79-fbd3-43e0-8d7d-a8d757c978fe"), "McMinnville", "I was watching fire works with binoculars  and I saw something weird. As I watched it  I ruled out the possibility of a plane or fire w", "Disk", "OR", "Alien" },
                    { new Guid("10f2058c-3769-4949-9df5-09f9a562dc51"), "Spotted in the woods on the southbound side of the road (Wilbur Cross Parkway)", "On Saturday afternoon on August 4  2018 at approximately 2pm my boyfriend and I were driving from Berlin to Woodbridge about halfway there I was staring out the passenger side window as my boyfriend was driving. In a clearing of the woods I saw what looked to be an extremely tall man with shoulder length dirty blonde hair. As I focused in I realized this 8 ft tall creature’s arms  chest and legs were also covered in the same long dirty blonde hair. He was walking north with the back of his hands facing forward  swaying like a gorilla as he walked on two legs. As we passed him I jumped out of my seat and turned around and kept my eyes locked on him as long as I could. My boyfriend asked me why I did that and I told him  “I think just saw a Sasquatch. I just saw the weirdest thing and it was not a human.” And went on to describe what I saw.", "Report 60892: Afternoon sighting by motorist  Wilbur Cross Parkway  approx midway between Berlin and Woodbridge", "CT", "Bigfoot" },
                    { new Guid("11b9971f-792e-4e2d-ba34-67bb5c6a7220"), "Genoa", "The Dake House is known to be haunted by many spirits. It is now an antique shop. It was once home to the local undertaker. Afterwards  it became a family home. The Dake house is very old  and it's most common spirit is of an old woman. Workers report seeing an old woman in a housecoat walking around after everything was locked up. Some people also report being slapped or pushed. I have been there many times.", "The Dake House", "NV", "Ghost" },
                    { new Guid("11fb571e-5517-414a-9435-003a3f914773"), "Albuquerque", "It looked like a very large  slow satellite  and then it disappeared.", "Light", "NM", "Alien" },
                    { new Guid("13c49440-e018-43ed-a3c2-de1d93e4ac00"), "Approximately seven miles from Cumberland out on HWY 48 is the general location. .", "\"This incident happened a long time ago  and never told too many people about it.  I am a 31 year old Native American  and I was maybe 6 or 7.  I am glad to know that there are people like you who take this seriously.  It was night  and my sister and cousin were playing around on the phone (they would dial our number & hang up the phone so it would ring).  They had music playing (loud)  and were just playing around.  The door bell rang  and one of us answered the door  but there was no one at the door.  Well  this happened 2 more times.  We had a little housedog (we also had a st. bernard)  and my sister and cousin noticed that the house dog was crouched under a chair in our livingroom.  The last time the door bell rang  we all went outside  and couldn't see no one around (we all stood out on the porch). It was maybe a half hour later  my oldest brother went to the refrigerator.  The rest of us kids were playing in the hallway when he came running down the hallway with his hands to his face  and crying hysterically.  He ran in our parents room and jumped on the bed landing on his stomach.  He was crying pretty bad.  We all kept asking him what was wrong  and he finally told us what he saw.  He said he saw something peeking around the tree  and he said it was motioning to him to like \"\"come out\"\".  That's when he freaked out. After about 15 minutes (he calmed down some)  there was knocking at the back door  and the way they were knocking  it was like  open the door now!  When we opened the door  a guy who lived a few houses away  came in as white as a sheet  and was shaking pretty bad.  He said he broke down a ways from our place  and when he was walking up the road  he heard something walking in the woods with him.  He didn't know what it was.  He said he was really glad to see our lights on.  Our parents weren't home (mother working; father-didn't know where he was)  but we ended up calling our Uncle's  who lived next door to us.  They arrived a few minutes after we called them  and they had their shot guns with them.  They came and talked with the guy that came to our house.  I think one of my uncles took him home.  There was 6 of kids home (one was our cousin).  My uncles went outside to look around  my oldest sister and our cousin wanted to go outside too.  Well  when they opened the back door  our st. bernard  well let me tell you  for the size of those dogs  that dog would not let those girls out  and he even growled at them.  Well my sister and cousin backed up from the door  and as they did that  the st. bernard came running into the house.  Well  my sister and cousin still went outside  and as they were standing by this little trail by the house  they noticed some dark form at the bottom of the hill/trail.  They thought maybe it was a stump  but then the stump moved and turned to look at them.  My cousin said it had red (?) eyes.  They came back inside right away.  Our cousin went out again (back door)  and went around the house to the front  and when she got to the corner of our house  she looked up towards my uncles garage  and said she saw something peeking around the garage.  She said she thought it was one of our other cousins  but she noticed this had a cone shaped head as it looked around the garage towards our house.  They ended up putting us kids to bed (3 of us).  My sister and I were pretty scared  and our little brother (he had a crib) didn't really know what was going on.  My sister and I were shaking in bed.  Our brothers crib was right next to the window.  We were really hoping whatever was out there  didn't come to our window.  Well  we did see a big figure go by.  We were just so scared!  It seemed like forever when our parents got home. When they did we told them what happened.  My mother ended up calling a spiritual guide  and he told her that there was probably 3 of those things around the house that night.  He also told her that they were looking for a boy to take.  He said that one of them may have lost one of their own  and came looking for a young boy to replace the one they lost.\"", "Report 1432:   Someone or something walks by house and peers from around a tree", "WI", "Bigfoot" },
                    { new Guid("13d85bb0-934a-480c-a8f0-544bb7746015"), "", "\"When I was young six years old  Ronnie Joe a friend of mine and myself was playing behind Ronnie's house.  We heard a thumbing sound and moved closer to see what was making the sound.  Just behind a neighbor's house we saw a big foot digging in the ground with a stick of fire wood  at times taking one stick of fire wood and pounding a second stick into the ground. Then he would turn the dirt over  using the stick like a spade. He may have been looking for food  but we never knew for sure. Then the bigfoot stood up and walked our way.  We were only 25ft. to 30ft. from the animal. It was showing its teeth but didn't make a sound.  This was a open field  bright sunshine lit day  nothing between us and the animal  so we got a good look but not a very long look at bigfoot. The animal had a dark brown coat with a lighter  almost grey vest.  He had large teeth and long \"\"dirty\"\" finger and toe nails. The nails looked very thick.\"", "Report 1024: An account of bigfoot tool use", "KY", "Bigfoot" },
                    { new Guid("14474980-4160-41bc-85cb-1defa40b5cf7"), "Oklahoma City", "It was a disk and it changed colors and disappeard.", "Disk", "OK", "Alien" },
                    { new Guid("1449199a-d22f-4a07-90a6-f4d148582966"), "Boston", "In the 1700's The Everett Theatre on Fairmount Ave. People on the balcony were all slaughtered on the balcony. Story is that that the further stage lights above the balcony were cut down by two murderers. They killed a whole sold-out audience in the balcony. Today the theatre is closed because the people who owned it ran out of money. Still today the people who were killed are seen screaming and crying up there.", "The Everett Theatre", "MA", "Ghost" },
                    { new Guid("156d3d61-734b-4af7-8732-12095b80a7e6"), "At the southern end of the Danforth Hills  on private property known as the Morgan Creek Ranch  owned by the Colowyo Coal Company. This property is part of the Colorado Division of Wildlife's Ranching for Wildlife program  and is actually known as Morgan Creek Ranch.", "\"While hunting in Moffat County  Colorado  my wife and I both heard a sound that was inexplicable to either of us. There is no doubt in my mind that what I was hearing was a vocalization of some sort. I have spent my entire life in Colorado  and spent quite a bit of time in the outdoors  and this sound was unlike anything I have ever heard  and I can not imagine any animal in Colorado that would be capable of making this sound. It started as a very low range roar  of sorts  and built in volume and range to a high pitched  very primal scream. The sound was very  very loud  and very \"\"large\"\"  for lack of a better word. The sound came from an area closed to vehicles  and it echoed from the surrounding hills. The duration was about 6-7 seconds  and it was repeated 4 times in the course of about 90 seconds. This sound was so primal  so intense  so big  that it raised the hair on my arms and the back of my neck  and I was chilled as I have never been before in the wilderness. I know what bear  elk  raptors  and big cats sound like in Colorado  and I assure you  this was nothing like I have ever even imagined.\"", "Report 16648: Hunter reports possible vocalizations in the Danforth Hills near Meeker", "CO", "Bigfoot" },
                    { new Guid("1590b215-2a37-451b-8442-522bd2176c00"), "about 2 miles behind my old home place on bayou bodcaw", "While squirrel hunting on Bayou Bodcaw on a clear and sunny morning  I heard dogs running what I thought was a deer on the west side of the creek. I was standing on the east side appx. 20 ft from the bank looking for squirrel in cypress den trees. The creek was about 30 to 40 yards wide with banks 10 to 12 ft high. As the dogs drew closer I put a 12 ga 00 buckshot in my shotgun. I then saw what I thought was a person break through some bursh and slide down the bank almost to the water. It then crawled back up the bank and turned and looked my way. This creature had reddish brown hair all over its body about the length of a deer's hair. It stood appx. 6 to 6.5 feet tall. Due to its hair I could only make out its nose and eyes features. After a few seconds it turned north and jogged up the creek until it was out of sight. The next day I told my dad about this. He asked why I didn't shoot it.  I told him it looked too much like a man.", "Report 23227: Daylight sighting by squirrel hunter outside Sarepta", "LA", "Bigfoot" },
                    { new Guid("161e1b4c-26a6-425f-828f-f8229b3022f7"), "", "While strolling through the timber on a warm fall night  I came up the slight incline from the river bank and heard a scream coming from due east. My immediate thought with respect to the sound was that it was a bobcat. I froze in my tracks and looked toward the sound in time to see whatever it was jump from about 6 or 8 feet up in a tree to the ground. It landed on its hind legs  took 3 or 4 steps  then went to all fours and ran faster than I have ever seen anything run into the treeline. When I saw that it was completely gone  I ran as fast as I could perpendicularly to the highway.", "Report 24997: Hiker has nighttime sighting near Carlyle", "IL", "Bigfoot" },
                    { new Guid("16afa4fd-1e70-47d6-abe5-38efc1cc379c"), "Salt Lake City", "Three objects seen repeating formation below cloud cover by several witnesses", "Odd Shape", "UT", "Alien" },
                    { new Guid("16b0cd5c-4c6b-4157-9cb1-76c650f0ce11"), "Quincy", "In the early 1900's  a house stood in the place where the school is today. A woman  living alone was murdered  and the killers were never found. It is told that she was dragged down the large staircase  then stabbed until her screams stopped. They then hid her body in the closet at the base of the stairs. The bloodstains were never able to be removed completely.", "Madison School", "IL", "Ghost" },
                    { new Guid("16c3c220-06ee-4cdf-abae-4e7c9d9f04e4"), "Creeks and ponds in the area.", "\"While predator calling this date  I was targeting bobcats with an electronic call. (I mention this because with this particular call  only a bobcat would be expected to respond. A fox  coyote  coon  etc. would not respond to this call.) After about 10 minutes of calling  I heard a sound from behind me that I could not identify. I was using a varmint light  which has a red filter. This light is not normally readily seen by predators. I shined the light toward the sound  and saw what I thought was a bear. It was dark in color  but everything was either light or dark because of the red filter. I have hunted in the West several times  and seen many bears. I initially thought that's what this was. But as stated earlier  a predator does not respond (normally) to this light. But this animal did. It stood up and moved away very rapidly on it's two \"\"hind\"\" legs. While on all fours  it appeared to be a bear. Upright  it appeared to be around 5-foot tall with a fairly large stride. I wasn't able to notice any other details because of the light source and because of how quickly it moved off. Bears do not move great distances on their hind legs  and especially not rapidly. It made this sound continuously as it moved away  gradually decreasing in volume until I couldn't hear it any longer.  I'm not sure what this was  but I'm quite certain what it was not  and it was not a bear  a hog  or any other animal native to this area. After a recent conversation with Daryl Colyer  he and Craig Woolheater encouraged me to make this report. I did not do so earlier because I simply had no idea there was a possiblilty this could have been a bigfoot-type animal. Should there be any follow-up  I'd like to request Daryl Colyer as the investigator.\"", "Report 10591: Predator caller has night time encounter in Sam Houston National Forest", "TX", "Bigfoot" },
                    { new Guid("16dab1cb-e9e3-4c0d-a44f-7744ccc4a2f3"), "At this moment I don't know the location because I was so young.", "\"When I was around 10  11 or 12 (1975-77) Sorry  I don't remember exactly -- it's been a while. When I was a kid  My grandparents had a little bitty camper at a campsite at Nolin Lake. I couldn't tell you precisely where it was either. If I had to  I could probably get my father to tell me where it was  but that would mean I'd have to tell him this story ... Anyway ... one summer my father took the family (me  my sister and mother) to my grandparents site for a little vacation. One evening as it was becoming dusk  I remember standing inside the camper looking out the screen door at my father who was cooking at the grill. The campsite sat at the top of a hill in a wooded area. The woods consisted mostly of old growth  deciduous trees  so there weren't really any evergreens or shrub-type trees like cedars which could really block your view. So I was looking out the door at my father who was on my left and eventually  out of boredom I guess  I ended up scanning to the right and down the hill into the woods. I remember seeing about midway down the hill  something that caught my eye. You know how when you think you see something and in a split second your mind says  \"\"Did I just see what I THOUGHT I saw?\"\" Well that's what happened to me. There he was. Midway down the hill -- I'm getting chills right now typing this -- partially hidden behind a tree was this \"\"man thing\"\" I could see his whole head  his right shoulder and part of his leg coming out from behind the tree. He/it was grayish brown and he was looking right at me (Maybe not -- but it sure felt like he was looking at me) I looked away thinking I had to be imagining it but when I looked back  it was still there and I had no problem picking him out from the trees. At that point my mother who was cooking at the stove behind me said something to me and I turned around to talk to her. When I looked back outside down the hill  he was gone. I kept looking through all the trees  but I couldn't find him. After that I was scared. I didn't leave the camper the rest of the night. I was an avid comic book reader at the time  so I used that as an excuse to stay in. I remember I kept looking out the door that night just to check around and see if he came back and my parents kept asking me to come out and sit by the fire ... I didn't dare tell my parents about what I saw because my father's teasing is legendary in my family. He's the oldest of 7 boys so he REALLY nows how to get under your skin. What I saw was big and burley and it didn't make any sounds that I can remember. It had a big  squarish head (kind of blocky with rounded corners) that looked like it sat right on its shoulders. I really don't recall seeing a neck. I could see a massive shoulder and a thick bicep. I could also see its chunky hip and a good portion of its thigh down to about it's knee. All the rest was hidden behind the tree. From time to time I'll see an animal show that will feature a three toed sloth  and every time I see a sloth I always think  \"\"That sloth's hair looks like that bigfoot I saw when I was a kid\"\" If you want  I can draw what I saw if that helps any.\"", "Report 10765: Youth watches animal hiding behind trees near Nolin Lake.", "KY", "Bigfoot" },
                    { new Guid("17682841-5eac-4a87-9017-aabceaab500f"), "Area is near multi use trail that winds thru thick woods and fields of the area. James Reed Wildlife Area 13101 Ranson Road Lee's Summit  Mo 64082 area maps are available on line", "While birding the James Reed Wildlife area in Lee's Summit Missouri in the late afternoon of March 8  2013  I observed in the tree line on the west side of of Bodarc Lake a large brown hairy creature walking along the edge of the Lake. It appeared to be 7ft tall and had a long stride and arm swing. I observed this for five minutes from the parking lot for this lake. I observed this animal with my binoculars.  The animal walked into the woods. The area has cut back the brush in the area opening large areas to view that have been obscured for many years.", "Report 40306: Man observes with his binoculars a large hairy biped at the James A. Reed Wildlife Area", "MO", "Bigfoot" },
                    { new Guid("176901fa-2070-4bb2-8a3f-09aaadff6748"), "", "In 1991  I don't remember the exact date  my wife  then girlfriend  and I were riding around the backroads of Cross Anchor trying to see any deer crossing or standing on the side of the road. This was our typical date  all you redneck country boys will understand. I don't remember the name of the road we were on but it was between hwy.49 and hwy.72  not far from ridge rd. back toward Clinton. It was around 1 or 2 in the morning. We were going down this road and way out in front of us  out to the point where the headlights barely reach  we saw something cross the road on two legs. I punched the gas and sped up to try to get down there so maybe we could see what it was. When we got to the area where it crossed I stopped and rolled the window down and was shining my mag light in the woods. Back about maybe twenty yards in the woods I noticed this tree that had a big lump on the side of it. Well  I focused my light on that tree for a few seconds just looking when all of sudden this thing stepped out  looked right at us then turned and walked on into the woods out of sight. At that point I didn't know what to do. My wife was yelling for me to get out of there so I hit the gas and drove off. Being dark as it was  it's hard to say just how big it was but I would guess around 7 feet tall. It looked to be covered in brownish hair all over. I'm not sure about the face  I couldn't see it that good. The only reason I knew it was looking at us was because it's eyes were glowing red from the flashlight. I've hunted that area for years  and I've heard a lot of unusual things but that was the only time I ever seen anything like that.", "Report 24235: Man recounts watching a sasquatch cross road near Cross Anchor", "SC", "Bigfoot" },
                    { new Guid("17739a33-6e6e-4c64-b16b-fd93cc9ab0be"), "Idaho Falls", "My husband and I was walking the dog late down the dirt road. And we both looked in the same spot in the sky and we seen a bright wight", "Light", "ID", "Alien" },
                    { new Guid("17a40737-c105-4edc-bb1f-da11af5d9471"), "Anchorage", "Room 201 - This room is haunted by a man who died there  and whose body was not found for several days  according to the staff. Also  there is a ghost by the name of Ken who wanders the parking lot and courtyard  in and around the gazebo. There is also what appears to be a cat walking around the hotel. It's very evident in rooms 103 and 107.", "Courtyard by Marriot", "AK", "Ghost" },
                    { new Guid("17b1c67f-8320-4d63-a472-c758915fee11"), "Swedesboro", "Reported sightings of a man on a bike as well as screaming.", "Swedesboro Lake", "NJ", "Ghost" },
                    { new Guid("17c9d75a-7320-45f1-9688-f735a502391d"), "It was a small little campground along Flatrock River in a secluded part of northwestern Decatur County close to Rush and Shelby County.", "\"This happened to me and a friend of mine. It was a clear spring day. We were at a campground where my parents camped in a secluded part of our county. It was a Wednesday  so most adults were at work. We pitched horseshoes and messed around while the dogs that hung around the campground all played. I had a .22 rifle of my brothers with some shells. My friend and I went down to river as it was traveling at a slow pace and I through in a pop can. We took target practice at the can. I had one shot left and the can was pretty far down the river when I noticed how quiet it was. I put the gun on safety and ask my friend when is the last time you ever heard complete silence in the woods. No birds  no nothing. The first noise we heard came from across the river. It kept getting louder and I told my friend that I was going to get the .22 shells that were on the picnic table up the bank by the horseshoe pit. I was halfway to the picnic table and I heard this loud noise and my friend hightailing it up the hill saying \"\"There it is!\"\" I froze in my tracks and my friend stood right behind me. There stood this Bigfoot with one foot in the water and one on the bank. It had rusty reddish-brown hair which hung down over its eyes like a sheep dog. We stood frozen and so did it for around five minutes. I told my friend to take a good look because for the rest of our lives people are going to laugh at us for what we are now witnessing. I had one shot still in the chamber. I took the safety off and told my friend to run to the car when I fire the gun. I first aimed the gun at the Bigfoot and it did not move. I debated for awhile then decided that this creature was not trying to hurt me so I shot up in the air. We ran to the car and drove straight home. I told my mom and she did not believe me at first. I  still to this day  want to take a lie detector so bad to prove to them and everyone that I did  in fact  have a loaded gun aimed at a Bigfoot and decided not to shoot. I still don't own a gun and I am fifty and I definitely do not hunt. The following Sunday was the Fathers' Day and my brother-in-law  who was nineteen went across the river in a rowboat to check things out. There were footprints everywhere. Only \"\"four\"\" toes. I wear a size thirteen shoe and I could put my foot in these prints with a couple of inches longer and wider to spare. My brother-in-law at the time  found a clump of hair that matched the description of what I saw stuck in the bark of a tree a couple of hundred yards into the woods by the cornfield. A tree had fell down and was stuck in an angle into another tree and it was about 7 foot up on the tree that was leaning. He put it in a plastic ziploc and to this day  I don't know what he ever did with that sample. I told this to an Amish man who does not live far from where this happerned in the mid-90's and he told me that one of the men in his congregation had also spotted this creature along the river around that same time. I am an honest  sensible man. I know what I saw and nothing will ever change my mind.\"", "Report 29032: Memory told of a mid-afternoon encounter along the Flatrock River", "IN", "Bigfoot" },
                    { new Guid("17dc5734-fa92-4ba1-8b16-f853ec7303f6"), "Leadville", "Blue lights shoot through the treetops  and a woman in white flies over the tombstones.", "Evergreen Cemetery", "CO", "Ghost" },
                    { new Guid("17e3de2e-f861-4f33-8f14-92a6ac87fe56"), "Council Bluffs", "\"This cemetery is home of the \"\"Black Angel.\"\" Dodge's wife died and in her remembrance they made a statue of the angel that she dreamt of before she died and put it in the front of the cemetery. The statue is known as The Black Angel. Her eyes follow you no matter what direction you go. Whoever is \"\"blessed\"\" by her is on the sickly side from then on. Small lights have been seen in the trees behind the older grave sites. Feelings of someone walking on the heels of visitors.\"", "Fairview Cemetery", "IA", "Ghost" },
                    { new Guid("186bdfcf-de23-494a-9938-f510d15ee416"), "Kansas City", "\"Was witnessed by my girlfriend on her way home. She stated that it was an orange colored \"\"Glowing\"\" round object leaving a trail behind\"", "Odd Shape", "KS", "Alien" },
                    { new Guid("189723f8-1438-4480-b552-a32500fc445e"), "On the 169 (heading west toward hibbing)on the outskirts of Iron in a high voltage tower clearing with woods on either side.  Remember  I was headed east to Virginia  seeing this across the two-way of 169 going west.", "\"While driving east on hwy 169 (approximately 3 miles out of Virginia  MN.)  I saw  looking across 169 heading west to Hibbing  what appeared to be a large  silvery-gray creature in a clearing  just beginning to enter a wooded area.  I caught this movement from my peripheral vision from my left (so it was on the other side of 169) where there was a car pulled over on the opposite side apparently watching what I was seeing.  Because I was headed to Virginia and there were trees that popped up in the median as I was driving  I only observed this \"\"something\"\" for about 3 seconds or so.  It did have a peculiar way that it's arms moved when I saw it walking  and it had a cone-shaped head. After that  the wooded area in the median obscured my vision  but if I would have found a place to make a quick u-turn  I would have turned around to go back and investigate.  I sort of talked my self out of believing what I saw because this \"\"something\"\" was not the normal brownish/red color typified of a bigfoot sighting.  Perhaps it was one of those new-fangled netting out-fits hunters wear.  All I know is I saw something.\"", "Report 27676: Possible brief sighting by a motorist outside Mountain Iron", "MN", "Bigfoot" },
                    { new Guid("1897bf9c-6e88-4f04-9386-c0d7ba9a4f83"), "North Platte", "So after on of our concerts in North Platte  my band mates decided to go out to the famous Buffalo Bill Codys’ house  looking up at the window we saw a vision of a little girl. The curtains were moving around while there was no wind  perfectly clear night. The little girl looked to be glowing around the edges as she moved her hand around.", "Buffalo Bill Codys' House", "NE", "Ghost" },
                    { new Guid("18de0c6a-e494-446c-9c91-16eb8d898367"), "Hinsdale", "A woman name Helen died around 1900 while the land was still a potato farm and she can be seen walking around at night. She walks through the lot not paying attention to anyone and is visible at night if there is an outdoor fire going on.", "The Walsh Camp", "MA", "Ghost" },
                    { new Guid("193740a2-5b99-45c8-88b4-1d498011eb9a"), "Rapid City", "Sioux San was a boarding school  many many years ago for Native American children and a sanitarium for TB patients many years later. It is now an out patient hospital. It is said the voices and crying and apparitions of children haunt the third floor. These sightings have been seen by numerous night guards  who have quit because of the ghosts. There is numerous little graves on the grounds  of children  who still need to go home to their families.", "Sioux San Hospital", "SD", "Ghost" },
                    { new Guid("199e0205-3021-4ea6-b27d-ebafe5d63636"), "Marksville", "Triangluar object moved very slowly over the trees appr. 100 yards from me without a sound  stopped  tipped up and lowered itself into", "Triangle", "LA", "Alien" },
                    { new Guid("19b39fa9-f6ec-4f6f-8419-058608ecb11b"), "At the edge of town.", "\"This incident happened last night just after 11pm. My daughter was home alone. She lives with a relative  who was out of town. She called me at 11:22 pm; she was terrified. She said she could hear something walking back and forth by her bedroom window. She also said she looked out the window when she first heard it  and saw \"\"something\"\" big and black  really big. She described the \"\"thing\"\" to have been about 3-4 feet above the bottom of the window. When I went down to look behind the house this morning  I stood by the window. I am 5'4\"\" and my eyes just reach the bottom of the window  so I figure this \"\"thing\"\" must have been 7-8 feet tall. We live in a small village of less than 500 population.  There are a lot of bushes and trees in between the houses. Their house is close to the beach  and there is forest surrounding the town. Now  I've never known my daughter to afraid of anything  but last night when I went to pick her up  she was shaking like a leaf  she was hysterical  it took me almost an hour to calm her down. I questioned her about what happened. She called me about 5 minutes after she first saw it.  She was too scared to move. When I got down there  I would not look behind the house  but she was hiding in my relative's closet. She said it was walking back and forth right behind the house. She described the footsteps as a sound that someone very large walking on two feet  kind of like a \"\"stomping\"\". My daughter is very down-to-earth  not one prone to dramatics. When I first went down there  I didn't really know what was going on  just that my daughter was scared spitless  but I would not look behind the house. When I went up to the house  my hair felt like it was standing on end  and I had goosebumps really bad. I was scared and didnt know why.\"", "Report 7963: Sasquatch walks past window of house at night", "AK", "Bigfoot" },
                    { new Guid("19e972da-94b5-4985-8f2c-2172e855af6a"), "", "You have had an encounter with my family  the Bridges over in Quincy  Florida. I now live in jacksonville  Fl. with my boyfriend  his mothers friend has a lake house in Lake Crosby. We took a day trip out there and as we were walking from the end of the dock up to the lake house. It intriged us greatly when we looked to the left and saw a foot print that was not a normal size. We jumped off the dock to get a closer look  it was exactly how a big foot print looks. It was about 11-12 inches long and 5 inches wide. While we were there  there was ducks in the water near shore. The area is very swampy like a marsh  and deserted from a lot of human commotion. Furthermore  my knowledge provokes me to go back to where it was sighted and do further research ourselves. We do believe the area is habitat to big foot. To have your opinion about the situation would be greatly appreciated. Thanks.", "Report 33088: Couple find large footprint on Lake Cosby", "FL", "Bigfoot" },
                    { new Guid("1a38c01e-3b76-4f4e-806f-83b394070483"), "Hattiesburg", "Bright  red pulsing object in the north eastern section of the sky.", "Light", "MS", "Alien" },
                    { new Guid("1b36ff63-7c22-4dba-ae52-8f19ee86d65f"), "Vanderburgh", "Boehne Camp Hospital - This is an old abandoned tuberculosis hospital. Several people have reported sightings of the ghosts of patients who were held there against their will as to not contaminate others. The property is now privately owned  but students from the nearby university often are caught trespassing on the property. - Trespassers will be reported to the police. - June 2008 Update: the hospital was torn down only right across from it is the other building that was connected by the tunnel it is being renovated to apartments and there is still a utility shed with access the tunnel which is not smart it is usually flooded and cluttered with old desks lots of bats and creatures of the night.", "Evansville", "IN", "Ghost" },
                    { new Guid("1b94c656-438d-4650-b7d7-b6c65d30e9a9"), "Greenwood", "there have been a sighting of a headless person behind my car you go at night you hear moaning  hart beats  and beating on the old iron gate.", "Old Greenwood Cemetery", "LA", "Ghost" },
                    { new Guid("1bf75784-b305-40a7-b9ff-47f137e833f3"), "Dickinson", "It is said that the elevator door leading to the morgue often opens by itself at night. The key is that the doors can only be activated from the inside of the morgue. The area near the cafeteria is also said be haunted. A soft  eerie moan can sometimes be heard coming from the area late at night. There are reports of the nurse's call button being pressed late at night on the third floor in unoccupied rooms. The voices of children laughing and running can often be heard in the old section of the admin offices from the basement.", "St Joseph’s Hospital", "ND", "Ghost" },
                    { new Guid("1c739ed9-e5e4-4fab-8740-aa3b6996e5a3"), "They have been seen around the river and dry river beds in the cispius area the town", "You guys need to go to Washington state and go too the Gifforard Pinchot forest where there is a river called Yellow Jacket and the Cispus river flow together. I have seen and heard weird things there and me and my nephew seen a big foot walking towards us and my friend seen them recently and got pictures on his phone of two or maybe three of them the people who live their have seen them or heard them I believe that if you go there for not just one day and night it will take you about four to five days before you might see one if you try looking for them you wont see them but if you just camp out and hang out for awhile I am pretty sure that something will get your attention there is all kinds of signs there.", "Report 55658: Hunters on bikes have close encounter with a sasquatch near Randle", "WA", "Bigfoot" },
                    { new Guid("1cabbb58-0e54-4cb3-8bdb-17226172d3e1"), "Powell Marsh  Manitowish Waters Wisconsin [Investigator (MM) note: Here are the GPS coordinates for the rough location of where he was standing when he shot the photos and video. The figure was an undetermined distance to the southeast of his position  running away generally towards the southwest. 46.0839196  -89.9131363", "Wanted to pass this by you as I was out duck hunting today (10/17/21) in north central Wisconsin… Powell Marsh area to be exact. This is a very remote marsh area surrounded by hundreds of thousands of acres of state and National forests.  You can access this marsh zone via paths the DNR has to maintain Water levels and people do watch migratory birds from a couple observation areas along road. I was more on a walk with the potential to jump shoot some puddle ducks as you can see not a cloud around.  Nor were there ducks. Not even sure it is a sighting but seemed rather strange. Something told me to look behind me as I was going the opposite direction as the figure. After watching this object for a couple hundred yards I decided to grab my cell phone. It is a long way away but appears black  large  and fast.  We have bear  very few moose  wolves  and occasional Elk around.  Feel free to say it is a guy on a bike-riding in the peat moss  or a guy on a 4 wheeler in a prohibited motorized vehicle area. It appears to be bipedal and walking deeper into the swamp in the muck. It is hunting season and I wouldn’t expect a person to be dressed in all black in a public hunting area.  I tried walking in it and turned back after about 5 feet. With naked eye I could see much better. The figure seemed to float as it moved across the swamp. Again a guy on a bike? After my hunt  I returned to the only 2 access areas to see if there were vehicles with bike racks or people out for a peat bog run. There was nobody around. I have been to the Marsh countless times and have never seen something like this. Although the distance a bit far for video. Figure seems quite large. Clearly appears to be in muck. I have photos and video but iPhone is a long way away and i am not an editing expert.  I am sure video can be manipulated and enhanced. ——————————— [Further comments provide when he sent in the photos: “ Here are pics. Was hunting ducks in Powell Marsh  Wisconsin.   Video I have problems getting to send but have it running thu the muck   Any thoughts are welcome. Watched with naked eye for about 300 yards before I figured I should try to get some photos/video. The small road behind is top of dikes running through the swamp.  about 10 feet wide with deep water on sides.  Clearly in the marsh not on road.  Of course left GoPro at cabin so stuck with iphone camera..  Would be happy to say it is nothing so I could hunt peacefully without thinking of this. Seems quite large. Was fast. And all black. mentioned in investigator notes. To see the clip  right-click on the link to open it in a new window. When the link shows in the new window  highlight it and then click Enter.", "Report 71733: Sighting  photos and video (distant) of a probable Sasquatch near Lac Du Flambeau Indian Rez", "WI", "Bigfoot" },
                    { new Guid("1cc1f32d-55d0-46b5-a3a0-56abf8b998db"), "Lenox", "An eleven year old girl  whose last name is Sloane died from a disease in a hotel room there. The building on the right  which is right next to Sloane's Tavern. A open diner place. They say people have heard squeaks  as apposed to be her own language. Even my dad did. He works as a carpenter there.", "Cranewell Resort", "MA", "Ghost" },
                    { new Guid("1cd6731a-db70-40e7-adf6-875f40efa53a"), "Midlothian", "Bright white light moving quickly toward earth  then stopped dead and shot back up.", "Circle", "VA", "Alien" },
                    { new Guid("1d3780d5-4c0b-4a2a-86ed-f1ee528169fa"), "Lehi", "This hospital is over a hundred years old  the windows are broke and the back stairs have collapsed.  At night there have been reported sights of a nurse that is hung hanging from a steel flag pole.  the story is that she was working late in the ward and a doctor went crazy and hung her out there.", "Lehi Historical Hospital", "UT", "Ghost" },
                    { new Guid("1dc67711-0d96-4d75-ae49-3db6c1cfcb73"), "Cullowhee", "8th Floor - In the early 1990's a young student hung herself in the East Wing. For many years the floor was shut off due to many occurrences with sightings of the young lady. Bathroom lights will turn on and off as well as doors opening and shutting. Water will run for no reason.", "Scott Residence Hall", "NC", "Ghost" },
                    { new Guid("1e3f3935-112d-43af-bf14-1ae379066f16"), "Yankton", "I first saw this cigar shape fairly brightin the northern sky  there was glowing around it on two sides  like if it was shining light.", "Cigar Shape", "SD", "Alien" },
                    { new Guid("1e60335a-628a-4d5f-8c78-b6cee7132e68"), "Cody", "There have been sightings of a soldier dressed in an 1800's style uniform in the main dining hall near the cherry wood bar. Also seen  Irma (Buffalo Bill Cody's daughter)- “The Lady in White” roams the halls of the second floor where the suites and rooms are  as well as an aggressive presence in the kitchen.", "Irma Hotel", "WY", "Ghost" },
                    { new Guid("1ed1eef9-d924-4aac-9807-ba372dac6080"), "New Wilmington", "Hillside Girls Dormitory - Witnesses report strange occurrences such as opening and closing of doors  not to mention locking of doors  the turning on and off of lights  things being knocked over and put back up in front of the witnesses eyes  music being played from peoples computers when they are not even at their desk  and strange typing noises from everyone's computers. Rumor is a girl named Betsy long before the college was built in the 1800's. It was a Mansion long before Westminster College existed. Rumored to have been murdered.", "Westminster College", "PA", "Ghost" },
                    { new Guid("1f0e6048-41b5-4279-be79-394d76d96b93"), "LONG STRAIGHT ROAD KNOWN AS FAIR LANE FLATS ON  HWY 183", "THIS HAPPENED AROUND 1981 IN PICKENS COUNTY S.C.I WAS ABOUT 14 YEARS OLD.MY BROTHER LIVED IN PICKENS I LIVED BETWEEN PICKENS  EASLEY AND DAUCUSVILLE.THIS HAPPENED BETWEEN PICKENS AND HOME.I WOULLD RIDE MY BIKE TO MY BROTHERS APT.CLEAN IT UP AND THEN RIDE MY BIKE HOME SOMETIMES VERY LATE AT NIGHT.MY FRIEND BRIAN WOULD SOMETIMES COME WITH ME.ON THIS NIGHT IT WAS MID-SUMMER AND A BRIGHT MOON. I WAS AHEAD OF BRIAN AND LOOKED BACK TO SEE WHERE BRIAN WAS  ON THE TURN I SAW SOMETHING WHITISH IN COLOR THAT HAD MOVED FROM THE ROAD SIDE OF THE FENCE[BARBEDWIRE 3 TO 4 FEET HIGH]TO THE OTHER SIDE MOVING FAST.I NEVER REALLY GOT A GOOD LOOK AT IT BUT I DID SEE SOMETHING WHITISH IN COLOR KNOCKING BRANCHES OUT OF THE WAY.THE ONLY THING I COULD THINK OF IT BEING WAS A HORSE BECAUSE OF THE HIEGHT.I WENT TO THE SAME SPOT THE NEXT DAY AND QUICKLEY DECIDED THAT A HORSE WOULD NOT MOVE THAT FAST THROUGH  THAT TYPE OF COVER.I NEVER THOUGHT FOR ONE MOMENT IT WAS A BIGFOOT [BECAUSE OF THE COLOR]UNTIL I WENT ON THIS SIGHT.TALKING ABOUT THIS TO MY BROTHER LATER MADE HIM REMEMBER SOMETHIG HE HAS SEEN.I AM TRYING TO TALK HIM IN TO REPORTING IT.I WISH I COULD REMEMBER MORE DETAIL  SORRY BUT I KNOW IT WAS NOT A HORSE OR BEAR ECT.I CAN GET ROAD NAMES IF IT WILL HELP. I JUST HOPE SOMEONE IN THIS AREA WILL SEE THIS AND TELL THERE STORY IF WE DO NOT TALK ABOUT IT WE MAY NEVER KNOW THE TRUTH. THANK YOU FOR THE OUTLET. MICHAEL .JUST AN AFTER THOUTH BUT I USE TO SQUIRREL AND DEER HUNT THIS AREA.", "Report 16962: Possible early morning sighting along country road near Pickens", "SC", "Bigfoot" },
                    { new Guid("1f6cf84d-ac1e-484c-b3eb-e938dffb5973"), "Council Bluffs", "\"The Dodge House was owned by General Dodge and his family. The community has tours go through it  to make some money off of its beauty and age...The real story is that General Dodge is still there wandering around or sitting in his rocking chair. Around dusk everyday  you can hear 2 men arguing if you stand in the middle of the street. Late at night you can see small flashes of light around the dodge house lawn  and get a very faint smell of fire. Dodge's wife died and in her remembrance they made a statue of her and put it in the front of the cemetery. The statue is known as The Dark Angel. Her eyes follow you no matter what direction you go. Whoever is \"\"blessed\"\" by here is on the sickly side from then on.\"", "General Dodge's House", "IA", "Ghost" },
                    { new Guid("1f7e698e-66ff-4f72-af30-450fb4757ef8"), "Around Moody  Alabama.", "\"When I was around 11 years old  I had a strange encounter in the field behind my house.  At that time  I believed I saw a crazy old man  but I now realize that is all I could rationalize it to be. I was walking alone at dusk with my dog.  This was not unusual as I loved to be outside- my parents often had to force me inside by calling me in for the night.  Well  from what I can remember of that particular night  I was picking up rocks in a ditch and looking at them.  I might have been looking for a certain kind of rock but I can't remember exactly what I was doing.  It was definitely getting dark  but I could still see well enough to keep after the rocks for awhile longer.  I remember holding a stick I was using to pry rocks out of the dirt.  It was very quiet and still and there wasn't much wind.  As I was looking at the ground  I heard a noise in front of me and I looked up to see what it was  and that is when I saw him.  He stood right in front of me at a distance of 5 to 10 feet  he was tall  but hunched and quietly staring right at me.  He wasn't much taller than a normal man  but I got the impression he was old because he was hunching.  He looked like Rip Van Winkle to me  and that is what I thought of when I saw him.  He had a long shaggy beard around his facial area  but he was completely naked but for the long shaggy hair that was in matts all over his body.  I remember the hair was thin at his face  the base of his neck  and upper torso  but thicker around his beard  lower torso and legs.  All the hair was grayish white and very long and shaggy.  Mats of hair dangled from him in tatters.  His feet were bare.  His face was very humanlike  but not quite normal as it had very exaggerated wrinkles- again  a reason I thought he was a crazy old man.  His head seemed normal  but there was so much hair it was hard to make out his features except where the hair was thinner.  He appeared gaunt and thin  but in just a moment I would realize he was not like an old man at all.  I screamed as loud as I could out of fear and I noticed my dog bolted towards the house while I was taking in the sight of this strange thing in front of me.  The shaggy old man let out a scream of his own when I screamed.  He was staring right at me screaming in a voice that sounded like a woman shrieking- he seemed very scared of me as well.  I turned to run for my house.  I looked over my shoulder to see if he was following me and I saw him run up the ditch in the other direction.  He was extremely agile and fast- he was definitely not Rip Van Winkle.  He ran in a full sprint  very quickly for someone so hunched. I think I caught the dog running back to the house  as I was so frightened.  I remember running into the kitchen and telling my Mom there was a crazy old Rip Van Winkle in the field.  I remember describing how he was old looking  hunched  naked  and his hair was very long and matted like he hadn't cut it in 20 years.  I told her about how he had hair all over his body.  Needless to say  I wasn't believed.  I became obsessed with what I called \"\"the Shaggy old man\"\" or \"\"the Crazy old man\"\".  I believed that he must have been an old deformed hermit.  I kept a notebook in which I drew many sketches of him.  I remember keeping the notebook secret from my family  hiding it out of fear of being ridiculed.  I wish I had those sketches now but sadly I've misplaced that notebook.  I remember I went back to the spot in the field looking for him on other occasions  but I never ran into him again.  I wasn't aware enough to look for prints or anything like that  but I knew that he was out there somewhere and I wanted to prove he really existed to others. What changed my opinion of this sighting was a late night visit to a bigfoot website.  I was just browsing their sightings index and I came across several sightings in the same county I lived in and all described white or grayish colored creatures.  Honestly  I didn't realize bigfoot were sighted in this part of the country at that time  or even for most of my life  and just seeing all those other sightings was a revelation.  I realized for the first time that what I witnessed may not have been a crazy old shaggy man  but rather a bigfoot.  When I think back on the sighting  it all makes sense in that light.  There would be no reason for a naked old man to wander that field  much less to be covered in grayish  white  shaggy tattered hair.  The only reason I never thought of it as a bigfoot before was that I had never heard of an Alabama bigfoot  so the thought never entered my mind.  Also  I had never heard of a whitish gray colored bigfoot  and this creature was thinner than a typical bigfoot description- maybe he was older or maybe even younger.  He looked a bit hungry to me  as he was not some hulking powerful creature  but he was still strong looking and extremely agile.\"", "Report 8679: Adult recalls childhood sighting at dusk near Moody", "AL", "Bigfoot" },
                    { new Guid("1f8fa399-2586-4a1b-affa-ed7531b69f18"), "Charleston", "Dickinson Hall - Students have reported strange sounds  sightings  and feelings of uneasiness **Has recently been torn down.", "University of Charleston", "WV", "Ghost" },
                    { new Guid("1ffbd4a5-9f3d-4952-937f-d9798d5cc520"), "St. Louis", "Spooky scary skeletons", "New Sighting", "Missouri", "Ghost" },
                    { new Guid("209fd0da-cb6c-478c-9cb4-d5b2ed0d662d"), "", "In 1957 in Valentine  NE I was 6 years old and playing hide and seek...I was with another young girl and we were walking down an alley looking for the other kids when we saw a sasquatch coming down the alley toward us..it was very tall and looked like a erect ape..very hairy...and was making terrifying loud noises.  We went running for the hills.  I carried the memory for many years and have never doubted that this was a true sighting.  The only person that believed was a school teacher that lived on that street who heard the inhuman sounds it was making.", "Report 25012: Woman recalls an encounter as a child  in an alley in the town of Valentine", "NE", "Bigfoot" },
                    { new Guid("214c44b9-15d6-40fd-bcc6-805574384805"), "Marsing", "Apon entering the cemetery at night a feeling of being closed in and severe saddness comes over you. Flashes of dancing lights appear over the headstones.There are alot of young people buried there. Eighteen years and younger.", "Homedale Marsing cemetery", "ID", "Ghost" },
                    { new Guid("219a2b02-3dab-44b9-8bb5-35ef2a81f47f"), "Forest Grove", "Blackbean shaped object  round on top  more angular toward bottom.", "Teardrop Shape", "OR", "Alien" },
                    { new Guid("22542c21-deae-4a3c-98e0-8314127bb20a"), "take mill creek road to the rooks park turn off and follow till you reach Rooks Park", "While walking along the Mill Creek Constitutional Path on 12/15/2000 witness Harley Michaelis observed large barefooted tracks along the trail.  Harley estimated the tracks to be 18-20 inches long and 9-10 inches wide  he also noticed a smaller set of tracks along with the other tracks.  Harley said the second set of tracks were about 10 inches long.  As he followed the tracks he came to a wooden bridge and lost the tracks there.  Harley did not report this sighting till 14 days later out of fear that he would be considered a nut.", "Report 1263: Rooks Park Investigation", "WA", "Bigfoot" },
                    { new Guid("2273d4e6-991a-4878-b4fa-fa896f8471b1"), "Montezuma", "60 miles east of Santa Fe  The Evil was filmed there. Ever since  people have seen some sort of woman in the castle towers at night. No one wants to go in there at night. It is currently being renovated.", "Montezuma Castle", "NM", "Ghost" },
                    { new Guid("227774d2-82a3-431e-b33a-65c0ed48744c"), "About 3 to 4 miles south of the Turkey Run State Park & School on Hwy 41.", "\"We were then living in Ohio. My husband had photography work to do and was being transferred to Indiana. In the fall of 1997 while driving south on Hwy 41 near Turkey Run State Park in IN  my husband and I saw what we affectionately call \"\"A something\"\". It was a misty night and we were headed for Terra Haute. I was driving my Ford Aerostar Van with my husband in the passenger seat (I was glad he was on that side) we also had our two year old son in the back seat. \"\"It\"\" was walking in the gully. \"\"It\"\" stood taller than the van so to speculate on the height I would say over 6\"\" easily. The body was black and hairy although the face was huge and long in the jaw shaped like a knight of a chess piece but not like a horse! My husband describes the face more like a lions shape. We passed it and continued our trip - and later even moved here with our child going to Turkey Run School. We travel the same road often from Turkey Run to Rockville and have never seen \"\"It\"\" again - YET!\"", "Report 19588: Nighttime sighting by motorists near Turkey Run State Park", "IN", "Bigfoot" },
                    { new Guid("22970096-f3cc-4e62-8a1d-347764ded031"), "Farmington", "there has been some strange sightings of a person who has been taking things from people and making some strange eerie noises and seems to scare people away from the park. People say at night that you can hear walking footsteps coming towards them and suddenly stopping at a few steps away them and then someone touching them and no one is there. Late at night you can here screaming and then laughs so scary that you cannot even image.", "Lions Wilderness Park", "NM", "Ghost" },
                    { new Guid("22c29c56-3b51-440d-8dcf-30e7a063a118"), "Portland", "I went out to lock my car at 11:33 PM on September 2nd and saw a white disk shaped object streak across the northern sky.", "Disk", "OR", "Alien" },
                    { new Guid("22c9b7d8-ced7-4e6b-b933-f67cbd30e4f5"), "US Route 4  one mile West of the Big Apple Diner. Whitehall  NY.", "\"Witness received a text message from a friend at 10pm. He needed vehicle assistance. As he was driving Eastbound  towards Vermont  on US 4  he noticed a \"\"Log\"\" on the side of the road where the white line is. Witness then noticed a second log next to the other. He then realized it was a black haired creature  approximately 6 foot tall  2.5-3 foot wide shoulders. No neck  the hair from the head went down to the shoulders. He only saw the back of the creature  he did not see the face or front. As he approached  he saw it step over a side railing about 3 feet high with little effort and descend into the woods towards a high power line. He had to continue to assist his friend. The next day he contacted a local Whitehall Bigfoot researcher Paul Bartholomew whom visited the site with the witness and took plaster casts of the two footprints on the side of the road.\"", "Report 59838: Motorist sighting at night approx 2 miles from NY/VT state line outside Whitehall", "NY", "Bigfoot" },
                    { new Guid("22d3940d-308c-4955-b391-898bc267a715"), "Fairbanks", "Room 277 - There is a ghost of what is probably a large man. The ghost was active mostly at night. He has been known to push lightly on the bed and poke people on the shoulder. One person had heard something on the floor  like a person running his finger along the carpet. There were other small noises that could not be explained. There was no one staying in the next room that could have made any sounds either.", "Westmark Hotel", "AR", "Ghost" },
                    { new Guid("22e9b3bf-f9b9-423d-870c-5263cd11eed8"), "Quincy", "Padua Hall - The fourth floor of Padua Hall is haunted by a former student that committed suicide by jumping out of the window. The floor was eventually closed down  but reopened earlier this year. People have reported hearing the boy screaming.", "Quincy University", "IL", "Ghost" },
                    { new Guid("23bc6cf9-01dd-4979-923d-a18e3e969ed4"), "Robbinsville", "An apparition of an old woman can be seen at different times of the day  usually during a full moon. Horses can be heard trotting  men fighting& sound of babies crying at several different locations.", "Tuskeegee", "NC", "Ghost" },
                    { new Guid("23c4fc55-a6c1-400e-b944-b897d5a6eeb4"), "Dauphin Island", "In the depths of Shell Mounds  there is a clear circle surrounded by trees. This circle was the ceremony pit for the natives that are buried in this Indian Cemetery. On well-lit nights  you can see the female natives dancing to the sounds of their instruments.", "Shell Mounds", "AL", "Ghost" },
                    { new Guid("23e6bbbc-fce1-4e0f-91e7-9546d3c07b8f"), "Can't remember but I went back there many years later just to see it  was easy to find. Not a big state park.", "\"This happened roughly in 1990  High Point State Park in NJ. Camping with my much-younger siblings. I was about 23  they were about 8 and 9. Camping area was around a small lake. Picture a straight road with a left-hand turnoff to the camping area. Campsites were accessed by a horseshoe-shaped access road that went around the lake. Hillsides sloped up from the far (non-lake) side of the access road. A few folks were camping right near the turn off. We went all the way around the lake to the far side  away from everyone. It was about 20 yards from the access road to the lake -- we put up the tent close to the lake  so about 20 yards from our vehicle.  Made a fire. About dusk  from directly across the lake from where we were camped  up on the hillside there  we heard a long  loud howl. Will describe it later  but my little brother and sister asked what it was. I said  \"\"A moose \"\" knowing full well it wasn't but not really thinking much about it. After it got dark and we were roasting marshmallows  we heard the same sound  now closer to us  to the left. My siblings asked the same question  I gave the same answer. It started to drizzle so we went in the tent to sleep.  Sometime in the middle of the night  after we were all asleep  we were awoken by the same howl  except much closer and much louder than before.  So loud that if I had to yell at my brother and sister I'm not sure they could've made out what I was saying.  Same question  same answer. On the way out of the campground the next day  I asked the ranger on duty if he'd heard \"\"the howling last night.\"\" He sort of laughed and said no. Like an idiot I thought he stayed there overnight  but he could've lived an hour away for all I know. Anyhow  I didn't remember any of this...UNTIL I was watching a \"\"strange creatures\"\" show ion late night cable about 8 years later  and heard a howl supposedly made by a bigfoot. Every hair on my arm stood up -- I remembered everything.  I called my siblings and asked them to play the sound -- found it on the nascent internet somewhere  I think.  They then remembered the noise too and were freaked out  but I don't think they remembered the details as well as I did because they were so young at the time. I've been an outdoorsman all my life and know and have heard every sound made by every known animal in the North American woods. This sound was not like any of those. I describe it as sounding like it was made by a huge man with at least 2x the lung capacity through a PA system. It was that huge  long and loud.  And remember  this was way before this stuff was on TV much and way before the Internet -- I was in no way influenced by that stuff. If I had any clue about it at the time  I wish I'd looked for tracks. It had been raining  and I'd bet that animal was near the truck on what I believe was a dirt road. Ah well. Incidentally  this experience ended up in me producing a novel  \"\"Dark Woods \"\" years later.  It was published but is out of print so this is not a plug!\"", "Report 34572: Man recalls hearing strange howls while camping in High Point State Park", "NJ", "Bigfoot" },
                    { new Guid("241fea4b-ae47-4cc3-b95e-029860427e71"), "Wasilla", "Bright light in the sky like a lighthouse beacon.", "Light", "AK", "Alien" },
                    { new Guid("246ef391-136d-4e59-9d36-625ece60dbcb"), "", "While walking on a road headed toward Bert Reed's historic cabin on the Stanislaus National Forest  the forest suddenly went silent  and then something in the brush screamed at me and the person I was with.  We were unable to see what had made the sound.  We felt like something was watching us  and we both had a terrible fear (but we had both come across bears and other animals in the forest  and never felt this type of fear before).  The fear made us unable to move or speak. After several minutes  the regular forest noises started again  and since we felt better (like we weren't going to die)  we were able to move away from the location.  We continued on to where we were headed  and on the way back  we went by the same location  but nothing was there.", "Report 2311: Two hikers have interesting experience near Strawberry", "CA", "Bigfoot" },
                    { new Guid("24951ec1-001a-467c-9d92-153fa61f645d"), "Parkersburg", "The legend has it that there were 3 men camping on the island. It was about two in the morning when on of the men woke up to the smell of perfume. He woke up the other two men smelling to same smell. They looked around and didn't see anything. They looked to their left one more time and saw Margett Blennerhasset with her infant that was buried on the island as were her other 6 year old daughter. The legend says that at night Margett and her kids walk the island.", "The Blenner Hassett Island", "WV", "Ghost" },
                    { new Guid("24b3f016-7698-49f9-a756-85a787111a1f"), "At Pennsboro  WV follow 74 North for approximately 4 miles.", "\"This took place in the late summer of 2002. I was walking the property next to mine as logging interested me in how it worked and how the land looked afterward. I'd go onto the place after the workers left for the day at 3PM. It was rather hot and plain nasty so I usually headed out after 4 -5 PM. This day they were at the far end of the valley (or \"\"holler\"\" as the locals call it-I'm from CA originally). I was armed as there are wild dogs  bears  and a black panther running round back here.  Walking to the far end there are two smaller branches off to your right  the first is shallow and only extends a few yards. Every time I walked to base of the hill before  I felt like I just didn't want to venture into the woods. I had found another way onto the ridge above on the right a few months before-but I also got pretty badly spooked and kind of stayed away. I had trails and just went wherever-until the loggers hit this patch. The past few weeks before this I had roamed all over the logging trails and as soon as they got back there I began to feel very uneasy. Walking alone  I decided to keep looking around staying extra cautious. This day I went left and followed a trail that took me to the ridge top which is dead center of the valley. I also had a very \"\"something is watching me\"\" feeling so I wasn't what you would call happy  just taking note of where things were and enjoying the view. The trail followed along this ridge and would take me near where I had all the strange feelings. I stopped as the feeling of being watched was getting a bit too much when I heard a tree fall  just on the other side of the ridge not more than about maybe seventy yards away. I was wondered just why in the hell would a tree fall but something told me not to investigate and to get off that hill. I decided to turn around to call it a day. I walked maybe ten yards when something loped between two trees on the ridge to my right. My first thought was some loggers or forestry guys were still on the property. It looked to be wearing Carhart brown clothes. I went maybe twenty more yards and then it hit me: I had been on that ridge a few days before  I knew where those trees were and if  IF it was a man he had to be around seven to eight feet tall. A day or two later I went back to the ridge where I saw the thing and took a good look. I never felt any real strangeness on this side and didn't then  but I did confirm that whatever I saw was very big. I also could swear I saw the right arm and leg but not the head  thinking back it was kind of leaning forward as it walked along so the head was behind the tree when I noticed it.\"", "Report 26279: Logging reveals a brief sighting of a bipedal creature near Pennsboro", "WV", "Bigfoot" },
                    { new Guid("24b76fd3-86c1-4e69-aba4-fa787f6d3b38"), "Monmouth", "Todd Hall- For Halloween they gave a haunted tour of it and explained what has occured there. Apparently when the building was first built it was used as an all girls dorm. The headmistress then  was said to be very protective of her girls. She retired after many years of living and working in Todd Hall. They named the hall after her. On the tour  they said that she has been seen and strange things have occurred there. For example  they once caught a bright light on a surveillience camera. There was no one in the building and it was locked up. Sometimes campus security will get calls that a motion detector of system has been set off  but when they go to check the building out no one is there. There have been other strange occurances as well. It is said that other places on campus have been reported as haunted as well  but Todd hall is the most well known.", "West Oregon University", "OR", "Ghost" },
                    { new Guid("24ecd2fc-0701-47e7-9141-d2482dc22b71"), "Craig", "In 1948 a man fell to his death out of the art room and on to the stage. In the art room the door swings open even when there is no draft.", "Craig middle school/old high school", "CO", "Ghost" },
                    { new Guid("24f23f98-daf4-4c12-aa19-09195efd0095"), "Cody", "Two nuns can be seen floating down the halls  and weird noises are reported.", "Coe medical center", "WY", "Ghost" },
                    { new Guid("250f916e-1c32-4b78-a994-23d3d2235767"), "Jacksonville Beach", "Dark rectangular object with 6 lights flying North toward Atlantic Beach along the coast.", "Rectangle", "FL", "Alien" },
                    { new Guid("25256a95-df1b-4654-9ac1-030df8f94b27"), "Swords Creek", "Reports of an apparition of a young girl with a bonnet on a little bit of hair came down in her face. She had black circles under her eyes and she was really pale.", "Railroad Tracks", "VA", "Ghost" },
                    { new Guid("253e7cc0-f1cf-47f6-927e-0438a72f532a"), "Terrytown", "A large hot dog shape object  glowing red orange  just like the color of an electric stovetop. Object was seen floating above the Cres", "Odd Shape", "LA", "Alien" },
                    { new Guid("2595f480-eea2-4d99-a173-632f8be4703d"), "Pine Bluff", "I saw a light shooting across the sky. It suddenly stopped and then completely changed its trajectory", "Light", "AR", "Alien" },
                    { new Guid("2596237f-bed3-4bb8-b866-a57ed67cf6fe"), "West Warwick", "This is the first Catholic church built in Rhode Island.  The building of it was met with resistance by the local Protestants who were the majority at the time.  The builder and his wife Mary completed the church anyway despite warnings that if the ground was broken for the church  the person who dug the first shovel of earth would lie beneath it.  That unfortunate person was Mary.  It is her spirit who supposedly haunts the church.  Lights have been turned on and off  candles have inexplicably gone out and items have been moved from various areas of the church.  She seems to be a benevolent spirit and the priests at the church accept her as part of the parish.", "St. Mary's Church", "RI", "Ghost" },
                    { new Guid("259af3ee-d74b-48cb-ac92-c036d8ff83b1"), "Cambridge", "A loud noise caught my attention to look out my window to see that there was a large circular shaped object hovering over apt complex", "Circle", "MD", "Alien" },
                    { new Guid("259f56fd-595b-4c39-8f90-ea87414a1792"), "Buffalo", "\"In 1975  it is said that a young boy died in the school pool on the second floor. In English room below  ceiling tiles fall every year describing the word \"\"Help.\"\"\"", "School #61", "NY", "Ghost" },
                    { new Guid("261a3b4c-3cec-4672-be7f-8fcc2efe7067"), "Noble", "Light that streaked across sky stopped and then stopped.", "Light", "OK", "Alien" },
                    { new Guid("26304a5d-1272-4420-a157-88e79086fc51"), "Fort Recovery", "Reports of an apparition of a woman & hear the lady's room door to open and close by itself.", "Homestead- a restaurant", "OH", "Ghost" },
                    { new Guid("26394704-c402-461e-a4ef-2ca440cc0874"), "Salt Lake City", "Doors locking that don't have locks on them  cold spots  as the owner drives away he looks into the rear view mirror and sees lights going on and of all through out the unoccupied house. The mansion is haunted by a little blonde girl  about 11 or 12 years old. She has been seen walking in and out of the big mirror on the west wall. She has been seen walking the rooms and been known to rearrange items and indeed lock doors. People that have seen her say that she look like a young girl depicted in a painting hanging the house. Lights come on at all hours of the night and witnesses have seen footprints that begin and end in the middle of the room.", "The McCune Mansion", "UT", "Ghost" },
                    { new Guid("26818583-6a27-4eb5-a17d-a8491ab23ea4"), "", "This is an old report  but recently after watching the better bigfoot programs on tv  it dawned on me that what we had experienced was a bigfoot. Every September  my husband I would go hiking to see the color.  This trip was in September  1970 to Pikes Peak State Park located on the highest bluff on the Mississippi River in Iowa. September is a time when the kids are back in school.  There was only one other car in the parking lot so the trails were deserted. Pikes Peak had several walking trails.  We decided to take the longest which led to the overlook on the Mississippi.  We had hiked almost to the point of the overlook.  Fall had us crunching on the fallen leaves when we heard a large thump  thump  thump from behind the trees followed by a loud animal scream that we had never experienced before.  Having hiked in the woods almost weekly  we learned to identify most of the animal sounds around us.  This was not an identifiable animal. The screech scared us so badly that we immediately turned around and ran as fast as we could all the way back to the rangers station.  Having reached the station we immediately inquired about the animal we had encountered.  We explained in great detail what had happened  but the rangers said they had no clue what we had encountered and that nothing similar had ever been reported. To this day I am still haunted by the sound of the footsteps and the screech.  Until the bigfoot programs I had never considered that what we had encountered could be a bigfoot.  Now I'm 90% sure of my identification. I also noticed that there were no other sightings in the same area.  Perhaps we were just at the right time and the right place  but I know what we experienced. Although late  previously I was unaware of any reporting sites to relay our experience. I am excited to hear your thoughts.", "Report 44740: Memory told of being chased off by frightening thumps and scream while hiking in Pikes Peak State Park", "IA", "Bigfoot" },
                    { new Guid("268b725e-96f9-456f-80a2-053427012245"), "Garnet", "There is a full ghost town up in the hills of Montana that was originally created as a mining town. After a fire caught hold of the hotel there  many people started moving out. The houses and buildings have been wonderfully preserved and the original hotel that caught fire still stands and with little damage. Spirits can be felt all in this town and especially in the hotel on the second floor. If you go up the stairs  walk straight towards the wall without turning  and then look to your left  the open door there is where one of the spirits resides. Beware  though  because he's not nice. It's a great place if you want a sensory overload. If you can't find it... it's on the state map. It's worth going to see.", "Garnet Ghost Town", "MT", "Ghost" },
                    { new Guid("2704e751-8f5c-4ac2-ac5d-5884a7a01ce3"), "St. Albans Bay", "There have been sightings of a ghost ship floating about in this bay. Witnesses have even claimed that ghostly pirates on the ship will yell out to the fishermen. Legend states that they are trying to capture a creature once believed to inhabit the bay  known as Champ.", "St. Albans Bay Park", "VT", "Ghost" },
                    { new Guid("274922fb-903d-4af1-9dd5-433c9e999790"), "Sheridan", "a male in black cloths running between the trees and sitting on a bench on far side of park", "Sheridan city park", "OR", "Ghost" },
                    { new Guid("278d9e32-3334-4b62-8edb-c9a1949ce5f5"), "Dodge City", "(Now Soul Intermediate Center) - An old high school built in the 1800's. The true nature of the haunting has been lost in legend and lies  but one thing still holds true  there are ghosts in the halls in the basement of the school and the library. Several spirits reside within the school  not all of them friendly. There are several passageways that have been blocked off underground the school  legend says a young man was exploring down there after hours  knocked himself out and died shortly there after. Workers were tearing down the set. One of the tear down procedures was two or three of them would walk around the school and take down the flyers promoting the play. they descended to the lowest level where the basement hallways connect with the commons area and the library. While walking into an unlit area they heard the door to the library open and slam and then a laugh. They all sprinted towards the doors  only to find them locked with no one in sight and no one in the library. All of a sudden one of the other people came around the corner  the flyer had been ripper from her hand and torn twice. Now the halls have been revamped and children attend school there  but time will only tell if that has scared away the ghosts of Dodge City Senior High School.", "Old Dodge City High School", "KS", "Ghost" },
                    { new Guid("27b21a45-138a-4d29-a533-914669581a69"), "Lyons", "Flash in the southern sky  according to others this was similar to the night of the meteor just off the east coast  except of course th", "Light", "GA", "Alien" },
                    { new Guid("27d87c55-0320-4a31-8600-a5bc6d3e01cb"), "Greenville", "Back in the 70's The Greenville Inn was owned and operated by Mr. and Mrs. Frank Ducharme. After Mr. Ducharme passed away and Mrs. Ducharme became ill  the Inn was sold. There are reports that Mr. Ducharme haunts the place. There was a write up in the Monadnock Ledger in Jaffrey  N.H. about this.", "The Greenville Inn", "NH", "Ghost" },
                    { new Guid("28240cab-b4bd-4a97-9873-2046887e965b"), "Geneva", "Enormous Cigar shaped craft  no wings  no windows  no sound  incredible rate of speed  over Lake Erie  in Ohio  chased by helicopter.", "Cigar Shape", "OH", "Alien" },
                    { new Guid("283e64c1-45fa-4859-8f5a-4d6cb954fcef"), "Hinesburg", "Aircraft engine noises were heard in the woods behind my house on 11\\8\\99. This noise was heard for a period of approx 2 minutes  at t", "Unknown Shape", "VT", "Alien" },
                    { new Guid("2872ea8a-facc-4cb7-8689-38bb2b43b953"), "Ansonia", "Strange sounds have been heard. Feelings of not being alone. A grandfather clock that dates back many years will start to chime every 15 minutes. Chains being dragged across an upstairs floor  as well as voices  coughing and laughter have all been heard by witnesses that where alone in the building.", "Webster House Company #3", "CT", "Ghost" },
                    { new Guid("28900b41-3dcd-40de-82f6-3a021c395bc5"), "Belmont", "\"The cigar shaped craft was hovering in the southwestern sky fairly close to the ground. There were lights on it. There was a bright \"\"\"", "Cigar Shape", "VT", "Alien" },
                    { new Guid("28f595db-b9f7-463a-829c-c83694c3b8db"), "Quinton/Bridgeton", "The true story of Berry’s' Chapel is  Berry was a black pastor hung by the KKK. The chapel was built back in the Civil war days. It burned down in the early sixties. The grave yard was starting to get desecrated from local kids parting in the area  and skulls started appearing in trees by the main party spot.. It was then the county moved all the bodies to the graveyard surrounding the ancient oak tree near the Salem City public library. The area is blocked off now and you can't drive back there. The Chapel was just in the paper again this week (05-27-02) as they were again cleaning up the area from those lame people who feel they have to dump all their trash back there. What was always odd is how nothing would ever grow on Berry’s' grave. No grass  no weeds  no bushes  nothing.", "Berry’s Chapel", "NJ", "Ghost" },
                    { new Guid("29a460b2-a3b4-452a-89ba-88cd643a052e"), "Flagstaff", "A meteor-like object  trailing burning debris  changed into a blinking point of light. It then made a gentle turn to the north and gra", "Fireball", "AZ", "Alien" },
                    { new Guid("2a2c4b75-dd38-4446-914e-32a2b2846ed0"), "Doyline", "Twenty Seven Years ago...Four Doyline High School Teenagers were riding back from the local homecoming dance. They were drunk and ran straight into a Pine Tree. A cross was placed right in front of the tree where they wrecked. Every Homecoming Night...Blood runs from the tree to the cross...but now that someone stole the cross....the blood runs up the tree...they say you can hear the two girls weeping...in the tree", "Potter Road", "LA", "Ghost" },
                    { new Guid("2a77a556-0933-45f4-8dce-51b3caf6468b"), "Makaha", "at night  there are children walking and playing around the site of the pool  where they have died. You can feel them by your side and hear footsteps behind you when you're there a night", "Makaha Shereton golf club", "HI", "Ghost" },
                    { new Guid("2a7e305e-b129-4ec5-9284-a9f00ca64d1e"), "Carson City", "Abe Curry still returns looking for his wife.", "Curry House", "NV", "Ghost" },
                    { new Guid("2a9e4007-1aa3-4ba6-8716-5de1faa644c2"), "", "Went camping at Lake Jeanette in the Superior National Forest in Minnesota. First night we were there we heard wood knocking. Knocked back and got three distinctive and separate responses. As we started to go to bed we heard a whooping noise. The next day we hiked out into the area which the sounds came from; no camps  nothing out there. After a long day of hiking and and swimming we went back to camp  ate dinner  and that night we started the knocks. Again we hear three responses. One of the three got closer and closer after each time we responded back. My friend got creeped out and we left the woods and sat at our camp site. As we are sitting by out fire we both saw a set of eyes staring at us. Neither one of us said anything about the eyes to the other until we were on our way home. We decided to go back into the woods for one last time and as we did something very close to us made a loud grunt. I've hunted since I was 12  I have heard bears  moose and everything else that would be in the woods of Minnesota and I have no idea what this was. We took down our tent and left within 20 minutes of this grunt. I don't know what was there but we both felt like it didn't want us there.", "Report 42295: Possible encounter makes campers leave Lake Jeanette campground near Orr", "MN", "Bigfoot" },
                    { new Guid("2b3df370-83ec-4b68-a9bf-318f3fc9315c"), "Gorham", "The Robie-Andrews Dorm -  Local documentation indicates that on the fourth floor of this building there was a suicide or murder in the early part of the 20th century when it was still an all-women's learning center. Students have seen the ghost on several occasions. The fourth floor also exhibits inexplicable cold spots and mild poltergeist activity. Students constantly hear footsteps moving around above them in a vacant attic. A student who lives near the attic stairwell said she felt someone grabbing her arm and her room seems to always be cold. According to legend there are 5 spirits in the building. One of which (the most active) was a female college student who lived in the 1800's. She committed suicide after her boyfriend left her when he found out she was pregnant.", "University of Southern Maine", "ME", "Ghost" },
                    { new Guid("2baa2904-b205-4df0-b462-fa53b18be219"), "Osterville", "I saw this flashing light in the north east horizon that was flashing in and out and darting across the sky.", "Light", "MA", "Alien" },
                    { new Guid("2be40403-0702-4464-9a40-73cfb1172eea"), "Upper Marlboro", "Jelly bean Shaped object flying erratically for about three hours in the sky.", "Oval", "MD", "Alien" },
                    { new Guid("2c7bd856-efb1-422a-a3f6-328f049726f7"), "Burnsville", "Two star like objects accelerate and fade one after the other.", "Light", "MN", "Alien" },
                    { new Guid("2cc91e1d-fe1c-495a-b1ba-dc74541c4db1"), "St. Albans City", "St. Albans - Reports of being tapped and apparitions seen.", "Bellows Free Academy", "VT", "Ghost" },
                    { new Guid("2cd9c2bf-b67a-408d-920e-f38d498d5cfa"), "Garland", "Some have reported seeing people in the windows  and if one enters the house  boards fall and almost hit any intruders. There is an old car at the house that says “I will kill you” on it. If you knock on the door you hear a return knock.", "Old Garland Movie Theater", "NE", "Ghost" },
                    { new Guid("2eb5b721-f795-4f84-9f48-49dde8c48167"), "Trenton", "Several have been just sitting and I think they are communicating to each other with their blinking", "Circle", "NJ", "Alien" },
                    { new Guid("2ede0380-b999-4951-b288-1d5476ede6ff"), "Papillion", "There were lights moving weird on the horizon. When my brother and I get home we see a tik tak shaped object hovering over our house.", "Cylinder", "NE", "Alien" },
                    { new Guid("2edf430a-4e93-4db1-8020-92ed3ffa5808"), "Eagle Harbor", "people claim they have seen a woman walking the porch looking out to the lake as if she is looking for her long lost husband who was lost in the lake in a freighter crash  the light house has had everything to lights flickering on and off to hearing voices  and apparitions.", "Lake Breeze Inn and light house", "MI", "Ghost" },
                    { new Guid("2f304cc6-fa1a-40ac-8999-538106e961d2"), "Sidney", "The Old Fort Sidney Commanders Home is haunted by the spirit of a woman. She was the wife of a commander back in the earlier 1900's. One day while in a hurry  she took the steep maids staircase. She tripped and fell to her death. Some say she can still be seen roaming through the house. An actual picture of the ghost can be seen in a Nebraska published magazine called the Scriviner.", "Old Fort Sidney Commanders Home", "NE", "Ghost" },
                    { new Guid("2f48ea41-62bb-4448-8647-f48827dad1f0"), "St. Joseph", "Benedicta Arts Center - The ghost who died during the construction of the building is named Steve. He has been know to shatter lights during performances and people have run into something solid when there's nothing there.", "College of St. Benedict", "MN", "Ghost" },
                    { new Guid("2f925d2e-a154-46cb-8323-009ae8c4caa5"), "Mechanicville", "The ghost of Richard Thomas Thompson is said to roam this homestead. He was killed in a fire in 2003 and often leaves beer bottles in places nobody ever had them in.", "Rich Thompson Homestead", "NY", "Ghost" },
                    { new Guid("2f9dfb2c-d2fe-4b06-a8c8-99ccf36223ef"), "Storey", "Gold Hill Hotel - Hatel is haunted by several apparitions who appear on second floor hallway and bathroom. Hotel is renowned locally as a haven for supernatural occurrences  and many people have seen strange thing while staying there.", "Gold Hill", "NV", "Ghost" },
                    { new Guid("2faaaa78-c122-4f95-a087-07e780997c4c"), "Lily Dale", "many people have reported seeing a man  with a full beard and glasses  dressed in Victorian garb  walking across the podium there.", "Assembly Hall", "NY", "Ghost" },
                    { new Guid("2ff53645-b47d-4d5c-b543-bb00ea0201a9"), "Mount Vernon", "On the top of a hill stands an old white house which has been abandoned for many years. The house was once a stop on the underground railroad. The house is now being remodeled  according to rumor  into a bed and breakfast. It sits on the corner of Mill and 9th. Local lore says that the house is very haunted  but no one really knows by who/what or why.", "Robin Hill", "IN", "Ghost" },
                    { new Guid("302cc49f-4faa-429b-aa6d-92891933fda4"), "Pine Bush", "There was a very large object with bright yellow lights going across  it was moving slowly for about 7 seconds  then vanished.", "Odd Shape", "NY", "Alien" },
                    { new Guid("302d621f-918f-411a-9d6a-5306607d19c8"), "Philadelphia", "I noticed the large object  glowing orange. It was motionless soundless  I looked to identify but unsuccessfully. It did not move.", "Disk", "PA", "Alien" },
                    { new Guid("303144c1-3160-414c-a109-f29e3c035bdf"), "Minneapolis", "While driving in a residential area a noticed blinking lights that stayed in the same spot.", "Circle", "MN", "Alien" },
                    { new Guid("30c96cb0-9a5b-433d-a6fb-88860c1d48dc"), "Rindge", "The Manor - At the turn of the century  what most know today as The Manor  was previously a brothel run by a woman named Edna McGuinness. McGuinness hung a large portrait of herself in the stairwell leading to the second floor. When McGuinness passed away the building was sold but the portrait was never taken down. During the late 1990's an employee of the college was cleaning the manor after a banquet and heard a piano playing. However  there had not been a piano in The Manor for many years. The employee went searching for the noise and didnt come across anything unusual until she walked by the stairwell and saw the apparition of a woman holding a baby in her right hand walking down the stairs. The woman was wearing a glowing dress and humming. To this day students and faculity members have seen and heard very strange things in and around The Manor. Some say McGuinness can be seen looking out the 2nd story window towards Pearly Pond.", "Franklin Pierce College", "NH", "Ghost" },
                    { new Guid("30e6892d-1876-4574-8ea9-7f4a1a1b1f95"), "Kingsford", "\"Everyone in town knows that this area was hit hard during the depression  and a hobo town was located where K-Mart is now. Well the legend goes that a homeless guy was trying to hitchhike on Pine Mountain Road up to Marquette for work and was hit by a truck. The driver left his body there for someone else to find and by the time someone found him his body was too mutilated and decomposed to identify. Many people report seeing a man after midnight with a long white beard in 20's era clothes trying to flag them down. His eyes are big and white  almost like he's scared. If you happen to see  \"\"The Hitch\"\" as we call it he disappears when you look back where he was standing.\"", "Pine Mountain Road", "MI", "Ghost" },
                    { new Guid("30f9742d-5a28-4ebf-9652-57ad7f0cae50"), "Genoa", "At night the current owner of the restaurant turns off the lights  but on some nights after she leaves and locks up  the lights turn back on. People have heard footsteps from the basement stairs  and dishes have mysteriously disappeared. The man who they assume is the spirit of the ghost used to be the owner of the restaurant  and he used to drink 8 cups of coffee a day. That is the number of cups that have been missing. He also used to watch CNN all the time  and no one was allowed to change the station on the television. When the workers walk out of the room with a certain channel on the TV  they come back only to see CNN on the screen. No one that works there watches that. If the ghost is the spirit of the old owner  his name is Kenny.", "Big River Restaurant", "WI", "Ghost" },
                    { new Guid("31508f62-9526-48b0-bf80-222b7f69a7df"), "Gig Harbor", "I looked up to the sky seeing a bunch of “stars”  when I shortly realized they were moving  changing formation  and changing colors.", "Triangle", "WA", "Alien" },
                    { new Guid("3155c68e-73f2-4017-82be-bc0cb0234e1c"), "Tarkio", "People have seen mop buckets roll down the hall on their own. Some people have heard scratching coming out of a janitors closet.", "Rankin Hall", "MO", "Ghost" },
                    { new Guid("31640b3f-8df4-4425-981b-c026fed21473"), "Pensacola", "The Gray House on Alcaniz Street  which faces the Dorr House across Seville Square is said to be haunted. The ghost of a sea captain named Thomas Moristo who lived there in the 1700s is believed to still reside there. When the home is vacant  a man has been seen peering through the windows. Many people who have lived there have reported that they will turn on the stove  go upstairs  then come down and find the stove turned off. On one incidence  a resident was painting the house and left the paint inside the front foyer. The next morning he found all the paint had been moved outside. - The house was once in a bad fire  and it is believed the ghost does these things attempting to prevent another fire. Many people have become too frightened and refused to live in this house  and some residences have claimed to see apparitions of the old man while inside the house.", "House on Alcaniz Street", "FL", "Ghost" },
                    { new Guid("31c12b0c-8bdb-4dc9-ae24-d9bc5fd37b40"), "At the time it was called John J. Audibon Historical Trail. It was on a county road in a forest.", "While laying down and preparing to go to sleep we heard foot prints coming our way from within the woods. Not knowing what it was I grabbed a handful of chat from the ground and threw it in the direction of the steps. The creature took a number of steps back into the woods. Then it stopped and started coming back towards us. It was a two legged creature. You could tell it was walking on two legs. At that point we both got up and ran to the car. We then drove back and forth returning to gather what we could off of the ground and we left the area. At this point we drove back to the highway and to a roadside park where we spent the rest of the night in the car. The next morning we went back  restarted our fire from the night before  I prepared breakfast  eggs and bacon. After cleaning up the dishes we began walking the trail [ Mark Twain National Forest ]. Approximately 1 mile in we stopped at a spring I knew about to get a drink and fill our canteens and continue down the trail which followed a creek. After walking another mile or so I heard a noise coming from our right  I looked to my right and then I saw it. Up the wooded hill I saw a reddish long haired man type of creature  approximately 7-8 foot tall running through the woods. I was able to see it for around 5 steps before it cleared the top of the hill and disappeared. At this point I turned to the girl I was with and asked her if she saw it. She said no but at this point I was ready to go and she didn't argue with me and we walked back down the trail to her car and we left. I got no argument from her. She was with me the night before when we heard it outside our camp. I was dating another girl who I eventually married  the girl I was with was not her. I was a JR in high school at the time.", "Report 62297: Two young campers get stalked at night  then a Sasquatch sighting the next morning near John J. Audubon Historic Trail in Mark Twain National Forest", "MO", "Bigfoot" },
                    { new Guid("32056bd8-55d9-4e82-9579-baafaa1830d1"), "McMinnville", "Cold spots in the women's bathroom by one of the entrance doors to the theater. Feeling of being watched. Feelings there aren't scary just a little uneasy.", "MACK Theater", "OR", "Ghost" },
                    { new Guid("3212a268-cb47-4997-aee4-4297acc4b854"), "Take highway 22 west from Salem following signs to Lincoln City  you will end up on highway 18  traveling through the Van Duzen Corridor  take a left onto Slick Rock Creek Road  which becomes Boulder Creek. Travel east on Boulder (becomes logging road  so it goes different directions) continue on the main road for about 2-3 miles and the road splits  take the right split  continue on the main road for another 3-4 miles and the road splits again take the left split  continue on the main road 2-3 miles till comes to another road like a 3-way intersection take the right turn  continue till there is a road on the left (aprox. 1/2 mile) that almost doubles back up the hill  take the first right (aprox. 1/32-1/16 mile)  continue on the main road (this is a narrow road  there is another road that cuts back to the west just after turning on this one  but continue straight on the main road). The sighting occured about 1/2-1/3 miles in.", "While sitting in the Blazer (with 3 other females ranging in age from 13-34 all of which were sleeping) that was broken down waiting for help to return I noticed on the east side that there seemed to be something peeking out from a tree aprox. 20' into the woods. I was thinking that it could have been a trick of lighting and the wind moving some branches as the only time I seemed to be seeing movement was when I was looking straight ahead to the north the direction the Blazer was headed and this was out of the corner of my right eye to the east and every time I would move my head to the right it would stop. I played this game for a while  but decided that if I was really seeing something  that I was going to have to turn my head to the right. I dozed off for a while and when I awoke I was still looking off to the right (east) and there was something peeking around a tree that was closer more like 15' or so  so I just kept my eyes on the object and was able to make out!that it was tall  hairy  light coloring in the face except for the eye and mouth area. It didn't move but just like a shifting of feet once in a while. It didn't advance any more  but seemed intent on watching what was going on or in seeing just what it was that it was looking at. I couldn't smell anything as the wind was blowing to the east. I didn't awake anyone because I didn't want to scare them. I didn't feel threatened  but I wasn't going to go and check it out either. At 3:30 help arrived and so I concentrated on what needed to be done to get the broken-down rig off the hill.", "Report 1224: Possible movement and footsteps heard by women waiting in stranded vehicle", "OR", "Bigfoot" },
                    { new Guid("32600232-5586-4590-a40e-0d8dff323810"), "New Boston", "Hovering light with flashing blue and red; movement was irratic and non-airplane like. Appeared as large (moving) star. Another small", "Light", "NH", "Alien" },
                    { new Guid("335fa1fa-6f9b-44c1-9c69-687e671fd0ff"), "Lewis County", "A small cemetery in the middle of nowhere  when entering the cemetery a light in the church will turn on  and if you walk through the center of it  you will be followed by something. the footsteps get louder and faster but don’t run  if you run and you are caught  legend has it that you will never escape the East Fork Cemetery.....", "East Fork Cemetery", "KY", "Ghost" },
                    { new Guid("337f8d89-f594-47e1-959a-dacf7f836b69"), "Danbury", "Fairfield Hall -  3rd floor haunted by soul of young girl who had committed suicide in the tower on the top of the hall. She is know for apparitions in windows n mirrors.... running showers and showing up in photographs. She is known for making mirrors become never ending ...and making screaming sounds all through the night...is she waiting to be let free...or is she just haunting the students who live there.", "Western Connecticut State University", "CT", "Ghost" },
                    { new Guid("33c0149c-7d10-440a-bc17-73cb47afc80c"), "St. Joseph", "A guy fell from the loft while it was being built  and died. People see a tall  shadowy figure walking around.", "Benedicta Arts Center at College of St. Benedict's.", "MN", "Ghost" },
                    { new Guid("34ca190b-bcaa-400b-b370-75fc0b3d21b1"), "Elkmont", "Low level  cloaked  morphed  silent  incredible.", "Changing Shape", "AL", "Alien" },
                    { new Guid("34ddf18d-ef20-4aef-a0e3-2a4acbbd29a4"), "Salt Lake City", "Reports of 5 Ghosts in this Building. Two Children  a brother and sister who were killed during the building of the structure. A woman who is believed to be the mother of Children. A Pioneer Judge and an old Mayor of Salt Lake. The Building is 5 floors and the Ghosts haunt all floors.", "City County Building", "UT", "Ghost" },
                    { new Guid("350a0e3d-4abe-45f9-bbbf-941e5c0840d4"), "Missoula", "It was super fast looked small but surrounded by a blue like flame around it. Was going so fast and just blinked out.", "Cigar Shape", "MT", "Alien" },
                    { new Guid("351f3fee-4d8b-4f94-a66a-21c48e918648"), "Specific instructions omitted for privacy reasons.", "\"When my aunt was about 11 or 12 years old  she was helping her older cousin (Jerry) in the field at her aunt's house in an area called \"\"Screamer\"\" in Henry County  Alabama.  It was a hot day  and after some time Jerry grew very thirsty and asked my aunt to walk up the road to the house and get him a glass of water.  My aunt then walked through the field back toward the dirt road leading to her aunt's house.  Upon reaching the dirt road  she saw two creatures standing on the other side of the road.  She stopped and began slowly backing up  then stopped again.  She stood there looking at them  and they looking at her  for a minute or so  long enough for her to get a good look at them.  They were only around 10 feet away from her at that point - she on one side of the dirt road and they on the other.  She described them as standing next to each other.  One was  in her estimation  around 5 feet tall and the other was slightly shorter  around 4 feet tall.  She said that she got the impression that they were young.  She said that they were \"\"real hairy\"\" and completely covered in dark brownish black hair  that they looked sort of like gorillas but with human looking faces with hair on them  human looking hands  and human looking feet.  She said their noses were free of hair and that the color of their noses was dark brown or black  as were their feet and hands.  They stood very still other than blinking  just looking at her.  Except for being covered in thick hair  their faces looked human with regular human-looking noses.  After a minute or so  she took off running as fast as she could back up to the house to get the water Jerry had requested.  She did not look back as she ran.  She got the water  and proceeded to walk back toward the field.  The creatures were not there anymore.  She never told anyone about this incident until just a couple of months ago because she was always afraid people would make fun of her.\"", "Report 44986: Memory told of a close up daylight encounter with two  possibly young  Bigfoots near Abbeville", "AL", "Bigfoot" },
                    { new Guid("3545be65-004e-47b1-996a-94c6118b766c"), "Lewiston", "Several years ago two girls were murdered in the theatre which used to be a church. Also that night the janitor disappeared and they still can't find him to this day. At night you can see the youngest girl climb up the stairs. She will also play tricks on you. There is also a phantasm there of a woman who was left at the altar when it was a church. You can see her roam through the seats crying. Also one of the old directors who passed away will sometimes come in late at night and sit down to watch a play. Strange feeling can be felt all around. September 2004 addition: there are  at any given time  no less than 70 spirits in the theatre. There's a trap door in the light booth that goes up to the rafters that has opened on its own. Lights turn on and off on their own. The chandelier spins in one direction for ten minutes  stops for five  and starts spinning is the same direction. Visitors lit candles on stage. Some blew out on their own. The ones that didn't blow out didn't burn when you put your hand in the flame. There was wailing that started from stage right and moved inhumanly fast to stage left. Floorboards move inexplicably. All the spirits there are harmless  of course  but it's still an exhilerating experience.", "Lewiston Civic Theatre", "ID", "Ghost" },
                    { new Guid("35593af8-4de4-43ab-982e-663d9b310c55"), "Boulder", "It's been rumored that ghosts have been sighted walking around the courthouse grounds at night. These ghosts are said to have been the hanging victims of the death sentences carried out in the 1800's.", "Court House", "AL", "Ghost" },
                    { new Guid("356ef076-f683-4f19-b1cd-d93d47c69c36"), "Bogue Chitto", "Something has been reported there that has the body of a four-legged animal  but a head that appears to be like a man's. It apparently has glowing red eyes  and it is about the same size as a goat.", "Myers Creek", "MS", "Ghost" },
                    { new Guid("35da0e1c-b124-4418-8172-69a8f1be316a"), "Iva", "if you pass the cemetery on foot at sun down and look behind you. you can see an old man and then you look back and he is gone.", "Iva cemetery", "SC", "Ghost" },
                    { new Guid("3647e02a-5ae8-44af-bfce-78002761d0da"), "Roseburg", "You can hear people running up and down the stairs and doors opening and closing. You can hear people talking. Papers get thrown all over the floor. The lights go on after being turned off. Two people were seen running out of the bank chasing after some people walking down the street  even though the doors were shut and locked. A dog can be heard barking inside the bank. In the bathroom of the top floor a woman was seen wearing a 1920's style outfit and she's been seen and heard flushing the toilets. Loud noises can be heard like there's a room full of people talking and then is gets really silent. A man was seen walking inside the bank and then just disappeared. The bottom of the elevator always glows bright red and doesn’t work right. Almost every night after all the lights have been turned off and the doors have been locked a light on the top floor goes on and a man is seen staring out the window.", "Downtown Umpqua Bank on Main Street", "OR", "Ghost" },
                    { new Guid("368bbfb0-84ed-435d-b366-6bd1a0cb6b8e"), "Abingdon", "\"The ghost of a young woman haunts the inn believed looking for her lover. Sightings are so common/reliable that they at one time charged extra for her \"\"favorite\"\" room. The workers are very helpful and acknowledged the sightings. no matter how many times they put down new carpet  blood stains reappear from old soldiers who were wounded during the war.\"", "Martha Washington Inn", "VA", "Ghost" },
                    { new Guid("36a7a859-cf86-4baf-abdf-768f59d827b9"), "Ravine at entrance to Hafer Park  at 9th and Bryant.  The ravine runs parallell to Bryant. From I-35  take Edmond Road (2nd St) west to Bryant  then south on Bryant to 9th.  This is the entrance to Hafer Park.", "\"Winter  1982: On this occasion  there had been a big snowstorm  and nothing was moving on the streets.  There weren't even any tire tracks.  I was about fifteen years old  and worked at a fast-food restaurant about a mile north of this location  and was forced to walk home because my father had called and told me that conditions were so bad he couldn't get the car out of the drive.  The heavy blanket of snow made visibility good  reflecting light as it does.  As I cleared some trees to the east  I observed movement to my left through peripheral vision  and looked to my left into the ravine  and saw a figure apparently playing in the snow. For an instant  I thought that it was a child wearing a dark colored snow suit  but as the moment passed  I became very aware that this was no child.  I had a very clear view of it  and could see that it was black  or very close to black  and covered with long hair or fur from head to toe.  It was probably around five feet tall  and weighed about 160lbs. The creature continued playing in the snow  bending over at the waist  and throwing snow up into the air with both hands in a wide scooping motion  throwing it up so that it came back down on its head.  It also began rolling in the snow. I felt stark terror at the sight of the thing.  I was also very unnerved knowing that I was very far from any residential area  in the early morning  and that there was absolutely no traffic on the road. The creature was only about thirty to thirty-five yards from me  and I had about an eighth of a mile to clear until I was out of sight of the creature.  I thought about running  but I feared that my footfall and rapid motion would catch the thing's attention and that it would then begin chasing me as is instinctive for a lot of animals. The point is  I had quite a bit of time to view this thing  and the longer I looked at it  the more I realized that what I was looking at did not fit any rational explanation.  Once I was out of sight  and I thought I was out of earshot  I ran as fast and as far as I could. This area is now a park  Hafer Park  but at the time  nothing was there but a wooded area and the ravine  which is a drainage ditch.  Even now  with the park  there is still a good deal of wooded area there. David A. Farris  author of \"\"Mysterious Oklahoma \"\" says that locals have dubbed this creature the \"\"skunkape \"\" reportedly because of its terrible odor.  I did not smell anything in this incident  but I have a very poor sense of smell and serious sinus and allergy problems which are routinely exasperated by the cold weather.\"", "Report 4081: Early morning sighting of young sasquatch in snow", "OK", "Bigfoot" },
                    { new Guid("36b17ecb-cc4b-4f57-8fde-9627c297219f"), "Kauai", "Once upon a time in the 1990 there was a place in  Kauai Lihue  there now its called  Chief's Kamakahella Middle School  but befor that was a train track one day when a train passed there have been reports about a lady in white waiting for the train. Before that was a woman she would always wait for the train until one day the lady accidentally went on the track so out of no were the train ran over her. and at that school every night she waits for the bus.", "Lihue", "HI", "Ghost" },
                    { new Guid("3718406e-5f1a-4d2e-abdb-4b382a76a4fc"), "Fort Belvoir", "Saw three lights in a triangular shape flying from the east to west. It moved as one unit passing by within moments. A plane was in t", "Formation", "VA", "Alien" },
                    { new Guid("371a099b-c8e7-4e6e-a0b8-abcec02ae839"), "Butterfield Canyon Road below Kennicott Copper Mine", "When I was a child before bigfoot was known to me  we went on a family camping trip in Butterfield Canyon in the Oquirrh mountains below Kennecott Copper Mine. There were six people there. Two adults and four children. The tent was pitched by the creek next to a trail. Tent was tall enough to give the adults a couple feet of head room. When we were in the tent getting ready to make our beds (it was thundering with alot of lightning) we smelled the worse smell. It made our eyes water and our noses run  it was that bad. Next we could hear a large animal coming up to the tent. It was screaming and yelling. When it got to the tent it stood over the top of the tent. Our bodies were vibrating from the screams  our noses and eyes were running from the smell. When the lightning would go off we could see the shadow of long hair hanging down from massive arms. This thing towered over the tent as we were all ready to die from the fear. The adult male that was with us went out of the tent to do something. We had never heard of Bigfoot and he wanted to protect us. When he came back in the tent (after we heard scuffling and growling outside) he sat down with his back on the tent's zipper. His face was white and his eyes were huge with fear. First bit of daylight he had us packed and out of there. Years later he told my granddaughter that he confronted Bigfoot that night and could never get over it. He would never tell us that was there  what he saw. We knew it had to be nine feet tall at least to hover over the tent. There are three witness left that cant get over it.", "Report 38797: Woman recalls childhood experience of a terrifying night-time encounter while camping near Kennecott Copper mine", "UT", "Bigfoot" },
                    { new Guid("37471fd6-4a4c-42e0-bb38-398d9ca069d2"), "", "Was fishing at Ottowa county lake near Bennington happened to look over to the south by the dam and saw a huge upright creature towering above the tall grass it was right next to a tree the lowest branches on that particular tree are about 10 ft from the ground the head was right below that branch  I saw the head and shoulders of it my name is James I'm in the military and I know i saw a bigfoot.", "Report 32256: Soldier on leave has a daylight sighting while fishing near Bennington", "KS", "Bigfoot" },
                    { new Guid("3751d682-01da-4803-9c89-9fd8a18ca48c"), "Approximately 4 mi north of Rochford  at Carsten’s Cottages", "I was visiting my family’s former home and treated myself with a night’s stay at the cottages. They lie along the road running through from Deadwood to Rochford. The campground was empty save for me  even the proprietor was not home. They have beautiful pastures and a huge assortment of farm life - from turkeys to quail to goats and llamas donkeys and horses.  Their fields run right up to the forest  probably not even a football fields length away. I was sitting outside watching their antics and enjoying the evening air.  Suddenly  something started to howl in the woods to the west. Everything alive on the place froze in that same moment and all of their heads - mine included- swiveled toward the sound. I cannot begin to describe it  but I had grown up in these hills and know it was nothing I could identify.  The sound was somewhere between a howl and a scream and just echoed. It went on for 3-5 minutes  and every creature stopped to listen. I didn’t hear it again while there. I didn’t tell the proprietor when I saw him next. Since then  I’ve listened to recordings to try and identify the sound and the recent recording by the hunter out of Canada is an exact match. That’s what impelled me to report it.", "Report 65588: Possible howls heard 4 miles north of Rochford in middle of Black Hills", "SD", "Bigfoot" },
                    { new Guid("37e7b3a2-d420-4509-ba3e-a231d1f5d7e7"), "Fargo", "Fuzzy orange oval shaped craft  emitted four beams of light for 3-5 seconds.", "Oval", "ND", "Alien" },
                    { new Guid("37ee0f0b-5de2-478f-93d2-b30e8d4bf02b"), "Cornell", "\"The small city library in Cornell is a location that triggers unease in most any one that enters it. As far as the history of the building  the basement  where the restroom is  used to be a jail during the earlier duration of Cornell's existace. The entire building has a heavy sort of a feeling to it  but it is the basement in particular that makes all who step down there to visit the restroom uneasy. Some librarians working there would not go down to the basement to the restroom the entire time they worked there because of the uncomfortable feeling that overwhelms visitors to the basement. The entire basement area has had virtually no remodeling and is for lack of better description \"\"rugged\"\". To my knowledge there has been no sightings of any kind  just the feeling of an overbearing presence of some kind.\"", "Cornell City Library at 117N 3rd", "WI", "Ghost" },
                    { new Guid("380c9b38-8a6c-464b-8973-0b216cd7ad2b"), "Chesapeake", "Small gray or silver in color  cylinder shape  made no sound.", "Cylinder", "VA", "Alien" },
                    { new Guid("380cf5cb-a363-44c3-bf02-829007efe925"), "", "\"This story that you are about to read has a lot of similarities to some stories you might have already read. It was in August of 1977. It happened on a hunting expedition in Farmington Canyon  Utah. There were four in the hunting party. Everyone was away from camp hunting. There are two lakes where this occurred. The sun began to go down to set. It was an archery hunt so normally you would sit wherever you were because that's when the deer or the elk come out. Every hunter's hopes are that he is going to see something before it gets dark. On this particular evening  nothing seemed to come out from the landscape. So I proceeded to move slowly back down the trail towards camp  which was set up just below the lakes. It was to dark now to see any of my other hunting companions. No moon was in the sky  just stars. I had positioned my self above the upper lake. I knew the area quite well. As I proceeded to go back  I had to cross a little creek that came out through a marsh below the upper lake. But being that it was dark  I couldn't really see the trail. But I could hear the water gurgling in front of me. As I came to this spot in the trail I new I had to make the right moves or I would end up in the water. I sat there trying to adjust my eyes to see where to make the next step. While I was standing there for a few seconds  I started to hear a low growling noise. I have never heard a noise like this. I never believed in Bigfoot. When I heard the noise I thought it was one of my companions playing with my mind hiding in the bushes. So I not very loudly muttered under my breath  \"\"Steve...Mike....is that you?\"\" Not getting any answer I could hear the trees start to thrash and that noise came back again with a deeper growl  almost like a moan  low in pitch. As I stood there it seemed like an eternity but was only about five minutes. I knew I had to be making a move. I had to take that trail that lead through the bushes. With my bow in one hand I held my breath and jumped to big leaps across the creek  landed half in the water and yelled out a couple of loud words and ran through those bushes. I never stopped until I reached camp. When I got back to camp. There was nobody there. So I put my bow against the tree and proceeded to get a flashlight out of the tent. Within a few minutes everyone was back at camp. We all talked about what we had seen and what we had heard. Then I talked about what I had seen and what I had heard and everyone had a hard time believing my story. They thought I probably heard a cougar. But I have been hunting for many years and I know a cougar when I hear one. About a half hour later  another friend pulled up in his truck. He was going to spend the night with us. He brought his dog. We fixed something to eat and crawled into the tent. We told a few stories and then drifted off to sleep. About the middle of the night  the dog started to growl in the tent. It started to growl at first and we tried to calm him down. It was pitch black outside except for the stars in the sky. The dogs growl began to pickup. We tried to hold the dog down  then it started to growl and bark. We finally got the dog down on the tent floor when we could hear something outside the tent. Something then brushed the side of our tent. The dog immediately jumped up and started to bark. The dog barked for about 30 minutes and then it seemed to settle down. The area where we had pitched the tent was in tall grass. There wasn't much dirt or barren trails. The next morning we inspected for tracks to find out what it was. But the grass was so tall we found nothing. The noise that I heard that night  has made me a believer of what lurks in the woods.\"", "Report 25233: Bowhunter recalls hearing possible intimidation at night while returning to camp in Farmington Canyon", "UT", "Bigfoot" },
                    { new Guid("382c381a-8db4-4faa-bb45-68df515f0c16"), "Heavily wooded wilderness miles off Route 2 into the old logging camps. [Large property near the end of Cedar Ridge Road]", "\"I was not in any way aware that these creatures existed in Maine  firstly. I am from Connecticut however I have spent years in desolate oilfields across the U.S. including places like West Texas  the upper Peninsula of Michigan  and the Everglades of Florida. I have a vast knowledge of wildlife as I have always taken an interest to it and spent years IN the forest. My point is  what I experienced this day has shaken me to the core as I know my encounter was nothing \"\"normal\"\". In the Northwoods of Maine in a town called Greenbush  (population 1 400) I purchased 80 acres of wilderness with virgin forest on the back half of the lot. (meaning not even loggers have been there  it's that desolate.) I had rented an excavator and for this entire day I had been cutting a road through swamp  hills and forests to a high hill I call Hope Hill on the virgin most desolate corner of my land where I want to build my cabin. I had made it halfway and in the swamp I realized I was out of fuel. I shut down the machine and get out. I step down onto to road and was admiring my work and just relishing in the whole idea of pioneering this new path. Suddenly about 50 yards into the tree line I hear a bang with a stick on to a tree. Like someone was hitting a wooden bat against a large tree trunk as the percussion was unmistakable... At first I thought \"\"Oh crap there is a moose\"\" because it is mating season for them and they are known to ram their antlers against trees to intimidate their foes. Suddenly  the sound happens again. Now I am certain this is no moose as no branches are breaking  there is movement  no grunts  nothing... Just this wooden thump just through the trees where I can't see. I begin walking further away because I'm obviously freaked out. Again  but now 2 knocks... I grab a large branch I had just ripped down with the machine and smacked it against a large tree trunk. Immediately I received a knock in response. I wait around 45 seconds.... I knock again  BANG it knocks right after me again... I knock again 5 seconds later  it responds again right back.... Now I am shaking because I know what I presume this creature to be. It's obviously strong because the bang was very loud. Intimidating... I knew there was a certainty I was interacting with Sasqauch. I went back to my trailer on my qaud which was parked about 200 feet down the trail. I FLEW home. I calm down  now I am questioning reality and am quite  scared I guess. This is my land  I'm only halfway through making the road  these are my thoughts  so I decide to ride back... I knock again. It responds. I take my phone out. Turn on record on video  I knock  it goes away... Almost as if it knew I was recording. Regardless it was incredibly perplexing. I got back on the quad and went back home knowing for sure what I just experienced was legitimate. I brought a feather bead string thing from a dream catcher and brought it out there as a gift. It's been 3 days. I haven't gone back to see if it's still there.\"", "Report 66224: Distinct wood knocks heard 18 miles NNE of Bangor", "ME", "Bigfoot" },
                    { new Guid("3864baf9-af40-41db-9c00-9a98a8808885"), "Longview", "Legend has it that while this school was being built  a young girl died. She took cookies to the workers often  but was victim to a terrible fate one day when she fell in an area of freshly poured cement. Her ghost has been seen wandering the halls of the school at night  humming a tune. The girl’s footsteps have been heard as well.", "Monticello Middle School", "WA", "Ghost" },
                    { new Guid("386ed893-fa44-45f1-b785-d831754f4cfb"), "Biddeford", "Seeing eye's peering down on you from ceiling the. Unexplained noises  voices. Lights flashing on and off. The face above stage eye's seem to open and shut or move.", "Bidderford's City Theatre", "ME", "Ghost" },
                    { new Guid("38cf6feb-ca27-4910-bdc1-f4cd673480b9"), "Four miles north of Mescalero School.", "We hear screams almost every night throughout the spring and summer months. This particular incident occured after midnight  approximately 1:00am. I was awakened by all the neighborhood dogs barking. Even my dog was barking outside my window. Suddenly my dog began to cry. I sat up and walked into the living room and opened the sliding door enough to peek out side and listen to what the dogs were barking at. When I heard a loud scream like screeching then it turned into a loud holler. This screaming sounds went on for about ten minutes and came closer to my home. I then closed the sliding door and continued to peek out my living room window. I saw this tall hairy thing like a man standing next to the other window looking inside my home. I got down on all fours and began to crawl into the kitchen where he couldn't see me. I remained there for about five minutes  then looked toward the window where he was standing and could not see him. I crawled to the window and peeked out. I saw it walking into the dark carrying something in its hand. The next morning when I looked out my front porch my deer jerky that was hanging to cure was gone.", "Report 10126: Possible night time sighting by a resident in the Carrizo neighborhood of Mescalero IR", "NM", "Bigfoot" },
                    { new Guid("38e6594f-161a-4f54-92f1-296cf9b6045f"), "Hill City", "This building was the first funeral home in Hill City  and the crematory can still be seen in the basement. Employees at this now restaurant highly dislike going up to the third floor to sweep late at night  as many strange noises can be heard. One waitress told the story of cleaning upstairs by herself one night. She heard the pool balls on the pool table being broke  and when she turned around  she could still see the balls moving  but no one was upstairs with her.", "Mount Rushmore Brewing Company", "SD", "Ghost" },
                    { new Guid("39061779-56d0-4705-b5cf-0e4459279846"), "Gulfport", "A civil war park that has a man thats head was blown off. People claim that if you go out there at night you can see his ghost walking around looking for his head.", "Grandgulf", "MS", "Ghost" },
                    { new Guid("391fd1a9-0528-4217-a5a9-e6975114919a"), "Flemington", "Slamming doors and spinning barstools are seen and heard after closing. Strange events occur without warning like one time  the heavy wooden front doors were locked. Some employees were sitting around the bar when the heavy wooden doors opened all of a sudden and a cold wind went right past them. When the employees locked the door again  they saw a pair of leather children shoes walking up the stairs. The restaurant is haunted by many unknown spirits.", "Union Hotel", "NJ", "Ghost" },
                    { new Guid("39418af3-fa22-4434-9ec6-365f1161ba42"), "Ellis", "Lockers slamming  The toilet in the girls bathroom flushes by itself all of the time  accompanied by chills.", "Ellis High School", "KS", "Ghost" },
                    { new Guid("395e9fe1-5a7f-46c6-927d-89403fdc0bf3"), "Stevensville", "There are three floors to the high school but one is abandoned. It’s said that this girl that went to school there hung herself in a classroom. A few years after that they reopened the floor and the janitor was cleaning  when she looked over the girl's spirit was coming towards her. A couple other janitors said they saw her and could here her crying. - March 2007 Update: Formerly listed as The High School.", "the Junior high school", "MT", "Ghost" },
                    { new Guid("3972a9ec-c899-4f11-91b7-a141d30e7f4e"), "Bagdad", "\"Witnesses have heard kids laughing in the daytime  just outside the cemetery (in the overgrowth of the property. There were no sign of kids where the noise came from. We also caught a few orbs on film when we visited there at night. Note of caution  the county sheriffs department stakes out the road nearby and patrols the cemetery because of vandals and drug users. A Local legend is associated with the large round ball tombstone in the SE corner of the cemetery  near the exit road. On dark moonlit nights  you can see and hear the granite ball slowly rotating in it's pedestal!!! Also for some reason  the three adjacent obelisks have always been refered to as \"\"The Sentinels\"\".\"", "Bagdad Cemetery", "FL", "Ghost" },
                    { new Guid("397b8aae-f858-4cc0-845a-ee6ca267a4c6"), "St. Cloud", "James W. Miller Learning Resources Center - The new library was built over an unmarked graveyard. Children bones and adult bones were found and later studied by students and staff. The most common ghost is a solider dressed in his time period's uniform  walking through the hallways.", "St. Cloud State University", "MN", "Ghost" },
                    { new Guid("39c51ed7-ddb5-4678-9552-3c27e1b5c04c"), "The town of Scrantons old water supply. It used to be called Scranton Lake. East of the City of Scranton. I believe the Lake is now privately owned.", "While driving down a dirt road which ran alongside a small lake looking for a place to fish I saw something standing in the grass beside a small tree. I stopped my car to get a good look. It appeared to have the shape and look of a person but very tall muscular and covered in what looked to be brown fur simular to the color of the fur of a deer. I believe it must have been 7-8 feet tall. It didn't move but just stood looking at me . I got spooked when the friend in the back seat said he seen it move and I took off in a hurry. I went back to the spot of the sighting in the daytime a couple days later but didn't find tracks or anything else.", "Report 26790: Fisherman has night time sighting along dirt road east of Scranton Lake.", "KS", "Bigfoot" },
                    { new Guid("39dad60d-9adf-4c71-8a69-cc58a587bd82"), "On route 24 near Angola area", "In 1998 or 1999 my brother and a friend were meeting up with me and another friend at home. When they came in the house they were both filled with fear with what that had just saw. It was winter time and it was also in the evening around 7 p.m. and raining. They were driving down route 24 near the Angola light when something ran across the road on all fours. Then when it got across the road to the field they both said it stood up and it had red eyes. I just started to watch the television show finding bigfoot and remembered that night and called my brother up again to get the details to see if I remembered it right.", "Report 39121: Recollection of a possible night time road crossing near Angola", "DE", "Bigfoot" },
                    { new Guid("39fb816a-3465-4720-97c8-f8c3a5ebd1b1"), "", "We live about a mile from Austin Bridge Road in Paulding County  Georgia.  We believe we may have seen whatever it is was seen in your Report # 14887.   We were going to drive out to Hiram for dinner in our Suburban;  and were heading towards Ridge Road on Austin Bridge.  Near where Austin Bridge intersects Mein Mitchell Road; we saw what I would describe as an animal with the basic body structure of a bear but standing on it's hind legs;  and a face that seemed more wolfish than anything else.   It had to be about 9 feet tall.  It stood in the road.  At about 200 yards we decided to pull the vehicle around and go a different direction rather than drive any closer.", "Report 18016: Nighttime sighting by motorists outside Hiram", "GA", "Bigfoot" },
                    { new Guid("3a607cf5-a38f-4bec-8e63-bbeebf78d08c"), "greenleaf rd at rt 5 across railroad tracks into woods pond at horse area", "winter 1994 jay lake area west branch state park a friend and i were fishing a pond. the pond was mostly frozen over except for a spot in the middle which we were casting bait into. i dont know how long we were fishing but across the pond a figure stood up from the shoreline area and walked up a steep hill when it got to the top it turned back to look at us  the figure was large covered with hair and walked on two legs  it was winter the pond was frozen and the figure wore no clothes so theres noway it was a human we were arround 15 yrs old so we took off since we were scarred by this encouter. we viewd the figure for maybe 1 or 2 minutes", "Report 28820: Man recounts sighting from his teens near Edinburg", "OH", "Bigfoot" },
                    { new Guid("3a86243f-15a2-4bb1-8c4d-bad2e2b6c861"), "I was driving south on hwy 51 what I saw was in the second set of trees just in the tree line. East side of bridge. Left side", "While driving my work van just as I was coming over the top of the hill (over pass) a tall dark figure passed in the tree line. It was walking too tall for a human. It was maybe 7 to 8 foot range because it was at the mid point of the trees. There isn't a rise there it's flat I checked because I drive this way 5 days a week twice a day. I watched it walk for several seconds until it disappeared into thicker tree growth. Was stopped due to bridge construction (flagman).", "Report 50208: Bus driver has afternoon sighting on U.S. 51 north of De Soto", "IL", "Bigfoot" },
                    { new Guid("3ae4784c-8717-4baa-807d-26f8d3dc2f36"), "Myrtle Beach", "My family and I were walking along the beach with flashlights looking for shells and anything that washed up on the shore. We looked ou", "Light", "SC", "Alien" },
                    { new Guid("3ae9e4bc-36e6-44d5-a72c-bae325dac8d6"), "Hartville", "A disk shaped flying object followed the path of our car just above the telephone lines.", "Disk", "OH", "Alien" },
                    { new Guid("3b34bec0-2810-42b4-972c-72c38198630e"), "Paducah", "There have been reports of 4 gangsters roaming the halls and firing blanks at students. at night the janitors have reported smoke and the smell of marijuana coming out of the boys locker room.", "Paducah Middle School", "KY", "Ghost" },
                    { new Guid("3b5f95c9-cf9a-469c-9c4c-7ec7490523dc"), "Tavares", "Observing metor shower. 10 minutes into obsevation an object was seen to pass from NW to SE all lights extingwished. Estimate no more t", "Odd Shape", "FL", "Alien" },
                    { new Guid("3c2ebc0a-229a-4654-abff-6ecba3496028"), "Fort Sill", "Images of Indian Children playing on swing set in the backyard. A solider has been seen walking through the house. Voices and combat boots are heard. Lots of physical contact such as: Hair pulling  poking  kicking the end of the bed  touching shoulders  the list goes on.", "Geronimo Acres Housing", "OK", "Ghost" },
                    { new Guid("3cd88362-7d4b-4300-9f50-8ef8f3b1e29d"), "West Greenwich", "My co-worker told me I should report this on this site. This is the first time I have seen this. Myself and my fiend just fininshed a d", "Triangle", "RI", "Alien" },
                    { new Guid("3d070ad3-b759-4182-b4c4-bf1d786aec35"), "Crockett", "There was a woman checking her mail late one night  and was killed by a murder on the loose. She is said to be standing at the mail box at which she had owned with her back toward the entrance and when she turns around you can see the knife marks where the guy slit her throat. And on the anniversary of that night it is said that when you go near the building you can hear the woman calling for help and screaming.", "Crockett Post office", "VA", "Ghost" },
                    { new Guid("3d29b982-242d-4d16-af65-85dee90d8291"), "From the red light in Sandy Lake take 173 north to Mill Street stay on Mill Street it turns into Coal Road go about 1 mile you will cross a small creek in a valley the incident happened near the back of the property.", "When I was 12 years old  my mother was cooking my breakfast before school and as she was cooking and looking out the window she said  what in the world is that? I jumped up just in time to see a large brown figure going into the woods toward a stream behind my house. She said it ran from the neighbors down a powerline and was snapping off sumac like they were twigs.  Being young and curious I ran about 75 yds to the spot the animal had entered  there was a small drop off of about 20 feet then a level spot about 10 ft  then another 4 ft drop to the creek bed. When I arrived I observed the bigfoot at about 50 yrds  It must have heard me as it stopped and turned its upper torso and looked at me. The animal was between 6 and 7 ft tall with a dark face  after looking at me it made great strides down the creekbed and was gone around the bend. When my father arrived we went to check the area. There were very large heel prints in the top of the bank where the animal had landed when it leaped off of the top. I hunted those woods for years and there were times that I felt I was being watched  We heard vocalizations one night but my father said it was a bobcat  after hearing bigfoot recordings I believe they are what made the noise.", "Report 48013: Memory told of a close daylight encounter behind a home outside Sandy Lake", "PA", "Bigfoot" },
                    { new Guid("3d4e7a8a-789f-45df-86af-57987385465d"), "Coventry", "Huge wing craft - 1000 feet in width hovered over house  no noise or lights", "Triangle", "RI", "Alien" },
                    { new Guid("3db972d3-9db2-4a38-aa9e-680c621eeaec"), "Lenax", "High Point was built in 1910. Reports of hearing voices  lights turning on and off in the bathroom  see apparitions of people looking out the windows  feelings of being touched  and cold spots. - September 2005 Warning / Update: the Old High Point mansion has been converted into a Residential Treatment Facility for teenage boys. The facility is now owned by Hillcrest Educational Centers. It has been reported to us that through the summer and early fall during the nights kids have been caught on the property looking into the windows and walking around in the woods with flash lights. There are people working at this facility 24 hours a day 365 days a year and If any people are caught on the property without permission they WILL be PROSECUTED to the fullest extent.", "Pittsfield", "MA", "Ghost" },
                    { new Guid("3dc8e509-117e-4010-a24a-248921a1e7ab"), "Far back in the mountains in eastern Kentucky.  It is possible strip mining has destroyed the area.  I've been away for 40 years or so.", "When I saw this creature  I was told not to tell anybody or they would think I was crazy!! In 1950 when I was 12 years old   I lived in a little hamlet called Beauty located in eastern Kentucky  located along the border of the Tug River. We children played in the mountains almost all summer long.  We had heard of a rock cliff back up on the hill that had a cave in it and we decided to go looking for this cliff with the cave.   Being kids  we didn't keep track of how far we climbed or what ridges we went on  but finally we reached this cliff.  We were standing at the base looking up through the shadows of the trees when I noticed there was someone standing up on the rock (about 10 feet up)  looking back at us. He was  I judge about 6 feet tall.   Muscular.  His arms were longer than a humans.His legs about like a human. He had hair much like a chimps hair grows on its arms and legs. NOT the fuzzy hair like a bear.  His chest seemed to be pretty hairless.   Very hairy around the genital area so one could not tell if he was male or female....but I didn't see any breasts so I judged it to be male.    He was holding a heavy stick in his hand as he stood there looking down at us.   I could not see his facial features.    I would say that he was an intelligent being from the way he behaved. He stood looking at us for about 15 seconds then he stepped back out of our sight and was gone.   It was not until I was an adult that I realized what I had seen. I believe this being knew we were children....I believe he allowed us to see him because we did not present him any danger.   Of course we yelled and tore up the bushes running back off that hill!!   I told my grandma that we had seen a gorilla and she told me people would think I was crazy.   So I kept it to myself what I had seen.", "Report 5678: Woman recalls childhood sighting near Warfield", "KY", "Bigfoot" },
                    { new Guid("3de27e29-6f6f-42fc-9f5a-0d50b41169af"), "Outside of living room window of single family home.", "The sighting was thru the window from the inside of the house. The creature was looking thru the living room window right above the halfway point. Which a person can't see past the bottom ledge.That is what scared me. It was moonlit and created a shadow. I had just turned off the TV at that time. We have alot of deer but they are not vertical or that tall. The incident lasted three seconds.", "Report 46620: Possible nighttime sighting through a living room window near Potomac", "MD", "Bigfoot" },
                    { new Guid("3e0b717b-2631-49fa-a1ee-a4a13e49b647"), "Hays", "\"In 1867  a drummer named Ephriam Polly and his wife Elizabeth  stopped at Fort Hays. While staying there  a terrible Cholera epidemic struck the fort. It is not known what happened to Ephriam  but Elizabeth Polly stayed on at the fort tirelessly nursing sick soldiers. In the late afternoon  she would take a moment to walk to her favorite spot that was an isolated hilltop west of the fort. She would rest there and enjoy the peace and quiet. Elizabeth Polly eventually contracted Cholera and died in the fall of 1867. She was given a full military funeral and was buried at her favorite spot on the hilltop. In the 1960's  a marker was erected there that read \"\"The Lonely Grave.\"\" It is very difficult to get to by vehicle and the last hundred yards must be covered by foot. The ghost of Elizabeth Polly has been seen many times over the years haunting the lonely hilltop that she had frequented so often in life.\"", "Old Fort Hays", "KS", "Ghost" },
                    { new Guid("3e0cdfb5-3958-4448-b936-2af0b5344289"), "", "what i witnessed happened a number of years ago. my brother in law and i were trout fishing in the broad river area of bat cave n.c. outside of asheville n.c. time of year spring time. about 9 10 or 11 in the morning. i was on a large rock in the middle of the river and had been there a number of minutes approx. 20 to 30. when something across the river caught my eye. i looked over and saw something standing on two feet looking at me .this thing was approx. 30 to 40 feet away at most. we looked at each other for approx. 5 to 10 seconds before it turned and proceeded to walk up the mountian at a 45 degree angle to the mountian after taking approx. 20 steps it was hidden from my view in a laurel thicket. i heard it in the thicket but never saw it again  my brother in law was approx. 50 feet down river and saw the same thing. im not sure what we saw what i do know is that it was no bear what we saw was approx 6 to 8 feet tall approx 300lbs. and completely covered in hair it was not solid black it was more of a dark brownish grey in color. i dont know what i saw i dont think i have heard any other stories like this in the area. i would be more than happy to talk to any one in your org. about this even take you to about where this happened. again it occured a number of years ago.", "Report 14801: Daylight sighting by fishermen on Broad River", "NC", "Bigfoot" },
                    { new Guid("3e697db2-22fb-47e1-b9f8-f2309d589b36"), "Powell / Cody", "The center was built during WWII for the relocation of the Japanese. During the day nothing real spectacular happens except for a friendly spirit can be felt following you around. At night however everything changes. Noises and footsteps can be heard when no one else is moving. You get the feeling that someone/something is following you and watching you. They are called Shadow People and they are an old Native American legend. They are usually not malicious and mostly observe people.", "Heart Mountain Relocation Center", "WY", "Ghost" },
                    { new Guid("3eb6db39-15cf-414d-be32-431b90123153"), "Paducah", "\"German Cemetery - This is an old Catholic cemetery located directly across the road from St Johns Catholic Church. There have been many sightings here of unexplained supernatural phenomenon. Such events include but are not limited to sightings of a \"\"werewolf\"\" type creature that charges up the hill at you  a female apparition that is not fond of males  and a strange light that seems to hover over one of the graves in the lower portion of the cemetery. Late at night during certain events  even the crickets are silenced.\"", "Lone Oak", "KY", "Ghost" },
                    { new Guid("3ec6506d-6c61-47a0-816f-5ec3093b0e4e"), "Jamestown", "The Little Theater seems to be haunted by many ghosts. In the shoe room  where they keep all the shoes for performances  the door will slam shut and lock when a person goes in there. The temperature will also drop significantly. Other stories have been told about a male ghost in the boiler room and practice room. People have even reported seeing a man on stage late at night  often playing pranks on people by moving things to where they should not be. He has supposedly spoken to children  luring them across the stage when unattended by their parents.", "Little Theater", "NY", "Ghost" },
                    { new Guid("3f4f35dc-1067-45e3-87d4-984c74fd6ed4"), "Greenville", "Roth Hall - Many people have seen a ghost haunting Roth Hall. The origin of the ghost is unknown.", "Thiel College", "PA", "Ghost" },
                    { new Guid("3f688d80-519b-4643-afd7-f4ca4565193e"), "Kalamazoo", "Black disc shaped craft with a row of bright red  blue and green bright lights around the disc hovered low and made no noise.", "Disk", "MI", "Alien" },
                    { new Guid("3f77eba2-572d-40c5-918d-5a78f84864ed"), "New London", "Footsteps  running water  and voices can be heard inside the old academy when no one else is around. The ghost is said to be a member of the Colby family.", "The Old Academy", "NH", "Ghost" },
                    { new Guid("3f97aff2-00c2-47fd-af5b-51b7b2f1d416"), "I was actually on my boat on the lake at the time. If needed I can give almost exact locations using Google Earth or another map.", "While fishing on Lake Arthur at Moraine State Park I heard wood knocks and rock clacks. It seemed that they were answering each other. I would hear 2 wood knocks then maybe 10 seconds later  to the west about 200-300 yards I would hear 3 rock clacks. This sequence continued for about 8-10 minutes. The sounds stopped when a boat went past mine. I do believe in Bigfoot  I always have. However this is the first time that anything like this has happened to me. It disturbed me so much that I started up my boat and moved to another part of the lake.", "Report 48575: Fisherman on Lake Arthur startled by series of possible wood knocks and rock clacks", "PA", "Bigfoot" },
                    { new Guid("40091e78-339f-490e-b89a-bf0a553b79f7"), "York", "\"Way back in the Colonial days  this building used to be the town hall for the village of York. The story goes that the village head had a young woman hung front of the building  accused of witchcraft. Doors open on there own  moving items  and cold breezes can be felt. Sometimes  locals (who have named her \"\"The White Which\"\") will see a woman walking around the outside of the building/along the road late at night. Across the street from the museum  there is a day care center. Some children at the center have told people that a \"\"very nice lady in white\"\" sometimes comes over and plays with them during there recess. A nice place to visit  the spirit does not harm anyone.\"", "The York Village Historical Museum", "ME", "Ghost" },
                    { new Guid("40babfc8-ecd1-499b-b8d3-e135b8e26413"), "Omaha", "Odd red cloud in clear sky  several small object came out of it moved around in the sky and then went back into the cloud and it faded", "Odd Shape", "NE", "Alien" },
                    { new Guid("40f65e0c-b0b0-4baa-9e51-737fbeb50a10"), "Not far from Russel-Abbott State Forest", "\"I have not had a visual incident  but several strange experiences around my area recently have led me to try want to talk to someone who might know what is going on. Here I'll list the experiences: 1. I have a small orchard next to the forest in back of my house. 2 years ago  a young pear tree was bearing fruit for the first time  loaded with pears  there must have been 20-30 pears on it. I checked them one evening and decided that the next day I would come out and pick them. The next morning  I came out with a basket and every one of them was gone. Not only gone but every branch that had had a pear was broken. The top branches were about 10ft high so what ever took the top pears had to be tall. At the time  I didn't even consider a bigfoot and thought it might be a moose which we have go through the yard periodically. But I have not heard that moose eat pears and certainly not every one on the tree. Usually when deer eat my apples  they rarely eat more than 1/2 an apple at a time. Since that time I have put an electric fence around the orchard and the tree is recovering. 2. My workshop is down the street from my house  in my barn. About 1.5 years ago  I was walking up from the barn to the house and it was pitch black  in the evening. I could only barely see the road. Just before my house there is a patch of hemlock trees. As I passed the trees I encountered a very strong scent of wet dog. It had been raining all day but had stopped but everything was wet. The smell was overpowering and so strong that I stopped to see what it was. I peered into the trees but couldn't see anything. I walked past the trees and past the smell  walked back to the trees and the smell was still there. The trees are about 15-20 ft from the middle of the road where I was. I have to say I was a bit afraid as we do have some big bears around and didn't want to aggravate one  but I doubt a bear would have stayed still. My experience with bears is that they don't like being around humans and the ones around here are certainly not afraid of humans and usually just walk away. Whatever this was didn't move. So I went into the house. I definitely felt like I was being watched. 3. 1 year ago my wife and I were woken up around 1 am to the sound of a screaming woman in the woods  or what sounded like one. It was very loud  certainly louder than a woman would have been able to make  and it woke both of us up. After the screaming stopped  there was a pack of coyotes who yipped for a while from the same area. Then another sound of the woman screaming  then more coyotes  then more screaming and then more coyotes  then nothing. We went back to bed. We had heard the woman screaming sound before  years ago  in the middle of the day  and had gone out to find out what was going on but found nothing. We do have cougars here though and it may have been one of them. 4. A few weeks ago  at about 10 pm  my wife  myself and my son were sitting in the living room. It had been raining and foggy all day and was still drizzling out. It was pitch black and we couldn't see anything outside. All of a sudden  a rock hit the side of the house nearest the woods. It must have been about the size of a large marble. We immediately opened the door  but it was totally quiet and nothing more happened. 5. My daughter was visiting two weeks ago  and she was here for a week. She came on a Sunday and the next Friday she complained to me that she hadn't been able to sleep because of the screams in the woods. She asked me if I had heard them but I had slept through them. She said they were about midnight to 1 am and were accompanied by the sounds of a pack of coyotes. She described the screams but I of course cannot repeat them on this note  however  when she tried to repeat them  they are like nothing I've ever heard. She said they repeated for four nights. On Friday night  we stayed up trying to hear them but they did not reappear. 6. My daughter's dog stayed with us last fall for 5 months. She is a small black lab and loves to explore our field near the  woods. But many times  during the day even  when we went to let her outside  she refused to go out the door. She would sniff and then back away from the door. I still don't know why. Some days she would go out willingly  and some not. 7. The most recent was a few days ago. It was our first day above 90 degrees and I was traveling down Rte 31 north from Greenville along the Souhegan river. I was looking down the river on the right as the river arced away from the road and saw  some distance down the river  a large animal on all fours standing in the river.My first thought was that it was a bear. It was large  as the black bears we've seen around here are quite large. But it was cinnamon colored  quite a light color and the fur was at least 4\"\" long. I couldn't see its head. One of the bears here stood up against the screen door of my next door neighbor and my neighbor is 6'2\"\" and the bear stood as tall as he is  and I thought as I looked at this animal that it was at least that big. I know cinnamon is a variation of black bears  but the fur didn't look right  it was much too long and shaggy. The fur was so long that I couldn't see the joint between the legs and body. I should have stopped to get a better look but I was in a rush and didn't. 8. The last experience I had was in March. I was walking in the forest on a trail. In the distance  I heard someone hit a tree with a stick three times. I remembered that this is what bigfoot sometimes do from the online reports. I thought about that  and then walked on. About 100 feet later  it happened again. I thought  \"\"If this is a bigfoot  I don't want to meet him today\"\". I finished my walk without incident. So in sum  what is all this? Am I imagining something or what? Any suggestions? Do you have any similar reports from near here (southern NK)? I know bigfoot has been cited near here several times in the past in nearby towns. Xxxxx Xxxxx\"", "Report 52031: Family reports strange ongoing activity near Greenville", "NH", "Bigfoot" },
                    { new Guid("40f9b519-df17-4e4d-baff-0b66eaf09317"), "", "Tonight  while on the porch  my better half and myself heard an odd vocal sound.  Then there was a tree crash.  I used a spotlight and checked out the surrounding area and found nothing.  So  just figured a tree fell  no big deal.  Approximately 10 minutes later a LARGE crash from  what I assume to be  a tree was heard further down the road.  I again used  my spotlight and saw nothing.  We sat on the porch for a bit longer and heard rustling off in the woods.  We decided to go inside.", "Report 42128: Residents hear possible activity near Linden", "VA", "Bigfoot" },
                    { new Guid("4151647c-dca7-4695-a235-0f983f567081"), "Granby", "I was driving while I saw a weirdly shaped aircraft hovering above me and then hovered over a field while very low to the ground.", "Diamond", "MA", "Alien" },
                    { new Guid("415cc749-c105-4ffa-bed7-ce781a591fa6"), "Crete", "A bright light seen in the sky  when observed through binoculars seen as a bright light surrounded by three to five others", "Light", "NE", "Alien" },
                    { new Guid("4186664d-de68-4bf6-bb99-742c22b30a56"), "Tecumseh", "A literal circle formation of something with a bright beam of light coming from it appeared in the western sky. The craft came out of", "Triangle", "MI", "Alien" },
                    { new Guid("41e60f88-174c-40b5-b7d4-52c9cad7ccfe"), "Las Vegas", "Bright green comet streak.", "Sphere", "NV", "Alien" },
                    { new Guid("420f03d0-9c29-4c67-ad20-a6d965af5cd4"), "Memphis", "Several definitive accounts of Mary  the ghost of the Orpheum Theatre exist in the archives of Memphis Magazine  in It Happened in Tennessee and in the published history of the Orpheum. The ghost of a little girl  Mary  haunts this theatre. She has a favorite seat during performances. Some people believe that she is the ghost of a girl who died when the original Orpheum burned  but no one was reported to have been killed  and others believe she was killed near the Orpheum on Beale Street. She is not a malicious ghost  actually very shy  and enjoys the playing of the organ (where she has appeared several times.", "The Orpheum Theatre", "TN", "Ghost" },
                    { new Guid("42146423-85cf-4069-a071-9747205bb476"), "Chilhowie", "\"Aspenvale Cemetery is a Civil War Cemetery There are reports of strange feelings of \"\"company\"\" present  anomalies  and orbs present in photographs.\"", "Aspenvale Cemetery", "VA", "Ghost" },
                    { new Guid("4260d766-5810-4241-bbc0-64a37a8dc07d"), "Rapid City", "Built in the 1920's  the Hotel is said to be haunted by many ghosts including the original owner. Employees tell of noises  items moving  and a woman seen on the eighth floor. Guests have told of strange happenings especially on the eighth floor  pianos playing themselves  crying in a room that a woman supposedly jumped out of the window on her wedding night.", "Alex Johnson Hotel", "SD", "Ghost" },
                    { new Guid("42a5db9a-429e-40bd-be09-889739033691"), "Shelby County", "there has been a man seen in the woods several times known as Pigman when approached he disappears he has a pig like face and others haunt this wooded area too. its only likely that you'll see pig man at night but carry a flashlight to see other strange things.", "Shelby Forest", "TN", "Ghost" },
                    { new Guid("4300da81-ed85-4b3d-8adc-4243d3ca4333"), "Broomes Island", "There is a old cemetery and if you circle the cemetery three times on the third time fog will come rolling in and you will hear a little girls start to laugh.", "Church Rd.", "MD", "Ghost" },
                    { new Guid("43a59799-0ae3-4156-9cfd-12b221d8394f"), "Both sightings were on the North east corner of the reservoir..the lake was low..I saw it walk and stick its face in the water like a dog", "\"Well last year I was night fishing 9/2010 at Amawalk Reservior SOMERS NY about 30 minutes from PAWLINGS I was fishing with my buddy..the reservior was about 100ft into the lake before you got to water .....about 5am sun was coming out..when a 5 foot maybe 5 1/2 ft man  or Big Foot came out of the woods washed its face and drank some of the reservoir water..he looked like something out of the old school \"\"Planets of the Apes\"\" chimps..I said to my buddy \"\"you see that?\"\"?he said yes ..Now on Animal Planet there showing a clip of a Big Foot that has been seen in these areas (Lower Hudson Valley)..So I'm puzzled to think what I saw was a Big Foot....so this my account of what I saw..and we didn't catch crap at night..anybody ever run into anything like this??... This was my post on www.westchesterfishing.com Low and be hold another member at the same reservior..Columbus day 2011..this is his post..Hey Guys  I put at Amawalk this summer and about the 5th time I took it out in early October.  I saw two upright walking chimp looking things walk out of the woods and crouch down and drink from the res  run back in to the woods and then do the same thing again.  When they came out the second time one of them threw it's arms in the air while squatting and then they ran back into the woods.   The second one went back slowly.  It seemed like they saw something in the water right in front of them.  That was right when the sun came up.  I haven't been back to my boat since.  I have no idea what they were and looked like two large chimps to me.  Maybe some guy who lives there has two monkeys or something?  I have no idea.  But I saw something that I can't explain  it has been eating away at me since.  When I saw the preview for that show I almost shat myself.  When Biggame posted here I didn't want to say that I saw something because I'm from Oregon and my hunting and logging part of the family thinks they know where they live but none of them have never ever seen them just have stories  just like everyone else in Oregon.  Then I saw what I saw in October and have been denying it to myself ever since.  I absolutely hope that someone owns two monkey's on the Amawalk. I have no reason to say something like this.  Before October I could have cared less if bigfoot existed  now I'm a bit curious.  I own a fishing rod company and have business to lose from people thinking I'm crazy for posting this on here.  This is a nothing to gain and allot to lose situation for me but  I had to say something when Biggame posted.  Let me be clear in saying that I saw something too.  I have no idea what they were and would need absolute proof that bigfoot existed before I would ever say thats what they were. So two seperate sightings same place different year..I BELIEVE!!!\"", "Report 31940: Fishermen and Law Enforcement Officer Report Three Class A Sightings in Same Area Within a Year near the town of Somers", "NY", "Bigfoot" },
                    { new Guid("448eb892-4cfd-4126-a864-9ee15ed254e8"), "Southbury", "A large triangular object hovered 30 mins  then accelerated and disappeared over the horizon.", "Triangle", "CT", "Alien" },
                    { new Guid("449db04d-d4cc-4518-844f-62cc033e57c1"), "It was near Bell Mountain  I didn't drive to the area so I wasn't really paying attention to the area.  I think we entered the trail just off what I thought was Country Road 32 if I saw the sign correctly.", "Went for a weekend hiking and camping trip with 4 family members.  We hiked about a mile and a half down an established trail before making a turn into the brush to find our camping spot just after sunset on the first night.  we probably hiked about 400 yards into the brush before setting up camp and turning in for the night as it began to rain.  I was woken up about 4:30am by a very strong odor that smelled just like a skunk  so much so that I assumed a skunk had made it into our camp and I zipped up the shell on my sleeping bag to avoid being sprayed.  The odor went away so I relaxed a bit more and tried to get back to sleep when I smelled it again only this time I had an overwhelming feeling I was being watched from directly behind me.  I rolled over to look and was able to make out a sillouette of a very broad shouldered shadow and head between two trees about 7 yards from where I was laying.  I immediately turned around and waited for daybreak  still unsure if I had seen anything or just imagined it I sat waiting and listening for anything aggressive in nature and it didn't happen so I chaulked it up to an overactive imagination but was still uneasy about staying in this location.  I said nothing to my family but I was determined to not let the camp fire die out on the second night.  The second night came and it rained again  we could hear the sound of what I would describe as a very loud owl.  We turned in for the night and all my family fast asleep let the fire get to the verge of dying  easily helped by the falling rain.  Sounds were all around the campsite but not really unexpected in a dry rotting forrest during some steady rains.  I got up to tend the fire and as the firelight grew it seemed the forrest sounds intensified  again probably just nerves.  I'm not an avid outdoorsman but I love the minor amount of time I do get to spend in the wilds.  It was about 3:30am at this time and one of my family members woke up and helped me with the fire  sensing my uneasyness he suggested I use his hammock to get some rest and he would watch the fire.  I got a couple hours sleep and woke up around 5:30am still before daybreak and my family member proceeded to tell me that about 15 minutes prior he heard a very loud crash in the forest and then another less intense crash directly behind the hammock where I was then sleeping.  It had alarmed him enough that he had his handgun out and ready but he said he didn't see anything and I still didn't say a word about what I thought I may have seen the night prior.  I actually did not tell anyone until we were on our way home and I told my brother about what I thought I saw  mostly out of fear of ridicule.  It wasn't until we got home and I started doing some research that I became more convinced of what I think I saw on the first night and what I smelled.  During our time at this campsite the rain stopped during the day and we were able to hike around the area probably covering almost 2 miles and one of things that struck us was the complete lack of any wildlife.  We saw a woodpecker and heard the sounds of birds chirping on the first morning  but that was it  nothing not a single rabbit  squirrel  dear  bird or anything other than that woodpecker and a few fish in a nearby creek were seen in the area.  We did come across some animal droppings that looked almost like rabbit droppings only smoother.  We only stayed two nights even though we had planned on 4 nights total  fearing more rain we left early.", "Report 26694: Possible nighttime encounter while camping near Potosi", "MO", "Bigfoot" },
                    { new Guid("44c89867-fa16-4523-804b-e6494338c7b4"), "We were on a widing reach of highway with dense frest cover on either side. At the precise location of the siting we identified a standard under-road box culvert with a secondary channel flowing through. There were standard metal barrier s on either side of the road protecting the culvert and vehicles. We had seen no homes or lights for perhaps 30 minutes and it was another 30 minutes before we reached the park gates - where there were no rangers available to report the siting to.", "The siting was witnessed by my friend and myself  both Geologists  while driving into Yellowstone from Cody for employment at the Park for the summer. My friend was taking his turn at driving and I was soaking up as much as I could see as well as providing a running commentary to keep my friend alert during our long drive. As we came around a curve in the road our high beams illuminated a large dark shaggy figure coming up out of the ditch on the left side (south)of the road at a distance of about 200 -250 ft. As we approached the figure at a speed of about 45 miles per hour  it looked first at the vehicle (we noticed the yellow reflection from it's eyes that is seen in a dog's eye when light catches it at night) then deliberately turned it's head away from the lights. That motion was non-human or bearlike  in that the the shoulders  chest and head moved simultaneously as it caught site of our vehicle and then turned it's face away from the headlights. We slowed (OK   we slammed on the brakes)  stunned at what we were seeing and trying to rationalize we were looking at. A hominid creature  perhaps 7 to 7.5 ft in height (we have a 7 foot friend as a reference)  massing perhaps 600 to 800 pounds without obvious signs of obesity  standing completely and comfortably upright  came up out of the ditch from the left side of the road right at the edge of the metal barrier above the culvert. It took 3 extrodinarily long and fluid strides across the highway (22 ft) and another 3 of 4 shorter strides down the other side of the road actually appearing to catch hold of the metal barrier/railing with one long fingered hairy hand and swinging down under the road into the box culvert or channel bottom completely out of our line of site. We stopped the vehicle within 25 feet of the culvert and watched the final decent of the creature into the darkness of the channel. At this point we speed on toward the east gate of YNP hoping to find a ranger to report the siting to and perhaps to go back and take another look. There was no one at the gate due to the late hour and we didn't see any lights on anywhere  so we continued on to our destination and went to bed deciding not to contaminate each others observations with discussions until morning. In the morning we both independently described graphically and in writing as much of what we had seen 6 hours earlier. This is a synopsis of our findings. There were virtually identical down to the movment of which leg moved first as the creature crossed the road. The head appeared to merge into the neck and there was no snout or protrusion from the face as would be commonly seen in a bear (I've seen hundreds  up close and in person) The face was not clearly visible and was only glimpsed for a moment. We both got an impression of long hair covering some of it. The nostrils were large and open  but neither of us were able to describe mouth or teeth. The eyes weren't exceptional  just the reflection of gold  like a dog's. What each of us can still describe with great clarity in the size  shape and unique fluid movment of the creature. It was big  7-7.5 ft ish  but not much bigger than that. It was heavy and powerful looking. In shape  it possessed a rather blocky  yet elongated head slightly domed on top of the cranium  thick short neck  broad shoulders  full chest. It was square and longer through the torso and hips than a human. As it walked across the road in front of us  the buttocks were clearly seen as muscular masses moving under heavy shaggy hair  they obviously attached to long powerful  muscular thighs longer in proportion to a human  big knees that functioned as a human knee  thick mulcular calves and feet in proportion to the rest of the oversized body. The soles of the feet appeared to be hairless or less covered in hair and very dark in color. The arms hung from heavily muscled shoulders and were longer than a human reaching to knee length and extending fully and almost a horizontal positon to the front and rear of the body as it moved. The elbows were perhaps a little further down the arm that on a human - or the unusual length of the arm made it appear so. The hands were large and long fingered  neither of us could later describe the palms  nails  or other than the backs of the hands which were covered in the same long shaggy dark brown hair as the rest of the creature. The creature made no sound nor gesture throughout the siting. It appeared a little startled at our vehicle appearing out of the night  but in no other way frightened or threatening. Starled the heck out of the two of us  though!", "Report 1241: Two gov't geologists witness hominoid creature cross road about 30 min. east of Yellowstone Park's East Gate", "WY", "Bigfoot" },
                    { new Guid("452678ee-223b-4107-9fd3-61df101eebe0"), "Bemus Point", "The Casino is a teen dance place. The Ghost that haunts it is known as Jordan Basile  a young chef there who died when the oven blew up. He was around the age of 15. Now when they hold dances  food mysteriously disappears and people often trip and fall when nothing was in their path. Jordan Basile is seen at the new oven on August 16th (the date of his death) every 2 years making what appears to be lobster  which was his specialty.", "Casino", "NY", "Ghost" },
                    { new Guid("4547de9e-ab16-4af1-a5cd-3e9cff727764"), "Waimanalo", "Started as a bright star on horizon  silently moved in a east-west direction over us. multi-colored light along the outside of the tria", "Triangle", "HI", "Alien" },
                    { new Guid("4594f519-626e-40ae-93fb-e14c553d012a"), "Corvallis", "Sackett Hall - In one of the rooms is the sight of numerous disturbances including fire starting and things be thrown around the room. It is said that a girl was killed in that room. Her name was Brandy and she lived in room 121. She was known to be very loose particularly since it was the 1950's and one night she was killed by accident by a drunken frat boy. She still roams B-long  her physical body having been turned to dust ages ago all that remains is her angry spirit which is seen at times to be a swirling cloud  twisting and turning in constant eternal anguish for a unpunished crime...very few have seen her.", "OSU", "OR", "Ghost" },
                    { new Guid("459ab226-d909-4608-866d-df65afa94b91"), "Middletown", "A triangular shaped object seen late at night.", "Triangle", "OH", "Alien" },
                    { new Guid("45bd86f9-ae34-4f69-a0ba-aab15050026c"), "U.S.A. Gallatin National Forest  Gallatin County  Montana. ~10 miles east of US 191 ~30 miles south of Bozeman. Incident occurred in the Portal Creek area.", "\"Two friends and I were backpacking in the summer of 93'. We were going to hike the Gallatin divide that summer  one weekend at a time. We started south of Bozeman and planned to finish in Yellowstone latter that summer. This was our third weekend and it being a Sunday we were hiking out to our car which was parked at the Portal Creek access. It was getting late in the day and it looked like some weather was rolling in. We were coming down the west side of windy pass so we decided to double time it so we weren't exposed in the weather. We didn't make it to the tree line before the storm hit us. The wind was howling and a nasty mix of rain/hail came down on us. When we were well enough below tree line we decided to sit out the storm by this rock out cropping. Wind whipping through the hills  especially in a rocky area like this  has a very distinct sound. It seemed like there was something else in that in that howl. Something that didn't quite sound like it was part of the wind. No one commented on it but I could tell by how Dan and Kevin were looking around that they heard it too. After about 45 minutes the wind died a bit and only a slight drizzle was falling. We started hiking back down  the clouds were clearing and it looked like we were gonna get a good view of sun setting over the Spanish peaks. We were coming through this clearing that had been cut maybe ten years ago. The sun was almost out of sight when we heard some thrashing across the clearing. It could have been almost anything but since we were in bear country Kevin took out his .357; not enough to stop a determined grizzly  but it was better than nothing. We proceeded slowly across the clearing. It was maybe a hundred yards towards to older tree line  with a lot of scrub and young pines in between. I was looking up for circling carrion when I heard this howl. It sounded like what I had heard earlier but now the wind wasn't behind it. It sent a chill up my spine. Dan  who was behind me yelled something to the effect of \"\"holy [#*$%]\"\" and pointed off to our right. Something massive and dark and clearly running on two legs ran through the brush about sixty yards away and disappeared into the forest. I don't think any of us moved or spoke for about five minutes until we heard the howl (yell?) again (this time pretty far off and in the opposite direction than we were heading) We got out of there in a hurry. We didn't tell too many people about this when we got back to town. We did return back to Portal Creek access the next weekend to start our hike again and I've been back to that area several times since hunting or just out of curiosity and I've never heard or seen anything unusual.\"", "Report 1454: Three backpackers see a large  massive upright animal running on two legs through the brush in Gallatin Nat'l Forest", "MT", "Bigfoot" },
                    { new Guid("45cccb6e-d880-4b93-bab6-f5c8412f0540"), "Reno", "at night time when the lights are out teachers report to hear awkward sounds.", "Dodson Elementary School", "NV", "Ghost" },
                    { new Guid("46fdb78a-7f9a-4d72-9ebf-7c0f405bc9f3"), "Naples", "My dad told me to come look at the sky  when I went outside I saw several bright lights moving around  some would blink  they didnt app", "Light", "ME", "Alien" },
                    { new Guid("470e0ada-dc8a-400e-ab8d-1638082ae9c6"), "Evansville", "Willard Carpenter  of Willard Library  lends a bit of excitement to the staff and volunteers at WNIN from time to time. Mostly strange noises  things moved when you aren't looking and a sighting or two just out of the corner of the eye.", "Carpenter House", "IN", "Ghost" },
                    { new Guid("478b09fe-1bdb-49e7-877b-a01ea61cf31f"), "Wickenburg", "Old Train Depot - There are reports of people hearing whispering. Witnesses claim to have caught orbs in photos. This depot was built in the 1840's.", "Chamber of Commerce", "AZ", "Ghost" },
                    { new Guid("47bd6f4b-38c4-47f5-afbf-62f2d8c54252"), "Eden", "Circular light image moving in an arc downward. Brightly lit  white-yellow with warmer tones flaring out on the bottom. It's size was", "Light", "NY", "Alien" },
                    { new Guid("47e340e2-e38d-42d3-a83c-8f9a2f77f00c"), "Oxford", "the light- Near oxford their is a place called hueston woods  go through it until you find the Hopewell cemetery. It is one of the best ghost hunting sites in southern Ohio. And I saw the light in oxford also mentioned on here  if you want to be safe don't go to it. It has caused me very bad luck every time I go near it. But up the street from it their is a barn you can't miss it  go their and search around  when you get back to your car their will be a little surprise. I went once and haven't ever been back the surprise caused us to wreck the car we were in trying to get away.", "Hopewell cemetery", "OH", "Ghost" },
                    { new Guid("47f504ca-ac83-4e30-910b-034063bbb538"), "Westminster", "Many reports of a lady diving onto cars as they cross and then disappearing before the car can stop. Many say that the woman is screaming for them to help her find her child. Others say it is the ghost of a woman that drowned in the creek below while swimming. The bridge is beside an old saw mill  maybe thats where she died. But it is a fact that a woman did drown in the water in the late 50's.", "Lonely bridge", "SC", "Ghost" },
                    { new Guid("480f15cb-8c04-4911-8ae9-9bd34fae9264"), "Lenox", "There is a cemetery onto of October Mountain that’s is supposedly haunted. There are many stories of people hearing humming noises and seeing ghostly figures of children.", "October Mountain Cemetery", "MA", "Ghost" },
                    { new Guid("4858f252-d482-4de2-b625-d7884eb08b79"), "Combs", "Two craft moving towards the North  the first craft vanished then approximately one second later the second craft vanished.", "Light", "KY", "Alien" },
                    { new Guid("48eadf0d-0a3b-4f7a-aff6-2463c9a8bec9"), "Don't know any closer than that. It was midnight with no street lights  just highbeam headlights  moon & stars. The west end of Deerfield Rd is Route 28 in Allenstown.", "\"In one part of Bearbrook State Park is the Girl Scout Day Camp location. Across the street from New Rye Rd is the Camping Museum & the Snowmobile Museum. There used to be a nature museum. If you keep going straight on that dirt path  you wind yourself up into the Girl Scout Campground. It was a 2 week event. The older campers were allowed to have a single overnight in the last few days. It was '67/'68  late July. There were 3  5-person tents  I was a senior and in the tent closest to the woods. The evening was spent cooking hotdogs & hamburgers & marshmallows & sa'mores with lots of singing laughing & screaming. We all retired around 10 pm. In the middle of the night  around 1 or 2 am  I was woken by something softly grunting & pushing down on the top of the tent. We have racoons but no bears in (I get the irony) Bear Brook State Park. The other girls in my tent were trying to stay quiet  but still panicking not so quietly. I said \"\" it's just one of the other girls.\"\" I am a camper since age 9 with a father who was a practical joker. So I said loudly \"\"That's not how you do it. This is how it is done\"\" & I dug my nails into the canvas & making a roaring growling sound clawed down the canvas hard & fast & hit something soft but solid on the outside of the cloth. I was picturing a man's hand/fist kind of like knuckles???. There was a loud grunt/growl & crashing away from us through the underbrush just on the other side of the tent. Now the girls in my tent are screaming hysterically about bears  The rest of the campers are opening my tent and all pandemonium broke loose. No-one admitted to playing a prank. & the leaders in the other 2 tents all day insisted everyone was accounted for & no one had left the tents not even a potty run. There was a funky smell though  that no-one could recognize. The park rangers swore there were none in the area  they were all up north for the summer. We had never heard of bigfoot  I fear I am repeating myself  so didn't even know such a thing existed. So  unexplainable incident  that with hindsight  I am thinking  could it have been??? The entire area  for square miles  has always been swarming w/ deer  even still  today.\"", "Report 48354: Woman recalls scary night while at a Girl Scout campground in Bear Brook State Park", "NH", "Bigfoot" },
                    { new Guid("49307110-78ea-4699-88eb-b72d90c01279"), "Hayward", "This casino was actually a farm many years ago. In the past  there were stories of the farmhouse being haunted. Classic occurrences such as eerie footsteps could always be heard late at night. The house was moved about one mile down the road when the casino was built. Many workers of the casino graveyard shift have seen apparitions of people in the casino after it has been closed.", "Lac Courte Orielles Casino", "WI", "Ghost" },
                    { new Guid("497abc52-4f5e-4394-9ea0-d8414400f6a9"), "Waterloo", "A shiny silver object floating stationary then made tight but short movements.", "Oval", "IA", "Alien" },
                    { new Guid("49b3c074-9c4e-420c-906f-a8ec921727a5"), "\"We went around Strawberry reservoir (NE of Heber) Hwy 40 up to Hanna  then on a dirt road  then backpacked to Betsy Lake (Granddady Basin).  We were on the North side of the lake. It as a \"\"No firearms allowed\"\"  area.\"", "\"We backed pack into the Uintah's two years in a row - this was our second year. I have never shared my experience with anyone.  I was afraid people would think I'm crazy.  My personal experience happened about 1985-1986.  We were camping in the high Utah Uintah's (Grand-Daddy Basin) on the North edge of Betsy Lake  in a small clearing.  Since we were by the lake we built a little raft out of logs (tied them together).  The FIRST night something woke me (I was in a tent with my nephew).  It was about 2:00-3:00am I could feel and hear heavy walking outside the tent.  We had a two man tent and something was playing with the top of the tent (feeling the poles).  I lay in my sleeping bag (petrified!). Because we were so close to the water  I also heard someone (something) in the lake. What caught my attention the most was the long strides when they walked.  I knew it wasn't a bear  because bears would have clawed at the tents.  Whenever I camp  I always sleep in my clothes.  I finally got the courage to go out of the tent to look things over.  While I was putting on my shoes  my Nephew woke  and he said  \"\"What's that?!\"\"  I said  \"\"I don't know  but I'm going out to find out.\"\"  As I went out of the tent  I screamed as loud as I could (like Tarzan) to scare them away! The one in the lake came out and joined the other and they ran past the tents.  My sister heard them run past her tent and they ran fast!  They were gone immediately! The SECOND night I moved into the tent with my sister and her husband and my nephew moved into his sister's tent.  About the same time of the night  I heard them again.  I just lay in my sleeping bag wondering if I was crazy.  I could hear them walking around and I listened extra hard to recognize how large they must have been from the extra heavy footsteps and very long strides.  They hung around for several hours (moving around) and left at day break. The THIRD night they came about the same time.  I could hear them walking around again  and then one of them grabbed the tent rope and plunked it (\"\"Bing\"\" like a guitar string).  My head was about 6\"\"-8\"\" from the side of the tent and suddenly one of them ran their fingers across the side of the tent (that's how it sounded to me).  With my heart pounding and everyone awake  I stepped out of the tent to build a fire (hoping this would scare them off).  While I was building the fire  I could feel them watching me.  When the fire became a blaze they walked off (they didn't run this time).  Later in the day we went out on the raft.  As I looked into the water  I pointed and said \"\"Footprints\"\"!!  My brother in law laughed at me  but what I saw were large dips as if something had walked into and out of the water.  It was about the same place I heard something come out of the water the first night.  My brother in law teased me about my \"\"big Foot\"\" experience.  Since my brother in law is a heavy sleeper and snores loud  I have wondered if the sound of his snoring is what brought them to our tents. .\"", "Report 20430: Possible camp stalking at Betsy Lake  Grandaddy Basin  Uinta Mountains", "UT", "Bigfoot" },
                    { new Guid("49eea6cf-b2f5-4c57-a64b-60ad74d93d8c"), "on the yellow river bout 10 miles down past hwy 2 bridge", "yesterday 11/11/08  i was kayaking on the yellow river in north west fl panhandle  when i heard a vocal moan to a yell   got on down the river smelled a very musky wet dog smell   i heard sticks breaking   but not as much as you would think  then the big stuff happened out of nowhere a big rock come flying out of the trees and hit the water   i thought its got to be a redneck or some thing so i yelled out hello what are ya doing no sounds not even birds then another rock about the size of my head almost hit my kayak  that set off a bunch of coyotes they were on something then a sound so loud it scared me then trees breaking and then a dog or coyote screamed like it was in pain   barking yellping and some sound that i cant identify  they were fighting i think . the river trip was 25 miles long and it sounded like i was followed the whole way. dont know what that was but i thought yall might be interested . never saw it . but heard it and smelled it and got rocks thrown at me it was scarrey  to say the least", "Report 25037: Kayaker experiences frightening incidents while traveling down Yellow River", "FL", "Bigfoot" },
                    { new Guid("4a0fbd13-7a2c-40c2-875f-a4c0d5beb3a3"), "El Paso", "Building #13 - built in 1893 for soldiers of the 18th Infantry. A Calvary soldier was forced to retire because of his age-he may have been a doctor. This depressed man apparently hanged himself in the rafters of building 13. Also in building 13  the swinging doors in the courtroom have a habit of swinging by themselves at times. A cavalry soldier has been seen walking through the halls as well.", "Fort Bliss", "TX", "Ghost" },
                    { new Guid("4a62aef5-73b9-42c4-ac8e-da71191067b6"), "It happened in the woods across from the NH International Speedway in the areas between Loudon and Chichester or so...big patch of woods out there very rural all the way to winnepesaukee.", "Well it was a few weeks ago in Loudon  NH.  Me and my wife had just settled into a house nestled next to a farm.  It was night time no real overcast or anything.  From inside the house we heard what we thought was barking constantly.  We own several dogs so we were used to it.  this continued for about an hour or two then quieted down.  Later on that evening about 2am or so we heard the most bloodcurdling sound ever.  The only way i can describe it is like about 20 dogs all screaming and yaulping at once in a shrill chorused scream.  We haven't heard it again but it came from across the farmer's field in the woods across from The speedway.  I'd have to say the date was around January 10th or so.  We have heard other things too and seen plenty of deer...but never heading across the field.  We don't know what it was and did not see it at all.  We have seen shadows move down the dirt road we live on but figured it was just someone walking up the road. Maybe we're just paranoid...but i've lived in the woods here a long time and never heard anything like that before.", "Report 1975: Couples hears late night scream in Loudon", "NH", "Bigfoot" },
                    { new Guid("4a64be49-42ae-4873-b23b-631ce28f47a8"), "Cody", "\"Cedar Mountain use to be called Spirit Mountain because people have been lost and never found in the caves that honeycomb this mountain and the surrounding area. The caves were closed to public access except that one can register with the forest service an explore these caves. Even the canyon that runs along side the mountain is considered haunted. People have heard footsteps behind them but when they turn around  no one is there. Also  some of the long time residents claim the mount is occupied by \"\"little people.\"\"\"", "\"Cedar \"\"Spirit\"\" Mountain\"", "WY", "Ghost" },
                    { new Guid("4a880ab5-deea-41a2-9d0f-0a007c6ec2c0"), "Jacksonville", "First one appeared in the eastern sky and moved slowly south  about 10 minutes later another light appeared in the same spot the first", "Light", "IL", "Alien" },
                    { new Guid("4ab9900b-3e85-415c-a107-af8dffbbacd4"), "[camp site near Horsethief Picnic Grounds off Talemina Scenic Drive]", "Went camping in the Ouachita mountains near Talemina Scenic Drive.  At 3:39 we all woke up due to the sound of something knocking a tree behind us. Was in the distance but close enough to make you on edge. We thought it was a woodpecker and brushed it aside. 10 minutes later we heard the noise on our right side of the tent. The knocking was in triples such as “ knock  knock  knock” then a pause and the 3 knocks again  but in every direction the knocking had a slight variation. The knocking was coming from all sides of our tent  as if there was something surrounding us communicating. Knocks has slight variations in how quick they were  but all of them had the triple knocking. The closest knock was about 50 yard uphill from us. The close one made everything stop in the woods  it was raining and it stopped along with the wind. This is weird  considering it was super windy up there the whole time we stayed  except that one moment. We all agreed to not camp that spot again.", "Report 65284: Campers awoken by loud knocks around 4am near Talemina Scenic Drive", "OK", "Bigfoot" },
                    { new Guid("4acf6b1a-8fbe-4c85-b79b-309b3dbcb505"), "North of Montrose  the old Airport road  which is now called 64.50 Road", "\"Witness  38  who requested confidentiality  was a young teen in junior high school at time of the incident. Witness  who will be called Jeff  said he and his friend were alone at his parents house one night when the friend  since deceased   noticed \"\"something\"\" looking into the house through the front door. Since the friend was \"\"always a kidder \"\" Jeff just looked outside to call his friend's bluff. \"\"But sure enough  there was this head looking at us.'' He said since it was dark  few details were visible  but he described it as \"\"like a coconut.'' \"\"We freaked out  so we ran into mom's bedroom and grabbed the .22 and loaded it with bullets. I told (the friend) to go lock the door  but he said no way. So we ran into the bedroom  which at the time didn't have curtains. Soon we heard it breathing and kind of scratching at the window and we saw a hand up against the screen. I would say it had to be 8 to 10 feet tall to be looking in like that.'' Witness stated at that time  he could see the animal looking in the window. He described it as \"\"large  hairy and black.'' \"\"My friend fired two shots at it  but missed. It took off running and we didn't see it after that.'' The two called the sheriff  who came to investigate and found the two bullet holes in the window  but no blood and no footprints on the hard adobe ground. The sheriff asked if the two had been drinking  but both were aspiring wrestlers. Jeff said neither of them drank nor used drugs. Jeff's brother  who initially contacted the BFRO  said that when he and his parents came home  his brother and friend appeared to be \"\"scared to death.'' The brother also said the impression of a large hand could be seen in the window screen.\"", "Report 1075: Teens fire at big black thing peeking in window of home", "CO", "Bigfoot" },
                    { new Guid("4bd84d79-4238-41df-9ffc-b5c7e7f6bbdd"), "Honolulu", "Green glowing UFOs and some that look like stars in the shape of circles with many encounters.", "Circle", "HI", "Alien" },
                    { new Guid("4bdbc239-778a-4c9d-98f4-a2afc552099e"), "West Stockbridge", "Campers and counselors have reported seeing apparitions walking across the large field late at night. Also  when camping on the top of blueberry hill  campers and counselors have reported seeing the same apparitions atop at the clearing.", "Camp Kingsmont/Blueberry Hill", "MA", "Ghost" },
                    { new Guid("4bf3a43f-ad86-4324-bc1b-423b5dcf80ef"), "Just north of Challis  Idaho and south of the Salmon River Wilderness.", "We were on a hunting trip with about 10 people near Challis  Idaho  south of the Salmon River Wilderness  in October 1975. We had stopped our trucks on a dirt road on our way back to camp following our morning hunt to “work” these hillsides that converged at a stream near the road. To our knowledge  there were no other hunters in that area. Four of us went up into the hills to make a giant circle to try to scare up some game and drive them back down towards the stream where the others were waiting. Being young  I volunteered to be a hiker. As we split up  I thought three of them went up the backside of one hill while I circled the other. As I came over the ridge  I found myself on a very steep  shale-covered slope about 500 feet above the stream. As I was scared of sliding all the way to the bottom on my butt  I sat down to watch the opposite slope while my dad and the other 2 worked that hill. As I sat there  I saw what I thought was one of our hunting party walk across the slope  about 100 feet below the ridgeline. He crossed the hillside  near the ridgeline  on the hill across a large ravine from me. That hill was taller than the one I was on. I remember thinking  “boy  he is going to get shot  dressed in dark clothing like that!” It kind of made me mad because he was walking a rather brisk pace  not even stopping to look around for game. I watched him through my riflescope  and for the life of me  I couldn't see any rifle in his hands. My dad had brought along one of our neighbors who had very little experience hunting  and I figured it was that guy. After about 30 minutes  I saw my dad and his other buddy come into view. They were much lower on the slope and I estimated their range to be about 400 yards  but seemed to be smaller in comparison to the other figure I had seen earlier. We waved at each other to work our way back towards the others. When we got back to the trucks  the neighbor  of course  was late in arriving. While waiting for him  dad was joking about seeing him walking along the ridge with his rifle still in it's zippered case  as is was raining lightly. I told him that I thought I had seen him  but saw no rifle and almost shot at him as he was dressed in dark clothing. Dad said “He had an orange vest and orange cap on  and how did you see him when he was above and behind you?” I said  “No  he was above and behind you.” When the neighbor with the clean and dry rifle returned  he confirmed my dad's report. So I said  “Well then  who was that I saw?” Everyone was too tired and wet to care. We went back to camp and forgot all about it  until the other day. Now I'm starting to wonder all over again. Since whoever/whatever I saw was probably 500 yards or so from me  I had trouble making out much detail. I had a variable 3 X 9 power scope. After I saw him I cranked the power all the way to 9 and watched him cross the open hillside without obstruction for probably a full minute or so until he disappeared behind the trees. I was watching his entire left profile. He walked rather quickly and did not turn to look at me  as far as I could tell. He did not appear to have much difficulty traversing the terrain  but when my dad walked across  it looked like he was having the same problem as I was with the steep slope and rocks that slide when you step on them. It took dad forever to cross the same amount of space as this other guy  and dad appeared to be much smaller  even though he was obviously somewhat closer to me. Dad was probably 50 feet or so lower in elevation than I was. As far as estimating height  my dad is 6ft tall  and this thing was much taller and broader...but not fat...kinda “lanky”. A really rough estimate would be at least 8ft. tall  with really long arms that he/she swung like a cross-country skier as he walked.  and taking rather long strides as well.", "Report 6983: Hunter has early morning sighting near Challis", "ID", "Bigfoot" },
                    { new Guid("4c0659ab-daaf-4bf5-8d72-0a3114eeca0a"), "Rapid City", "Looked towards a thunderstorm approaching from the west. First saw a bright shape in the sky in the northwest direction. The light wa", "Odd Shape", "SD", "Alien" },
                    { new Guid("4cb6dc2f-dbbe-47c7-a2eb-0bd22674b602"), "North of Cedarville", "At the top of the mountain at Dry Hill Rd. going north on Highway 220  off the to the left side of the road is part of the old Butterfield Stage Coach Rd. Hunters have always reported the sound of someone whistling a strange tune. When they search the surrounding area to make sure it's not a joke from someone  it always stops when you step onto the Old Stage Coach Road. When the whistling stops  you can hear a team of horses running  as if the old stagecoach is making another run.", "Highway 220 at Dry Hill Road", "AR", "Ghost" },
                    { new Guid("4cdc42dd-fca7-40e3-83c9-91a481eb4e9a"), "Salt Lake City", "The Alta Club  a private club  once held hotel style rooms on the top floor in which member's could live in. In the early 50's  one member  who had been living there for years  fell asleep on his couch with a burning cigar in his hand. It proceeded to start a fire; evidence of the soot can still be seen today above the outside windows on the top floor  which consumed most of the top floor as well as taking the man's life. Several people have seen a man matching his description  per a previous photo  walking on the top floor. He usually is seen walking down the hall to where his room had been or disappears upon a second look. Also  in the basement  several workers have reported smelling a lilac perfume and some even feel a gentle touch on their shoulder.", "Alta Club", "UT", "Ghost" },
                    { new Guid("4cf9d71c-8158-4790-a928-20d8608298d6"), "Paducah", "A restored mansion  now a rest area  and open to the public. A female apparition has occasionally been sighted on the balcony attached to the second floor bedroom  believed to be the owner's wife. Legend has it she bled to death during an appendectomy. The feeling in that room is very pleasant  however  due to how much she loved that room---her husband had the room and balcony added on especially for her. She has been known to turn off the lights in that room  and the sounds of long skirts swishing as well as the scent of her perfume have been noted. Also  even though the old kitchen is now the employees' break room  there have been times the smells of someone cooking a huge feast have greeted startled visitors. It has been known to happen during the holidays  mainly Thanksgiving and Christmas. It is a beautiful place to visit  even if you don't get to meet the happy spirits inhabiting this great house.", "Whitehaven", "KY", "Ghost" },
                    { new Guid("4d519505-dc57-451c-9670-d86d0c095309"), "Memphis", "If you park your car by the lake in Auburn Park  The Blue Lady is supposed to rise out of the lake and walk towards your car.", "Auburn Park", "TN", "Ghost" },
                    { new Guid("4df7423e-d860-4233-b218-377051ec161d"), "Milligan", "When a closed can of beer is placed beside a certain tombstone in the cemetery and left for about 15 min. It will be empty and still closed when you return. There are extremely eerie feelings and noises as soon as you pass through the gates.", "Cobb's Cemetery", "FL", "Ghost" },
                    { new Guid("4e0bec33-9649-4295-bd19-948688b386d4"), "Mulliken", "On the night of a meteor shower around 6-8 years ago from this date  a friend and I witness what we believe was 4 unidentified spacecra", "Disk", "MI", "Alien" },
                    { new Guid("4e2ef34f-94c0-4df6-b759-96a3d1f09654"), "Corning", "Reports of glowing tombstones and bells in the tower are heard - there are no bells in the tower.", "Beach Grove Cemetery", "OH", "Ghost" },
                    { new Guid("4ed1801f-4b92-44fb-97e7-1c3a8caf6ffc"), "El Dorado", "I was standing in my driveway getting into my car when it happened. My back started to get extremly hot  it felt like I was getting a", "Circle", "KS", "Alien" },
                    { new Guid("4ed50f7d-2700-4e18-990a-e2a2849994c8"), "Meridian  Mississippi  Lauderdale County.  By the NAVY base  In the woods behind Military housing.", "\"When I was 8 or 9 years old  my sister  some friends and I were swimming in a small water hole(more like a wide spot in a creek)  behind the military housing.  Probably about 400 yds. into the woods.  I wasn't swimming I was sitting down at the side of the water hole with my feet in the water but kind of drawn up beside me and my sister was sitting between my legs in the water.  We were all just playing around being pretty loud and I don't know if I heard something  caught some movement out of the corner of my eye or what  but my attention was drawn to a large bush on the other side of the \"\"swimming hole\"\". I sat there staring at this bush for a good 30 or 40 seconds maybe a full minute  before I realized what it was I was seeing.  There was a face looking at me from behind (between) some branches.  The face was very big  flat  dark brown almost black  eyes were black. I thought at the time that the eyes were looking at me with curiosity or amusement.  It didn't look evil  menacing or well you know. I don't remember a mouth or nose.  I remember the hands being huge  gigantic  the size of baseball mitts.  It seemed like I was looking at it for minutes or longer  but couldn't have been that long  and all of a sudden I was just terrified.  I picked up my sister and screaming ran out of there and everybody just followed me out. I was the only one who saw it  my friends wanted to know why I was so scared.  I told them it was Old Man Walker  (A hermit who supposedly lived way back in the woods  and would shoot at you if he saw you)  and they were o.k. with that.  I didn't want to believe what I saw but it defiantly was not an old man. I found it very comforting to know I was not the only one to have seen something so frightening. Thinking about my encounter I was in no way threatened and I don't know why I was so frightened  but to this day I still wake up with night mares. Thank you.\"", "Report 1342: Child sees a large  dark face staring at him from the bushes.", "MS", "Bigfoot" },
                    { new Guid("4ed8c64e-79a3-4654-af6c-825fa6e38990"), "West of Horsetheif Lake about 1mile  just after 4 in row road signs  and before sharp right curve.", "I was driving home to Custer SD from Keystone SD on Highway 244 or known as the  Mt. Rushmore Rd. At about 5:20 in the evening along the side of the road was a large bigfoot.I  looked right at him as I drove by . It was Reddish brown in color  hairy very tall  with long big arms and slightly hunched over. I drove by at about 40 mph and when I looked in the rear mirror it was gone. Later the next day I went back to the spot to look again and found nothing but a well used trail; I didnt go up the trail . It was about 1mile west of horsetheif lake.", "Report 16557: Early evening sighting by motorist on Hwy 244 near Horsethief Lake", "SD", "Bigfoot" },
                    { new Guid("4ef075e8-6301-4fe9-9c78-3b39d1ad86c7"), "Waxhaw", "8 massive balls of light swarming like bees extremely fast and followed us driving home.", "Circle", "NC", "Alien" },
                    { new Guid("4fb65bae-2afc-4293-9ad2-f81f6c31781c"), "Rush Springs", "A very fast light headed from the ground towards the sky.", "Light", "OK", "Alien" },
                    { new Guid("5012969e-c0b3-49c6-81b4-db176b2c8e06"), "Alton", "It is said that three teenagers hung themselves in an old broken down house just off the Floyd River. You can still see three ropes hanging from the rafters of the house. There is a path elading to the house with a No Trespassing sign on it and when you cross it the haunting starts. Legend has it  the haunting never stops.", "Floyd River", "IA", "Ghost" },
                    { new Guid("504d8b20-7539-4d0f-99c3-a2b79c6d24bc"), "Hawkinsville", "Object with 3 large spotlights making absolutely no noise as it flew over us.", "Triangle", "GA", "Alien" },
                    { new Guid("505fc3fe-1fd7-4a10-9128-f1e94678f807"), "This was one of the regular camping areas on Waldo Lake. I couldn't tell you the exact spot without going back to the area which I would be willing to do.", "While we were tent camping at Waldo Lake in the Oregon Cascades  at about 4 am we heard a moaning howl. My wife woke me up and said that there was a bear in the camp. I heard the howl and had no idea what kind of animal made that noise. Another camper a few hundred feet away had dogs that starting going crazy barking. The howling went on for about 20 minutes to a half hour. Our German shepherd started growling. We got up and got in the car with our sleeping bags still thinking it was a bear. At about 5 am and still dark  the other camper left in a hurry in his pickup. It looked like he lit about a half gallon of Coleman fuel in his fire pit. The flames were probably 6 feet tall. We did not see or hear anything else that night. The next day I walked around and looked for signs of the animal. I walked around the other camp and did not see anything. We joked about bigfoot coming that night but I was shocked this last year when I was listening to some of the bigfoot recordings on this site and then heard the moan howl from Columbiana  OH. That was exactly what we heard and it gave me chills.", "Report 11304: Campers hear moaning howl at Waldo Lake at night.", "OR", "Bigfoot" },
                    { new Guid("507a0bc3-66c3-4b12-96cb-5bed4c38c2ab"), "Eliot", "a transparent skull appeared floating above a stare case in a photo taken for a newspaper. Also window randomly broke while kids were playing outside.", "William Fogg Library", "ME", "Ghost" },
                    { new Guid("50bbfd7a-bd04-409e-83ca-3df6f4975a11"), "Rockingham", "If you go there at night a bride will stop you and ask for a ride and she get in and you go down the road and look back and she will be gone.", "US# 1 South Carolina border", "NC", "Ghost" },
                    { new Guid("50fec606-7cf2-4b25-a651-d89836c445b4"), "Camax", "This is a very old bridge with one lane and steel overhead  located on the Country Club road north of Jasper  Al. It has been haunted by the ghost of Moon Mullins for years. She died on the bridge under strange circumstances over 75 years ago. Since her death  several people over the years have reported hearing strange noises and seeing apparitions on the bridge  as well as the nearby Black Water Creek banks.", "Mill Bridge", "AL", "Ghost" },
                    { new Guid("516b6b22-98f4-448f-ae5d-27934626c19f"), "Como", "A rounded shape triangle with bright florscent lights.", "Triangle", "MS", "Alien" },
                    { new Guid("51bcb14c-bef8-4a4a-86e7-b0e6822b70c2"), "Washoe", "Bower's Mansion - Mrs. Bower's  who died penniless after her husband died  is said to haunt the second floor of the house. She used to conduct Séances in the parlor after her husband died  in an attempt to contact him. The Graveyard on the hillside behind the Mansion has also been a spot of numerous sightings of glowing figures on moonless nights.", "Washoe Valley", "NV", "Ghost" },
                    { new Guid("51d1d61c-c569-4924-bade-e624c32041bb"), "Crooked Lake Rustic Camp Grounds near the lake.", "While hunting in the Pinckney State Recreation Area during the last week of deer season my hunting partner and I heard loud whooping or howlling type noises similar to those heard in recordings on this site along with bi-pedal type foot steps through heavy brush. The sound of the foot steps were very heavy and we could hear branches breaking as it moved around.  My partner and I were a few hundred yards apart and the noise came from a thick cover between our spots.  We both heard it as my partner called me on the two way asking if I could hear it too.  I don't know that it was a bigfoot however it was scarry enough for me to remove the safety from my gun and actually swing in the direction it came from knowing my partner was in that direction as well.  I have continued to hunt the area since then and have had no further incident. .", "Report 28023: Two hunters experience possible sasquatch intimidation behavior near Pinckney State Recreation Area", "MI", "Bigfoot" },
                    { new Guid("523fdc26-3760-466b-9243-629d7d151654"), "Approximately 95 miles east of Egegik  Alaska. Up the Egegik River thirty-five miles  and sixty miles accross Becharoff Lake to the far south/east corner of the lake on the mouth of the Bear Creek spit.", "To whom it may concern  I am a commercial fisherman in Alaska and have been doing so since 1970. I am an avid outdoorsman  hunter and someone who just loves to get out there. Every year after fishing  I try to take a trip up river with a friend or two to wind down and enjoy ourselves before we go home. This year while I was on this trip into Alaska's interior our main mission was to take pictures of bears and the surrounding wildlife to promote a new bear viewing and sports fishing buisness. While on our five day trip  we spotted more than fourty bears. I took hundrends of pictures of these bears and their tracks. One of which  was so big  it put chills up my spin and gave me and my companions a very uneasy sense of insecurity. What set this track apart from the others was it's enormous size and human shape. In one of the pictures that I took of this track  I placed my foot next to it on the ground  keep in mind I am wearing a size 13 boot. Whatever made this track was so heavy  heavier than the biggest bear  that it pushed the gravel so far into the earth that it made us truly speculate what we were looking at. Other pictures that we took of bear tracks were nowhere close to the indentation that this track had left. One of the most intriguing things about this track was there were no visible claw marks as with all the other bear tacks. Both of us felt extremely uneasy of our surroundings and had the feeling that we were being watched. For the rest of the day we didn't have much to talk about  and that night felt uncomfortable at camp. We never heard or smelt anything out of the ordinary. To this day I'm not too sure what we saw and I'm not making any claims other than the words I have put fourth. I would like to include the photos I spoke of  as maybe you or someone on your staff might help me shed some light on this situation. I want nothing but to put my mind at ease. Wether this is a bear track from an extrememly enormous bear or...? Please help if you have any input.", "Report 11616: Fishermen find footprints east of Egegik.", "AK", "Bigfoot" },
                    { new Guid("5293572a-6083-4740-86a8-4f641dae7cba"), "Pensacola", "Branch Medical Clinic - The ghost of a navy corpsman killed while stationed there reportedly roams the hallway between the lab and X-ray departments. He always is seen carrying something in his hands and wears a tech jacket.", "NAS Whiting Field", "FL", "Ghost" },
                    { new Guid("529b7c94-c474-4929-92e4-652df8689155"), "Kenton", "Cemetery with nothing but white crosses. Only one headstone existing in the middle of all the white crosses. Chainsaws often heard along with screaming. Orbs float in front of parked cars of visitors.", "Kitchie Cemetery", "MI", "Ghost" },
                    { new Guid("52a62f01-2473-4b70-8546-98ca57ddd750"), "Lamar", "The staff have heard someone walking down the hall  things moving (heavy furniture).", "Barton County Hospital", "MN", "Ghost" },
                    { new Guid("536a91d6-780d-4ad4-a9dc-d3952656edcf"), "Indianapolis", "Saw far away in the sky. Looked like a star but there were no other stars in the sky.", "Sphere", "IN", "Alien" },
                    { new Guid("53fce6ec-616c-459e-b27d-67a5e9f2b46e"), "Keystone", "The old cemetery overlooking Mt. Rushmore is a burial for many of the mine workers and people who died working on Mt. Rushmore. If you bring a video camera you can catch faces in the video camera and white figures hanging from the trees even though you can't see them with the naked eye.", "old cemetery", "SD", "Ghost" },
                    { new Guid("54241230-6683-4933-8038-19bbabb7f134"), "Kapaa", "Array of small white with purple belly lights following eachother in an angle over slleping giant Kapaa HI.", "Circle", "HI", "Alien" },
                    { new Guid("54386d1a-20c2-4d65-a1c5-b64f5dd065a7"), "Independence", "\"Off Service Creek Road there is a very old church and cemetery located along the banks of the Ambridge Reservoir. Service Creek Church was built in the 1700's and the adjoining cemetery is just as old. There are remains of Revolutionary War soldiers  Civil War soldiers and more recent graves. It is still being used. The church and cemetery look like something out of a postcard  but beware. There is an eerie feeling here and total absolute silence. Sometimes  there is an indefinable smell in the air. Behind the church property is the road that runs along the reservoir. - BE ADVISED...it is ILLEGAL to go over the guardrails and down to the reservoir. YOU WILL BE ARRESTED!!! - There are strange faces in the mists and unexplainable violent thunderstorms that suddenly stop once you reach the end of the road. Strange sounds like whispers can be heard late at night. This is a popular lovers' lane area. Violent lightning strikes sometimes hit the banks even when the weather is clear. There are voices here and strange movements and lights  and it is ALWAYS foggy. Reports of strange animals have also been recorded. This was once Indian land. Back in the cemetery  there have been numerous dead animals seen and always a feeling of being watched. When you stand at one of the Civil War graves  you can actually get a sense of how this soldier died and \"\"see\"\" him lying in his coffin. The spirits attempt to communicate with the living. The main road into the cemetery is a pine-tree lined twisting scenic road that leads right into the church parking lot.At night  however  this road is misty and mysterious lights can be seen shimmering in the fog. - PLEASE BE RESPECTFUL...the church and cemetery are still in use.\"", "John T. Anderson Cemetery", "PA", "Ghost" },
                    { new Guid("547c6369-1c8f-4095-be8d-5e18df45ffb8"), "Spectacle Pond  West of Kingman Brook", "Background:  I have spent a large part of my life in the woods between Eddington where I grew up and Deblois where my Grandfather built a hunting / fishing camp in the 1920s – everywhere in between hunting  fishing  camping and hiking.  I have walked those woods since I was 4 years old and I’m now 61 – I know the deer  moose   bear and other wildlife of those woods.  I built my camp on Spectacle Pond in Osborn in 1988.  I have spent a lot of time in the years since exploring the woods and waters around the camp over the years and know the area between Route 179 and Route 193 better than most and within 10 miles of my camp  better than anyone.  Since 2008 when I retired from the U.S. Navy  I have spent one month every year at my camp – 2 weeks in May  fishing and 2 weeks in November  hunting.  I have spent many days and nights in the most remote areas of that part of Maine. On the evening of November 12th  2020  my wife and I had returned to our camp after an afternoon deer hunt  it was dark by the time we got back to camp and settled in for a routine evening with getting the camp warmed up  supper  a couple hands of cribbage and talking – we had been in camp for 10 days.  At around 8:30 my wife decided to go to bed as we planned to hunt the morning.  I picked up my book and was reading until 10:30.  The only light within a half mile of my camp was the single gas light in the front room of the camp which I was using to read – the nearest people were 0.5 mile away in their camp back toward Route 9.  I decided to call it a night at 10:30 and wanted to relieve myself before I went to bed so I went outside across the porch  down the front steps and walked approximately 15 feet to the back outside corner of the camp.  Within seconds of standing in that spot there was two very loud “THWACK” sounds just inside the woodline which is 15 yards across the back yard.  It took me by surprise as I’ve never heard that sound before completely by myself in the woods.  It sounded identical to someone taking a large stick of firewood and hitting a tree in full swing.  I could easily replicate that noise as in knocking snow/ice off firewood against a tree  but with force.  I did not have a flashlight with me as the diffused light from the gas light inside the camp gave me enough point of reference to get back inside so I didn’t think to bring one with me.  I stood there perplexed as to what I had just heard and trying to make sense of it  when it happened again…”THWACK” but this time a little farther away – maybe 25-30 yards  but still quite loud.  This repeated itself 10 or 11 times over a period of maybe 2 to 3 minutes  each time a little more distant than before.  I remained standing there as I was still trying to figure out what it was “THWACKing” these trees.  After the hitting of trees dissipated  I returned to the camp and locked the door – I didn’t (and still don’t) know what it was but I knew it wasn’t a person  moose  deer or bear!  Of note  there was absolutely no light as in a flashlight from a person.  Additionally  those woods are extremely thick with dead spruce and fir – lots of blowdowns yet there was absolutely no noise – no snapping branches  breaking twigs. Nothing – Silence.  I can tell you first hand that nobody could walk down through there in broad daylight  much less at night without a flashlight without snapping branches and making a lot of noise. I spent an additional hour in the camp that night reflecting on what I had heard and trying to attribute it to something that made sense – there was none in all of my experience.  I went to bed and when we got up Friday morning  we decided to hang out at camp to get a start on packing and cleaning as we were closing up camp and leaving on Saturday.  I walked into the woods during daylight where I heard the “THWACK” noises the night before but found nothing where I expected to see some type of sign.  Needless to say  I didn’t tell my wife about those events until Saturday morning as we were getting ready to leave. I still have no idea what it was and it was so dark  I didn’t see anything but I can tell you that I’ve never heard or experienced anything like that in the many years I’ve spent in those woods and the 30+ years I’ve owned that camp.", "Report 67335: Knocks heard near Spectacle Pond  27 miles east of Bangor", "ME", "Bigfoot" },
                    { new Guid("548a34f0-25da-4122-9a31-57a4d0aabb17"), "Missoula", "Grey Spheres flying fast  and low above city  appearing out of nowhere and disappearing into nothing.", "Sphere", "MT", "Alien" },
                    { new Guid("54e4f3d0-490a-4441-8582-112edc1ad996"), "Lacey", "\"A picture taken showed an orb in the \"\"7b\"\" hallway. Rumored to be the spirit of a kid who attended the school in the 80's who died while he attended. There's a plaque commemorating him in the front-left of the school near the bus lane.\"", "Nisqually Middle School", "WA", "Ghost" },
                    { new Guid("55214555-dac9-4a22-b91e-98e8a258b0ea"), "Melbourne Beach", "What looked like a bright green ball entering the atmosphere.", "Circle", "FL", "Alien" },
                    { new Guid("5532155b-2e65-43af-97d3-1df9fd80c1c3"), "location: Hillside above Lake Waramog looking from east to west angle New Preston/Washington line in CT.", "Place: New Preston  CT.   hillside Lake Waramog  Date: 2/16/15 Saw: Looking over lake from riding in a car on RT.45 the hillside saw a black tall figure just walking along so easily  the figure crossed a driveway from the forest to the other side and continued slouching along swinging arms heading towards powerlines approximately 800 yrds away.  It did not have a hat or any other clothing and snowshoes. The head just sat on the shoulder.  I thought it was a man but then realizing no man could walk on such a steep slope without poles  etc. It lasted a few minutes do to the car moving. The black figure stood out against the white snow and sunlight of day.", "Report 48101: Passenger has possible daylight sighting near New Preston", "CT", "Bigfoot" },
                    { new Guid("55ade919-83bf-4c51-be60-fbb8c053a8d9"), "Newburyport", "Massive craft about the size of an aircraft carrier that was hovering and was silent and appeared to be rotating.", "Cigar Shape", "MA", "Alien" },
                    { new Guid("55e421ff-6a4b-4d71-a01a-386143ee1cd1"), "Bayonne", "This was a World War Two Factory active to make P.T. Boats after the war a lot of people lost the jobs. During the war a boat fell off a conveyer belt and crushed 2 men. And now the little girl is seen some times looking for her father and her father is still yell for her. Over and over. Never to be seen again but forever heard!", "Elco Naval Base", "NJ", "Ghost" },
                    { new Guid("55ec6dc3-2da9-4938-a4ee-adb61813098e"), "Bountiful", "Voices heard in the old wood cemetery  strange smells and sounds 1 tombstone was a temple workers for the salt lake temple it is always warm.", "Cemetery", "UT", "Ghost" },
                    { new Guid("5683c16a-3497-4fd6-bd75-2ee07880e565"), "Lake Lynn", "Seen two sphere shaped objects in the sky that definitely weren’t a plane  jet or helicopter. This is the third time we have seen this.", "Sphere", "PA", "Alien" },
                    { new Guid("56959b4e-6925-49b0-8b46-6e9cfb72b55c"), "Crystal Springs", "In the bathroom around 10:45 you can sometimes hear the door open and close. In the back room there have been times when you can hear footsteps. And the lights go on and off and there have been times reported when the microwave has gone on and off by it self. When they lock up there have been odd times when the owner has come back to get something and the door has been unlooked. The employees have seen misty figures floating around then disappearing when someone come in or they hear a loud noise.", "OK Batte Cleaners", "MS", "Ghost" },
                    { new Guid("56a2ab71-7c5f-4085-9a43-58dbabc4576e"), "Keystone", "The old children's park next to the creek across from the trailer park is haunted. If you listen carefully you can hear children playing and laughing. Their is a water pump there that is always shut off but when you walk by it it turns on; just enough to trickle all by itself. Also you encounter many shadow people there.", "children's park", "SD", "Ghost" },
                    { new Guid("56c0db86-f371-4c62-9b19-88c1b1c62b5b"), "Hays", "Approximately 15 lights appeared in the sky and the craft began doing maneuvers in which I could see that it was disk shaped.", "Disk", "KS", "Alien" },
                    { new Guid("571a7e53-aa68-4302-b29b-3c4c20b31139"), "Gladstone", "A college group from Knox College took a field trip to the cemetery next to South Henderson Church. They took cameras and surveillance equipment and found many weird things. They found millions of orbs and deducted that the cemetery is a gateway to the other realm.", "South Henderson Church", "IL", "Ghost" },
                    { new Guid("57266ddf-15ca-4f31-8fdd-e91b234db52e"), "Long Creek", "when ya go there and are alone you build a fire and after a couple of hours you will feel like you are being watched and then you will see things out the corner of your eye a white glow. When you pack up and leave as soon as you get out of there and come to the first stop sign you will go across and see a Methodist church you stop put it in reverse and look in the grave yard and then put it into drive and you will see something glowing and look at you as you pass. after that you will see visions of many people dieing and getting killed. Young girls  boys  old men  old ladies  all and see where they are killed and you will get names how they was killed.. go on 1/20 and be there between 10 and 3 build a fire camp and the start to leave. you also will act different not like yourself...MAYBE like the ones who was killed.", "Grape Vine", "SC", "Ghost" },
                    { new Guid("574ca7e5-5902-4b6b-9243-c54088f5159d"), "Fort Collins", "Two large  bright circular objects initially very close together moved in opposite directions and disappeared.", "Circle", "CO", "Alien" },
                    { new Guid("578cd703-152f-4d61-ba53-74ff41e0cd8d"), "Soldotna", "Shiny metallic craft in morning sunlight", "Circle", "AK", "Alien" },
                    { new Guid("578e8f6d-5158-4f20-bde3-6a5ed59e4ade"), "Castleton", "Two hundred yards off of off of Castleton State College lies an abandoned building. The inside is filled untouched museum pieces that appear to have been left behind. Although there is no way to enter the building -- the objects inside seemed to get tossed around.", "Castleton State College", "VT", "Ghost" },
                    { new Guid("57d3da8c-cd48-4113-bfc4-d9bfedac6d21"), "Described in context above.", "\"This is the third in a set of chronological reports that I am submitting regarding a series of encounters I had between 1970 and 1983 in Nevada  California  and Washington States. This third encounter occurred in August 1972  when I was 12  at my home  roughly ten days after our encounter at the dry wash. I have previously described nearby Peavine Mountain and Lemmon Valley.  Our house was located on the East side of the valley.  It was in a new development at the time  tucked back in a draw among several steep hills.  The surrounding hills rose from 50 to 250 feet above our neighborhood and were primarily granite outcroppings.  The soil was coarse granite sand interspersed with boulders of various sizes.  Where there was vegetation on the hills  it was predominantly sagebrush.  In the draws  the sand was less coarse and there were a variety of grasses and other weeds. We had just moved into the newly completed house a few weeks earlier and were getting to know our neighbors  all of whom had just moved into their new homes as well.  Like many of our neighbors  we were building a fence and otherwise improving our property.  At the time  there was only one thing to detract from the new neighborhood -- the presence of a pack of feral dogs. The pack was composed of four large dogs -- two Dobermans and a couple of mixed breeds.  They were a matter of some concern because many of the new residents had small children and the pack displayed absolutely no trace of fear of people.  They would generally appear around dusk  when it began to cool  and boldly range through the neighborhood.  At night you could often hear them in the surrounding hills  barking and baying occasionally.  It didn't take long to determine that they had no owner and one of our neighbors  an animal control officer for the city of Reno  told us that he had arranged for the county to do something about them. Our home was an \"\"L\"\" shaped ranch  with two of four bedrooms in the back  at the top of the \"\"L\"\"  and a garage in front  at the bottom right of the \"\"L\"\"  facing the street.  We had partially constructed a cedar plank fence around the property  starting in back and working our way around the property clockwise.  We had completed the fence on the side of the property at the top of the \"\"L\"\"  and had built a small section of fence connecting the back left corner of the \"\"L\"\" to the fence on that side.  This created a small cul-de-sac behind the house.  Along the side of the property to the right of the \"\"L\"\"  we had set the posts and rails.  Along the front  where we intended to connect it to the garage  at the lower right corner of the \"\"L\"\"  we had set the posts  but hadn't yet put in the rails.  You could  essentially  walk right into our back yard from the street side of the house  but could not leave the yard on the back side without climbing over the fence. On the night of the encounter  I had picked up all of the two-by-fours we hadn't used as rails yet and I had stacked them horizontally along the base of the fence back in the cul-de-sac.  This was a precaution since they were pilferable and we weren't the only ones building a new fence. My bedroom was at the top  right corner of the \"\"L\"\".  The ground outside my window was about a foot and a half below the floor of my room.  My mother had already planted a small flowerbed of marigolds there.  To protect it  she had me put in one of those small  white-painted  wire trellises that reminds you of a bunch of coat-hangers welded together.  To put it in I had to heavily wet down the ground  then force it in.  Once the ground dried  the powdered granite and sand set like concrete.  It was about a foot high. The incident occurred between midnight and 12:30 am.  It was late summer and I was awake late reading.  I had my window open  but the drapes were closed.  That night  the pack of feral dogs had been more noisy than usual.  Every so often  their barking would become particularly strident  drawing my attention away from my book.  I remember thinking to myself  over the course of fifteen minutes or so  that they were chasing another jackrabbit  then deciding that it must be a coyote  since they'd been going at it for longer than usual  then wondering if they might have a cougar at bay  since they were still barking and baying loudly  but seemed stationary. I was just turning back to my book  when I realized that they had started moving again  and were coming down the street in the direction of the house.  I started to sit up  intending to go to the living room window to see what they were chasing  but realized that they would be well past the house before I could get to the living room in front.  As I listened  though  the noise of the pursuit didn't decrease the way I expected it to do as they chased their quarry past the opposite side of the house.  Instead it grew louder  and I realized that  whatever they were chasing  they were chasing it into our back yard.  I also realized that they might corner it behind the house in the cul-de-sac.  Excited  I started to get up to look out the window. Before I could get up  though  their quarry rounded the back right corner of the garage heading in the direction of my bedroom at the back right corner of the house.  For just a second  I could clearly hear it running  as the sound of the dogs was still partially masked around the corner of the garage.  As it covered the twenty feet between the two corners  I heard three distinct  heavy footfalls -- one just as it rounded the garage  one midway between the garage and the corner of the house  and the third just under my window  where the wire trellis was set firmly into the ground.  This was followed by an incredible impact into the corner of the house.  The force was so great that I could hear the four-by-four upright in the wall crack and the whole room shook.  The impact and cracking sound came from a point about five and a half feet above the level of the ground outside.  Simultaneously  there was a secondary impact about seven feet above ground level across the top right corner of my window as viewed from outside.  The window rattled violently in the frame and I was sure it was cracked.  Immediately following the two simultaneous impacts  there was a forced grunt as if the wind had been knocked out of whatever it was and I could hear its body fall heavily to the ground. My first thought was  \"\"Oh my God!  They're chasing a man!\"\"  The footfalls were clearly bipedal  the height of the impacts was too high for it to be anything four-legged  and the sound of it having its wind knocked out was manlike  if somewhat heavy.  Also from the sound of its fall  it went from an erect to a prone position.  At the same time I recognized that something was strange.  The \"\"man\"\" hadn't called for help  hadn't made any vocal noises at all  in fact.  He had covered twenty feet in what was essentially two strides  and had hit the house at a point too high for all but the largest of men.  The secondary impact across the outside corner of the window was also too high for most people to reach  and the force of the impact  strong enough to make the four-by-four in the house's frame crack  indicated much more mass than any normal person would have. I didn't spend any time really thinking about this  though.  Even though I had an underlying uneasiness because the sounds indicated that the guy was huge  I was sure the dogs were chasing a man.  The dogs closed on the man  snarling and barking.  I was afraid he was lying on the ground  injured or unconscious  and I realized that I had to do something.  I immediately threw my sheet off  jumped out of bed  and reached for the drapes  intending to throw them open and yell at the dogs -- about all I could do in the situation.  In the two or three seconds it took to do this  though  it didn't sound like the dogs were mauling the man.  They were about three feet from the house  stationary  barking and growling.  It sounded as if there were only three of them  two very aggressive and ready to attack  and one that was barking the way a dog would if it were afraid of you  but ready to attack if provoked. Just as my fingertips touched the drapes  the scariest thing I have ever experienced in my life happened (believe me  this is saying a lot for someone who has spent nineteen years in the military and lived through a parachute malfunction).  Somehow the man had recovered from hitting the house  having the wind knocked out of him  and falling.  He had somehow managed to stand up and get his breath back and just as I touched the drapes  from a point immediately outside my window  level with and about two feet from my head  He Growled Back at the dogs. The growl wasn't loud.  It was only about two and a half seconds long.  But it was the meanest  deepest  and most menacing growl I have ever heard in my life (to include those of trapped brown bears at Yellowstone).  It was almost as if he was keenly aware that there were people around  that he knew precisely how long he had to growl to get his point across  and that he didn't want to make any more noise than he absolutely had to. For the next several seconds there was absolute silence.  He didn't make any more noise.  The dogs didn't even make any sounds of movement.  And I was frozen in fear and shock  praying that he wouldn't notice I was there  and afraid he would hear me if I moved at all. It was like that for several long seconds  then  all but silently  I heard him step and brush around the corner of the house. A second later the dogs were after him  but the head start was all he needed.  I heard the stack of two-by-fours tumble down and the sound of him hitting the six foot cedar fence as he went over it  followed by the dogs hitting the fence and then scratching at it and barking.  After a few moments the dogs stopped trying to get over the fence and raced back around the house clockwise. As I heard the dogs racing down the street  I relaxed slightly and gulped for breath.  I hadn't even realized I'd been holding it.  I immediately choked.  The \"\"Thing\"\" had left an incredible stench.  It was overpowering.  It smelled like a combination of wet dog  stale urine  and rancid sweat.  There was also an acrid component a little like burnt rubber.  It was so bad that I staggered away from the window. I stood there for a few moments trying to decide what to do.  The thing was gone  the dogs were gone  and all I would accomplish by waking my parents would be to anger my father.  I decided it wasn't worth it.  I thought about going outside but really didn't want to poke around out there in the dark.  I was struggling with what I had just experienced.  Whatever had been outside my window was manlike  but clearly was not a man.  I had no frame of reference to place it in.  I didn't relate the experience to my encounter at the dry wash because I had so thoroughly convinced myself that that had been a man.  I closed my window (which to my amazement was not broken)  got back in bed  and tried to read to get my mind off of the incident.  Eventually I fell asleep. The next morning I woke after my father had left for work.  I looked out my window and could see that the flowerbed -- trellis and all -- had been flattened.  I got dressed and went outside.  The ground was scuffed but there were no distinctive footprints.  I choked down my apprehension and walked back into the fenced cul-de-sac behind the house.  The stack of two-by-fours was lying there toppled.  I looked at the cedar fence.  The scratch marks from the dogs' nails were clear.  Caught on the top of one of the planks was a tuft of coarse hair.  I stepped up on the lower rail of the fence and looked at it closely in the bright morning sunlight.  It was dark black with hints of brownish red highlights and about three inches long.  It had enough oil on it make it shine if you looked at it closely.  I struggled with whether it had come from the \"\"thing\"\" or one of the dogs.  After several moments of consideration I decided it was possible one of the Dobermans could have had some three inch strands of hair  that the colors were within the appropriate range  and that one of the dogs might actually have managed to make it over the fence to leave it there.  I left it where it was. I went back to the window and examined it and the siding on corner of the house closely.  I didn't see any damage from the impacts.  I decided that the thing had been running  hadn't seen the trellis  and had tried to cut around the corner of the house too closely.  The trellis  strongly embedded in the cement-like soil  tripped it and it fell  throwing its left arm(?) up in an attempt to maintain balance (or maybe grab the roof to catch itself).  The primary impact would have been from its body.  The secondary impact could have been from the left arm slapping the side of the house across the corner of the window. I went in and told my mother about the incident.  I was still very troubled and wanted to know what I had heard.  I discussed it at length with my father when he got home.  He was uncharacteristically patient and explained that it had either been a bear or a cougar.  I couldn't accept either of these explanations.  It wasn't until about a year later that I ran across a tourist pamphlet in Oregon that was about Bigfoot.  I can't express how relieved I was at the time to learn that there was a potential explanation for what I had experienced. We never saw or heard the dogs again after that night.\"", "Report 5770: Four feral dogs chase sasquatch", "NV", "Bigfoot" }
                });

            migrationBuilder.InsertData(
                table: "Entities",
                columns: new[] { "Id", "City", "Description", "Name", "State", "Type" },
                values: new object[,]
                {
                    { new Guid("57e2967d-3674-4951-a185-d68d31a9111e"), "Mesa", "Triangular shaped aircraft without identification lights and completely silent moving against the local flight pattern across the sky.", "Triangle", "AZ", "Alien" },
                    { new Guid("580e10b2-3eab-4903-ae55-3db069e371c7"), "Birch Run", "I went to the door to put my dog out. I saw red and green lights coming across Birch Run Rd toward my house through the trees. I watch", "Chevron Shape", "MI", "Alien" },
                    { new Guid("5814b90a-3010-4d9d-88f9-3c2409999a1a"), "Willis", "During a play  a kid fell of the catwalk over the auditorium. Now  during school you can hear him moaning for help but only in the auditorium.", "Lynn Lucas Middle School", "OH", "Ghost" },
                    { new Guid("5826f89a-3daf-4801-bc86-b680a8822bd7"), "\"On US-26 Sunset Hwy and go West for 9.2 miles Bear right on ramp at sign reading \"\"Exit 64 185th Ave. to Rock Cr.\"\" and go Northwest for 0.3 miles Turn right on NW 185th Ave and go North for 2.7 miles Turn left on NW Germantown Rd and go West for 0.3 miles Turn right on NW Old Cornelius Pass Rd and go North for about 500 feet Turn right on NW Cornelius Pass Rd and go North for 2.2 miles Continue on NW Skyline Blvd and go Northwest for 2.4 miles Turn left on NW Rock Creek Rd and go Northwest for 0.4 miles to Nw Rock Creek Rd\"", "Year: 1994 Season: Fall Weather: Cloudy with drizzle Time: Approx 4:00 PM Location: Rock Creek Rd  Portland  OR Multnomah County X-Street: Old Cornelius Pass (Skyline area) Incident: I was in the kitchen talking on the phone with my sister and looking across the street at the hillside beyond the creek through the kitchen window. The dogs were barking so I was curious to know what was going on outside. I saw the bushes moving and I saw what looked like a very tall   broad  stout  hairy person  almost ape looking  with long dark brown hair. It was rustling through the bushes. The leaves were moving. I looked at it for about two minutes trying to see what it was. Then it disappeared. I was describing what I had just seen to my sister on the phone as it happened. I felt excited and scared. I locked the door and checked for the twelve gage (my husbands gun). I didn't see the Sasquach after that. But once in a while after that  my dogs would bark in that different wimpering way. Not their normal bark. My sister was watching a documentary about Sasquatch in the Portland  OR area on the TLC Channel (The Learning Chanel) that aired on Friday  Oct. 27th 2000. That reminded her of our conversation on the phone when I saw Sasquach that day. She called me to talk about what I had seen because she did some research and found the bfro.net web site and encouraged me to document the sighting.", "Report 531: Woman witnesses large  hairy man-like creature outside home", "OR", "Bigfoot" },
                    { new Guid("585c1ca9-ad25-46dc-acb4-4bff1f5aef96"), "Conneaut", "During a fire in the early 1900's  a young bride named Elizabeth was killed while trying to escape from room 321 on the third floor. Her ghost has been seen walking down a narrow hallway on that same floor. Ironically enough  the fire escape is located at the end of the hall. Elizabeth seems to be a likable spirit though. She has been known to help employees by moving things around in various rooms. People have also reported seeing ghostly figures dancing in the ballroom  which is located on the first floor. Their origin is unknown.", "Conneaut Lake Hotel", "PA", "Ghost" },
                    { new Guid("58ca3d78-cd26-4147-9976-b5b50a0ea642"), "Durham", "We saw a white rectangular-shaped object very high in the eastern sky moving very slowly.", "Rectangle", "NH", "Alien" },
                    { new Guid("58d0b87b-d35a-4696-98db-bbf0b827f2ee"), "", "On May 8th 2016 I was riding my four wheeler over on Fort Hill road in Oxford Webster area in the woods. I just hanging out by a swamp clearing a trail and had a weird feeling where something was watching me. My back was turned to the swamp and I heard a small splash coming across the swamp and didn't really think nothing of it. About thirty seconds later I heard another one and that one caught my attention but I didn't see it. It was bigger and it was in the middle of the swamp. So I dialed my buddy and as he picked up the phone  a rock about the size of a football  if not bigger was thrown about three quarters across the swamp and I saw this one hit the water.", "Report 51902: Strange encounters and possible tracks found in a swamp near the Douglas State Forest", "MA", "Bigfoot" },
                    { new Guid("599a7e80-d79e-4102-945c-fe8337b4a5b9"), "Baltimore", "Robert Long House - Reports of weird feelings are felt on the first floor  which has been restored. The 2nd floor is where noises were heard. The 3rd floor  which still had smoke damage from a fire. This was a very cold place that had worse feelings.", "Fells Point", "MD", "Ghost" },
                    { new Guid("59ba8c13-b24e-436e-a303-fe019b94e77f"), "When you come from Milton on route 30 heading east towards Millsboro you come to xxxxxxx Rd and take a right the home is in the wooded area down about 1/2 mile. The whole area in surrounded by wet lands and Pine trees", "On 11-13-12 my wife and I just returned from the store and I stayed out by the car as she walked in the house after a couple minutes of me messing with her phone and some slight music playing on speaker  I heard the most blairing scream I have ever heard in my life and to follow. 4 blasting knocks. I screamed for my wife and told her I believe I just heard a squatch  she rolled her eyes and said if you would stop trying to call them after you watch the show they wouldn't come and then 4 more loud knocks. She went back into the house and while I stood there I could here the trees moving around  I have been watching the show and joking with the kids and wife with calling them in the rear of our wooded lot but after hearing this I can honestly say they are out there. This couldn't have been 100ft away from me and was so loud that it felt like it was next to me  I don't know if it was the light music playing that had it let me hear it or the practice calling in the rear yard but there are definitly BIG FOOTS IN DELAWARE", "Report 37386: Couple hear possible screams and knocks at their home near Redden State Park", "DE", "Bigfoot" },
                    { new Guid("5a10fec6-799e-42ca-b0a7-dce601edb047"), "Park County", "Cowboy Bar - Footsteps  when no one in there. Glasses falling  full from the bar  and not spilling a drop. Seeing and hearing someone order a steak. Bottles flying of the shelves. Bullet holes in walls  a wake held  with the dead man laying on the bar  Several murders in and around the bar.", "Meeteetse", "WY", "Ghost" },
                    { new Guid("5a12a76b-276a-4721-94d9-4dc539ca4136"), "Whitefish", "\"Saw bright \"\"star\"\" that changed into red  white  and blue lights. Emitted a beam of light in a horizontal sweep of the sky. Darted hor\"", "Unknown Shape", "MT", "Alien" },
                    { new Guid("5a386621-e529-43c5-99d5-7ed04d336caf"), "Not sure of the county.Michigan's U.P. M-28 east of Munising.", "When I was stationed in the U.P.of Michigan's K.I Sawyer air force base I travelled sometimes to see my family in the Detroit area.This was 1977-1978.A friend and I were driving on M-28 east of Munising.They may call it the Seney Stretch area.This was after an afternoon shift so leaving the Marquette area at midnight or so would put us in the sighting area at around 1:30 am.This was winter time and quite cold.as we were driving we both were looking down the road straight ahead.A mile or so up the road was a slight knoll or small hill and we could see the glow of headlamps from the other side highlighting the top of the knoll.Between us and the headlamp glow we observed what we first thought was a bear crossing the road.It was at least 1/2 a mile up the road but the headlamp glow from the other side of the hill outlined this thing quite clearly.It walked sort of hunched over until it reached the center of the road and then it stood upright and we could make out broad manlike shoulders and arms.Bear shoulders are tapered downwards.These were broad.It then shlouched over a little and crossed the road.We just looked at each other with our jaws open.We slowed down near the area.It was cold there were no houses or lights in the area and there was no reason for a man to be in this area in that weather at that time of night with not a house in sight.I don't remember if there was a bright moon or not but we looked for tracks.We didn't look for long due th the temprature and the unknown in the middle of nowhere. I have mentioned this to people over the years and always wondered what it was that I saw.I never thought there may be interest in this subject in that area.", "Report 20457: Nighttime sighting by Air Force personnel near Seney National Wildlife Refuge", "MI", "Bigfoot" },
                    { new Guid("5a607d25-a495-4634-88eb-bf78ebd91ed0"), "Green River", "\"You can hear strange noises and books fall off the shelves at night. Daily Rocket - Miner Reporter stayed the night in the library. Had many different eerie feelings. But didn't see anything until he remember his recorder recording in the conference room. It had several unexplained clicks on it. Then about halfway through someone breathed into it. Then on the other side of the tape  a small girl yells out  \"\"HELLO!\"\" And he and another reported were the only ones in the library! One night the janitor was vacuuming and the light came on upstairs so he ran to turn it off  but when he returned the vacuum was gone and then he heard someone upstairs vacuuming and when he went up there nobody was there! - June 2008 Update / Additional information: they built the new library on the old city graveyard. A new graveyard was constructed up the hill and it was thought that all graves had been removed from the old site and were accounted for. Not quite. During construction  workers dug up several old caskets  which broke open with the bones falling out! Spooked the workers good. Ever since  the library is thought to have been constructed on \"\"bad\"\" soil  like out of some horror movie plot.\"", "Green River Library", "WY", "Ghost" },
                    { new Guid("5aa92741-25a8-4047-8326-734f767549bc"), "Southbound on highway 77  near Blue Springs  Nebraska ", "While traveling southbound on highway 77  near Blue Springs  Nebraska  I encountered a very large bi-pedal creature. As I came around a gentle left curve in the road  this creature stepped up out of the ditch on my side and with one stride was upon the road bed and with two more strides was across and going down into the ditch on the other side  a car coming the other way also saw this and we both slowed to a crawl as we came to the spot  I asked if they saw something and they responded they had also seen it. I was most impressed with the girth of the creatures legs  and torso  it was massive and about 7-8 feet in height  I would estimate the weight to be 6-700 pounds  the body was covered in medium length blackish brown hair  and the face appeared to be less hairy  I was not close enough to see any facial features  the arms swung normally and were longer than a mans proportionately. The quick stride and the movement was what impressed me the most along with the sheer mass. I'm familiar with the bigfoot lore having lived in California  but I never thought I would see one  especially in Nebraska. There was a creek just south of where the creature entered the road way  it seems it could have gone under the bridge if it wanted and remained unseen  it did not appear alarmed  just quick. This incident occurred in the Fall of 1974 I believe. I'm fifty and been an outdoorsman all my life. Good luck  hope you catch one  then maybe they will be protected  just don't kill one  might be the last one. the incident made a believer of me regardless what people say  I've seen one.", "Report 1149: Late Afternoon sighting by motorist near Blue Springs", "NE", "Bigfoot" },
                    { new Guid("5ac36b59-60fb-450f-8636-4aa673c56916"), "Woonsocket", "The ghost of an elderly brother (priest) is said to roam the halls of the 4th floor after dark.  Apparently he was murdered by a student way back in the early 1900's when the Academy was an all boy’s boarding school.", "Mount St. Charles Academy", "RI", "Ghost" },
                    { new Guid("5ad66894-7416-48ae-87da-34bc00d0318a"), "Investigator Note: The location is where SE 60th Street (Route 364) crosses over the South Fork of Ninnescah River. For the Google Maps pin for the location of the figure seen in this incident  .", "When you enter Kingman County from the [east] on [60th street]. It was on the first bridge you come to. He was on the west bank. Just north of the bridge. It is wooded right there but surrounded by farmland. I am handicapped so I cant walk to where he was. My son could but I didn't even think of it. It just happened day before yesterday and its been raining.", "Report 69193: Two motorists spot a Sasquatch TWO DAYS AGO on South Fork Ninnescah River 30 miles west of Witchita", "KS", "Bigfoot" },
                    { new Guid("5b09a7d3-908d-4699-b6e9-021ccce633c7"), "Newark", "people say there are a family of six walking across the highway. Back in the 1900's the family of six was hung because of witchcraft  ever since then they hunt the highway to find the relatives whom hung them.", "Salem Church Road", "DE", "Ghost" },
                    { new Guid("5b10fdbb-3d27-41f7-924d-6ddd29f66ab0"), "East Alton", "We saw a bright blue-green object streak across the southern sky at a great rate of speed travelling from east to west.", "Light", "IL", "Alien" },
                    { new Guid("5b25099d-780a-4aa3-ab55-139b4acb0ca1"), "Oatman", "Room 15 - Many guests and staff testify that it is not uncommon to hear whispering and laughter coming from this empty room. There is also a Theatre Room Museum on the second floor  where dust on the beds reveals the outlines of sleeping guests  leaving adjacent areas intact and undisturbed. A former chambermaid's ghost has also been sighted.", "Oatman Hotel", "AZ", "Ghost" },
                    { new Guid("5bc7a7d3-8fa4-4c2d-a573-73de583d0e9c"), "Mesa Verde", "The spirits of the ancient Anasazi walk in and around the ceremonial pit houses (kivas).", "Cliff Palace", "CO", "Ghost" },
                    { new Guid("5bc91c56-f9cf-4d61-9a03-d9483d57e8f1"), "Pittsburg", "Full Triangle shaped with white light on each corner  silent  moving faster than most airplanes or jets I have seen.", "Triangle", "KS", "Alien" },
                    { new Guid("5bd11b2e-0da1-4c76-b8d6-c76032d63aaa"), "Rowland", "Triangular shaped with 3 blindingly bright lights gliding silently over my head and onto bypass.", "Triangle", "NC", "Alien" },
                    { new Guid("5bd1da73-ba58-4f8e-846e-7ae2a31e6ed2"), "Sitka", "\"On hunting trip  woke to see object hovering over bay and \"\"navigating\"\" up the bay and up the head waters and out of sight over hillside\"", "Disk", "AK", "Alien" },
                    { new Guid("5c60215b-f915-4f42-b666-c3d8ee4e3de4"), "From Hwy 43  turn onto Rabbit Trail Rd. continue about 30 miles to Blooming Grove Rd.  turn left and continue to Revilo Rd. Stay left until you reach Mt. Zion Rd.  turn right and continue until you cross the low water bridge and you arrive at the Mt. Zion church.", "While on a day trip to a very remote local cemetery in the pine barrens near Appleton  Tennessee my family and friends observed a freshly fallen tree across Sugar Creek about 150 yards south of the Mt. Zion Church entryway. Visitors have to cross a low water bridge on Sugar Creek at this point. Was a very pleasant day in May (31st)  with blue skies and a light breeze. After about a half an hour we heard what could only be described as the most unholy sound any of us have ever heard coming from the area past the fallen tree on Sugar Creek (about 1000yds away from us). It was no cow  donkey  horse  etc. My wife and best friend heard this sound and in fact captured it on our camcorder. It is nowhere as loud as it was in person  but I do have it recorded.", "Report 23916: Family records possible vocalizations in daylight near Mt. Zion Cemetery", "TN", "Bigfoot" },
                    { new Guid("5d0a74a4-6f61-43de-b26c-3f70e17bd5ac"), "Monticello", "At midnight you can go down Nola rd. and look at the church and see something in the window glowing. There have been people go in there and see a woman in a whate dress chase them out.", "Shilo Baptist Church", "MS", "Ghost" },
                    { new Guid("5dadc468-d5b4-4673-b672-7c430ea2ebfa"), "Elgin", "While looking up at sky I noticed a bright light hovering above the sky. then I noticed a jet airliner traveling in the same area and I", "Cylinder", "IL", "Alien" },
                    { new Guid("5dd8f28a-9cee-403b-9804-1763af365120"), "Los angeles", "Looked like a red star with an oval shaped ring of light.", "Light", "CA", "Alien" },
                    { new Guid("5e7d0663-8d5e-4912-89ea-7099f2a1ba7a"), "location ny interstate 390 north too the ny state pkwy going west at or over iland cottage rd there is a little pond in the middle of entrance and exit from 390 to pkwy and iland cottage rd is on the norteast side", "well here is my sighting. on june 20th 2004  [near] rochester [and] greece  me and 2 friends where out on a bike ride like we do three times a week. we start at 104 and fetzner rd in rochester new york and travel down the bike trail too the [parkway] and iland cottage rd. we always stop at the pond and [our] bike rides are well into the night around 12 - 1 am. we hang out for a while then head back home. what would make it a 15 - 20 mile bike ride. while standing talking we all noticed something standing behind tree. it was about 7 - 8 feet tall tan in color or gray fur. it stood out in the black background. one of my friends start[ed] heading towards it and so did the other and then me with my headlight. when the first friend moved the thing started off too the woods on 2 feet. my one friend said he seen it turn around and look at him. i just seen it go into woods. when we got too the woods which woul be heading west next too parkway  one went in a little. me and other stayed on edge. we stood still and heard alot branches and then silence. don’t know if it was related too [our] sighting but seemd like the only sorce at the time because [of] what was seen. it was pretty chilling and strange. felt very weird like it wasn’t happening.", "Report 8905: Three men have a late night encounter with a bi-pedal figure", "NY", "Bigfoot" },
                    { new Guid("5e85c263-026b-4e51-ba97-be24b5f1a29b"), "Cullowhee", "Harrill Residence Hall - 5th Floor - It is said that a girl died of an asthma attack while her boyfriend was sleeping over. She suffocated in her sleep before she could be saved. It is now said that the 5th floor as well as the elevators are haunted by her ghost. The elevators open at the 5th floor  and then go down to the first floor  opening again. The elevators have been known to randomly open with no one in them on all floors. Strange occurrences and the feeling of being watched have been reported on the 5th floor.", "Western Carolina University", "NC", "Ghost" },
                    { new Guid("5ea4ca8c-6c6b-44af-a8c2-a8b3ddfe7788"), "Quincy", "There are lights in the back corner of the cemetery at nighttime. When you walk forwards you can see something hanging in a tree and if you blink it will disappear. Up in frobt of the mausoleum you can see and hear little children playing  and when you walk towards them and smile they will smile back at you  and wave and disappear.", "Greenwood cemetery", "IL", "Ghost" },
                    { new Guid("5f0b0731-4d53-4641-867d-19540fb25477"), "Off of Rt 2 on Greer Rd.", "\"We were riding our 4-wheelers in Mason Co WV  We were off of Greer Road on a friends property and stopped to get something to eat. This area we were at is not populated at all. I went over and sat on a log to eat and my husband asked me what kind of track was by my foot  When I looked down I was astounded! My husband wears a size 13 boot  And this was in cold weather so the thick boots make his foot look even bigger and this footprint made his look small! it was atleast 16 to 18 in long and 6 to 8 in at the widest point.There were about 3 or 4 more footprints leading down to the creek. I walked up and down the banks looking for more but I couldn't find anymore. I am 5'9\"\" and have fairly long legs and I could not put my foot beside one of the prints and reach the other one. This was one of the most amazing things I have ever seen! Regretably none of us had a camra  but there were aprox 15 of us who seen these. Everybodys first reaction was that it was a hoax  but in my opinion if someone was going to fake this they would have done it in a more populated area. Our friend Jack   whos property we were on called the Department of Natural Resourses to ask them about this  they sent one truck down to look at the print. This truck left and came back with about 5 more trucks. They told Jack not to come back there while they were there. After they were done one of them stopped and told Jack that it was only a black bear print  I am no zoologist but I have seen black bear prints  and this was not one. There were no claw marks  but there were toes. And if that was a bear  and it left tracks that big  I wouldn't want to meet it! This happned in winter of 2001  I have not told very many people because the ones I have look at me like I need to be locked up! I am very glad to find this site  and to share my amazing experince with people who understand!\"", "Report 7241: ATV'ers find footprints near Pt.Pleasant", "WV", "Bigfoot" },
                    { new Guid("5f18a0b8-97b7-45c4-a3fa-b380b9f18ada"), "", "\"When I was 14  I had gotten up early one Saturday morning to go squirrel hunting on a small piece of property by my parents house. This stretch of woods is located in Greenup County Kentucky in Northeastern KY. The property is bordered by a small creek \"\"Raccoon Creek\"\"  and a river  the \"\"Little Sandy\"\". I hunted this area on a daily basis when I was younger and had never seen anything unusual. On this particular day in early September  there was a heavy dew on the trees so it was easy to hear anything moving as the dew would fall and make a very distinct noise. I was walking down the ridge top overlooking Raccoon creek and had not made any noise since arriving way before daylight. As often happened  my neighbors dog followed me that day and I thought I had ran him off a couple of hours earlier. Everything was completely still with almost no wind that morning. I started to hear the dog  \"\"Gruffy  start barking and growling in a way that I had never heard before. At first I tried to ignore the noise but after a few minutes I decided to go run him off again as he was destroying my hunt. As I quietly eased down the ridge about 50 yards  I saw what I thought to be a young bear through the trees. The animal was standing on it's back legs and was only around 6' tall. I noticed that as Gruffy would lunge at the animal it would knock him back with its hands. He would let out a yelp and then go back after the animal. I eased closer being as quiet as possible planning to shoot near the animal to keep it from killing the dog. As I got directly above the animal it noticed me and turned to look directly at me. This is when I noticed that it was not a bear. I did not immediately distinguish the animal as a Sasquatch but was very confused as to what I was looking at. The animal growled visciously which scared me more than I have ever been scared. When Gruffy noticed me he ran to me and kept barking at the animal. I thought about shooting the animal but decided that with a 20 gauge shotgun at this distance with #6 shot that I would just tick it off. I started to walk backward slowly. After 3-4 steps the animal let out a blood curdling growl. I literally threw my shotgun down and ran home. When I got home  I told my father about what had happened. After he got over the fact that my gun was still in the woods  he decided to grab his rifle and take me back to get the gun. He would not accept that this was anything other than a bear. I have never spoken of this encounter because if my father would not believe me then who would? Although black bears are in the area  I have only seen one in the wild in the area. I have been an avid hunter my entire life and hunt everything from Ginseng and Yellow Root to big game. I still am not entirely sure of what I saw that day but I know it was not a bear and it was not a human. A human couldn't possibly make the sounds that this animal made at the volume it made them.\"", "Report 51739: Memory told of seeing the neighbor's dog going after a hairy biped while squirrel hunting near Greenup", "KY", "Bigfoot" },
                    { new Guid("5f39d068-e907-444b-87c7-0e632aeca945"), "Acton", "a sighting of a ghost husky (dog) with threelegs roaming the shore  it has a dark and a light glow. Late mornings around 1:00 or 12:00 a.m.", "Loon Pond", "ME", "Ghost" },
                    { new Guid("5f784635-24e5-4015-8fc0-e23289009424"), "Ladysmith", "Is said to be Haunted. Possibly built on a cemetery. Rumors of Ghosts. One rumor of a man in a red flannel shirt that was killed with an ax. People that live near the trailer court close by have said they have seen this man standing in their living rooms just watching them.", "El Rancho", "WI", "Ghost" },
                    { new Guid("5f81810f-5e14-41e9-bd15-1ff179d7a0b2"), "Newark", "In the early 70's a runaway girl was taken into the woods and killed here. The killer was never caught but sometimes a pleading high pitched voice and muffled screams can be heard from the woods just off the Swamp Forest hiking trail which goes around Lums Pond.", "Lums Pond State Park", "DE", "Ghost" },
                    { new Guid("602dbcba-e91b-4aa1-841e-baceba038bd1"), "Chinook", "I was outside of my house admiring the night sky when I noticed an object streak across the sky and then stop very quickly. Then anothe", "Changing Shape", "MT", "Alien" },
                    { new Guid("60910961-8bd7-403f-816f-6947cca086ef"), "Hwy 19 in Trinity to FM 230 to Eastham prison to property across the road.", "While letting my two dogs out to use bathroom there were deeps screams/clacking of wood and sounds like trees breaking. 12/15/03.  Something carried off deer feed bucket made a big mess out at feeder area. This is ongoing noise as this house is in a very remote area of woods/creek/pond and deep ravines.  My horses were so spooked from the screams that they were running into the fences I had to calm them down.  This house sits in the middle of the 30 acres wooded area.", "Report 7604: Possible bigfoot activity near Walker County line.", "TX", "Bigfoot" },
                    { new Guid("609be913-4f62-465e-869d-e3e38ea1a32b"), "Pasadena", "A long  white cigar shaped object flew across the sky  disappearing a couple of times  then shooting straight up.", "Cigar Shape", "MD", "Alien" },
                    { new Guid("60b3e466-13d0-487f-b2c9-23edd065b7b1"), "Woonsocket", "It was said that 2 people got killed falling off the scaffolding during the original building of the high school. One of the two who were killed has been seen and felt in the auditorium on multiple occassions by kids in the band and chorus. It shuts down lights  turns on the spotlights  turns on the music and other audio equipment.. and it has been heard that it sometimes makes noises during nightly rehersals  etc.. It once shut the curtains half way during a senior assembly. (there is a ladder that leads to a dark tunnel near the ceiling to get to the spotlight room). The spirit has been seen in the spotlight room and everyone is now too afraid to actually go up there.", "Woonsocket High School Auditorium", "RI", "Ghost" },
                    { new Guid("61400081-9b34-4ab9-98c7-cc8e74fc79eb"), "On rte 321 toward rte 301  near the SC/GA border", "On July 9th we were driving from NYC through the Carolinas for a vacation with family members. While driving on 95 I missed my exit and continued on 95 til south of the border. We weren't sure if we missed our exit so we got off the highway and went to a gas station to ask for directions. I was told to take Rte 301 off 95. This is in South Carolina. While on 301  about 10 minutes into it  I was driving at about 70-75 miles an hour when out of the dark  a black  hairy  tall thing crossed the road in front of us. It was not a bear.  It stood like a person with a slight bent. It had hair all over its body. I had to turn the wheel to the left to avoid hitting this thing.  It almost hit the right side of my van. The screams inside my car were frightening. We almost lost control of our car. I saw it  so did my wife  2 aunts and my 7 seven year old granddaughter. It happened at about 12:30-12:45am  July 9th.", "Report 12205: Late night sighting by motorists near GA/SC border", "SC", "Bigfoot" },
                    { new Guid("615300e9-379b-46b9-8a38-9aed5d462908"), "Couer D'Alene", "This is haunted by a strange apparition that haunt the auditorium of the school right before we turn out the lights for a play. After clean up from a production and right before; at the back of the auditorium is a ghostly figure that walks paces behind the last row of seats. The next day storage room doors are open and things are strewn about.", "Couer D' Alene High school", "ID", "Ghost" },
                    { new Guid("61682461-0528-40d4-aac8-76acd258df3b"), "Eugene", "A young boy was shot on the playground. And whenever any one goes there after 12:00 they are approached by a ghost child  Who warns people to stay away.", "Woodland Park", "OR", "Ghost" },
                    { new Guid("622735b1-c1e4-4d08-9e45-2f977aee4e22"), "Hay Springs", "a presence of a male has been felt.", "Hay Springs High School", "NE", "Ghost" },
                    { new Guid("623f9551-1ebf-4b6a-b9d7-669d61a46b00"), "Vicksburg", "\"This home is one of the oldest in Vicksburg. There have been investigations by many paranormal investigators. There are more than a dozen restless spirits in the home  making it known as \"\"The most haunted home in Mississippi\"\" as one investigator put it. Ghosts range from Civil War soldiers  to former owners  to Native American Indians. Thousands have seen some of these ghosts.\"", "McRaven Tour Home", "MS", "Ghost" },
                    { new Guid("62642919-5801-4b88-b0c4-f67e14295826"), "Scottsbuff", "There is a female spirit clad in white that walks along the base of the opposite bluff  around the end of July and beginning of august around midnight or one in the morning. Sometimes you'll see her  sometimes you won't. A lot of people have besides me...but you got to look closely  and be patient.", "Scottsbluff National monument", "NE", "Ghost" },
                    { new Guid("62e36d07-142d-4e03-b5e3-06f242c6dfcc"), "Prairie Du Chien", "It has been in the news paper a lot  about a man walking around the town. The residents there believe that he is a ghost.", "Wyalusing Academy", "WI", "Ghost" },
                    { new Guid("63282afb-3f2a-4201-9633-261b96350836"), "Dover", "A Judge’s angry spirit walks among the nearby tombstones and on the Green. RI", "The Green At Dover", "DE", "Ghost" },
                    { new Guid("6336f4b4-1529-4cd1-b2b1-6c6cadd5ed85"), "Salt Lake City", "There is story of a lady who was killed the night of her wedding walking across b street and if you go to the spot where she was hit and you park your car and turn off the lights you can see her cross the street in her wedding dress. And voices have been heard on tape recorders of a girl's whisper asking for help.", "Memory Grove", "UT", "Ghost" },
                    { new Guid("634bdacb-08e0-4dd0-9faf-2826bc809aad"), "Caryville", "There are about twenty graves in this cemetery that are located at the top of a hill  next to a river. People have seen faint images of children running in the field and headlights shining through the river. If you stop and turn off your lights on the way to the hill  hell hounds can be seen.", "Old Cemetery", "WI", "Ghost" },
                    { new Guid("643bbea3-4bfc-4ad3-8d7e-efff75446b3d"), "Piedmont", "Very large oval ball the same color of the mixed gray and white clouds", "Oval", "SD", "Alien" },
                    { new Guid("6442ccee-5f5f-4f27-a96d-9dc46ffd0098"), "Park rangers are trying to keep this quiet  but have had reports of bigfoots and tracks. The tracks I saw were on the Futures Trail above the first parking lot and below the power line at Mt. Ascutney State Park in Windsor  VT.", "\"I research mountain lions in NH  but I was caring for my mother and hadn't gotten out since Christmas Day  2014. On 5/24/15 I decided to just go for a walk  no research. I did a Meet-up with someone who walked much faster than me. She left me at the power line. I was way downhill  but was determined to at least make it to the power line. I did  but when I turned back to go down to the car  I saw two huge prints near a tree by the trail. When I got to them  the heels were 3-4 inches deep in the soil and leaves. They touched and the toes went out and away from each other like a duck's feet. They seemed to be 15 inches long  but it was hard to tell with all the leaves  unevenness  grass  etc. I took photos and measurements (even on a walk I take a camera and tape measure). It was interesting as hiding by that tree the Futures Trail went right past the tree  above was the power line and behind the tree was the park road  so that it was an advantageous hunting spot as animals coming from six different directions could easily be hunted down. Going back to the car  I saw two more tracks to the right of the trail. One was about 10 inches. The other seemed to be 15 inches  but with a 10 inch track inside it. The toes were 5 inches across for the three toes that were embedded in the bank. The other toes were over the hardened trail. There was also a 5x6 inch parallelogram shape. I kick myself now as I didn't take a photo. Later I saw a knuckle-walking gorilla on TV and thought  \"\"That's what that was!\"\" It was a knuckle print and also was very deep. At the bottom I asked the ranger to do a casting and he said I could instead  so I bought plaster of Paris. It wasn't enough. I had to go back several days later (rain). The casts are awful. There were too many leaves  the toes broke off  etc. The interesting part was that the park ranger acknowledged the report with a \"\"Yeah  we get lots of reports of bigfoots  but we try to keep it on the down low.\"\" When I asked him about mountain lion sightings  he seemed scared and said  \"\"You think there are mountain lions up there?\"\" It was odd that bigfoot was \"\"normal\"\" and mountain lions were \"\"strange\"\"! When I came back  I heard from someone else that this same ranger had been followed down the hill by something he nicknamed Roy. He was hoping it was a bigfoot and not a lion. Part of his job is to clear the trails and make sure everyone is off the mountain. That night it got dark  and he was also \"\"helped\"\" off the mountain  though \"\"it\"\" always stayed the same distance behind him.\"", "Report 49902: Possible footprints found by a hiker on Mt. Ascutney", "VT", "Bigfoot" },
                    { new Guid("64ebdcac-6477-4f0d-bf91-f71ae292bb12"), "Reno", "Earlier the Wooster colts lost the zone final to the McQueen lancers. One guy went out to the football field later that night and shot himself. Now whenever the lancers play on the Wooster field they have said they trip over nothing at all. They say that something or someone tripped them.", "Wooster High School", "NV", "Ghost" },
                    { new Guid("6501eac8-5863-4102-9b03-46a78e03ae0f"), "Castleton", "Ellis Hall - Ellis Hall has been part of Castleton State College for years. On the second floor in this building a girl student killed herself and now students here her flushing toilets running showers and the sink in the bathroom. Almost every building at Castleton State is Haunted.", "Castleton State College", "VT", "Ghost" },
                    { new Guid("6528b73d-fd9c-4411-bb63-ab5d112f6c32"), "El Paso", "The building itself used to be a hospital and the room that gets the most activity was supposedly the surgery room. The room is currently the weight room  people have said to have been in there and the radio will turn on or off by itself  the lights will turn on and off  or people will pass the room and see nobody in there but the weights will be moving.", "Main Police Department", "TX", "Ghost" },
                    { new Guid("65307cdd-8f30-43f9-a1e1-40eb8d0b86cf"), "Vicksburg", "The Queen Victoria Room is haunted by a hazy  transparent woman who appears at night in front of the room's right window and floats past the fireplace  then her figure disappears into the area behind the bed. Her footsteps remain  pacing back and forth in the spot that she vanished. This continues for a few hours until about half an hour before the sun comes up.", "Cedar Grove Mansion Bed and Breakfast", "MS", "Ghost" },
                    { new Guid("65560abe-8c99-43a0-aa64-09c7ae5c7b65"), "Manchester", "Objects where flying in two staggered v shaped formations. They approached from the south east heading northwest.", "Formation", "TN", "Alien" },
                    { new Guid("65661b98-cc0b-46be-a6bc-a0b16faa1fa3"), "West Chesterfield", "Reports of seeing flishing lights  hearing a baby crying  and a loud screeching sound.", "Riverside motel", "NH", "Ghost" },
                    { new Guid("6567261b-a194-46e4-8ab5-40efdb1f67f8"), "Logan", "The ghost of Mame Thurman  a lady killed on June 22 1932 by a still unknown killer  has been seen walking the woods where she was killed. Mamie Thurman", "22 Mine Road", "WV", "Ghost" },
                    { new Guid("65861343-1629-492e-8b25-20c0ca3cfd42"), "Minneapolis", "I saw a light in the sky  it was moving around at odd angles  would disappear and reappear. I had pointed it out to two people who were", "Light", "MN", "Alien" },
                    { new Guid("65a23e50-75ce-4d1b-b458-1c43e2720cac"), "St Louis", "I was in my room watching tv when I looked out the window to see a huge blue flash that lit up the sky. I could see everything as clear", "Flash", "MO", "Alien" },
                    { new Guid("660ec3fc-fadc-479f-a48f-8d754a1b7ebe"), "Grapeview", "Residents in the park would see a reflection of an old man in mirrors  rocking chairs seems to rock by themselves  and feelings of being watched.", "Benson lake", "WA", "Ghost" },
                    { new Guid("6670c187-dd23-4f5e-93a1-c952a3f6abb3"), "Gautier", "We saw two stars slowly moving in the milkyway  stopping  starting  making right turns  shining a light.", "Odd Shape", "MS", "Alien" },
                    { new Guid("668a0eaf-60a4-4159-92d8-fbf389058a5e"), "Gold Hill", "Several rooms and guest houses are said to be haunted. The owner of the hotel says she has never experienced anything but guests and employees have smelled unexplained smoke and alcohol  and alarm clocks buzz every hour even when unplugged.", "Gold Hill Hotel", "NV", "Ghost" },
                    { new Guid("66f37b83-9d9f-4ec4-9de4-67d517483d66"), "Sand Basin area", "We were in a hunting camp and something spooked the horses late at night. This is not uncommon here but something was different. Something came running through camp and made the strangest yell I've ever heard. We thought it was probably a bear or what have you  but the next morning we found some parcel tracks that appeared to be man shaped but larger. We all wondered if it could be what we thought but needed the meat we were after worse. We just kind of left it at that and use it to scare visiting relatives.", "\"Report 1518: Campers hear something \"\"running\"\" through camp & find very large footprints\"", "MT", "Bigfoot" },
                    { new Guid("670d8dc6-85ee-4007-81c9-99b7c6140781"), "This is located in Timber canyon.  GPS coordinateds are N40  1.680  W110  55.891.  It is about 14.6 miles from Highway 6 (Spanish Fork Canyon  Soldiers Summit) and 20.2 miles from Highway 40", "This is a sighting reported to my by Mike(last name withheld for privacy reasons)  a friend that lives in the same area as I do.  We went to the sight this past Saturday and Mike showed and told us..(a group of about 20 people) what occurred on the night of the sighting.   Mike went back to the sight the week before to make sure he could find it again since it had been 25 years since he had been into Timber Canyon.  He and his younger brother Lynn had gone fishing.  They had been in the area many times before with their father and other family memebers.  They arrived at their intended camp sight  about 7:30...they both had noticed once they entered the canyon that they saw no more wildlife....deer  birds  or anything.  Mike remembers having a erie feeling from the very moment they started down into Timber canyon.  He recalled hearing no noises  and commented to Lynn about this and the weird feelings he had of something or someone watching them.  They had forgotten worms so both went out into the willows and were digging worms...all the while feeling something was watching them.....Mike said the hair on the back of his neck was standing on end when ever he would look around to see if they could see anyone watching them.  They return to the truck  lit a lantern and put on the top of the truck...and proceeded to light a fire to roast a hotdog on.  His brother and he were sitting on a log and he noticed his brother had opened a beer and was not drinking it and was just staring at something and had ceased to talk to him....he looked in the direction his brother was looking and saw a sasquatch trying to sneek from off the road to a clump of willows and then to another and then proceed to peer at them by holding the willows off to one side and leaning over so he (the sasquatch) could get a good view of them.  Mike was so shocked he lost his balance and fell from the log and in getting back up noticed the sasquatch creeping behind the willows moving to the west and south.  Mike and his brother then lost visual sight of IT and could hear very loud thrashing noises of the sasquatch going through the creek and willows and up the canyon to the west and south of the camp site.  Mike said he did not smell any thing...and figured it was because of the smoke from the fire.   Mike estimated the whole sighting and noises lasted two minutes.  His younger brother wanted to stay there and sleep in the camper shell...but Mike was impressed very strongly to leave and get out of there.", "Report 3022: Nighttime encounter with campers near Duchesne  in Timber Canyon", "UT", "Bigfoot" },
                    { new Guid("670fe4eb-a32a-460d-968b-c201bf659914"), "Sioux City", "\"Dimmit Hall - There is said to have been a girl that committed suicide on her hall on the girls side of the building. Her hall is called the \"\"hidden\"\" hall because the is no entrance to the outside so you have to go up a level or down a level to get out therefore leaving her trapped on her hall. It is said she committed suicide by hanging herself on old heating pipes in the rooms. Residents of her room have reported recently of hearing a girls voice and gagging choking sounds at night while they're studying. They've opened up their doors and yelled down the halls at their hall mates thinking it was a joke and no one was out there and the sounds continued. Other girls of the hall reported seeing a moderately dressed young woman walking slowly down the hall sniffling and crying and walking through the door into the haunted room.\"", "Morningside College", "IA", "Ghost" },
                    { new Guid("67268797-090e-4603-9b29-df5f8eb06189"), "Warwick", "3 arrow shaped objects brown in color flying in a triangular formation moving very quickly.", "Triangle", "RI", "Alien" },
                    { new Guid("6748e716-46a1-4a9b-84b5-e67d641d7358"), "West Warwick", "\"Several employees of the Times reported strange sensations and feelings of panic when working in a storage room on the third floor of the building.  The same has happened in the men's lavatory on the same floor.  One employee quit after being \"\"followed\"\" by someone she couldn't see.  It is rumored that a man killed himself by hanging in the third floor stairwell.\"", "Kent County Times Building", "RI", "Ghost" },
                    { new Guid("674c0a35-aaa5-4eb7-be1d-5fcf77e1e993"), "Kenai", "There is often an old man who is transparent  attempting to maintain his own gravesite  as well as others.", "Local Cemetery", "AK", "Ghost" },
                    { new Guid("67849705-72bb-4c1a-8b68-d7bd2db08df2"), "Council Bluffs", "This is the old Council Bluffs library  which has now been restored to a wonderful looking and brand new Union Pacific railroad museum. Before the renovation occurred  many people were hesitant to venture into the basement of this Carneige structure due to books literally flying off the shelves. Many experienced items mysteriously disappearing  only to have them return later. Also  some have reported dark-shadowy figures being seen in the basement. Not too many folks want to go into this basement alone.", "Old library-Now Union Pacific museum", "IA", "Ghost" },
                    { new Guid("67c21486-9c70-445e-ae9a-29f28d74d079"), "Shohola", "Thick white bar of light descends while moving left to right in my field of vision. Flashes and disappears four times as it descends.", "Cylinder", "PA", "Alien" },
                    { new Guid("67c222c3-c3b7-44fa-a636-72de3552981c"), "Iowa City", "Reports of a glowing shape walking through the cemetery  believed to be the spirit of the Black Angel. She is also said to watch people and strange lights in connection with this statue. In there with the Black Angel is a small statue of a girl that is set up on a column. If you walk under her and around her she will pick out someone in your group and stare at them until they leave. Also the closer you get to the little girl statue the warmer it gets. The farther you get the colder it gets.", "Black Angel &amp; Little Girl Statues", "IA", "Ghost" },
                    { new Guid("67e075e1-987d-4a22-b88a-f8a4b5580023"), "Yuma", "There are two predominate places within the prison where the spirits are active. One is the dark cell and the other is the visitors' museum. The dark cell hosts a ghost that likes to pinch. It is attracted to children and the color red. There are supposedly two spirits in the visitors' museum. One is a woman who sings quite early in the morning  and the other is a poltergeist that likes to play with money. He's attracted to dimes.", "Yuma Territorial Prison State Historic Park", "AZ", "Ghost" },
                    { new Guid("684cc441-4a8a-474a-8460-28ba2b3b1da1"), "Fort Bliss", "Many current and former members of the U.S. Army and Department of the Army civilian employees confirm stories of strange activities in one of the oldest remaining buildings on the Military Installation. One tale tells of an old Army Cavalry soldier seen in the upstairs window of the building on several occasions. Others tell of similar situations in which men and women are seen roaming the halls of the now unoccupied building. Building 4 was once used as a secondary morgue to hold the bodies of slain soldiers.", "Building 4", "TX", "Ghost" },
                    { new Guid("688a3f51-4caa-4302-b3b3-8e26cfe5827c"), "Fort Bragg", "has a ghost 3 the people who work in the hotels bar area say that things like glasses have moved by themselves mysteriously.", "The Gold Coast Hotel", "CA", "Ghost" },
                    { new Guid("68909a19-0a0a-4c41-8472-5a29f9e60829"), "Onalaska", "Large shiny silver ball  stop in mid flight and then moved off quickly at a sharp right angle  and dissappeared.large", "Sphere", "WI", "Alien" },
                    { new Guid("68aea7a0-c2a9-4d1b-9a52-50ba796cdcc9"), "Near Fenton Lake also known as Camp Eagle in October Mountain State Forest. Access road is north of four corners.", "October Mountain state forest  Washington  MA. October 20  5 pm. Near camp Eagle. Loud  strong wood knocks. Long sustained low pitched howl occurring while 2 barred owls hooted back and forth. Definitely not a coyote. Sounded almost human  but very low pitch. There is no human habitation in this area and is very remote.", "Report 46973: Hikers hear possible knocks and howls in The Berkshires", "MA", "Bigfoot" },
                    { new Guid("6940a241-22f2-40e3-9606-8e3b1879df2d"), "Sebastian", "Two independently moving orange  fireball like  lights. Rapidly flying along a storm cloud  without making a sound.", "Light", "FL", "Alien" },
                    { new Guid("6943193e-f353-48f2-ae2e-9659b05c4bcb"), "Coming south on Highway 259 you travel about 5 miles of the junction of 259 & 4 (which heads back to Smitville proper). On the east side of 259 you will see a low water crossing that crosses Mountain Fork river you follow that logging road 2 miles to the east. At the two mile mark the road Y's back south there is a pond on the south side to mark this spot. You take this logging road about 1/2 to 3/4 of a mile further and you will see the steep bank off the road on your right hand side (west). I will include more precise directions here below: Using the Smithville Quadrangle 7.5 minute topo map the UTM coordinates are as follows: Zone 15 347964E 3806266N This area sits between Hee Mountain which is to the south and Mountain Fork River which is north.", "\"While my son and I were camping in the Quachita National Forest on Oct 19 2001  in McCurtain County we discovered 4 large foot prints and one large hand print. We were off one of the logging roads that wind through out the forest. I came upon a area that had a very steep cut out along the bank off the road. This cut off had exposed the underlining strata  and I thought it would be a good time to show my son some geology of the area. The exposed strata was layered and I could show my son (18 years old) how the rock and soil was layered by water over thousands of years. We went up to the bank and was starting to show him the layers when suddenly my son said \"\"Dad look at this print\"\" it turned out that it was a very large hand print. After further investigation we found 4 large foot prints. The prints were in a single line and you could follow the prints for a space of roughly 15 -20 feet. We did not have a tape measure or ruler to measure accurately so every measurement is a guesstimation. The first print seen is a left foot  then comes right foot about two feet away  then comes left foot about 8 feet further up then about 3-4 foot away and slightly higher up the (what I will call for lack of a better term alluvial fan  because off this bank the soil and rock is washed down into a pattern like that off larger areas such as the sides of mountains  etc.) Following the left hand print comes another left foot print about 3 feet away  however this print only shows the toes and about 1/2 of the foot it appears to have been made while the foot was rotating off the ball and toes  and stopped at what with some caution I will call the arch. (I say that because there does not seem to be much if any arch at least like a normal human foot.) Following this print is another large print however this print seems to be out of place as that it is perpendicular to the others and headed further up the debris pile. After this the tracks stop. There are some others there that I think were at one time prints however they were deteriorated to the point where it would be impossible to ID. The material in this wash is a combination of small chat like material mixed with the native soil (clay based sandy loam). It is not a material that is condusive to holding any print of any kind for very long and they will be gone totally after the first rain. The track these prints and place was not a easy track for it was slightly up the debris pile and a fairly steep angle  my best guess why it would take this track was because the location of this place is in one of the few places in this area which has any open ground (not very large  but larger than the surrounding area) and as stated earlier it was right off one of the logging roads  so I guess he/it was walking along the bank to minimize his silhouette while treking along this open space next to the road. The next morning (Oct 20) we went back out there and we took some small sticks and placed hunters orange tape on the tops of the sticks then placed the sticks in the middle of the tracks so that we could get a visual on its track. We used one piece of tape to mark foot prints and used two pieces of tape to mark the hand print. This was so we could get a easier visual sight of what was going on. We then took the video camera and filmed the tracks and the track markers  so we have all this on video and you are welcome to view this  and in fact I can/will furnish a copy of the tape if interested in it. Just let us know if you wish to see it. \"", "Report 3240: Father and son observe hand print and footprints near old logging road", "OK", "Bigfoot" },
                    { new Guid("69962a2b-3106-469b-a01b-f10665ca5cce"), "Jacksonville", "Luminious at a distance  very fire like ( massive blaze  orangish-red glow  turning amber up close. Very quiet. Triangular shape ", "Triangle", "AR", "Alien" },
                    { new Guid("69e4f17f-01df-4030-8f49-a287ba47899a"), "Berry", "Hovering and moving up and down in the same location.", "Circle", "KY", "Alien" },
                    { new Guid("6a10aa45-9eda-47cb-a52d-0354b016a069"), "Savannah", "\"Formerly a mental facility  there have been many sightings and sounds blames on a ghost they call \"\"Oscar\"\". Oscar was a patient in the mental facility and before he died he swore to never leave and to make everyone's lives there hell. My fiance worked as a CMT (med-tech) there  she didn't believe in ghosts until Oscar made a bunch of noise and scared her out of the basement one night.\"", "Shady Lawn Nursing Home", "MO", "Ghost" },
                    { new Guid("6a6b8888-26cd-4e16-b1be-af55b9ab3419"), "Capitol Hill", "June 2008 Removed. Private property. No Tresspassing. Tresspassers will be prosecuted.", "Behind the Capitol building", "UT", "Ghost" },
                    { new Guid("6a764cb3-8267-4cef-bbf7-ae586598d87b"), "Muscatine", "Very brilliant green oval traveling silently moving north to south. Clear blue sky. Object appeared shiny and metallic with sun shini", "Oval", "IA", "Alien" },
                    { new Guid("6a999f16-b500-4cc2-8e3b-563ec61a81ce"), "Dodge City", "Saint Mary's is an old church (no longer used) which is connected to the college. A nun was walking down the first flight of stairs near the doors and had tripped and fallen to her death. From personal experience  (the doors usually arent locked)  you can hear the moaning of an old woman a the bottom of the steps  but when you turn the corner  all sounds are ended.", "Saint Mary's", "KS", "Ghost" },
                    { new Guid("6ae087f2-b5d7-4889-90be-a1fa4ca4b42f"), "Reno", "My wife and I were on our way to Reno. I was looking at a large cloud formation that was pouring out an unbelievable amount of rain. Wh", "Formation", "NV", "Alien" },
                    { new Guid("6c3ccdea-71f9-4448-8392-de1cfe6e0554"), "Wildwood", "I saw two small lights in the sky that moved super fast and did not move in a straight line.", "Light", "NJ", "Alien" },
                    { new Guid("6c73a264-d64d-4bdd-be94-13a1ce6184f5"), "Old Bridge", "I was sitting in my back yard when I saw this strange star that seemed to be moving in the sky. I got my phone and videotaped in a sou", "Sphere", "NJ", "Alien" },
                    { new Guid("6c8714ef-ab72-4178-b6ef-d9ab745cff60"), "Grand Forks", "Triangle shaped UFO with 3 dots in each corner no lights  sphere and worm like object in sky", "Triangle", "ND", "Alien" },
                    { new Guid("6c99044c-5d97-4f9a-a11d-cfef90f47b44"), "Bentonville", "Haunted by the former owner  the museum  open to the public  has light poltergeists and corner of the eye apparitions.", "Peel Museum", "AR", "Ghost" },
                    { new Guid("6cb35b78-8265-42a1-a445-d4ea7bbde15e"), "Portsmouth", "A triangluar craft with blinking lights seemed to be surveying the backroads of Portsmouth and Middletown before it flew away.", "Triangle", "RI", "Alien" },
                    { new Guid("6cff53ef-14a1-4244-b24e-36bc5ba332fa"), "", "\"While on vacation driving down from Seattle we stopped and camped at KOA Fortuna July 1992.  On this trip was my wife and three children. We decided to get an early start the next day so we could drive through Humboldt Redwoods State Park with little or no traffic to enjoy the landscape without too much distraction.  We packed up and drove southbound as we approached an area of Hwy 101 were the Eel River makes a large bend towards the highway I saw movement down by the river.  My vantage point was above the animal I saw and I was driving slowly.  What I saw was a human like \"\"creature\"\" walking slowly away from the river across a rocky sandbar towards the forest.  The color appeared to be a reddish brown.  The creature walked with the same apparent gait as the creature seen in the Patterson film.  It wasn't a bear  bears don't walk with an apparent human type gait.  I talked to my wife after driving several miles down the road and prior to me asking her if she had seen anything unusal she said yes.  Later on my daughter who was sitting in the back also said that she saw the same creature.  I am a law enforcement officer and know that I saw \"\"Bigfoot\"\" - there is no doubt about it.\"", "Report 9283: Early morning sighting by motorist along the Eel River", "CA", "Bigfoot" },
                    { new Guid("6d152a05-0784-4d6b-a794-d8c75d6e09ce"), "Fort Bridger", "Ghosts in almost every standing historic structure. One in the museum building that likes to play with copiers. One or more animal ghosts  particularly that of a dog that was decorated for heroism for saving a young boy. Most ghosts seem to be rather harmless. Most are soldiers that died while stationed at the site in the mid to late 1800's.", "Fort Bridger State Historic Site", "WY", "Ghost" },
                    { new Guid("6d4e1d97-5234-4e5e-ab56-28238cf4f4d2"), "Helena", "A man named John Jo Weezer was Hit by a Combine at night to this day you can here Weezer moaning in pain around harvest every year.", "Sturgeon's corner", "OK", "Ghost" },
                    { new Guid("6d59469c-2bcb-47ca-8dc0-65bd5aed6f56"), "Iron River", "cold spots  hear people talking when there is no one there  glass brake when there is no glass to brake. foot steps up stairs doors open & close lights in the house but there hasn't been power in 15 years", "Iron Lake", "MI", "Ghost" },
                    { new Guid("6d7e861a-c37e-4a05-a008-36854e2788c5"), "Fort Bragg", "Formerly the Redwood Hospital - is said to be haunted by a lady she is often seen roaming around in their garden areas and there has been the sightings of a man who apparently appears in one of the windows.", "The Grey Whale Inn", "CA", "Ghost" },
                    { new Guid("6da78201-fde1-4770-b9e4-ae92c5896030"), "well if you can find the Fillmore golf course or the Fillmore Bar and Grill u can find Simon road", "Well in total I've had 5 encounters the first one being about a year ago I was bow hunting and this big hairy man like thing just came up and sat right under my tree stand I was thinking about shooting him but I didn't want to scare him out of the country so I sat there quiet as possible then he just got up and trotted off. The second encounter was 5 months ago I was riding on my four wheeler and I went past a big patch of woods and he just stood there and watched me. The third encounter was 2 months ago I was driving home from work and he was retreating into the woods by a telephone pole. The fourth encounter was about 5 days after the third encounter and the bigfoot was walking through one of our old knocked down barns and I was out on my porch just watching him and he looked at me then he ran off and hurdled a five foot barbwire fence. The last encounter was just about three days ago and he was goin down a trail in our woods", "Report 51678: Multiple sightings on family property near Cascade", "IA", "Bigfoot" },
                    { new Guid("6ded0654-96f4-496e-8d60-18ab5d299c37"), "Birmingham", "A disk was hovering then disappeared then re-appeared then there was a flash and it disappeared again.", "Disk", "AL", "Alien" },
                    { new Guid("6ec6614f-4b26-4819-aef7-ea541b9c621c"), "Madison", "Object moving slowly down a row of homes. Crossed boulevard and disappeared over warehouse. drove under it thinking it a police helicop", "Unknown Shape", "WI", "Alien" },
                    { new Guid("6ed13a6e-1df0-432b-a69f-92297f75bf5f"), "New Haven", "It was a triangular shaped vessel that gave off a light blue light. It was night so I couldn't tell much more.", "Triangle", "KY", "Alien" },
                    { new Guid("6f1cd581-e551-40b0-9688-2d2de1a807a3"), "43.71597  -115.39289.  It is 2.5 hours from the nearest gas station in Idaho City so very remote.", "\"While mule deer hunting in Idaho  I road my atv to the snow line on road 255 southwest of Atlanta. I passed a truck with Alaska plates. It was parked on the side of the road with no one around just where the snow started. I was forced to turn around due to deep snow about a mile from the truck up hill from it.  I observed many large elk tracks in the snow so I decided to move down in elevation to glass the timber strips.  Elk season started in 3 days so I want to see if any were in this area. Once at the location about a half mile down hill past the truck  I parked on the side of the road. About 5 minutes into my search I heard a knock to my right about level with me about 300 yards away (guess). Very loud and solid.  I first thought it was two trees hitting each other from wind. The wind was light though.  About 5 minutes later it happened again but the knock sounded different and a bit lower. Within 10 minutes the Alaska truck drove by me with just a driver.  He headed down elevation from me. I continued to glass this area without a sound for a good 5 minutes. I heard a vehicle coming up the hill and that person stopped to talk to me.  He was a friend of mine from my old home town in California.  Small world.  I knew he liked this area and was happy to see him.  We started to compare our hunting apps on our phones. Come to find out he was camped about 1.5 miles from my camp. We talked for a few minutes and then a loud knock like I heard before.  A bit closer and near level to us.  He stopped mid sentence for a second and turned to the direction of the sound but kept talking. A truck came by with a family in it and stopped to talk. I told him the snow situation and he headed up.  He returned within 5 minutes and headed down the road to lower elevation. We heard 1 more knock lower and like further away (not as loud) after the truck passed us.  My friend said  \"\"What the hell is that??\"\"   I joked  \"\"Bigfoot!\"\"  He immediately said it is someone splitting wood. When we heard 3 more in the next 20 minutes I told him that wood cutter sure takes his time between splits. Then it happened....a knock behind us with a different tone and it seemed farther away..  Then another below and to our right but not as loud as the other knocks. Things went quiet for 10 minutes. We said see you later.  He headed up the road toward the snow line. It didn't take long and he was back and drove by me with a wave.  I have not talked to him since then. Within 5 minutes of him driving by me I heard 3 distinct quick clacks or knocks directly behind me up the hill. Like rock not wood. Then 1 faint wood knock below me.  I stayed for about 15 minutes in silence  then left. \"", "Report 71863: Elk hunters hear loud wood knocks from multiple directions in remote forest 40 miles east of Boise", "ID", "Bigfoot" },
                    { new Guid("6f580c0c-3c2c-4365-9ba4-fb34953076c2"), "Summerville", "This abandoned manor house was the scene of a double murder in 1982. Before the murder the site was once used for satanic rituals. It's said to be haunted by evil forces.", "Corpse Woods", "GA", "Ghost" },
                    { new Guid("6f618440-d998-4c0f-9c1c-e5b49ac8cf8a"), "Vincennes", "Is said to be haunted by Civil War Colonel. Doors open and close as well as strange clouds and figures appear all the time.", "Sigma Pi House", "IN", "Ghost" },
                    { new Guid("6fc9a230-9194-41bd-b9f1-5f53ca02f167"), "Harrodsburg", "We were star gazing and I looked up at the perfect moment. It was a huge line of white lights flashing.", "Rectangle", "KY", "Alien" },
                    { new Guid("700395e8-068b-4308-af93-8a973ff6fec1"), "This is near Ketchumstock Mountain  about a 30 mile jaunt by ATV's to the west of the Taylor Highway south of Chicken Alaska.", "This is an excerpt from a short story I wrote about this hunting trip for mostly my family.  I am 64 years old and have 40+ years in law enforcement  currently serving as chief of police. With hunting season not to open until the day after next  we were in no hurry and enjoyed the evening with a touch of good single malt Irish talking about our past hunts and the one we were about to have.  Loyd and Davis would not arrive until the first day of the hunt  presumably because Dave had become domesticate sometime after the previous year’s hunt and had to attend a retirement party before being allowed to leave Valdez for camp. With the evening expended and the toll the day had taken on us we were in our sleeping bags and doubtlessly turning logs into sawdust by 2300 hours.  The stove was stoked with fresh firewood and all was good.  About 0215 I awoke feeling way too warm  unzipped my bag  slinging the top off  when I heard a resounding crack of wood striking wood  similar to a Louisville Slugger solidly striking a large  sound Birch tree very close to the cabin.  There being no one within many miles of us  my attention was immediately focused on the sound.  A few seconds later  the sound was repeated  which was to be the pattern for several minutes while I attempted to evaluate it to determine its source.  I finally decided to wake Bill saying in just above a whisper  “hey Bill”.  He stirred responding with something that sounded like “what” and did not move again for twenty minutes; when he woke up and asked what was going on.  In the mean time the commotion stopped when I initially attempted to awaken Bill up and I was sitting on the bunk with my .450 in hand waiting for whatever eventuality might arise.  Nearing 0300 hours I finally returned to a sound slumber awaking well into the following morning. With a spot of coffee in our gullets and having explained to Bill the events of the previous night we explored the area of the old village  inclusive of the nearby grave yard  in an effort to find an explanation.  We found numerous paths traversing the grassy area around the cabins with a multitude of bedding sites.  Never did we find anything that would provide us with an answer to the question of the source of sounds.  Explaining this to another friend after our return  with the experience of spending many years living in numerous villages  he asked me if there was a native graveyard nearby.  It is less than 50 yards from the cabin.  Nevertheless  I named the source “Sassy”.", "Report 25442: Hunter describes powerful wood knocks at a cabin in remote wilderness south of the town of Chicken", "AK", "Bigfoot" },
                    { new Guid("7021f1e2-a249-4c66-8725-372d880f3cfd"), "Sheridan", "There is a house on Center St. haunted by the spirit of an old woman (witch?) She is seen wearing rags. There are strange choking chemical smells. Loud metal banging crashing from the abandoned house next door in the middle night. Whimpering moaning dog sounds from the other abandoned house also next door. TV’s will turn themselves on in the middle of the night full blast. Cupboards will bang in an empty kitchen. Footsteps are heard walking around the house/in the house at night. Strange break ins with no one being seen. The front door will unlock itself at night. Game systems (Nintendo  Playstation) will lose their memory. Shadows running around the house in the day. Yard gates unlock by themselves. Earthquake like rumbling in the day. Banging on the bedroom door at night. Sound of the front door opening/closing with no one around.", "NE Center St.", "OR", "Ghost" },
                    { new Guid("7053afae-876d-4040-b324-4f25b28a2ba4"), "Salt Lake City", "There has been sightings of an eight year old little girl who you can see in the upstairs window. People say you can hear her humming  singing  or even talking to herself sometimes. Others say that she can be seen in pictures taken by visitors and they say she looks like pictures on the walls that were taken in the 1850's. They say that when she gets mad she throws things on the ground and she even shuts doors when they are left open. Workers say they feel cold spots sometimes when they walk in certain places.", "The Deveraux Mansion", "UT", "Ghost" },
                    { new Guid("70a96c6a-3fe9-4646-9411-14c5458f31ce"), "St. Joseph", "at night some of the guards have said to see the door of the guard shack open and the sound of footsteps as if someone was coming in the guard shack  one guard said he was doing his rounds and saw someone walking outback by the back fence  sounds come from the basement when no one is in the building.", "St. Joeseph's Foods", "MO", "Ghost" },
                    { new Guid("70afe5b2-b744-4225-8612-1867fbd720b1"), "Ogallala", "people driving past on west 10th street have seen lights on in the back room when the museum is closed at night. Museum keepers have also seen a man’s figure walking around during the after noon when only the museum keepers are there.", "Mansion on the hill", "NE", "Ghost" },
                    { new Guid("70d5ae0f-0807-4a3a-a04e-ee66843bf7b5"), "Shreveport", "Bell tower which was once part of a church  now stands alone in a pasture off the side of US Hwy 71. Legend has it a bride was waiting for her soon-to-be husband who died in a car accident on his way to their wedding. Many stories exist about the way the woman actually died. Some say she fell down the stairs to her death because she was upset  but still others say she hung herself in a fit of depression. People claim at midnight the bell tolls and a woman's screams can be heard.", "Taylortown Tower", "LA", "Ghost" },
                    { new Guid("713f2bb5-5900-4948-9bbc-e12d449b308e"), "Springfield", "Stationary green light in the sky for about 3 minutes maybe longer  zipped all weird directions then descends down and disappears", "Light", "PA", "Alien" },
                    { new Guid("7155217f-478e-4642-b0c2-ca2059e3e6f9"), "It was about five hundred yard from a high mountain lake", "Took a pic of a huge foot print in the mud. [Editors note: this witness felt he knew what had made the print  because he had seen a sasquatch in 2000  more on his sighting below in the Investigator's follow-up]", "Report 40524: Photo taken of a possible print near Lake Esler and memory told of a daylight sighting near Deerhead Lake", "MT", "Bigfoot" },
                    { new Guid("720a124c-c53d-49ad-8f04-f50feaddcfa5"), "Maryville", "There is a presence felt at this church. It has been engulfed in flames before and no damage has occurred. There is a story about someone seeing some old cars around there like a funeral was going on and the roof of the vehicle that this person was in started to crush in until they left. A voice told someone where a knife was located under a part of the floor that was used by the priest to kill someone. A tree right by the chapel was used to hang people. You can sometimes see figures hanging from the trees. Also when you look just right you can see a figure hanging inside the church itself. Also rumors of a man that walks a horse. Supposedly if you leave your car underneath the tree that people were hung from you can hear feet as if trying to stand on your car to stop them from dying. Hoofs and many strange sounds come from the woods and sometimes noises from he chapel while in the cemetery are heard.", "Workman's Chapel", "MO", "Ghost" },
                    { new Guid("728f7eae-9948-4b08-b29a-011702e07154"), "near pine forest and creeks", "\"This incident occurred on a surf trip to Ocean City Md. with my high school friend and surfing buddy but we had gone up rt. 404 into Delaware to cut down from Rehobeth beach. I'm not sure where EXACTLY but it was between a number of farms and on a road off of 404 which we considered a shortcut. The area was dense pine trees and I would guess it was late spring as there was no traffic at all and usually in summer there was even at the time we were travelling  between 3 and 4 AM. We were moving at about 60 to 70 MPH and looking out for deer and were very much awake. I saw a pair of eyes off in the woods some ways up  perhaps 100 meters when I noticed them and as we were closing rapidly I braked fairly heavily. My friend and I saw what I can only describe as an absolutely enormous hairy creature moving VERY fast from the passenger side of the road to the left side. I would estimate it to be at least 8 feet to the shoulder and hunched forward  almost on four legs but definitely NOT a quadruped. It was positively terrifying and we both looked at each other and said \"\"WHAT THE HELL WAS THAT?!?!\"\". I will never forget the size of the thing. Neither of us have any idea what it was but both of us were outdoorsmen and camped regularly and experienced in the woods. For many years afterward we have speculated what it was and I think I may have told three or four people about it but never was taken entirely seriously.\"", "Report 25137: Memory told of a possible late night sighting while driving near Hurlock", "MD", "Bigfoot" },
                    { new Guid("72d38d1b-17d5-488a-b5ff-a6700f794dec"), "Barrington", "Both witnesses see cigar shaped object in sky  tree level  far distance  when reaching crest of hill  object was gone.", "Cigar Shape", "NH", "Alien" },
                    { new Guid("72e56c5b-2d56-4e49-8965-6148cffcf993"), "From route 102 N or S. Take Spring Lake Road. Follow there are multiple points of entry in to the reserve and a general parking lot at the end of Spring Lake Road.", "\"The exact date was October 15  1998. I was training for a mountain bike race and this was to be my last ride prior to the race. I was riding at the Black Hut Management Area in Glendale RI. Along for the ride was my three year old mixed breed (shepard/lab)large dog. It was sunny but cool and I planned to spend an hour or so breaking a swet. As i weaved my way through the trails  i had to leash my dog to cross a street. After I unhooked him we started up a hill toward a chasam. It's small and kids hang around there and drink beer  have fires etc. At the crest of the hill I could see the top of the chasam (approx. 50 yards away). Out of the corner of my eye I noticed something that first appeared to be a dirty white blanket perhaps hung on a small tree. Suddenly (I think it heard us)it turned (as it was squatting with it's back to me)saw me stood up and disapeared into the woods. I was shocked and could not believe what I had just saw. From my vantage point I would say the animal was white or grey but very dirty. In no way did it resemble a man. I did not see the face clearly. But from what I did see (full rear view) although it stood fairly erect  it's gate and posture was like an ape. The arms were not long like a gorilla and oddly it was no were near seven-feet tall. I'd estimate maybe six feet at best. I reversed my direction and rode immediately to the top of the chasam. I looked for footprints and hair but didn't find any. I walked a short distance in the woods in the direction were it disapeared. My heart was pounding so loud I could hear it. I knew it was no were in the general area because my dog was not barking. Anytime there is an animal near fox  coyote  deer  my dog barks and will usally chase. Interesting point is that my dog never barked and I don't think he saw  heard or smelled it. I noticed no unusual smell in the area. And also noted no signs of broken branches and no way to determine its direction. I've told one or two people and in November of 1998 a friend and I (with video and digital camera) spent two weekends hiking in the area directly behind the chasam with no results. I also snow shoed the area after the first snow. I was starting to believe I had imagined it. In 2002 I met a hunter in a bar and asked him if he ever hunted at Black Hut. He said \"\"yes\"\"  \"\"and once I saw a white gorilla there! I had chills and related my story. The differences were in color  he stated white (the one i saw was more grey) and said the one he saw was eight feet tall. Still  same place same type of sighting. What made me write this is the two other RI sightings seem to be similar. I wish I could have seen it longer and closer. \"", "Report 15923: Daylight sighting by mountain biker in Black Hut Management Area outside Glendale", "RI", "Bigfoot" },
                    { new Guid("7327a253-4a08-49dd-a404-6069342658fd"), "", "While sitting around the bonfire listening to music and talking our family heard screams out in the distance. They sounded like a party that turned into chaos. At first we figured it was nothing but then after hearing Cliff scream on Finding Bigfoot we figured we heard a Bigfoot Up North so we thought we should report it.", "Report 34990: Family members describe possible nighttime vocalizations heard over the years near Prescott", "MI", "Bigfoot" },
                    { new Guid("735c36ef-fddb-4c2e-bf5b-a1bab2f345f5"), "Hot Springs", "This historic inn has a very colorful past. The scent of perfume lingers around the upstairs dormer rooms. Visions have been seen at the main staircase. The spirit of a girl by the name of Giselle happily roams the household. A very inviting and non-threatening mystery.", "Villa Theresa Guest House", "SD", "Ghost" },
                    { new Guid("73c164df-46d6-48a4-9898-9e444bacb79b"), "200 to 300 feet to the east of the 1806 hwy 44 junction.", "Hello I am from rural South Dakota and i have a strange sighting that I saw about 6 years ago. I was Driving truck and this was about at 5 in the morning still dark in the fall of the year around the end of november. I come onto hwy 44 from 1806 and i turned east onto 44 about 2 miles from the platte-winner bridge on the missouri river. About 200 to 300 ft or so from when i turned there was a dark figure on the right hand side of the road crouching down. At first i thought it was a deer or a fabled moutian lion but it was too dark colored and the only thing that made me write this now was as i drove past it it stood up. this thing was tall enough to look into the top of the passengers side window of my straight truck. This would have made it a little over 7 feet tall. I have never said anything to anyone about this around here because no one would have beleived me. I have lived in this area my whole life and an avid hunter and fisherman  i have never seen anything like this.", "Report 29455: Truck driver has early morning sighting on Highway 44 near Missouri River", "SD", "Bigfoot" },
                    { new Guid("74d9361d-187f-4a37-aeb0-9ae0c0652565"), "From I-95 S  merge onto RI-4 S toward North Kingstown. Take exit 5B to Exeter and continue on Ten Rod Rd. Turn left at S County Trl. Left at Kingstown Rd. Right at Watson Rd. Right at Liberty Ln. Then left at Great Neck Rd.", "I have recently become very interested in bigfoot research  and based on reports that I found on this website of previous incidents in the area  decided to go to Great Swamp in Rhode Island to look for any evidence of bigfoot. After walking thirty to forty minutes down the main trail beginning from Great Neck Road  I took a smaller path off of the trail for about five minutes. That is when I noticed a young tree that was snapped in half at about six feet off the ground. More noteworthy  however  was a stick formation that I found a little bit farther down the path on a slightly elevated area of land. It was small  maybe three feet high  but constructed in the same woven-looking manner characteristic of other possible bigfoot stick formations. Other than that  I did not find anything else unusual. It may not be extremely compelling evidence  but I figured it was worth telling experts  who could then take it as far as they saw fit.", "Report 16746: Possible stick formation found by hiker in the Great Swamp", "RI", "Bigfoot" },
                    { new Guid("74ef8fb1-6367-4ff9-87a6-cd5d30f3a627"), "Willard", "Haunted by the Lady in Grey  you can try to catch an image on www.libraryghost.com", "Willard Library", "IN", "Ghost" },
                    { new Guid("7579e9cb-ed6f-4e09-901b-1895d88ad4a0"), "East Greenwich", "is the oldest operating burial ground in the United States has been investigated by several paranormal groups and is reported to be very active with ghostly globes and lights.", "Eglington Cemetery", "NJ", "Ghost" },
                    { new Guid("7581f4a5-927e-4545-b9ca-e4aa1a5f9b56"), "From Mt. Vernon go west on SR V highway past Baptist Hill Assembly to the first bridge over Spring River.", "\"When I saw it I was fishing on Spring River on SR V Highway due west of Mt. Vernon past Baptist Hill Assembly. It was in July 1997 I had been fishing near the bridge over Spring River and decided to move downstream a bit. As I came around a large group of oak trees I saw a figure walking from the stream towards the woods. At first I thought it was a hunter but realized it was too large to be a man 7-8 foot tall at least and probably over 600 pound ( I'm 6' 3\"\" and it was taller than me). It had long reddish brown hair kind of matted or curly looking. I was approximately 100 yards from it. I don't know if it saw me or not but it didn't seem to be in any rush to get into the woods. I watched it for at least five minutes before I couldn't see it anymore. I thought about trying to follow it but since I was alone I thought better of it  but I did go back the next day in the afternoon to see if I could find any footprints but didn't find anything that I could say definately belonged to the thing I saw.\"", "Report 12470: Fisherman has daytime sighting west of Mt. Vernon", "MO", "Bigfoot" },
                    { new Guid("762ec4bc-19bb-4157-973d-7cc66e91b676"), "Las Vegas", "Viewed pairs of red strobing lights extended across wide area of Nevada desert and watched as two F-15 fighter aircraft tried to interc", "Light", "NV", "Alien" },
                    { new Guid("76748e07-d028-4ac7-8739-bd897b548bf2"), "Honaker", "Old principal walking down the stairs gym basement. People have smelt smoke  and report seeing him.", "Hoanker High School", "VA", "Ghost" },
                    { new Guid("76994def-10dc-4aef-a4ae-84de82fcd380"), "Ninnescaw River", "\"We had been fishing in the river  standing on sand banks. My companion and I had our dog and he decided to walk South in the river to fish downstream. I continued to fish standing in knee deep water on the East side of the river. It was hot  very hot weather. I heard sounds of deep heavy breathing...a weird sound I cannot really articulate  but it caused me to look up and around. I thought my dog (a Great Dane) who had followed my companion downstream was back panting heavily from running in the river. I realized the sound was coming from behind me. I turned around and saw a tall creature staring at me. I couldn't believe my what I was seeing. He was 100-150 feet West of me standing on the bank beside a tree. I could see his eyes very clearly. They were like a man's. He had hair around him and covering his face and his entire body. He was very tall at least 7 feet and built very athletically. We just stared at each other for several minutes. I had no weapon to protect myself so I just stood very still and so did he. I realized I had to do something. I dropped my fishing pole in the water and started to move sideways slowly downstream where I could barely see the person I had come with. As I did the creature moved very quickily to the next tree Northward  stopped and stared at me. I stopped. I wanted to move closer  but I was too scared. I thought  if I had a gun or something I would move toward it  but then it occurred to me this may be somebody in a suit! I thought it might be my brother. But  in this hot weather? I called out my brother's name  \"\"is that you? Quit kidding around!\"\" The creature simply stared at me. We were both curious about each other and I could tell  I don't know how that it was a male creature. Several more minutes passed and I knew I better get out of there. I moved slowly again  sideways and began softly calling to my companion  but he was so far downstream he couldn't hear me. I was afraid now  so I started moving faster to get out of there. The creature moved when I did and he move away from tree to tree and I made my way through the river to my companion. I yelled for him to get up here and told him what I saw. He thought I was crazy. When I finally got him up river to see  the creature was gone. We went up on the bank to look for prints  but I didn't see any  because it was all dry sandy soil. We immediately went home and I told my family  my brother was home and it was obviously not him. My family owned this part of the river for recreation at that time and it has become the family joke. But  I know what happened and I did see bigfoot in Kansas. It wasn't just a siting  but a long hard stare at each other. Of all the pictures I have seen of Bigfoot  there is only 1 that is true. This creature looks like a man  has eyes like a man and even if I would have had a gun  I would never shot it for fear that it would have been a man (a tall one) in some sort of suit.\"", "Report 1325: Fisherman hears heavy breathing  turns and sees tall man-like creature", "KS", "Bigfoot" },
                    { new Guid("775879de-1a4c-4b36-85fe-e4aac0daa445"), "Newark", "First Battle of the American Revolution where the Stars and Stripes was flown in Battle. Delaware militiamen were delaying the British forces who landed at Turkey Point in Maryland so as to give General Washington time to escape from Philadelphia. One legend states that during the initial skirmish between the militia and the Redcoats  a British soldier got his head shot off. On foggy moonless nights people claim to see a Headless British Soldier walking along the roads in the area. There are many other stories associated with the area.", "Cooches Bridge", "DE", "Ghost" },
                    { new Guid("77a2875c-95e1-4fa8-9f75-646ef84c165b"), "Plato", "Ferguson's Cemetery - The cemetery is out in the middle of now where along side a county blacktop surrounded by corn fields. Supposedly haunted by a little boy. The small grave stone for him is separate from the rest of the cemetery. It sits in the southwest corner all by itself. Cemetery is framed by large pines and large iron gate at the front of the cemetery there is a small dirt field road on the west side that runs along the length of the cemetery and ends next the boys grave. In the center of the cemetery is a large tree or trees growing out one base. At night after 12 am if you count the trees at the center of the cemetery and if you go to the boy’s grave and come back the number of trees has changed. Most of the time it's thirteen but sometimes as few as six. It also feels as though someone is watching you and that your not welcome there. Some reported to have seen dogs by the boys grave as you are backing out with car.", "Glencoe", "MN", "Ghost" },
                    { new Guid("77b83d91-e700-4ce1-8e05-a1d81f471ee2"), "Calera", "It was circle and was the whitest light and bright. Even atsuch a distance it was the size of a beach ball and so bright.", "Circle", "AL", "Alien" },
                    { new Guid("77ede8f2-757a-4081-a0c6-297d22c6cad4"), "Fort Oglethorpe/ Lafayette", "There is also a women whom wears a white dress that sings a lullaby to a small infant she carries with her. She is usually seen at dusk but has also been seen during reenactments of the battle.", "Chickamauga Battle Fields", "GA", "Ghost" },
                    { new Guid("783e77e5-b375-426a-b833-4719e1b11d1a"), "Standish", "There is a child that haunts the old chapel  he was the son of the family that owned the land before the college was erected  he was buried in the chapel and had to be moved  sometimes you can hear him laughing and playing. There is a small girl that haunts the pond. She drowned while playing near her little play house  her father built her. There is also a nun who haunts the old Xavier building. The ghost has been seen by two girls who don't go to the school any longer.", "St. Joseph's College", "ME", "Ghost" },
                    { new Guid("7867834c-4c1a-4f97-9914-4b1b38374e5a"), "Cheyenne", "A huge fireball east of Cheyenne Wyoming", "Fireball", "WY", "Alien" },
                    { new Guid("78fb1b02-8725-491f-a978-02380a5a19a5"), "Providence", "White tear drop shaped object that was visible to the naked eye that I noticed after an aircraft flew overhead.", "Changing Shape", "RI", "Alien" },
                    { new Guid("79bdda7b-0e57-4c29-a079-46bea32d5dbf"), "", "\"This happened when I was very young. I figured it would have been reported. I was aproxametley 6 years old and was helping my mother cut some weeds out of the feild before my father combined and we discoverd some very large footprints heading from the end of the field towards the house. We stopped my father who was in the combine and showed the tracks to him witch looked very human like. But upon comparison to his foot was very large  and the stride it had taken was very large un reproducable for my father who was 5-11\"\" . My parents reported it to the sheriffs department and they came and investigated the tracks. Many of the locals and others came and looked at the tracks also. All I know is that it scared me to death and had many a nightmares about it and my father went and bought a big gun in case it came back.\"", "Report 5072: Witness reports seeing footprints as a child", "IA", "Bigfoot" },
                    { new Guid("79c93d66-6edd-4f24-9400-1a6eae113a4a"), "Charleston", "Geary Student Union - Feelings of not being alone strange noises and shadows.", "University of Charleston", "WV", "Ghost" },
                    { new Guid("7a1dcb1c-284b-4a95-8158-80a972f77a46"), "Clearfield", "Dot of light  varing in intensity  moving from West ot East", "Light", "UT", "Alien" },
                    { new Guid("7a752a59-039e-46d5-8212-75fba6f193e9"), "Blythe", "What appeared like a normal satellite drifted across the night sky  then completed three circular turns  then stopped.", "Circle", "CA", "Alien" },
                    { new Guid("7ae92214-f663-482e-a481-092fb04baf19"), "Las Vegas", "White  vertical cigar shape floating around in the eastern sky.", "Cigar Shape", "NV", "Alien" },
                    { new Guid("7ba0415b-2f43-4972-93a0-6f21e8eb994a"), "Supply", "I saw this changing wobling circular object that was changing colors in odd patterns.", "Circle", "NC", "Alien" },
                    { new Guid("7babae19-4fb7-4526-9248-e990eb0f865b"), "Rosario Resort", "Some people who were long time workers for the resort have seen the deceased wife of the man who originally owned the resort before it became one. Common story will be seeing her on the 2nd or 3rd floor wearing a Red dress of the 1930's and believe it or not  she will be driving through the 2nd floor on her old favorite motorcycle.", "Orcas Island", "WA", "Ghost" },
                    { new Guid("7bcb5c4d-ec82-43d5-996e-b195f444e452"), "O'ahu", "Reports that the Night Marchers have been seen there. Also  seen once  a rectangle of light as if from a window with the silhouette of a man sitting on a boulder outside of the first cabin across an empty field from the cafeteria. There is no boulder next to the cabin  just the empty field.", "Mokuleia Beach Park", "HI", "Ghost" },
                    { new Guid("7c25f404-cfaf-4b01-8445-9a32fe8a2878"), "Athens", "Triangular shaped craft with three dimmly lit lights on the bottom of it and It was following something on the interstate going south.", "Triangle", "AL", "Alien" },
                    { new Guid("7c58de37-da95-4423-80e0-ae5126f47310"), "Libby", "During the spring of the year  when thunderstorms are rumbling overhead  and lightning flashes lighting up the dark midnight sky  a shadow of a figure looking down  wearing what looks like a hooded poncho that is blowing  and waving in the wind  can be seen drifting (floating with no feet) around the RV Park. Before the RV Park was built  in the late 1960s with anticipation  and the start of construction on the Libby Dam  this place was called the Riverside Inn. It was a steak house  gas station  mobile home park  and mobile motel (house of ill repute). Construction workers and others gathered here after work to let loose  and do who knows what else. It is said that vagrants  and squatters called the Riverside Inn home. They camped in the woods behind the Inn with hopes of landing a job on the Dam. A few years after the Libby Dam was completed  the Riverside Inn burnt  and was never rebuilt. Who knows what happened to the ones who never landed a job? How did they survive with little or no food  and the harsh winter weather in Montana? Could some poor lost soul  still be wandering  and waiting with the hopes of landing a job on the Libby Dam? Did something horrible happen to this person before their time  and they will not rest until their wrong is righted? You be the Judge!", "Sportsman’s RV Park", "MT", "Ghost" },
                    { new Guid("7c73dc47-95da-4ca8-a451-882394113415"), "La Crosse", "2003 - The manager was sitting in a chair behind the bar one day before opening. The bar was empty; He was watching TV for maybe an hour and a half in that one spot when he heard a knock at the door he got up to see who was there. Before he got to the door a large iron industrial fan directly above his chair fell from the ceiling crushing his chair. No one was at the door or anywhere near the bar when he checked.", "Dells Bar", "WI", "Ghost" },
                    { new Guid("7ccd53bb-1864-4ad1-bac1-79b72c939766"), "Watersmeet", "it is told that you will see a light that changes colors from red to white that floats around no one has ever found out what it is and unsolved mysteries has been out there and could not find out what it was i have been out there many of time and seen it. the story is that a older man went to save two kids from a train and pushed then out of the way and got decapitated and now he wonders the woods looking for his head holding his lantern", "Paulding light", "MI", "Ghost" },
                    { new Guid("7d532d5c-d6d9-4844-84de-a7de2165a7c0"), "A 1/4 mile north of route 80 in a wooded swampy area.  The nearest habitation (at the time of sighting at least  was about 2 or 2 1/2 miles away)", "\"This sighting happened in mid October 1971 in Fairfield  New Jersey.  It was a Saturday  sometime around noon. At the time I was 15 and my friend was 16.  We were walking throught a area that is primarily brushy woods  but alot of wet land with only clumps of  tall grass. We were walking in a westerly direction along a feeder stream that fed into the Passic River.  The Passic River is about 1/2 mile north of where we were. The area is quite flat.  The areas on the imediate left and right of the feeder stream had little brush. It was partly cloudy  and we were wearing light jackets.  From a distance of aproximetly 75 yards we observed 4 creatures.  The largest was standing on the south side of the stream.  It appeared to be about 8 feet tall  very long arms that went almost to the knees.  Very powerfully built  barrel chested  very wide shoulders.  the head seemed to have a rounded \"\"peak\"\".  The color of all 4 was black  the faces seemed somewhat lighter in color  but not white.  The second one was sitting on the ground  the third was lying on the stream bank  and the last was standing in the middle of the stream. We observed them for a few minutes.  They also observed us.  We discussed it and decided to run.  We ran back east for a bit until we came to a clear cut for power lines that ran north & south.  We ran south along the clear cut for aproximetly 1/4 mile until we came to Route 80. We went home.  The only people we told were our parents.  At no time did we feel threatened by the creatures.  We were used to being in the woods and knew the local fauna.  We both agreed these were not people or bears.  When I later the Patterson film  I felt that these were the same in appearence.\"", "Report 10046: Small group observed in a remote part of Essex County Swamp  around noon.", "NJ", "Bigfoot" },
                    { new Guid("7d600f96-5476-4c38-8bf8-deca5337c1c5"), "Salt Lake City", "Strange things have been observed in the Pioneer Memorial Museum by the Utah State Capitol surveillance camera.  Authorities reported the specter of what appears to be a woman's face first appeared in the early morning hours of October 10th 2007 in the motion cameras.  The image lingered on the camera for about five minutes but  when officers investigated  they found no sign of life in the museum. Since this time  the face appeared three or four nights of a seven or eight day period.  Camera lens were cleaned and other explanations were speculated  but no conclusion as to the face has been made.", "Pioneer Museum", "UT", "Ghost" },
                    { new Guid("7dc6de55-e41f-4a7e-a121-1d8bff5d6a63"), "Tucson", "It was completely dark and at first the object looked like a star; then I zoomed with my phone and I saw it moving in a circular way.", "Circle", "AZ", "Alien" },
                    { new Guid("7ddd3ced-7340-4de9-85de-ec2afbef4ed0"), "Chickamauga", "\"Many things reported in this area: Every night  a mysterious fog rolls in upon the battlefield. Upon driving through the park  one may find that there is no fog before entering or after leaving the park  only in the park itself. -There are also tales of the infamous \"\"Green Eyes\"\"  a confederate soldier killed by his Yankee twin brother  whose eyes can still be seen at night on Snod Grass Hill. An apparition of a soldier walking down the road has been reported. They also say that if you notice him and he notices you  he will stare you down until you are out of sight. There is the tale of the bride-never-to-be who still walks the battlefield in her wedding gown during September and October  visiting the grave of the man she was going to marry  killed during the war.\"", "Chickamauga Battlefield", "GA", "Ghost" },
                    { new Guid("7e09a759-525c-4d92-8ce9-18682a19544c"), "Holderness", "Large greenish blue fireball seen almost overhead  travelling in northerly direction.", "Fireball", "NH", "Alien" },
                    { new Guid("7e46ebff-608d-487e-b3f2-86848ee2b1c2"), "Hickman", "Many years ago a little girl was murdered and decapitated there. Her body was thrown off the hill. At night if you park your car there and flash your headlights three times the little girl will come walking up the hill with her head in her arms.", "Wilson Hill", "KY", "Ghost" },
                    { new Guid("7ea55995-a552-44ff-b5a4-a165ba52b543"), "Bethel", "In a boarding house on the Danbury end of the street  there is a room where one man committed suicide and another overdosed on heroin. Former residents of the room report hearing screams in the night and the illusion that the walls are melting.", "Wooster St.", "CT", "Ghost" },
                    { new Guid("7f09ab2e-effd-4041-9818-3dc39bdf661f"), "Kingman", "Noises in Hallway  items being moved. Whispered voices. On our Visit  a member of our party used the  downstairs mens restroom  he walked forward into the first stall  when he tried to come out the trash can had been moved in front of the stall door.. he was the only person in the room  and up until that point not a believer of the paranormal.", "Brunswick Hotel", "AZ", "Ghost" },
                    { new Guid("7f0af77b-a8c9-47e7-b7f3-584381fa86c9"), "This occurred along the shore of eastern Lake Oneida area adjacent to the southern boundary of Verona Beach State Park.", "\"When I was 11 years old I was living with my mother and step-father in upstate New York. Our home was on the shores of Oneida Lake and bordered the southern boundary of Verona Beach State Park. One evening shortly before Halloween I had gone to bed late about 10pm. The window in my bedroom was directly behind the head board of my bed  and one of only three street lamps beamed light through this window. The height of the bottom of the window frame was approximately 6 feet above the ground. My bedroom window was also the only window in the house that faced our neighbor's house. The neighbors house was about 8 to 10 feet away with no french between the properties. On this particular night the light from the street light shown brightly into my bedroom and lit the entire room well enough to almost be able to read by its light. A few minutes after going to bed a \"\"figure\"\" moved into the light and cast a huge shadow on the opposing wall of my room. I amassed that this figure had to be standing with in only a few feet of my bedroom window do to the sharpness and size of the shadow. Also  considering the size of the shadow and the height of my window above the ground the figure had to stand at least 7 to 8 feet tall to cast such a shadow. I froze in my bed (and embarrsingly enough  I had wet myself in fright). I could not muster the strength to look out the window  I simply froze. the shadow remained for all of about 20 to 30 seconds  then it was gone. About three to four minutes later heard a very loud crash of wood and metal as someone or something had ripped off the door to our back storage room. I heard someone or something moving items  then I heard the big freezer chest open (and the toys I had left on the freezer fall to the ground). Again  I was still frozen with fear and in my bed  and could not moved. There were some loud bumps and bangs as if something was throwing bricks around the storage room (our storage room was approximately 16 feet by 32 feet and attached to the back side or lake side of the house). After the banging stopped the freezer lid slammed shut and all banging stopped. Later that night my step dad and mom had come home from work around 3am (they owned the restaurant a few blocks away) and started screaming and my mom was very very panicked. My mom called one of her friends that was also a good customer and was a State Trooper. I don't know what was said between them. The next morning my step dad and two of his friends were trying the fix the door to the back room. This is when I first saw the damage done. The room looked as if it were turned upside down  then right side up. My step dads large roll-away tool box was on its side and on the other side of the room  and packages of frozen meet were all over the place. A car transmission had been tossed as if a toy. The freezer had some faint scratches on the side and on the lid  but no tool marks or pry bar marks (my parents normally kept the freezer locked). These same scratches were located on the side of the house and the removed door. Missing were packages of my mom's frozen strawberries  and two frozen turkey's. None of the prepackage streaks or hamburgers  or lobsters were taken (they used this freezer as a back up to the freezer at the restaurant). The State Trooper friend of my Mom's said that it looked like three or four people had to of done this  but could not offer an explanation to the faint scratch marks. When I told my mom of the shadow figure my mom would only start to cry and hug me  saying we were so lucky that God had protected me from this situation. Of note was the conversation between my step dad and our neighbor. Our neighbor told my step dad that he too had seen some kind of shadowy figure moving between the houses. Our neighbor said he had tried to let his dog out to investigate  but the dog would not go outside. But as soon as the figure appeared  it had gone away  and he had gone back to watching tv. Our neighbor did not hear any of the knocking or bangs in our back room. At this age I had not ever heard of Bigfoot. But later  (the next spring) the other boys were talking about a \"\"monster\"\" called bigfoot that had been on TV  and for the first time (since that night)I froze again in fear (for a few seconds this time) and somehow knew what they were talking about  and what they were describing.\"", "Report 27035: Man recounts childhood incident at his home on Oneida Lake", "NY", "Bigfoot" },
                    { new Guid("7f3a7446-1952-49a6-b402-579f40d2aff2"), "Lewes", "9 lights flew diffrent speeds some times fast and others slow W to E north of the canal Red-Green and Blue. They made no noise.", "Light", "DE", "Alien" },
                    { new Guid("7f575eab-64f6-4cbb-aa44-1c3b3041e8f3"), "", "Well here goes....it was late evening  I stepped out to our driveway and saw something in the shadow.. It turned and stepped across the lit area and into the woods. One and a half steps  bout 8-10 feet..since then a lot more incidents bout like what I've described and there is always a rotten dead like odor. We have 12 bout acres and in the area we see this  is where we put table scraps..also there is an area where trees 6 inches in diameter are just pushed to the ground and the middle area is scratched up.", "Report 37094: Multiple sightings close to Lookout Mountain near Gadsden", "AL", "Bigfoot" },
                    { new Guid("7fbf5455-c1f0-4523-8a20-3e03a3fd3706"), "El Paso", "Traffic noise is a factor but how do you explain sounds of children playing and laughing at two in the morning. There is a section of the cemetery were score of children were buried after they died during a small pox epidemic. You can hear the hoof beats of Calvary soldiers  and just general conversation  but never really understanding the words just recognizing the human voices.", "Concordia Cemetery", "TX", "Ghost" },
                    { new Guid("80196908-5b4c-4609-b6b7-5258b448e98d"), "Duncan", "An old man died in the auditorium of the high school. He died from a heart attack. You can hear voices and feel cold breezes and doors shutting by there selves.", "Duncan high school", "OK", "Ghost" },
                    { new Guid("801f28ce-b53f-4b75-aea4-345d26df7a75"), "Esler Field Road near the airport", "We just had a house built. Esler field . buy a set of woods . at the time it wasnt to populated.Well one night my farter and mother had friend s come over on a friday night and play cards there daughter was my sister friends so we were all outside at night playing around on our farthers car hood with was parked on the side of the drive way next to the wood s . i got down from the car hood and went off to the side of the woods and was walking towards a streetlight that we had put up near the end of the drive way and off on the side of the woods . when i felt something standing in front of me. it was very hairy or fury so i lifted my head all the way up to look up into the eyes of bigfoot . its eyes where very dark and were very pupil big. its face had a grayish color to it . it was almost like a gorila face but wasnt dark but grayish . it had a more upright forehead that face it self wasnt all covered with hair. all it did was look down at me no expression on its face at all . like it was just curious.well of coase i ran out of the side of the woods and towards and in my house . leaveing my sister and her friend behinde . i told my parents what i seen when i could finnally calm down but they thought it was just my mind playing tricks on me . but after a few minutes my sister and her friend ran in and slam the door and said they heard someone walking in the wood s . nothing else was said and i think everyone else has forgotten but i never did or could . i didnt seem to be a monster but it seem to be a creature with a soul and feelings and wasnt out to harm . if it wanted to it could have rip me to one end to the other. its very tall and very wide in the soulders . long arms and wide. this is my sighting i never really have told anybody until now. since then i always new and new if i wanted i could find such animale . thank you", "Report 1459: Witness looked  up into the eyes of Bigfoot", "LA", "Bigfoot" },
                    { new Guid("8025e978-fb22-46ac-ac1c-5db8803bee40"), "Wahiawa", "Outside this plantation town are ancient birthing stones where royalty would come to give birth. Any attempt to move these stones will prove fruitless. The stones make their way back to the area by themselves.", "Sacred Birthstones", "HI", "Ghost" },
                    { new Guid("80362368-f76c-47e0-9a10-0a1d8fa409a5"), "Litchfield", "This church is haunted by The Sioux Indians. Many reports say that the lights of the church turn on  strange figures appear  a little girl named Annie was buried it has been said that she will come out to your car at night and sit on top to of the roof of your car and if you drive off with her on your car she will haunt you for the rest of your life unless you let her get off on her own  and last at the stroke of midnight a car would appear and drive behind you and all of a sudden disappear once you hit the end of the rode.", "Ness Church", "MN", "Ghost" },
                    { new Guid("80a31d44-e9eb-474f-939b-626fba571ff9"), "Hancock", "Phi Kappa Tau House - In our 102 year history of the house  it has been a hospital  hotel  doctors office  and now a fraternity house. One of the brothers fell off the fire escape 20-30 years ago and died. Strange things happen such as faucets turning on  lights going on and off  and doors will open and close. In addition their dog will not go into ROOM 1. She will stand outside the door and watch something or someone go around the room. There has also been sightings of miners and other strange people in the house. The basement was a morgue  and every now and then when down there it will go from being warm to ice cold even though it may be 70 degrees outside.", "Finlandia University", "MI", "Ghost" },
                    { new Guid("80fbd989-acf1-408f-8a09-100808a14c3b"), "Cincinnati", "A while back a janitor was working in a small room between two science classrooms on a ladder. Alone. The man suddenly had a heart attack and was found by the secretary the next morning when she called for him and no reply she went up and found him....now during class there are doors opening and closing with no one nearby and at night janitors recall doors all being opened perfectly at 90 degree angle Also when the schools pool was first put in  a student wandered down there without even hearing about it yet talking on the cell phone tripped  and right into the pool drowning. Now when you go into the boys locker rooms you can hear toilets flush by themselves and splashing in the pool even when it’s not filled.", "Taylor High School", "OH", "Ghost" },
                    { new Guid("811d33b3-3788-4499-bb8c-a09c53c57346"), "Davenport", "Triangular shaped noiseless craft flew over head at approx 150 feet heading south by south west from my location.", "Triangle", "IA", "Alien" },
                    { new Guid("81966dee-55f4-4c59-886a-6eed126f74b9"), "Lookout Mountain", "\"in the rock formation \"\"Ruby's Drapery\"\"  and in the twilight zone  there have been sightings of mysterious shadows and figures. on a school trip  a child named Katie saw a woman dressed in ruby red clothes. Said to be the ghost of \"\"Ruby\"\"  who the caverns were named after.\"", "Ruby Falls", "GA", "Ghost" },
                    { new Guid("81a4a2dc-506e-4f4f-8b67-8b0172c5c68d"), "El Paso", "At night the bell tower is illuminated. The bells do not ring anymore and haven't for years. Yet at night you can see the movement in the bell tower. Some say it is a colony of bats  or birds. But this shadow wears the same habit as the rest of the nuns teaching at Loretto. What this shadow represents is the spirit or energy of a much beloved sister who taught at this academy for many years and died of an illness  which kept her from continuing her duties at Loretto Academy. Her existence is well documented by the Concordia Cemetery Association  as well as her personal information and final resting place.", "Loretto Academy", "TX", "Ghost" },
                    { new Guid("81dd7a55-d8e5-4975-8e2a-382b0faf747d"), "Lawton", "Army Base was built on former Native Lands and was the site of massacre in early (?)1800's. Sightings of native American spirits  and unusual noises common place. Also  home to grave of famous chief: Geronimo.", "Fort Sill", "OK", "Ghost" },
                    { new Guid("81ec9e85-cbf3-4fae-899f-5a3145b2a43d"), "Rock Springs", "there have been many strange and unusual happening in the building  mostly at night when a lonely deputy is on duty making copies in the office or just simply sitting down and having a cup of coffee  Report seeing people out of the corner of their eye when the building is empty. He shook it off again and went back to his reports when suddenly he turned around and there standing in front of him was an old man wearing a blue bathrobe and blue slippers. He said the old man just looked up at him and turned around and walked out.. The deputy  not realizing what had just happened  followed the man out the door  but when he reached the hallway  there was no one to be found! Another unexplained happening happened around the same time when the Emergency Management Director was sitting in his office early in the morning and was drinking a cup of coffee when suddenly someone slapped the back of his chair and sent him flying up on top of his desk! When he turned around to investigate  he realized that no one was in the room with him  let alone  no one was even in the building at the time of the event!", "County Offices Building", "WY", "Ghost" },
                    { new Guid("8248d2c1-4bcb-4fda-b0d6-97d826daf781"), "Vaughn Woods State Park in South Berwick  Maine.", "I was hiking in the woods  doing occasional whoops and wood knocks to try to illicit a response. It felt so squatchy from the moment I got there  but I got no response to anything. I was about an hour into my trek and I see off the beaten path a series of footprints. The snow had stopped yesterday and I tell you these prints were FRESH. I am thinking I just missed that squatch by a matter of minutes or hours! SO CLOSE! Well  let me tell you what!! These things were 12'' long and the stride between steps was measured at 8 feet! The line of prints was straight  just like you see with other evidence of a bigfoot trail! It was INSANE. There were no other prints around  I followed these about a quarter mile into the depths of the woods and off the beaten path. The snow was up past my knees at some points but how could I stop following this epic trail! I could see some prints more clearly than others  I could see toe outlines and the heel in a few! I have pictures and videos to share with you. By the looks of the size of the prints and the distance in stride  this seems like an adult sasquatch  These things were huge!! The sun was setting and my phone was dying so to my dismay I had to turn around and get back to the path before dark  otherwise I would have followed those tracks until they lead me to whatever made them  and we know what made those beasts! This is the BEST day ever. My very first bigfoot evidence and experience and I couldn't be happier!!! There is literally NOTHING else this could be  it is an amazing and documented bigfoot footprint trail!", "Report 56798: Possible track way found in the snow in Vaughn Woods State Park east of Dover", "ME", "Bigfoot" },
                    { new Guid("82542cce-6a54-4777-95a9-acf467d134f2"), "", "\"while camping in the Lake Luzerne/4th lake area we heard several hoot-whoops on July 24th at approx 0130--200.prior to hearing these whoops  I heard something large walking approx 20-30 ft away from our camp. a distinctive \"\"cracking\"\" noise was made as if something very large either broke or stepped on a large branch these vocalizations were between 2  and possibly a 3rd animal. they were heard moving away from our area. I almost wonder if they were herding prey for hunting purposes. approx 02 hrs later I heard them again as they moved back into our area.I have heard these noises before and I immediately recognized the sounds as they are so unique.there were 7 people in our tent. 4 teenage girls (my wife myself and our 10 month old son.we all heard them and needless to say the girls and my wife were a little startled.\"", "Report 26338: Possible vocalizations heard by campers In Lake Luzerne area", "NY", "Bigfoot" },
                    { new Guid("825dbeaa-c054-4d25-aedc-caf6f328e107"), "i am quite surprised that there are no other reports  coming from the wanblee area. there is a creek running from a butte (8 miles south of wanblee) through wanblee and out to the badlands. and there is a rich history of sightings of bigfoots in this particular area.", "\"i just started working as a police officer  and i was assigned the midnight shift. i was doing my basic patrols  when i was runing low on gas. the officer who was working the evening had the gas card with him and he lived approx. 7 miles south of wanblee on a gravel road. i did speak to him over the phone and he said that he'll be waiting for me to come get it. i drove out to his residence and i did get the card and i started driving back into wanblee. as i was coming over a hill (the ditch area is approx.4-5 feet deep  on both sides of the gravel road) my patrol unit was a chevy tahoe  which did sit kind of high to the ground. i was north-bound when i started to descend the hill i noticed some thing \"\"bobbing\"\" in the ditch (west side of the road) and i was kinda high off the ground. i thought it was a bat or a bird  so i did'nt think nothing of it. the next minute  i did saw something run across the road  right in front of me. it was running towards the east.  i did see what i think was the shoulder area to the thigh area  through the windshield. i had a side view of this thing. i could still remember seeing the reddish-brown hair which covered the thing. the hair looked to be approx. 4-5 inches in length. and the overall torso/body from what i could see  was slim. from the chest to the arms. the arms were long and slim  i do not remember seeing the hands. it only happened for a brief second or so  but what ever it was.....was very fast. i did stop and turn around to try to see what it was   but it was gone\"", "Report 13691: Police officer describes late night road crossing sighting south of Wanblee", "SD", "Bigfoot" },
                    { new Guid("8281c4b4-4f9b-4337-b4b3-cb51d2b68e94"), "Downers Grove", "Metallic cylinder in sky  hovering still no sound or movement.", "Cylinder", "IL", "Alien" },
                    { new Guid("829dafbb-dc23-4361-a035-beaaf9bd8967"), "Lewes", "Triangle shape craft with lights at points and center made low turn over tree line and disappeared into trees.", "Triangle", "DE", "Alien" },
                    { new Guid("82c5bc7e-0da7-4d9d-bb11-545d4c7d059b"), "Bridger Teton National Forest- HWY 30 out of Cokeville  WY  North to HWY 89 to Salt Creek pass  right turn onto Forest Service Rd 10072 east into National forest about 16mi from main highway to FS 10138 to 10128 north to Thompsom Pass Please don't post actual directions online.", "\"There were two separate incidents within 12hr time of sounds so unusual that  to this day  I can't explain or rationalize out of my mind.  I had arrived at a campsite near Thompson Pass  the evening before the start of deer hunting season. The campsite was about 500yds off the forest service road and in a dense pine forest  near a logging trail that led to a creek. I settled in for the night in a sleeping bag in the cab of my truck  waking up at about 0400  with the need to go to the bathroom. I rolled the window down and listened for any \"\"critters\"\"  most notably bears. Grabbing a flashlight  I left the truck and relieved myself. As I was preparing to return to the truck  I began hearing the sounds of something breathing deeply to my left and to the rear. Shining my flashlight in that direction  I saw nothing  heard nothing move. I quickly got back in the truck  and then began hearing this warbling  like a man yodeling in a high pitch  from the direction of Thompson Mountain. I rolled up the window and stayed awake with my .44mag. I waited until dawn to leave the truck to hunt- I usually leave about a half hour before dawn  depending on how far I'll be walking to the area I plan to hunt  but those noises had really spooked me. I got to the heavily wooded ridge partially up Thompsom Mt  at  the convergance of two main game trails  remaining there until about 3pm  only seeing one small doe moving quickly head hunched down. I passed on it. I then began moving down back in the general direction of my truck  and keeping an eye on the area where a spring comes out of the side of the mountain  and trickles down to Witherspoon creek. From the area where I had been hunting came this bone vibrating sound  so loud with like multiple harmonics   its hard to explain. It was beyond a roar. I half expected to see a dinosaur crash through the trees  it was such an unreal sound. It lasted 4-5 seconds. I was out of there and on the way home  scared spitless. I've since mentioned the experience to a few co-workers  and none have had or heard of anything like it.\"", "Report 6037: Hunter hears unusual vocalizations on two occassions", "WY", "Bigfoot" },
                    { new Guid("82cf3e3e-ccb4-4985-93a2-8194552605a5"), "Sioux City", "People taking pictures  hunting for orbs  experience slight disorientation  and cameras stop functioning until you leave the premises.", "Graceland Park Cemetery", "IA", "Ghost" },
                    { new Guid("83176169-0a8f-4161-a54e-440341ca1e61"), "Lily Dale", "On the 3 floor of the Maple wood many people have reported seeing someone  perhaps a maid  in the corridors.  Many people have heard footsteps in the hall  felt a presence  or heard soft voices in conversation.", "Maplewood Hotel", "NY", "Ghost" },
                    { new Guid("83523c1b-5bab-4918-b095-553cb1f3fa4b"), "Kansas City", "Platte River Access - Strange This had an old bridge on it up until about 6 years ago when the state tore it down. The frame of it is still standing  however the part that you could drive on is completely gone. The bridge was too old to support traffic anymore. There is still to this day an old car that is partially buried in the riverbank that you can easily see that fell through it a long time ago. There have been reports of unusual noises  including muffled screams  footsteps in the leaves in the fall  gunshots  and voices talking from various locations on the riverbank. Platte County doesn't really have a major significance in the Civil War  however there is a history of skirmishes.", "The Humphrey's Access Conservation Area", "MO", "Ghost" },
                    { new Guid("835794c0-9106-48f4-bfac-4bd7e7750443"), "Memphis", "according to several witnesses a 35ish year-old lady with a long light blue dress has been seen walking around the lake (usually on the south side) at night...she asks for help with an out stretched arm  but when approached she vanishes. It was reported that the body of a lady with a blue dress had been found near this lake raped and stabbed in the 1960's but its unknown if there is a connection.", "The lake at Overton Park", "TN", "Ghost" },
                    { new Guid("83a3017f-154f-4c21-85f8-f3730f187b64"), "Maspeth", "Several hovering lights seen moving in strange formations and directions.", "Light", "NY", "Alien" },
                    { new Guid("83e540d4-00c8-468c-9837-73a7a5826bd1"), "Casselton", "Imitates aircraft; red  blue & amber lights in the evenings  same place every evening; there are others nearby.", "Unknown Shape", "ND", "Alien" },
                    { new Guid("84043c30-f287-44d4-a80c-20a5f7a48f5e"), "Green Vally its a camp ground.The lady that ownd it at the time would let us camp off season and off camp grounds back in the woods.", "We heard the most undiscribable cry/scream ever heard it was almost blood curdleing.it sounded about 1/4 mile or so away.All seven of us froze.We all just kind of looked at each other in disbelive asking each other what the f--k was that and before ya knew it it did it again but this time it was right behind the tent. sounded like 50ft away.and if you think we froze before we were freakin now.nobody moved a muscle.turns out this sream has been heard by many researchers and has been recorded and this is why I am coming foward with this now.", "Report 22192: Possible screams and stalking heard by seven campers out Newton", "NJ", "Bigfoot" },
                    { new Guid("8436bac1-ab15-4dbe-b9fe-619f9c75b5e3"), "Greenfield", "Noticed a very large  slow moving  reddist tinted object in the northern sky. It appeared to have 2 smaller objects flying around it. F", "Unknown Shape", "WI", "Alien" },
                    { new Guid("8438dd2d-e02d-4a2f-bc33-6b2587db0469"), "take Mill Creek road to Blue Creek rd  go left and follow to Fivepoint then go right on Blacksnake ridge", "witness was ridding with some friends up blacksnake ridge in their suv. They came to a stop to spot Elk  The witness Stephanie was looking in an area called laird gulch when she noticed what she said to be a black colored  upright walking primate.  Witness says the creature was approx 7-8 foot tall and could see its arms swinging back and forth as it walked down a ridge.  She asked her friends to take a look with thier spotting scope to confirm what she was seeing but they woul not take the time since they were watching a herd of elk on the cloe ridge.  The sasquatch walked down and into the woods at which point she lost site.", "Report 2195: Girl watches large black sasquatch walk down ridge", "WA", "Bigfoot" },
                    { new Guid("851aa601-e4f3-4b4a-a13c-a68abe789a8a"), "Saint Charles", "We were at a local fireworks display. Just before dusk  I looked up in the sky with my son and saw a large green object shooting acros", "Light", "MO", "Alien" },
                    { new Guid("8612f46f-5cf0-4cd2-a14b-d0af06143ff1"), "", "Well i live in bentonville Akansas right now  my dad own his own buisness. One Day we got on the subject i was telling him that i had bought a little book of ghost stories and bigfoot sightings and how i was very  itrested in bigfoot. Then he told me that he seen bigfoot before and he told me the whole story. At fist i didnt belive him  but a couple of years later he told me the same story when we got on the topic again. The story is that he was riding ATVs with his friends around or in ether lost bridge lake of bever lake and he was at the front of the group of 4-wheelers and they were going down this hill that led to a dirt road. Since he was in front of the group he went down first and got on the dirt road and stopped to wait for the rest of the group to come down. before they came down he lokked over across the dirt road on the other side of the hill on the tree line where the evevning sun was shining through the trees and seen the big foot walking. He said it was taking really big steps and apered to be 7-8 feet tall. He couldnt se the color because the sun was shining through the trees and big foot so you know it apeared as a shadow. Then the rest of the group came down and he told them what he saw and they didnt belive him. Thats all he told me. He told me he coudnt remeber every detale. But he still knows more than me  i cant remeber everything. The reason i'm telling you and not him is that i probably coudn't get him to get on here to tell you this. I'm telling you this because im learnig about bigfoot in our biology class at bentonville high school. my teacher is a marine biologist and a cytozoologist. We watched the big foot movie and the legend of boggy creek in class. Plus the sightings in Decator which is write by our town. So all this bigfoot stuff is making me so excited to dicover the bigfoot and do my part in adding another unreported sighting  since i know theres got to be alot of them out there. If you need any more info i dont have a phone but you can write me at (Withheld)  my name is (withheld) or you can call my dad who was the one who seen it at (withheld)", "Report 7045: Man riding 4-wheeler observes a bigfoot reaching into a tree", "AR", "Bigfoot" },
                    { new Guid("863a6f3c-f932-4fb4-ae20-128cc2271f21"), "Smyrna", "Girl in white dress floating through hallway  chairs turned around backwards  objects misplaced and moved  all electrical objects turned on.", "Union St.", "DE", "Ghost" },
                    { new Guid("864dcd85-f70f-4557-9657-1b72c1fa6d2f"), "Oquawka", "In the old days when slaves were being traded  Alexis Phelps kept slaves hidden from traders. It is said that slaves walk around the lower levels and crawlspaces of the house. Alexis Phelps is said to be walking around the entire house.", "Alexis Phelps House", "IL", "Ghost" },
                    { new Guid("869e5df4-3952-4c45-bf13-2df37ce5700a"), "Westfield", "The spirits of maids are know to haunt this mansion. Mr. William Steward lived here once. In the basement there is axes and other weapons. A 4th grade class took a trip to see the Mansion and 2 boys had an encounter with a spirit. It was a white shadow. They said it looked like a girl in there mid 20's. She was in the corner crying and they went over to see who it was and nobody was there. The spirit still haunts the McClurg Mansion and the 4th grade classes still go there for a field trip.", "McClurg Mansion", "NY", "Ghost" },
                    { new Guid("86b714bc-8c05-41bf-901d-7119989c0926"), "Schofield Barracks", "Hearing mumbling voices  body paralyzed  and your can hear someone in the room with you laughing  pulling on your blankets. A lot of the rooms here are haunted by WWII soldiers  some ghost don't bother you but let you know they’re there by knocking on stuff walking around in the hallways  but some are evil and will show you that!", "J Quad Building 846", "HI", "Ghost" },
                    { new Guid("872558b0-c551-47c5-955b-59c7ee9faf00"), "West side of route 7", "On Saturday Sept 5th of 2015  my wife and I were driving north in our RV on route 7 very close to the Vermont state line. It was about 1:00 in the afternoon. My wife saw an animal on the west side of the road. The animal was about 50 yards from the edge of the highway. What caught her attention was that the animal was walking upright. It was very tall ( well over seven feet ). The animal's fur was black. It was most definitely not a bear. We are both mystified as to what this animal could possibly be. W&C Waterbury  CT", "Report 49697: Daytime sighting while traveling on US-7 North of Williamstown", "MA", "Bigfoot" },
                    { new Guid("87d65991-8b2a-48f5-b5a3-38c37d474381"), "it was about 3 miles east of hwy 84.  not too far from the mountain.  There was creek that ran through the pasture.", "\"We were walking down the road enjoying our summer vacation.  When one of us noticed that there was something walking in the pasture North of where we were standing.  It was close to 7 feet tall  had long white hair (at least a foot)  was walking on two legs.  It stopped when it noticed us standing there watching it.  Actually we were almost too scared to run.  Anyway it acted like it was going to come our way so we took off for a little ways then stopped to look again.  Everyone knows that a fence with 6 strands of barbed wire is at least 5 feet tall right.  Well  it stepped over that like it wasn't there and kept on going to the East taking long strides and swinging its arms back and forth while it walked.  A few days later we were in the same general area and noticed some long white hair hooked on the top wire of the fence.  We took it home to prove our story we told the day before.  We called it a Honka.  Have to say that we were more careful about how late we stayed out from that day on.  Always made sure we were home before dark.  Until the moment we saw it we had heard lots of stories but never believed them.  Seeing is believing.  If you can talk to anyone in the Dustin area you will be told of several sightings of this nature and also will be told about what everyone called \"\"The Light\"\"\"", "Report 5817: Woman recalls childhood encounters.", "OK", "Bigfoot" },
                    { new Guid("8807b842-8108-4058-9f73-65bb072ffd43"), "Sylva", "A shadow looking like a man and the feeling of not being alone and watched  voices and strange screams have been reported. There are also spots along the road that are warm at first then they become ice cold a few steps further. Years ago there was a murder of a woman and her husband. There have also been numerous accidents involving both humans as well as animals on this road. These accidents have been rumored to be caused by the man and woman that were murdered.", "Dillsboro Road", "NC", "Ghost" },
                    { new Guid("8860bf3e-33c0-4cf6-a25f-4b14f4e35414"), "In a development off RT 112 in Charlestown known as Five Seasons.", "\"I've told very few people this story for fear that they might think I'm crazy. The only reason why I'm taking the time to report this is because of a recent entry a friend of mine who knew my story told me about. My story takes place in Charlestown  Rhode Island in the late 1970's. My mother and father and I lived in a wooded area abutting the \"\"Indian Cedar Swamp\"\" and property owned by United Nuclear which probably comprises several thousand acres. The property surrounding our home was mixed  white Atlantic juniper swamp scarlet  red and white oaks with old growth white pine stands mixed in  with a dense understory of briars  mountain laurel and blue berry brush. We lived off a road with 3 houses on it. The houses were all built close to the entrance of this development. The road was part of a series of roads that were put in as the start of a development. The roads were oiled gravel and had been left to grow in after years of little or no use. It looked like the developer had started and went belly-up. These roads were great to ride bikes on or take a evening cruise on after bringing my father dinner at his second job. My mother drove a baby blue Mustang Mach 1 and she would drive around the roads with me looking at deer before we retired to our home for the evening. As a kid I remember this being a highlight to the evening. I was at the time maybe 8 years old and my mother and I on this particular night in the late 70's commenced our ride around the roads to see if we sould see any deer. It had been raining earlier with thunder and lightning mixed in. Now it was just raining. We were rounding a corner on one of the roads that paralleled the Indian Cedar Swamp and as we started downward   we noticed the road was obstructed by a large blown down oak tree  the tree had green leaves (this makes me think it was summer or the early fall) on it so it had recently come down  we guessed maybe in the storm earlier(possibly lightning). The road was very narrow and the brush along the side of the road made it difficult to back the car around to turn around. The rain was falling but not heavy  the wipers were on  the headlights on the car were on as well. As my mother turned the front end  of the car the lights cast on the left side of the road where the tree had been broken off from its stump. We were maybe 1 1/2 car lengths from the stump. Beside the tall fractured stump stood what looked like a large white(yellow white) ape. It was maybe 6 to 7 feet tall  its hair was long  face flat  long massive arms  its head appeared to be without any neck  its chest was broad. My mother and I froze momentarily (5 seconds  maybe 10) and the figure remained still  staring at us. My mother floored the car into reverse. I remember ther terror of it all. The sound of gravel hitting inside the fender wells  the sound of the brush crushing against the car and then the acceleration as she sped off. We were clear as to what we saw and we have no question in our mind that we saw something or someone in ape like shape that night. This we are certain of. We need no one to tall us what we saw  it's crystal clear. For years we told no one. We would talk about it in our home in privacy and even my father found this story hard to accept. We've never forgotten this and this story would have never been told if it wasn't for someone else informing me of a similar sigthing. I'm now in my 30's an extremely active hunter  farmer and woodsman. I hunt deer 40 days a year in Maine  RI  CT and New Jersey. I use automated cameras which are triggered by heat. I've never seen a picture of a bigfoot on my film. I have seen pictures of deer on my 50 acre tract of land that I would never believe are there if I didn't see it on my film. I know every inch of my land and the surrounding property and these mystery deer show up at all hours on my cameras and frequently at that. How can they move right around our hunting parties in such a small area and never be seen  I'll never know  Even today I find it hard to accept what we definitely saw. I'm not a fan of ghosts  UFO's or even big foot. I'm not sure to this day what I saw wasn't a man in a costume  dressed up  out in rainstorm  a half mile or more from any home  waiting for my mother and me to drive down the road to give us a scare. The only thing I can say is it was a damn' good costume and a damn' good plan. We saw what we saw and this is something I would sware to on any polygraph test as I'm sure my mother would.\"", "Report 6643: Mother and son see sasquatch closeup from road", "RI", "Bigfoot" },
                    { new Guid("887060c4-3278-4910-bf18-75205b624c35"), "Grants", "Upstairs there is a room used for banquets. The upstairs used to have apartments  but they were gutted by a fire in the early 1990's and remolded. There is a ghost that shakes what sounds like a key ring full of keys. Often the ghost shakes them right next to people's ears. There are cold spots  and the ceiling fanlights go on and off at will.", "Montecarlo Restaurant", "NM", "Ghost" },
                    { new Guid("88744990-0f9f-4232-b329-b22d9d4d5da0"), "Sandisfield", "Apparition of a little girl  misplaced items would always return where you had just looked.", "New Boston Inn", "MA", "Ghost" },
                    { new Guid("889161ce-94e4-40e1-844c-ba1a1dde271b"), "The tracks were off the Maxwell Butte trail  I had been cutting cross country and would have to draw a map or show someone the exact location; my campsite was just up the road from the blacktop area  second camp site on left - sits across from large reprod.", "While I was archery hunting on Aug 31  2004 near Maxwell Butte  I found two tracks that measured 14x5 inches  both tracks had a prominent large toe on the side of the track. The tracks were not together but on the same ridge. I also found a feces pile that was like bear in contents (berry seeds) but much larger and more human-like.  it was like a fifty cent piece in diameter and 12-14 inches long. I had a visitor the next morning at 4 am. I was sitting in my dimly lit tent listening for elk bugling. I woke at 3 am and was wide awake drinking coffee and hoping to get a head start on my hunt by hearing elk. I was surprised by a low growl that sounded like it came from my stomach. I thought it was odd that I didn't feel it  but as soon as that thought crossed my mind a loud scraping sound was followed by a loud thud that came from the thick patch of trees next to my tent  only 2-3 feet away  I heard no other sound after that. I slapped the table top [inside the tent] hoping to hear something leave but whatever stomped the ground didn't make another sound. I put my boots on  grabbed an axe and went outside yelling  hoping to scare off the animal but I never heard another sound. I think a bear would have been more obvious. This animal was able to get next to my tent and leave without me noticing anything except for the growl and the stomp.", "Report 9289: Elk hunter hears growl  finds footprints  feces.", "OR", "Bigfoot" },
                    { new Guid("893ea3a0-7ce3-44ed-9f40-b29924b34be3"), "Estes Park", "Randomly moving lights in the sky moving above  through  and below clouds.", "Light", "CO", "Alien" },
                    { new Guid("8a5c8f14-9a9b-42bd-9862-154f3841b750"), "Dillsboro", "When Norfolk-Southern began expansion into the southwest mountains of North Carolina  it was difficult for the company to find men able to do the hard work required. Convicts were brought in to complete work on a tunnel right outside of Dillsboro. To get to the site  the men had to cross a section of the Tuckaseegee River on raft. One day  the raft flipped over in the rain-swollen river and all of the convicts died (except one) because they were chained together. The men were buried on the mountain above the tunnel. Sometimes  especially after a big rain  people report hearing chains rattling and the echoes of men splashing in water yelling for help. **Interesting fact about this tunnel** This is the same tunnel Harrison Ford walks into in the movie 'The Fugitive'.", "GSMR Tunnel", "NC", "Ghost" },
                    { new Guid("8a6f2f37-a989-4711-ad09-e5a93a14d7e3"), "Paulding", "Dogmeadow lights - A mysterious light appears in the distance along old railroad tracks and power lines. Also  cold spots have been felt by visitors along the viewing hill. Every clear night on this road all you have to do is look for parked cars. Over the next hill as soon as the sun goes down you will see a red orb hovering in the air. After a few seconds it will turn white and disappear. This has gone on every night for many years. A lot of speculation has gone on but with no definite answers. One story is the light is from the lantern of a railroad switchman who fell asleep on duty and was killed  but there are many more.", "Robins Pond Road", "MI", "Ghost" },
                    { new Guid("8a9ea7b0-3dd0-4655-afc8-c250ba99e49a"), "Makaha", "Lights flicker at night and reports of hearing screams.", "Makaha Elementary", "HI", "Ghost" },
                    { new Guid("8abfd299-d43d-422e-a2c6-dff90e4a51f4"), "Rapid City", "\"the storage room is haunted by a ghost called \"\"Sparky\"\".- March 2007 Correction: \"\"Sparky\"\" is a well-known figure who reportedly plays jokes in the theater. He snaps lights on and off and opens and shuts doors  rattling staff and students. Former students now in their thirties has reported He was named Sparky when they went there. A freshmen at Steven's reports Sparky played tricks on them every time they are practicing for a concert. He messes with the sound system  the lights  the doors  everything. He doesn't haunt the storage room. For more information  please visit  www.unexplainedresearch.com/media/rapid_citys_haunting_reputation.html\"", "Stevens High School", "SD", "Ghost" },
                    { new Guid("8b0665f2-606d-459d-b0e8-c6395d4e97b5"), "Lawton", "This forest was built a long time ago for the dust bowl. The forest is extremely deep and is haunted at night by shadows and taking young teens away at night to get them lost in the forest. Many kids have been lost in the forest and have never been seen again. Shadows walk the forest and supposedly small nematodes (Indian like figures) grab and scratch you to the bone. Once you enter the forest it is extremely cold and quiet  you always will feel someone watching you.", "Parrelle Forest/ Wichita Mountains", "OK", "Ghost" },
                    { new Guid("8b0bea1b-0603-4d99-b631-2e4e69aa37af"), "Salsbury", "The house was owned by this man and his family. The family ended up dieing. The house is now used as a old folks home. People who live their clam they have heard glass breaking but when they look nothing is broken. They have seen a young girl who wears a red dress and walks about and is friendly with the residents.", "Shard Villa", "VT", "Ghost" },
                    { new Guid("8b8f5653-aa47-4a52-9a30-c39a94f2f4ca"), "Hamilton", "The little town of Hamilton near Craig  in Northwestern Colorado has a benevolent spirit of a mountain man or trapper from a century ago. Sightings of him are wearing buckskins and smoking a pipe. He suddenly disappears and only the smell of the pipe remains. Witnesses will catch a glimpse out of the corner of their eye. When they turn to look there is nothing there  also the strong scent of a pipe or cigar.", "The Town", "CO", "Ghost" },
                    { new Guid("8b9660df-4017-433c-b3e1-f02609ed0834"), "Barnes", "It was stationary  with a red light. I looked to my West  and another one  identical  with same red light. Other person captured photos", "Circle", "KS", "Alien" },
                    { new Guid("8be2a98c-54df-4705-a943-f500d5e227ac"), "Bayou La Batre", "\"Late at night while everyone is quiet and still  a ghostly figure can be seen leaving the cell in the middle of the jail. Also  you can hear the toilet flushing  even though no one is ever in that cell. The legend has it that the cell served as a \"\"drunk tank\"\" and the cops hung a man there in the early 1980s.\"", "Bayou La Batre Jail", "AL", "Ghost" },
                    { new Guid("8be9384c-c40f-4fad-9485-b3e767f8ec26"), "El Rito", "Multiple changing colored lights following a path", "Formation", "NM", "Alien" },
                    { new Guid("8c0210d0-267a-49bb-828a-61ba1250a90c"), "The sighting occurred in a high-elevation park meadow in the Fan Creek Drainage in Yellowstone's northwest corner.", "\"The following account was given to Colorado curator T.E. Stein during a phone interview with Bob Jackson in 2003. Recently  Jackson gave permission to submit his account to the BFRO.  Jackson  also known as \"\"Action Jackson \"\" was legendary among park supporters - notorious among outfitters and scofflaws - for his enforcement of park rules and regulations. He retired as a Yellowstone ranger in 2004. Few people have ever known Yellowstone's backcountry and its wildlife like Jackson. \"\"The  first time heard anything was in the mid-late 70s. An outfitter and I were riding up Fan Creek in the northwest section of the park. Up the drainage in Stellaria Creek  we heard a sound that just kept going and going. It was probably a mile away. It filled the whole valley up - kind of 1 000 like elk going to their death. I couldn’t believe this thing had that much volume for that long  a period of time. He had never heard anything like it  neither. \"\"A couple of weeks later  I was coming out from Sportsman Creek  taking a trail which comes out of Fan Creek. I was 11 miles back in  up high in a subalpine fir meadow complex. I was on a  steep sidehill with horses and in woods but down below about 40-50 yards there was a kind of fairly flat meadow  with dense  subalpine thickets. There were these low fir growths that have a centerpiece tree and then everything kind of cone-shapes to ground. They were about 20 yards wide or so. \"\"The horses were flaring their noses and snorting  like they do when a grizzly bear is real close  but I could see fairly good all around and I couldn’t see one. So I started looking down below me  and the horses were really agitated – they’re wanting to get out of there. I held them but only with effort. \"\"I looked down to see where griz was  and I saw a deer at edge of thicket. All at once it bolted and started jarring ahead perpendicular to me. Right then coming out the other side was this thing that was running on two feet. It was black like a bear and it had long arms and ran. I think I held it there 30 seconds  but it got scared and then came out. It ran but not super fast. It ran to another thicket and went at angle out of thicket to another thicket about 40-50 yards away (At this point  the creature was 75 yards downslope.) \"\"It kept hitting these thickets trying to get away from me. I’ve never seen a bear do that. They’ll always take a straight line. \"\"The first thing I thought was “bear” but right away I realized this black shaggy thing wasn’t a bear. This thing was smart. I’ve never seen animal trying to pick up protection as it fled. \"\"I tied that together with sound had on other side of the drainage. \"\"It wasn’t that tall – it looked like it was like 6 foot  maybe 6' 5\"\". The side of the face looked like it had a lot of fur. Most of the time it was angling away  so I only got a good look at the head for probably the first 10 steps. \"\"The proportions of the torso - it looked more stocky than anything else. I notived the arms swung more than a human’s would and it didn’t have elbows cocked. \"\"This was no hoax. I’ve ridden maybe 50 000 to 70 000 miles in the backcountry on horses and you encounter a lot of bears when you do that. This thing  whatever it was  the horses looked straight down to it.\"", "Report 12302: Yellowstone backcountry ranger describes sighting  other incidents", "WY", "Bigfoot" },
                    { new Guid("8c052f65-ae1b-4f6d-b2f2-34464cc2d81f"), "The bigfoot was headed west toward the Gila National Forest  and away from the Bosque del Apache National Wildlife Refuge.", "Traveling south on interstate 25 on 12/24/1986. My wife and I both saw the bigfoot running across the hwy. I pulled over to shine my headlights on it. It had gone over an embankment. It must have squatted down because we never saw it again. The bigfoot was very tall  hairy  skinny  with long arms.", "Report 66089: Night time sighting on I-25 within Bosque del Apache National Wildlife Refuge", "NM", "Bigfoot" },
                    { new Guid("8c5749f4-dfa7-48a0-858b-2062903123c3"), "Salt Lake City", "Stationary silver ball very high in daytime May 1980 observed approximately 45 minutes.", "Sphere", "UT", "Alien" },
                    { new Guid("8c63f3d7-7060-4ba5-b80c-943d703ea938"), "Anna", "2 dark shapes above clouds with light around them and flickering", "Circle", "TX", "Alien" },
                    { new Guid("8d1b308e-afbb-4008-86a0-246c2c67b057"), "", "well my self and my dad were camped at woods canyon lake in the spilway camp ground.. well on friday around 3 to 4 in the after noon i was fishing on the spilway.off the the east is a hicking trail that gose up the hill and around the lake..out of no where a bolder the size of a basket ball come flying thru the middle of the pine trees an 10 to 15 feet into the lake.well befor this happen u could hear birds cherping.well when is happen it got quiet quick..another guy saw what i did we bolth looked at 1 and other and he ended up leaveing", "Report 16397: Rock throwing incident at Woods Canyon Lake.", "AZ", "Bigfoot" },
                    { new Guid("8d7b7789-7279-4cb4-aaf0-0b50a65cad70"), "\"A few miles south from Malad City  Idaho on I-15 is a rest stop the \"\"Cherry Creek\"\" rest stop on the mountain side of the freeway. My report is from that rest stop\"", "\"While traveling from Herriman UT to Rexburg Idaho  I stopped for the night at the Cherry Creek rest stop off I-15 just before Malad Idaho. I parked in the \"\"Truck\"\" area as close to the mountain and as far from the restrooms as I could. I fell asleep in my pickup camper shell approximately 10:00 pm At 11:00 pm something woke me up  I sat up and looked around and saw nothing out of order  I could see very well due to the rest stop lights  I saw one big rig parked in the truck area and no cars at all. The truck may have awakened me when he pulled in. I laid back down and few minutes later I heard brush breaking a couple of hundred yards up the hill  I thought it must be a bear or an elk. Ignoring the breaking brush I tried to go back to sleep then while still awake I heard a clear distinctive wood knock  very clear like a bat on an oak tree. I listened for another half hour or so and heard occasional brush breaking  I then fell asleep. I was then awakened at approximately 3:00 am by breaking brush that sounded much closer than before  followed by one clear knock from uphill and north of me 10 seconds or so later another clear knock further up the hill but to the south (two separate locations) I got up a little freaked out and drove north to Malad  Idaho\"", "Report 57784: Traveler sleeping at rest stop near Malad City awakened by possible wood knocks", "ID", "Bigfoot" },
                    { new Guid("8d9eb651-6404-42c3-a362-12726dec7dce"), "Milledgeville", "Samford Hall - The third floor of the dormitory which has now been closed only leaving two floors has been an area of a ghostly sighting. Some say that the ghost of a girl who committed suicide over an unexpected pregnancy still lingers on the floor in which her suicide occurred.", "GC&amp;SU", "GA", "Ghost" },
                    { new Guid("8e3384bf-f715-45b7-b9e5-08f49cb222c6"), "Kennebunk", "Reports of doors slamming  people running up and down the old staircase  apparitions of soldiers walking on the rafters in the barn and cold spots.", "Wallingford Hall", "ME", "Ghost" },
                    { new Guid("8e7da633-d866-4c96-99bf-fdc177f069ab"), "Salt Lake City", "Bright starlike object over oil refinery in SLC zig zag over mountainside & went straight up at high speed", "Light", "UT", "Alien" },
                    { new Guid("8edb69bc-dd2f-4eb4-8ca4-0e30fef84e48"), "Dickinson", "There are reports that a figure can be seen walking the mall after hours. One story goes that a police officer was making his rounds in his vehicle and saw someone inside in the mall. When he went to investigate  he could find no one.", "Praire Hills Mall", "ND", "Ghost" },
                    { new Guid("8ee5f7f4-ac6a-4b68-8999-566ecf860a33"), "Pickens", "In the old Police hall (currently the museum) in the living quarters the first sheriffs family lived there. The mother died of typhoid or some disease acquired from the family well. The mother of the family supposedly haunts the semi-circular tower that is on the right side of the building-you can see her in the second story window usually after 11 and most often during a full moon.", "Pickens City Museum", "SC", "Ghost" },
                    { new Guid("8f0057fa-9937-4fc8-acfb-6a83de85750d"), "Grand Junction", "Horse Thief Canyon is located west of Grand Junction and connected to the Colorado National Monument. In the 19th century  horse thieves would bring their latest herd of horses here and hide them for a while. One night the sheriff surrounded the area and shat the thieves along with some of the horses. The spirit that haunts this place seems to be unrelated to the canyon's history. On certain nights a woman in a white dress has been spotted walking from canyon wall to canyon wall. Her background is unknown  but others have claimed to see her walking the banks of the Colorado River.", "Horse Thief Canyon", "CO", "Ghost" },
                    { new Guid("8f75ea44-31e5-41b6-972a-ee9fa16d70f3"), "Lake Bistineau  outside of Shreveport near a town called Koran  not far from Houghton", "\"This occurred approximately 18-19 years ago when I was about 13 or 14--probably 1979. My mother and I were inside our home. The time was probably close to dusk  there was still a little bit of daylight left. The next thing that I remember was that my mother said\"\" that it was awful quiet outside all of a sudden.\"\" Then we heard the dog  start howling and scratching to get into the house  which was remarkable in its' own rights because this dog was tied to a stake in the yard. This was a Big German Shepard that had to be tied up because if he ran loose  he had a nasty habit of killing any animal he crossed paths with. Anyway as soon as my mother opened the door to let the dog in  the dog literally knocked her over and went immediately into the bedroom under the bed. The door was still open  so I looked outside and (this happened very fast) I noticed how dead still and quiet everything was. I felt that little charge of fear race up my spine and I remember that the hairs were standing up on my arms and neck  and at that moment my mother came back ! and started to shut the door  when all of a sudden we both heard this SCREAM. It was not human  it was not any animal I had ever heard. It was almost like a cross between a woman's scream and a cougar. Since I knew that there weren't any cougars or women standing out on our dock  we both knew we were hearing something unimaginable. We then heard big sloshes of water  as if something great was passing through the lakefront. (Our House was only about 1/2 an acre up from the lake.) This whole episode probably only lasted about 5 minutes. We then noticed that the normal sounds of the swamp came back as if someone had turned the lights back on. We knew that whatever it was  continued down the lake. We heard from other families that lived along the lake that they had experienced the same thing.\"", "Report 1516: Unknown animal with loud scream visits lake front home  frightens dog; something heavy is heard walking in the water", "LA", "Bigfoot" },
                    { new Guid("8ff95d98-5740-4101-bfd3-42d522aab05d"), "Grand Junction", "reports of 3 to 4 different shadows have been reported to have been seen in the building by members and employees. One shadow is said to have been a woman who died of unnatural causes in the building. Employees have reported trashcans that were left on the tables after mopping were thrown across the room  doors closing on their own  and voices have been heard.", "The Elks Club", "CO", "Ghost" },
                    { new Guid("9004ec25-4e55-42c7-b5f7-f7aa41b49de8"), "Milton", "\"When your on stage you can some times hear strange things and some times music \"\"banjo\"\" from the rehearsal room even when no ones there.\"", "Mountaineer Opry House", "WV", "Ghost" },
                    { new Guid("90de592d-460d-4cdf-8795-7e51acf5e049"), "Crestview", "On a normal basis  this cemetery is haunted by a ghost that walks among the grave at about 1:24 A.M. AS the story goes this ghost is a man late 80's ; retired officer looking for his wife. He appears mostly in Feb. - January 2007 additional information: The road is between a gas station on highway 90 and a hairdressing place. Keep going past the church  a ways. This road is mostly paved. It's on the left hand side on a dirt road - it’s very narrow (ie  you can't turn around in it till your in the cemetery) KKK apparitions  ghosts of the lynched and a wondering man. There seem to be a lot of white flashes  like a sheet running and then it's gone.", "Cobb Cemetery", "FL", "Ghost" },
                    { new Guid("90ff7809-7931-4abf-8a34-a0f4681de7ac"), "St. Joseph", "After the floral shop shut down they tried to sell it but no one wants to buy it do to its weird happenings. There is a very eerie feeling when you enter the building. Plus it kind of looks like a castle. People have heard a beautiful sound of piano playing from the upper floors  they hear foot steps  noises in the fire place.", "The Old Park Floral Building", "MO", "Ghost" },
                    { new Guid("91085c1e-49dd-46fb-8a18-e0b514df94fb"), "Narragansett", "\"Figures seen walking from room to room in the main office building (that was once and old farm house).  Creepy feeling in the basement of the museum hall.  Things reported being moved overnight in the museum hall by the only person who had the key.  A former employee reported seeing a full apparition outside via the reflection on a computer monitor.  The apparition was thought to be a real person that was coming into the office...no one came in  and no one was in the parking lot. The \"\"person\"\" was reported to have been wearing early 1900's garb  plaid/pastel blazer with kakis  a tan round flat straw/wicker? hat  with a matching breif case.  The museum is located where the beach house/mansion of former Governor Sprague used to be.  And very close to Narragansett town beach  the \"\"it\"\" beach to be in victorian times.\"\"\"", "South County Museum", "RI", "Ghost" },
                    { new Guid("9177f604-4384-4c44-a8a5-8bc815852254"), "Wakefield", "\"A protective ghost haunts the top floors of this old Victorian.  It slams doors  sometimes emits an odd stench  turns up the heat  and turns on electrical appliances.  The ghost is unknown but referred to as \"\"Satan\"\" because of its need for hellish temperatures.\"", "Allen Avenue", "RI", "Ghost" },
                    { new Guid("92152849-40ea-4f19-9603-103447347609"), "Stamford", "I saw 6 bright lights with blue triangular lights between them on a triagular shaped object hovering low in the sky.", "Triangle", "CT", "Alien" },
                    { new Guid("92c5df69-c061-40aa-a84b-5f670ea5221d"), "", "\"When I was fourteen  I am 39 now  I was out rabbit hunting on our farm. It was getting dark so I started walking towards home. I entered the field to head up the hill  just then I saw a very dark figure \"\"crawling\"\" on the ground.  It reminded me of an alligator walking due to it wasn't using its rear legs.  Instead it was dragging them behind it while on its hands and stomach. I was unable to tell where it went from there  it had gotten very dark and I stayed put until my dad came looking for me with the tractor. I was too afraid to keep going due to fear. I remember it was hairy like an animal and appeared long in length. I went down the next day and seen where the drag marks were from it dragging its feet and where it seemed to get up and walk into the woods. Large footprints were still in the ground. Not sure anyone would believe me  I never told anyone. I was raised around all animals on the farm  been told what large animals were in the area. Never seen anything like it.\"", "Report 43758: Hunter recalls his observation of a dark figure crawling on a family farm near Markton", "PA", "Bigfoot" },
                    { new Guid("92f41f5f-ba69-4aa2-9081-770d02572301"), "Raccoon", "Strange fogs/mists and orbs have been reported.", "Mount Zion Cemetery", "PA", "Ghost" },
                    { new Guid("932d8df0-88e0-4b0f-b410-bc417cb706b8"), "Council Bluffs", "Feelings of getting sick  major emotions and disorientation are felt.", "Lewis and Clark monument", "IA", "Ghost" },
                    { new Guid("934763eb-3d99-4146-b222-8e0464ecde91"), "Wickenburg", "The mine was founded by Henry Wickenburg  when he found gold there. There are a couple of haunted places. One is the caretaker's house  in which the man and wife heard strange noises. They will openly share their ghost stories. The other haunted spot is the mess hall. There have been smells of food  even though this kitchen has been deserted. It is on the self-guided tour of the mining camp. Also  further down the road  to get to the mine  is the Vulture Mine cemetery. This is where old miners have bee buried. There is said to be a headless Indian horseman. Visitors say that they feel watched  and they can sense death. There are a couple of places on the tour where people have died  such as the hanging tree and a cave that collapsed on miners.", "Vulture Mine", "AZ", "Ghost" },
                    { new Guid("93e4b30b-9bc1-42c0-925c-7e6e2ae48a49"), "Couer D'Alene", "\"Sherman Ave - Most of the rooms have shown some level some level of activity. Rooms #1 and #3 seem to be the most active with ashtrays falling off tables  lights flickering on and off and items left on tables changing positions. People have often reported \"\"creepy feelings\"\" in these two rooms. All activity seems to be non-threatening and somewhat benevolent. Before being turned into a motel in the early 50's it was an officers quarters for the Farragut Naval Base.\"", "The Bates Motel", "ID", "Ghost" },
                    { new Guid("93eec002-3b95-4e3b-a80a-72ed4529833c"), "Rutland", "The light the triangle shape no sound  even a hotair bollon make noise", "Triangle", "VT", "Alien" },
                    { new Guid("940264ea-f4c4-4361-81df-bde2189f3d7b"), "Lake Charles", "This is an old road that is on the outskirts of town. A railroad runs across the road  leading to the rice factories. The story is that a long time ago  in the 1950s  before there were railroad signs there  a family consisting of a mother  father  and two daughters went down that road. Despite the fact of the older girl protesting going down that road due to a bad feeling  the father drove down there anyways and the car got hit by an oncoming train. Reports of seeing orbs and the apparition of the older girl. When you drive down that road  you get a very strong  odd feeling of being suffocated.", "Old Railroad", "LA", "Ghost" },
                    { new Guid("94291667-38a8-4942-b032-a1e8ccf95ddf"), "Henry", "It looked like a star at first  then it started moving in circles  going straight up then back down again and then going in circles aga", "Light", "TN", "Alien" },
                    { new Guid("944de46c-d667-46b9-8cf8-5c7cbaa0ca0e"), "Bayard", "\"There is an old lady seen in the creek crying and yelling for her child. A flood had supposedly gone through this woman's home and washed her son away. She is still heard and seen in the area calling for her son. Another story is  She was a beautiful Hispanic women the only problem was that she was poor. One day she was in the village when she met a handsome man. They started dating and ended up getting married. Then one day she noticed that he had changed. He was always leaving town and leaving her to tend to her children. Well he would leave more and more. Until she caught him cheating on her with another women. Well instead of getting even  she that she would get back at him by not letting him see the children  by drowning them in the local creek. When doing this she realized what she was doing and tried to stop but she lost control and let the kids go. Well they started to float down the creek  she tried to run after them and try to save them but it was no use she had lost them forever. While running she tripped over a root in the ground and hit her head right open. She died instantly  Well the story goes every night you can hear her crying and yelling for her children this is what they call the \"\"Llorna\"\" which means crying lady. Since that had happened it is said that you can hear her crying all over searching the riverbeds for her children.\"", "Chino Mines Creek", "NM", "Ghost" },
                    { new Guid("9478594d-aa94-42b5-ab3e-fa946eed7815"), "Ajo", "In the 1950's  a couple was married in Ajo and was driving to Lake Tahoe for their honeymoon. Around midnight  they entered into crater range  which was lined with hills and huge rocks on both sides. Their car crashed into a rock and they were both killed. It is said that if you drive through crater range after midnight you can see their car and the couple off to the side of the road  trying to flag down help.", "Crater Range", "AZ", "Ghost" },
                    { new Guid("9495c22e-beb6-413a-86b5-8d3b5392480e"), "Opp", "Strange stationary lights in the sky.", "Sphere", "AL", "Alien" },
                    { new Guid("952f1c2a-d312-4fac-816f-bf3f02df0580"), "", "\"Well  I went out hunting with my Lab  I got a full-blooded Lab  my dog. And as usual I went out on a Wednesday. It was a nice sunny day out  nice weather  around 72 degrees  75 degrees  very good weather. I drove back into the area where I've been hunting every year for the last 20 years. And that's when I had an experience. The dog kept acting up. And I also noticed a kind of a stench smell and I thought maybe it was something dead. And I kept hearing something of more of like a grunt noise. So I kept hearing that and as I heard that I thought maybe somebody was playing jokes or something on me or playing a prank but then I realized there was nobody else I knew out there  there weren't any other vehicles so I went ahead and started looking around  for mushrooms. I walked maybe less than ten feet and I heard a few more grunt noises toward me and they seemed like they weren't that far off  I had that feeling that someone was watching me and as I stood there I heard it went from a grunt to  oh I would say  a loud more of a scream or yell. I have never heard nothing like that in my life before. And it proceeded twice after it did it the first time it did it again a few seconds later and then I heard three like movements in the trees  like cracking and the brush was moving and lo and behold here comes my Lab running back  with the hair all the way up from her neck and all the way down to her tail  and her tail all the way between her legs and her head down and she was looking towards the area where I had heard the noise. The dog was scared  I have never seen my dog ever act like that. That is when it kind of scared me because I thought if the dog is that scared what is it? Well then I ended up getting in the vehicle  it scared me and I still had that feeling I was being watched. I got in the vehicle and backed my truck all the way up the road that is along side a corn and soybean field I backed up and proceeded towards the back entrance where I came in and I parked it almost mile from where I was actually at when I had these experiences and I went on the opposite side of the corn field. As I went over there I thought I will hunt over here  it seems like it is more open  a lot of thickets and brush but not as thick as where I was at and it was quite away off and there was still plenty of daylight  sunshine. When I got out and walked down in there I looked across the creek and the water was probably no more than four or five inches deep. And there isn't really a lot traffic over there and when I walked I couldn't believe my eyes I seen footprints  actual footprints  and I knew it couldn't be human  a human wouldn't have walked in that area barefoot  for one there is too many thickets and he would have been crazy if he did and two it was so big Shaq couldn't have a foot that big. The first one I found was the right foot and the big toe you could see it very clear  and the other one was four feet away and it was the left foot. On it you could see the heel and the toes. Basically after that I came the next day. My son-in-law  who is an ex-police officer  wanted to go out. He was a non-believer and a skeptic and basically didn't believe me. He wanted me to prove to him I wasn't lying. So I said  \"\"I'll let you be the judge  maybe I'm making a mistake  maybe I didn't see what I seen.\"\" We went out the next day and found other tracks that were in the same area from where I found the first set of tracks. So instead of finding two sets of footprints we found like six of them. They were all scattered in an area within fifty yards along the creek. That was on May 6th  which was a Thursday.\"", "Report 27692: Mushroom hunter hears vocalizations and finds footprints near Jubilee College State Park", "IL", "Bigfoot" },
                    { new Guid("95424d1f-b2a9-49df-9af6-a6cc0d52407d"), "Westport", "Silent  very slow moving  pulsing red lights under perimeter  passed directly overhead  making 90 degree change of direction  S to W.", "Circle", "CT", "Alien" },
                    { new Guid("95521913-7ca1-4d3f-8906-0094bd92ea1d"), "St. James", "You sit down stairs and hear guns cocking upstairs  the lights will go on by them selves  the radios and TVs will go on and be turned as loud as they can go. There has been seen of a woman walking down the hall and standing at the edge of the bed covered in blood. The dogs wouldn't go into the grove ever they would stand on the outside of it and howl. There is a light that can be seen coming towards the farm from the field and all of a sudden  just as fast as it would appear  it would be gone.", "The Farm", "MN", "Ghost" },
                    { new Guid("95dcfd5c-9147-4eba-85d3-f90cba12591f"), "Mena", "The ghost light of a young girl that died trying to take care of her family is seen. She is said to wander the mountain with a lantern  looking for her family's cabin. She is actually buried in Old Pioneer Cemetery on the mountain. She has been seen by local folks for many years.", "Rich Mountain", "AR", "Ghost" },
                    { new Guid("96a32799-78ae-4254-8c26-c04eb6944a57"), "Las Cruces", "My father and i were driving home from El Paso  Texas  to Las Cruses  New Mexico. Half way to las cruses (which is about a 30 min. driv", "Circle", "NM", "Alien" },
                    { new Guid("96a7c1fd-f05f-48be-bc3a-592f89a546bd"), "Virginia City", "the ghost of Miss Suzette still walks across the schoolyard.", "Fourth Ward School", "NV", "Ghost" },
                    { new Guid("970dd0bb-3e7e-40fa-9549-606347249f86"), "New River Gorge", "To keep it short..I was deer hunting in the new river gorge in Fayetteville WW and it was in 2007  the week of thanksgiving. It was evening with about two hours of daylight left and I noticed movement about 60 yards towards the gorge from my position..I raised my gun to view the movement through the scope..after holding it in position for 10 sec or so I saw a very large hand appear from the side of a large Poplar tree..it was palm against the tree and I saw fingers mostly..then to my surprise I saw a head peek from around the large tree and two LARGE eyes affixed on a head if a creature I've never seen before..and I'm a hunter..have been since I was 8..I'm now 38.. The Bigfoot blinked twice while looking at me and then stepped back behind the tree..I viewed it for about 20 seconds while it was looking at me..my mind just couldn't figure out what it was and I knew what it wasn't..I had no desire to shoot it and very well could have but my mind and body almost seemed to be in a state of shock while viewing it..I had to cross near the location on the trail out if the woods and I was F'n terrified even with a loaded deer rifle..my hair stood on end when I realized that I would have to go towards the location to get out of the woods..I called my uncle as soon as I got to my jeep and told him..he believed me..I am a VERY honest man and would never lie about this..the thing is though..I never heard it run away or move through the leaves..and you can hear movement from 200+ yards off in these woods..it's like it just disappeared..I came home very shaken from the experience and it changed my life..now I know that it is out there. It was very cool looking..about 7ft tall  it had very dark large pupils and around the pupils its eyes were almost owl like..it had brownish blond fur and it had a visible face..it almost looked like the troll faces that you used to put on your pencils as kids..really..but  it was very clean looking and not what you would expect..its fingers were long and thick with no fur and it had dark fingernails..I had my scope on 9 power and it was equivalent to being about 30 ft from me visually..it was real and I would take a polygraph and swear on my life.", "Report 34043: Observation by a hunter through his scope by the New River Gorge Bridge near Fayetteville", "WV", "Bigfoot" },
                    { new Guid("976a7c5f-126b-41b1-8f55-07ed36d55d66"), "Denver", "Spinning Triangle shaped craft with lights on tips spotted in thunderstorm", "Triangle", "CO", "Alien" },
                    { new Guid("97b1cf47-1008-4f57-96a4-cc507036d503"), "Monmouth", "This is one of the oldest cemeteries in Warren County. Most of the stones date back to the early 1800's. There is an Indian buried there who was killed by the people trying to settle in the area. Story has it that this Indian was responsible for scalping a white farmer who was working in his field. The community hunted down the Indian a killed him. There has been documented investigations in this cemetery several times in just the past few years. Many uncertain images appear in pictures and audio recordings playback what sounds to be Indian chanting. The area residents discourage anyone from entering the cemetery after dark. This stems from several problems with cult activity in the years past. Many have stated that even on the hottest summer day once you enter the cast iron gates of the cemetery a cool breeze will follow you around. If you travel to the cemetery go to the farthest stone in the southeast corner of the cemetery and you will find the stone of the unnamed Indian.", "Sugar Tree Grove Cemetery", "IL", "Ghost" },
                    { new Guid("97e74d7a-9f86-480c-a547-b28ee99b22c5"), "Fredonia", "Igoe Hall - A student named Jimmy Igoe was killed on a fishing trip to Lake Erie. He now haunts the halls of this structure by slamming doors  changing television channels  turning lights on and off  and messing with the water in the bathrooms and he messes with the elevator. When you ask him to stop  he will.", "Fredonia State College", "NY", "Ghost" },
                    { new Guid("97f02bde-623f-4bd9-824c-18b115454a6f"), "1 mile north of Lugerville grade road and 1/2 mile east of rock creek road  deep woods.", "This is totaly unbelievable  it has happened again. I can not even believe this myself  one sighting in a lifetime is hard enough but when this thing shows itself to me again  I'm starting to think maybe it is hanging around in the same type of woodland areas that I do. I am a Pro. woodsman and most of my outdoor treks take me away from all other human interferance  another words I go where other people do not want to go or will not attempt to go. The reason for this is that in my area the public are getting more and more populated in the areas that I choose to hunt or just get away  so I travel in deeper woods and swamplands away from there interferance. Well as I said I have seen this thing again  and this time it was about 3 miles from where I had spotted it the first time during hunting season. This sighting was as though it was curious or that it was following me  staying in the shadows moving only when I moved. Although this time at first it took me by complete suprise  I remained calm and also let myself observe this thing's every noticed action  trying not to let it have any knowledge that I was watching it as well. I would move taking a slow pace for about 50 yards at a time  turn to my side and kneel down acting like I was picking at the ground. It would stop and watch me from the shadows  as I move another 50 yards and watched it  it would wait till I would get about another 50 yards then it would stop and simulate what I was doing  it would crouch down and paw at the ground where I was kneeling. It would continue to sniff at the air and try to catch scent of me. After about a hour of this cat and mouse it dissapeared. I got a real uneasy feeling when I notice it about 75 yards to my right it was flanking me. This action made me very nervous  I have seen this with coyotes tracking a wounded deer. The thought ran in my mind that it was hunting me  but this feeling passed as I kept moving on. Again it would only move when I would move  perhaps it knew that its movments would be hidden by my coinciding movements  or it was trying to get in a direction of catching my scent. I kept moving in a southeast direction  stopping every 50 yards acting like I was digging and rutting around on the ground  keeping my head down and turning looking up with my eyes and not moving my head up. I thought it was gone but noticed it behind a uprooted tree root system peeking through a hole in the roots. It was closer now and was not aware that I new its location  at only about 30 yards I could make out its eyes and the right half of its face. The eyes seemed to be the color of a whitetail deer  no whites only dark. I moved on and after about another half an hour I was getting close to a area that loggers had clear cut  and it was gone. I sat in the area for at least another hour but it did not appear to me again. While I was watching this thing I got a chance to observe it and notice a lot of its features and charicteristics. Its height is only about 6 to 6 1/2 foot  it stays in the shadows  has dark brown hair with blackish streaks almost like what you could call brindle. Walks with a hunched over ape like character. I did not notice any smell. And it made no sound. I am convinced that this is a creature that with some time I can get close enough to again. No one can tell me that this freek of nature does not exist. It has showed itself to me twice.", "Report 8121: Hunting & fishing guide has afternoon encounter in deep woods near Lugerville", "WI", "Bigfoot" },
                    { new Guid("986ec287-9c4a-4546-898c-8a3a6b2d5187"), "Chapmanville", "In the band room office of Chapmanville High the ceiling has always leaked.  Maintenance workers have replaced ceiling tiles  pipes  and repeatedly checked the roof above for leaks  but the ceiling continues to leak.  PVC pipes have replaced metal piping  yet the water leaking is a reddish hue.  Stories have been told that previous to the school's construction  the bottom which it occupies was a swampy area  and it has been said that a murder occurred there on the spot that is now the office of the band room.", "Chapmanville High School", "WV", "Ghost" },
                    { new Guid("99396455-ccfd-41c3-b095-f92137ee0ea7"), "Dickinson", "There have been many reports of toilets flushing by themselves and the feeling of being watched/followed by workers in the early morning hours. The ghost is said to be that of a doctor who went on a fishing trip  but never returned. He is believed to have drowned on that fateful trip.", "Ear  Nose and Throat Clinic", "ND", "Ghost" },
                    { new Guid("993c5dce-9f4c-4dce-9499-b33836699e69"), "McCracken", "CC Cohen Restaurant - Haunted History - CC Cohen Restaurant - Known to most Paducah residents as the Cohen building  this important structure was built around 1865  probably for M. Livingston & Company. Afterward  it became a clothing store  a dry goods store and in 1914  a Paducah City Directory identified the occupants as the R.L. Peacher Liquor Dealers and the Rehkopf Distilling Company", "Paducah", "KY", "Ghost" },
                    { new Guid("9959cb32-d33f-425b-8018-2d2c5f977a65"), "Stratford", "Before the Mansion was built a lady named Goody Basset was burned at the stake for being a witch. After the house was built  lots of people have been drawn out of it. The legend is that if you stare in a mirror in the house  you will not see your face but Goody Basset's and she will prick your arm with a needle for staring at you. - November 2005 correction: Phelps was owned by Reverend Eliakim Phelps and his family in the 1800's. But the history of Phelps still intrigues people to this day. Reverend Eliakim Phelps was returning to his home on Elm street in Stratford after Sunday service on March 14 1850. With him was his wife  two sons ages three and eleven  and two daughters ages six and sixteen. When they entered the house  they found the interior in shambles. Furniture  food and expensive china had been strewn around the downstairs rooms  the Rev. Phelps first thought was that the house was burglarized  until he entered the dining room. He then concluded that demon spirits had entered his home.", "Phelps Mansion", "CT", "Ghost" },
                    { new Guid("996657ca-5c02-4a4a-b3f2-0ab8bb206278"), "Franklin", "In the mid to late 1800's there was said to have been a lady in her 20's killed in the dining room. If you stand in the dining room late at night you can see her backing towards the dining table and a man in late 1800's clothing will stab her on the table. - March 2008 Update: On 12-28-2006 The Poor Richard’s Summit Inn burnt completely down. The Inn has been known for catching fire at least once a year. The owner & 1 of his dogs died in the fire.", "Poor Richards Summit Inn", "NC", "Ghost" },
                    { new Guid("9980ef38-41be-4c6f-98ed-b68832a7013d"), "South Campground of Interstate State Park", "We set out to do some squatching at Interstate State Park in Wisconsin.  Our party consisted of 4 adults and 2 children.  We set up camp and had dinner in the South Campground.  After dark we began our first night op at 10pm.  We left my wife and the 2 year old in camp with the fire.  Nick  his pregnant wife Jennie  their 5 year old son Atticus  and I went up a small ridge above our campsite to begin.  We walked slowly working south east of camp and further from the campground.  After about 5 minutes we heard something in the woods following us intermittently we stopped and waited with lights off for about 4 minutes. We continued to walk and stop with lights off until we got about a half mile from the camp.  At this point Atticus  the 5 year old  was ready to go back.  We started back and then stopped to do some whoops.  I did two whoops spaced about 30 seconds apart  no returned noises.  We continued to walk and stop.  When we were halfway back we let Atticus try some whoops.  He did two about 30 seconds apart.  After his second whoop there was an immediate response from within a hundred yards of us.  It was a slightly higher pitch whoop than I have heard before.  We waited about 4 minutes before continuing to go back to camp.  When we were about 100 yards from camp we stopped.  Jennie and Nick remained with lights off as Atticus and I turned our flashlights on and returned to camp.  As they sat by a tree they both heard something approaching them from the direction of the returned whoop.  It got so close that Nick stood up.  Then it took “four large  quick  heavy steps” back.  When Nick turned his flashlight on nothing was seen.  They then returned to camp.  As we sat and debriefed in camp we heard noises around camp  but dismissed them as raccoons.  I was looking to the woods beyond camp and began to see orange eye shine.  I thought it was a single star  but it moved lightly and would leave and return into view.  The next morning I saw that where I was seeing the glow was well below the ridge line and could not have been a star. Nick and I traded places while sitting in camp and he saw the same shine leave and return a few times as well.  Nick and I returned to near where he and Jennie had sat to leave an apple in a tree.  We all went to bed around 12:30 am.  Nick  Atticus  and I slept in a tent while Jennie  Sara and Hagen slept in a small teardrop camper.  After falling asleep Nick and I both woke up abruptly at 1:35am.  We immediately looked outside the tent to see a raccoon on the picnic table.  When we made noises to scare it away we heard something else moving around camp. We listened for a while before returning to sleep.  At 3:10 am we were woke up again.  We listened for a while  heard nothing  and went back to bed.  In the morning Jennie told us what happened to them in the camper.  At 1:35 am she was woke up not by the raccoon on the picnic table  but by something large walking in the woods behind camp.  She heard us scare away the raccoon and whatever was in the woods walked off.  At 3:10 am something started to shake the camper.  She said the camper was moved back and forth 3 times.  Her reaction was to laugh out loud from inside the camper.  She laughed because Sara and Hagen were sleeping through the event.  The shaking stopped and she heard something retreat back into the woods.", "Report 45418: Campers hear possible vocalization and have trailer shaken at Interstate State Park", "WI", "Bigfoot" },
                    { new Guid("99de68ab-2838-4a35-b211-15b44aceb898"), "Location on Map: 39.680008  -95.696218", "\"While bow hunting in a field in Kansas  I observed something that I could only describe as a Sasquatch. I was sitting on a stool next to a round bail of hay near the tree line. I was near a deer scrape. As I sat watching the tree line to no avail  it began to get too dark to see my fiber optic pins on my bow. So  I began gathering my gear to make my move to my vehicle. My friend was hunting farther up the tree line in the timber. After gathering my belongings there was still enough light to see an opening near a corn patch. As I stood up I saw a figure which I thought was my hunting buddy. I said in a normal voice  \"\"Did you see anything?\"\" The figure did not reply. Upon further observation I saw that it was walking in my general direction. It stopped next to a round bail and I realized that the figure was at least 3-4 foot taller than the bail of hay. I began moving toward the tree line as to not silhouette myself. As the figure was closing the distance to 100-125 yards I began to make out body features. The head was kind of high with no visual neck  broad shoulders which tapered down to a slim looking torso. The outline of the body allowed me to see that his arms  shoulders  legs were extremely muscular  like that of a professional athlete. The arms were longer than normal and he walked in silence. As I stood there trying to figure out who or what I was seeing  I never had a sense of fear. I had my iPhone on me but it never dawned on me to make video because I was in what felt like a dream like trance or shock. As I realized what I may be seeing I hastily skirted the tree line to my truck. As I approached my truck the first thing I did was open my palm and slapped the shit out of my tailgate. As  I hit my trucks tailgate I then observed the figure drop down on all fours and in four seconds flat it was gone. It either used the bails as cover or it was the fastest living thing I have ever seen move. After meeting with my buddy he informed me that he shot an arrow at a buck  but it ricochet off of the breast plate. He then informed me that the deer was going to run in my general direction toward the field but the buck stopped in his tracks and looked into the field  then turned around and came running back from the same direction that my buddy just shot at him from.\"", "Report 65984: Hunter's dusk sighting of a sasquatch on the Kickapoo (KS) Indian Reservation", "KS", "Bigfoot" },
                    { new Guid("99fa3273-efa5-48f9-a2ab-ce7a883bb58a"), "This area was behind Chesterfield Golf  Club  and bordered up river by St. Louis County Water Works. This area is now fenced off and posted by Missouri Department of Conservation.", "\"While Bow-hunting in Creve Coeur bottoms  I had been in my stand all day and had no luck. So I got down right before dusk and proceded to stalk along side a trail leading to the river. I had come to a point were the trail turns and runs parelell to the river.When I started around the turn something moved in the corner of my eye off to my right. My first thought was that I was going to scare up a deer  So I drew my Bow and tried to take aim on the area of movement  But what I saw was not a deer. At first  I thought it was a man in camo laying on the ground  That freaked me out  so I let off my Bow. However  I was trying to make out this \"\"person\"\" laying on the ground  on thier belly  When it raised up on it's right arm  turned the upper half of it's body  And looked at me. This was no person. It was to dark to see any features  But I could see two legs stretched out behind it  Two arms in front  A large torso  And a head. It seemed to be covered in greyish-brown from head to toe. No visible gear  Which struck me as odd  So I continued to try and figure out what this was. I stared at it  And it at me  When I felt the need to LEAVE. I did not feel threatened  Just that I had to go. As I began to leave and head back toward the levee  I kept thinking about turning back because I could not believe what had happened  But something made me go out of the woods. I have grown up in woods all my life  Have hunted in south-central and eastern  Missouri  And grew up only a few miles from here  But never before have I seen Something I could not explain. If this thing had stood up  It would easy have been a foot or more taller than Me.\"", "Report 10927: Bow hunter observes animal lying down in the Creve Coeur bottoms.", "MO", "Bigfoot" },
                    { new Guid("9a4fb107-2386-469b-aefb-610793384dc9"), "Newark", "\"A long and windy road near the Pike Creek area that many have sighted eyes  herd screams at night  had things run in front of their cars  seen things chasing their cars  accidents are a near miss on this dark and creepy road. The trees that line it seem to fallow you and bend down towards your passing car  the woods seem to move with you instead of being passed  keep your eyes open and your foot on the break while driving this haunted road. There is also somewhere on this road a tree said to have had an abandoned baby placed in it to die  sometimes if brave passersby stop they can hear the tree \"\"crying\"\" the distinct sound of an infant crying in the darkness surrounds visitors.\"", "The Valley", "DE", "Ghost" },
                    { new Guid("9aa3ae20-4500-4612-b103-5e887e385c6b"), "Off of Interstate 155 at the Obion exit  turn west (away from town) go about 2 miles and Glass is the first Community you come to. It has been seen over about a 3 mile radius to my knowledge.", "\"Well this is going to sound strange but  here it goes. I grew up in a small community were something else lived. I have talked to people from that area from three generations that have seen this thing. If you have never seen it most of the people that have won't tell you much  they do not want anybody to think they are crazy!! I even knew one man who  is dead now that had a relationship (fed it and it was not afraid of him)it. Any way I seen it 3 times during my childhood 1 time from about 200 yards with 2 other people. The other 2 times I was alone. One of those times I was maybe 40 yards away coming home and it was in my back yard by a fence. But the last time was very intence  I was walking home from town (about 3 miles away)and it was pretty dark so I was looking down most of the time. I was about a quarter of a mile from home and I turned onto the street that led to my house. I walked about 30 feet and there it was. It was about 10 feet in front of me. It was down on it's hands and feet doing something! It saw me at the same time I saw it  it stood up and we looked at each other for a few seconds (it seemed like forever) then it ran one way and I ran the other way. Now we always called it the White Thing. It looked like what most people think a big foot looks like except it is an off white color  it is about 8-9 feet tall. My father always said all of us kids were \"\"seeing things\"\" untill he found tracks while hunting. I know 30-40 people who have seen this thing.\"", "Report 25432: Man relates a series of encounters with a white bigfoot near Obion", "TN", "Bigfoot" },
                    { new Guid("9b23dcf9-a6c4-497f-a07b-96444b75a99c"), "Pace", "Orbs in the maternity section", "Wal-Mart", "FL", "Ghost" },
                    { new Guid("9b54222b-54d9-44a8-90aa-df5b3c958a1b"), "Leefield", "This location is so notorious as to be completely abandoned at night save the most curious. This tree was reportedly used for numerous lynchings and is currently surrounded by a small community that has been in this area since pre-antebellum. Reported that bodies can be seen in the tree from a distance and if it is approached  the swaying bodies will stare at the trespassers. Other sightings conclude that there is a murder of crows that constantly watch for trespassers as well.", "The Hangin' Tree", "GA", "Ghost" },
                    { new Guid("9c7ea572-a9ba-4dcb-adf5-3043f7673a36"), "Albuquerque", "VERY bright white light  appeared to be about half the diameter of the moon.", "Light", "NM", "Alien" },
                    { new Guid("9cc14f57-ab26-42ec-9431-6ef524bd6c93"), "", "We were on our way to a rental cabin (Cloud 9 cabins)  in Smithville Oklahoma on Oct 1  2009 on Beechton Road (dirt road) at about 4:30pm. The weather conditions were overcast  temp around 60  no rain  daylight  we were driving about 30 mph. No cars  houses  people for miles around. As we were heading to the west from Mena  Ak about a 1 ½ miles or so from the turnoff to the cabins  my wife Debbie smelled something sweet but dead smelling at the same time. About a minute after that  we went around a turn in the road  and saw an animal move across the road from the left to the right  into the brush and trees.  This animal moved in a very fluid motion on all fours. It was dark grey or black  short hair  about 36” long and about 24” high. It had no tail  no collar on its neck. The head was completely round about the size of a large grapefruit. There were also no ears or snout visible. It ran by moving its legs back and forth  not together as in how a cat would run fast. We could not identify it. We thought we might have seen a baby Sasquatch  going to its mother in the woods. We felt the mother might have crossed first  before we came to the curve. We do know what it was not. It was not a dog  cat  bear  bobcat  skunk  wolverine  rat  rabbit  skunk  or anything else that we have ever seen  and we do spend a lot of time in the woods  hunting and camping. The total time we saw the animal was about 3 seconds  and we stopped to look were it had entered into the woods  but saw nothing. What was more striking in my mind was  if it were to stand up. It would have looked like a small dark person. (keep in mind we didn’t see the face) We still think to this day that is/was a baby Sasquatch. When we got back home in Missouri  we looked on the internet for baby gorillas  to compare what they looked like to this animal  and there was a close match.", "Report 26711: Couple witness a possible juvenile running on all fours in Smithville", "OK", "Bigfoot" },
                    { new Guid("9cf42d5f-f6c9-41ee-86f4-b843cc853219"), "We returned to the site the following year and found the cemetery. Our camp was about 100 yards away. I would need to look at the map again to verify the exact location.", "\"Myself and 2 good friends were camping in the Lill Aaron Strauss Wilderness area of Green Ridge State Park in Allegheny County Maryland. We were all in our late teens but very experienced campers and very comfortable in the woods. On the 2nd night of our trip we made camp in a low area several miles off the trails near where our topographic map showed a Civil War cemetery was located  though we were unable to find the site. After dinner we sat around the fire as the darkness grew and we all began to feel a bit spooked  as if we were being watched  so we let the fire burn itself out and bedded down. Early the next morning I awoke to a loud wailing which I can only describe as a cross between a lion roar and a screech owl. The noise happened several times and it was very close. At the same time we heard something crashing through the vegetation nearby and what sounded like thick branches cracking and heavy thuds as if large logs or rocks were impacting the forest floor. My friend Bryan and I were sleeping in hammocks over which we had suspended rain ponchos. The ponchos were fastened to the hammocks so we would need to untie them in order to get out and we could not see out either. I whispered to Bryan \"\"what was that?\"\". He whispered back \"\"I don't know\"\". That was all we said. I was scared out of my mind and did not dare even move my head to try to see anything as I didn't want to draw attention to myself. I was able to look at my watch and determine it was just after 5am. At that moment I resigned myself to my fate  figuring that if something out there wanted me I would have no chance. I made my peace and waited  eventually drifting back off to sleep. Bryan did not sleep at all after the episode and our 3rd friend  Tom  somehow slept through the whole thing. We rose around 6am and broke camp. We looked around for signs of anything unusual but could find nothing.\"", "Report 29330: Recollection of possible vocalizations and brush crashing while camping in the Lil-Aaron Straus Wilderness Area", "MD", "Bigfoot" },
                    { new Guid("9df1012b-92ac-4964-b31b-fec09af02d7a"), "Reno", "In 1976 a woman was found dead in the old bathroom down stairs. Her murder was never solved and she haunts the bottom floor of Park Lane Mall and is said appear around 9:00pm on the 3RD Sat. of every month. - March 2008 update: Has been torn down", "Park Lane Mall", "NV", "Ghost" },
                    { new Guid("9e2e5344-b58e-4719-b7aa-9385156154f7"), "Pocatello", "Is haunted by a girl who was locked in the tower of the mansion when she fell ill. My friends and have seen apparition of a man on the side of the front porch and a young boy in old century clothing sitting at the dining room table eating.", "Stanfard Mansion", "ID", "Ghost" },
                    { new Guid("9e5b9824-2471-4da1-be8e-52accf78d559"), "Moscow", "Object moving across sky west to east that was changing colors: red  yellow  green  blue  white.", "Light", "ID", "Alien" },
                    { new Guid("9e5e40f3-2872-4a87-8edb-3bbaafc67069"), "Charles City", "\"In these woods behind the old white farm there have been sightings of a little girl dressed in white  also various girls have been heard. Around Halloween you can hear faintly a chanting that is something like this  \"\"ring around the rosy...\"\" and \"\"wanna come burn with me\"\". Around 1920 there was a train car full of orphans that burned down on the railroad tracks that run through there. a burned rag doll has been found. They say it is there graveyard yet no family ties have been found.\"", "Iron Hill", "IA", "Ghost" },
                    { new Guid("9ef612c5-ca1b-4b7b-a7e7-fd79ecc36752"), "Bessie", "Late at night you can hear footsteps on the stage that sounds like a four-legged animal and you can feel cold spots throughout. If you stay late enough you can see an apparition of a man dressed in a long black trench coat with a large black top hat and long brownish black beard. After investigating the old gym it was found to have been an old morgue back in the day when they had horse drawn carriages  it was a building in which had a basement and large pulling elevator large enough for the horses  later filled in and the gym was built on top of it. A picture of the old morgue proved to me that the apparition was that of the caretaker", "Bessie Gym", "OK", "Ghost" },
                    { new Guid("9f849376-746b-410e-a500-383c91740d0e"), "Not sure exactly where on US 64 - somewhere between Pulaski and Fayetteville. There were woods to the right of the car where a bigfoot was running. We were traveling east on US 64.", "We were in the car heading back home (probably around 10:00 pm) when the sighting occurred. We were traveling east down US 64. There were high winds and my dad had trouble keeping the car on the road. We were driving along when we spotted something run across the road in front of us. It appeared to look like a bear  only more human features  but the rate at which it ran across the road made us believe it could not have been a bear. My dad (who has since passed away in 2002) and I are the only ones in the car who were able to spot what we believe was a bigfoot. My mother was in the car and looked down for a moment and missed what we saw. It happened so fast. The one thing I can remember is the bigfoot was searching for shelter quickly with the storm approaching. I could see that the bigfoot was fearful of the storm and was looking for shelter. It was one of the most unbelievable things I have ever witnessed. I have shared my story with friends and family for years. I believe I saw a bigfoot in the flesh to this day. It was amazing!", "Report 10220: Motorists have nighttime sighting near Pulaski.", "TN", "Bigfoot" },
                    { new Guid("9f87f006-c6d8-4f17-8de7-61176ad109c9"), "Cyril", "some reports have been of a young girl roaming the halls late at night  and doors opening and shutting by selves.", "Cyril high school", "OK", "Ghost" },
                    { new Guid("9f9b1b78-5118-4928-8daf-ceb68faeb683"), "North Chestnut Hill Rd. north of Abner Lane.", "Walking in woods about 50 yds off trail with my adult son. There was a stone wall about about 30 yds from me. I noticed a black figure behind this 2 ft. high wall. The animal was very black. I thought it was a bear at first. After 5 seconds it stood up and walked deeper into the woods. It looked to be around 5 ft tall. I never saw a face. It just got up with its back to me and walked away fast. It had a cone shaped head  no neck  a slim looking body  very black hair  swinging arm was very long  legs seemed shorter. It moved fast but it didn’t run. I yelled to my son who was about 20yds from my left. We tried to follow it. My son never had a visual but he could hear it crunching ahead of us. We looked for about 3 hrs trying to see it again but could not find anything.", "Report 63731: Recent sighting on Connecticut Water Co. property near Killingworth", "CT", "Bigfoot" },
                    { new Guid("9ffa1711-e266-4269-8fe1-31b640ac5e64"), "Van Buren", "Things have been heard and seen by actors and maintenance workers during the running of plays.", "King Opera House Theatre", "AR", "Ghost" },
                    { new Guid("a06270c9-72e2-41ea-90e6-34e0151b3a1f"), "This happened on Coy rd. in Defiance Co. about two miles south of Ney  Ohio", "While traveling at 55-60 mph  I saw what appeared to be a tall being covered with brown hair. It was standing in a ditch beside a cement bridge that was about two to three feet above the road. The being's head was about another two to three feet above that. I estimated that the being would have stood eight to nine foot tall.", "Report 4556: Midnight sighting by motorist on Coy Rd", "OH", "Bigfoot" },
                    { new Guid("a093885d-3077-4a4c-8256-54f56d797cbb"), "East Milton", "there are a row of white houses off the side of Highway 90 that is haunted. Witnesses have gotten pictures of orbs and facial images in the background. In The bathroom  after the room was steamed up from the hot shower  different words written on the mirror would appear.", "HWY 90", "FL", "Ghost" },
                    { new Guid("a0a5c66f-3014-4f81-bb42-c0a3a15dfe70"), "Greenwood", "I took my dogs out just before 5am this morning and saw a flashing light to the west. The object was not moving and high in the sky.", "Circle", "IN", "Alien" },
                    { new Guid("a0e15b86-ba9b-40fc-ba7c-69f80cc5c7db"), "Huntington", "It started out as five lights  then went to one bright light  then the light turned into a ring  and then back into a ball.", "Changing Shape", "WV", "Alien" },
                    { new Guid("a197553a-ade2-4059-9919-835336ccd415"), "Catfish", "N.C. HWY 16.- There is an old Indian burial ground If you go down the road about 3 miles and turn off in the field you will find an old dirt road with a chain blocking the drive. People say they see lights down there and that weird things happen to their vehicles when the lights come near.", "Riverbend road", "SC", "Ghost" },
                    { new Guid("a1b99539-1c43-4071-8cf6-c5f5be9d3363"), "Yuma", "Hotel Lee - At least three spirits have been seen by guests and employees of the Hotel Lee. One ghost is of a young teenage girl  usually seen late in the evening  carrying towels down the back hall. The other is believed to be the original owner of the hotel. She is seen walking the halls late at night  and has been known to knock on  or rattle the doors of the rooms. The third spirit is that of an Indian woman  believed to pre-date the hotel. She has been seen hovering above the guest’s beds  and is known to take small screwdrivers and awls  later to return them to odd places.", "Yuma County", "AZ", "Ghost" },
                    { new Guid("a1cc18ec-970c-4eea-86b8-226dfc20473b"), "North Charleston", "Bright light  not changing  moving fast and low  completely silent.", "Unknown Shape", "SC", "Alien" },
                    { new Guid("a2297582-75c8-455e-a977-623c03c2d8bf"), "Birch Bay", "Restless spirit. Moves about the condo at night moving small articles from one place to another. Rustles through bags  knocks on doors  displaces small objects. Enjoys centering objects that it has moved.", "Cabana Club Condominiums", "WA", "Ghost" },
                    { new Guid("a2593ab4-76e9-443b-b39c-31b45cdd7bf1"), "Bethany Beach", "Observed a spinning circle which emitted various colors in a flared fashion as it moved in an irregular path in the night sky.", "Circle", "DE", "Alien" },
                    { new Guid("a2596c8c-a362-4bb6-828b-2b451a71fc10"), "Reno", "\"When first seen  it was a huge  brilliant white  \"\"bow-tie\"\" shaped object which exploded into a much larger sphere filled with red  gree\"", "Odd Shape", "NV", "Alien" },
                    { new Guid("a274ab29-e65e-4f49-ae7f-9c18303dc83d"), "Natchez", "Madeline haunts this building and has been witnessed by 100's.", "King's Tavern", "MS", "Ghost" },
                    { new Guid("a2817cfb-56ba-498b-83e5-f1985070f0d0"), "Newark", "\"Main Street- Has be remolded several times but back in the 1800s slaves were traded on the porch. It is said that Edgar Allen Poe wrote \"\"The Raven\"\" there. Once a popular dive for the college kids  the wait staff used to tell stories of sounds on the stairs(which were closed off at the time) when opening or closing the bar. Of course no one was there. Often the front doors would swing as if someone entered  but again  no one was there.\"", "Deer Park Inn and Tavern", "DE", "Ghost" },
                    { new Guid("a28b1687-4f3a-4f52-9aec-8ff3cbe09af0"), "south on 285 coming down on the backside of Kenosha Pass headed towards jefferson.", "While headed back to Denver from Buena Vista  My wife and I saw something very large pass in front of another car. This car was in front of us by about 25 feet. The weather was not good as it was snowing and dark out.  I was driving about 12 to 15 miles per hour. At first I thought that it was a person getting out of the car infront of us.  This struck me as odd considering the weather and the time of night  not to mention the location. We were in a 4x4 pick up and I guessed this thing to be about 7 to 8 feet tall. Very dark body with a large head and huge hands. It crossed the highway in a smooth fluid motion  paying no mind to the vehicles coming in either direction.It crossed the road in three or four strides  then disappeared of to the west side of the road. My wife and I remaind speechless for a couple of minutes and then I asked her what she thought she saw. She said it looked like bigfoot. I agreed.", "Report 22801: Further apparent corroboration of multiple-witness  winter  nighttime  road-crossing near Kenosha Pass", "CO", "Bigfoot" },
                    { new Guid("a2e44273-7651-4c11-962a-34e73ecbbd57"), "Wheeler", "Reports of a sinister force chasing and seemingly trying to trap people walking by.", "Wheeler School Area", "HI", "Ghost" },
                    { new Guid("a321e03f-ec7e-4649-b6d0-0d9e2e50b19a"), "it was in a woods at the end of 12th street that is no longer there", "When I was a little girl before i'd heard of bigfoot   i saw in a small woods down from our house what i called a big white hairy thing. it was in the mid seventies....in INDIANA. I've never reported it to anyone other than my family who were witness to my subsequent hysteria. The big white hairy thing was a beige white color  with a cone head sloping back from it's brow ridge.Short hair over its entire visable body ecept for its hands and face longer hair like a cloak over its shoulders.It was june or july...summer time...it's face was brown like leather its eyes peircing black ...a broad flat nose... it was eating blackberries from the bushes...it must have felt me looking at him because it turned to look at me and when it saw I saw him he took two large steps into the wood and disappeared. That's when I screamed.Being only a small child no one really believed me or tried to tell me it must have been someone in a coat. I've never forgotten it. He didn't seem menacing at all but it really freaked my little self out.", "Report 26587: Woman recalls afternoon sighting near the outskirts of Marion.", "IN", "Bigfoot" },
                    { new Guid("a325e876-7149-4254-958b-37cd4f658dc9"), "", "When I was a child  I heard my grandfather  a man who quit school at sixteen  tell stories about something that lived in the Burns Rebrake (a swampy area owned by a Mr. Homer Burns). The stories he told went back as far as WWI and included among others  my grandfather and my father. They never got a good look at the thing(my father always attributed it to bootleggers)but my grandfather said whatever it was  it drove lumbermen out of the woods and beat panther hounds so bad that they didn't come home for days. When I was little  I listened to the old people describe the thing and it didn't register in my mind until I got older that it sounded an awful lot like a sasquatch. I've heard there's something in Lousiana  and with all the primitive waterways that cross that two states  I wouldn't be surprised if the two aren't connected. The Burns Booger as they called it has been absent from the area since the sixties when the lumber companies went high tech. This is the same time the last panther was heard in Attala County. My great grandfather and a man were logging in the area after WWI and something frightened them so bad that they quit logging and refused to go back in there. My grandfather and father along with some coon hunters saw something standing by a dieing fire that they had built. They said it looked like a man but then it didn't. (My memory is hazy) on the exact descriptions. My father's coon hounds were known to hunt panther  but something tangled into them one night setting the dogs to howling in pain and terror. Before my father or grandfather could get to them  it was over. The dogs didn't come up for days. All the old people I heard the stories from saidthere was something in those woods  but the old people are all gone now and no one's heard from the Burns Booger in years. (I've not heard anymore stories of recent origin).", "Report 1339: Creature seen by witnesses", "MS", "Bigfoot" },
                    { new Guid("a37fcfa6-bb62-4f6d-afbd-77d500c8d1cf"), "Honolulu", "It was reported once that a security guard at one of the gates to Barber's Point once saw a yellow Volkswagen parked off to the side of the road. He went to check out the car and found a young woman sleeping in the car. He tried to wake her but she wouldn't respond. He called in the license plate number and found out that the woman had died several years ago in that car near there. He was told that her ghost appears to greet new security guards.", "Barber's Point", "HI", "Ghost" },
                    { new Guid("a38bb9f1-ec8f-4a64-82f2-41bd115fa0ce"), "Keatchie", "There is an old women's college in Keatchie down Highway 172. During the Civil War the college was turned into a hospital for the wounded. It is said that if you go to the second floor (which was turned into the morgue during the war) you can feel cold spots and hear the moans of the departed. To get there go either down Hwy 5 from Logansport  Louisiana and turn left onto Hwy. 172 when you get into Keatchie or from Shreveport go down 171 get onto 172 and go through Keatchie and its not less than 200 yards past the old white building.", "Keatchi Women's College", "LA", "Ghost" },
                    { new Guid("a396a946-cd1e-4b8b-8426-82f0bd28dea8"), "Boulder", "I saw two different (or changing) objects about two minutes apart but in the same approximate location.", "Changing Shape", "CO", "Alien" },
                    { new Guid("a3b5e1c7-a2a0-4a80-afc1-751a36e78934"), "", "\"We have had several encounters with this creature. We used to have it living in the back of our woods near the swamp  but since clearing of land further back from other neighbors  it has moved to the other side of the forest. It still frequents the area. Run-ins still occur and have now for years. And now  there is a young with the mother. I really do not know what to say but the most important thing to me is trying to protect this animal  aka Bigfoot. This creature has not harmed anyone  is shy  but is really not afraid of people. I am hoping that someone here will help me out in determining the next step I could take. I DO NOT WANT THIS ANIMAL TO BE HARMED IN ANY WAY POSSIBLE OR REMOVED FROM ITS HABITAT. IT IS NOT A THREAT TO ANYONE OR ANYTHING!! There have been too many occasions to name that just proved to me and others that we have a family living close by. Seen  heard  smelled  footprints  etc. I would like to somehow get help from the govenment to protect this creature so no harm could come to it from anyone and that no one would try to hunt it down just for the money and fame. That is the only reason I am not giving the location of where all this is occurring. I am a registered nurse. I care about my job and reputation but I would rather have a \"\"rep of being crazy\"\" than ever having any harm done to this creature. Please respond with some help to point me in the right direction to help secure this animal's well-being and safety. Please. Thank you for your time and I await anxiously for your response.\"", "Report 26201: Family reports numerous incidents since 2000", "GA", "Bigfoot" },
                    { new Guid("a3bffbef-f3cd-4295-ab81-17bd382670e8"), "Georgia Ave. and Tulip Ln. run East-West  My house was approximately 1/3 of a mile from Bellevue Blvd.  which ran along the heavily forested area of Fontenelle Forest.", "The following occured in 1975 when I was 14 years old.  My family lived in Bellevue  Nebraska (near Offutt Air Force Base) where my father had recently retired from the U.S. Air Force after 24 years of active duty.  I now live in Florida. Actually  this incident was a series of three encounters over a three-day period.  A bit of background seems necessary.  My girlfriend lived on the next block.  Our houses were separated by a field with a stand of trees on the north side of the field; the stand of trees was approximately 20 feet wide at that time and ran East-West.  The stand of trees ran to the East to Bellevue Blvd.  On the East side of Bellevue Blvd. was a heavely forested area that was either a part of  or bordered  Fontenelle Forest.  I would go over to my girlfriend's  house and visit until it was time for me to go back home (my curfew was 10:00 pm during the summer). The first incident occurred as I was crossing the field on my way home around 10:00 p.m.  I was walking in a NW direction with the thick stand of trees to my right.  I heard heavy foot-falls and occasional snapping of branchs within the stand of trees.  Whatever it was within the trees was paralleling me.  When I stopped  it stopped.  When I began walking again  it began walking.  It was very dark in the field and I could not see anything.  After several stops and starts  I became somewhat frightened and ran the rest of the way across the field  climbed over the 4-foot chainlink fence that surrounded our backyard  and ran up our backyard (it was basically a hill) and into the house. The second incident happened the very next night.  This occurrence happened exactly the same way as the first incident. The final incident happened on the third night.  As I crossed the field I again heard the heavy foot-falls and snapping of small branches within the stand of trees.  However  this time I was not being paralled; the thing was heading in a SW direction which placed it on an intercept course to my NW direction of travel.  I could hear it getting closer  but could not see anything because of the extreme darkness.  Near the point of interception  I began to smell a foul odor.  The odor was very stong and almost made me gag.  By now the foot-falls were very near.  I could feel the thing cross in front of me very close  but could not see anything.  The foot-falls were now on my left.  At this point I became extremely scared and began running across the field.  I'm not sure  but I suspect I cleared our 4-foot fence without even touching it. About half-way up the hill (our backyard) I stopped.  I can't explain why I did this  but I simply felt compelled to do so.  I turned around and saw what had crossed my path.  The backyard and a portion of the field was nicely illuminated by a flood-light my father had put on the back of the house. Standing at the edge of the field next to a clothes-line pole  was a creature on two legs.  It was covered in dark brown hair.  I estimate the height at 7 feet.  This is based on the fact that the clothes-line pole was 6 feet in height and the creature's head was a good foot above the top of the pole.  I was approximately 40-50 feet from it  but could not make out any facial features.  I recall that there was eye-shine  but I can't recall the color  possibly reddish.  The thing was extremely thick across the chest.  The arms hung almost to the knees.  This thing was very muscular.  We stood there staring at each other for approximately 20 seconds before I turned and ran into my house (I chickened out before it did). There is no question in mind that what I saw was a bigfoot.", "Report 7809: Teen has nighttime sighting near Fontenelle Forest", "NE", "Bigfoot" },
                    { new Guid("a3e3efc0-03f7-4f47-b64f-8ce09d77cea3"), "", "Upon my initial encounter  I did not think at all that I would be attributing it to something like this. However  the more I read  the more certain I am that me and my friends had a close encounter with a bigfoot. It was early spring when me and two buddies decided to romp through the woods behind my dad's house. It was just before dusk and there was an hour or so left of daylight. We headed out equipped with only two flashlights and cigarettes. My friends were Robert (a tall well built guy and Paul  another large guy but not as tall as Robert). Neither of them had any beliefs in anything other than the normal mundane. I on the other hand have always had an open mind on topics such as these. We were prompted to venture out based on some local tales of the woods that grew up to my dad's back yard and that encompassed many miles of land along the Stones River in TN. The stories were mostly odd noises (growling  knocking sounds  and screams). The occasional sighting of something strange (figures moving through the woods etc). We always thought it to be ghosts as battles of the Civil War were fought in the area. Anyway  we set out to explore the woods and the horse trail that followed the river several hundred yards behind the house. As we reached the trail I noticed oddly that there seemed to be quite a few trees that had been pushed over and uprooted. I commented on this to them and they didn't seem to think much of it. We continued on and at a fork in the trail we opted for the higher ground as the alternative path was somewhat muddy. This lead us to a ravine that the trail sharply bypasses. On a whim I offered up the idea that we should get off the trail and hike out this ravine to see where it would lead. They both pondered for a moment and off we went. Perhaps an hour or two went by with us all having a great time laughing and conversing when we came upon a spot of ground that was covered with dried grass and chose to take a break. At this point it was well past dark. We shut off our lights and Robert and Paul lit up their cigarretes. I remember looking up while they smoked and seeing stars but no moon. It was crystal clear and I commented on how dark it was. A few moments passed and Robert then seemed to become uneasy and stated that he was ready to head back. Paul and myself seemed a little thrown off by this as we have never seen Robert become so unnerved so quickly. We readily agreed to leave and rose from our spot on the ground and realized that where we were sitting was just 5' from the trail. We climbed the steep embankment and resumed our walk on the trail. The trail follows the river and if you walk far enough it meets the road and curves sharply back into the woods and continues on with the river for many miles. I have never (especially after that night) walked it's entire length. In fact  I can't recall anyone I know that has. Regardless as we started walking I did get the sensation that we were being watched. I think we all 3 had this feeling as our conversation and laughter didn't ever quite resume. We had walked about 15-20 yards perhaps after climbing back onto the trail (which at this point had no trees overhead just on each side of us) and then the trail entered into the woods again. The forest here was extremely thick overhead and it was very dark at this point. We continued on with the intentions of getting to the road as mentioned before. We were perhaps 100 yards from the road when we heard the first branch break. If you asked me today I would tell you that Paul was a little crazy as he darted into the woods in the direction of the noise. He had no flashlight as Robert and myself had the only 2. At this moment I have never seen someone so afraid as Robert was at that moment. He was more than willing to leave our idiot friend and bolt for the road. After some convincing  we headed toward the location Paul had run. We used our flashlights sparingly as we had assumed by now that someone was out there with us. We did not want out lights to give away our location. I remember nearing the point where Paul vanished and calling his name in a half yell/whisper. His reponse still gives me chills. He half pleading asked me to be quiet. Then I heard him making his way toward us. When he entered onto the trail from the trees on our right side I could see his face (barely but enough) was filled with fear. He told us that someone was out here and that now he too was more than ready to leave. We quickly stood up and turned to make our way to the nearest exit... to the road when we heard again another branch break. This was in the direction we were wanting to go. Not what we wanted to hear. At this point  I feel it's necessary to point out that when I say branches breaking I don't mean little twigs. It was loud enough to sound like someone snapping a rather large branch on their knee. To me it meant something big. With no option to leave quickly we opted to head back the way we had come. I would guess that we had walked maybe 2-3 miles away from my home. None of us looked forward to this prospect  least of all Robert. At a brisk pace we began the hike back with our lights on. This is where the story begins to blur and again I get chills thinking about it. Whatever it was had to be following us for from time to time  we would hear the same branch breaking. Each time we did  we would crouch down and huddle together with our lights off. Then  when all seemed well  we would trek off again lights blazing. I would say this pattern repeated perhaps 5-6 times. The last time we huddled is the last moment of clarity I have. We were at the base of a fairly steep incline on the trail. Along the river this was an area we called the bluffs as there are a series of steep cliffs here. We cut off ourlights again in response to the same noises. We had not huddled for more than 30 seconds when the air was filled with the most horrific scream I have ever heard in my life. The intensity was such that it echoed far down the river and I would have to say for several miles. Without hesitation I ran. I know they did too as I could hear Robert and Paul behind me. We did not stop and did not turn off our lights till we reached the house. Fully out of breath  we all three collapsed in the living room. We were all in disbelief unsure as to what had just happened. I heard my dog begin to bark and assumed that she was barking at us returning home. She was kept in a fenced in area out back. Paul took a light and shone it into the yard and quickly noted that she was barking into the woods. When he closed the back door  we heard the scream again. It had followed us for the most part but remained in the woods. Having enough  we left. I spent the night at their house not eager to remain home. There are several other things I would like to report that have only now dawned on me that relate to this experience and this topic. Also  I would love the chance to have someone with knowledge accompany me to the area as I do not think this was an isolated encounter. (Added some of these notes below)", "Report 11682: Young men have frightening vocalization incident near Stones River.", "TN", "Bigfoot" },
                    { new Guid("a3f9feaf-b8ad-44ab-823e-c6e2f456d2c3"), "Lowndesville", "\"Ridge Church is an old  abandoned church that was used by Satanists for a short time after it closed.  All together  it has four graveyards and a mass gravesite  most likely containing the remains of the many victims of a fire that happened in Lowndesville years ago.  People have reported seeing orbs floating over graves in broad daylight and at night  hearing sermons going on inside the church itself  hearing footsteps inside the church coming from above their heads as though someone is walking around in the bell tower  and even seeing dark figures inside the church moving around.  Many people refuse to enter the church due to a negative feeling they get upon stepping up the stairs and opening the door  as though something is \"\"wrong\"\" with the building.  The inside of the church itself tends to feel freezing cold even during the summer time.\"", "Ridge Church", "SC", "Ghost" },
                    { new Guid("a3ff53f9-7fe1-4c6f-9c2f-3c8b13db1ae4"), "Take Hwy 14A west out of Sturgis", "\"I travel  every year on vacation  to South Dakota to do some camping in the Black Hills and have for the past three years camped in the same location. I belong to a club of outdoor enthusiasts  we travel to certain locations to scratch a living from the earth for a few days and once you have the fever there's no such thing as a nonworking vacation. This last trip (June 2008) I had an experience I couldn't explain: I was asleep in my tent; I was the only person left in camp everyone else had packed up and left. I wasn't too concerned as I have camped by myself in this area several times and could only recall one other time when I felt like something was nearby perhaps a cougar or other predator type animal as the crickets stopped chirping and the whole area became extremely quiet. This particular night I was sleeping soundly and was then suddenly awake and aware that something was up  everthing was silent. I didn't know what had woken me at first but I reached over and checked my watch seeing that it was 3:11am I thought to myself I need to get back to sleep  then I heard it; someone or something was moving around in the stream below my camp. Not directly below  but more to the north and west of my camp following the curvature of the stream. Picture a curving \"\"L\"\" shape. Now rotate the \"\"L\"\" 1/4 turn to the right  apply that to moving stream water  my camp sits above the water 20 to 30 feet in the inside turn of the \"\"L\"\". I heard splashing in the stream and then  SMACK....SMACK. There was a pause of a few seconds then SMACK....SMACK....SMACK. It was two rocks being hit together in a pattern. Ok  creepy and not what I was expecting  I reached over and put a shell in the chamber of my weapon and checked the safety. I'll give it a few minutes and if nothing else happens I'll go back to sleep. Nothing else did happen except when the sun came up I packed up and left. The area around the stream is covered in rocks of every size and shape from small pebbles to boulders as big as cars and trucks. I didn't think to look for tracks. I was still the only one there and I didn't know what to think  except that if someone thought it was fun to show up at a secluded camp at that time of night to smack rocks together there must be something wrong with them and it's time to vacate the area.  A few months later I saw a program on primates and how they will knock rocks and sticks together to communicate I put two and two together and realized I may have had an encounter.\"", "Report 25415: Possible nighttime visit while camping in the Black Hills of South Dakota", "SD", "Bigfoot" },
                    { new Guid("a48bc3d5-9888-4c8e-b55d-3725e48b43c3"), "Described in context above.", "\"This is the second in a set of chronological reports that I am submitting regarding a series of encounters I had between 1970 and 1983 in Nevada  California  and Washington States. I grew up several miles Northwest of Reno  Nevada in the foothills of the Sierra's.  My father was a geologist who preferred sparsely populated areas  so we lived  camped  fished  gold panned  rockhounded  and hunted Indian and goldrush artifacts in some relatively remote places. This second encounter occured in August of 1972 in Lemmon Valley  Nevada.  Lemmon Valley is Northwest of Reno on US 395.  Though the area I am about to describe is now covered with housing developments  in 1972 there were only two developed areas in the valley.  Stead Air Force Base (deactivated in 1959)[N.B. below] was on the West side of the valley and the community of Lemmon Valley was on the East side.  The community of Lemmon Valley was  in reality  simply a strip of built up properties along Lemmon Valley road - just housing and few small businesses extending for about five miles toward the back of the valley and for a couple of hundred yards at most to either side of the road.  US 395 cut across the South and higher end of the valley at the base of Peavine Mountain's North slope.  Toward the back of the valley  the North or lower end  were a few small ranches.  Only a couple of improved dirt roads cut across the center of the valley connecting the community of Lemmon Valley to Stead. The climate was high desert.  Roughly 5000 feet in elevation with negligible year-round rainfall  but sometimes several feet of snow in the winter.  The humidity was generally less than ten percent and often as low as five.  Other than those planted near developed properties  there were no trees in the floor of the valley.  Scrub pine begins on the higher ridges about five miles West of the valley and thickens to fully developed arid pine forest as the elevation increases.  The dominant vegetation is sagebrush  mixed with a wide variety of large weeds and coarse grasses.  Jackrabbits  prairie dogs  and smaller rodents were very common  as were a wide variety of lizards and snakes.  Coyotes are common  but rarely seen.  Cougar and black bear are rare  but sometimes sighted in the area.  Deer stick to the surrounding higher elevations with more trees.  Other indigenous animals include hawks  falcons  and few burrowing owls.  Quail  and other ground nesting birds are also plentiful.  There is also a variety of large insect species (cicada  locusts  etc..) to round out the ecosystem.  At first glance  the area may not look like it supports much in the way of life  but it actually does.  Snow melt is the primary source of open water in the late spring and early summer and a small lake forms toward the back of the valley.  By late August this has usually dried up and the only sources of water are near human habitation. As I mentioned in my first report  the North face of Peavine Mountain was deforested in the late 1800's.  It has also eroded significantly over the last century as a natural result of the vegetation loss and due to hydraulic mining.  The runoff from the mountain was clearly heavy at some time in the past  because two deep washes cut through half the length of the valley flowing North from Peavine Mountain. These washes were eight to ten feet deep in places with vertical walls and averaged five to eight feet in width.  Walking down one was much like walking through a school hallway with slight curves.  Their depth would increase and decrease as they intersected the natural fingers and draws running down from the ridges that bounded the valley.  They were difficult to climb in and out of except at a few places where they shallowed out to a couple of feet as they intersected a draw.  Because they were shaded and contained a little more moisture than the surrounding terrain  they formed a small microclimate where certain species of lizard and an occassional scorpion could be found.  The sagebrush also grew a little taller (about three feet) along their edges.  Below  the floors of the washes were almost perfectly level  shaded  and protected from the wind.  Very little vegetation grew in the floors of the washes and was usually limited to tumbleweeds and some patches of coarse grass.  From the floor of the valley these washes were virtually invisible.  You could only tell where they were from a stripe of sagebrush running along their edges that was a little greener  thicker  and taller than the rest of the sagebrush in the valley.  You couldn't see them or see down into them until you were right on top of them. This encounter took place in the early afternoon in mid-August of 1972.  It was bright  sunny  and hot  about 85 degrees Fahrenheit  at the time.  The wind was less than five miles per hour.  I was twelve.  I was with my brother  who was ten  and a friend  David  who was also twelve.  For years  my brother and I had spent the summers exploring the surrounding hills and valley.  We knew all the best places to catch each type of lizard  the best places to look for arrowheads  where the trash dumps from the 1800's were (good for old bottles)  and the best places to find old shell casings and such from when the airbase had been active.  We didn't often make it out as far as the dry washes  but when we did we made a point of exploring them because of the unique things like scorpions you could find in them.  We had just moved from Stead to the Lemmon Valley side of the valley and David  a new neighbor  was with us for the first and  as it turned out  only time. We had decided to go all the way out to the closest wash to show it to David  and were angling toward one of the shallow points where it would be easier to get into.  As we walked along we were searching the ground for horned toads  arrowheads  and anything else that might be interesting.  We were about twenty feet from the wash when we stumbled across an area with jasper and obsidian chips on the ground and started looking around in earnest for arrowheads and other stone tools.  My brother and I were seriously competitve when it came to hunting arrowheads. I was facing North  focusing on a piece of jasper I had just found  and had my back to my brother and David when I got a sudden feeling something was wrong.  I don't know whether I heard one of them gasp or just go abruptly quiet  but I knew there was a problem.  I had a sense of where my brother was a few feet behind me and turned to look at him.  As I turned clockwise from North to South I saw first David  about twenty-five feet away from me and a couple of feet from the rim of the wash  then what I perceived to be a giant black man about eight feet from David and about three feet away from the wash  and finally my brother  who was only about five feet behind me.  The giant black man was about thirty-five feet from me  standing still facing me with his arms at his sides looking directly at me (I guess he must have figured I was the lead male).  David was in shock  rooted to the ground  staring directly at him with his mouth wide open and his lower jaw level with his collarbones.  My brother was poised to run and looking from the \"\"man\"\"  to me  and then to David in a panic.  As soon as I saw the man I took a step to run also  but realized David wasn't going anywhere and we'd need to help him if the \"\"man\"\" tried to do anything (we weren't that far from Reno and there are a lot of weird people who drift through that town - a man out of place in the desert is immediately considered dangerous).  I settled my weight and looked the \"\"man\"\" in the eye waiting for him to indicate his intentions. This all took about a second.  At this point my brother turned to me and screamed  \"\"That's not a man!  That's not a man!\"\"  Not breaking eye contact with the \"\"man\"\" I snapped back at him  \"\"Yes it is!\"\"  My brother immediately yelled \"\"No  it's not!\"\" and I snapped right back \"\"Then what is it?\"\"  which shut him up.  At that moment  in that situation  it was critically important to me that the \"\"man\"\" be nothing more than a man.  I also knew my brother and I could probably get away  but David was at risk and I intuitively sensed that it was important to control the fear  both by keeping the \"\"man\"\" just a man and by calming my brother. As I focused on the \"\"man\"\" I recognized that he was not overtly threatening but seemed stern and annoyed.  He didn't move a muscle and he didn't make a sound.  From his manner I gathered that he was not threatening us  but was determining if we were a threat to him - that we had disturbed him and he just wanted us to go away and leave him alone.  My brother and I would have been happy to oblige but David was still standing like a statue and we weren't leaving him behind so we all just stood there and stared at each other. I could see the \"\"man\"\" from the lower shins on up  and this is where it gets a little strange.  He was at least eight and a half feet tall  three and a half feet to four feet broad at the shoulder  and had a comparatively narrow waist.  His arms hung down to the top of his knees.  Not only was this \"\"man\"\" huge and slightly disproportionate  but in the middle of the afternoon  in the middle of August  to my perception  he was wearing a black down ski parka with the peaked hood up  matching black down ski pants  and black gloves.  Down ski-wear was a brand new fad with the skiers that came through Reno back then.  I thought to myself that it was strange that he had this brand new ski outfit  let alone one that fit his frame.  I thought he must have stolen it (I had already subconsciously assumed this guy was a hobo because we were at least a mile from the nearest road  there wasn't a vehicle in sight  and I couldn't think of a good reason for him to have apparently been hiding in the wash).  As I thought about it  the hobo assumption made sense.  The ski-suit was probably the only thing he had to wear and  at night  sleeping out in the open in the high desert it tended to get a little chilly  August or not.  There was even a little dirt on it in places  indicating he'd been lying on the ground in it. The \"\"man's\"\" bearing  though  didn't come across the way a homeless person's would.  He stood tall with his shoulders relaxed  but back.  His posture indicated a sense of self-worth that was almost regal and his gaze didn't flinch (as an afterthought  there was nothing about his eyes to give me the impression that he lacked human intelligence).  Even under the ski suit you could tell that he had a massively muscled upper body  and the ratio of shoulders to waist were those of a world-class athlete.  For a moment I considered that I was looking at fur-covered muscle and immediately killed the thought  then started to look a little closer anyway.  This was when he simply broke eye contact  turned  stepped down into the wash at the shallow point where he was standing and walked away down the wash without looking back (this was a little strange in retrospect because there was absolutely no indication in body language or eye movement to telegraph that he had decided our encounter was over - he simply turned and left without acknowledgement).  Within a couple of steps he disappeared around a slight curve in the wall of the wash as it cut through the next finger off of the ridge.  We had stood looking at each other for maybe forty-five seconds. I didn't move for a couple of seconds after he disappeared  waiting to give him time to go before moving to check on David.  I'd never seen anybody so afraid that they were frozen on the spot before and I was concerned about him.  As I walked up to David  looking cautiously down the wash as I got a better angle on it  my brother followed me and said in a voice that seemed to beg me to believe him  \"\"That wasn't a man.\"\"  Standing in front of David  I looked him in the eye and said  \"\"Yes it was.  It was just a big  black hobo.\"\"  That ended the discussion.  I asked David if he was ok.  He just shook his head yes and didn't say anything.  My brother moved up to the edge of the wash to see as far down it as he could and I asked if he could see the guy.  He couldn't and we started to leave when curiosity got the better of us and my brother asked  \"\"What do you think he was doing down there?\"\"  I thought about it for a second and decided I wanted to know  too  so we walked along the edge of the wash for a hundred yards or so to make sure he wasn't hiding close enough to threaten us (the guy wasn't carrying anything and I was worried that we would find his camp about the time he came back to it to get his belongings).  We walked back down to the shallow spot in the wash and jumped down into it.  I briefly recognized that the \"\"man\"\" had simply stepped down the three feet I had just jumped  but didn't say anything. We walked both up and down the wash a hundred feet or so looking for a campsite.  We didn't find one.  No firepit  no food wrappers  no trash  no drug paraphenalia  no signs that a human had been camping there.  The floor of the wash was granite sand so there really weren't any footprints that I could recognize to indicate where he may have been.  We did find a spot where someone had taken pieces of tumbleweed and sticker bush and embedded them in the wall of the wash.  Tumbleweed and pieces of bush were also arranged on the floor of the wash at the same spot.  Those embedded in the wall of the wash were arranged in a tall half-oval with the peak about four and a half feet high.  Those on the floor of the wash were also arranged in a half oval that joined the first.  It was about the right size for the guy to sit cross-legged in with his back against the wall of the wash. At that time I had never heard of Bigfoot  so it wasn't even an option for me to consider within the framework of the encounter.  Even though several things about the encounter were strange I convinced myself that we had been confronted by a man.  What else could it have been?  About ten days later  though  something happened that forced me to admit that there was something in the valley that was manlike but wasn't a man.  I'll submit that as my third report soon.\"", "Report 5697: Three boys encounter sasquatch in eroded terrain", "NV", "Bigfoot" },
                    { new Guid("a49a2881-45e9-4bcf-8c44-9cacd7306994"), "Great swamp area  Narragansett Indians", "\"While attending U.R.I in the Fall of 1974 I would stay at my girlfriends mother's house on weekends because I only had a five day mealbook plan. It was Sunday evening about 10:00pm when I decided to head back to school on my ten speed bike. Very dark in the area because it being mostly wooded  country like setting but yet city. I was going down her street and noticed my front center pull brake needed to be adjusted. I stopped under a street light at the end of her street which is an intersection to adjust the brake. Directly in front of me was a small field that sloped down and away from me pitch black background  tall grass and a few bushes being light by the street light. Typical New England  Oak  Maple and  Pine trees. As I was fixing my brake I began hearing very loud foot steps of a biped  comig from the field on the slope side more like a crushing thud. I could hear the actual compression being placed  like someone dropping a heavy metal ball/rock on the ground.I looked up to see if I could see anything and just said to myself \"\"its nothing\"\"  and went back to fixing my brake. I noticed it was getting closer and felt very apprehensive  the sound was coming in my direction. All of sudden this dog starts barking like crazy  I can hear the chain snap as it either tries to attack or getaway from something. I said to myself \"\"its time to go!\"\"  as I started I turned left to head north  into a few pedals. From out of the darkness steps into the street light this white looking gorilla. The legs present themselves then the body as it comes to rest on its knuckles. Twenty maybe twenty five feet away  directly across the street from me perhads six feet tall maybe 400 pounds or more. Massive arms that went straight down on its knuckles  knees slight bent.The head is higher in the back connected to the neck all-in-one mass. The face dark  deep strong  but primate.The eyes are close together and set deep in the face. The nose and mouth are human like  it's nose is wide  around the mouth black hair that went down on each side.It looks up with its head and chest see me  eyeball to eyeball as I look back trying to see if this thing is real. Humanlike in appearance  the face is not like a primate but has a distinct animal presence (the eye are close together). I was never so scared in my life and knew had I stayed I don't think I would of survived the attack.The way it was positioned gave it an explosive start as it decides to chase me down the street. My heart was pounding out of my chest  my eyes had tears in them and with all my might I pedaled as it ran on two legs  then down on its knuckles then back up again. Perhaps for ten yards  I remember how its long hair on its arms moved with each reach I thank god I was in first gear. A good five second chase and it was all over.It had stopped in the middle of the street just swaying back and forth  turned and just cleared this rock wall all in one motion from a grass sidewalk. At the top of hill I began riding in circles  I didn't know what to do  I could not comprehend the situation I was in. I knew one thing I was not riding back. I cut through her grandmother's yards and made it back to her house. Not trying to look crazy or anything they ask me what's wrong ? I told them what happened and agreed  that it was best to go back in the morning.\"", "Report 6496: Bicycling student has night encounter", "RI", "Bigfoot" },
                    { new Guid("a4d86f10-4e02-41a7-b205-01d116b84083"), "Route 6 East going from CT into RI", "I was driving along Route 6 crossing the CT state line into RI.  The road is very dark and heavily wooded in this particular area.  As I was traveling east  something quickly moved across the road in front of me.  I was driving approximately 55 mph.  Once I registered what I was seeing I also realized that whatever it was  it had walked on two legs.  It cleared the guardrail on the side of the road in one step and was gone.  I was very spooked.  The whole incident lasted less than 30 seconds  though I think about it often.  especially when I drive through that area.", "Report 30906: Early morning sighting by a motorist along Route 6 near Foster", "RI", "Bigfoot" },
                    { new Guid("a5b7eee5-ec1e-4497-9b13-45bb2ea03215"), "My family would camp at the intersection one quarter section East of 18 and one quarter section North of Pond Rd.  The sighting occurred on a dirt road  one quarter section North of our camp.", "While attending a family hunting trip  several of us were walking on a two track north of our camp.  We were almost a quarter mile from camp  climbing a steep portion of the road. Suddenly  the four of us stopped dead in our tracks.  At the top of the two track  a large  dark figure stood in the middle of the road staring at us. The thing was quite tall  and very broad across the chest.  The arms were longer than a man  and it seemed frozen as it looked at us.  I could not make out any features  but am certain that it was not a person.  It looked more like one of the drawings or statues I have seen on the net or in books. After what seemed like forever (it was probably only a minute or so) we turned and ran back to camp.  I am not sure what the thing at the top of the hill did  but we didn't stick around. Several years later  a few of us discussed this sighting  and those who aren't necessarily believers in Bigfoot had no explaination as to  what we saw. We ", "Report 25298: Man recalls a sasquatch watching he and a group of teenagers taking a walk while camping near Houghton Lake", "MI", "Bigfoot" },
                    { new Guid("a5ea361d-6745-49e0-ac09-d2a8f968b4dd"), "Houston", "Went outside looked up there was a huge space craft floating in the air took off right away. All I seen after was a streak of light", "Diamond", "TX", "Alien" },
                    { new Guid("a67a5379-8baa-459a-8e77-ae69193d32f7"), "You need to get on Vermont Route 7A and the turn-off for the park is labeled. I am not sure of exact directions before then but if you reach the Equinox Hotel you have gone too far.", "I am a Civil War re-enactor and I was participating in an event on the grounds of Hildene Mansion  which is Robert Todd Lincoln's home near Manchester  Vermont.  We were camped on the front lawn of the mansion  which is bordered on two sides by woods.  The whole area is somewhat off the beaten path  the house is probably a half mile from the main road. In the middle of Friday night  I would guess around 1-2 a.m.  I woke up and was walking to the building beside the main house to use the rest room  and as I left my tent and was walking toward the restroom I heard footsteps walking near me in the woods.  They seemed to follow me as I went to the rest room and as I walked back from the rest room they walked back with me to my tent. The whole time walking back I had an uneasy feeling like I was being watched. The next night  Saturday  I was sitting around the campfire around 11:00 pm talking and we heard footsteps coming from the woods which we were right next to  but the noises were coming from inside the woods.  We shined a flashlight on the area that the noise was coming from and it stopped immediatly and as we turned the flashlight off we heard the noises again heading away from us. Both times that I heard the noise it sounded like a large animal and from what I could hear it sounded like a large animal walking on two feet.  While there were other groups at the event I don't think that it was another person as there were trails that were clear that they could have used. Also of course it was so late at night and there was no light from a lantern or a flashlight.", "Report 13345: Possible stalking at Hildene Mansion grounds  near Manchester", "VT", "Bigfoot" },
                    { new Guid("a759fe97-819a-4aee-a353-d0d504f9b09a"), "St. Cloud", "Legend says that the skating rink was built over an old pond where a boy had drown. Lots of unusual things happening in the building have been reported.", "Skatin' Place", "MN", "Ghost" },
                    { new Guid("a7e8d6ca-9712-4f80-99b0-7a51a66c1c3d"), "Close to Claremont down 120 not far from Kingston road.", "I was on my way to Claremont from Lebanon on Rte 120 and was passing by some reeds in a marshy area next to the road that sounded like a huge flock of birds. The creature came out of the reeds and was crouched down looking at me through them. Surprisingly it got out of the reeds from crouched to standing turned around and ran towards the wooded area up a hill and was moving with it's arms brush and tree branches out of the way. It was incredibly fast runner and I got a good look at its coconut shaped head as it ran away. It was light brown/brown. It had incredibly broad shoulders. I went back the same day. The marsh went up to my knees and I could smell a bad odor like garbage. Myself and a friend went back to the sighting. We found a footprint and a hair sample. I could hear wood knocks when my friend James did a call and we also found a large bed of branches and some tree structures. The following month I went back to Claremont and I heard screeching in the woods while I was traveling Rte. 120 on a bicycle.", "Report 55269: Dawn sighting at Stevens Brook outside Claremont", "NH", "Bigfoot" },
                    { new Guid("a81d4289-4a89-4515-8205-e6261209d806"), "Newport", "Hovering object  possibly disc-shaped  with many red  yellow  blue and green lights that were in constant motion", "Unknown Shape", "WA", "Alien" },
                    { new Guid("a8475b1d-4800-4c46-af02-c26016c988a0"), "Grants", "No one is allowed on the third floor  it now is used as a storage. From the swimming pool  you can see people looking down at you. You can hear footsteps  screaming  and the elevators going up there. The elevators don't even work. Someone appears in the Kitchen. You feel a coldness upon you. December 2003 addition: They say it’s just a fake. People are forgetting about it. No newspaper can be found  it like the town has covered it up. Some locals say they know there’s something there. They heard a Maid was murdered there  she was taking some towels up to a man and when she got to his room he grabbed her and murder her in his room on the third floor. The police tape is still on the left wing of the third floor. People say that if you go to the room that it happen in that you can still smell blood and that the room is very cold. If you go at just the strike of midnight you can hear her screams and moans. All the rooms that don't have numbers on the door are said that something happed in those rooms. The hotel it filled with evil and people say that if you sleep on the second floor of the under the room that it happened in that you can hear here yelling and cry for help!", "Econo Lodge", "NM", "Ghost" },
                    { new Guid("a9188bac-5fb1-4409-a689-a1dec8360fa1"), "Williston", "Mannequins move on their own. Whispering is heard  but no body knows what it's saying. In the basement there used to be and old staircase  but it got sealed up and some people have said they have seen an old soldier standing there guarding it.", "The Old Armory", "ND", "Ghost" },
                    { new Guid("a9ddc003-5406-4f8b-97e6-248cd8366be0"), "Ridgefield", "This house was built along time ago back when are small town was just starting off. A family had just moved in the place and everything was calm for a little bit. After a few months weird noises could be heard followed shortly by an apparition that looked like an older women. Things would be moved around at night making feel like you were never alone. The legend says that an older women died in the house so maybe that is who still walk's the place.", "Barn House", "WA", "Ghost" },
                    { new Guid("a9f13ccd-425b-4936-a50e-5e1ce818f8a5"), "We were camping in the National forest at lake Jeanette. camp site number ten. It is right on the lake.", "We were camping  North of Orr MN at Lake Jeanette. Around four in the morning I heard heavy large foot steps coming toward our tent. It was definately on two feet I was wide awake and have no doubt about that. I yelled  Who's there? and it threw a rock at our tent  then walked very fast away. once again with huge heavy foot steps. I tried to recreate the sound of the steps in the morning but was unable to sound that loud. Still wondering what it was.", "Report 35281: Unknown nighttime visitor at a campsite on Lake Jeannette", "MN", "Bigfoot" },
                    { new Guid("aa29fdfa-7270-42fd-ae13-8afeae1ba8de"), "Newark", "Formerly listed as Station 3 - There are 2 ghosts that haunt the firehouse. There is one in the engineer's room that is evil and appears as a shadow in the door way and you can see him in the hallway going to the engineer's room. You can also hear voices late at night if you are by yourself. But there is another ghost and he is the protector of the station. He is very good and he rarely shows himself; and he keeps the evil presence in the hallway of the engineer's room. If you go to the firehouse you can literally feel the struggle going on.", "Christiana Fire Co. Station 12", "DE", "Ghost" },
                    { new Guid("aa5e55a0-fcc8-4727-a480-0dfd8d3f4dc7"), "Rawlins", "I was sitting in my hot tub looking at the sky when I noticed this triangular shaped object in the sky. It was so weird. I watched it c", "Triangle", "WY", "Alien" },
                    { new Guid("aaaab57a-1efa-4834-bc17-258e06ec107f"), "Mount Greylock State Reservation  Cheshire Harbor Trail off West Mountain Rd  Adams  MA  heading southeast toward base of trail. Adams  MA.", "\"My wife and I started to make our descent from the summit of Mount Greylock during a morning hike.  Approximately half a mile on the Cheshire Harbor Trail  close to Rockwell Rd  my wife and I heard a clapping sound.  We stood in place for a few moments  listening to the sound.  The \"\"clapping\"\" was non-rhythmic  sometimes there was one or two  other times there were many \"\"claps\"\".  In between the \"\"claps\"\" there was sounds of something walking  breaking fallen branches as it moved.  The sounds were about a distance of 100 feet from our position on the trail  within a thicker patch of woods.  We listened for almost a full minute and then decided to continue on the trail  moving closer to the source of the sound.  When we reached the area where we believed the clapping sound to be coming from we listened again and heard nothing and had seen no movement.  Further down the trail I attempted figure out the sound.  I did some tree knocking and banged rocks together  but only when I clapped my hands did it most closely match the sound my wife and I had heard.  It was a sound that I have never heard before and it has sparked my interest into figuring out what animal made this noise.\"", "Report 51847: Hikers have possible daytime encounter on state's highest peak  Mount Greylock", "MA", "Bigfoot" },
                    { new Guid("aabb48b5-5487-43fc-a34e-c0c561bd20de"), "Idaho Falls", "Saw two triangular objects in near proximity of each other with circular white lights near the points of each of the objects. I soon r", "Triangle", "ID", "Alien" },
                    { new Guid("ab233b5d-0175-4f78-81d8-16c8ef8e839f"), "Ogallala", "Boot hill is a cemetery for old cowboys. Many people have seen the ghost of pioneers  and cowboys roaming around the grave stones at night.", "Boot Hill", "NE", "Ghost" },
                    { new Guid("ab4c2611-d226-4a0b-84af-bdf0cbe11518"), "Dalton", "A bright yellow object traveling from west to east  ending in a bright flash", "Circle", "GA", "Alien" },
                    { new Guid("ab8c5d00-264b-4834-9088-ba7f4d6d3719"), "Oxford", "reports from Wal-Mart employees that their keys disappear to reappear again later in the same spot. Electric doors stick and won't shut. Computer's have weird drawings on the screen in the morning like a child has been drawing. - January 2007 Update: The store is now all closed up  due to a brand new Wal-Mart super center being built down the road.", "Wal-Mart Store", "OH", "Ghost" },
                    { new Guid("abb0dc63-62b8-4099-93c2-5e11e0cbb08c"), "Kotzebue", "\"During the spring season there is a giant puddle under the museum from all the melted snow. A young boy named Alex was playing with a basketball near the museum. His ball went under the building. When he tried to get the ball  he slipped under the building and couldn't get out. He drowned in the water. People say if you bring a basketball into the auditorium  leave it on the floor and say  \"\"Alex  come get your ball!\"\" you will hear the ball start bouncing.\"", "NANA Museum", "AK", "Ghost" },
                    { new Guid("abb172c9-2a20-44e9-af63-bc1099e22411"), "Colchester", "\"There are a couple of places on campus that seem to have ghostly visitors. 1) The theater supposedly is haunted by a nun who assists actors. There have also been incidents reported during performances of props disappearing with no explanation. 2) The men's' first year dormitory also an evil presence. in the 60s or 70s  young men were holding some sort of occult meetings One of the men insisted that he needed to close the \"\"portal\"\" before they left  but by that time security was there and they tossed them off campus. the door to the attic is padlocked shut. However  lights go on in the attic and footsteps are heard in the middle of the night by the residents on the top floor. The image of the pentagram still exists on the floor despite attempts to replace the wood.\"", "St. Michael's College", "VT", "Ghost" },
                    { new Guid("ac3d2047-1aa8-4e4b-9694-64ed6392a5d0"), "The camping area was called the Lazy L&L and the name of the road is called River rd. The Guadalupe River area.", "While on a camping trip in a camping resort  my wife and I went for a walk in the woods. It got dark fast and all I had was a small flashlight. I don't know how but we ended up by the main road called River Rd  leading to the campsite. we could just make out the small light of the main office. That road is dark and there were no cars that night for some reason. Well  we were walking along the side of the road where the tree line was by the Guadalupe River. When we started hearing footfalls behind us  very heavy footfalls. The only thing  they were coming from the other side of the road where the sheer rock cliff is  intermingled with a thin tree line. They were not pranksters like someone already suggested to me. The air that night was weeping (meaning humid). Suddenly we stopped and what ever it was stopped too  but when it stopped it must have stepped on a branch because we heard the branch break. Well needless to say we ran the hell out of there all the way back to the camp. My wife was so frightened we had to leave the secound it got light.", "Report 1431: Campers hear foot steps in tree line while walking on road", "TX", "Bigfoot" },
                    { new Guid("ac40f778-6430-4311-af88-459fa29ab9cf"), "Lebanon", "This cottage was once an old school house. Late at night (12:00 to 1:00) you can hear children screaming and running in and out of the rooms. When these children run in the moonlight they become visible to the human eye.", "Old Cottage", "ME", "Ghost" },
                    { new Guid("ac6f2a64-a4c8-4687-a321-877a35f4ff96"), "Hancock", "Peyton's Place - A man supposedly went crazy on his family and killed them all with a pitch fork. if you walk back into the woods into their private cemetery  a young man's voice will call at you to run and leave. also  a black '62 mustang will chase you when you leave and then vanishes from your rearview mirror.", "Warsaw", "IL", "Ghost" },
                    { new Guid("ad0307d2-3d32-43ac-9107-d3c67ece955f"), "", "\"On July 3rd  2016  at around 7AM I was fishing at Norwich Pond in Lyme  CT.  I caught my first fish within minutes of arriving.  When I brought the fish to shore I heard 3 distinct knocks coming from behind and above me. There is a rather steep  high (30 ft?) slope along the access road near the boat ramp. I turned around thinking it was people walking down the road.  Nothing there...  I threw the fish back and recast.  I caught another within a few minutes.  As i brought this one to shore  I heard another 3 distinct knocks from the same spot and again turned around to see if someone was there.  No one! This boat launch/pond is about 4 - 5 miles in from the main road and the only houses around were on the other side of the pond  the opposite direction of the knocks.  I am pretty sure it was an encounter with Sasquatch even though I did not see or smell one.  The knocking was too \"\"human\"\" to be an animal and there were NO people around.\"", "Report 55169: Couple hear possible knocks while fishing one morning near Lyme", "CT", "Bigfoot" },
                    { new Guid("ad769f3b-c021-4c80-862b-8eb22d94fef4"), "From Sundance Wyoming east on I-90 take Moskie Road county 207 to Grand Canyon Road  north to Williams Gulch Road.", "It was the second day of deer season and I was going to try my luck in the Black Hills. It's the last chance hunt in this part of Wyoming for deer. There was a good snow a few days before. I had an old 64 Ford van and I put a shanty heater in it though the roof vent. I drove down Grand Canyon Road to Williams Gulch. I had to shovel out an area to park the van. I didn't go up the Williams road because the van was only two wheel drive and didn't want to get stuck in the snow. I parked where Grand Canyon and Williams Gulch road met. I got fire wood that day and hunted up the ridges. I had my dog with me and got ready to spend the night. I ate something and sat in the van enjoying the wood heat. The wood stove was doing its job all to well and had to open a side window on the van. Soon after I heard a strange screaming noise outside. I still had my boots on so I went out the back doors of the van to hear it again. I grew up in upper Michigan and been in the woods all my life camping hunting etc. This was something I never heard before. It sounded like a WHOAAAAAAAAAAAA that lasted for about 20 seconds. If you hear something that long it sounds like it last forever. It seemed to be some ways away and when it stopped you could hear echo off the ridges. What had me frightened was the volume of it. Whatever made it had on hell of a lung capacity. Afterwards my dog would not come out of the van. It screamed about four or five times. that night I just laid there on the cot wondering what the hell it was. The next day I didn't see one deer and that in its self is strange for the Black Hills. I don't know what I heard and I'm the type of person that only believes what I see bigfoot ufo etc. There is nothing in North America that I know of that makes a sound like that. To me it's an unexplained scream but it's been bugging me for years.", "Report 13033: Local hunter hears multiple screams after dark outside Sundance", "WY", "Bigfoot" },
                    { new Guid("ad7a95d0-1a68-4968-84cf-a93e833cc820"), "Colchester", "Vishnu is an old abandoned township located just west of Colchester. There are feelings of being watched  viewed shadow like beings in darkened corners. The old hotel is haunted. Pictures taken reveal orbs and a fog/mist that were not visible to the naked eye. Also a corner was very cold  much colder than the outside temperature.", "Vishnu Springs", "IL", "Ghost" },
                    { new Guid("ad9c15db-752e-4593-bfe3-9345db5e00dc"), "Grahm's Forge", "\"Owned by a slave owner  he tortured and killed many of his slaves. He burned down a slave house with over 100 men  women  and children inside. Coming close to the house  you get the sensation of pain and anger. Lights turn on and off  even though there are no electrical cables. Curtains move. You can here someone going up and down the stairs. Bloody handprints sometimes stain the basement  which is where cages are and where slaves were kept and tortured. There is a guillotine there also. If you stay too long  you will start to here voices  screaming  babies crying  and lots of yelling. Be careful. Many who enter this house say they always bring out something with them. If you drive by the place late at night  there are lights on  and there is no electricity to the house  and a figure that walks by the attic window  and the gates are rusted shut  and there are no cars. There is one specific light that shines at you  then the light turns into two lights  then three  then one again  and then all of a sudden the lights go out  and then back on again. - September Correction: formerly listed as being in Foster Falls. There is electricity run to the house. There are \"\"No Trespassing\"\" signs on every other tree. - November 2005 Correction: Graham was a slaveholder  but he never tortured or murdered over 100 slaves. That would have indeed brought the authorities  even in the South. 100 slaves would represent a vast fortune. A local slave owner named McGavock never mentioned the stories formerly submitted in his extensive diaries and they were close neighbors and friends. The house is indeed supposed to be haunted.\"", "Major Grahm's Mansion", "VA", "Ghost" },
                    { new Guid("ae3683f4-fe6d-4210-8263-7cfc945d1b3d"), "Dunseith", "a camp once used as a reform ranch for boys  there are reports of hearing laughter in the trees where a boy hung himself after he and 4 other campers murdered the councilors/owners of the camp. there is also a feeling of being watched or chased thought the trees.", "Camp Mondak", "ND", "Ghost" },
                    { new Guid("ae5f4885-70a3-4153-b720-3cb0ff43f719"), "Clymer", "\"Jaquin's Pond is a swamp with a few narrow dirt roads through the woods. There are several stories about this spooky area. There are three bridges supposedly haunted by the ghost of a school bus driver named George  who committed suicide after a boy was killed in an accident involving his bus; if you stop on the third bridge and say his name three times  your car doors will lock and he will appear (there are several variations). The road also forks  diverging into the \"\"Light Path\"\" and the \"\"Dark Path\"\". Apparently the Dark Path has been the site of more than one teenage suicide. Also surrounding the area are several old stone buildings which may possibily have been used to be some kind of waterworks  now abandoned.\"", "Jaquin's Pond", "NY", "Ghost" },
                    { new Guid("aea5a7e8-7c95-4316-aff2-837c7e2e80cd"), "Rusk", "Ladysmith high school - Sometimes kids say they are followed into the school by ghosts in the morning and sometimes at sporting events Ghosts have been reported being seen in the locker rooms during a game.", "Ladysmith", "WI", "Ghost" },
                    { new Guid("aec7fff1-6895-43b5-a8e0-fa7d1a99be5d"), "montain road wall to wall plenty of tall ever green pine", "We were on our way back from Las Vegas NV going around 89A over the mountian road of Jacob Lake and the North rim of the Grand Canyon. My aunt thought it would be fun to play in the snow so we pulled over  we were in a type of gorge where the road cuts threw the mountians as were playing i thought i could hear someone yelling it was loud because i heard this sound over my cousins snow fight. i guess my aunt heard the same thing because she had a weird look on her face and as we were ready to leave the area we all heard the second howl this time it was loud and clear and deep. so we high tail it out of there my aunt did not want to know what made that noise. i compared this howl to the ohio howl on your website they are exaclly the same. i believe the howl i heard was not from the local wildlife.", "Report 15178: Two part report of possible vocalizations  footprints and a nest  near Jacob Lake", "AZ", "Bigfoot" },
                    { new Guid("af32b4d7-be3e-49ae-8063-47743b3cdae9"), "Honolulu", "\"\"\"Fireballs\"\" of light pop up behind boulders and a silhouette of a boy hanging from a tree by his neck. - August 2004 update: reballs  it's hard to say if those pictures are actually fireballs  or a leak in the camera  altered digitally  or even just faulty processing. As for the Morgan’s corner story  this is an urban legend. Here's a local newspaper article mentioning that this is just an urband legend. The URL is: http://starbulletin.com/2000/10/12/features/story1.html But  the fireballs is actually a legend  there's numerous accounts of people seeing the fireballs  but like all ghost stories  none of it is a first person account. It's one of the Night Marchers  another Hawaiian Legend)\"", "Morgan's Corner", "HI", "Ghost" },
                    { new Guid("af5a889a-eda8-498d-9405-56dc012e6b9e"), "Garden City", "In the small town of Garden City across from Stevens park. There are some very old apartments. Which were closed for disclosed reasons. Some believe a boy had a jealous uncle. Who was jealous of his brother because he stole his girlfriend and told their boy he was going to kill his older brother and his ex-girlfriend. And the boy tried to tell the police but they wouldn’t listen and later he went up to the apartments and found his parents dead. And since no one would listen he broke out some of the stairs so he would be safe from his uncle and u can still see him looking out the window for his uncle. No one knows what happened to the boy.", "Main Street's Brocken Home", "KS", "Ghost" },
                    { new Guid("afdbcde9-62cb-4ac8-b9df-da4c18156ec2"), "Kenai", "There are several spirits here. One is an older  heavyset woman who goes by the name Marie. There is also an older gentleman by the name of Arthur Johnson. He has been spotted maintaining his gravesite  plus the graves of others who are buried there. In the back part of the cemetery are several unmarked graves that contain the remains of servants brought up here to help dig for gold. But when the gold ran dry  it was too expensive to feed them  so they were killed and buried in graves outside the main cemetery.", "Kenai Cemetery", "AK", "Ghost" },
                    { new Guid("b06f7ea9-570e-4e88-8e7b-9750b59ee742"), "Charleston", "On the bank of the Kanawaha River  at the train depot  just at the bottom of the exclusive South Hills mountain drive  the Charleston Train Depot rivals any 19th century European Town Center. At the depot  flanked by the river on one side and a winding suburban mountain road also exists a carriage trail which led  in days gone by  to the Governors Mansion. The depot has a restaurant and a scenic view. The old carriage trail is barely noticeable from the train platform  but driving up the hill on the right side of the forked road motorists can see a clear wide carriage road leading to what is now Sunrise Museum. Vagrants and homeless people are said to spend some nights near the bottom of the trail waiting for a train to hop  and high school students sometimes wander the trail at the top of the trail behind the museum. No one ventures past the desecrated statue of a Our Lady. A dark spot exists in summer and winter at the second curve from the top of the trail (or the third from the bottom). West Virginia was fiercely abolitionist during the Civil War and the state seceded from Virginia because the mountain men and their Indian Wives did not believe in slavery. The Underground Railroad ran through the exclusive South", "Charleston Train Depot and Carriage Trail", "WV", "Ghost" },
                    { new Guid("b08cfe17-416f-470b-9c5e-c53b0f6ff9e7"), "US Army Signal School-Fort Gordon-Small Arms Impact Area.  This was in a ravine where a spring fed rill forms the headwaters of South Prong Creek. It is the center branch of three which form the creek.", "\"While preparing to check inside the brush that ringed the stream inlet area  a large man/ape creature 10' to 10'6\"\" tall (estimated weight 1100 lbs.) approached me with an unhurried pace at a distance of approximently 20 feet. The body except for the Face and Palms of the hands were covered with  neat short (one inch)dark brown to black hair flecked with gray hair.  The attitude was not especially threatening. It was more like a positive defensive move.The face was rather like a Gorilla(Dark skin and Dark deep set eyes  the head sloped back and was neanerthal shaped  had no eyebrows prominent lips but not protruding  jutting square chin  no ears or teeth were seen prominent nostrils slight nose (not flat like a gorilla) and an aged look to the face. The body was all big boned muscle  no body fat and had thick arms and legs. It made no vocal sounds and I did not notice any odor. I backed out of the ring of brush and walked quicky back to my truck. It did not pursue me!\"", "Report 2218: Man approached at close range by man/ape creature at Fort Gordon  US Army Signal School", "GA", "Bigfoot" },
                    { new Guid("b09311e0-fc33-4f2b-bfa3-e275ccd32c2c"), "Seymour", "haunted by a woman who used to live there. It was a mansion converted into a restaurant in the mid 60's. Now the story is  that she lived there with her brother for many years  but they rarely spoke  and they say  for this reason  she haunts this place.", "Carousel Gardens", "CT", "Ghost" },
                    { new Guid("b0b68d7d-4e68-4099-8e67-41492f9af1e9"), "just off us state route 30 south out of E. Canton.", "\"Yesterday up the road from my house a friend and I actually saw a bigfoot in the daylight about 6 pm.  As i stated on the 99 incident at my home this must be a route they use after what we saw yesterday.  We are going to go look for prints today. We we driving down the street and at the top of the hill I saw something dart past a telephone pole on my right.  It was very fast and my first reaction was that its a jogger dressed in black  just like in 1973 and I said nothing but as we got to the intersection my friend says \"\"where'd he go\"\" and I said \"\" did you see something dart up in the woods?\"\"  He said yes.  We turned around right then and there and went to look in the woods.  There was nothing there.  Nothing moves at that speed.  By the way we live just west of Alliance Ohio where there have been sightings.  Maybe this is a route they use?? Thing was all black and had a long torso with very tall long arms that were swinging in a forward motion when it was running.\"", "Report 1851: Two men see see a hairy creature running into woods", "OH", "Bigfoot" },
                    { new Guid("b0bf3d45-7abc-4959-8137-047eb7a2f95c"), "Holcomb", "A janitor was cleaning a bathroom when he fell  hit his head  and died. He comes once a year at midnight and rings the school bell.", "Holcomb Elementary School", "KS", "Ghost" },
                    { new Guid("b21ab2f4-330d-46c5-8a40-63fcd6a1df23"), "The location of the incident was just past the Little Pee Dee River on Hwy 917 between Marion and Mullns  SC", "The year was 1998  September.  I was in the Air Force  stationed in Sumter  SC (Shaw AFB) and was traveling home to N. Myrtle Beach  SC with my two young sons (7 and 5)--they were asleep in the back seat.  I had worked that day and had spent time with my neighborhood friends after work.  I was a single parent and my children hated to ride in the car  so I had intentially started my trip very late--about 11pm.  Trip was pretty much uneventful (as always) until about 1am.  As I was traveling one of the many shortcuts I had found (hwy 917) and just passed the Little Pee Dee River  I noticed what I thought was a dog in a ditch.  As I approached  the animal turned and looked at the car and I immediately knew that this was no dog.  It was stooped over in the ditch  maybe eating a deer carcass or some other road kill.  When it turned there was a couple of things that I noticed first...  It's face almost looked like an orangutan's  there was no fur on the face and it had lips that had no real shape to them  the mouth was wider than a man's  the lips were pursed together and very narrow.  It's head seem to be wider than normal with scraggely fur on top.  The fur had an orange-brown tint to it (thus the thought that it was a dog).  It was in the process of standing straight up when it turned to look at me  almost picking itself up in the process.  Therefore  I know that it was not an animal that I had ever seen before.  I did NOT get a chance to look at it in it's full length since I passed and could not see it in the mirror.  It did not appear to have a neck  and was much broader in the shoulder and chest area than it initially appeared.  Again  I did not notice much about the legs since I did not see much of them--I will say that the chest was MUCH larger than the mid (and butt) section and it never turned fully around--but what I did notice was the arms.  They were very long and what appeared to be fingers were curved up into it's palms (not a fist)--therefore  making me believe it was some sort of ape--that maybe it mostly walked on all fours like a chimpanzee). It was covered from head to toe (with exception to the already mentioned facial area in the orange-brown fur...It had two apparent arms  I never really saw the legs since they were underneath the animal and hidden by the ditch and was much larger than I had initially thought.  The ditch was probably 3 to 4 feet deep and the animal (stooped or bent over) rose above the ditch about 4 to 5 more feet.  Another reason why the dog scenario did not fit the bill.  The reason I knew the animal was stooped or bent over was because when it turned to look at me  it had to push itself up out of the ditch with it's arms (hands  I assume) and turn around--it was initially facing in the direction I was driving (SSE) and was apparently standing  still slightly stooped over  when I passed.  It was a very dark night and I could only see the animal with the headlights.  I was driving about 65 and when I saw the animal  I slowed down--thought it was going to run out in front of me--I had deer do that to me before... When I passed I looked in the mirror  but it was too dark to make any discernable shape in the ditch.  I certainly did not stop as I was sort of tripped out and I had my two young sons in the car with me.  I retired from the Air Force in 2007 and have only told a very few people this story thinking they would believe I was crazy! I live in Texas now and have never seen another thing like that.  I am looking for any explanation that you may have for this.  I have perused your website  as well as others  and have not found any in the area that I had my sighting.  Any explanation would be greatly appreciated.", "Report 23314: Late night roadside sighting by motorist on Hwy. 917 south of Mullins", "SC", "Bigfoot" },
                    { new Guid("b2504ed6-f539-4398-8667-93a8b016d55b"), "Fort Bayard", "Fort Bayard Medical Center has been around since the 1800's. It was originally a cavalry base where the Buffalo Soldiers(first African American soldiers in the U.S. cavalry)were first introduced in New Mexico. After military use  a medical center was constructed and used as a TB center. It is now a long term care facility  and veterans hospital. In the basement (where the dungeon for the original base was) there have been sighting of wheelchairs rolling down the hall  door opening and closing  sounds of shackles and chains  moaning  crying  conversations  laughing  voices  people touching your shoulder  and apparition sightings  throughout the whole hospital on all 6 floors  esp. 2 west. In the housing area there are reports of hauntings  footsteps  late at night when everyone is asleep  apparitions  knocking on the doors and no one there  covers being torn off you.", "FBMC hospital and housing", "NM", "Ghost" },
                    { new Guid("b287fc10-d580-4a25-8f05-35126f387904"), "Coupeville", "Accounts have said that his ghost  both with a head and headless  have been seen in the cemetery and in an old cabin his family occupied after his death.", "Ebey's Landing  Sunnyside Cemetery", "WA", "Ghost" },
                    { new Guid("b2db1a3b-205b-4131-b104-c8a480309944"), "Adams", "Turn Hall is located on Turners Avenue in Adams  Massachusetts. Downstairs  there is a gym  bar  and bowling alley for members and residents of the Adams area. Upstairs  there is an appartment  that is occupied. Two friends were reported to have been looking out a bedroom window into the gym and seeing unusual things. There are a few people associated with Turn Hall that were members that have passed away that have also been reported to have been seen dowstairs in the bar room. There was a coach for gymnastics that commited suicide a few years ago that has been known to answer people's calls and still be wathing over her workplace. All these spirits aren't out to scare  though  they are all nice.", "Turn Hall", "MA", "Ghost" },
                    { new Guid("b3021679-61d8-4d9d-bc11-40da7003fe67"), "Pine Lakes ranch  approx 5 miles north of Cascade about 2 miles off of Hwy 55", "\"When I was 8 years old while living in a forested portion of central Idaho  my little brother and I got up on a snowy February morning at dawn to watch cartoons. It was to early and only a test pattern was on the TV. We turned off the TV and my brother went back upstairs to bed. I opted to stay on the couch in my warm blankets and wait untill the cartoons started. The couch was positioned along an outside wall beneath a row of 3' wide x 5' tall picture windows. These windows were approximately  7 feet from the ground on the outside. The 19\"\" TV was sitting on top of a tall wood storage box next to the wood stove directly across from the couch. I could see the reflection of the windows in the darkened TV screen. I dozed off for a while and was awakened by a noise which I thought was the snow sliding off the metal roof. I noticed a shadow shape in the window reflection nearest the stairs and at first thought it was a snow bank created by the snow off the roof. Then I saw the shadow move on to the next window and then it stopped at the window just past the head of the couch. I listened and heard some movement outside and also a sort of grunting noise. My heart started to race as I watched the mirrored reflection in the TV screen. Curiosity got the better of me and I sat up on my knees on the couch  leaned over the armrest  and looked out the window. I will never forget what I saw! There  just a few feet away was a sasquatch peering in the window. It was scanning the room with obvious curiosity. After a couple of seconds it sensed my movement and looked directly into my eyes. The face looked like a gorilla but with longer hair and \"\"smarter eyes\"\". It was not like the dark black eyes you see on other forest animals. Terrified  I dove off the couch and scurried on my hands and knees toward the bottom of the staircase. I tried to call out for my mom but my voice didn't work. I was afraid the bigfoot would hear me. Finally  I gave out a few meager calls and my mom finally appeared on the balcony above the room. \"\"What's the matter?\"\" she said. \"\"There is a bigfoot outside.\"\" I whispered. At that point I started to cry and shake. Sensing that something had terrified me   she said \"\"Well get up here then.\"\" I was still afraid to move. She said she couldn't see anything outsde from up there  so I flew up the stairs using my hands and feet. My mom knew I wasn't joking around and she wouldn't let my brother and I outside to play in the snow untill later in the afternoon. My brother saw the holes in the snow where I thought the animal stood but snow had partially filled them and he wouldn't believe my story. Years later  a friend of my moms  who knew about my sighting  gave her an old local newspaper with a story in it about multiple bigfoot sightings occuring with in a 30 mile radius of home during that 1979 time period.\"", "Report 12158: Young boy views bigfoot through window", "ID", "Bigfoot" },
                    { new Guid("b31a19ae-fc75-4f1a-aec8-faf793907393"), "3 miles west of flaming gorge dam in utah", "well i was driving down the road late at night headed back to work in vernal utah i was driving over the flaming gorge pass i was somewhere between 1 to 3 miles before the dam turn off when i was driving i seen some eye balls about 6 1/2 to 7 feet in the air so i locked up my breaks backed up to and faced my head lights at it and i seen it my first thought was a bear that was standing on its hind legs but then i noticed it was not a bear by that time he turned around and slowly started walking away from me it had verylong black mated hair and i know for a fact it wasn't a bear by the way it walked it scared me so bad i got out of there and i did not care to go back and look so the next few times going back through been watching every track to see if i could  find them but  no luck but i know one thing he was not scared of me nore my loud deseil motor", "Report 25265: Man watches a bigfoot in his headlights near Flaming Gorge", "UT", "Bigfoot" },
                    { new Guid("b33a130f-4888-485f-928c-1ad21ed4b9a5"), "Missoula", "Is haunted by a poltergeist named George. If he likes the production  he will prompt the actors. If he does not like it  he throws the storyboards.", "Missoula Children's theatre", "MT", "Ghost" },
                    { new Guid("b3ed070c-120e-497a-8f77-7654e77b5d43"), "Lewitson", "An old Native American woman wanders around along the shore of the lake. When approached she recedes into the lake and disappears into a whirlpool.", "Waha Lake", "ID", "Ghost" },
                    { new Guid("b47cef97-2677-4a05-bdad-6ff8fe5430dd"), "Anderson", "Sullivan Music Center -  a ghost of a lovely young girl haunts this building. People say she is there because she is waiting for someone.", "Anderson College", "SC", "Ghost" },
                    { new Guid("b4e8c270-d1cc-4a38-a136-51103046358c"), "Winooski", "In the 1960's  five Winooski High School students were killed in a crash coming back from Canada after a suspected night of drinking.   The local funeral home didn't have enough room in its parlors to hold all five bodies  so the others were laid out in the school gym.  A mass wake was held later held there.  Janitors have reported strange sightings since then up to present day when cleaning late at night  especially after sporting events.  Ghostly happenings include lights flicking on and off  lockers mysteriously opening and slamming shut all down the hall  echoing voices in the gym...etc.  But perhaps most frightening  the sound of wheels rolling along the gym floor  echoing the coffins being rolled into the gym for the wake.", "Winooski High School", "VT", "Ghost" },
                    { new Guid("b4f379a6-01e1-49aa-bf0c-a8a242df8c9b"), "Columbia Station", "There are two parts to this cemetery on West River Rd. A new part and an old part  in the new  pretty much any time after dark  there is a little girl that will skip to a tombstone and then stop and kneel down at it and disappear.", "Columbia Cemetery", "OH", "Ghost" }
                });

            migrationBuilder.InsertData(
                table: "Entities",
                columns: new[] { "Id", "City", "Description", "Name", "State", "Type" },
                values: new object[,]
                {
                    { new Guid("b5026fac-2734-4356-a332-78d95a7933f4"), "DeQueen", "If you drop a rock in the well at the middle of the cemetery at night  you can hear a baby cry. It has been said that you can even see and hear the baby’s mother running through the graveyard  near the old burned down church. The story is told of a woman who was near the well drawing out water  before it was a graveyard. She sat the child on the edge of the well  and the baby fell in and drowned.", "Avon Cemetery", "AR", "Ghost" },
                    { new Guid("b5636d60-cd75-429f-b877-e707472809eb"), "Gloucester", "Whital House Battle Field - it is noted of haunting from the revolution 1776 dead soldiers in the attic house was used as a hospital check it out.", "National Park", "NJ", "Ghost" },
                    { new Guid("b5aa5ccd-f1a9-48c2-a90f-55f91ade1db9"), "It was just North of the road on Hwy 285 from the flashing light of Tres Piedras  New Mexico right where there is a wall of rocks on each side of the road. by the Per-light.", "On Feb .20  2011 my mother and father were on there way back to Antonito  Co from Espanola  New Mexico. It was probably between 10:00p.m.and 11:p.m when they were driving down  road 285 headed north a big tall  black human looking thing was standing in the road upon the car coming up closer the black thing which stood over six feet tall  very husky  walked very fast like a gorilla walk across the road. The thing popped out from the east side of road 285 crossing to the west side of the road . It was a very scary situation according to my parents. They suggest that anybody  especially female drivers to PLEASE BE CAREFUL.", "Report 28886: Couple driving home has night time sighting near Tres Piedras", "NM", "Bigfoot" },
                    { new Guid("b5fbfb3e-aabe-4ede-8f23-6e37065744a8"), "All encounters occured in Amite County  Mississippi  in a wooded area about one mile south of Hwy. 23. This area  known as East Fork Community is about 15 miles west of McCombe  MS", "\"Unfourtunately  I have no video or audio  only personnel observation. The first encounter did not involve a sighting. As a young boy  I was out on the front porch with my mother  father  uncle  and grandfather. At around 9:00 pm  we all heard a sound that was not unlike a shrill human scream. Untill that night  I did not know what it meant to have your hair stand on end. A somewhat large dog that we had outside barked  cried  and ran away in apparrent terror. The only thing we found the next day was a single partial footprint. The next encounter happened when my cousin and I were in the woods fishing at a pond on our grandfathers property. We first noted a very strong odor that we took to be a skunk. We then heard a sound like a scream  a few grunts  then nothing. Before the next encounter  there were some unusual incidents that deserve mentioning. First was the finding of dead livestock  mainly pigs. They almost always had been found with their liver and heart removed. I never saw this myself  only heard the stories. I did see on at least two ocassions all of the fruit eaten off of trees on the property. In both cases  all of the fruit was removed from the trees  and the pits on the ground around the tree. We laughed about the belly ache something would have from eating an entire tree of green pears. Later  as a teenager  I was alone in the woods. I had the distinct feeling I was being watched. I crossed a barbwire fence near the road  crossed the road and entered the woods there. When I returned to the road a short time later  20-30 minutes  I saw that the fence I had earlier crossed  had been partially knocked down. Upon approaching the damaged fence  I noticed several \"\"large\"\" footprints. They appeared human in every respect except for their size. Even then  I wore a size 12D boot  the prints were at least two to three inches longer and maybe two inches wider than my boot. The tracks led first to the road  then back into the woods. Maybe a year later  a friend and I were in the woods. He was from New Orleans  LA  and knew nothing of the past encounters. While near a creek bottom  he suddenly froze and ask me what was watching us. I stood near him and saw what I first thought was a bear about 25 yards away. It was in a squating position. It then stood upright. It was  I'm sure  seven to eight feet tall. The creature was covered with very dark brown hair over it's entire body  with the exception of it's face. It stood upright like a man  not stooped like a bear. As we departed the area  we watched it follow us. The creature had a long stride and it's arms swung as it walked. It followed us to the edge of the wood line. The only sounds it made were whistling noises. My next and last encounter did not occur until I was in the army. A co-worker and I went to the old house to do some shooting. We arrived late that night. As we sat outside talking  we saw a large man shaped creature walk accross the road about 125 yards away. It walked into the woods and disappeared. It did not seem to notice us.\"", "Report 1338: Several incidents in the East Fork Community", "MS", "Bigfoot" },
                    { new Guid("b63de41f-8123-418d-b8f8-05748834c91d"), "St Louis", "Object appeared below the moon. Travelled from Southeast to Northwest. Changed color and direction erratically.", "Light", "MO", "Alien" },
                    { new Guid("b77530b0-0b18-41b6-98c2-d9d851e8a26c"), "At Wheatfields Lake camping ground.", "\"We were camping out with a couple of my cousins along with their kids on 4th of July weekend at Wheatfields Lake  east side of the lake. We got there on Friday evening which is July 3rd. we decided to camp there since there were alots of campers at the main campground which is located on the west side of the lake right off the highway. At 4:00am Saturday morning  my little boy woke and I started to tend to him. At 4:15am  my girlfriend and I were up sitting inside the tent feeding my little boy when we heard a loud low sounding roar coming near the west side campground. Immediately  some of the campers' dogs started to bark like crazy. I asked my girlfriend \"\"did you hear that?\"\"  she replied \"\"yes  what is it? It sounds scary\"\". I told her that its something huge with a good set of lungs. We heard it about 5-6 times. Duration of the calls would last like 10 seconds long. About 5 minutes later  the call ceased. But we could still hear the dogs barking away. Then at 4:45am  we heard one more call from the same location. Afterwards  my girlfriend and my little boy went back to sleep while I stayed awake all morning. The next morning  I asked my cousins if they heard the calls and they said they didn't.\"", "Report 26297: Several early morning vocalizations heard at Wheatfields Lake", "AZ", "Bigfoot" },
                    { new Guid("b7bf7c43-7494-4161-9b99-6c51f0d44387"), "Mound", "3 red lights that formed a triangle in the sky moving slowly and then just disappeared.", "Triangle", "MN", "Alien" },
                    { new Guid("b7f36886-3c1c-4f8a-9d73-88c0a0c8166a"), "North Platte", "This is where they used to keep ice back when they didn't have fridges. People have said they have seen a man hanging from one of the hooks that they used to put ice on  they have also said lots of things about people walking around on the upstairs level of the ice house.- April 2007 Update - that building was torn down.", "The Ice house", "NE", "Ghost" },
                    { new Guid("b7fe7a60-050f-465f-b823-84d4f6ab42f4"), "Beaver", "Mudlick Hollow - It is said that in the 1800s tragedy struck when a young newlywed couple was riding their horse drawn buggy through the hollow on their way home after the wedding. A small animal is said to have darted out of the woods  spooking the horses and causing the buggy to roll off the road and into the creek. The bride died from a broken neck and the groom was pinned under a horse (who had become lame) and slowly died next to his new bride. It is said by many locals that on very dark nights a fog creeps up onto the road (which is more of a dirt lane) and you can hear a horse drawn buggy fast approaching behind you  but before it comes upon you there is a crash  a scream  then all is silent and the fog vanishes.", "Brighton Township", "PA", "Ghost" },
                    { new Guid("b88078c1-f54f-4dfb-969d-f8459c8f8928"), "Park City", "One of the ghost was murdered back in these woods several years ago. It was by her husband who had caught her in a deep love affair. Little did he now that she was pregnant. Now her soul can't rest. So she takes it out on the kids who travel this trail. The second tale of a different ghost is a strange one. Jacob was riding his bike down the trail. This trail is a pretty easy to ride on except for one spot. We know it as deadman's curve. We'll when he got to this spot he was picking up speed so he tried to slam on the brakes. But for some reason his brakes were not working. So he road his speeding death trap down the wrong path. His front tire hit a root sticking up from the ground and it sent him flying head first into a tree. His lifeless body floated down the creek never to be seen again. Some say it was the wife who killed him.", "The Backtrail", "KS", "Ghost" },
                    { new Guid("b888ca58-99c8-4f24-851f-f69c8fe8eb88"), "Keene", "Huntress Hall - Harriet Huntress is said to roam the attic and fourth floor of Huntress. In her later years she had to use a wheelchair to get around  and some say you can hear the wheels scraping against the floor. The wheelchair is still in the attic.", "Keene State College", "NH", "Ghost" },
                    { new Guid("b91a7dd5-5959-464e-bece-c9f37077d854"), "Arcata", "The original proprietor of the building (and several others nearby) is known to haunt the pub and periodically cause it to be known. Employees report moving furniture  dishes etc. during their shifts and the ghost is well known to established patrons.", "Humboldt Brewery", "CA", "Ghost" },
                    { new Guid("b9c22c03-9207-44ff-a168-4f62531da9f1"), "North vernon", "Noticed a bright light like the sun coming up the it started to change colors from orange to red to blue to white then other colors was", "Light", "IN", "Alien" },
                    { new Guid("b9e7f3aa-b48a-45af-a669-68650a51aeba"), "Puryear", "Big white orb moving south across the sky at a fast pace  and then vanished.", "Circle", "TN", "Alien" },
                    { new Guid("b9ea7ba2-0193-4907-9762-648722b61e09"), "North Cove", "wood knocks screams yodleing structures ", "Report 63252: Ongoing incidents in North Cove outside Asheville", "NC", "Bigfoot" },
                    { new Guid("ba3ac14a-3b10-4846-b011-de814a62c27e"), "Halfway up Snowbowl Rd.  before reaching the Arizona Snowbowl chairlifts.", "\"While in flagstaff  AZ  my husband  mother-in-law  and I decided to take a chairlift ride. As we drove up snow bowl rd to reach the Arizona Snowbowl  we saw a large tall figure walking in long strides through the trees. I would say about 40 yards from the desolate road. As an avid \"\"Finding Bigfoot\"\" watcher  our sighting was everything we heard/saw on the show. The squatch had to have been at least 8 or 9 feet tall. It was too far away to make out any features  but the way it walked  the posture  and dark brown/black color it was unmistakeable. Definitely not a bear or deer. We saw the creature take two long strides through the trees and \"\"disappear\"\". A feeling came over us of shock/fear/amazement. I had goosebumps all over my body.\"", "Report 46243: Passengers travelling to the Arizona Snowbowl ski area have a possible daytime sighting", "AZ", "Bigfoot" },
                    { new Guid("ba5a487b-94d9-46fa-8ab1-3a1ec7081346"), "Missaula", "Main Hall - unexplained occurrences include blood-curdling screams.", "University of Montana", "MT", "Ghost" },
                    { new Guid("ba609a0b-7607-4333-858c-03b5df18acd9"), "North Little Rock", "Clearly observed a triangular craft outfitted with three bright lights. Object made no sound and floated perfectly still for around fo", "Triangle", "AR", "Alien" },
                    { new Guid("ba7ec3ab-4550-4d73-a702-a874ef0a9b6c"), "La Crosse", "Apparition of the original owner is reported.", "The Bodega Brew Pub", "WI", "Ghost" },
                    { new Guid("bac0eaab-1424-437a-95e9-bc2ba068794f"), "Honaker", "A helicopter crash left large chunks of metal from the aircraft and bones in the trees on big a mountain. Local people from the area were first on the scene and one man found a dying victim moaning but he was too late to save the person's life. He returned to the spot years later and said he could still hear the person moaning and felt a cold chill and the smell of death still fills the air around the area where the helicopter crashed", "Big A Mountain", "VA", "Ghost" },
                    { new Guid("bb30ad0e-8cf3-4fd8-a478-1a1a75fa53ce"), "Lake Havasu City", "Orb like lights dancing within a large cloud", "Light", "AZ", "Alien" },
                    { new Guid("bb33a927-ea54-4b27-a055-60800eb25afc"), "Gunnison", "Roubidoux Hall - 3rd Floor - Third Floor Roubidoux is haunted by the ghost of at least one spirit.  He had died from smoke inhalation when the building caught on fire some 20 years ago.  Those who live in the boys old room where he died have seen ghostly apparitions over the side of the bed while sleeping.  The doors have also been known to lock people within the room as he was trapped inside his room when he realized there really was a fire.", "Western State College", "CO", "Ghost" },
                    { new Guid("bba1a2cf-3810-4da8-880d-7e95a942032b"), "Anchorage", "It is said that when the Dimond center was first built  the grounds under it were sacred burial grounds from thousands of years ago  dating back to when natives first roamed the lands. While digging up the grounds to build the mall  workers came across a few graves  but due the fact they were so old and small  they continued digging. Now the ghosts roam the areas and usually appear in front of lone people in the bathrooms  and smaller hallways in the mall.", "Dimond Center", "AK", "Ghost" },
                    { new Guid("bba1b5b7-d07a-4957-bb8e-6b771578d2b4"), "Anchorage", "It is said that in the basement auditorium and in the area where it links to the Middle School  there are restless creatures that are only semi-human in the area. They take out their anger on a lot of students and young teachers. Rumor has it that West High and its neighborhood were once an elusive  swampy forest area and the creatures hate how their land has become so polluted and contaminated.", "West High School", "AK", "Ghost" },
                    { new Guid("bbcd624a-a2d1-4e22-9df8-d0c77a23210d"), "Outside of South Sioux City NE on Golf road about 50 yards past Elgin ave.", "In september 1998  me and my brother-in-law and his girlfriend (which wish to remain anonimous) were walkin down the gravel road that I lived on. It was about 2:00am  we were about 1 mile away from my house  and we smelled this horrible smell  almost like the smell of something dead but stronger. We looked around  but couldnt see anything considering how dark it was. We walked a little bit farther and decided to turn around and go home. As we came across the spot that smelled so bad  we noticed that there was no smell anymore  so we decided to look around a little more. On both sides of the road were ditches that were about 8 to 10 feet deep. We walked over to the side of the road where we originally smelled that bad smell  as we got to the edge of the road a creature that looked to be about 7-8feet tall suddenly stood up  it was very dark that night but the creature looked to be the size of a grizzly bear  but there are no bears in the area I live in. Needless to say it scared the hell out of us and my brother-in-laws girlfriend screamed and the creature took off running as did we. As we were running back home we saw three deer running in the cornfield near the road. I slowed down for a second and watched them  then I heard this extremly loud screaching kind of howling sound. Im wasnt sure what it was we saw or heard that night  and wasnt much of a believer in bigfoot  but then this last summer I was watching wierd travels on the sci-fi channel. They were talking bout bigfoot  and they explained exactly what we saw  heard and smelled that night. I never mentioned anything about it till now for fear of critisizm. But i am now a strong believer in bigfoot  and want more than anyone to prove these amazing creatures exsist.", "Report 22577: Three witnesses encounter a large creature while walking down a gravel road outside South Sioux City", "NE", "Bigfoot" },
                    { new Guid("bc71d4db-1ba2-4d34-a398-8baaafcf0562"), "about 3.3 Miles up the Ingersol Road.  N 47 15.824 W 120 13.426", "\"While Turkey Hunting in the Ingersol (Colockum Wildlife Area in Central WA.)on 4-15-05 I came across some fecies with a diameter of about 2\"\". Which at the time I thought to myself it must be a Huge Bear. The following day 4-16-05 I walked about a mile down a fire guard road above where I had seen the fecies. The fog was coming in and I had not seen any Turkeys so I turned around and headed for the truck. The Fog was getting thick and I could only see about 35 yards.About halfway to the truck the wind changed and was blowing down the hill. I smelt this awful musty skunky smell and the hair on the back of my neck stood up. I quickly turned facing the smell with my shotgun slung but I did not see or hear anything.Again I could only see about 35 yards because of the Fog.At this moment I felt it was the smell of a Sasquatch. Then I got to thinking about the Fecies and told myself it must be a Bear. That evening I called my Nephew because he was going Hunting with me Sunday 4-17-05. I told him their must be a Large Bear in the area because I saw the fecies on Friday and on Saturday I had smelled him.Sunday mourning we arived at Daylight where I had seen 5 Turkeys the day before.We got all of our gear ready and hiked about 300 yards up the hill. I took out my Turkey Box Call and started Yelping with it.A Howl started below us about 150 yards a Coyote that turned into a Wolf that turned into a roaring blood curling sceam! I am 47 Years old and have Hunted the Cascade Mt.Range all of my life! I have NEVER heard anything like it in my entire life. My nephew turned and looked at me He's 16 and said what is that? I looked him strait in the eye and said it is a Sasquatch. The Length and the Volume and the Depth of the Howl could not be duplicated by a human being.I asked my Nephew if his gun was loaded and if he wanted to try to get a look at it? He said yes.We moved a little closer toward the scream but did not see anything. It was in scatered Pine Trees.We headed back up the ridge and West aways and stopped. Again I took out my Turkey Box Call and started yellping. Again about 400 yards up the canyon we heard a Deep Long Howl. The creature was making his way up the draw at a high rate of speed.I yelped on the Turkey Call again and he Howled again!!!He was moving away into thicker Timber this time he was 500 to 600 yards away and we never heard him again.\"", "Report 11313: Turkey hunters surprised by loud vocalizations near Wenatchee", "WA", "Bigfoot" },
                    { new Guid("bcb5e5d0-2742-40f5-b7b5-256b8c9b1dbb"), "Cheyenne Mountain  near NORAD.", "While training at Ft Carson  I was on patrol with a Marine Recon Agressor Force  agressing fire batteries in simulated attacks.  My patrol attacked the HQ company  and during the withdrawal  I was separated from my unit.  There was plenty of ambient light  and I could see my unit across the field and hear them calling for me.  They took off  and I figured I could cut through a wooded area and intercept them.  As I rounded a bend in the trail  a figure stepped out into the trail in front me.  It was about 6.5 feet tall  covered in light brown fur  had large fox-like ears  and large  black  globe-shaped eyes.  The nostrils were slitted and large  without much nasal definition.  The body was muscular  with a thin waist and easily discernible definition  and the arms were long  hanging below the level of the hips.  The creature stepped out into the trail  looking in the opposite direction  and I had stopped stock-still the moment I saw it.  It turned and saw me  at which it exhibited a startle reflex then immediately crouched down and slowly moved sideways off the trail  watching me the entire time.  It knelt behind a bush  at which point it became very hard to see. I realized that I was encountering something few people have the opportunity to see  at only a distance of about 10 feet.", "Report 17767: Night-time sighting by Marine training near Ft Carson", "CO", "Bigfoot" },
                    { new Guid("bd497ffb-5ea4-402c-a21d-d6a6a230400a"), "Chadron", "This neat old bed & Breakfast/Restaurant  Bar is haunted by a friendly spirit that the Owners call (Jack). Guests and employees have heard footsteps on the stairs when no one is there. objects have been moved from their original position. One couple who recently stayed there had placed a water glass by their bed side table. The next morning when they awoke they were surprised to find the water glass sitting on a counter in another room.", "Old Main Street Inn", "NE", "Ghost" },
                    { new Guid("bd69d787-eba9-4ea6-8eaf-5f7093e12b15"), "Eureka", "stories have been told of a two restless ghosts that wander the auditorium. The first is of a man who fell from the balcony during the buildings construction during the 20's and was decapitated. The second is of a young girl  who after losing the leading role in the school play of 1954  hung herself in the lighting booth in full view of the actress on stage. The actress took no notice of the wide eyed corpse in the balcony  and continued the show.", "Eureka High School Auditorium", "CA", "Ghost" },
                    { new Guid("bd6e6f83-eb7a-46ea-9509-8d8ac02ba8bd"), "Hindustan is the nearest village (only a few homes and small church) perhaps 3-4 miles away on Old 37. The town of Martinsville is about 5 miles to the north and the town of Bloomington is about 15 miles to the south. This incident took place in the Morgan-Monroe State Forest on the Main Forest Road about 1 or 1.5 miles east of the forest entrance that is off of the State Road Old 37.", "\"This took place while on the last day of firearm deer season in Novemeber  1988.  It was after sunset but not yet dark.  The temperature was in the mid 30's but the ground wasn't frozen and there were still patches of snow on the ground in places.  I came out of the woods  put my shotgun  heavy winter coat  and daypack in the trunk of my car and got inside my car to start it up when a movement to my left caught my eye. I will tell you what I saw and what I thought as I was seeing this happen.  This man/bigfoot came out of thick brush between the trees to my left on the opposite side of the road from where I was parked  maybe thirty five or forty yards down the road at an angle but it had to know that I was there or at least that my car was there. When I first saw this thing coming out of the thick brush the first thing I thought was  where in the heck did he come from....  Then  I thought  stupid guy  no hunter orange and then I began to notice strange things like he had no gun  and that he was the same color from head to toe  no hat  no hunter orange?  But then what I really noticed was that his arms were long  his hands were swinging at his knees and though he was taking large steps crossing the road very quickly but without running  he was just walking.  His arms were swinging wide like a British soldier marching but he didn't seem to be in any hurry and he completely ignored me like I wasn't there but he had to know that I was there.  He did not look over and kept his head looking straight ahead. He went into the woods on my side of the road (side I was parked on) and went down the hill and disappeared.  My eyes told me that I just saw a bigfoot but my brain and common sense was trying to dispute that.  His color was dark brown and I thought could that have been a man in a one piece Carhartt outfit or if he were a hiker lost wouldn't he just have stayed on the road rather than go down a steep hill when it was almost dark or if lost why didn't he ask me for help?  He was about six feet tall but very husky with his hands  body  feet  side of his head-face  all one color.  I actually couldn't see fur because the light was dim.  I could see the trees and tree trunks fine but not the bark because the tree trunks were silhoutetted and that's what I mean about not seeing the fur  it was all one shade of dark brown.  Now  all of this that I just told you took place in a minute or less.  Soon as it disappeared over the side of the hill I jumped out of my car  opened the trunk and loaded my shotgun (for self-defense only)  put on my winter coat  and got my flashlight out of my day pack and walked to where I thought the thing went over the hill.  I wanted to check out what I just saw and was hoping to find a footprint in the ground or on a patch of snow and I went slowly back and forth  traversing this rather steep hill going a little deeper down as I moved back and forth.  There was a deep like gorge on the right side of the hill and I looked up towards the road and by now the ridge on top was just a slither of gray and looking over my shoulder I realized this was not too smart  it was pitch black below me and I got a little scared and hiked back up to the road and to my car as fast as I could.  I placed my shotgun back in the case along with my heavy coat putting them in the truck and then I drove up and down the main forest road to see if there were any cars parked off on the sides or if there were anyone walking  I saw nothing.  I drove to the valley road where I thought this thing would eventually come out at the bottom of the hill into farm fields and I drove back to the end of this valley and back hoping to see something but saw nothing.  I have been wanting to make a report of what I saw and have told my wife  children  teenage granddaughters  brother  and two close hunting buddies  but have always been hesitant to make a report.  The truth is  though I am sure what I saw wasn't a man I can't prove it wasn't a man dressed up in a suit but who would be that stupid especially during hunting season. I can't say positively that it was a bigfoot but that is what my eyes saw.  Logic says \"\"no\"\"  my eyes say  \"\"yes\"\" and that's my report the best that I can remember it.  I am glad to get this off my chest.  If this helps in any way then that's great but please use only my first name if this is posted  I am not seeking notoriety here  thanks.  Sincerely  [name removed]\"", "Report 24815: Man recalls his observation of a creature crossing a road while hunting in the Morgan-Monroe State Forest", "IN", "Bigfoot" },
                    { new Guid("bdaa20fe-5cd1-4009-b326-35c2de0dfca6"), "Lawton", "Wilson Elementary school has a ghost that opens doors  turns off radios  and sometimes  out of the corner of your eye  you can see shadows move about.", "Wilson Elementary school", "OK", "Ghost" },
                    { new Guid("bde3d8e0-5082-48bb-8cfd-523c14a81343"), "Jackson", "A light brighter than Venus  moving in an 'S' pattern  fades into the darkness of the southern sky.", "Light", "MS", "Alien" },
                    { new Guid("be7ef05e-81a7-4fb6-9450-741eba4593ed"), "Gravel Ridge", "Supposedly  if you go there late at night you can see apparitions of the dead animals that were buried there. You can also hear their howling cries come and go in the night.", "Gravel Ridge Pet Cemetery", "AR", "Ghost" },
                    { new Guid("bef61647-7ce3-45fa-8509-0498ed59a707"), "Casper", "On the paper route two cylinder shaped craft with brights lights in the center  preformed sparatic movements in the sky.", "Cylinder", "WY", "Alien" },
                    { new Guid("bf40411e-0219-4342-b226-2c566a260e98"), "heavy wooded area around campground", "While on vacation  my family and I were camping at Linville trailer lodge and campground in Linville North Carolina. On June 15th  2010 we were all sleeping in our pop up camper. At 2:00 am I was woke up by the sound of an animal to the south east of our camper. Its calls were 4 short whoops followed by 1 double whoop. After listening to that for a couple of minutes I heard another one calling from the North West. Its call was 3 short whoops followed by a double whoop. While listening to that one  another from the North West started calling. Its calls were 2 short whoops followed by a double whoop. After a couple of minutes I could hear them calling and moving towards the north east. It sounded like they were with in 100 yards of our camper but I was the only one that got woke up. On June 17th we got ready for bed about 9:00 pm. around 9:30 pm I could hear the same calls as the second and third animals from 2 nights before  they were much further away this time. My 8 yr old daughter heard them also and asked what kind of animal makes that sound? I did not answer her. After we got home I got onto your web sight and played the whoops and knocks from the Sierra Nevada Mountains  my daughter came running from her bed room and said that is what I heard the other day. Then I explained to her what it was she heard.", "Report 28381: Campers hear multiple whooping sounds at Linville Falls", "NC", "Bigfoot" },
                    { new Guid("bf86cf9f-38f8-4166-bc27-e8221b9b831f"), "Lapwai", "\"it is a two story  red brick building  with a 100 x 50 foot courtyard in the middle. It is located on the west side of an open field  which is about the size of a football field. Directly across from this building (on the eastern-most side) used to stand an identical building  which burned down about 20 years ago. Finally  on the northern-most part of the field is another building  which was part of the other two  which has since been remodeled into the local school districts office. The point behind all of this  is that these buildings were once used as offices  dormitory's and also a TB hospital and sanitarium by the U.S. Calvary during the early settlement days. This area was called \"\"Ft. Lapwai\"\". The building has now been remodeled-extensively- and contains a total of 11 head start classes  with 4 of those classes for the ages of 0-3 years. it is these downstairs  baby rooms that have some of the most \"\"activity\"\" one particular incident occurred about a year ago  conveniently around Halloween! The last persons out of the building are usually the janitors. They usually run a check thru to make sure all of the night. early the next morning  the first person downstairs in the morning is the lead teacher. When he arrived in the morning  there was children's reading books  put into two separate lines on the floor  side-by-side  leading from one room to the office. No one had been in the building  nothing was missing  toys are often found as if they had been played with-after they had been put away  lights have been witnessed downstairs  apparitions have been seen  rocking chairs move without anyone in them  and other strange occurrences. Other rooms also have activity  but one room seems to have the most.\"", "Nez Perce Head Start Program", "ID", "Ghost" },
                    { new Guid("bfdc6fbb-bb4b-4d69-bd46-3532ecee562b"), "Hwy.#1 N. to McBee  turn left onto Hwy.151. Go about 6 to 8 miles turn left at a little country store onto Hwy.903 . Then go about 2 to 3 miles turn right at second paved rd. This will take you to the turkey farm.", "My co-worker and I were on a turkey farm at about 12:30AM. one night in October 2003. I began smelling a strange smell that I had never smelled before on a birdfarm. I began shining my Q-beam spotlight around in the darkness. I noticed something standing behind the barn across from me. I could see the animal picking up acorns or something off the ground.The animal didn't like my spotlight because it would block the light with its hand. I couldn't believe what I was seeing. I ran over to my coworker  that was working on the other feed truck to warn him as to what I had seen. He laughed and said for me to quit tryin to scare him. I told him that I was serious  and he would see it if it was still there  since it was behind the last barn that he had to pump feed in. I noticed he was startled when he shined his spotlight and saw this large creature for himself. He claimed that this creature started walking toward him  and it really shook him up  because he ran to the front of his truck and sped to the front of the farm where I waited on him. He was white as a ghost. He claimed that this creature was between 8 to 10Ft. in height and as broad as two linebackers. I told him that's exactly what I had seen .", "Report 9475: Two turkey farmers have nighttime sighting near Jefferson", "SC", "Bigfoot" },
                    { new Guid("c01bd620-5ae4-4c67-b06b-25b480060674"), "El Paso", "Photo lab - Students and faculty have reported feeling a presents in the back of the photo lab. The revolving door has opened by its self and the curtain has opened as if someone is watching you. Some students have even reported that they felt someone touching their shoulder and breathing on the back of their necks. The school was built on top of the old Prices Dairy  and some believe a presents from the dairy has found a new home in the school photo lab. Some of the janitorial staff refuses to clean the photo lab area after dark.", "El Paso Community College", "TX", "Ghost" },
                    { new Guid("c045c930-d09d-45df-a246-c18c53afa1a6"), "Rahway", "Triangle shaped aircraft with swirling lights", "Triangle", "NJ", "Alien" },
                    { new Guid("c09a34c5-733b-457c-9b76-55f4d8dea106"), "Go to the town of Genoa.  Drive north on Foothill Rd. turn left on Centennial past the cemetary.  The road ends up behind some residential homes but where the road ends the land belongs to the Forestry/BLM and is the start of the trail head.  It is a tough hike but eventually you will come to the remaining foundation of the deer hunter's cabin.  It was in this vacinity where we met this large  hairy  smelly guy near the creek. Going uphill the creek will be on your left.", "\"In Sept. 1984 my friend and I were hiking on the east side of the Sierra Nevada Mtn. Range above Lake Tahoe and the Carson Valley above the town Genoa.  Both of us grew up in this area.  Although in high school I was kind of a cut up  my friend Linda  graduated valedictorian of our class 5 years earlier.  She is very logical.  We have often hiked this trail that basically goes straight up the mountain and over to Tahoe.  It is a strenuous hike.  When we parked our truck at the trailhead there was another car parked there as well.  We were 1/4 the way up the trail when two teenage boys came running down the mountain towards us.  The trail was extremely steep and they were running for all they were worth.  They stopped long enough to implore us not to go any further up the mountain as they had seen a monster or something.  There was an old deer hunter's cabin at about the half way point and we told the boys that we were only going to go that far.  (We thought they were drinking or on drugs) We shrugged off the incident laughed and joked that we wished we had what they were \"\"smoking.\"\" We reached the cabin without incidence sat down on the bluff that overlooked the Carson Valley we split a soda that we had brought and I took out my recorder (flute like instrument) and began playing some little tunes on it.  We were alone on the mountain we thought. After about an hour of putsing around we decided to head back down the trail.  I kept smelling dog doo or something dead.  I even checked my shoes.  We were near the creek gathering pine cones for an art project  I was facing downhill  Linda was facing uphill  we were examining a particularly perfect cone when Linda looked up and exclaimed  \"\"Oh  my God it's a bear  no....it's a guy in a bear suit!\"\"  I looked up and couldn't believe it  we were a stone toss from a 7 ft. hairy dude.  He looked directly at us and to this day Linda and I felt something pass between the three of us.  He stood across the creek from us.  His hair was the color of dry pine needles and covered his whole body with the hair thinning just on his chest and face. He had a large broad chest  but not breasts like a female  his arms were hanging at his sides nearly to his knees and when he walked  he took long strides and his arms swung freely as he walked. He didn't seem to fear us although he began to walk straight up a pine needle covered slope  barefooted  without slipping. As he moved away Linda grabbed my arm and began dragging me down the hill I couldn't take my eyes off him and he never took his eyes off us.  I do not feel to this day as he meant to harm us but instead I feel he was just as fascinated with us as we were with him.  His face seemed almost serene with very intelligent eyes - his face resembled an orangutan. He had large eyes and a flattish nose I sketched a picture as soon as I got home and Linda confirmed that I had captured his likeness - I wished I had a camera on me that day.  As we continued at a fast pace down the hill he remained on the ridge above us paralleling in the same direction. We reached our truck and could still see him crouching on a granite boulder at least a football field distance between us.  I yelled up to him that he was very cool but he shouldn't be scaring the crap out of us locals.  He stood up on his boulder and Linda told me to shut up and get in the truck.  We were strangely disturbed that afternoon and evening.  We thought of going to the forest service or the sheriff’s dept.  But crimeny sakes  who would've believed us?  Plus in our community they would just want to shoot him. We have since hiked there many times.  Always hoping to catch another glimpse.  We are married ladies with kids and we take the kids up \"\"Bigfoot Canyon\"\" periodically in search of our elusive friend. A few years ago the wind blew down some trees during a storm and exposed an area that we had not seen from the trail before.  When we went up to investigate we found a large boulder and some older pine trees with branches low to the ground around it.  You could duck down and go under the trees near the wall of the boulder and it looked as if something or someone had made a natural shelter there.  The pine needles had all been tramped down and it seemed to be away from the prevailing winds.  A great place for deer  bear or perhaps a bigfoot.  We hope so.  I will never look at life on this earth the same way.  I have seen bigfoot and not only does it make for a great tale around the campfires at night  it fuels my imagination about every little sound I hear when I am in the wilderness.  I am intrigued.  I only hope that no harm comes to the Bigfoots.  I believe that the great creator of all life shares the sight of the Bigfoot with people who might grow from the experience. I know Linda and I have both grown.  Even if we share the experience with someone who doesn't believe us - it really does not matter.  We know what we saw.  He was so close in proximity it was obvious to us that this fella belonged here.  He was as natural as the sky  creek  trees and the deer.\"", "Report 5909: Two Hikers Have Close Encounter Near Genoa", "NV", "Bigfoot" },
                    { new Guid("c1587bed-948b-46da-bbaf-f3b3fe9ece7e"), "Hayward", "I was driving with my son and noticed what I thought was a plane  but wondered why it was so low above the tree line...the as it moved", "Disk", "WI", "Alien" },
                    { new Guid("c1934897-800b-4e42-aa37-5e5a6020697d"), "Virginia Beach", "I was laying in my bed watching tv with the windows open and I saw this Bright yellow light fly across the sky then all of a suden It s", "Light", "VA", "Alien" },
                    { new Guid("c1a9d3d0-a3a8-42f8-ba0a-b25d37106ea0"), "", "WAS ON HWY 15 NORTH JUST APROACHING HWY 33 UNDERNEATH A HIGHWAY LIGHT AND YARD LIGHTS OF FARM HOUSE. WAS APPROACHING AND SOMETHING OR SOMEONE CAME OUT OF THE DITCH ON MY SIDE AND WITH 1 STRIDE CAME RIGHT UP TO MY CAR AND STARED RIGHT AT ME AS WENT BY. AS I SLOWED DOWN FOR THE STOP SIGN I LOOKED IN THE REARVIEW MIRROR AND IT WAS STANDING IN THE MIDDLE OF THE ROAD LOOKING AT ME. SORRY  DIDN'T STOP. CALLED MY FIANCE AT THE TIME (NOW MY HUBBY) AND WAS HISTERICAL. HE CALLED THE STATE PATROL AND THE DISPATCH SAID...THIS ISN'T THE FIRST TIME WE HAD A BIGFOOT REPORT. THIS THING WAS AT LEAST 6 TO 7 FEET TALL AND DARK. ALL I SAW WAS EYES ON TOP OF THIS MASSIVE BODY. SCARED THE HECK OUT OF ME. JUST ASK MY HUBBY.", "Report 28090: Motorist has possible night time sighting near Dorchester", "NE", "Bigfoot" },
                    { new Guid("c1b14508-5570-4885-919d-2a9bbfec2471"), "Deming", "Two students have reported seeing a knife in the gym  noises  lights flickering. They have also heard the piano in the third grade hallway when no one was there. Also two girls staring in the windows.", "Memorial Elementary", "NM", "Ghost" },
                    { new Guid("c2e993db-4443-4be6-ba23-9b70b6489b0d"), "St. Louis", "There are three known ghosts that haunt this famous theme park. The first one is the ghost of a little girl that has been seen around various areas of the park running around and laughing. The second spirit is a girl named Stella who haunts several of the parks theaters  giving off cold spots and speaking to people. The last ghost to haunt this park is known as The Pigman. He has been spotted on the back service roads late at night and some of the employees have claimed to hear the echoes of pigs squealing in the distance.", "Six Flags Theme Park", "MO", "Ghost" },
                    { new Guid("c2ee05df-9bf6-4ea6-920a-5f5302cbaa46"), "Rapid City", "now Dakota Junior High -  The heater room said to be haunted by football coach and team that had died years ago in a plane crash. - Update: The story is in 1968 or 69  on St. Patrick’s Day  the cheerleading squad and their coaches were killed in a plane crash at Rapid City Regional Airport while returning from the state AA's boys basketball tournament in Sioux Falls. It was a private plane owned by one of the cheerleader’s father. Now there is an award given out at the state basketball tournaments every year to the cheerleading squad with the best spirit  called the Spirit of Six Award and is in honor of the 6 cheerleaders who were killed in the crash. It is the Third Floor Gym of the school  which is supposedly haunted because that is where they use.", "Old Rapid City High School", "SD", "Ghost" },
                    { new Guid("c31f3534-69e0-4991-8c09-4585a4515ae2"), "Independence", "My passenger and I were driving backroads in the country heading to Independence  and had noticed a light which was not moving. I notic", "Chevron Shape", "OR", "Alien" },
                    { new Guid("c3467551-c528-45a7-a9fe-26477929049a"), "Sweetwater", "The Sweetwater County Library was constructed on an old Indian cemetery. Items move by themselves. Apparitions have been seen.", "Sweetwater Co. Library", "WY", "Ghost" },
                    { new Guid("c3471bc1-2566-4f87-8d3a-84d9b142ddfb"), "To the best of my knowledge  the incident occured in sec. 24 (on the north side of the Tahquamenon River) T46N  R9W Mcmillan Twsp. Luce Co. Mi.", "While sno-mobiling in a remote area of the county in which I live  I noticed somewhat ahead of me something had walked and left this trail of foot-prints or tracks in the snow. I right away thought this is unusual as people just do not venture into this marshy area. Now this is the 3rd week of Feb.  and that winter we had had a heavy fall of snow  and the depth of the snow in that area was around 30 inches. I was able to sno-mobile as the snow had a very hard crust on the surface solid enough to support the weight of the sno-machine without breaking through. So I drove right up on the trail made by something and I stopped and looked down at them. Then I realized these were not black-bear tracks of one coming out of hibernation early  or some person on snow-shoes  or any other familiar thing. These were human bare-foot tracks. The impression left in the snow by whatever walked through there was perfect. The heel mark  the toes  the way the feet taper from wide in the front to narrow by the heel. And thats when the hair on the back of my neck stood on end. A bare-foot giant had walked through there. I saw those prints  and a real fear came over me. And at that time  I had never heard of bigfoot. I had heard of Yeti  in the Himalayas  and Sasquatch in the Pacific north west  but never Bigfoot. I got out of there in a hurry.", "Report 3525: Snowmobiler finds large barefoot tracks in upper peninsula of Michigan", "MI", "Bigfoot" },
                    { new Guid("c3e33415-8fe9-4361-9b58-41c61147f5b5"), "Caldwell", "A long time ago a woman hung herself and if you drive out there at night  and turn off you car lights before crossing over the bridge you will see her shadow up on the side of the bridge. Also many people have jumped off the bridge and you can hear their splashes  but you wont see anything. There is also a light on the island out there that comes on at 7:00 pm every night  but there is not a house or even power lines going out there.", "River Road Bridge", "ID", "Ghost" },
                    { new Guid("c466a5b0-2244-4ccb-ac17-453bb383cd1c"), "Rome", "\"On the road between the main campus of Berry College and the new mountain campus  the 2-mile road is bordered by woods on both sides. In the days before there was a mountain campus  students from Berry would go up into the woods to fool around. One such couple who attended Berry in the '40's is the subject of a tragic accident that occurred at Berry. After making love  the young man and young woman got into an argument  and the boy left his girlfriend in the woods to walk home alone while he drove. After driving a little while  he felt sorry and turned around to pick her up. On the way back  he wasn't paying attention to the road and he hit something. Assuming it was a deer  he got out to look--and it was his lover! She was dead. To this day  students at Berry say that if you go to the spot on the road where the girl died (it is not a bridge) and say  \"\"Green lady  green lady  green lady\"\" that a pale green light will appear in the trees. This is her spirit.\"", "Berry College – The Road between the new &amp; old campus", "GA", "Ghost" },
                    { new Guid("c46a059b-0b7b-4e46-b0fd-5f2b036c66df"), "LaGrande", "There has been many hauntings reported by many......a lot of people died in this place a long time ago.", "Hot Lake Hotel", "OH", "Ghost" },
                    { new Guid("c46b7626-6d39-419f-ae42-6644fb1aee22"), "Smyrna", "development on this road is said to be built on top of an Indian Graveyard. Some things can be pretty creepy at night. Lights glow in the distance and people who live in those houses in the development say that when taking pictures of family and friends orbs appear in pictures maybe to appear to be an Indian.", "Black Diamond Rd.", "DE", "Ghost" },
                    { new Guid("c4b95ddb-da80-459b-88c4-0fdfaad8e1bd"), "Detroit", "Saw in the sky three star sized lights moving rapidly and smoothly in a reverse triangle formation. Checked my phone compass and looks", "Circle", "MI", "Alien" },
                    { new Guid("c4e233b6-ff74-4b31-8df5-cc00dd674069"), "Sugar knob patc cabin on great north mountain on the boarder of va and wva", "Two friends and I were backpacking on great north mountain in the winter of 2002. It was our second night and we reserved a stone cabin from the PATC  named sugar knob cabin  we had not seen anyone all day. There was an ice storm coming and we attributed it to that. We made a fire outside the cabin just before dusk while it was still nice out. We began to hear slow moving  very heavy footsteps walking around the perimeter of the location we were at. We thought it was a bear or a deer but it was clearly on two feet by the sounds it was making. We called out to see if it was a poacher or just someone walking around but no response was given. This is a pretty remote spot and definitely not very visited in the winter months. The walking sounds continued but because the sun was down by now we could not see too far into the woods. We all heard the walking sounds for quite a while and it really freaked us out so much so we abandoned the fire and pretty much locked ourselves into the cabin. All of us had a lot of outdoor experience and had backpacked a lot as well. We had never heard or experienced anything like this before. The sounds got closer once inside the cabin. It is a stone cabin so it is fairly well Insulated from noise. So whatever it was  was large. The footsteps seemed to stop and continue for maybe an hour or so. We made dinner inside and after we ate the footsteps were right next to the cabin  there was a window opposite the door with wood shutters on the blinds that were closed so I opened them expecting to see a person but we all witnessed a dark  very hairy large face looking at us about a foot outside the window. We were terrified  shaking and speechless. The creature took off after a few seconds of seeing us and vise versa. We never heard anymore sounds after that either. We stayed up all night  though just kind of standing guard. The next morning we awoke to ice everywhere and could not find any tracks or evidence of what we saw and heard. We hiked down the stony creek trail to the cars as fast as we could without getting hurt with the ice on the ground. There was a cabin journal at that time and we read it over that night after the incident and read several accounts that were similar to ours. We never stayed there again and this is the first time I have ever told this because I did not want people to think I was nuts or something.", "Report 30006: Hikers startled by encounter at remote cabin near Woodstock", "VA", "Bigfoot" },
                    { new Guid("c51b83e0-1427-4532-a781-56fa2465b95b"), "Lempster", "Horse that got stuck in the pond mud in the dry spring of 1900 haunts this area  has been seen rising from the pond then disappearing.", "Hurd pond road", "NH", "Ghost" },
                    { new Guid("c52e7342-1251-447f-9cd6-139cc4e5acb6"), "Beverly", "A momentary sighting of a large bright circular object flying through the sky.", "Fireball", "WV", "Alien" },
                    { new Guid("c53d8980-627e-4463-9c4d-84af2efed57d"), "I was only 13 at the time and didnt pay much attention to the roads.  The dirt road came down around a hill and leveled off along the east bank of the river.  The other side of the river was inaccessible due to a very steep bluff.  The bottom of the bluff was exposed rock with a slight outcropping from erosion.  About 50 feet up the bluff vegitation began with ever increasing pine trees and vegetation that continued at least another 200 plus yards to the top.  This part of the river was on a long gradual bend that obstructed lengthy views along the river in either direction.  I have fished the river many times as an adult but have yet to find the exact spot.", "When I was about 13 years old I went trout fishing with my mother and aunt on the White river in Arkansas.  We were staying at a motel in BullShoals.  One morning we drove to a remote area of the river to fish via an unkown dirt road.  We stopped to fish a bend of the river.  On the opposite side of the river(west)  was a tall stone bluff with a slight over crop from erosion.  On the east side was flatter land with 12 to 20 foot thin scrub trees about 20 to 30 feet from the water  as the river was low.  While my mother and aunt where fishing off the bank  I decided to try my luck further up river  about 300 yards away and just out of sight with my mother.  While I was fishing along the bank I began to hear rustling sounds in the trees and shrubs behind me.  I looked in the direction of the noise and could see the tops of the these thin trees moving as if something were walking through them and pushing them to the side  but due to the thickness of the vegetation I could not see what was actually moving the trees.  I stood and observed this activity for 2 or 3 minutes.  I began hearing grunting type sounds that were very deep and substantial sounding.  These sounds were similar but different than grunt sounds a bull would make.  The movement of the trees began to appear as if something were shaking the trees at this point instead of moving through them.  It appeared that whatever was making the noises was only about 10 feet inside the brush yet I could not see what it was.  Feeling nervous  I decided I should return to my mothers side and began walking back towards my mother.  As I did  whatever was in the brush moved with me step for step.  As I walked the movement in the trees seemed more forceful with the sounds of large branches breaking as it moved.  When I got within sight of my mother (about 50 yards)  all activity stopped.  I informed my mother there was something in the brush following me  but she shrugged it off.  Within a few minutes we decided to leave as we werent catching any fish.", "Report 7969: Youth hears vocalizations and is trailed while fishing on White River", "AR", "Bigfoot" },
                    { new Guid("c5483c9d-e3b6-491b-85ac-76be26339999"), "Koppel", "\"When traveling down the road at approx midnight  sometimes you can see the imagine of the \"\"headless horseman\"\" run across the road in front of you. He is harmless. Legend has is that he was a civil war soldier who was the enemy. He was caught and decapitated. - February 2004 Correction: The legend the submitter has heard about this road concerns a little girl and 2 hounds roaming the road at around midnight near an old early 1800's cemetery that is there.\"", "Foxwood Road", "PA", "Ghost" },
                    { new Guid("c60b0f80-268a-4dc8-96b6-7409c8741066"), "Napivine", "old bar established in the 1900's the say it is haunted by an old logger", "Frosty’s Bar and Grill", "WA", "Ghost" },
                    { new Guid("c627d154-31de-4da3-9a00-737e1837ed06"), "Woodbury", "Voices of children can sometimes be heard in this 100 year old + former schoolhouse. Also the occassional apparition of an older woman (a teacher perhaps) can be seen in the dressing room areas. Hosts of orbs appear in photos  also with whispy swirls of mist. Theater WILL allow investigations sometimes.", "Sketch Club Community Theater", "NJ", "Ghost" },
                    { new Guid("c65d4c81-ef7e-4130-b4ba-de0ae1753afb"), "Fort Smith", "Judge Isaac Parker  who hanged around 80 people here  haunts the courthouse (that is now a museum). The people he hanged also haunt the courthouse. You can sometimes see the ropes at the gallows sway back and fourth with no wind. Also  you can hear the banging of Parkers gavel in the courthouse.", "Judge Parker Court House", "AR", "Ghost" },
                    { new Guid("c6c8d7df-7573-43d7-9698-1df9de462526"), "Fort Bridger", "There is an old phantom that roams the graves.", "Cemetery", "WY", "Ghost" },
                    { new Guid("c712ceea-cf2b-40be-b8df-be6dfd9c4749"), "Ulysses", "It is haunted by a little girl she walks in a certain hallway near the cafeteria", "Red Rock Elementary School", "KS", "Ghost" },
                    { new Guid("c72223ee-decc-4424-93c2-0de4b582c9c7"), "Decatur", "This old abandoned cheese factory  has been known for its many unexplained phenomena. It is said to be guarded by spirits. Many people claim not to be able to spend much time in this area. It is located in the woods just east of the Kuklehan Mansion. Also it is known for its occult activity.", "Adams County Cheese factory", "IN", "Ghost" },
                    { new Guid("c73726f3-426d-425c-abcd-8f4dd826f961"), "Moses Lake", "Multiple spheres of light slowly zigzagging upwards until they faded away...", "Light", "WA", "Alien" },
                    { new Guid("c73b932f-af8c-4df7-8c6f-a869905e201a"), "Custer", "is said to be haunted by a girl whos father was a miner there be fore it became the play house.  And that the girl haunts the costume room because that’s the room she stayed in.  Some times the costume people will leave the room one night with every thing put away and the next morning on the table will be a costume laid out perfectly.  They say that its the girl who laid it there.", "BH Playhouse – Costume Room", "SD", "Ghost" },
                    { new Guid("c7ad195b-3275-4a19-ab72-0a8d8f424bd4"), "", "\"This is the story as was relayed to the investigator. \"\"Just after dark the witness  which was 15 at the time  and his friend were getting nightcrawlers to go fishing with. Just behind their house  which like many West Virginia houses is rural  their was an old logging road which was covered by very heavy green briars. The witness heard something coming down the mountain through the green briars. He shined his flashlight and saw an enormous animal which was built like a large bodybuilder. He watched the animal from 60 feet away traveling right to left. He watched the animal for several seconds. What stuck out his memory the most was the swinging arms and the hair 10-12 inches long hanging down off of the forearms. The hair in general was mostly straight and dark brown in color with reddish tinge on tips. It really scared his friend and him. The next day based on a sapling they estimated the animal to be 9 feet tall.\"\"\"", "Report 26963: Blacksmith recalls seeing a creature come down a mountainside and shares a sketch he drew", "WV", "Bigfoot" },
                    { new Guid("c7c20b5f-6b1d-4994-8b92-69afc21f52e1"), "It was in the Lavalle Creek area on private lands.", "While horseback riding one afternoon or late morning  I observed a large  black upright creature that was walking along and just below a ridge to the east of me.  As I my horse and I continued to climb up the hill to get a better vantage  the creature apparently realized it had been seen or saw us  and ran back in the direction from which it came.  It was very tall and black.  I thought it was a bear at first  but it was upright and extremely fast as it ran.", "Report 36727: Biologist observes a biped on a ridge outside Missoula", "MT", "Bigfoot" },
                    { new Guid("c810dbfc-93e9-4fac-a7bd-fa644a2d4101"), "Ringgold", "There are many reports of seeing a mysterious set of glowing green eyes from a ghost of a confederate soldier. Even during the war  soldiers had reported him looking over the dead during battles. Also  There is an old tower here that is visible from the main road. The top four steps have a mysterious blood stain on them. People have tried to remove the stains  but to no avail. They always seem to return. A mysterious being haunts the area beneath the stairs at night. - October 2007 additional information: It is believed the mysterious being living under the stairs in the old tower is said to be part sheep and part woman. There have been reports from people who live in the area of a nest that was removed from underneath the stairs in years past. There are a great number of unexplained things in this park. You can feel the ground shake and hear the cannons explode if you listen hard enough.", "Chickamauga Battlefield", "GA", "Ghost" },
                    { new Guid("c8180650-7496-467e-b781-7df0d050df0a"), "Lenoir City", "I was riding in a boat and noticed a very bright pair of lights at about 30 degrees above the horizon I turned to ask my wife if she sa", "Odd Shape", "TN", "Alien" },
                    { new Guid("c865b959-4b12-42c5-b83a-9775aa621094"), "Buckles Mountain east of Garwood  Idaho", "\"While out deer huntning myself and my wife found a set of tracks alongside Forest service road 2302. This road starts on Forest service road 406 and travels for approximately 1.5 miles before dead-ending on a hilltop. The tracks were approximately .75 miles up the road just past a clearing. These tracks were about 16\"\" long and 7\"\" wide. The toe prints were clearly visable. It had rained earlier that morning and had light showers intermittently throughout the morning. The tracks had no water puddling in them and appeared to be fairly fresh. I have been a avid hunter for many years and can distinguish between fresh and old tracks. I never have been a believer in the Bigfoot stories and legends but have since changed my attitude. I didn't really believe what I had found until I took my wife up and showed her. She agreed that they could  in fact  be Bigfoot prints.\"", "Report 15206: Possible tracks found on Buckles Mountain", "ID", "Bigfoot" },
                    { new Guid("c929268c-b65b-4962-9bab-5340cd550786"), "I don't want to include directions in this report.", "\"In mid spring of this year  I was hiking through the woods with a friend in the middle of the night. Making our way up onto a trail  we stumbled upon a picnic table and decided to sit down and rest. We were startled to find the whole ground glowing green around us. Using my headlamp  we attempted to spot whatever was causing these little glowing green dots. At the time we had no clue what was causing this to happen  but we later realized that firefly larvae were lighting up the forest floor. Seeing the glows coming more intensely from a nearby hillside deeper in the woods  we decided to scan the the hillside with our headlamp. As soon as we shined the headlamp  we caught a pair or grapefruit sized bright green (with a slight hint of gold) eye reflections peering over the crest of the hill. We stood in shock  never removing the light from those eyes. \"\"Maybe its a deer \"\" she said. A few moments later the eyes raise up to be about 5 off the ground and rotate slightly more towards us. \"\"See \"\" I say  \"\"It is just a deer.\"\" As soon as that last word leaves my mouth the eye reflections stand up another 4 feet to be standing at a towering 9 feet. It slowly occurred to be that I had never seen eye reflections of this color and that the closest thing might be a bear. Suddenly I hear a slight rustling behind me. Swinging the light around we caught the reflections of two more sets of eyes. They too were grapefruit sized and green  but were spookily sneaking up on us from behind. I get caught in a frenzy of shinning the light back and forth between all three sets of eyes until they just quietly disappear. we hurried out of the area  terrified  and made our way south to a different hiking area to take the whole situation in. Again we noticed firefly larvae  but when we began to approach the woods (which in fact are connected to the last area by water system) a bunch of creatures began running around in the woods  breaking branches and shaking bushes and trees. Later  upon watching one of your videos and discussing the experience with some knowledgable peers  I realized that I had experienced a sasquatch encounter.  Returning to the same spot some 2 or 3 months later with a few buddies  we were able to catch the same eye reflections for a very short period of time.\"", "Report 30634: Night hikers possibly stalked near Bee Tree Preserve", "MD", "Bigfoot" },
                    { new Guid("c9491e71-853d-46d4-aeb8-107357faefc5"), "Redding", "a small field on the right of the train tracks before the overpass usually at night orbs of light and a lit tent vanishing.", "Topstone Rd", "CT", "Ghost" },
                    { new Guid("c962eb5f-6649-497e-a4d9-b0c05249f41f"), "Sitka", "Bright white light with some blue and possibly red. Traveled left to right in the night sky in an up and down zig zag type movement.", "Light", "AK", "Alien" },
                    { new Guid("c9c783f2-d838-4889-9db8-668d62ba80c7"), "take hwy.50 east out of Carson . turn left onto 431 through Silver City just before you get to Gold Hill there is a drive to the left across from New York mine. siting was at old mill site at American flats in ravine just south of ruins of old mill.", "\"I was a reserve deputy sheriff for Story co. Sheriff's office. I was employed by Houston International Minerals Corp. at Gold Hill as their on site security supervisor. I had worked the day shift. I had ran some kids out of the old mill at around 3:30pm on 09-15-80. I was showing my swing shift officer the area I had ran the kids off from. We were in the security vehicle parked on the high side of the southside of the old mill (Gold Mining). We saw that the boys  (four of them) were running back down the ravine to the creek below. it was 4:15pm. As the boys reached the creek they must have scared a group of girls at the creek bottom because they started screaming. there was a lot of noise being made by both the girls  and boys laughing  and yelling. At first I thought they had scared a deer west of them near the rock outcrops. Then I thought  no it's too big to be a deer. I could see it moving amoung the trees heading up the other side of the ravine at a very fast pace. I thought it must be a lone mustang as I watched. My secutity officer got the binoculars from the seat and said \"\"OH MY GOD\"\" I looked closer  and realized it was not a mustang. I was looking at a large greying/ brown man shape thing about ten plus feet tall. It was obviously male. because of it's build. As it cleared the trees near the top of the hill I could clearly see it. It was covered with hair from head to toe. Greying like a person in their fifties. It was at least three feet across at the shoulders. At the crest of the hill it turned to look back down the ravine. It was maybe a hundred yard across the ravine. I had an unobstructed view at this point. It stood on the hill top maybe a minute looking back down the hill  then turned and moved over the other side of the hill out of view. We drove over to where we had seen the thing last (about a two mile drive on dirt roads). It's was about 4:50 pm by then  We saw no further sign of it  but was able to establish that the thing was standing next to a tree that was 11 feet tall  and it was just as tall as the tree we saw.\"", "Report 3455: Two security guards see a creature outside of Gold Hill", "NV", "Bigfoot" },
                    { new Guid("ca298d6b-a94a-4307-89a0-ef7a7bebf952"), "Brookings", "4 disks appear getting bigger and bigger than disappearing", "Disk", "SD", "Alien" },
                    { new Guid("ca2f5197-53d6-41a3-82cd-b58a043dbf6d"), "El Paso", "The building is aged back to the 1920's and supposedly served as a hospital to war veterans. It's said that on the second floor that a child not knowing the history the building had witnessed a man walking down the hall with bloody gauze on his head and amputated arm.", "Crockett Elementary", "TX", "Ghost" },
                    { new Guid("ca496890-ce1a-4222-a2aa-cc82472d8f19"), "Pangburn", "\"The night sky was overcast and the Red \"\"star\"\" I saw was the only light in the sky. It stayed motionless and then flickered out.\"", "Circle", "AR", "Alien" },
                    { new Guid("ca6cbd66-d6a8-4813-9d17-af5fc116067a"), "Millington", "This used to be a gunpowder factory during the world wars. Most of it is under ground and a lot of tunnels. Rumor has it that it was used by an old crazy homeless man to kill and hide his victims. The factory is off limits but you can see the stacks for miles. rumor has it the woods are haunted by the old mans victims and the tunnels are haunted by the old man himself", "The Smoke Stacks", "TN", "Ghost" },
                    { new Guid("cb286981-557c-49b4-8535-9fed11b3c394"), "Vicksburg", "The mansion was used as a hospital during the 1863 siege of Vicksburg. There have been sightings of Union and Confederate soldiers  as well as former owners.", "Duf Green Manson", "MS", "Ghost" },
                    { new Guid("cb37845a-ff40-4380-b740-0ddc4141e504"), "Bullhead City", "Believed to be a passing for frontiers  many say the grounds are haunted. City Hall now stands in the haunted area.", "City Hall", "AZ", "Ghost" },
                    { new Guid("cb7b16bd-fead-4c14-aa41-b91c19ac8819"), "Vicksburg", "this is where parts of the civil war was fought. if you go around 1 o clock in the morning you can still see the soldiers battling  you can also hear the gunshots.", "National Military Park", "MS", "Ghost" },
                    { new Guid("cbca0cd0-9a68-4526-8dca-2bf6ae98141c"), "Tupelo", "The object was a football shaped object with no lines it had a pulsating green haze and a trail of green light.", "Disk", "MS", "Alien" },
                    { new Guid("cbee05d9-953b-4434-a5be-6d14694e6e8a"), "Canyon County", "Old Saratoga Hotel/Restaurant - It is said that the upper floors  the restaurant and bar areas were haunted. Reports of a chilling cold feeling upon opening doors to some of the guest rooms. Many nights  employees that were left to close up after hours experience moving chairs  swinging glass racks  and footsteps. After demolition of the ruins  a new office strip mall was built and many employees complain of strange noises.", "Caldwell", "ID", "Ghost" },
                    { new Guid("cc309355-2aff-48f4-9059-eb30cb5b7576"), "Brunswick", "What I saw was a bright flash of gold light that appeared in one part of the sky  it died down and apeared in adifferent part of the sk", "Light", "ME", "Alien" },
                    { new Guid("cc3b489f-2c47-49da-b211-231c9c877cdf"), "New Haven", "The object slowly climbed up just above the horizon  disappeared  reappeared some distance away  and disappeared again.", "Sphere", "WV", "Alien" },
                    { new Guid("cc4d7065-9a7b-4adf-9414-ae814d2da971"), "Killdeer", "Highway by Killdeer - On some nights people in car's drive by and there and cars break down and then they say a hoof man comes out or you see someone on or near the road", "Lost bridge", "ND", "Ghost" },
                    { new Guid("cc8f4e0b-6026-4748-ba2e-239afe4bf6db"), "Crofton", "I heard a strange noise in kitchen.I thought that my cat knocked over the trash bin again.So I whipped my silk rob on  and walked down", "Odd Shape", "MD", "Alien" },
                    { new Guid("cd07676d-8de3-45db-9cfc-2eb6d7a5b70e"), "Villa Rica", "Crown shaped object seen 1/4 mile away moving fast just above treetops. Metallic  smooth with silver color.", "Odd Shape", "GA", "Alien" },
                    { new Guid("cdb19e5f-aebe-43da-b4de-8cf1bb3f34ed"), "Baltimore", "The Fort was used throughout history in guarding Baltimore Maryland. Many stories of ghosts and ghostly activity include: a shadowy figure marching along the parapets  an evil spirit in the hallway leading to the bathrooms  floating or moving furniture  tour guides during the Ghost Tour being surrounded in unearthly light  and voices heard by employees after the Fort has been closed to visitors. The stories are well known by local residents and many people who worked at the Fort or visited it can attest to these occurrences.", "Fort McHenry", "MD", "Ghost" },
                    { new Guid("cee61b6e-227b-4746-8d88-36cbb7177126"), "Gallup", "The old house is said to be haunted by a little boy named Billy. Who had an unfortunate death while playing in his room. He is said to live in the closet of the front bedroom  and is a friendly ghost that has played with children that have lived in that room.", "old house on Aztec", "NM", "Ghost" },
                    { new Guid("cf000c20-5408-4fb1-8a4a-673014b692f1"), "Harwinton", "Massive black triangle with curve corners  a red  yellowish  and blue round set of lights under each side hovering overhead", "Triangle", "CT", "Alien" },
                    { new Guid("cf58a105-4118-4d97-b66a-22ea8ad2eec4"), "Deming", "in the basement their are loud sounds up stairs computers turn on by it self.", "Deming Middle school", "NM", "Ghost" },
                    { new Guid("cf93d91f-d4cc-4120-b32f-4880dfbe322d"), "Ansonia", "to be honest just weird things but they only happen when you are the only person there whether in the basement or on the top floor there is a history here check into it.", "Eagle Hose Co. #6 (firehouse)", "CT", "Ghost" },
                    { new Guid("cfb5412e-53ac-4b54-9b81-8d92f81ea1cf"), "St. Cloud", "For years it's been reported by night employees that a man who is either dressed in a white shirt and bow tie or a printer's shirt appears in the basement of the building. Sometimes the sound of banjo playing is heard. He's been known to tamper with office equipment and lights from time to time.", "St. Cloud Times", "MN", "Ghost" },
                    { new Guid("cfb8ce09-d02b-48cf-974d-f99fa9822019"), "This is probably not accessible now- we were able to walk back to the area due to everything closed by COVID.  Parked at the rail yard  crossed tracks and walked through the salvage yard area (unused railway equipment).  Followed path to Chama river  crossed at a rocky ford. Continued on the path along the river approximately a quarter mile.", "Summer of 2020 (quarantine year)  in late July  I was hiking with a friend along Rio Chama.  Although we were just on the other side of the river from town  the railroad was not running  the campground was closed  and the majority of the town was empty. This was a short day hike as we are seniors. We had a dog accompanying us (pit bull mix) for part of the way.  Before we reached the river we had to return the dog to the car- she became unusually excitable and fearful. Note: my friend and the dog live up on the mountain  the dog is used to wildlife and has treed a bear before. Anyway  windows down and dog much happier  we returned to our walk.  We had crossed the river and was on the trail that runs by the bank when we heard a series of hollow knocking sounds.  These were loud and resonate  not woodpeckers or falling branches.  A short time later they were repeated at a distance- the knocks sounded lighter in tone  like a hit on a more solid wood.  The knocks close to us responded- and we decided that it was in our best interest to leave the area.", "Report 69437: Possible Sasquatch wood knocks in forested riverbed beside Chama during lockdown", "NM", "Bigfoot" },
                    { new Guid("d032484b-04d1-4a51-8883-0cb5524713bb"), "Rathdrum", "Small floating light/disk. Hovered for about a minute getting brighter and duller. It then started to move further away and disappeared", "Light", "ID", "Alien" },
                    { new Guid("d038fa5a-16e6-4d48-9a89-2d0d5a30873a"), "Danbury", "Several hauntings are known to exist on the grounds - mainly around the area of the abandoned Hearthstone Castle. There have been reports of shadowy figures  glowing orbs or mists in the castle's windows or on the roof - as well as the surrounding land and the locations of the former servant/guest houses.. Some hikers have reported being pushed & sticks thrown at them.", "Tarrywile Park &amp; Hearthstone Castle", "CT", "Ghost" },
                    { new Guid("d04aa9db-044d-4f16-bfcf-3a1189c6704a"), "off hwy 72 you will see baker lane  go down baker lane you'll see emmette holland road  go down that road it'll open up into fields and woods and you are there", "well me and my cousin were deep in the woods deer hunting close to our little camp site when we heard some very loud popping sounds maybe 35 yards away  we froze  tried to figure out the sound but couldnt. We started walking it was getting late almost dark we started to smell something. It smelled awful deader than dead my cousin hears something walking heavy  we turn around look down the logging road and see this thing step out of the treeline  it was a good 40 to 45 yards away it had dark brown hair  walked on two legs was very big 9 to 10 feet tall and it just stood there. Out of being so scared we couldnt move either  I couldn't of shot it if I wanted to but we stared at each other for about 3 or 4 mins and when it took a step into the woods we ran. 1st time ever saw anything like that. I told some people but they laughed and asked me how much I had been drinking but I dont drink so I saw the sight and decided to get this off my chest. I've been holding for years and I havn't been deer hunting that far in the woods since.", "Report 27568: Daylight sighting of a Bigfoot outside Muscle Shoals", "AL", "Bigfoot" },
                    { new Guid("d0901372-1004-4d75-aba4-8ecfff1b52c2"), "Cornfield sink 2000' SSW of the Blue Hole 3 miles NE of Rocky Lane", "Two friends of mine and myself were pushing a cave lead in Cornfield Sink on the east side of Pigeon Mountain. We came out of the lead at about 3:00AM and started gathering our caving gear together for the 1/2 mile walk to the car. As we are about to leave the strangest call I have ever heard came from the opposite side of the sink from us. Distance would have been about 900'. The three of us have been woodsmen all our lives but none of us had ever heard a call like that. It sounded like four different animals in one. All powered by what must have been an enormous set of lungs! Hearing the vocalization the three of us looked at each other saucer eyed not saying a word. Each of us was hoping the others would pipe up with a logical explanation for what we had heard. Needless to say since we had been planning to leave anyway we beat a hasty retreat to the vehicles.", "Report 11030: Cavers hears possilble vocalization on Pigeon Mountain", "GA", "Bigfoot" },
                    { new Guid("d0c9acd0-4730-45df-988f-20960af4009b"), "Middletown", "A young boy was said to have died in the house in the early 1900s. The house is 152 years old. Lights  TVs turn themselves on and off. One night the toy train in the sunroom began to go around the track all by itself  and voices have been heard. Feelings of not being alone when you walk in the house is common! At night the house is never quite  squeaks and thumps are heard.", "Locust Grove Farm", "DE", "Ghost" },
                    { new Guid("d10ef606-8766-4131-9036-31e4a5e03cd3"), "Anchorage", "The Korean owner of this place was killed by Chinese weightlifters in 1999. The owner's spirit is sometimes seen peeking out the window.", "The Little Karaoke Place", "AK", "Ghost" },
                    { new Guid("d111fbbb-ca43-49b6-a49b-0284e4b046a9"), "On the main trail toward the glacier  before the stream about 1 mile past the Kennikot settlement at the abandon dynamite shaft.", "My hiking partner and I arrived late to the Kennikot area. We were trying to make it to the camp sites near the glachier but it started getting too dark even for us . So we decided to camp at the first available site . We found a small spot right off the trail so we made camp and hung our supplies in a tree down the trail   started a fire and were just finishing a small meal when I walked to the trail to smoke. I was standing on the trail a few minutes when I noticed what I thought was a man on a bike coming down the trail. I let my partner know  but when I looked back it was still in the same spot. I started looking more closely to see a face or the bike or something. It was then I realized it wasn't a person. It was a large dark form legs spread apart  this is what led me to think it was a person on a bike. The arms were curled at it's side like someone with hands on handle bars. Too big for a bear and the legs were too far apart. I called my partner but when turned back to look at it again it moved very quickly into the woods on two legs. The next day we looked but found no evidence of anything on the trail. I've told this story to a few people but they all think I'm crazy. I hope that this helps. I know what I saw  I guess I'm just hopeing somebody belives me....", "Report 637: Campers' encounter just after dark in the Wrangell - St. Elias National Park and Preserve", "AK", "Bigfoot" },
                    { new Guid("d11c812a-e957-4efc-bb28-c0a315cb9692"), "This sighting occured in a community in Central Louisiana. Outside the city limits of Pineville near a swamp area. Between Hwy 107 and Hwy 167.", "This was in the early 80s late spring early summer. i was still in High school ( Graduated in 1983)  Myself my two brothers and my best friend and his two brothers were in a field with our dogs goofing off on top of a hill over looking a swamp bottom.We had been talking about and wondering why the cattle that stayed in this field never went to certain part of the field.( the area we were looking at).(We jokingly called this the Devils corner because of this).On this particular day the cattle had wandered into this area and were grazing. After about 10-15 mins of us sitting at the top of the hill talking about this we noticed that a few of the cattle looked very anxious and were looking toward the fence row that bordered the swamp area. We all started getting excited that the cows were scared of something  when all of a sudden the herd startled and began running up the hill out of that corner and bottom. Since we were in their path we moved and watched them run back to ward the south end of the field. Being curious we gathered up some weapons (logs sticks rocks) and decided to go see what was there  not expecting to see anything. We crossed the bottom and started toward the fence row.We noticed that it was extremely quiet in that corner of the field . We began to look around when we noticed some reddish hair stuck to the barbs on the fence.Then thought hey there are no reddish colored cows so why is this hair this color and on the top row of 4 row barb wire fence ( fence was 5 ft at the highest point) we then heard something moving in the woods (very thick and dense lots of thorns)where the hair was at. At this time i noticed that a pine tree roughly 5inches in diameter had been twisted and knocked over about 8-10 feet up.We hadnt had any storms recently and no other trees were damaged. We decided we should leave.As we started to leave my the younger boys threw there stuff down and began running me  but me and my friend didnt. I then had the feeling that we were being watched i asked my friend if he felt that as well and he said yeah  i turned toward the fence to see a face about 7ft up standind next to the broken tree i asked my friend if he saw it as well and said uh huh  we stared at it for about 2 mins before we ran away. What i saw was 2 eyes a gray/white color with reddess hair the top of the head was hiddien by brush the bridge of the nose was very apparent straight long and narrow the rest was hidden from view. After that we never said anything about it again.About a month later my friend decided he was going back in there to look around with his dog.(this is the same dog that was with us the first time and acted very afraid and this dog has chased many animal in that field) I wnet to the fence row by the broken tree with him but told him i was not going in there with him and that id wait there for him.He said he'd be back later.After he crossed the fence i lost sight of him about 5ft in. No sooner had i lost sight of him i hear movement to the left of the spot he went in  shortly after this i heard him come running back to the fence row  he was yelling i saw it  i saw it..he jumped that barbed wire fence in stride with his dog hot on his heels. From that day on we never went to that area again. Later on that fall we had found a calf in the swamp that had been ripped open and the guts had been pulled out but not eaten.We passed it off as wild dogs or coyotes/wolves. Later that winter we had a snow (unusual) and again found another calf that was the same way but in another area of the field. We also passed this off as wild dogs  coyotes/wolves. But since reading about the deer kills in other states i began to think that these calves had been done the same way.We never talked to anybody about what we saw.Except the calves. That wooded area has since been cleared/thinned and but the swamp is still there.This swamp has access to Bayou Marie Cedar lake  and the Red River.My parents still live there so i visit the area every month.", "Report 1461: Witnesses saw Creature next to a Broken Tree", "LA", "Bigfoot" },
                    { new Guid("d1311c7e-86b3-4951-867d-0480668886e4"), "Sheldon", "It is said that if you walk into the graveyard at 12:00 midnight you can see a white shadowy ghost floating in the air.", "9th Street Graveyard", "IA", "Ghost" },
                    { new Guid("d1597205-d237-4447-ae61-c4581cba3f93"), "Zwolle", "There's a story about a woman who had a baby and her husband or boyfriend took her baby and killed it. The woman went looking for the baby and found the man in a boat with the dead baby. After that no one knows  but the story ends with the woman known as the Crying Woman  walks around Grady Hill crying for her baby. People all over town have heard her crying and some have even seen her.", "Grady Hill", "LA", "Ghost" },
                    { new Guid("d19ff9d8-e3af-4e3a-b697-8c265f809957"), "Calls came from south west of Westwood Dr.", "Westfield   MA 3am Couldn't sleep and went outside to have a cigarette. Heard howls in the distance that I never heard before. I've worked as a wilderness counselor for the past 10 years and heard all sorts of animal noises in the night foxes  coyotes  owls etc.. This sound had a lack of clarity but power in its voice. I knew that it came from a long distance away. I remember listening to Bigfoot calls years back and on a hunch ran inside found the EXACT same howls on the net sounded like the Snohomish  WA 1978-79 calls. I woke up my friend who has been hunting western mass for 30 years and he said he never heard anything like it. He heard it and he said it gave him the chills. The howls trailed off as if he creature was moving. Incident lasted for about 10 minutes. I google mapped the area the sound came from and its a huge swath of wilderness that stretches into Vermont and south into Connecticut.", "Report 28667: Resident hears possible early morning vocalizations near Westfield", "MA", "Bigfoot" },
                    { new Guid("d2195b10-7a7a-4ef9-8840-a88247378c22"), "Burlington", "Simpson Hall -  a spirit of a man who stalked a girl  followed her to her dorm one year. He now resides in Simpson. Late at night students wake up with a sense they are being watched  usually the room becomes icy cold when it happens. Very rarely some wake up freezing at night with the feeling that there is someone else in there bed.", "University of Vermont", "VT", "Ghost" },
                    { new Guid("d2205306-b823-490d-b672-46c2ac9f2564"), "Portland", "I was driving over the burnside bridge into downtown Portland  A metallic green fireball very slow in nature. slower than the dozens of", "Fireball", "OR", "Alien" },
                    { new Guid("d2b187a3-aa98-4488-8a97-ceb9d0d920c0"), "Between Springdale Center Road and Town Hall Road.", "This happened almost 24 years ago  but it has never left me in all these years.  And I have never told anyone about these two incidents.  The first incident happened when I was bow deer hunting during the early season  as I remember that the leaves on the trees were still green.  I had returned to my car that was parked in a nearby field and got my hunting gear put away.  I then sat in my car waiting for about 10 minutes for my hunting friend to return so that we could go home. When he didn't return (he did return after the incident) I got out of my car and walked down close to the edge of the woods  maybe about 10 feet or so from the edge of the woods  shortly thereafter I heard something coming from my left just inside the woods edge.  It was making a lot of noise as it was walking through.  I thought this was my friend coming back  but then I thought that this  was “very odd” for my friend since he was really quiet in the woods.  As the “walker” was about right in front of me I called out my hunting friend's name to which I received a rather loud “guttural growl”.   But what ever the “walker” was it did not break stride  it just kept right on walking rather loudly away from me going parallel with the edge of the field just inside the woods edge.  I have listened to over and over again the bipedal walking audio on the BFRO website - http://www.bfro.net/avevid/sierrasounds/911.asp#bipedal . It sounded just like this  but add in some very loud branch breaking and you will be very close to what I heard that night!!!!! I'm 6' 2” tall  and when the “walker” did its loud “guttural growl” when it was right in front of me it sounded like it was at about the height that my head was at.  I would estimate that the place in the field  that I was standing at was about two feet higher than in the woods where the “walker” was at. The second incident that took place happened in the same location  but about 200 yards from where the first incident happened about a week  or so earlier.  Both times I had been hunting from the ground. The hunting friend that was with me from the earlier time was also there along with my sister's boyfriend.  We split up with about 3 hours of hunting time left.  It was really quiet for about the first hour  but then things started to change.  I heard all sorts of noises that I can't explain nor identify that happened in front of me from about my 10 o'clock position to about my 2 o'clock position.  I did see what appeared to be something walking into the thicker part of the woods.  This looked like the arms and legs of something going from the more open part of the woods  to the more thicker part and was about 40 yards away from my location. After seeing the arms and legs of whatever the things were  the tops of the smaller trees started swaying violently back and forth.  This went on and off for about a ½ hour to 45 minutes.  What really scared me was when the rocks started to be thrown in my direction.  The size started out as about golf ball size  and by the time that I “turned tail” the size was about softball size. I would describe the color of what I saw of the arms and legs to be about a rather dark red to almost black.", "Report 41734: Bow hunter recalls being shaken by possible incidents near Mount Horeb", "WI", "Bigfoot" },
                    { new Guid("d2ee8486-6b1b-46e0-b542-790d91850a3a"), "It was on Apricot ave. about half mile from the San Joaquin river.", "While riding our bike just after sundown my dogs started going crazy  I looked at my dogs and saw that the hair on their backs was straight up.  I looked in the direction they were barking and standing in a suger beet field thirty to forty feet away was a humanoid figure covered in long shaggy grey hair.  This thing was massive and I would imagine it was at least eight feet tall.  It didn't move - it just stood there looking at us.  Needless to say in 1962 I didn't know what bigfoot was so I turned my bike around and got the hell out there. My dogs a collie and an Australian shepherd beat me home.", "Report 25009: Youngsters encounter large  grey creature in a sugar beet field", "CA", "Bigfoot" },
                    { new Guid("d390716f-94f1-4da1-b34e-6eb6f55f7d25"), "Point Pleasant", "I saw a large triangular craft with 3 non flashing/blinking lights just above my car.", "Triangle", "WV", "Alien" },
                    { new Guid("d3ea9384-7202-493a-9110-47c2e24f1f58"), "Conneaut Lake", "A hotel in an amusement park. It caught on fire and a young bride named Elizabeth was killed. they say that she is still seen in the hotel.", "Hotel Conneaut", "PA", "Ghost" },
                    { new Guid("d408c857-8ea9-4407-a55a-35783c29d25e"), "Phillips", "Field and woods light up by a red light that has no source. Light seems to scan area for about a minute. Object turns lights on and lan", "Unknown Shape", "WI", "Alien" },
                    { new Guid("d41ad3e4-438a-4806-a675-e69818470b43"), "Flemington", "Red light that moved back and forth  hovering each time it stopped before moving back again.", "Light", "NJ", "Alien" },
                    { new Guid("d4eff746-acf5-4f38-8f39-c1d162722bba"), "Highway 17...Rio Grande National Forest...midway up the grade rising from a small bridge over the Conejos River to La Manga Pass.", "\"We were on Highway 17 in southern Colorado  heading south through the Rio Grande National Forest toward Chama  NM. As we neared the border  Highway 17 began snaking up a five mile grade beginning at the Conejos River and cresting at La Manga Pass (10 230ft). Midway up the grade  we pulled off at a turnout to take a break and survey the surrounding forests  enjoying the view the elevation afforded us. The morning was quite brisk and one of the individuals in our party let out a \"\"whoop\"\" as we exited our vehicles. Soon after the echoes of the \"\"whoop\"\" had faded into the distance  we heard what sounded like a very loud roar (made by some type of nearby \"\"animal\"\")  unlike anything I'd ever heard before  that lasted for several seconds. Following a short pause there was another roar  then a pause  and then a final roar. The \"\"roar\"\" can best be described as being almost exactly that (sound  duration  pausing) which is currently found on this website  listed as a potential Bigfoot \"\"howl\"\" recorded in Ohio. In fact  listening to the \"\"howl\"\" and noting the distinct similarities to the \"\"roar\"\"  is what prompted me to submit this report. In the silence following the final roar  I felt the hair on the back of my neck stand on end and uttered the only thing that came to mind at that point. Namely  \"\"What the hell was that?\"\" And  needless to say  I apparently wasn't alone in my thoughts as  with minimal discussion  our group quickly departed. In retrospect  even though we were seemingly alone on the grade  someone could have been playing tricks on us. Whatever  whether it was someone or something  the \"\"whoop\"\" issued by a person in our party is seemingly what precipitated the sounds we heard.\"", "Report 407: Possible vocalizations heard while motorists were taking a break at turnout near La Manga Pass", "CO", "Bigfoot" },
                    { new Guid("d4f292b5-7fad-4c9a-b2da-9d87c15e0665"), "Natchez", "The Post House used to be an old post office in Natchez. It has been the home of several restaurants since that time. Everyone swears that the second floor is haunted by a ghost named Madeline.", "The Post House", "MS", "Ghost" },
                    { new Guid("d5161dc6-1941-4dc0-8c6f-4a636f0cfb8c"), "", "Years ago I had a strange experience as a kid. I was ten years old and I remember it was the summer time. My bedtime was 8:30 so I knew this had to have happened later in the evening as I was already in my pajamas. It was dark outside. My ex-brother-in-law had an old pick-up truck that he was always having problems with. He called my mom and asked if she could come get him as he had broken down. We got into the car  me in my pajamas and we headed out one of the country roads that is east of Norris. As we got nearer the creek (Middle Fork of Copperas Creek) and woods there is a curve in the road. After coming out of the curve the headlights shined onto something that was crouched down behind the fence and near a fencepost. We couldn't tell what it was but it's head did stick up above the four foot fence. It appeared to be watching my brother-in-law whose truck was just ahead of us. When we got to the truck we told him about it. He grabbed a rifle he had with him and strapped a flashlight onto it with some duct tape. I went with him as as he took off to see what this unusual creature was. He moved his flashlight back and forth near the fence and that is when it stood up. It was really tall and was on two feet. It immediately took off running into the woods that were close- by. In two or three steps it was gone.", "Report 28714: Memory told of seeing a bigfoot on the side of a road along Middle Branch Creek", "IL", "Bigfoot" },
                    { new Guid("d537b773-04af-4947-9a7c-a45ac55e187f"), "Union", "UFOs travel nightly over my property and house. Usually it’s quiet and I only see because I’m looking outside.", "Rectangle", "IL", "Alien" },
                    { new Guid("d5b35230-b0d4-4222-bf36-dc3f6230178d"), "The place is a U.S. Marine camp  it is outside of Quantico base  if my memories serves me right it was camp Geotche.", "While I was a Marine stationed at one of the schools demostration camps in Quantico VA I observed something that looked like a bear while walking my post  what alerted me was a dog that use to walk post with whoever was on duty at night  when she started to bark I looked up and saw a figure that was about 7 feet tall had light brownish hair on it's body  was not able to see the face due to the darkness of the wooded area  but when I told the dog to go after it  the figure just stayed there and didn't move  but when I put a round in the chamber of my M1 it took off running  I never saw it after that  I asked some Marines that came from that area if there was an animal that looked like my description and their remark was  what did you have to drink  I really never paid any attention to the matter until years later I started to see stories of big foot  I am hoping that my story can confirm someone elses sighting in that area.", "Report 679: Marine had late night sighting on military base in Quantico", "VA", "Bigfoot" },
                    { new Guid("d5d89bcb-9ce0-422b-8463-a4f47cd0e339"), "Baltimore", "Six Flags America -  Believed to be haunted by the Hall Family (original owners of the land.) Behind The Wild One  Hall Manor house sits partially hidden. This area is off-limits. A grave that marks the only daughter of Eleanor Hall She died on her birthday. On that day in June  rides malfunction and other problems occur more than usual.", "Upper Marlboro", "MD", "Ghost" },
                    { new Guid("d5f37cbf-314d-4e39-abef-ebd5629f9e00"), "Fayetteville", "The orb was bright in the sky  it descended in front of the four witnesses. Craft was visible long enough to record video footage.", "Sphere", "NC", "Alien" },
                    { new Guid("d5f9c101-6947-427d-969c-1a105395aad1"), "Cranston", "Guards have reported seeing a man jump off the side of the building of Maximum Security.", "Rhode Island Prison", "RI", "Ghost" },
                    { new Guid("d604d0f7-4cc6-49e3-a784-cbaef88ced47"), "NNW end of Three Lake Wildlife Management Area Keenansville  Florida Approx. 6 miles west on Williams Rd. then north 2.85 miles on Rd. #1. Road #1 runs parallel with the Florida Turnpike and is approximately 1.25 miles east of the Turnpike at the point of sighting.", "Witness and a friend were deer hunting that day. They were resting by their vehicles at approximately 1:30 pm when the witness looked north on the road (Rd. #1) and observed 2 Bigfoot crossing the road from west to east. The Bigfoot crossed from an oak hammack into an area of pines and tall palmettos. Approximately  225 yards east through the pines is a large swamp. The witness and his friend were roughly 2/10  of a mile away from the creatures when they crossed the road. The witness saw a large male  6.5 ft. tall with light brown hair cross the road first. When the witness first saw the male he thought it was another hunter walking around without an orange safety vest on. The witness states that it was walking weird and slightly hunched over. When the second one came into view (5.5 ft. tall) it was completely black and had breasts. She also appeared to be carrying something about her waist with both hands. The witness feels she was either very pregnant or carrying a young Bigfoot. The male was 15 yards in front of the female. The witness states that the female had hairy breasts and that both bigfoot walked without locking their knees.", "Report 733: creature observed walking weird and slightly hunched over.", "FL", "Bigfoot" },
                    { new Guid("d612676d-8a02-4c08-93bf-6ba39c2f1e1c"), "Land is owned by the Monocacy Hunting Club.", "\"My friend and I had been searching for a place called Dickerson quarry in Dickerson Md  and had just located it on a map. We had to park on some railroad tracks by the aquaduct and walk through some very dense sticker bushes and overgrowth to find the place. To describe the quarry  it is located in the middle of the woods. It is about 75 yards long and about 30 yards wide with very tall cliffs  about 50 to 80 feet tall in some places. However there are a few places where you can walk down to the waters edge. As we were approaching the quarry  we heard this very loud screeching sound coming from about 25 yards away in the overgrowth. It was very loud and it actually startled us when it first started. The only way to describe the sound would be to say it sounded like a pig getting slaughtered. We stopped walking and waited but it stopped  whatever it was. We continued walking and found the quarry  hearing the strange sound several more times  always coming from a different place. We made a survey and located a place to go down to the waters edge to sit and rest. As we made our way around the quarry we heard the screaming again. Actually coming from the area where we wanted to go! We were not too alarmed though  being curious and stupid. We made it to the waters edge and sat down and started to look around and check the place out. I had picked up a stick off the ground and got out my pocket knife and started to carve on the wood. Suddenly there was a very large splash in the water. It sounded like a person had just jumped in but when I looked up could see ripples in the water where something had gone in. Figuring it was a rock falling from the cliffs we began talking again. About 5 minutes elapsed and we heard another splash. This one bigger and it was very far away from the edge. I asked my freind \"\"Did you throw something in?\"\". He said no  he was looking at me. We looked around to see if anyone was there that we didnt see but there was no one anywhere. We sat for about 5 more minutes talking and then heard another big splash. Neither of us saw what made it but the disturbance in the water was so big we guessed it had to be something big! We started to think that someone was in the woods and didnt want us trespassing and was trying to scare us off. However as we started to really think  we became aware there was no way anyone could throw any rock that big  that far. So we made the choice to go ahead and leave. As we were climbing up and out of the quarry another splash came from very near where we had been sitting and also sounded very big. We reached the top and started to make our way to the car. We only walked about 20 feet when something came crashing through the tree branches and hit the ground near us very hard. It sounded like a 20 pound rock hitting the ground. At that point we both stopped walking and turned and really looked hard into the woods. Neither of us saw anything. As we stood there listening  I swear Ive never heard the woods more quite in my life.  We started to walk again and the objects being thrown at us started to get alot more accurate. I remember saying to my freind \"\"What the hell is going on?\"\" His response was to tell me GO!!! We took off running and reached our only real obsticle  a creek about 10 feet wide where we had to cross on a log. I went first and he was close behind. As we where halfway across the log something landed in the creek about 5 feet from me that had to be the size of a paint bucket. I didnt see if it was a rock or what but it was big. At that point I jumped for it and hit the ground running with my freind right on my tail  neither of us looking back. I have never really felt scared like that  but that day I had the thought that we might meet something that was beyond nature and not live to tell about it. Our journey into the woods took about 30 minutes due to the high growth of pricker bushes  Our journey out took about 3 minutes! We reached the car and the only after the adrenaline wore off did we realize we both were bleeding nicely from running top speed through summer overgrowth. At the time  I didnt know about the connection between the rocks being thrown at us and the screaming to bigfoot  but it sounds like a classic case. Ive only been back a few times since then and only in the winter where I can see for 100 yards!!\"", "Report 10778: Vocals and thrown objects experienced by two friends exploring", "MD", "Bigfoot" },
                    { new Guid("d6aefa3a-991c-4b36-b229-8a689197a6de"), "Paducah", "In the little-kids playground  through the gates  you will be talking and back around the corner you can hear the sound of a bike being slammed up against the gates  but when you walk back there  it stops. There are also voices and footsteps in the halls  especially in the hallway that has the names of the past principals listed. Also  for two miles around it  almost all of the houses have had paranormal activity. No one knows the identity of the school's ghosts  but most of the ghosts in the community are either past owners or past owners' pets. Also  the place used to be a gravel pit. According to myth  many people died on construction of the town  and  to keep people from knowing that some people had died unexplained deaths  there buried them under the town. Of coarse  that's just a myth...", "Emma Morgan Elementary", "KY", "Ghost" },
                    { new Guid("d6cc1d0e-197f-48f9-8701-2d7cf045fe0d"), "Paducah", "The spirit of a young woman named Della Barnes walks through this cemetery on certain nights. Documents claim she was accidentally poisoned by the doctor who was treating her for an illness. Legend has a different story though. Some people believe that her fiancée' murdered her in a fit of rage. He even went as far to cut off her left ring finger in order to retrieve the expensive engagement ring he had given her. There is also an iron-rod statue of an angel that is said to turn and face a different direction in the cemetery.", "Oak Grove Cemetery", "KY", "Ghost" },
                    { new Guid("d6fee9db-5ec2-4510-bcd3-490ca705ecd6"), "Fort Bragg", "supposedly haunted. Custer was supposedly to have passed through Fort Bragg and they say that he and his army traveled up a steep cliff at pudding creek there's been sightings of he and his army to have been seen going up the cliff at Pudding Creek and there is a path that leads to wood walkways head towards the ocean that you can walk to MacKerricker State Park. That has claimed be have seen a young lady in medieval clothing walking about searching for her lost lover who died in the civil war and they say she's been seen wandering around asking if anyone has seen her lover.", "The Entire Area", "CA", "Ghost" },
                    { new Guid("d7236290-0cc1-4af3-8ca4-922b93318feb"), "Rome", "CCC Road - aka Seven Bridges Road - On the northern side of Berry College  there is a road - CCC Road  when you go west  if you count the small bridges as you go over them  there are seven  turn around  count them on the way out  there are only six. At the west end of the road are the ruins of an old church and cemetery called Mountain Springs Church. You can hear music coming from the church at night along with crying and footsteps in the cemetery. - October 2004 update: this is a dirt road and it is blocked of to visitors with no permission.", "Berry College", "GA", "Ghost" },
                    { new Guid("d73f6cd5-d988-4d6e-a4c7-805251eaead0"), "Mobile", "Within close range of the huge oak tree  crying and whispering can be heard.", "Oak Next to Public Library", "AL", "Ghost" },
                    { new Guid("d7cabac4-bb3c-4dd5-b225-f0785ae42d24"), "Baton Rouge", "Green object appears in digital camera shots of the Moon taken on the night that the Moon was at it's brightest.", "Odd Shape", "LA", "Alien" },
                    { new Guid("d83b123b-29ca-43e0-b47f-d0396d765f0b"), "South Webster", "Lights in the sky  random movement  color of a high sodium light in the northern sky.", "Light", "OH", "Alien" },
                    { new Guid("d85c2c1b-cf48-4d9d-ad81-d916ba3cf80b"), "Anne Arundel County", "It has been said that at night you can see a women walking up and down the halls of the middle school  a former principle. Sometimes she is walking by herself and sometimes she is pulling a student by his ear along with her. None of the students liked her cause she was a very mean principle. She was said to have died (year unknown) during the school year and was buried under the school because that was the only place where she liked to be. Now she still acts as the Principle while walking the school at night.", "George Fox Middle School", "MD", "Ghost" },
                    { new Guid("d89b9527-74cc-461c-94cd-b48cb9b3d7c1"), "Eureka", "Large  heavy objects moved across floor overnight. Sighting of former post commander who died of malaria in 1859 looking out window of old hospital building. Lights going off  objects falling. Occurrences regularly during 1993 and have been reported sporadically since 1950's.", "Fort Humboldt", "CA", "Ghost" },
                    { new Guid("d8c3ba62-347a-420b-bc58-ce9d7f26f451"), "Wendover", "Object flew towards us from S.E. and then parallel to us at 75 mph. Appox. 8 lights on outer circumference of disk shape  only lights v", "Disk", "UT", "Alien" },
                    { new Guid("d91b2e67-b922-4288-b688-2418662fa18a"), "", "\"while out looking for deer tracks in the B'Darcs River Bottom in remote area on private property  not accessible by public  we noticed twisted branches. After looking further we found a barefoot print measuring appro 14\"\". after going into creek bottoms  we found more footprints approx the same as before. We went deep into bottom later that evening and heard tree knocking from 3 different locations. We sat til after dark and continued to hear unexplainable noises. After dark in total darkness  we heard objects being thrown thru wooded area at us. I was too afraid to wait around. This property is located approx 6 miles south of Monkstown Tx.\"", "Report 26473: Possible sign and incidents on private property while scouting for deer south of Monkstown", "TX", "Bigfoot" },
                    { new Guid("d986c6d1-9123-4ed0-9fbd-1a22dac88b3d"), "Valley City", "It was a star shaped object travelling south that stopped  changed colors  and sped off dissapearing in the night sky.", "Disk", "OH", "Alien" },
                    { new Guid("daab6fe3-23e5-4450-8d15-e600da283a16"), "Ogunquit", "Revolutionary War soldiers seen here at times.", "Ogunquit Playhouse", "ME", "Ghost" },
                    { new Guid("daacfe3b-03f3-4109-a64d-2d9ac4a7d8d2"), "Danbury", "\"Berkshire Theatre - There is a ghost known by the name \"\"Daphne\"\" that haunts the large theatre of Berkshire Hall. Students working late at night will see her image in the light/sound booth or on the stage. She is friendly and will appear/reappear when asked politely by no more than 2 individuals.\"", "Western Connecticut State University", "CT", "Ghost" },
                    { new Guid("dabcc0f4-6896-422f-8530-dbc3e463ae07"), "On the only railroad track from Bloomingdale -Meldrim   This occurred between the two", "While riding 4wheelers my wife and I and another couple decided to follow the railroad tracks to the next town. It was about a ten mile treck that goes through swamp and none of which is developed. I have never followed it before at night. At about halfway to the other town (Meldrim Ga.) it looked as though the light at the far end of the tracks was getting brighter.We pulled off the side and backed up to the ditch that parallels the railroad bed to wait to see if the light got brighter.While waiting my wife and friends sat and talked and I climbed back onto the tracks on foot to watch the light. The plan was to wait ten minutes and if it didn't get brighter it was possibly a light from another source. After about five minutes my wife and her friend heard something moving progressively closer in the woods. Then large objects began falling around us. I looked at everyone asked had they heard it   then there was no doubt. Larger objects started coming down -large rocks  large limbs. Many were landing in the water  not all in the same place   not all the same size  making huge splashes like bricks would make or larger. One then two then multiple large things landing on both sides and on top of the tracks. Everyone with me by then was right beside me and none of them were playing a joke. Something was throwing stuff at us from the woods. I kept shining my flashlight but never saw what. These were big objects and there is no way any animal I am familliar with could have done this. I have hunted all my life and stay in the woods all the time but this truly freaked me out. As a side note when I used to stay with a friend at his house near the tracks on the Bloomingdale end his grandad used to tell us of howls that came from the woods down the swamp that he couldnt explain. He said they would sound like screaming I've always been skeptical of that but now I am not so sure.", "Report 18361: A group of four-wheelers experience a barrage of rocks and limbs on a late-night ride near Meldrim", "GA", "Bigfoot" },
                    { new Guid("db13f894-45f9-4420-8775-fa300ccf10a1"), "North Kingstown", "the graveyard at the beginning of school street near post road is very haunted. People have seen people walking through the graveyard at night and have seen lights flashing with no explanation", "School Street", "RI", "Ghost" },
                    { new Guid("db546a00-d865-441f-b3d0-4efb67aad24a"), "", "\"While looking through reports for Kentucky I came across report #11966 in Lawrence county  KY. I had a sighting/experience around the same time period and same area near Blaine  KY. I have never told anyone of this other than at the time it happened I told my wife I had been stalked out of the woods by something large and packed my family up  leaving the area. In 2003 my wife and I took our daughter and youngest son with our travel trailer to camp at Yatesville Lake State Park in Lawrence county Ky near Blaine. We arrived on a Friday in August with intent of fishing and I always go on ginseng hunts where I am able/allowed. I think it be noted I am an avid outdoorsman having hunted  fished  hiked  and camped in at least 28 states of the USA for 40+ years. I am well acquainted with big game animals including bears  mountain lions  elk  deer  and wild hogs. I stake my reputation on my word and kept this encounter to myself. On Saturday morning I took my family to fish in the lake at a spot where Highway 32 bridge crosses a fork of Blaine Creek. After my family was set up  I took off into the mountain on the southwest side of this bridge and possibly part of Yatesville Lake WMA to hunt ginseng. As I had worked my way up a long deep hollow and neared the top of the ridge and to my left I heard knocking like someone striking a piece of wood against a tree (similar to what researchers hear/do). I also had several rocks come through the trees from the top of a small cliff at the top of the ridge  but thought they had fell off the rock formations on their own. Then as I happened to look back behind me from the hollow I came out of on the far side of that ridge I saw a very large dark hair covered figure that was watching me and it was standing upright  it definately was not a bear. I estimated later it was near 8' tall  I'm also a carpenter and pretty good at measurements. As silly as it sounds  when it left my sight  I spoke aloud to this \"\"thing\"\" and said \"\"Old one I mean no harm and I'm only taking what I need\"\" all the while easing my way around and down toward my family  once I was out of eyesight I took off down the mountain as fast as I could  I could hear this \"\"bigfoot\"\" following at a distance. Once I got to my family I told my wife to get everything to gather and packed my family out of the area telling them a bear was stalking me off the mountain. It was not a bear and I guess I'm only reporting this now because of the other sightings in the area around the same time. BFRO is welcome to contact me and I would be willing to travel back to the exact spot and show where this occurred even though it was over 8 years ago. \"", "Report 34725: Ginseng hunter has an unexpected encounter near Blaine", "KY", "Bigfoot" },
                    { new Guid("dbb78bfd-e216-415f-8be9-1b65e3b61abc"), "Hanover", "\"Alpha Theta - Likely due to the untimely deaths of fraternity brothers and their unidentified female \"\"companions\"\" due to a boiler explosion and fire in the house many decades ago  specters have been seen and the presence of spirits detected in various parts of the house. Hot spots are primarily in and around the remaining original structure - the house basement.\"", "Dartmouth College", "NH", "Ghost" },
                    { new Guid("dbf9dce1-3866-4965-9eea-05bcaac669df"), "city", "description", "name", "state", "type" },
                    { new Guid("dc1a9052-171a-417c-9ddf-4157feda0e7a"), "Santa Clara", "Large round glowing circle size of a new moon", "Odd Shape", "CA", "Alien" },
                    { new Guid("dccb6386-76a3-4cf6-8fd0-991a21288526"), "Lincoln", "The craft flew over  without sound  made a turn and disappeared into the clouds.", "Triangle", "NE", "Alien" },
                    { new Guid("dcd61355-9468-46cb-9f23-15c87cdc6921"), "Lewiston", "While gazing up at the stars  you had to look carefully but I noticed a formation yet more a bunch of single lighted objects. They were", "Formation", "ME", "Alien" },
                    { new Guid("dcfaffdf-889a-4f8a-baaf-b170f1a3ba9d"), "Rockville", "Bright orange craft flying low and rapidly followed by a second one close behind", "Fireball", "MD", "Alien" },
                    { new Guid("dd17d0e3-ae26-4fbc-8cbc-b26b778c1e36"), "It's off Rt 100 outside of Ludlow Vermont. It crosses some very heavily wooded  desolate areas.", "\"My family and I went to Ludlow  Vermont for Columbus Day weekend since we enjoy the northeastern woods. We all enjoy observing the local flora and fauna in their natural settings and we often drive and/or walk the back roads looking for deer  moose  bear and whatever else we can spot. One evening we went \"\"Moose Spotting\"\" on Tyson Road since during a summer trip to the same area  earlier  we had observed eight moose in one evening. As we drove along Tyson Road I saw a large bipedal form cross the road in two strides. I asked one of my daughters  \"\"Did you see that? Tell me what did you see.\"\" I purposely didn't say what I'd seen since I wanted to know if she'd seen what I'd seen. I wanted to be sure I had not imagined it. Very quickly she said  \"\"I don't know what it was but it was real big  maybe eight feet tall  hairy and crossed the road in two steps.\"\" She saw the same thing I did.  It crossed the road about 50 feet ahead of us and judging from the trees where it crossed the road I'd say her height estimate is accurate +/- 20%. My other daughter didn't see it since she was in the back seat and was looking out the side windows of the car. I still don't quite believe it but I know what bear  deer and moose look like in natural settings since I've been hunting for 40 years. It wasn't anything I had ever seen in the woods. It walked across the road in two strides  was heavily built  covered in short dark hair and  as stated previously  approximately eight  feet tall. One more thing.  The day before  we had driven the same area  didn't see anything at all  no fauna at all  but we did hear some very odd vocalizations that sound very much like the recordings available on your website.\"", "Report 13285: Evening sighting by motorists on Tyson Road  off Route 100  outside Ludlow", "VT", "Bigfoot" },
                    { new Guid("dd272ddc-68f8-4157-99c6-fba627b9807d"), "Ness City", "In the 1960's the second floor was rented as apartments to some older women. After the passed away nobody else every lived there. To this day many people claim to hear footsteps in the hallway and when you check to see if anyone was coming there would be no one.", "Old Ness County Bank Building", "KS", "Ghost" },
                    { new Guid("dd427a14-9729-463a-af56-9af5d7581741"), "Easley", "From our back yard  seven o'clock from the moon  strange lit up object last night with lights around on it that were a diamond shape.", "Diamond", "SC", "Alien" },
                    { new Guid("de496f3b-a0ef-4a77-ac7d-d858926d2ca5"), "Pocatello", "Glowing light swoops down lands atop mountain emits bright lights then chased off by 6 silent helicopters with green lights", "Light", "ID", "Alien" },
                    { new Guid("de6e6044-98c5-4ffe-a9c8-8be1746f6f46"), "Crescent City", "old family owned bowling center was sold. new owners report during remodeling they could here footsteps on wooden walk space behind pin-setters.", "Tsunami Lanes", "CA", "Ghost" },
                    { new Guid("debb3048-2f24-483b-aee4-c5934d36dabe"), "Keene", "Sumner Knight Chapel - The whole area near the Knight Chapel is a major hotspot.  The chapel itself is home to a very unhappy spirit and it's presence is almost overwhelmingly strong as you get within 15 feet of the Chapel.  Near the chapel is the spirit of a little girl who will sneak around and peer from behind trees at you and on voice recorders you can get sounds of a girl giggling. You have to go away from the Chapel to encounter her. Warning  do not curse in front of the Chapel. There is a spirit who will wash your mouth out with soap if you do. Several people have documented the taste of soap in their mouths and others can smell the soap (Similar to Ivory Bar Soap in my opinion) on the breaths of the victims.", "Woodlawn Cemetery", "NH", "Ghost" },
                    { new Guid("dec0cff6-01ac-4946-ba3a-3f4b1723072a"), "Long Beach", "\"in the playground the \"\"rings\"\" they move while no one is on them and they're too heavy to be moved by the wind. It is said that a kid in 3rd grade died because he fell off and broke his head. Also in the cafeteria the trays move without anyone touching them. The benches move with a full load of kids. They say that a girl fell from the stairs and a boy was killed there by getting into a fight and the other kid had a weapon. These were from the years 1973-1984.\"", "McKinley Elementary School", "NY", "Ghost" },
                    { new Guid("ded1d3f9-d63d-448f-9d69-f1d37c4a6f45"), "Mobile", "Students and coaches have heard people playing basketball in the gym. Games from the football field being announced when no game is taking place.", "Mobile Christian School", "AL", "Ghost" },
                    { new Guid("dee80773-f1e0-4d81-b8d3-296c2368ce50"), "Pittsgrove", "The crying of a little girl who met an untimely demise can sometimes be heard in the upstairs dining room. In this dining room  cold spots can often be felt. These cold spots are attributed to the spirit of a past Maitre De  for whom the room is named after.", "Ye Olde Centerton Inn", "NJ", "Ghost" },
                    { new Guid("df8a53a4-42bb-4be2-a225-19cf33ed69c3"), "South of town  near the gulf about half mile from the ocean.", "This is the second report I have submitted. The first was of screams in Arizona where I am living now. This one took place in Jackson County Mississippi in 1973. My father was living in Ocean Springs and working for Littons Ship Systems in Pascagoula. I had joined him there from Arizona when I decided to try my hand at pipefitting instead of Mining. I had bought an acre of land and put a trailer house on it before I had my wife join me. We were on the south side of town in an area of bayous. One night we were at my Dads place playing dominoes when we ran out of diapers for my baby daughter. It was only about a half mile from Dads to my house  so the wife and I jumped in the pick-up and went to the house for more diapers. I had two Red Bone hounds penned in the back of the house and when we got there they were barking as if they had something treed. I was curious as to what they were barking at  as they seldom barked while penned. When I got out of the truck  I noticed a rancid smell coming from the back of the house. I ask my wife what she had given the hounds and she said nothing that smelled that bad. I left the truck running and we went into the house and gathered the new diapers then back to the truck and left. We didn't give it anymore thought that night. I didn't pay much attention when we got back home later  but didn't remember smelling anything then. The next night we were back at my Dads playing dominoes again  and listening to the news from the TV. We heard a report from Pas Christian that a woman had called the police and reported a hairy ape looking man outside her backyard  looking in her kitchen window. She said it was looking over her back fence  which was six foot tall  and she could see it's head and shoulders above the fence. Also  the kicker was that it was accompanied by a rancid smell like rotting meat. The same smell I encountered around my house the night before. Wow  was that weird. I looked around the next morning  but couldn't find any tracks or anything around the house. And there was no smell of rotting meat to be detected. I think we had a close encounter.", "Report 2376: Young couple encounter a rancid smell", "MS", "Bigfoot" },
                    { new Guid("dfd227d8-be31-4491-a56d-5f7c0ab2a36c"), "Denver", "Medium sized reflective neon/medium green circle.", "Circle", "CO", "Alien" },
                    { new Guid("e00e5f12-ea91-4f32-ac80-b4ab80a002fe"), "Shreveport", "\"This school (built in 1925) had a swimming pool at one time  but the pool was closed because a teenage girl supposedly drowned in it. A dance studio was built above it. In the \"\"catacombs\"\"(subbasement) of the school  a JROTC instructor reportedly killed himself with a rifle and his ghost still haunts the school to this day. Cold Spots reported.\"", "C.E. Byrd High School", "LA", "Ghost" },
                    { new Guid("e0396e5a-4be2-4890-9a6e-ba0064ce60f8"), "Chippewa Falls", "This place use to be a boarding house when it was first built but now is a saloon/restaurant. Employees say they hear footsteps walking up and down the stairs at night when they close up. And there use to be these roses painted on the wall and when the new owners purchased the place  they painted over the walls but after a while  the roses would bleed through and they would still try to paint over the wall and still the roses bleed through the paint. This one time an employee went up to the attic where the freezer is and the employee walked in to get some wine and all of a sudden the freezer door closed behind him  then locked itself and the lights turned off. He got out a half an hour later with a pick.", "Sheeley House", "WI", "Ghost" },
                    { new Guid("e0473935-22e0-4b2b-b641-3f06d823a9f6"), "Spencerport", "A small  bright  blinking white light outside my window. It was stationary for 5-7 minutes  then moved across the window.", "Light", "NY", "Alien" },
                    { new Guid("e097b115-3bd4-4d91-bdc5-a89c11367c26"), "St. Mary's County", "A Plantation Ever year they hold ghost tour of the plantation. It's on the Paxtent river so a few our of pirates and things like that. The tour guides said they always experiences paranormal activity. A family who used to live in the manor long ago was having trouble with money. So the husband of the house decided to invite some people of wealth over for a round of poker. Without much luck he continued to lose. In a last effort to win  he put the pink slip of the house on the table.. rolled the dice and lost. Supposeively to this day  you can hear the horses riding up  the dice rolling  and him yelling when he lost. For more info you can visit  http://www.sotterley.com/news_events.htm", "Hollywood", "MD", "Ghost" },
                    { new Guid("e0981c0b-4e83-4137-bd7f-e8a982935d5a"), "Medicine Bow", "Shimmering light  similar to northern lights  accompanied by spotlights moving fast in Wyoming", "Light", "WY", "Alien" },
                    { new Guid("e0b98489-915f-4d7e-ab71-7772529d314d"), "Baltimore", "Built on what once was a trailer park  the ghost of a young girl (Beth) can be seen by the overnight workers. Beth is a friendly ghost who has been known to hold open the curtain for employees entering the dock area. Many employees have also been known to talk to her.", "BJs Wholesale Club", "MD", "Ghost" },
                    { new Guid("e0cb7b74-80d2-49a3-b023-1bb44ad6fbe2"), "In Wolf Creek canyon near Wolf Creek  Montana off of I-15 returning to Helena after a trip to Great Falls", "\"While returning to Helena after a trip to Great Falls  I saw....something....illuminated in the cars headlights on a moutainside approximately 150 feet or less off of I-15. Trying to interpret what i saw  i didn't say anything at first. Then a few seconds later my girlfriend said  \"\"do you believe in bigfoot?\"\"  It literally sent a chill down my spine and all I could think of to say was  \"\"You saw that too....\"\" . She simply said  \"\"yes\"\". I don't know what it was  but i know what it wasn't. It definitely wasn't a bear  goat  sheep  deer  elk  lion  dog  or any other wildlife that lives around here. It was white  standing erect  in excess of 6' tall and appeared to be just watching traffic on the highway (hard to say really  because the duration of this sighting was only a few seconds and it was dark) I find it hard to believe that someone was out there late at night in freezing weather standing in the snow in the middle of nowhere in a gorilla suit (especially a white gorilla suit!) so I've ruled that out as well.\"", "Report 1533: Motorist & passenger see white creature standing off I-15", "MT", "Bigfoot" },
                    { new Guid("e103c243-b941-49f2-994f-a2834c2f9371"), "\"Proceding north on Howe Ave. in Shelton  CT take a left at Indian Wells State Park. The road turns into a windy  one lane road above the park  with blind curves and \"\"pullovers\"\" because only one car can pass at a time. At about 2 miles  the road crosses over a railroad track and continues to the cottage area. It was about 100 yards above the crossing that this event took place.\"", "This took place 53 years ago  however  I have lived with the vision of this creature all my life and have told no one about it. I was visiting a relative's cottage on Housatonic Lake near Indian Wells State Park in the White Hills region of Shelton  CT. Back then (1953) this area was not inhabited very densely and still is not today. There were 3 of us  all age 5-6  and we left the cottage and headed for the railroad track  which ran along the Housatonic River and Lake  to pick wild blackberries to put on our cereal. It was about 1/3 mile from the cottage. As we were busy picking  a large (6 1/2' to 7' tall) creature came down the steep hillside and proceeded to walk northward along the railroad tracks  staring at the 3 of us once  and moving at a fast walk. I remember the length of it's stride (about 5') and it's arms which looked like they went almost to it's knees. The body was covered in a dark brown/grayish color hair and it had the face of a primate. The hair was shorter than Bigfoots I've seen on TV (Patterson film) and it's body was thinner than those also. We ran back to the cottage to tell our parents who dismissed this as children's fantasy. This event took place BEFORE there was ever a mention of anything like Bigfoot  especially in this area.", "Report 16408: Children observe bipedal animal walking along railroad tracks near the Housatonic River", "CT", "Bigfoot" },
                    { new Guid("e13fffa6-922f-428b-953a-0421042cd1fb"), "Boissevain", "Reports of hearing footsteps following along side in the fields.", "Boissevain road", "VA", "Ghost" },
                    { new Guid("e1514070-912a-4e2a-a97e-8d4caa9235d4"), "In Huntsville. Just ask where Green Mountain is.", "When I was about 8 or 10 yrs old  I saw a Bigfoot. It was on Green mountain near Huntsville  Ala. It was unpopulated then. Now there are million dollar homes there. I was on my way home from my uncle's house on a gravel road. I was on one side of a hill. The road went down this hollow and back up the other side. In the ditch line was Bigfoot  about 8 ft. tall with arms that looked like they reached down past his knees. It was slightly leaned foward looking straight at me. It scared the daylights out of me. So I went back to my uncle's house and told him. He got his shot gun and we went back. It was still there looking at us. Uncle threw up the gun to shoot and I told him we needed to get closer. So we went down the hill and as we did we lost sight.  When we got back up the other side it was gone. ", "Report 7235: Recollection of an afternoon sighting on Green Mountain", "AL", "Bigfoot" },
                    { new Guid("e177c059-6a61-4461-a9cd-5e94a0e756da"), "Off the Blue Ridge Parkway in the northern Appalachian Mtns.", "Witnesses observed 12 to 16 inch (approx.) length tracks in the shape of a foot about 5-6 feet apart in 21 inches of snow. These tracks were seen within a 2 mile radius in the northern mountains of North Carolina in a town called Glendale Springs  off the Blue Ridge Parkway. They were observed by several individuals including park rangers. Photos were taken by a resident of the town. These tracks seemed to cross over a split rail fence in one stride. The park rangers tried to explain them as rabbits or small animals jumping up out of the snow and back in again. These tracks were all around the home that I was living in at the time and I know I saw tracks of something that would have scared the life out of me had I seen it in person. I think that this creature was probably searching for food in the deepest snow in these mountains in several years.", "Report 2149: Park Rangers and residents of Glendale Springs observe large footprints in deep snow", "NC", "Bigfoot" },
                    { new Guid("e1887111-1701-4d30-b1e3-389083e97aba"), "Memphis", "It is said that one of the rooms on the 2nd floor is haunted by the spirit of a 17 year old female that died there. The spirit is reportedly friendly.", "St. Jude's", "TN", "Ghost" },
                    { new Guid("e1fa644b-6586-45f3-a1a8-6aff1315e7a5"), "Soldotna", "The furniture store used to be a grocery store  and the owner of that store was murdered. The killer was never found. It's said that the man still haunts the place  and sometimes furniture breaks for no reason. Also  there are unusual sounds heard from the back office.", "Bailey Furniture Store", "AK", "Ghost" },
                    { new Guid("e2e39336-9991-4eab-9c05-3eb821692c0b"), "Bismarck", "I was sitting at a stop light  a couple of lights up in the sky caught my eye. It was three lights in the form of a triangle.", "Formation", "ND", "Alien" },
                    { new Guid("e331dcdc-bf0d-4c32-8afc-03e67b70b1ec"), "Heavy forest in the Ouachita National Forest  8 miles north of Acorn  Arkansas.", "While south bound on US71  8 miles north of the Ouachita River  observed a very tall  dark-colored  upright  bipedal creature crossing the highway and disappearing into the forest.", "Report 56108: Sighting at dusk by a Retired Police Officer with Anthropology Degree", "AR", "Bigfoot" },
                    { new Guid("e351e1f9-82cc-4337-b0fb-468ad6239c45"), "Arlee", "Girls Locker Room - The Arlee High School has class pictures dating as far back as the 1920's. It is said that a girl during the early years of the High School committed suicide in the shower of the girls’ locker room. Several eyewitnesses have heard screams when walking the halls at night  or the sidewalks outside. Many students have also admitted to feeling cold drafts in the water that moves from shower to shower starting from the back to the front. To this day the screams can still be heard.", "Arlee High School", "MT", "Ghost" },
                    { new Guid("e3aef66b-afe7-47b5-9ae0-b8783acbb157"), "Fitzwilliam", "Multiple reports from museum employees and visitors include feelings of being watched  nausea  strange sounds  doors opening/closing  voices  objects being moved  and mist. A paranormal team investigating the location got photos of mist and recorded voices. The museum does offer tours.", "Amos J. Blake House Museum", "NH", "Ghost" },
                    { new Guid("e4be9abb-99a3-4204-9df8-2d9ec88a4252"), "New Castle", "A tombstone lies here with a picture of a man who has  one white hand and one Black Hand on it. Legend states that if you put a white sheet over the top of the headstone on All Hollow's Eve (October 30)  at midnight and knock 3 times  the man will appear behind you.", "Madonna Cemetery", "PA", "Ghost" },
                    { new Guid("e4d9ef77-7735-4025-a892-57ff873a0343"), "Maryville", "Roberta Hall - haunted by the same ghost  Roberta Steel for nearly 40 years. South Third of Hudson hall was closed for years because of strange occurrences. While closed  there were strange noises  like golf balls being rolled down the hall  and strange green lights coming from the bathroom. Since it has been reopened  there have been occurrences of things such as hairbrushes flying across the dorm rooms.", "Northwest Missouri State University", "MO", "Ghost" },
                    { new Guid("e4ee781d-281c-4916-8caa-1754c7467b24"), "Chesterfield", "Above us a bright bluish light appeared which lit up the sky then diminished to nothing.", "Light", "MO", "Alien" },
                    { new Guid("e4f3af96-964e-4e43-a857-af5050860dfb"), "Missoula", "Brantley Hall - is haunted by a victim of the Wall Street crash of 1929. When the family ranch was lost  a female student took her own life  and her spirit has never graduated. Ask the locals about other haunted places and mysterious sites.", "University of Montana", "MT", "Ghost" },
                    { new Guid("e4fadc3a-0bfb-42c7-a2f5-dec51048dd03"), "Military Installation  during a training operation no one outside of the military had access to this location.", "\"This report was originally submitted by email and later investigated by telephone. \"\"I am a former United States Marine who in 2008 had a very compelling sighting of what can only be discribed as a Bigfoot. I am willing to tell my story once I am contacted and also I have two other US Marines that saw the same being. I can assure you that I am 100 percent honest with what I saw and that I can provide proof of my credentials and location.\"\"\"", "Report 34337: Large man-like figure seen in the trees by a Marine training at Fort A. P. Hill", "VA", "Bigfoot" },
                    { new Guid("e4fd81fc-35eb-4538-946e-e60a5a272a30"), "Spokane", "Large disk object with two beans of light hovers over with red and orange blinking lights.", "Disk", "WA", "Alien" },
                    { new Guid("e5741c6c-923d-4bc4-81b5-dd95008e2eca"), "Wolfeboro", "I was called by a friend on the phone who said she and her husband had just seen a bright light moving silently and speedily across the", "Light", "NH", "Alien" },
                    { new Guid("e5b47ee0-0583-46a7-9973-bee86c0080c0"), "Wilmington", "A quick moving green glowing ball seen while driving.", "Sphere", "DE", "Alien" },
                    { new Guid("e5ccbdf2-765a-4320-9bfb-6a730d8795a0"), "Smyrna", "Unexplainable acceleration and deceleration in proportion to emitted light intensity.", "Light", "DE", "Alien" },
                    { new Guid("e63b6221-09a7-498f-8fb1-b7a2a9d8eb2b"), "Marion", "Abijah Thomas built the Octagon house in 1850.  Thomas built the house with 8 sides to protect it from wind damage. He kept slaves to help him work the fields. It is said that in an upstairs room you can still see fresh blood dripping and seeping down one of the walls. You can also hear many strange noises through out the entire premises.", "Octagonal House", "VA", "Ghost" },
                    { new Guid("e6588cb6-c3f8-4686-8b4f-2b80271cfe4f"), "It is the Southernmost gas station off of I-25 from Las Vegas  NM.  It is a large service center.", "\"My wife and I were driving home from Denver  Colorado to Albuquerque  NM and stopped at a gas station in Las Vegas  NM (I believe it was a Philips 66) at approximately 0100 on 10/18/2013.  We pulled off of I-25 Southbound into the gas station parking lot.  When we were driving down the frontage road towards the gas station  we saw a few vehicles on the far end of the parking lot with 3-4 people talking and a NM State Police cruiser was leaving the lot  however  upon parking in front of the gas station  we discovered that it was closed.  I needed to pee rather urgently  so I ran around to the back of the station to find a dark place to do my business.  I walked about 15-20 meters behind the gas station to be out of sight of the occupied vehicles in the gas station lot.  As I was urinating I began to feel...uncomfortable.  I was peeing in open ground and initially thought somebody was walking up behind me (probably to do the same thing).  I craned a looked around and saw nobody and no animals; just a blanket feeling that somebody was very near me.  As I finished peeing  I turned and began briskly walking back towards our vehicle.  As I was hurrying back I turned to look behind me; and that is when I became a believer. Before I continue  I would like to preface my anecdote by alluding to my high-level of academic credentialing alongside my occupation as a healthcare executive.  I also provide executive and technical advise to elected and appointed officials; I have worked very hard to become an expert based on empirical analysis and studied fact.  I did not believe in Bigfoot  ghosts or another unexplained anomalies.  I believed in results  hard work and  well  results.  My perspective is now very different. As I turned and looked over my left shoulder  I saw an enormous  lurking animal.  The animal was crouched over  almost as if taking cover in the sparse and cold vegetation.  In fact  I think the creature watched me the whole time  and did not make so much as a noise.  However  the creature noticed when I saw it.  The creature stood up  and quickly lumbered into the dark away from the direction of the parking lot.  The one attribute of the creature that resounded with me was how heavy the footfall was.  It sounded like somebody dropping a sack of potatoes over and over again.  And it was fast.  I observed the creature for about 8-11 seconds  from the moment it realized I saw it  to watching the animal dart into the wood line.  Due to radiant light from the parking lot  I could make steady detail of the fleeing creature.  Here are the salient points from my memory (aside form the footfall): 1) The creature was approximately 8-10 feet tall.  I am 6\"\"2 and this animal would have towered over me ( I observed it on flat land lending to my estimation). 2) The hair on the creature was matted  like dogs that live outside.  The coloration was dark brown. 3)  The creature had a defined gait.  It took strides that I would estimate to be 3-4 of my strides per 1 of it's strides. 4)  The creature had massive  human like hands. 5) The creature was very skittish  not moving until realizing I was observing it  lending to a higher intellect that a brown bear.  I believe the creature may have even fled in fear. 6)  I did not make eye contact  but noticed a massive brown and defined jaw and cranial structure. There is one other trait that I have since read about that may allude to this being a New Mexico Bigfoot.  The air was rank with what I thought was the dumpster behind the gas station.  However  this may be the \"\"musk\"\" eyewitnesses have reported in the past.  I cannot be sure  but it was very powerful  and somewhat reminiscent of what I perceived to be urine. This incident was fearful and moving.  I was unable to sleep for days and could not even bring myself to tell my wife until recently.  Due to my profession and reputation  I have extreme  extreme reluctance about openly sharing my encounter.  However  I have personal visual evidence of a so-called mythical beast  and I do not know what to do with it. Another fact: I have a concealed carry handgun license in the State of New Mexico and was carrying a 1911 .45 at the time of incident.  I was so scared that reaching for my weapon would have been an afterthought.  I was actually scared stiff.\"", "Report 43399: Scientist skeptic has early morning encounter behind gas station near Las Vegas  NM", "NM", "Bigfoot" },
                    { new Guid("e74c5efb-1627-4c5d-a068-209adf37f797"), "Lolo", "My son and I saw a bright  white colored object in the sky right near the moon  but lower about a half hour ago.", "Disk", "MT", "Alien" },
                    { new Guid("e763d1f1-9f71-43da-9d34-85ddfdf2855b"), "Towson", "There is a book of ghost stories about this historic mansion previously owned by the Ridgely family.", "The Hampton Mansion", "MD", "Ghost" },
                    { new Guid("e79d4884-27cf-4fa6-b26f-13b7099b3d53"), "St. Joseph", "\"Strange noises and sightening have been reported and the 3rd floor is said to be haunted by a man in dress pants. An old patient is said to be seen wandering the halls through out the building. The most haunted part of the building is the Basement where the Morgue is located. Strange things such as the motion detecter going off rapidly when no one is around  the sewing machine starting  cries of help  sounds of whimpering and crying  and a man's shadow and muttering have been heard. Ten groups  (four groups of 1  two groups of 2  two groups of 3  a group of 4  and a group of half of a schooling college class)  have reported hearing a woman's voice whisper \"\"Help Me.\"\" at seperate times. And six groups  (two groups of one  three groups of three  and one family tour)  have reported a man running towards the elevator bellowing \"\"Why are you here? Get out!\"\".\"", "Glore Psychiatric Museum", "MO", "Ghost" },
                    { new Guid("e7ec782a-e5af-41fc-b04c-08f3ef5d09ed"), "South Berwick", "\"Object with a white and red light appeared to be \"\"dancing\"\" in the sky. At times it would make quick moves up/down and diagonally  and\"", "Light", "ME", "Alien" },
                    { new Guid("e7ede293-9148-4e81-b6ad-1abf09e67626"), "Cheyenne", "An orange object viewed intermmitantly in the night sky heading east at a relatively slow speed.", "Unknown Shape", "WY", "Alien" },
                    { new Guid("e7fd27aa-a084-4ece-8e0b-c0d0da4f137f"), "Pittsburgh", "I saw 4 different aircrafts within a period of 15 min  all were square  low flying  had 3 round lights  and fast flashing red lights.", "Odd Shape", "PA", "Alien" },
                    { new Guid("e8281648-8afc-433b-b5bb-739ae692335e"), "South Royalton", "it just appeared and stayed there flashing colors for sometime then something came off it and disappered. After sometime it came back t", "Circle", "VT", "Alien" },
                    { new Guid("e838bced-bca0-41fa-b3a0-d25eb2d27104"), "Glasgow", "I was heading towards I-65 away from Glasgow Kentucky a remarkably bright sphere lit up the whole area.", "Sphere", "KY", "Alien" },
                    { new Guid("e88a9b89-af5b-40cf-9f30-4078c9dba186"), "Mobile", "The apparition of a woman can be seen hanging on a cross.", "Seven Hills Cemetery", "AL", "Ghost" },
                    { new Guid("e8db05bc-f8d2-4921-a0a9-f320435a581a"), "Hammond", "There was a man who was having a very hard time. He and his wife had recently got a divorce  and he could no longer see his children. He was also fired from his job. The man was really  really upset and decided his life was no longer worth living. He committed suicide by hanging himself. Years later the residents living there can hear the man talking to them during the night  he also interferes with their lives by  for example  throwing tools all over the garage. Also  on the anniversary of his death a quick white light can be seen from his window to remind the neighborhood of the tragic event.", "Near Columbia School", "IN", "Ghost" },
                    { new Guid("e9d04ca4-3563-41a6-99da-27c9f920598f"), "This area is near the Trinity River bottoms and National Forest.", "While hunting in east Texas I saw a large hair covered  7 ft tall  275 lb. something ape/man like creature vault/leap over a fence  land on 2 legs and step off the trail into the forest. Through the 9 power rifle scope it looked exactly like some of the sketches I have seen. This occured 25 years ago and I just now started looking into other peoples sighting.", "Report 20685: Hunter observes large Bipedal Creature jumping fence near Austonio", "TX", "Bigfoot" },
                    { new Guid("ea70b664-e2ab-46c2-a59f-625ba2b4d360"), "We were traveling westbound when the animal was sighted  standing at treeline on slight rise south of eastbound lane of highway.  We continued travel westbound several miles and pulled into a rest stop on the south side of the highway. To fix a better location we were approx. 30-45 minutes west of Alaskan/Canadian Border  westbound and several miles after seeing animal  we stopped at a rest stop on the south side of the highway. Hope this helps. Also  for what it may be worth  several local natives were having lunch there and we shared what we saw with them. I believe one worked for the state road system as he was driving a state vehicle and another mentioned he was a state sponsored hunter for rogue bear. The hunter thought I had seen a grizzly  from the coloration  the height and the lack of a neck (he reasoned that the grizzly's hump  when viewed from behind could be mistakened for a head).", "My daughter and I were traveling to Tok  Alaska  westbound approx. 30-45 minutes from US Customs at Alaskan/Canadian Boarder. We were towing a 27 ft. trailer and listening to music and enjoying the view. An object caught my eye standing in the treeline south of the eastbound lane. I saw something from the waist up reaching to a higher part of a white bark tree. I did a double take and slammed on the brakes and came to a complete stop. Whatever it was had its back to us and still was reaching up with its right arm. The animal was a beautiful blond/auburn coloration and appeared well groomed as I could see the waist and well developed shoulders that blended into the head. I didn't see a real neck. I made a mental note using the tree as a height measuring device. I reached for the camera and my daughter but when we left our truck the animal was gone. We returned to our truck and continued driving until we pulled into the rest stop mentioned above. I took a tape measure from the tool box and measured a similar looking white bark tree using my mental notes....The animal I saw stood at better than 9 ft with an overhead reach greater than 12 ft.", "Report 9317: Driver on Alcan Highway has noon  road encounter near Alaska-Canada border", "AK", "Bigfoot" },
                    { new Guid("eb386ba3-e566-46e9-a7f7-293f75efb50b"), "Mayfield", "supposedly the angel tombstone located in the center of the cemetery will drop rocks on your head at the stroke of midnight if your sitting on the bench beneath her feet...", "Maplewood Cemetery", "KY", "Ghost" },
                    { new Guid("ebc0368c-9e4e-432e-91a3-e8afae698bcf"), "McGaheysville", "At the time I spotted this unusual flying thing  I thought it was a tiny beetle that hovered and zigzagged sharply like a hummingbird.", "Odd Shape", "VA", "Alien" },
                    { new Guid("ec2b0f2f-8c05-4fc2-9dfe-a7c5fdd62668"), "Beckley", "I saw an amazing bright flouescent green fireball fall to the earth from the south on a clear night that took only seconds.", "Circle", "WV", "Alien" },
                    { new Guid("ec36995c-0be5-4b11-b16c-06eb401c29e3"), "Premont", "Early morning  full moon star on left of moon started moving from our left to our right  crossing in front of the moon and continued", "Star Shape", "TX", "Alien" },
                    { new Guid("ec88b2b7-4c2b-4839-99f7-b879240e2347"), "Fort Madison", "So came out to smoke a cigarette and there happens to be a very very bright light in the sky. I pulled the my phone camera out to pictu", "Changing Shape", "IA", "Alien" },
                    { new Guid("ecb56ed4-348f-4a64-8677-9ce0218e219e"), "Just stay on 33 west until you hit the WV boarder", "Tonight March 16 2012  I was driving through the moutains of WV going east on Rt. 33 towards Virginia at 10 pm or so. I was out with my friend and I was driving. I took a turn and my headlights hit a figure walking along the road behind the guard rails. I'm 7 foot one but this thing was built  I'm tall but this must have been 6 inches to a foot taller than me. Though I was driving I was only going 15mph around a turn so I had time to see it. It was walking behind the guard rail and there is no way it was a man  it was way too dark out. Right after I saw it I pretty much had a panic attack. My pulse went up and started breathing fast and shaking. I never believed there was such thing as one but I am sure I saw one. I just can not believe how bad it scared me.", "Report 34583: Driver passes tall bipedal figure at night along Route 33", "VA", "Bigfoot" },
                    { new Guid("ecd7772b-f9b1-43f2-845c-29b14d1e2a42"), "Faucett", "Locker Doors open and close on their own. In the high school art room many hear the sounds of a young girl crying. Many young high school kids from this school died in car wrecks  swimming accidents  electrical shock  and other mysterious accidents.", "Mid-Buchanan High School", "MO", "Ghost" },
                    { new Guid("ed38732d-2b4e-4fcf-8995-9c47fb1623e3"), "Castleton", "Dorm - Apparition of student wearing orange t-shirt and jeans waking people up in middle of night  who hung himself.", "Castleton State College", "VT", "Ghost" },
                    { new Guid("ed6e0f7a-0180-4233-9ab4-64a129433462"), "St. Albans", "What is now a movie theater had had several encounters. The movie theater which used to be a jail has had several strange and unexplained encounters. Several times the projection booths have been a spot of mystery. Movies have started by them selves and voices can be heard in the old booths. The basement  which still has the remains of old jail cells  has the feeling of being watched. An old man with a white sweater has been seen walking around the basement. He is said to be an old homeless person who years ago moved into the basement and lived there. The basement door also has been know to fly open even when latched. Doors that say alarm will sound when opened have opened with out the alarm going off. Overall the theater has a very uneasy feeling to it.", "Welden Theatre", "VT", "Ghost" },
                    { new Guid("ed98ba0f-1629-48a9-87fc-bcb190240ecf"), "Irmo", "Saw various lights like starts traveling in a row and disappear in the sky.", "Formation", "SC", "Alien" },
                    { new Guid("ed9b77b5-ff96-426b-9c5b-f4946b44994a"), "Memphis", "The Metal museum of Memphis is on part of the grounds of what was the army hospital. This was ground zero for the yellow fever epidemic - and the equivalent of the CDC. Thousands died here. There are many tails of things at night. There is a lot of activity in the morgue building and the doctor’s residence.", "Metal Museum/Army hospital", "TN", "Ghost" },
                    { new Guid("edac6f0c-c6bb-40c6-9328-5d2459206174"), "Ward", "I was taking a picture of the moon because of the lunar eclipse. I didn't notice the object until I looked at my photo later.", "Unknown Shape", "AR", "Alien" },
                    { new Guid("edb7ef86-0165-4d77-ae71-e606899794eb"), "Ellis", "In the bottom of the Railroad Museum there is an old jail cell  (used for storage.) It is said that during the flood of 58 there was still someone locked up in the cell. He drowned and died  and up to this day you can noises and see figures walk past the windows.", "Jail Cell", "KS", "Ghost" },
                    { new Guid("ee000d51-4f04-4ec0-9128-fa834bb69055"), "Approx. 2 miles south of 369 (street address)  home address of parents.", "While home from college on holiday break I was out visiting friends one night.  I had pulled over and was outside the car in a remote area near my home (parents home) with a friend.  While outside the car  some movement caught my eye on a rock cliff on the opposite side of the road and approx. 100' away.  I saw a figure approx. 7' tall  broad from shoulders down through torso  large head  covered entirely with dark (hair)  standing upright with arms straight down by side.  No eyes  mouth  ears noticeable.  I stood still for 10-15 seconds starring at the image; then  it turned to it's left and disappeared.  No sounds made.  I hurried my friend back into the car and asked him if he saw what I saw and he said he only got a brief glimpse of a shadowy movement.  Although I definitely saw as described  I have dismissed this as being a person  maybe a hunter in the area.  And  I was looking upward at the time so the image could have been distorted.  But  readings of other similar sightings since has prompted me to submit this occurrence.", "Report 56809: Memory told of seeing a tall figure on a rock embankment at night near Crossville", "TN", "Bigfoot" },
                    { new Guid("ee3301e3-cc7f-49ed-a68d-8cd76aebf20d"), "New York", "Two eliptical luminous pink objects travelling North East at approximately Mark-2 in parallel formation.  However  there was sound emi", "Oval", "NY", "Alien" },
                    { new Guid("ee35273c-59aa-4183-b538-cda9a2f23d46"), "", "\"Subject: White Bigfoot I just read the Louisiana encounter on your site and thought it great that someone else had seen a white bigfoot. I have not told anyone outside of friends about my experience  although there were plenty of others around at the time. This encounter happened  Ohhh bout 30 years ago in Columbus  MS. I and several of the neighborhood kids were out playing in my front yard. I was the oldest  so the rest of the dozen or so kids were 4th grade and earlier in school. All of us were playing \"\"Tag\"\" and to make things level-out for the younger kids  we all were turning round and round to get dizzy so the youngers could have a fighting chance of  catching us. All of a sudden  my youngest brother ran through the group yelling \"\"Booger-Bear!!\"\" He looked TOTALLY scared to death. I thought he was joking  but then my next brother did the same while pointing toward the unoccupied side of out duplex apartment house. Soon  I looked around to find that I was the only one left in my front yard  the rest of the kids had run to where the parents where outside chatting next door. All of them were holding onto his/her parent(s). Well  I looked down the street and saw nothing unusual. Looked again  both ways  same result. As I was turning back toward them  my eye caught a movement beside my duplex. Something was standing at the corner  hugging it as though to peek around a corner. It appeared to be slightly hunched over and yet the top of it's head was at the top of the window. The top of that window was at about the 7ft plus level. Could have been higher. One day I might get a chance to measure it cause the house is still there today  although the neighborhood is not where I would care to be at anytime nowdays. Anyway  I stood there looking  trying to figure out what this white hairy thing was. Earlier in the year  maybe a couple of months (been a long time ago)  there was a report of a white gorilla that had escaped from a circus. Thing is  kids know when a circus is around in those days  and I had never heard of one being anywhere near. It was just standing there  slightly moving kind of side to side. Since it was at dusk  and I couldn't really tell what this was that I was looking at  I slowly backed over to the grown-ups area. Eventually  the thing was hidden from my view by the house. I eventually worked up enough courage to make a wide arc toward where I saw it to see if it was still there. Nope  it was gone. I had a terrible time sleeping that night. Didn't want to be anywhere near a window even though we had no AC and it was warm weather. Next morning  I went to the area just to see if I could find anything. Nothing. I was never late for supper again. Never stayed out after dark. etc...The experience is real  though I have questioned my brothers about it and they remember nothing. Perhaps it was the grownups playing a joke?  They of course deny any knowledge. This is my only \"\"bigfoot\"\" story  though I have a couple of others that may spark some interest  one of which defies any rational explanation.\"", "Report 1344: while playing tag with several other children witness saw a white hairy creature.", "MS", "Bigfoot" },
                    { new Guid("ee69385b-4d4f-41f7-8b19-54235db84c2b"), "DeRidder", "A Little boy at the age of 3 and His mother were killed in a house fire. They are buried at the Pleasant Hill Cemetery. There names were Marie and Freddie Kruger. Sometimes if you go out there at night and stand at the fence you can see an orange flame above his grave.", "Pleasant Hill Cemetery", "LA", "Ghost" },
                    { new Guid("eeb40dfb-eb1b-438e-b553-0ea69e2fe437"), "This area is in the Arlie Moore area of the corp land surrounding Lake DeGray.", "Wednesday  October  12  2005 our neighbors dogs were very active and barking all night.  The next morning about 5:30am my own dog was barking in the backyard.  I opened the door to calm her down and I heard something in the back of our property near the fruit trees.  It was very heavy sounding and I could hear branches breaking as it departed.  The next morning around 8:30am my husband went to his truck in the backyard and heard something behind our shop take off running.  He thought it was a hunter and ran to the back to listen.  He thought it sounded like it was on two feet.  He said it stomped very heavily as it was running through the woods and he could hear snorting.  Sunday  October 16th  I went walking around the neighborhood road and discovered several sets of large and small barefootprints on the gray slate road in front of our house.  At first I thought it was a childs footprint until I looked closer.  There were two sets.  The largest measured 13.5 by 7 inches and the small print measured 9 by 4 inches. I took pictures of all the prints and measured each print.  They consistenly measured the same size.  The large print is about 3 inches wider than my husbands foot and he's a big man.", "Report 12824: Two sets of tracks found near Lake DeGray.", "AR", "Bigfoot" },
                    { new Guid("eeb4694c-d262-4cb6-bc1c-927f8c3a14f8"), "Seattle", "\"The \"\"craft\"\" had about 6 white lights around its perimeter and a redish one in the middle. The thing was moving slowly towards the west \"", "Egg Shape", "WA", "Alien" },
                    { new Guid("eebaf4b7-f6b8-4fe7-9970-e3b8f9318d93"), "Port Townsend", "\"During the early 1900s a young girl named Kate stayed at the castle  after it was turned into a bed and breakfast. When she heard the news that her fiancé had been lost at sea the committed suicide and jumped from her third floor room  306. It is said that singing can be heard from the bathroom at night. Also the heat goes through many changes as if she is changing the heat herself. There is a broken clock that chimes. A book was once left in the room so that guests could record their experiences  but was taken out because it scared guests so much they asked for a room change. But Kate is a friendly ghost and there is said to be a portrait of her hanging in the lounge and the back wall. Numerous apparitions have been seen in the castle. One Visitor took a picture in the room they where staying and there was clearly an image of a woman staring out the window towards the ocean. She was clothed in late 1800's attire with a bonnet. It is also rumored that a monk hung himself in the attic. Lights go on and off by themselves  doors open and close in the same fashion. Was featured on the television show \"\"Sightings\"\". True ghost hunters will agree it is well worth a night's stay to truly see evidence of the supernatural. Open to the public  reasonably priced. Good restaurant.\"", "Manresa Castle", "WA", "Ghost" },
                    { new Guid("eec4bbe5-c24a-4728-b80c-71464c532e99"), "Pahoa", "Egg shapped orange Moon object over Hawaii neighborhood.", "Egg Shape", "HI", "Alien" },
                    { new Guid("ef0a9688-7b48-4883-8cbf-22cf72da7d8b"), "Paulding", "if you get out of your car and try to walk it  you will be walking down a hill and at the bottom of the hill is a running stream about ankle deep and it hard to cross at night. If you pass the stream and get close to the light it will disapear right before you get to it.", "Paulding Light", "MI", "Ghost" },
                    { new Guid("ef32bcce-aba0-494c-ad24-144a0fd14d64"), "Reno", "Years after 4 bodies of transients were unearthed in this canyon  just north of I80  ghost hunters from Oregon  Nevada and California have sought out this spot on fall moonless nights to see unexplained lights and occasional sounds of a murder. Since the murders were never solved  some people feel these ghosts are attempting to provide clues to the guilty.", "Robb Canyon", "NV", "Ghost" },
                    { new Guid("ef71f469-44b9-4682-97bb-fbac77154469"), "St. David", "A young girl was ran over while she was running across the street right in front of the school. She haunted the third swing from the right on the big swing set in the playground. Also  a janitor hung himself in the girl's restroom in the basement. In the classroom next to the restroom  there were doors slamming and papers flying off a desk when windows were closed. Since the occurrences  the school has been closed and someone lives in the abandoned school building.", "St. David Grade School", "IL", "Ghost" },
                    { new Guid("ef81306d-0f64-4de2-9f10-8a1e7a57681d"), "Medora", "Everyone that goes there experiences the feeling of always being watched and cold spots. Medora was supposed to return but she died before getting the chance to do so. I think when driving home from the Medora Musical I saw the lights on in one room.", "Chateau Demores", "ND", "Ghost" },
                    { new Guid("ef98751c-10ac-4383-8103-3de8a17e7360"), "Bossier", "Near a curve in the railroad tracks inside the city limits of Bossier City  ghostly cries and screams can be heard. The story is a young mother and several of her small children were hit by a train years ago when her vehicle stalled on the tracks. The spine tingling cries can be heard between 10:30 and 11:30pm on certain nights. Even hard core railroad men avoid this area at night. My husband won't go near the area at night again  because he has experienced the fright several times while working.", "KCS Railroad Tracks", "LA", "Ghost" },
                    { new Guid("ef9b199f-2da0-459f-88a0-350a817b0ec1"), "Capper Center", "A man was killed in the hotel  and now he's haunting it. His ghost has been sited several times by many people. The hotel has since been closed down.", "Tonseno Lodge", "AL", "Ghost" },
                    { new Guid("f0252d85-80df-4fb4-b444-b814f12b7a34"), "Hill City", "As I was leaving Hill City this morning going back to Rapid City  I saw a bright point of light.", "Unknown Shape", "SD", "Alien" },
                    { new Guid("f06f77d4-b6b2-42c6-9ec3-6f9ee226fefd"), "Morse Rd to the west and Hwy 169 to the north  a large swamp to the west and east. I was facing north when I saw it. Ten seconds before I saw it is when I heard the howling in the swamp to the west of my position.", "Went hunting south of Buhl about a half mile from the cemetery. In the wildlife refuge I made my way to a large swamp. Seeing nothing I headed back and jumped onto old railroad tracks. I heard something howling in a spruce swamp to the west of me. Every time I stopped it would get quiet. I started walking again and heading north when I noticed something on the road ahead of me about a half mile or so. It was black and at the distance I couldn't make out what it was. The closer I got I assumed it was a bear. But then it stood up and very quickly ran into the ditch and stood in the brush and looked at me. I couldn't believe what I had just saw. Long arms long legs  dark black and about 7-8 ft. tall. It was big and fast. I looked at it and I got the impression it was nervous the way it was acting ... Being a mile from my truck and having 2 of them to the front and back of me and the nervousness I was feeling I decided it was best to head off it was a long walk out.", "Report 46817: Hunter scouting locations has a possible encounter near Buhl", "MN", "Bigfoot" },
                    { new Guid("f070b74b-f32d-4007-b159-dabfe16989b4"), "Salt Lake City", "west temple - There is an open well in the basement that still exists today. Samples of the well have been tested and you get the feeling that when you go down there... something just isn't right. Employees will not stay late into the night - and no one will go down there alone. A young girl's voice as well as a feeling of malady has been reported numerous times...", "DMA Building", "UT", "Ghost" },
                    { new Guid("f08d1e06-a921-4ab3-aaca-aa25d4e5596b"), "Corvallis", "The costume room is haunted by a cold  un-welcoming presence. The costumes shift on their own and the ladder creeks as if someone were climbing it. The stage is also haunted. Strange drafts  uneasy feelings of an unknown presence  the curtains shift  and chairs move across the stage as if pushed.", "Crescent Valley High school", "OR", "Ghost" },
                    { new Guid("f098436e-4ea6-4ad2-bb3b-d187e6fd6a30"), "Maybe 20-30 minutes east of the Park", "\"Leaving the east gate of Yellowstone near sundown. Somewhere between there and Cody...maybe halfway...and after dark. I saw a dark  bipedal motion moving out of the tunnel of light provided by my van. It was very brief. When I got back to Florida at some point I received a field & stream and read about the skookum cast. After reading it I went to your site and found the \"\" Wyoming Hotspot\"\" and it all came back. I'm a cautious observer and realize how your eyes can play tricks. I asked my wife...prior to telling her about the skookum cast article or the information on your site... about whether she remembered me saying anything on the way to Cody when we left Yellowstone during our trip there. She said all she remembered was me joking about seeing Bigfoot. I wanted to be sure it wasn't a \"\"manufactured memory\"\" because sometime had passed. It was a long day...we had seen lots of wildlife and finished with a nursing grizzly with 2 cubs just before leaving the park. What I saw reminded me of a moose in color. I've always described moose as being difficult to see at night by saying it's the black that moves at the outer limits of your lights. Often you don't get a clear outline of the animal but know by the way it moves. I don't know if that makes sense but it's 2:30 am now so I'm a bit groggy. I was planning a trip back this summer to take a better look around. I was finishing a Masters last summer at Colorado State and had a week between classes so we headed to Yellowstone in the hopes of seeing Grizzly....and the Park. Had I been in Washington I probably would have been looking for Gigantipithicus. Many years ago I talked to Dr. Krantz and Peter Byrne while working on a project for an Animal Behavior class at the University of Florida. When I called them they seemed credible and were helpful. My memory is from a second or 2. Two strides that took it from the middle of the eastbound lane  to the middle of the westbound lane  to the gravel on the side of the road...dark...large. Half laughing I told my wife I saw a sasquatch...she said so did she...we both laughed and said we must be tired...she said turn around  which made me laugh even more...We're just tired. She pointed out we didn't know when we'd ever get back. I didn't think anymore about it till I went to your site. I'll be going back this summer...probably June...depending on the cost of gas...it's getting crazy again.\"", "Report 2216: Driver sees bipedal creature in headlights near Yellowstone hot spot", "WY", "Bigfoot" },
                    { new Guid("f0c9a3b2-7f47-45cf-a02a-1f2af592410b"), "Tellico plains", "I saw a black triangle three times  once over my house and once over a field and once following me home.", "Triangle", "TN", "Alien" },
                    { new Guid("f0c9ee4c-517d-4edb-bbbb-3d05db79db03"), "Scotia", "\"A small town in California named Scotia  there are a lot of hauntings. Particularly in the Scotia Inn. There are many sightings of many ghosts  but ask the front desk person for the most famous of them all  and you will get the answer...\"\"Frank\"\". Frank is on the top story in one room. There are many sounds  feet scraps  voices  ect. Frank is a friendly ghost  and some times will bounce a basket ball to you  if you bounce it to him. Another story is of a woman  and her children. A little child was playing with her ball one bright day when her ball fell off the balcony  as did the child. It is said the mother and girl haunt the room the little girl fell off of. There is yet another story of a baby crying. There are many other ghosts in the Inn....just as the people that work there.\"", "Scotia Inn", "CA", "Ghost" },
                    { new Guid("f0f95f1f-55e6-4b7e-a890-ad22fc0c104d"), "OLD LINDEN HI-WAY AND HI-WAY 260", "WELL ME AND MY FAMILY WERE ALL OUT CAMPING AND FISHING AT A GREAT LAKE THATS IN SHOW LOW AZ CALLED FOOLS HOLLOW LAKE.  IT WAS OUR LAST NIGHT THERE AFTER A GREAT STAY AND LOTS OF FUN WE HAD A NICE DINNER AND ALL WANTED TO HIT THE HAY. IT WAS ABOUT 9:30 OR 10 PM WE ALL WENT TO BED.  I HAVE HUNTED ALL MY LIFE AND THE SOUND I HEARD I HAVE NEVER HEARD BEFORE IT WAS VERY LOUD AND OFF IN THE DISTANCE IT WENT ON FOR ABOUT A MINUTE IT ALMOST SOUNDED LIKE IT WAS ANGRY. THIS HAPPENED AT ABOUT 3:45AM MONDAY JUNE 11TH 2007 I JUMPED OUT OF BED AND COULD HEAR A RABBIT SCREAM LIKE SOMETHING WAS KILLING IT AFTER THAT  I DIDNT HEAR IT AGAIN. IN THE MORNING ME AND MY FAMILY AND FRIENDS GOT UP HAVING COFFEE AND I ASKED SOME OF MY FRIENDS IF THEY HEARD THAT HOWL AND THE RABBIT SCREAMING AND A LONG TIME FRIEND OF MINE SAID HE WAS WAKENED BY THE SOUND AND HE ASWELL IS A LONG TIME HUNTER AND HAS NEVER HEARD NOTHING LIKE THAT.", "Report 20833: Possible early morning vocalization at Fool's Hollow Lake", "AZ", "Bigfoot" },
                    { new Guid("f135b56d-9b4b-4fc5-b663-7cb0ab3e18c3"), "Enid", "there is said to be a glowing head stone in the cemetery but when you walk  up  to the head stone it will stop glowing and if you go south of the head stone  there are claw marks on another head stone and if you go to the back of the cemetery there is an old Indian burial ground they say you can hear voices and people touching you.- April 2004 Addition - the Imo story about the grave has been completely investigated and is in fact tower lights across the street from the cemetary that give a reflection off the marker... the burning effect takes place as soon as it gets dark and goes away as soon as it gets light  when you walk up to it - at any point you can clearly see the lights in the background... from the ground point of view. It does infact look like it is on fire  esp from the road at night but is in fact only an illusion.", "Imo Cemetery", "OK", "Ghost" },
                    { new Guid("f1854144-5c70-4940-bf98-c04445090656"), "Livingston", "A figure can be seen standing in the windows  as well as strangeness related to cold feelings and a black and white cat.", "Covered Bridge", "AL", "Ghost" },
                    { new Guid("f188d9f9-540a-4e2e-b3de-44185fa93e34"), "Bannock", "The ghost of a woman is seen. Also a baby crying can be heard in this empty ghost town even when there are no children around.", "Meade Hotel", "MT", "Ghost" },
                    { new Guid("f198fde3-55b2-44f5-a8d0-146ec23f23c1"), "Approximately 7 miles north of Farmerville just off Hwy 15 on an old logging road", "Upon loading firewood into the truck  my grandfather and I saw a large  black  hairy creature about 50-60 yards from our truck. It appeared out of the woods and just seemed to observe us for about 30 seconds or so. It then walked off at a brisk pace into the woods.", "Report 1501: Two witnesses see a large  black creature while loading firewood on a truck", "LA", "Bigfoot" },
                    { new Guid("f1d1936f-2dcc-46b7-bc42-6eddab198dd0"), "Charleston", "\"This theatre was built in 1909 on the site of the old Welch Mansion that had stood there since 1798. The theatre still houses some of the family that once lived in the mansion. Capital Plaza is now a venue for artists such as Tori Amos  R.E.M.  and other well-known musicians. The former theatre where \"\"Mountain Stage\"\" was recorded  is a place that gives people chills when they enter the area. The most prolific ghost here is that of John Welch. He was the son of the man who built the house and heir to the Welch fortune. John is very sneaky and likes to play around with peoples' minds. He is quite protective of the place and of the actors who frequent the stage. Another ghost  not quite as active  is known as Molly Welch. She was John's youngest daughter who died of pneumonia in 1840 around the age of eight. She is very shy  but sometimes when an actor is standing on stage  she can be seen sitting in the front row of the balcony.\"", "Capitol Plaza Theatre", "WV", "Ghost" },
                    { new Guid("f284a60f-f48a-449f-aa49-e2fbb19bff91"), "Missoula", "Jeanette Rankin Hall - there is a whole class of ghostly students attending a ghostly lecture.", "University of Montana", "MT", "Ghost" },
                    { new Guid("f29d918d-7f50-4625-95c2-e4982af22271"), "Bentonville", "There was a little girl seen walking down the hall without a hall pass  so this boy went and told the principal. He went and inspected the hall  and the little girl was skipping down the hall  running her finger against the lockers. It was found out that this same girl was hung by her friend in the year 1950. The sighting occurred in 2005.", "Old High Middle School", "AR", "Ghost" },
                    { new Guid("f29f4fad-7d4b-4782-9a2c-16b299cdbb2c"), "North Shore", "\"There is an old Hawaiian legend surrounding this location. It is said that there is an akua (ah-coo-wah)  or god in the pond at the bottom of the falls. On occasion it requires a human sacrifice and takes a \"\"victim\"\"  drowns them  and keeps them underwater for a few days. the body is never found before the \"\"ceremony\"\" is done. Then about 3 days later  the body is found floating on top of the water.\"", "The Drowning Pool  Waimea Falls Park (Oahu)", "HI", "Ghost" },
                    { new Guid("f2aa5709-de2f-4668-9b37-5a4bdaeb2ca7"), "Salem", "Witnesses walking up the path from the elevated crypt belonging to the Veteran from WWII  Korean War  and Vietnam  heading toward the tall hill. Received unpleasant feelings from the forest down the hill to the left. Upon looking off to the right  noticed a grayish white human figure about 15 feet from the road walking along side of us  going the direction we had come from. Sounds of claws tapping the path. Saw a light around waist level moving around near the top of the hill.", "St Mary's Cemetery", "ME", "Ghost" },
                    { new Guid("f2e64f72-f8cf-471c-aec9-8314c4ab138c"), "Weeks Island", "Two lights  moving as one in echelon  starting north at 9 o’clock horizon to straight overhead and stopping  no noise  faded into dark", "Light", "LA", "Alien" },
                    { new Guid("f359d8cf-8a61-461a-91be-b634d7576e03"), "Three Lakes Management Area", "Witness was sitting in tree stand hunting. Noticed creature walking at high speeds  not necessarily running but covering lots of distance in a short time. There was a pugnent odor kind of like that of the zoo where elephants or large animals stay. The way he walked was bipedled  hunched with human sillouete. Coned head with wide shoulders and no visible waist line. Height: 8-9 feet Weight: 4-600 lbs. Hair Color: Black", "Report 736: while sitting on a tree stand hunter observed bi-pedal creature walking at high speeds.", "FL", "Bigfoot" },
                    { new Guid("f3f9e5d1-9a57-485d-87e8-2b3f9d6bf2f6"), "Kingston", "Will Theatre – Theater J - There has only been one occasion of violence regarding George - a teacher who will remain nameless whom a lot of the students did not like was standing at the top of the steps leading down into Theatre J (next to Will) when she felt 2 hands shove her from behind; she fell down the stairs. Nobody else was in the vicinity.", "University of Rhode Island", "RI", "Ghost" },
                    { new Guid("f4422cea-5012-4f69-aa9f-40f5ddf5b078"), "very close to the lake  near a road called Alca Flats or Alca road", "\"While on vacation with my wife in northern NH/ME area called Lake Aziscohos. we decided to go moose antler hunting to find some dropped racks. while heading into a clearing we started following moose tracks  we went further past the clearing and came to a small water run-off ditch. Well in this small ditch we saw a very unusual track for anywhere in the northeast  a five toe'd track that was HUGE!!! I took pictures  I did not have casting material  but i do have pictures with an altoids box for size comparison  we estimated this track to be between 20-22\"\" long and I'd say about 8-10\"\" wide. this was NOT  I repeat NOT like any other tracks we have seen  the track had no claw marks  I've been an avid watcher of Finding Bigfoot and do wood knocks regularly along with screams. My wife WAS NOT a believer but after this print  she looked at me and said \"\"NOW I BELIEVE YOU\"\" this is 100% true  I took pictures of the print!!!\"", "Report 55290: Possible footprint found by a family looking for moose antlers near Wilson Mills", "ME", "Bigfoot" },
                    { new Guid("f4461a24-c4c1-4640-aa5f-74a1e8df3951"), "We were heading east on Route 9 heading into Brattleboro this happened just after the Dollar General. There is a large swampy area there. This area is very close to Green Mountain National Forest", "About 5:30 am on Rte 9 heading east in west Brattleboro VT my husband and I saw a small (I don't know what) running across the road. It was about 3 to 4 feet tall  long dark brown to black hair  running on 2 legs. I caught the animal in my headlights very clearly. The one thing we both said was that it was fast. Faster than any animal we have ever seen. It was crossing the road into the swampy area near the small whetstone brook. There were tall reeds there and it disappeared into them. We did not stop. in retrospect  I wish I had. It might have answered some questions we both had.", "Report 49993: Couple have possible early morning sighting while driving outside Brattleboro", "VT", "Bigfoot" },
                    { new Guid("f46a8d73-912e-4a2e-959c-0f251cf1f93f"), "Camp Oyo Boy Scout Camp on Rt. 125", "While taking a break during a hike back from the Lou Wetzel cabin  we were sitting at a picnic area just below the Clark cabin when we seen a creature walking upright on it's hind legs with long brown hair and piercing green eyes. We was only able to see from the waist up due to the brush.", "Report 4975: Sighting at Camp Oyo Boy Scout Camp on Rt. 125", "OH", "Bigfoot" },
                    { new Guid("f48478f5-4033-45e4-a5a9-6305b332133e"), "Coeur D'Alene", "\"March 2008 update: Has been torn down to make way for town homes. - This favorite \"\"Old Town\"\" Mexican restaurant is built around an original structure that stood in the original \"\"old town\"\" of Coeur D'Alene near the lake. Restaurant workers often see \"\"shadows\"\" and feel a strange  \"\"cold presence\"\" while retrieving supplies in the cellar. Rumors have it that a construction worker lost his life when he fell while the foundation was being poured. His saw was left between the wall where he is said to have fallen. Last sighting was 7-06-2002. Public restrooms are across the basement hall from the stockroom where the shadows are spotted at any time of day. Guests will often be seen making a running exit up the basement stairs without any explanation. The most common remark to the restaurant manager is: \"\"You know  that basement is really creepy!\"\"\"", "Senor Froggy", "ID", "Ghost" },
                    { new Guid("f4c9eac3-6b28-4b5f-817e-d4012a6adcb1"), "Santa Fe", "We saw the object in the sky south of Santa Fe just after sunset. It looked like a glowing white sphere against the indigo sky  and was", "Fireball", "NM", "Alien" },
                    { new Guid("f504b783-5383-43ad-abdb-40b3690683b0"), "Richardton", "My wife and son and I were watching fire works towards the west side of town from the east and we saw a fire shape bell object leave fr", "Teardrop Shape", "ND", "Alien" },
                    { new Guid("f581e85a-e28a-463d-9628-c1e84fe19695"), "Memphis", "\"The \"\"Rose Room\"\" is haunted by Molly Woodruff whose bedroom it once was. Her picture is on the wall and she wanders the house  makes a depression in the bedclothes as if she slept there  and there are cold areas. Her most famous appearance was the day the house museum opened in the 1960's when a docent saw a woman in the bedroom who said  \"\"My bed doesn't go there.\"\" That was the first of many such stories. Strange odars like cigar smoke have also been in evidence on the house's third floor from an unnamed visitor.\"", "Woodruff-Fontaine House", "TN", "Ghost" },
                    { new Guid("f5e783df-7163-48f9-8a69-7f52bc5db4e1"), "Terre Haute", "I saw a roundish  kind of out of focus white sphere  that eventually disappeared before my eyes.", "Sphere", "IN", "Alien" },
                    { new Guid("f6bd426b-c6fd-478b-b28c-ae18a310e277"), "Located in Flying Eagle WMA about 5 miles East of downtown Inverness.", "Yesterday  on October 31st  2010  I was hunting in Flying Eagle WMA with a friend when I discovered something that I thought was very unusual. It was around 10:20 in the morning when we decided to meet back up and do some scouting for our last afternoon hunt on my quota. I had set my friend up a few hundred yards or so from Hwy 44 in the morning before daylight and I continued on for about 3/4-1 mi. on the edge of the swamp we were hunting. As I continued on I jumped something that ran off and sounded unlike a deer or hog but didn't think anything of it. We were sitting on ground. After we met up we started walking back towards the truck and saw a couple of wet areas (puddles) when I said to my friend  let me check and see if there are any prints leading to the water to get a drink. As I walked over there to see I looked down and noticed something out of the ordinary. I called my friend over to show him. It was a footprint  similar to a humans. Not real large but kind of wide for the length of it. It was so fresh that you could still see the thermal lines in the mud from the bottom of the foot. It was the only one that we could really make out. The heal and ball made deep impressions while the toes were not really deep in the mud in comparison. I had my cell phone with me so I took two photos of the print and one of the area we were in then he marked a tree next to it so we could find it again. It just seemed very odd to find a print like that in the middle of a swamp! We returned after lunch for an afternoon hunt. I did notice one other thing with the squirrels after we returned. I didn't go as far this time  but I noticed the squirrels barking more than usual off in the distance. It is how they warn others of pending danger. As time went on they got closer and closer to where I was sitting and then all of a sudden went silent. Just an observation! I have spent most of my life in the woods in florida either hiking  biking or hunting this was the first time I noticed something like this. It is probably human but who would be out there barefoot?? We ended up laughing quite hard about it after we named him Eddie the Yeti and I will ad this is not the first time I have heard or smelt something out of the ordinary while in the woods.", "Report 28450: Possible footprint found and vocalizations heard in the Flying Eagle Wildlife Management Area", "FL", "Bigfoot" },
                    { new Guid("f7736093-1d47-4c76-812e-60a3d878641a"), "Missoula", "The University Theater - is haunted by a spectral dog  as well as a murdered girl and a theatergoer.", "University of Montana", "MT", "Ghost" },
                    { new Guid("f7804b19-ba2a-43c9-9fb1-65d6d61cf9e2"), "Rt 94 to Great Gorge resort condos.", "We were at Octoberfest in October 1998 at Great Gorge in Vernon NJ.  We were out on the back deck which boarders the mountains and the golf course.  My brother in law and sister with me.  Out of the corner of my eye I saw an approximately 7 1/2 - 8 foot large figure that walked with a long steady gate   with long arms and a thick chest.  It walked steadily down the mountain side glancing at us and continuing to walk.  We all looked at each other before running inside.  We all saw the exact same thing.", "Report 39329: Trio remember observing a tall biped figure by a golf course in Vernon", "NJ", "Bigfoot" },
                    { new Guid("f7fcdcab-015e-451e-b2ab-c49311bf71e7"), "Corvallis", "A janitor died from a heart attack in the upstairs gym. When the doors are shut and locked  he can be heard whistling  pushing his broom  the sound of his keys jingling as he walks. The lights mysteriously turn on by themselves.", "Cheldelin Middle School", "OR", "Ghost" },
                    { new Guid("f8299e97-fd56-4d5c-851b-b848fc61ac6e"), "Humboldt", "Granada convalescing hospital - October 2007: this submission has been removed", "Eureka", "CA", "Ghost" },
                    { new Guid("f8570cd4-2dd8-4662-93da-f02c316507d3"), "Macomb", "Bayliss hall - 501 - Story has it  a girl stayed alone in her room all weekend while her roommate went home. This girl suffered from severe depression. During the weekend  she hung herself in her closet. Her roommate then found her upon returning for the weekend. Strange occurrences now happen such as occasional lights turning on and off  strange noises  and cold spots.", "Western Illinois University", "IL", "Ghost" },
                    { new Guid("f87b51fe-4b8b-402c-ad0e-c8ba2560c889"), "In a remote location near Baker Creek road.", "\"You would be interested in what happened to me a year ago  and twice more in 24 hours  just 2 weeks ago  near the Humboldt Mendo County headwaters of the Matole River. I am absolutely convinced that some unknown animal exists here so I began on the internet a search for similar accounts.  While immersed in the Internet searching it became clear to me that your organization should have this most recent information in a timely manner. Last July 2018  I was staying in a very isolated region  which had very limited access  behind 3 locked gates and 20 miles south of Whitethorn  CA  on a primitive 4x4 road.  This place is at the end of the world  on the northern border of a vast green belt spreading from Shelter Cove on the coast  east to Highway 101   and south to Fort Bragg  and east to Piercy  as can be seen on Google Earth. About 3 a.m. I was awake  it was a hot and dark night in these mountains.  Something above my tent location  approximately 200-300 meters  began knocking on wood  best described as loud whacks on a tree trunk by a big club or branch.  It started with one knock  which got my attention  with a brief hesitation  then several more knocks  but randomly timed  some in succession  others after hesitations.  The knocking was loud  so loud that it echoed down the canyon. The event lasted only a minute or two. My first thoughts were that there was no one on the mountain who could be out here in the middle of a primitive and protected area.  These knocks were obviously from something large  and no North American animal could have made them.  I listened intently while my mind tried to wrap around how the noise was made.  The woods were silent  not even a cricket.  I told a few locals afterward and learned that there were other hotspots for squatch sightings between Piercy and up to Willow Creek. Flash forward to two weeks ago  when waiting at the first locked gate to this same conservation area  I heard two distinct vocalizations which cannot be explained. As I waited in the dusk for about 45 minutes  waiting to meet a party at the gate who were running late  I heard a very loud wail/ scream/ call that I've never heard before in nature.  The call of this thing I located at about my 2 o'clock  facing east  and up the heavily wooded area above me  about 200-300 meters.  I instantly knew where I had heard such an unfamiliar call....about 3 years ago when watching a Bigfoot reality show  where these squatch hunters were making this strange/unique call while searching for Bigfoot. There was a few second delay from the first call  then a few more  then silence for about a minute  leaving me to wonder if this whole experience was real  pondering what I know about the wilderness  either that was an unknown animal or some kind of implausible prank.  It was loud  echoing down the mountain  as though some huge creature could belt like the lungs of Pavarotti  only much louder!  The chance of it being a prankster waiting in silence with me for 45 minutes in that remote location  just to hang out in these impenetrable woods and prank me  went away very quickly when  when another call out at about 3-400 meters to the north of the first  approx my 8 o'clock.  It was also just as loud  just as unique as the first  but came only 3 calls in succession  u-ah-o  u-ah-o  u-ah-o  with a distinct higher pitch on the \"\"ah\"\".  This absolutely blew my mind  because the first call might be an elk on steroids  but the response from what was clearly not an owl  brought chills down my spine.  This was some kind of communication between two individuals  neither which can be explained by any rationale. I must tell you that I have trekked and lived in remote areas in Africa  Australia  central and south America  many places of potential danger  and never had an inkling of fear.  I was born and raised near Yellowstone Park  with 100 times the average distance trekked by most individuals in their lifetime  and never had bad experiences with grizzly  mountain lions and wolves.  Travelling all these years with a firm understanding of ecosystems  I never could have believed in such mysteries  that anything new would ever be discovered. I had a fourth experience  which I must say something about  but it happened just the night before the dual vocalizations. On Friday evening  Nov 1st  2019  I had just moved into a cabin that my brother and I rented  located along an extremely rugged canyon area of the Matole River.  It was dusk  quite dark already in the forest.  I was outside looking at the stars  taking in the newness of these rugged surroundings.  Up above  again about 300 meters up and to the east of the river  there was a screaming that was so loud and so foreboding that I could only listen in amazement.  It was the loudest screaming I've ever heard  so loud I thought it was produced by some kind of banshees from a horror film. The screams continued  full throttle  for over 5 minutes.  I know mountain lions can scream  but nothing like this. It sounded much louder  more guttural  literally as if someone had set up a loud speaker and played the bloodiest scream that Hollywood could produce.  At the time  the night after Halloween  I wondered if someone was up on the mountainside pranking me as a newcomer to the neighborhood. I listened for a bit  then went inside and told my brother about it because it was so unnerving.  Bigfoot did not even enter my mind.  But then at dusk the next evening I witnessed these 2 calls waiting at the gate. I have since been over and over in my mind  why have I been so lucky as to hear or experience such mystery?  Much less 3 distinct vocalizations which cannot be explained.  I began pouring over USGS maps and satellite imagery to ascertain what the link may be  20 miles apart  are there any people or neighbors or access for individuals in the areas I experienced which may explain these?  Could one individual in such obvious stress on one night  have triggered the coincidental travel of at least 2 more unknown creatures the very next night?? I have talked to many locals about hearing strange noises  but no one claims anything  or they don't want to be ridiculed. Look  I am a man  60 yo  with extensive wilderness experience in forests and jungles all over the world.  The closest thing to new species discovery for me was the Costa Rican jungles  but my mind has always been as a skeptic observer  dealing in evidence based biology as a science.  What has happened to me recently has completely changed me!  There is a mystery in these woods  and I have a few ideas how to answer them. Please feel free to contact me  if you would like access to these remote locations.  And I am very curious if other people in my area are having similar experiences.  Something unexplained to science lives out here  and I am beside myself with these recent events. Troy Hunter   troy.hntr@gmail.com.  There is very limited cell service.  928-231-3***.\"", "Report 63645: Mattole River Watershed (Lost Coast region) resident reporting loud knocks and vocalizations.", "CA", "Bigfoot" },
                    { new Guid("f88a3b24-11dd-4bad-8a34-425f7207854d"), "Binger", "In the old part of the school by the gym at night you can hear kids talking and laughing and in the basement you can hear footsteps and talking.", "Binger School", "OK", "Ghost" },
                    { new Guid("f8b80b91-4826-4156-9c6e-982ae6cc3ed8"), "Public Hunting Access about 3 miles south of Pella  IA in Marion County.", "Yesterday  October 24 my husband took our son duck hunting.  They were at a public access huntiong area in Marion county outside of the town of Pella.  My husband saw a crane and he was watching it fly away and pointing it out to our son when he saw something run across the trail about 40 yards away.  He said it was solid white and tall.  It was on two legs and very fast.  He said the weirdest thing was how fast and quiet it was  almost as if it couldn't have been there because it didn't make sense.  He said he got a weird feeling because it was just so odd and he had our son sit down and he loaded his gun and went to see if he could see anything at all of it or foot prints to indicate what it was.  However it was gone and there were no prints as there are leaves all over the place.  I told him it sounded like bigfoot stories my dad read to me as a child and my husband said he doesn't believe in bigfoot but it was just too fast to see its features.  Just two legs and running upright.  It was too fast for a man and so quite with the leaves and all.  My husband said he doesn't want to look like an idiot and hear the jokes so he is not going to ask around about it and he isn't sure he would say it was a sasquatch because he has never thought they existed but he cant think of anything else that does exist that it looked like unless a super fast man in a big white hairy suit  with the grace and quiet of a ballet dancer was running through the woods.  Are there any authentic sasquatch reports of a white one?  I don't know a lot about it but my husband is not one to get scared outdoors or to make up things.  So  I know he saw something strange.  Please mail me as to whether or not they are all white in color.", "Report 511: Daylight sighting by duck hunter near Pella.", "IA", "Bigfoot" },
                    { new Guid("f8d1530f-7810-4645-b6a3-af77d01d8824"), "Platoro", "built 1945 in the tiny mining town of Platoro  Colorado. The Lodge is a 3story log/wood building and contains a general store  a restaurant  a game room  and guest/employee rooms. It stands at 10 000ft. elevation in a valley of the San Jaun Mountain Range in Southern Colorado. There is much history at the lodge and in the Platoro area in general. Platoro was founded in the early 1880's to provide housing  food and even a post office for local gold/silver miners. One of the ghosts that haunt the area/lodge is believed to be 'Little Eva'. Eva was a 16yr. old prostitute that was shot by the wife of a local miner. Her grave is an unmarked concrete slab that's in a field about 150yrds from the lodge.­ - (private property)­ - Another 'Spirit' is believed to be Henry  the ghost of a man that passed away(1950's) inside the main lodge after suffering a heart attack while hunting. Some of the mysterious things that happen are; Shadows(silhouettes)passing by/behind people when they're alone. Bowls  silverware  plates getting thrown off counters and shelves. Doors opening/shutting  even locking on there own. Numerous cold spots that are almost always there. The sound of furniture being dragged across upper floors when no one's around. Things missing and turning up in strange locations  and fires in the main lobby fireplace starting/stopping on there own.", "The Skyline Lodge­", "CO", "Ghost" },
                    { new Guid("f9b7dda3-9853-43f8-9e37-3b2fceff034f"), "Westminster", "This church is unlocked at all times. If you try to take something out of it  it will become too heavy for you to carry. If you light a lighter in the church  it will fall apart.", "Toccoa Presbyterian Church", "SC", "Ghost" },
                    { new Guid("f9f7a58f-0f3a-4a92-a253-9e1a85cd7648"), "Sacramento", "\"Ghost lights appear from time to time. A woman's voice saying \"\"Te papa\"\" near the Sacramento River. Sight was probably an Indian Burial Ground or Mine Shafts.\"", "Sand Cove Park", "SC", "Ghost" },
                    { new Guid("fa0105d7-66f4-4670-bd58-674a65f86a60"), "Clinton", "Before the old elementary school had burned down in 1998 it was believed to be haunted by the people who were once buried there. The tombstones were said to be removed but the bodies remained under the school. Numerous of students were said to be locked in the bathroom  heard and seen doors shut by themselves  and could also hear noises.", "The Old Hickman County Elementary School", "KY", "Ghost" },
                    { new Guid("fa319324-3c6d-4f3d-b9fe-41339b526b59"), "Mobile", "The Seaman's Bethel Chapel Theater - The Seaman's Bethel Chapel Theater - The basement is haunted by the ghost of a small child who plays in the costume shop. The ghost of a seaman in a captain's coat haunts the fly loft.", "University of South Alabama", "AL", "Ghost" },
                    { new Guid("fa5a94a0-2b8d-45c0-b52c-aa1cc203cebe"), "Calumet", "As you go in the old place back in 1903 a man was murdered but all sorts of orbs were seen and sightings and even screaming in the break of the night as you still go there you can hear screams and screams of a young girl that had died there her name was Elanda Rowe. The ghost of the great actress Helena Modjeska has also been seen here and is considered the resident ghost.", "Calumet theatre", "MI", "Ghost" },
                    { new Guid("faad3076-74d6-47da-9aea-6584c0b695c8"), "You can see the mountain from on the outskirt's of town. You can basicaly see the peak of the mountain that the sighting occured.", "\"My uncle  my six year old cousin  and I were on one of our little weekly expeditions to explore the surrounding mountains in Winnemucca  Nevada. We were walking up the foot of a mountain on the ridge of a wash and there was still about a foot and a half of snow on the ground when my cousin said that she saw a guy standing on top of the mountain and I said \"\"There's no one up there  it's to far from any civilizations. It's probably just a juniper bush.\"\" But about five minutes later  our 95 pound Doberman/Greyhound mix made a mad dash underneath the truck by the foot of the mountain. (And our dog was not one to be scared off easily  it scare's away anything that comes close to the house  and it even took on a mountain lion once  it has the scars on it's underbelly to prove it.) Just about the time me and my Uncle looked up towards where my cousin was pointing  we heard a low  droning howl and what I thought was the juniper bush  was animated now  walking downwards  and swaying side to side slightly. It spooked me and my uncle because on the way up we saw a totally decimated cow carcass! About that time we headed out to the truck because we were pretty shaken up by what we had just seen. We were reluctant to tell anyone in fear of being laughed at and ridiculed.\"", "Report 20780: Hikers spot a dark figure walking on a snowy mountainside near Winnemucca", "NV", "Bigfoot" },
                    { new Guid("fbf34c0e-10bb-4a9a-af04-0c6f543ffcba"), "Aztec", "\"There are several ghosts. One is of a lady that floats down the stairs. We've personally experienced an old man in room #7 who's very \"\"cantankerous\"\". There is also a tree in the back that was the site of a hanging.\"", "Miss Gail’s Inn", "NM", "Ghost" },
                    { new Guid("fc4afaa9-5a5a-4b3d-a69e-563ac4ea6339"), "Columbia Heights", "Triangle shaped object traveling east to west approximately 45 degrees above northern horizon.", "Triangle", "MN", "Alien" },
                    { new Guid("fc543eca-6061-430e-9539-86a65355cb72"), "Arnold", "cold spots  during renovation... things had to be replaced over and over  windows broken  & paintings falling off walls.", "Rugby Hall", "MD", "Ghost" },
                    { new Guid("fc642904-4b53-4d77-9827-996f17289f41"), "Hill City", "This now tourist attraction  still uses authentic engines and cars from the 1800's. Many abandoned train cars still sit on the train yard  and many strange occurrences have been reported of them. The Highliner Eatery  which sits on the train yard  is an authentic dining car  and one employee reported seeing a strange man in a brown suit standing in the back. Seconds later  he had disappeared.", "1880 Train", "SD", "Ghost" },
                    { new Guid("fcc3e180-45dd-43a2-940f-c0fa5d8bedea"), "New Castle", "The old Whitemen Homestead is haunted by several ghost. There is a spirit of a civil soldier that walks across the dining room causing the lights in the room to flicker and go out.", "Shenango Township", "PA", "Ghost" },
                    { new Guid("fcfaa72d-ad24-4631-810e-28ca67460efc"), "El Paso", "The men's dressing room at the amphitheater is said to have lights flickering and the sound of someone running across the room and banging the walls. A man was said to have died while constructing the buildings there.", "McKelligon Canyon", "TX", "Ghost" },
                    { new Guid("fcfe4d8c-a8c3-44de-bcf3-1995a4835a57"), "Roseville", "The old abandoned Prison in Roseville  just south of Zanesville and East of Columbus is rumored to be haunted. On some nights it is said that the ghost of a woman dressed in white can be seen falling from the roof of the building in a re-enactment of her suicide. Also  ghostly shadowy images are said to be seen peering out of the guard tower.", "Roseville Prison", "OH", "Ghost" },
                    { new Guid("fd14e441-9edf-4b25-bc29-03b887a4be11"), "Edgerly / Starks", "There is a small pass that connects two graveyards: Antioch and Big Woods. There used to be a gate at the connection of these two graveyards. Now there is a sign that states  “beware of Children…or children at play” The legend is that if you see a shadow pass in front of the gate when there is no scientific explanation for a shadow passing there  Then that is a serious warning that you should not be passing there. Some who have passed through the crossing after the sighting of the gatekeeper have never come back. Numerous Ghost hunting societies have lost Compact Flash cards and Hi8 video tapes from the electromagnetic interference out there. Numerous photos of orbs and ectoplasm have been taken here. SWLA Ghost Society has written documentation that this place is in FACT haunted. People have been chased by a truck that seemed to have no driver. Cars and trucks come from the cemeteries  drive to the woods and just disappear.", "Big Woods Cemetery", "LA", "Ghost" },
                    { new Guid("fd1e6bf0-028d-4bae-9d82-0fbea372f0de"), "4-5 miles north of wadena and 1 mile west of hwy 71.", "\"Younger Brother: In 1992-93 we went to visit family friends.  And when playing outside us kids built a tent-like fort over the clothesline.  With sheets and clothespins.  Then later when were called in for dinner we went in and ate.  Then watched a movie.  And as now it was late we decided to leave on wishing us farewell the owner of the house saw the fort with her sheets still up and said \"\"no one is going anywhere until those sheets are in the house\"\". So me being little I got out of the work and got to sit in the van with my mom. Who turned on the head lights so they did not have to dismantle the fort in the dark.  As we are watching this my mom says \"\"hey do you see that shadow over there by the tree?\"\"  and I tried to look but could not make it out.  so she took a flash light and shined it in the vicinty but not directly on it hoping not to spook whatever it was that was only 20-30 feet from the kids and the clothesline.  she asked me again if i couls see that thing just standing there watching the kids take down the tent-fort. when i said no she called over my big brother who instantly saw what she was talking about. And in his excitement he grabbed the flash light ran towards it. and i will let him take it from here. Older Brother: I approached the clothes line and held the light on the trees just beyond us and never did shine the light on this shadow figure due to i was afraid too. But what i remember from then was seeing the out line of a dark colored figure. It was adifferent shade  than the tree bark. it was near 6 in a half feet tall or maybe 7 feet. I was about 5'9\"\" at the time and i felt very short upon seeing this shadow next to the tree about 20 feet from me and my sister and her friend. We all saw this outline of a tall man near that tree when i told the girls that there was something by that tree watching us. It never moved from its position by the tree it stood up right and just seemed to watch. We hurried quickly and gathered the sheets off the line and i threw them in a bag and gave them to the friend as i was scared and so was my sister. We ran to the van and she got in first and i followed. My seat in this van was not a normal seating position. My folks had installed another van seat in the van that faced out the back window. This was the seat i took and sat in this night. Mom backed down the drive way. As she turned on the road the head lights passed over the spot where the figure had stood and everyone but me at this time say they saw the what looked like a upper body shape or a set of shoulders that where large. Mom started to drive forward towards Wadena and as we pulled away from this sighting of this shadow and figure. I watched in terror as i saw it running down the tree line towards the road we were on heading home. I told mom to drive faster and to this day she claims she was doing about 30 miles an hour on this dirt road. I watched this thing take and turn at the ditch and run real fast and real close to our van it had kept up for the first half a mile. Before it must have given up on following us anymore. It never ran on the road it stayed in the ditch and was fast. It didnt pump its arms when it ran like a sprinter does. The arms of this beast swung long and almost like with ease right in stride with its long stride as it kept up very well with the van. I know it didnt run like a mile or anything but it was almost a half mile that it did and never lost speed or footing in its steps as it chased us. Younger Brother: I would like to add someting now to my brothers discription. First off will never forget the feeling of not knowing what was going on when he hurried and took down the fort quickly.  I could tell he was scared and remember very clealy as he ripped the sheets off the line the clothespins popping up in the air madly.  I knew something was wrong   I was eight or so and this was my big brother.  Nothing scared him.  He was like the strongest person knew. And when my brother said it was chasing us his seat faced the back but I turned over the second seat and you could see it plainly in the red light provided by the tail lights.  There was a shadow on two legs not more than ten feet from us running in the ditch after the van.  It was very fast and especially for its size.\"", "Report 25323: A family is chased by a sasquatch near Wadena.", "MN", "Bigfoot" },
                    { new Guid("fdaeaff7-7bad-4c3a-adc5-30aeecd465a0"), "Debary", "I saw a bright green oval flying object that was stopped over myself and my dog as I was walking to my truck.", "Oval", "FL", "Alien" },
                    { new Guid("fdbef7c0-2a86-46dd-855c-3a01eac85fba"), "Jackson County", "The story is that 15 or 16 little kids got detention and were locked in the boiler room. The boiler exploded and killed the kids. Now if you go late at night then u can hear screams  sometimes you will see little kids  if you take pictures and get them developed you will see orbs and strange smoke that is in the shape of people. But when u look at the spots in person there is nothing  but in the pictures there is freaky stuff. On the walls in the boiler room there are child size handprints burned into the wall. -  November 2005 update: no screams where noted. A well-defined shadow of a little kid was seen through one of the glass doors in the school. The investigators watched this figure move from side to side of the door and then it walked toward them through the door and stood still for around 30 seconds  all of the sudden it bent down and got into like a 3 point lineman stance and then jumped toward them  they turned the lights on and there was nothing there. They placed a voice recorder in the boiler room as well and got what sounded to be a heartbeat that kept getting faster and louder and then made one loud beat and stopped. Also there was a loud moaning throughout the whole schoolhouse from the pipes but there is no heat going through the pipes so I have no clue why that would be making noise. An update to make on the school is that it was demolished last year and made into a park for the community.", "Elementary School", "NC", "Ghost" },
                    { new Guid("fdfe7f62-bc4e-468c-a06b-446b71f2f76a"), "Omaha", "Craft looked like a triangle in cind of a pivot so that what I think was the back. Craft allso looked as if it was engulfed in light", "Triangle", "NE", "Alien" },
                    { new Guid("fe269cbb-d7b8-4554-9eb2-1340320537c8"), "Mason County", "T.N.T. area - Called T.N.T. area because the U.S. military used to make explosives there during World War II. There are over 100 igloos in the area  where they stored the T.N.T. This is the place where sightings of the Mothman have occurred. The first sighting was here at the old North Power Plant  now destroyed back in 1995.", "Point Pleasant", "WV", "Ghost" },
                    { new Guid("feb643da-eafa-4641-947c-f3950922c061"), "Yuma", "Students often hear and see visions of Mary Post  as she haunts the school. There is also a picture of Mary above the exit doors  and sometimes when you walk out  her eyes will follow.", "Mary Elizabeth Post Elementary School", "AZ", "Ghost" },
                    { new Guid("fee004f4-1379-4cb5-91a0-30fbd6dca6e0"), "Festus", "2 large orange lights hovering near each other. Moving up and down  side to side. Zoomed & disappeared  seemingly realizing us noticing", "Fireball", "MO", "Alien" },
                    { new Guid("ff04c2e5-8003-4e60-adf3-cdf8df747937"), "Anchorage", "Anchorage’s oldest hotel is haunted by many things. Several guests have reported seeing a young girl walk the second floor hall. In rooms 215 and 217  the television will turn on and off at will. Also  the water in the tub and sink will run by itself. Employees have reported hearing people coming down the stairs when the hotel is empty  and few have seen a man walk past the stairs.", "Historic Anchorage Hotel", "AK", "Ghost" },
                    { new Guid("ff291c00-0ba2-4e63-b3d0-efc6290bfb9a"), "Ferndale", "The ghost that haunts Hart Theatre is called Bertha and is often seen late at night. One report claims she takes the form of a phantom cat who strolls down the aisles during performances. Bertha also performs other tricks such as locking the bathroom door from the inside and answering the phone at night when no one is there.", "The Hart Theatre", "CA", "Ghost" },
                    { new Guid("ff7835b5-757a-4f9b-850c-d35762951403"), "Brewster", "White dots moving across the sky.", "Light", "MA", "Alien" },
                    { new Guid("fff31393-2d97-4669-b85f-90242c109838"), "West Chesterfield", "Stone spiral stair case  fire place on a cement foundation in which the Madmen lived some people say that this place has an estimated death toll of over 178 people. - December 2003 Update - The public is allowed there until dark. Also Madame Cherie ghost is supposedly protects her buried treasure  even though in her will  if you find it  it's yours.", "Madame Cheries", "NH", "Ghost" },
                    { new Guid("fffe955b-5f9a-4d51-9a24-a6a1ededf3d0"), "Randall", "Darling Church - Early after being built it is said that two African American men kidnapped and murdered a woman in the church.  Being that murders were placed on the shoulders of Africans in that time it is no surprise that it was in this case either.  It was rainy that night and a nearby farmer was said to be out in the yard getting something out of the rain and heard the scream of a woman.  To him it sounded from the church  but because of the weather he didn't pursue what he had heard.  He figured he had heard the wind.  The next day the woman was found dead in the church (cause of death unknown).  Two African fellows were traveling through at the time and the death was placed on them.  They got out of there as soon as they could being either they did kill the woman or they knew they would get the blame.  The farmer never forgave himself for not going to the church that night.*  Few people have said that they had seen a figure of the woman roaming around the graveyard behind the church and the church itself at night.  They also said that further away from the church they heard a woman scream coming from the church.  The ghost is seemingly harmless.", "Little Falls", "MN", "Ghost" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0006a6b1-b388-4bbc-b8d4-7d95b38f18d4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0044c8f7-8175-40fd-b41d-7f5e19db552e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("007abd1d-1acb-433c-81dd-0c475950be75"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("00c83289-0063-41a4-bc3f-1e5d4a2fcedc"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("01437f51-7ccb-4a69-9d5a-baa93e9942e2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("017469ee-d7d1-4211-8c6e-3bf4a55b5bea"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("018ee894-de65-4d61-804a-0730afd67155"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("020536ad-323a-417a-af67-d6410ff19c52"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("02203c32-6b42-4785-b372-25c04972156c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("02afc222-5290-48d3-80f5-30387a39ba10"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("030bc30f-2596-4a6e-97fc-94eebd21bafc"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("03414189-ae2b-4cb1-b6d3-6d3d833f1842"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("034b1ff6-7e5e-473b-97ba-0e960e0055d6"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("03b23a09-2aee-40ec-8ac8-f025290e1fc7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("03d35449-9ba7-426c-a3eb-5ab149cc5a8b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("03f158d6-5717-48ec-877d-f438be4e9496"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("041658c4-e838-49a5-8112-e7ab1fc73f59"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("042f1013-ba22-4e74-8aea-2bee3c2769f1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("051a90c0-2c1b-49a2-b57c-a480de0cdfd8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("053e8509-f1c8-4cf4-a557-20afdc5123de"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0563c1ab-69d3-4bcf-8009-d825121c758f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("05972b8e-34d0-41b1-8fea-3d1c2abf98a7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("06086f1a-4258-40d5-94c6-de1915b203c3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("06141bc3-e9f7-4bde-825b-f9245af36b3c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("066b892c-1707-4db2-b1fc-70c5dce7a1d2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("071a9037-cde1-4b0f-bbc6-75e9d8c484b4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("07f99d60-1a11-4e24-938f-0c393b897ab0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("08a7c582-d3d6-41bc-982c-adc4736f357b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("08dba54a-a00f-4157-ac10-980045ba6c5b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0912ebb4-37c0-4f19-9f12-bdc92486a647"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("091a466a-cd42-427b-840d-8b18fc5e2af0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0952d8dc-1b7d-4147-9cb9-0d0d938dbb37"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("096753ac-b359-4e8d-ad22-5f80ebdb72de"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("096bc17e-3d02-4a4a-aade-165e3c563fbe"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("09b9bcd6-8293-4d8d-8bdc-d604f7acfeb8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("09c09121-7f54-4772-862a-7d694cad2476"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("09cc4d4c-df80-4505-a53b-07c6bab44aef"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0a00c710-f701-445c-abcc-c70147a48f0d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0a3027f2-436a-4c82-be8f-715e29bc6264"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0a351f31-ba06-4df4-8df8-51102db7d862"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0a35baa9-bff0-4829-84a2-134def6183ac"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0a3bea6d-506f-46f7-b82a-4e611c74df0b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0ac7b6ad-afc3-46ba-9716-aca4d294d7aa"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0ac9f3c8-16f1-4cfa-aaf6-269e3e3bfec1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0aee7704-49d4-45cb-b9db-d1073a4ead6f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0b1c00b9-ae92-4c10-9169-81941fe45d46"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0b47d38a-8da7-4127-863c-bd01f8f880d9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0bab6451-b303-4a90-92bb-c5d18d3c4920"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0badc05d-dbcc-4e0d-be87-a72653df8cdc"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0bbdd4f1-43bf-454e-ac45-8befa5948d81"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0bce51ad-9ec4-4f77-b2c5-d07e46884e53"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0be2608f-d71b-4cb1-8466-159345315cf5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0bfbdfba-6d42-425c-852b-ed1b9c5f02d4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0c36370e-6957-47b7-ad52-08efb6124f3f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0cc865b7-9d52-479a-8089-1d435d8ae962"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0d040fee-87e3-4cd1-bd8c-78d346a41cae"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0d6effee-1fd4-42e2-93b6-e619083939ac"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0dc133b2-950a-48ba-905c-74a58806d893"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0dcbe3bc-4e69-4a7c-a47d-4e5fb0146a82"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0e1af43e-72dd-4921-9692-a52a2b58db47"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0e1d3317-c2b1-4dc9-98c7-75fbcb06de54"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0e35a887-227e-4175-91e8-79dac4438d01"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0e6e4eae-8707-4604-b216-b66753e010fd"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0ebe9309-0316-44ac-a907-ebac5d5b38f3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0eebdf7a-9d4b-4748-879d-6bb2fb1214cd"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0f1434d7-f2b8-456e-82a1-425e9269792c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0fbd8b44-e266-4186-b320-11473bc1ab59"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("0fc4b5cf-d09b-4353-bb70-820be10e4505"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("101d1aa2-62de-4b61-8eef-cf376576fbe0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("103757ae-64fc-4db4-bc3f-d461cb994088"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("10cee965-432f-4de8-b331-29afaa112b83"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("10d9fb79-fbd3-43e0-8d7d-a8d757c978fe"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("10f2058c-3769-4949-9df5-09f9a562dc51"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("11b9971f-792e-4e2d-ba34-67bb5c6a7220"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("11fb571e-5517-414a-9435-003a3f914773"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("13c49440-e018-43ed-a3c2-de1d93e4ac00"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("13d85bb0-934a-480c-a8f0-544bb7746015"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("14474980-4160-41bc-85cb-1defa40b5cf7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1449199a-d22f-4a07-90a6-f4d148582966"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("156d3d61-734b-4af7-8732-12095b80a7e6"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1590b215-2a37-451b-8442-522bd2176c00"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("161e1b4c-26a6-425f-828f-f8229b3022f7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("16afa4fd-1e70-47d6-abe5-38efc1cc379c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("16b0cd5c-4c6b-4157-9cb1-76c650f0ce11"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("16c3c220-06ee-4cdf-abae-4e7c9d9f04e4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("16dab1cb-e9e3-4c0d-a44f-7744ccc4a2f3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("17682841-5eac-4a87-9017-aabceaab500f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("176901fa-2070-4bb2-8a3f-09aaadff6748"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("17739a33-6e6e-4c64-b16b-fd93cc9ab0be"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("17a40737-c105-4edc-bb1f-da11af5d9471"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("17b1c67f-8320-4d63-a472-c758915fee11"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("17c9d75a-7320-45f1-9688-f735a502391d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("17dc5734-fa92-4ba1-8b16-f853ec7303f6"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("17e3de2e-f861-4f33-8f14-92a6ac87fe56"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("186bdfcf-de23-494a-9938-f510d15ee416"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("189723f8-1438-4480-b552-a32500fc445e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1897bf9c-6e88-4f04-9386-c0d7ba9a4f83"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("18de0c6a-e494-446c-9c91-16eb8d898367"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("193740a2-5b99-45c8-88b4-1d498011eb9a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("199e0205-3021-4ea6-b27d-ebafe5d63636"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("19b39fa9-f6ec-4f6f-8419-058608ecb11b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("19e972da-94b5-4985-8f2c-2172e855af6a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1a38c01e-3b76-4f4e-806f-83b394070483"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1b36ff63-7c22-4dba-ae52-8f19ee86d65f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1b94c656-438d-4650-b7d7-b6c65d30e9a9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1bf75784-b305-40a7-b9ff-47f137e833f3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1c739ed9-e5e4-4fab-8740-aa3b6996e5a3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1cabbb58-0e54-4cb3-8bdb-17226172d3e1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1cc1f32d-55d0-46b5-a3a0-56abf8b998db"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1cd6731a-db70-40e7-adf6-875f40efa53a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1d3780d5-4c0b-4a2a-86ed-f1ee528169fa"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1dc67711-0d96-4d75-ae49-3db6c1cfcb73"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1e3f3935-112d-43af-bf14-1ae379066f16"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1e60335a-628a-4d5f-8c78-b6cee7132e68"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1ed1eef9-d924-4aac-9807-ba372dac6080"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1f0e6048-41b5-4279-be79-394d76d96b93"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1f6cf84d-ac1e-484c-b3eb-e938dffb5973"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1f7e698e-66ff-4f72-af30-450fb4757ef8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1f8fa399-2586-4a1b-affa-ed7531b69f18"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1ffbd4a5-9f3d-4952-937f-d9798d5cc520"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("209fd0da-cb6c-478c-9cb4-d5b2ed0d662d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("214c44b9-15d6-40fd-bcc6-805574384805"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("219a2b02-3dab-44b9-8bb5-35ef2a81f47f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("22542c21-deae-4a3c-98e0-8314127bb20a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2273d4e6-991a-4878-b4fa-fa896f8471b1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("227774d2-82a3-431e-b33a-65c0ed48744c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("22970096-f3cc-4e62-8a1d-347764ded031"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("22c29c56-3b51-440d-8dcf-30e7a063a118"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("22c9b7d8-ced7-4e6b-b933-f67cbd30e4f5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("22d3940d-308c-4955-b391-898bc267a715"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("22e9b3bf-f9b9-423d-870c-5263cd11eed8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("23bc6cf9-01dd-4979-923d-a18e3e969ed4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("23c4fc55-a6c1-400e-b944-b897d5a6eeb4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("23e6bbbc-fce1-4e0f-91e7-9546d3c07b8f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("241fea4b-ae47-4cc3-b95e-029860427e71"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("246ef391-136d-4e59-9d36-625ece60dbcb"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("24951ec1-001a-467c-9d92-153fa61f645d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("24b3f016-7698-49f9-a756-85a787111a1f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("24b76fd3-86c1-4e69-aba4-fa787f6d3b38"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("24ecd2fc-0701-47e7-9141-d2482dc22b71"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("24f23f98-daf4-4c12-aa19-09195efd0095"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("250f916e-1c32-4b78-a994-23d3d2235767"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("25256a95-df1b-4654-9ac1-030df8f94b27"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("253e7cc0-f1cf-47f6-927e-0438a72f532a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2595f480-eea2-4d99-a173-632f8be4703d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2596237f-bed3-4bb8-b866-a57ed67cf6fe"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("259af3ee-d74b-48cb-ac92-c036d8ff83b1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("259f56fd-595b-4c39-8f90-ea87414a1792"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("261a3b4c-3cec-4672-be7f-8fcc2efe7067"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("26304a5d-1272-4420-a157-88e79086fc51"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("26394704-c402-461e-a4ef-2ca440cc0874"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("26818583-6a27-4eb5-a17d-a8491ab23ea4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("268b725e-96f9-456f-80a2-053427012245"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2704e751-8f5c-4ac2-ac5d-5884a7a01ce3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("274922fb-903d-4af1-9dd5-433c9e999790"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("278d9e32-3334-4b62-8edb-c9a1949ce5f5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("27b21a45-138a-4d29-a533-914669581a69"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("27d87c55-0320-4a31-8600-a5bc6d3e01cb"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("28240cab-b4bd-4a97-9873-2046887e965b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("283e64c1-45fa-4859-8f5a-4d6cb954fcef"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2872ea8a-facc-4cb7-8689-38bb2b43b953"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("28900b41-3dcd-40de-82f6-3a021c395bc5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("28f595db-b9f7-463a-829c-c83694c3b8db"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("29a460b2-a3b4-452a-89ba-88cd643a052e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2a2c4b75-dd38-4446-914e-32a2b2846ed0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2a77a556-0933-45f4-8dce-51b3caf6468b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2a7e305e-b129-4ec5-9284-a9f00ca64d1e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2a9e4007-1aa3-4ba6-8716-5de1faa644c2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2b3df370-83ec-4b68-a9bf-318f3fc9315c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2baa2904-b205-4df0-b462-fa53b18be219"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2be40403-0702-4464-9a40-73cfb1172eea"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2c7bd856-efb1-422a-a3f6-328f049726f7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2cc91e1d-fe1c-495a-b1ba-dc74541c4db1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2cd9c2bf-b67a-408d-920e-f38d498d5cfa"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2eb5b721-f795-4f84-9f48-49dde8c48167"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2ede0380-b999-4951-b288-1d5476ede6ff"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2edf430a-4e93-4db1-8020-92ed3ffa5808"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2f304cc6-fa1a-40ac-8999-538106e961d2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2f48ea41-62bb-4448-8647-f48827dad1f0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2f925d2e-a154-46cb-8323-009ae8c4caa5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2f9dfb2c-d2fe-4b06-a8c8-99ccf36223ef"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2faaaa78-c122-4f95-a087-07e780997c4c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("2ff53645-b47d-4d5c-b543-bb00ea0201a9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("302cc49f-4faa-429b-aa6d-92891933fda4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("302d621f-918f-411a-9d6a-5306607d19c8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("303144c1-3160-414c-a109-f29e3c035bdf"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("30c96cb0-9a5b-433d-a6fb-88860c1d48dc"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("30e6892d-1876-4574-8ea9-7f4a1a1b1f95"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("30f9742d-5a28-4ebf-9652-57ad7f0cae50"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("31508f62-9526-48b0-bf80-222b7f69a7df"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3155c68e-73f2-4017-82be-bc0cb0234e1c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("31640b3f-8df4-4425-981b-c026fed21473"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("31c12b0c-8bdb-4dc9-ae24-d9bc5fd37b40"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("32056bd8-55d9-4e82-9579-baafaa1830d1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3212a268-cb47-4997-aee4-4297acc4b854"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("32600232-5586-4590-a40e-0d8dff323810"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("335fa1fa-6f9b-44c1-9c69-687e671fd0ff"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("337f8d89-f594-47e1-959a-dacf7f836b69"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("33c0149c-7d10-440a-bc17-73cb47afc80c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("34ca190b-bcaa-400b-b370-75fc0b3d21b1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("34ddf18d-ef20-4aef-a0e3-2a4acbbd29a4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("350a0e3d-4abe-45f9-bbbf-941e5c0840d4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("351f3fee-4d8b-4f94-a66a-21c48e918648"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3545be65-004e-47b1-996a-94c6118b766c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("35593af8-4de4-43ab-982e-663d9b310c55"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("356ef076-f683-4f19-b1cd-d93d47c69c36"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("35da0e1c-b124-4418-8172-69a8f1be316a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3647e02a-5ae8-44af-bfce-78002761d0da"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("368bbfb0-84ed-435d-b366-6bd1a0cb6b8e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("36a7a859-cf86-4baf-abdf-768f59d827b9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("36b17ecb-cc4b-4f57-8fde-9627c297219f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3718406e-5f1a-4d2e-abdb-4b382a76a4fc"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("371a099b-c8e7-4e6e-a0b8-abcec02ae839"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("37471fd6-4a4c-42e0-bb38-398d9ca069d2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3751d682-01da-4803-9c89-9fd8a18ca48c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("37e7b3a2-d420-4509-ba3e-a231d1f5d7e7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("37ee0f0b-5de2-478f-93d2-b30e8d4bf02b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("380c9b38-8a6c-464b-8973-0b216cd7ad2b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("380cf5cb-a363-44c3-bf02-829007efe925"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("382c381a-8db4-4faa-bb45-68df515f0c16"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3864baf9-af40-41db-9c00-9a98a8808885"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("386ed893-fa44-45f1-b785-d831754f4cfb"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("38cf6feb-ca27-4910-bdc1-f4cd673480b9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("38e6594f-161a-4f54-92f1-296cf9b6045f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("39061779-56d0-4705-b5cf-0e4459279846"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("391fd1a9-0528-4217-a5a9-e6975114919a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("39418af3-fa22-4434-9ec6-365f1161ba42"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("395e9fe1-5a7f-46c6-927d-89403fdc0bf3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3972a9ec-c899-4f11-91b7-a141d30e7f4e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("397b8aae-f858-4cc0-845a-ee6ca267a4c6"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("39c51ed7-ddb5-4678-9552-3c27e1b5c04c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("39dad60d-9adf-4c71-8a69-cc58a587bd82"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("39fb816a-3465-4720-97c8-f8c3a5ebd1b1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3a607cf5-a38f-4bec-8e63-bbeebf78d08c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3a86243f-15a2-4bb1-8c4d-bad2e2b6c861"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3ae4784c-8717-4baa-807d-26f8d3dc2f36"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3ae9e4bc-36e6-44d5-a72c-bae325dac8d6"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3b34bec0-2810-42b4-972c-72c38198630e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3b5f95c9-cf9a-469c-9c4c-7ec7490523dc"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3c2ebc0a-229a-4654-abff-6ecba3496028"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3cd88362-7d4b-4300-9f50-8ef8f3b1e29d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3d070ad3-b759-4182-b4c4-bf1d786aec35"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3d29b982-242d-4d16-af65-85dee90d8291"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3d4e7a8a-789f-45df-86af-57987385465d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3db972d3-9db2-4a38-aa9e-680c621eeaec"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3dc8e509-117e-4010-a24a-248921a1e7ab"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3de27e29-6f6f-42fc-9f5a-0d50b41169af"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3e0b717b-2631-49fa-a1ee-a4a13e49b647"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3e0cdfb5-3958-4448-b936-2af0b5344289"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3e697db2-22fb-47e1-b9f8-f2309d589b36"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3eb6db39-15cf-414d-be32-431b90123153"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3ec6506d-6c61-47a0-816f-5ec3093b0e4e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3f4f35dc-1067-45e3-87d4-984c74fd6ed4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3f688d80-519b-4643-afd7-f4ca4565193e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3f77eba2-572d-40c5-918d-5a78f84864ed"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("3f97aff2-00c2-47fd-af5b-51b7b2f1d416"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("40091e78-339f-490e-b89a-bf0a553b79f7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("40babfc8-ecd1-499b-b8d3-e135b8e26413"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("40f65e0c-b0b0-4baa-9e51-737fbeb50a10"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("40f9b519-df17-4e4d-baff-0b66eaf09317"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4151647c-dca7-4695-a235-0f983f567081"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("415cc749-c105-4ffa-bed7-ce781a591fa6"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4186664d-de68-4bf6-bb99-742c22b30a56"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("41e60f88-174c-40b5-b7d4-52c9cad7ccfe"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("420f03d0-9c29-4c67-ad20-a6d965af5cd4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("42146423-85cf-4069-a071-9747205bb476"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4260d766-5810-4241-bbc0-64a37a8dc07d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("42a5db9a-429e-40bd-be09-889739033691"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4300da81-ed85-4b3d-8adc-4243d3ca4333"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("43a59799-0ae3-4156-9cfd-12b221d8394f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("448eb892-4cfd-4126-a864-9ee15ed254e8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("449db04d-d4cc-4518-844f-62cc033e57c1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("44c89867-fa16-4523-804b-e6494338c7b4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("452678ee-223b-4107-9fd3-61df101eebe0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4547de9e-ab16-4af1-a5cd-3e9cff727764"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4594f519-626e-40ae-93fb-e14c553d012a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("459ab226-d909-4608-866d-df65afa94b91"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("45bd86f9-ae34-4f69-a0ba-aab15050026c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("45cccb6e-d880-4b93-bab6-f5c8412f0540"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("46fdb78a-7f9a-4d72-9ebf-7c0f405bc9f3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("470e0ada-dc8a-400e-ab8d-1638082ae9c6"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("478b09fe-1bdb-49e7-877b-a01ea61cf31f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("47bd6f4b-38c4-47f5-afbf-62f2d8c54252"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("47e340e2-e38d-42d3-a83c-8f9a2f77f00c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("47f504ca-ac83-4e30-910b-034063bbb538"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("480f15cb-8c04-4911-8ae9-9bd34fae9264"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4858f252-d482-4de2-b625-d7884eb08b79"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("48eadf0d-0a3b-4f7a-aff6-2463c9a8bec9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("49307110-78ea-4699-88eb-b72d90c01279"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("497abc52-4f5e-4394-9ea0-d8414400f6a9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("49b3c074-9c4e-420c-906f-a8ec921727a5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("49eea6cf-b2f5-4c57-a64b-60ad74d93d8c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4a0fbd13-7a2c-40c2-875f-a4c0d5beb3a3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4a62aef5-73b9-42c4-ac8e-da71191067b6"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4a64be49-42ae-4873-b23b-631ce28f47a8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4a880ab5-deea-41a2-9d0f-0a007c6ec2c0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4ab9900b-3e85-415c-a107-af8dffbbacd4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4acf6b1a-8fbe-4c85-b79b-309b3dbcb505"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4bd84d79-4238-41df-9ffc-b5c7e7f6bbdd"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4bdbc239-778a-4c9d-98f4-a2afc552099e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4bf3a43f-ad86-4324-bc1b-423b5dcf80ef"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4c0659ab-daaf-4bf5-8d72-0a3114eeca0a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4cb6dc2f-dbbe-47c7-a2eb-0bd22674b602"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4cdc42dd-fca7-40e3-83c9-91a481eb4e9a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4cf9d71c-8158-4790-a928-20d8608298d6"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4d519505-dc57-451c-9670-d86d0c095309"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4df7423e-d860-4233-b218-377051ec161d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4e0bec33-9649-4295-bd19-948688b386d4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4e2ef34f-94c0-4df6-b759-96a3d1f09654"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4ed1801f-4b92-44fb-97e7-1c3a8caf6ffc"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4ed50f7d-2700-4e18-990a-e2a2849994c8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4ed8c64e-79a3-4654-af6c-825fa6e38990"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4ef075e8-6301-4fe9-9c78-3b39d1ad86c7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("4fb65bae-2afc-4293-9ad2-f81f6c31781c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5012969e-c0b3-49c6-81b4-db176b2c8e06"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("504d8b20-7539-4d0f-99c3-a2b79c6d24bc"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("505fc3fe-1fd7-4a10-9128-f1e94678f807"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("507a0bc3-66c3-4b12-96cb-5bed4c38c2ab"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("50bbfd7a-bd04-409e-83ca-3df6f4975a11"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("50fec606-7cf2-4b25-a651-d89836c445b4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("516b6b22-98f4-448f-ae5d-27934626c19f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("51bcb14c-bef8-4a4a-86e7-b0e6822b70c2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("51d1d61c-c569-4924-bade-e624c32041bb"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("523fdc26-3760-466b-9243-629d7d151654"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5293572a-6083-4740-86a8-4f641dae7cba"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("529b7c94-c474-4929-92e4-652df8689155"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("52a62f01-2473-4b70-8546-98ca57ddd750"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("536a91d6-780d-4ad4-a9dc-d3952656edcf"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("53fce6ec-616c-459e-b27d-67a5e9f2b46e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("54241230-6683-4933-8038-19bbabb7f134"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("54386d1a-20c2-4d65-a1c5-b64f5dd065a7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("547c6369-1c8f-4095-be8d-5e18df45ffb8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("548a34f0-25da-4122-9a31-57a4d0aabb17"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("54e4f3d0-490a-4441-8582-112edc1ad996"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("55214555-dac9-4a22-b91e-98e8a258b0ea"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5532155b-2e65-43af-97d3-1df9fd80c1c3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("55ade919-83bf-4c51-be60-fbb8c053a8d9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("55e421ff-6a4b-4d71-a01a-386143ee1cd1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("55ec6dc3-2da9-4938-a4ee-adb61813098e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5683c16a-3497-4fd6-bd75-2ee07880e565"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("56959b4e-6925-49b0-8b46-6e9cfb72b55c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("56a2ab71-7c5f-4085-9a43-58dbabc4576e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("56c0db86-f371-4c62-9b19-88c1b1c62b5b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("571a7e53-aa68-4302-b29b-3c4c20b31139"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("57266ddf-15ca-4f31-8fdd-e91b234db52e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("574ca7e5-5902-4b6b-9243-c54088f5159d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("578cd703-152f-4d61-ba53-74ff41e0cd8d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("578e8f6d-5158-4f20-bde3-6a5ed59e4ade"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("57d3da8c-cd48-4113-bfc4-d9bfedac6d21"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("57e2967d-3674-4951-a185-d68d31a9111e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("580e10b2-3eab-4903-ae55-3db069e371c7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5814b90a-3010-4d9d-88f9-3c2409999a1a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5826f89a-3daf-4801-bc86-b680a8822bd7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("585c1ca9-ad25-46dc-acb4-4bff1f5aef96"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("58ca3d78-cd26-4147-9976-b5b50a0ea642"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("58d0b87b-d35a-4696-98db-bbf0b827f2ee"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("599a7e80-d79e-4102-945c-fe8337b4a5b9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("59ba8c13-b24e-436e-a303-fe019b94e77f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5a10fec6-799e-42ca-b0a7-dce601edb047"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5a12a76b-276a-4721-94d9-4dc539ca4136"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5a386621-e529-43c5-99d5-7ed04d336caf"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5a607d25-a495-4634-88eb-bf78ebd91ed0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5aa92741-25a8-4047-8326-734f767549bc"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5ac36b59-60fb-450f-8636-4aa673c56916"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5ad66894-7416-48ae-87da-34bc00d0318a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5b09a7d3-908d-4699-b6e9-021ccce633c7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5b10fdbb-3d27-41f7-924d-6ddd29f66ab0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5b25099d-780a-4aa3-ab55-139b4acb0ca1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5bc7a7d3-8fa4-4c2d-a573-73de583d0e9c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5bc91c56-f9cf-4d61-9a03-d9483d57e8f1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5bd11b2e-0da1-4c76-b8d6-c76032d63aaa"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5bd1da73-ba58-4f8e-846e-7ae2a31e6ed2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5c60215b-f915-4f42-b666-c3d8ee4e3de4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5d0a74a4-6f61-43de-b26c-3f70e17bd5ac"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5dadc468-d5b4-4673-b672-7c430ea2ebfa"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5dd8f28a-9cee-403b-9804-1763af365120"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5e7d0663-8d5e-4912-89ea-7099f2a1ba7a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5e85c263-026b-4e51-ba97-be24b5f1a29b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5ea4ca8c-6c6b-44af-a8c2-a8b3ddfe7788"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5f0b0731-4d53-4641-867d-19540fb25477"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5f18a0b8-97b7-45c4-a3fa-b380b9f18ada"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5f39d068-e907-444b-87c7-0e632aeca945"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5f784635-24e5-4015-8fc0-e23289009424"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("5f81810f-5e14-41e9-bd15-1ff179d7a0b2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("602dbcba-e91b-4aa1-841e-baceba038bd1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("60910961-8bd7-403f-816f-6947cca086ef"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("609be913-4f62-465e-869d-e3e38ea1a32b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("60b3e466-13d0-487f-b2c9-23edd065b7b1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("61400081-9b34-4ab9-98c7-cc8e74fc79eb"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("615300e9-379b-46b9-8a38-9aed5d462908"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("61682461-0528-40d4-aac8-76acd258df3b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("622735b1-c1e4-4d08-9e45-2f977aee4e22"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("623f9551-1ebf-4b6a-b9d7-669d61a46b00"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("62642919-5801-4b88-b0c4-f67e14295826"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("62e36d07-142d-4e03-b5e3-06f242c6dfcc"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("63282afb-3f2a-4201-9633-261b96350836"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6336f4b4-1529-4cd1-b2b1-6c6cadd5ed85"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("634bdacb-08e0-4dd0-9faf-2826bc809aad"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("643bbea3-4bfc-4ad3-8d7e-efff75446b3d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6442ccee-5f5f-4f27-a96d-9dc46ffd0098"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("64ebdcac-6477-4f0d-bf91-f71ae292bb12"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6501eac8-5863-4102-9b03-46a78e03ae0f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6528b73d-fd9c-4411-bb63-ab5d112f6c32"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("65307cdd-8f30-43f9-a1e1-40eb8d0b86cf"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("65560abe-8c99-43a0-aa64-09c7ae5c7b65"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("65661b98-cc0b-46be-a6bc-a0b16faa1fa3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6567261b-a194-46e4-8ab5-40efdb1f67f8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("65861343-1629-492e-8b25-20c0ca3cfd42"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("65a23e50-75ce-4d1b-b458-1c43e2720cac"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("660ec3fc-fadc-479f-a48f-8d754a1b7ebe"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6670c187-dd23-4f5e-93a1-c952a3f6abb3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("668a0eaf-60a4-4159-92d8-fbf389058a5e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("66f37b83-9d9f-4ec4-9de4-67d517483d66"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("670d8dc6-85ee-4007-81c9-99b7c6140781"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("670fe4eb-a32a-460d-968b-c201bf659914"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("67268797-090e-4603-9b29-df5f8eb06189"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6748e716-46a1-4a9b-84b5-e67d641d7358"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("674c0a35-aaa5-4eb7-be1d-5fcf77e1e993"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("67849705-72bb-4c1a-8b68-d7bd2db08df2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("67c21486-9c70-445e-ae9a-29f28d74d079"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("67c222c3-c3b7-44fa-a636-72de3552981c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("67e075e1-987d-4a22-b88a-f8a4b5580023"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("684cc441-4a8a-474a-8460-28ba2b3b1da1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("688a3f51-4caa-4302-b3b3-8e26cfe5827c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("68909a19-0a0a-4c41-8472-5a29f9e60829"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("68aea7a0-c2a9-4d1b-9a52-50ba796cdcc9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6940a241-22f2-40e3-9606-8e3b1879df2d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6943193e-f353-48f2-ae2e-9659b05c4bcb"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("69962a2b-3106-469b-a01b-f10665ca5cce"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("69e4f17f-01df-4030-8f49-a287ba47899a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6a10aa45-9eda-47cb-a52d-0354b016a069"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6a6b8888-26cd-4e16-b1be-af55b9ab3419"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6a764cb3-8267-4cef-bbf7-ae586598d87b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6a999f16-b500-4cc2-8e3b-563ec61a81ce"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6ae087f2-b5d7-4889-90be-a1fa4ca4b42f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6c3ccdea-71f9-4448-8392-de1cfe6e0554"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6c73a264-d64d-4bdd-be94-13a1ce6184f5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6c8714ef-ab72-4178-b6ef-d9ab745cff60"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6c99044c-5d97-4f9a-a11d-cfef90f47b44"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6cb35b78-8265-42a1-a445-d4ea7bbde15e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6cff53ef-14a1-4244-b24e-36bc5ba332fa"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6d152a05-0784-4d6b-a794-d8c75d6e09ce"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6d4e1d97-5234-4e5e-ab56-28238cf4f4d2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6d59469c-2bcb-47ca-8dc0-65bd5aed6f56"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6d7e861a-c37e-4a05-a008-36854e2788c5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6da78201-fde1-4770-b9e4-ae92c5896030"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6ded0654-96f4-496e-8d60-18ab5d299c37"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6ec6614f-4b26-4819-aef7-ea541b9c621c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6ed13a6e-1df0-432b-a69f-92297f75bf5f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6f1cd581-e551-40b0-9688-2d2de1a807a3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6f580c0c-3c2c-4365-9ba4-fb34953076c2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6f618440-d998-4c0f-9c1c-e5b49ac8cf8a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("6fc9a230-9194-41bd-b9f1-5f53ca02f167"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("700395e8-068b-4308-af93-8a973ff6fec1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7021f1e2-a249-4c66-8725-372d880f3cfd"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7053afae-876d-4040-b324-4f25b28a2ba4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("70a96c6a-3fe9-4646-9411-14c5458f31ce"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("70afe5b2-b744-4225-8612-1867fbd720b1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("70d5ae0f-0807-4a3a-a04e-ee66843bf7b5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("713f2bb5-5900-4948-9bbc-e12d449b308e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7155217f-478e-4642-b0c2-ca2059e3e6f9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("720a124c-c53d-49ad-8f04-f50feaddcfa5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("728f7eae-9948-4b08-b29a-011702e07154"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("72d38d1b-17d5-488a-b5ff-a6700f794dec"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("72e56c5b-2d56-4e49-8965-6148cffcf993"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7327a253-4a08-49dd-a404-6069342658fd"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("735c36ef-fddb-4c2e-bf5b-a1bab2f345f5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("73c164df-46d6-48a4-9898-9e444bacb79b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("74d9361d-187f-4a37-aeb0-9ae0c0652565"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("74ef8fb1-6367-4ff9-87a6-cd5d30f3a627"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7579e9cb-ed6f-4e09-901b-1895d88ad4a0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7581f4a5-927e-4545-b9ca-e4aa1a5f9b56"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("762ec4bc-19bb-4157-973d-7cc66e91b676"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("76748e07-d028-4ac7-8739-bd897b548bf2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("76994def-10dc-4aef-a4ae-84de82fcd380"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("775879de-1a4c-4b36-85fe-e4aac0daa445"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("77a2875c-95e1-4fa8-9f75-646ef84c165b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("77b83d91-e700-4ce1-8e05-a1d81f471ee2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("77ede8f2-757a-4081-a0c6-297d22c6cad4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("783e77e5-b375-426a-b833-4719e1b11d1a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7867834c-4c1a-4f97-9914-4b1b38374e5a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("78fb1b02-8725-491f-a978-02380a5a19a5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("79bdda7b-0e57-4c29-a079-46bea32d5dbf"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("79c93d66-6edd-4f24-9400-1a6eae113a4a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7a1dcb1c-284b-4a95-8158-80a972f77a46"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7a752a59-039e-46d5-8212-75fba6f193e9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7ae92214-f663-482e-a481-092fb04baf19"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7ba0415b-2f43-4972-93a0-6f21e8eb994a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7babae19-4fb7-4526-9248-e990eb0f865b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7bcb5c4d-ec82-43d5-996e-b195f444e452"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7c25f404-cfaf-4b01-8445-9a32fe8a2878"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7c58de37-da95-4423-80e0-ae5126f47310"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7c73dc47-95da-4ca8-a451-882394113415"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7ccd53bb-1864-4ad1-bac1-79b72c939766"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7d532d5c-d6d9-4844-84de-a7de2165a7c0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7d600f96-5476-4c38-8bf8-deca5337c1c5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7dc6de55-e41f-4a7e-a121-1d8bff5d6a63"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7ddd3ced-7340-4de9-85de-ec2afbef4ed0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7e09a759-525c-4d92-8ce9-18682a19544c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7e46ebff-608d-487e-b3f2-86848ee2b1c2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7ea55995-a552-44ff-b5a4-a165ba52b543"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7f09ab2e-effd-4041-9818-3dc39bdf661f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7f0af77b-a8c9-47e7-b7f3-584381fa86c9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7f3a7446-1952-49a6-b402-579f40d2aff2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7f575eab-64f6-4cbb-aa44-1c3b3041e8f3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("7fbf5455-c1f0-4523-8a20-3e03a3fd3706"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("80196908-5b4c-4609-b6b7-5258b448e98d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("801f28ce-b53f-4b75-aea4-345d26df7a75"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8025e978-fb22-46ac-ac1c-5db8803bee40"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("80362368-f76c-47e0-9a10-0a1d8fa409a5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("80a31d44-e9eb-474f-939b-626fba571ff9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("80fbd989-acf1-408f-8a09-100808a14c3b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("811d33b3-3788-4499-bb8c-a09c53c57346"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("81966dee-55f4-4c59-886a-6eed126f74b9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("81a4a2dc-506e-4f4f-8b67-8b0172c5c68d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("81dd7a55-d8e5-4975-8e2a-382b0faf747d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("81ec9e85-cbf3-4fae-899f-5a3145b2a43d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8248d2c1-4bcb-4fda-b0d6-97d826daf781"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("82542cce-6a54-4777-95a9-acf467d134f2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("825dbeaa-c054-4d25-aedc-caf6f328e107"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8281c4b4-4f9b-4337-b4b3-cb51d2b68e94"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("829dafbb-dc23-4361-a035-beaaf9bd8967"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("82c5bc7e-0da7-4d9d-bb11-545d4c7d059b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("82cf3e3e-ccb4-4985-93a2-8194552605a5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("83176169-0a8f-4161-a54e-440341ca1e61"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("83523c1b-5bab-4918-b095-553cb1f3fa4b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("835794c0-9106-48f4-bfac-4bd7e7750443"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("83a3017f-154f-4c21-85f8-f3730f187b64"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("83e540d4-00c8-468c-9837-73a7a5826bd1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("84043c30-f287-44d4-a80c-20a5f7a48f5e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8436bac1-ab15-4dbe-b9fe-619f9c75b5e3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8438dd2d-e02d-4a2f-bc33-6b2587db0469"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("851aa601-e4f3-4b4a-a13c-a68abe789a8a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8612f46f-5cf0-4cd2-a14b-d0af06143ff1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("863a6f3c-f932-4fb4-ae20-128cc2271f21"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("864dcd85-f70f-4557-9657-1b72c1fa6d2f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("869e5df4-3952-4c45-bf13-2df37ce5700a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("86b714bc-8c05-41bf-901d-7119989c0926"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("872558b0-c551-47c5-955b-59c7ee9faf00"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("87d65991-8b2a-48f5-b5a3-38c37d474381"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8807b842-8108-4058-9f73-65bb072ffd43"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8860bf3e-33c0-4cf6-a25f-4b14f4e35414"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("887060c4-3278-4910-bf18-75205b624c35"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("88744990-0f9f-4232-b329-b22d9d4d5da0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("889161ce-94e4-40e1-844c-ba1a1dde271b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("893ea3a0-7ce3-44ed-9f40-b29924b34be3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8a5c8f14-9a9b-42bd-9862-154f3841b750"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8a6f2f37-a989-4711-ad09-e5a93a14d7e3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8a9ea7b0-3dd0-4655-afc8-c250ba99e49a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8abfd299-d43d-422e-a2c6-dff90e4a51f4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8b0665f2-606d-459d-b0e8-c6395d4e97b5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8b0bea1b-0603-4d99-b631-2e4e69aa37af"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8b8f5653-aa47-4a52-9a30-c39a94f2f4ca"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8b9660df-4017-433c-b3e1-f02609ed0834"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8be2a98c-54df-4705-a943-f500d5e227ac"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8be9384c-c40f-4fad-9485-b3e767f8ec26"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8c0210d0-267a-49bb-828a-61ba1250a90c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8c052f65-ae1b-4f6d-b2f2-34464cc2d81f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8c5749f4-dfa7-48a0-858b-2062903123c3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8c63f3d7-7060-4ba5-b80c-943d703ea938"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8d1b308e-afbb-4008-86a0-246c2c67b057"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8d7b7789-7279-4cb4-aaf0-0b50a65cad70"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8d9eb651-6404-42c3-a362-12726dec7dce"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8e3384bf-f715-45b7-b9e5-08f49cb222c6"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8e7da633-d866-4c96-99bf-fdc177f069ab"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8edb69bc-dd2f-4eb4-8ca4-0e30fef84e48"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8ee5f7f4-ac6a-4b68-8999-566ecf860a33"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8f0057fa-9937-4fc8-acfb-6a83de85750d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8f75ea44-31e5-41b6-972a-ee9fa16d70f3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("8ff95d98-5740-4101-bfd3-42d522aab05d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9004ec25-4e55-42c7-b5f7-f7aa41b49de8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("90de592d-460d-4cdf-8795-7e51acf5e049"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("90ff7809-7931-4abf-8a34-a0f4681de7ac"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("91085c1e-49dd-46fb-8a18-e0b514df94fb"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9177f604-4384-4c44-a8a5-8bc815852254"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("92152849-40ea-4f19-9603-103447347609"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("92c5df69-c061-40aa-a84b-5f670ea5221d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("92f41f5f-ba69-4aa2-9081-770d02572301"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("932d8df0-88e0-4b0f-b410-bc417cb706b8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("934763eb-3d99-4146-b222-8e0464ecde91"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("93e4b30b-9bc1-42c0-925c-7e6e2ae48a49"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("93eec002-3b95-4e3b-a80a-72ed4529833c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("940264ea-f4c4-4361-81df-bde2189f3d7b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("94291667-38a8-4942-b032-a1e8ccf95ddf"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("944de46c-d667-46b9-8cf8-5c7cbaa0ca0e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9478594d-aa94-42b5-ab3e-fa946eed7815"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9495c22e-beb6-413a-86b5-8d3b5392480e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("952f1c2a-d312-4fac-816f-bf3f02df0580"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("95424d1f-b2a9-49df-9af6-a6cc0d52407d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("95521913-7ca1-4d3f-8906-0094bd92ea1d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("95dcfd5c-9147-4eba-85d3-f90cba12591f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("96a32799-78ae-4254-8c26-c04eb6944a57"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("96a7c1fd-f05f-48be-bc3a-592f89a546bd"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("970dd0bb-3e7e-40fa-9549-606347249f86"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("976a7c5f-126b-41b1-8f55-07ed36d55d66"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("97b1cf47-1008-4f57-96a4-cc507036d503"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("97e74d7a-9f86-480c-a547-b28ee99b22c5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("97f02bde-623f-4bd9-824c-18b115454a6f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("986ec287-9c4a-4546-898c-8a3a6b2d5187"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("99396455-ccfd-41c3-b095-f92137ee0ea7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("993c5dce-9f4c-4dce-9499-b33836699e69"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9959cb32-d33f-425b-8018-2d2c5f977a65"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("996657ca-5c02-4a4a-b3f2-0ab8bb206278"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9980ef38-41be-4c6f-98ed-b68832a7013d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("99de68ab-2838-4a35-b211-15b44aceb898"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("99fa3273-efa5-48f9-a2ab-ce7a883bb58a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9a4fb107-2386-469b-aefb-610793384dc9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9aa3ae20-4500-4612-b103-5e887e385c6b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9b23dcf9-a6c4-497f-a07b-96444b75a99c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9b54222b-54d9-44a8-90aa-df5b3c958a1b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9c7ea572-a9ba-4dcb-adf5-3043f7673a36"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9cc14f57-ab26-42ec-9431-6ef524bd6c93"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9cf42d5f-f6c9-41ee-86f4-b843cc853219"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9df1012b-92ac-4964-b31b-fec09af02d7a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9e2e5344-b58e-4719-b7aa-9385156154f7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9e5b9824-2471-4da1-be8e-52accf78d559"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9e5e40f3-2872-4a87-8edb-3bbaafc67069"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9ef612c5-ca1b-4b7b-a7e7-fd79ecc36752"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9f849376-746b-410e-a500-383c91740d0e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9f87f006-c6d8-4f17-8de7-61176ad109c9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9f9b1b78-5118-4928-8daf-ceb68faeb683"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("9ffa1711-e266-4269-8fe1-31b640ac5e64"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a06270c9-72e2-41ea-90e6-34e0151b3a1f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a093885d-3077-4a4c-8256-54f56d797cbb"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a0a5c66f-3014-4f81-bb42-c0a3a15dfe70"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a0e15b86-ba9b-40fc-ba7c-69f80cc5c7db"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a197553a-ade2-4059-9919-835336ccd415"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a1b99539-1c43-4071-8cf6-c5f5be9d3363"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a1cc18ec-970c-4eea-86b8-226dfc20473b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a2297582-75c8-455e-a977-623c03c2d8bf"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a2593ab4-76e9-443b-b39c-31b45cdd7bf1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a2596c8c-a362-4bb6-828b-2b451a71fc10"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a274ab29-e65e-4f49-ae7f-9c18303dc83d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a2817cfb-56ba-498b-83e5-f1985070f0d0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a28b1687-4f3a-4f52-9aec-8ff3cbe09af0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a2e44273-7651-4c11-962a-34e73ecbbd57"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a321e03f-ec7e-4649-b6d0-0d9e2e50b19a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a325e876-7149-4254-958b-37cd4f658dc9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a37fcfa6-bb62-4f6d-afbd-77d500c8d1cf"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a38bb9f1-ec8f-4a64-82f2-41bd115fa0ce"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a396a946-cd1e-4b8b-8426-82f0bd28dea8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a3b5e1c7-a2a0-4a80-afc1-751a36e78934"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a3bffbef-f3cd-4295-ab81-17bd382670e8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a3e3efc0-03f7-4f47-b64f-8ce09d77cea3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a3f9feaf-b8ad-44ab-823e-c6e2f456d2c3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a3ff53f9-7fe1-4c6f-9c2f-3c8b13db1ae4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a48bc3d5-9888-4c8e-b55d-3725e48b43c3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a49a2881-45e9-4bcf-8c44-9cacd7306994"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a4d86f10-4e02-41a7-b205-01d116b84083"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a5b7eee5-ec1e-4497-9b13-45bb2ea03215"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a5ea361d-6745-49e0-ac09-d2a8f968b4dd"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a67a5379-8baa-459a-8e77-ae69193d32f7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a759fe97-819a-4aee-a353-d0d504f9b09a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a7e8d6ca-9712-4f80-99b0-7a51a66c1c3d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a81d4289-4a89-4515-8205-e6261209d806"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a8475b1d-4800-4c46-af02-c26016c988a0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a9188bac-5fb1-4409-a689-a1dec8360fa1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a9ddc003-5406-4f8b-97e6-248cd8366be0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("a9f13ccd-425b-4936-a50e-5e1ce818f8a5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("aa29fdfa-7270-42fd-ae13-8afeae1ba8de"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("aa5e55a0-fcc8-4727-a480-0dfd8d3f4dc7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("aaaab57a-1efa-4834-bc17-258e06ec107f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("aabb48b5-5487-43fc-a34e-c0c561bd20de"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ab233b5d-0175-4f78-81d8-16c8ef8e839f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ab4c2611-d226-4a0b-84af-bdf0cbe11518"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ab8c5d00-264b-4834-9088-ba7f4d6d3719"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("abb0dc63-62b8-4099-93c2-5e11e0cbb08c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("abb172c9-2a20-44e9-af63-bc1099e22411"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ac3d2047-1aa8-4e4b-9694-64ed6392a5d0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ac40f778-6430-4311-af88-459fa29ab9cf"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ac6f2a64-a4c8-4687-a321-877a35f4ff96"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ad0307d2-3d32-43ac-9107-d3c67ece955f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ad769f3b-c021-4c80-862b-8eb22d94fef4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ad7a95d0-1a68-4968-84cf-a93e833cc820"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ad9c15db-752e-4593-bfe3-9345db5e00dc"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ae3683f4-fe6d-4210-8263-7cfc945d1b3d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ae5f4885-70a3-4153-b720-3cb0ff43f719"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("aea5a7e8-7c95-4316-aff2-837c7e2e80cd"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("aec7fff1-6895-43b5-a8e0-fa7d1a99be5d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("af32b4d7-be3e-49ae-8063-47743b3cdae9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("af5a889a-eda8-498d-9405-56dc012e6b9e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("afdbcde9-62cb-4ac8-b9df-da4c18156ec2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b06f7ea9-570e-4e88-8e7b-9750b59ee742"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b08cfe17-416f-470b-9c5e-c53b0f6ff9e7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b09311e0-fc33-4f2b-bfa3-e275ccd32c2c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b0b68d7d-4e68-4099-8e67-41492f9af1e9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b0bf3d45-7abc-4959-8137-047eb7a2f95c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b21ab2f4-330d-46c5-8a40-63fcd6a1df23"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b2504ed6-f539-4398-8667-93a8b016d55b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b287fc10-d580-4a25-8f05-35126f387904"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b2db1a3b-205b-4131-b104-c8a480309944"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b3021679-61d8-4d9d-bc11-40da7003fe67"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b31a19ae-fc75-4f1a-aec8-faf793907393"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b33a130f-4888-485f-928c-1ad21ed4b9a5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b3ed070c-120e-497a-8f77-7654e77b5d43"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b47cef97-2677-4a05-bdad-6ff8fe5430dd"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b4e8c270-d1cc-4a38-a136-51103046358c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b4f379a6-01e1-49aa-bf0c-a8a242df8c9b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b5026fac-2734-4356-a332-78d95a7933f4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b5636d60-cd75-429f-b877-e707472809eb"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b5aa5ccd-f1a9-48c2-a90f-55f91ade1db9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b5fbfb3e-aabe-4ede-8f23-6e37065744a8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b63de41f-8123-418d-b8f8-05748834c91d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b77530b0-0b18-41b6-98c2-d9d851e8a26c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b7bf7c43-7494-4161-9b99-6c51f0d44387"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b7f36886-3c1c-4f8a-9d73-88c0a0c8166a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b7fe7a60-050f-465f-b823-84d4f6ab42f4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b88078c1-f54f-4dfb-969d-f8459c8f8928"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b888ca58-99c8-4f24-851f-f69c8fe8eb88"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b91a7dd5-5959-464e-bece-c9f37077d854"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b9c22c03-9207-44ff-a168-4f62531da9f1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b9e7f3aa-b48a-45af-a669-68650a51aeba"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("b9ea7ba2-0193-4907-9762-648722b61e09"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ba3ac14a-3b10-4846-b011-de814a62c27e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ba5a487b-94d9-46fa-8ab1-3a1ec7081346"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ba609a0b-7607-4333-858c-03b5df18acd9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ba7ec3ab-4550-4d73-a702-a874ef0a9b6c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("bac0eaab-1424-437a-95e9-bc2ba068794f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("bb30ad0e-8cf3-4fd8-a478-1a1a75fa53ce"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("bb33a927-ea54-4b27-a055-60800eb25afc"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("bba1a2cf-3810-4da8-880d-7e95a942032b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("bba1b5b7-d07a-4957-bb8e-6b771578d2b4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("bbcd624a-a2d1-4e22-9df8-d0c77a23210d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("bc71d4db-1ba2-4d34-a398-8baaafcf0562"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("bcb5e5d0-2742-40f5-b7b5-256b8c9b1dbb"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("bd497ffb-5ea4-402c-a21d-d6a6a230400a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("bd69d787-eba9-4ea6-8eaf-5f7093e12b15"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("bd6e6f83-eb7a-46ea-9509-8d8ac02ba8bd"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("bdaa20fe-5cd1-4009-b326-35c2de0dfca6"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("bde3d8e0-5082-48bb-8cfd-523c14a81343"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("be7ef05e-81a7-4fb6-9450-741eba4593ed"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("bef61647-7ce3-45fa-8509-0498ed59a707"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("bf40411e-0219-4342-b226-2c566a260e98"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("bf86cf9f-38f8-4166-bc27-e8221b9b831f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("bfdc6fbb-bb4b-4d69-bd46-3532ecee562b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c01bd620-5ae4-4c67-b06b-25b480060674"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c045c930-d09d-45df-a246-c18c53afa1a6"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c09a34c5-733b-457c-9b76-55f4d8dea106"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c1587bed-948b-46da-bbaf-f3b3fe9ece7e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c1934897-800b-4e42-aa37-5e5a6020697d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c1a9d3d0-a3a8-42f8-ba0a-b25d37106ea0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c1b14508-5570-4885-919d-2a9bbfec2471"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c2e993db-4443-4be6-ba23-9b70b6489b0d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c2ee05df-9bf6-4ea6-920a-5f5302cbaa46"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c31f3534-69e0-4991-8c09-4585a4515ae2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c3467551-c528-45a7-a9fe-26477929049a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c3471bc1-2566-4f87-8d3a-84d9b142ddfb"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c3e33415-8fe9-4361-9b58-41c61147f5b5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c466a5b0-2244-4ccb-ac17-453bb383cd1c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c46a059b-0b7b-4e46-b0fd-5f2b036c66df"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c46b7626-6d39-419f-ae42-6644fb1aee22"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c4b95ddb-da80-459b-88c4-0fdfaad8e1bd"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c4e233b6-ff74-4b31-8df5-cc00dd674069"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c51b83e0-1427-4532-a781-56fa2465b95b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c52e7342-1251-447f-9cd6-139cc4e5acb6"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c53d8980-627e-4463-9c4d-84af2efed57d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c5483c9d-e3b6-491b-85ac-76be26339999"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c60b0f80-268a-4dc8-96b6-7409c8741066"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c627d154-31de-4da3-9a00-737e1837ed06"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c65d4c81-ef7e-4130-b4ba-de0ae1753afb"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c6c8d7df-7573-43d7-9698-1df9de462526"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c712ceea-cf2b-40be-b8df-be6dfd9c4749"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c72223ee-decc-4424-93c2-0de4b582c9c7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c73726f3-426d-425c-abcd-8f4dd826f961"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c73b932f-af8c-4df7-8c6f-a869905e201a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c7ad195b-3275-4a19-ab72-0a8d8f424bd4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c7c20b5f-6b1d-4994-8b92-69afc21f52e1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c810dbfc-93e9-4fac-a7bd-fa644a2d4101"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c8180650-7496-467e-b781-7df0d050df0a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c865b959-4b12-42c5-b83a-9775aa621094"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c929268c-b65b-4962-9bab-5340cd550786"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c9491e71-853d-46d4-aeb8-107357faefc5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c962eb5f-6649-497e-a4d9-b0c05249f41f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c9c783f2-d838-4889-9db8-668d62ba80c7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ca298d6b-a94a-4307-89a0-ef7a7bebf952"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ca2f5197-53d6-41a3-82cd-b58a043dbf6d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ca496890-ce1a-4222-a2aa-cc82472d8f19"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ca6cbd66-d6a8-4813-9d17-af5fc116067a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("cb286981-557c-49b4-8535-9fed11b3c394"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("cb37845a-ff40-4380-b740-0ddc4141e504"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("cb7b16bd-fead-4c14-aa41-b91c19ac8819"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("cbca0cd0-9a68-4526-8dca-2bf6ae98141c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("cbee05d9-953b-4434-a5be-6d14694e6e8a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("cc309355-2aff-48f4-9059-eb30cb5b7576"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("cc3b489f-2c47-49da-b211-231c9c877cdf"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("cc4d7065-9a7b-4adf-9414-ae814d2da971"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("cc8f4e0b-6026-4748-ba2e-239afe4bf6db"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("cd07676d-8de3-45db-9cfc-2eb6d7a5b70e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("cdb19e5f-aebe-43da-b4de-8cf1bb3f34ed"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("cee61b6e-227b-4746-8d88-36cbb7177126"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("cf000c20-5408-4fb1-8a4a-673014b692f1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("cf58a105-4118-4d97-b66a-22ea8ad2eec4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("cf93d91f-d4cc-4120-b32f-4880dfbe322d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("cfb5412e-53ac-4b54-9b81-8d92f81ea1cf"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("cfb8ce09-d02b-48cf-974d-f99fa9822019"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d032484b-04d1-4a51-8883-0cb5524713bb"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d038fa5a-16e6-4d48-9a89-2d0d5a30873a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d04aa9db-044d-4f16-bfcf-3a1189c6704a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d0901372-1004-4d75-aba4-8ecfff1b52c2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d0c9acd0-4730-45df-988f-20960af4009b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d10ef606-8766-4131-9036-31e4a5e03cd3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d111fbbb-ca43-49b6-a49b-0284e4b046a9"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d11c812a-e957-4efc-bb28-c0a315cb9692"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d1311c7e-86b3-4951-867d-0480668886e4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d1597205-d237-4447-ae61-c4581cba3f93"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d19ff9d8-e3af-4e3a-b697-8c265f809957"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d2195b10-7a7a-4ef9-8840-a88247378c22"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d2205306-b823-490d-b672-46c2ac9f2564"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d2b187a3-aa98-4488-8a97-ceb9d0d920c0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d2ee8486-6b1b-46e0-b542-790d91850a3a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d390716f-94f1-4da1-b34e-6eb6f55f7d25"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d3ea9384-7202-493a-9110-47c2e24f1f58"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d408c857-8ea9-4407-a55a-35783c29d25e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d41ad3e4-438a-4806-a675-e69818470b43"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d4eff746-acf5-4f38-8f39-c1d162722bba"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d4f292b5-7fad-4c9a-b2da-9d87c15e0665"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d5161dc6-1941-4dc0-8c6f-4a636f0cfb8c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d537b773-04af-4947-9a7c-a45ac55e187f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d5b35230-b0d4-4222-bf36-dc3f6230178d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d5d89bcb-9ce0-422b-8463-a4f47cd0e339"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d5f37cbf-314d-4e39-abef-ebd5629f9e00"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d5f9c101-6947-427d-969c-1a105395aad1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d604d0f7-4cc6-49e3-a784-cbaef88ced47"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d612676d-8a02-4c08-93bf-6ba39c2f1e1c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d6aefa3a-991c-4b36-b229-8a689197a6de"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d6cc1d0e-197f-48f9-8701-2d7cf045fe0d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d6fee9db-5ec2-4510-bcd3-490ca705ecd6"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d7236290-0cc1-4af3-8ca4-922b93318feb"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d73f6cd5-d988-4d6e-a4c7-805251eaead0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d7cabac4-bb3c-4dd5-b225-f0785ae42d24"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d83b123b-29ca-43e0-b47f-d0396d765f0b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d85c2c1b-cf48-4d9d-ad81-d916ba3cf80b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d89b9527-74cc-461c-94cd-b48cb9b3d7c1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d8c3ba62-347a-420b-bc58-ce9d7f26f451"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d91b2e67-b922-4288-b688-2418662fa18a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("d986c6d1-9123-4ed0-9fbd-1a22dac88b3d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("daab6fe3-23e5-4450-8d15-e600da283a16"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("daacfe3b-03f3-4109-a64d-2d9ac4a7d8d2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("dabcc0f4-6896-422f-8530-dbc3e463ae07"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("db13f894-45f9-4420-8775-fa300ccf10a1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("db546a00-d865-441f-b3d0-4efb67aad24a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("dbb78bfd-e216-415f-8be9-1b65e3b61abc"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("dbf9dce1-3866-4965-9eea-05bcaac669df"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("dc1a9052-171a-417c-9ddf-4157feda0e7a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("dccb6386-76a3-4cf6-8fd0-991a21288526"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("dcd61355-9468-46cb-9f23-15c87cdc6921"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("dcfaffdf-889a-4f8a-baaf-b170f1a3ba9d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("dd17d0e3-ae26-4fbc-8cbc-b26b778c1e36"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("dd272ddc-68f8-4157-99c6-fba627b9807d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("dd427a14-9729-463a-af56-9af5d7581741"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("de496f3b-a0ef-4a77-ac7d-d858926d2ca5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("de6e6044-98c5-4ffe-a9c8-8be1746f6f46"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("debb3048-2f24-483b-aee4-c5934d36dabe"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("dec0cff6-01ac-4946-ba3a-3f4b1723072a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ded1d3f9-d63d-448f-9d69-f1d37c4a6f45"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("dee80773-f1e0-4d81-b8d3-296c2368ce50"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("df8a53a4-42bb-4be2-a225-19cf33ed69c3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("dfd227d8-be31-4491-a56d-5f7c0ab2a36c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e00e5f12-ea91-4f32-ac80-b4ab80a002fe"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e0396e5a-4be2-4890-9a6e-ba0064ce60f8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e0473935-22e0-4b2b-b641-3f06d823a9f6"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e097b115-3bd4-4d91-bdc5-a89c11367c26"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e0981c0b-4e83-4137-bd7f-e8a982935d5a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e0b98489-915f-4d7e-ab71-7772529d314d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e0cb7b74-80d2-49a3-b023-1bb44ad6fbe2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e103c243-b941-49f2-994f-a2834c2f9371"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e13fffa6-922f-428b-953a-0421042cd1fb"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e1514070-912a-4e2a-a97e-8d4caa9235d4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e177c059-6a61-4461-a9cd-5e94a0e756da"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e1887111-1701-4d30-b1e3-389083e97aba"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e1fa644b-6586-45f3-a1a8-6aff1315e7a5"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e2e39336-9991-4eab-9c05-3eb821692c0b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e331dcdc-bf0d-4c32-8afc-03e67b70b1ec"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e351e1f9-82cc-4337-b0fb-468ad6239c45"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e3aef66b-afe7-47b5-9ae0-b8783acbb157"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e4be9abb-99a3-4204-9df8-2d9ec88a4252"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e4d9ef77-7735-4025-a892-57ff873a0343"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e4ee781d-281c-4916-8caa-1754c7467b24"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e4f3af96-964e-4e43-a857-af5050860dfb"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e4fadc3a-0bfb-42c7-a2f5-dec51048dd03"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e4fd81fc-35eb-4538-946e-e60a5a272a30"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e5741c6c-923d-4bc4-81b5-dd95008e2eca"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e5b47ee0-0583-46a7-9973-bee86c0080c0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e5ccbdf2-765a-4320-9bfb-6a730d8795a0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e63b6221-09a7-498f-8fb1-b7a2a9d8eb2b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e6588cb6-c3f8-4686-8b4f-2b80271cfe4f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e74c5efb-1627-4c5d-a068-209adf37f797"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e763d1f1-9f71-43da-9d34-85ddfdf2855b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e79d4884-27cf-4fa6-b26f-13b7099b3d53"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e7ec782a-e5af-41fc-b04c-08f3ef5d09ed"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e7ede293-9148-4e81-b6ad-1abf09e67626"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e7fd27aa-a084-4ece-8e0b-c0d0da4f137f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e8281648-8afc-433b-b5bb-739ae692335e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e838bced-bca0-41fa-b3a0-d25eb2d27104"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e88a9b89-af5b-40cf-9f30-4078c9dba186"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e8db05bc-f8d2-4921-a0a9-f320435a581a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("e9d04ca4-3563-41a6-99da-27c9f920598f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ea70b664-e2ab-46c2-a59f-625ba2b4d360"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("eb386ba3-e566-46e9-a7f7-293f75efb50b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ebc0368c-9e4e-432e-91a3-e8afae698bcf"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ec2b0f2f-8c05-4fc2-9dfe-a7c5fdd62668"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ec36995c-0be5-4b11-b16c-06eb401c29e3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ec88b2b7-4c2b-4839-99f7-b879240e2347"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ecb56ed4-348f-4a64-8677-9ce0218e219e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ecd7772b-f9b1-43f2-845c-29b14d1e2a42"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ed38732d-2b4e-4fcf-8995-9c47fb1623e3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ed6e0f7a-0180-4233-9ab4-64a129433462"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ed98ba0f-1629-48a9-87fc-bcb190240ecf"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ed9b77b5-ff96-426b-9c5b-f4946b44994a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("edac6f0c-c6bb-40c6-9328-5d2459206174"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("edb7ef86-0165-4d77-ae71-e606899794eb"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ee000d51-4f04-4ec0-9128-fa834bb69055"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ee3301e3-cc7f-49ed-a68d-8cd76aebf20d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ee35273c-59aa-4183-b538-cda9a2f23d46"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ee69385b-4d4f-41f7-8b19-54235db84c2b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("eeb40dfb-eb1b-438e-b553-0ea69e2fe437"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("eeb4694c-d262-4cb6-bc1c-927f8c3a14f8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("eebaf4b7-f6b8-4fe7-9970-e3b8f9318d93"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("eec4bbe5-c24a-4728-b80c-71464c532e99"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ef0a9688-7b48-4883-8cbf-22cf72da7d8b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ef32bcce-aba0-494c-ad24-144a0fd14d64"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ef71f469-44b9-4682-97bb-fbac77154469"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ef81306d-0f64-4de2-9f10-8a1e7a57681d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ef98751c-10ac-4383-8103-3de8a17e7360"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ef9b199f-2da0-459f-88a0-350a817b0ec1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f0252d85-80df-4fb4-b444-b814f12b7a34"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f06f77d4-b6b2-42c6-9ec3-6f9ee226fefd"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f070b74b-f32d-4007-b159-dabfe16989b4"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f08d1e06-a921-4ab3-aaca-aa25d4e5596b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f098436e-4ea6-4ad2-bb3b-d187e6fd6a30"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f0c9a3b2-7f47-45cf-a02a-1f2af592410b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f0c9ee4c-517d-4edb-bbbb-3d05db79db03"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f0f95f1f-55e6-4b7e-a890-ad22fc0c104d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f135b56d-9b4b-4fc5-b663-7cb0ab3e18c3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f1854144-5c70-4940-bf98-c04445090656"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f188d9f9-540a-4e2e-b3de-44185fa93e34"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f198fde3-55b2-44f5-a8d0-146ec23f23c1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f1d1936f-2dcc-46b7-bc42-6eddab198dd0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f284a60f-f48a-449f-aa49-e2fbb19bff91"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f29d918d-7f50-4625-95c2-e4982af22271"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f29f4fad-7d4b-4782-9a2c-16b299cdbb2c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f2aa5709-de2f-4668-9b37-5a4bdaeb2ca7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f2e64f72-f8cf-471c-aec9-8314c4ab138c"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f359d8cf-8a61-461a-91be-b634d7576e03"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f3f9e5d1-9a57-485d-87e8-2b3f9d6bf2f6"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f4422cea-5012-4f69-aa9f-40f5ddf5b078"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f4461a24-c4c1-4640-aa5f-74a1e8df3951"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f46a8d73-912e-4a2e-959c-0f251cf1f93f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f48478f5-4033-45e4-a5a9-6305b332133e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f4c9eac3-6b28-4b5f-817e-d4012a6adcb1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f504b783-5383-43ad-abdb-40b3690683b0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f581e85a-e28a-463d-9628-c1e84fe19695"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f5e783df-7163-48f9-8a69-7f52bc5db4e1"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f6bd426b-c6fd-478b-b28c-ae18a310e277"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f7736093-1d47-4c76-812e-60a3d878641a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f7804b19-ba2a-43c9-9fb1-65d6d61cf9e2"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f7fcdcab-015e-451e-b2ab-c49311bf71e7"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f8299e97-fd56-4d5c-851b-b848fc61ac6e"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f8570cd4-2dd8-4662-93da-f02c316507d3"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f87b51fe-4b8b-402c-ad0e-c8ba2560c889"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f88a3b24-11dd-4bad-8a34-425f7207854d"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f8b80b91-4826-4156-9c6e-982ae6cc3ed8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f8d1530f-7810-4645-b6a3-af77d01d8824"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f9b7dda3-9853-43f8-9e37-3b2fceff034f"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("f9f7a58f-0f3a-4a92-a253-9e1a85cd7648"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("fa0105d7-66f4-4670-bd58-674a65f86a60"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("fa319324-3c6d-4f3d-b9fe-41339b526b59"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("fa5a94a0-2b8d-45c0-b52c-aa1cc203cebe"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("faad3076-74d6-47da-9aea-6584c0b695c8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("fbf34c0e-10bb-4a9a-af04-0c6f543ffcba"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("fc4afaa9-5a5a-4b3d-a69e-563ac4ea6339"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("fc543eca-6061-430e-9539-86a65355cb72"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("fc642904-4b53-4d77-9827-996f17289f41"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("fcc3e180-45dd-43a2-940f-c0fa5d8bedea"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("fcfaa72d-ad24-4631-810e-28ca67460efc"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("fcfe4d8c-a8c3-44de-bcf3-1995a4835a57"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("fd14e441-9edf-4b25-bc29-03b887a4be11"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("fd1e6bf0-028d-4bae-9d82-0fbea372f0de"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("fdaeaff7-7bad-4c3a-adc5-30aeecd465a0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("fdbef7c0-2a86-46dd-855c-3a01eac85fba"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("fdfe7f62-bc4e-468c-a06b-446b71f2f76a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("fe269cbb-d7b8-4554-9eb2-1340320537c8"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("feb643da-eafa-4641-947c-f3950922c061"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("fee004f4-1379-4cb5-91a0-30fbd6dca6e0"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ff04c2e5-8003-4e60-adf3-cdf8df747937"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ff291c00-0ba2-4e63-b3d0-efc6290bfb9a"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("ff7835b5-757a-4f9b-850c-d35762951403"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("fff31393-2d97-4669-b85f-90242c109838"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("fffe955b-5f9a-4d51-9a24-a6a1ededf3d0"));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Entities",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");
        }
    }
}

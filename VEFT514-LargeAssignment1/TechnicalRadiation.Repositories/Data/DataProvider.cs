using System;
using System.Collections.Generic;
using System.Globalization;
using TechnicalRadiation.Models.Entities;

namespace TechnicalRadiation.Repositories.Data
{
    public class DataProvider
    {
        private static readonly string _adminName = "TechnicalRadiationAdmin";
        private static CultureInfo EN = new CultureInfo("en-GB");
        private static DateTime testDate = new DateTime(2008, 10, 1, 17, 4, 32);
        public static List<NewsItem> NewsItems = new List<NewsItem> {


            new NewsItem {
                Id = 1,
                Title = "Hong Kong leader Carrie Lam to withdraw extradition bill",
                ImgSource = "https://ichef.bbci.co.uk/news/624/cpsprodpb/137B5/production/_108579797_mediaitem108566452.jpg",
                ShortDescription = "Hong Kong leader Carrie Lam has said she will",
                LongDescription = "The proposal, introduced in April, would have allowed criminal suspects to be extradited to mainland China. The bill was suspended in June when Ms Lam called it dead, but she stopped short of withdrawing it.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 2,
                Title = "Why do sloths move so slowly?",
                ImgSource = "https://ichef.bbci.co.uk/news/624/cpsprodpb/137B5/production/_108579797_mediaitem108566452.jpg",
                ShortDescription = "Sloths do everything in slow motion",
                LongDescription = "Sloths, as their name betrays, have little need to rush. For the most part, they live high in the branches of the forests which stretch across Central and South America, only coming down to the ground.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 3,
                Title = "Why Polish people hate rules",
                ImgSource = "https://ichef.bbci.co.uk/wwfeatures/wm/live/624_351/images/live/p0/7l/y4/p07ly4j3.jpg",
                ShortDescription = "Warsaw has had a long and tumultuous history",
                LongDescription = "When the Nazis started closing in on my Jewish grandfather during World War Two, he made a fateful decision: he fled from Ukraine to Warsaw, where no-one knew him and it would be easier for him to disappear.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 4,
                Title = "Brexit's most important week? Five things that happened on Tuesday",
                ImgSource = "https://ichef.bbci.co.uk/news/660/cpsprodpb/100D6/production/_108605756_brexit_debate.jpg",
                ShortDescription = "Well, that was extraordinary day in Westminster",
                LongDescription = "We had to wait for the biggest moment of the day, but when it came it was certainly dramatic.To a House of Commons bursting at the seams, tellers announced that MPs desperate to prevent the UK leaving the EU",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 5,
                Title = "Mississippi wedding venue refuses interracial pair over owner's Christian faith",
                ImgSource = "https://ichef.bbci.co.uk/news/660/cpsprodpb/1031A/production/_108603366_caa252342fpture.jpg",
                ShortDescription = "A US interracial couple was turned away",
                LongDescription = "A US interracial couple was turned away by a wedding venue because the owner said their union went against her Christian beliefs, video shows.The footage was filmed at Boone's Camp Event Hall in Booneville.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 6,
                Title = "The best TV shows of 2019 so far",
                ImgSource = "https://ichef.bbci.co.uk/wwfeatures/wm/live/1280_720/images/live/p0/7m/bn/p07mbnm5.jpg",
                ShortDescription = "From Fleabag to Stranger Things and Chernobyl",
                LongDescription = "When Phoebe Waller-Bridge’s comedy-drama about a hedonistic, acerbically self-loathing thirtysomething made its debut in 2016, it was predictably lumped in with Girls as another study of millennial womanhood.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 7,
                Title = "Boris Johnson challenges Jeremy Corbyn to back October election",
                ImgSource = "https://news.files.bbci.co.uk/vj/live/idt-images/image-slider-dorianflooding/slide2_dorian_b-a_640-nc_3l61y.png",
                ShortDescription = "Boris Johnson will call for a general election",
                LongDescription = "Boris Johnson will call for a general election on 15 October if Labour and rebel Tories succeed in blocking a no-deal Brexit.He challenged Jeremy Corbyn to put his policy of 'dither and delay' over EU withdrawal",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 8,
                Title = "Hurricane Dorian: Scale of Bahamas devastation emerges",
                ImgSource = "https://news.files.bbci.co.uk/vj/live/idt-images/image-slider-dorianflooding/slide2_dorian_b-a_640-nc_3l61y.png",
                ShortDescription = "Rescuers have begun to reach areas",
                LongDescription = "Rescuers have begun to reach areas of the northern Bahamas devastated by Hurricane Dorian, with aerial images showing a trail of destruction.PM Hubert Minnis said some areas had been 'decimated' and expected the current",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 9,
                Title = "Climate change: Greenland's ice faces melting 'death sentence'",
                ImgSource = "https://ichef.bbci.co.uk/news/320/cpsprodpb/14E0E/production/_108581558_drone_976-nc.png",
                ShortDescription = "Greenland's massive ice sheet may have melted",
                LongDescription = "Essentially because its ice sheet is seven times the area of the UK and up to 2-3km thick in places. It stores so much frozen water that if the whole thing melted, it would raise sea levels worldwide by up to 7m.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 10,
                Title = "Is there a worst time of day to get sick?",
                ImgSource = "https://ichef.bbci.co.uk/wwfeatures/wm/live/624_351/images/live/p0/7m/dr/p07mdrjv.jpg",
                ShortDescription = "Our internal body clocks govern",
                LongDescription = "Take a good hard look at the skin of your forearm. Pinch it if you like. It may not look or feel any different from the way it did 12 hours ago, but if you were to cut or burn it, the skin would heal more than twice as ",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 11,
                Title = "Hurricane Dorian: US braced for 'life-threatening' storm surge",
                ImgSource = "https://ichef.bbci.co.uk/news/624/cpsprodpb/18468/production/_108623499_dorian_storm_05_09_640-nc.png",
                ShortDescription = "Hurricane Dorian is expected to bring a life-threatening",
                LongDescription = "Residents from Georgia all the way up to Virginia are warned to listen to emergency advice as the category three hurricane slowly moves north.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 12,
                Title = "Iran tanker: US offers captain millions to hand over ship",
                ImgSource = "https://ichef.bbci.co.uk/news/660/cpsprodpb/4BCA/production/_108620491_tv055916162.jpg",
                ShortDescription = "The US state department has confirmed it offered",
                LongDescription = "Brian Hook, head of the department's Iran Action Group, emailed the captain of the Adrian Darya 1 about sailing it somewhere the US could seize it.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 13,
                Title = "Neymar to Barcelona: Inside story of PSG striker's summer transfer saga",
                ImgSource = "https://ichef.bbci.co.uk/onesport/cps/800/cpsprodpb/10432/production/_108601666_neymar_getty2.jpg",
                ShortDescription = "After months of talk, bluster, posturing",
                LongDescription = "As the dust settles it is worth noting that the person least surprised by this is the PSG forward himself who, despite pushing for a move for months, feared from day one this summer that this was a deal always destined to fail.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 14,
                Title = "US Open 2019: Rafael Nadal beats Diego Schwartzman to reach semi-finals",
                ImgSource = "https://ichef.bbci.co.uk/onesport/cps/800/cpsprodpb/607E/production/_108620742_nadal_getty.jpg",
                ShortDescription = "Rafael Nadal is chasing a 19th Grand Slam title",
                LongDescription = "Rafael Nadal remains the favourite to win the US Open - and move within one of Roger Federer's tally of 20 Grand Slams - after a hard-fought quarter-final win over Diego Schwartzman.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 15,
                Title = "Ashes 2019: 'Steve Smith and the wind steal England's momentum'",
                ImgSource = "https://ichef.bbci.co.uk/onesport/cps/800/cpsprodpb/607E/production/_108620742_nadal_getty.jpg",
                ShortDescription = "There was a moment, just as tea was called",
                LongDescription = "As the rain came in sideways on thumping squalls, tearing the flapping beige covers from the frozen fingers of the ground staff, sending a steward in a clear plastic poncho staggering sideways as he tried to keep his feet ",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 16,
                Title = "Ashes 2019: Australia have nullified England momentum - Michael Vaughan",
                ImgSource = "https://ichef.bbci.co.uk/onesport/cps/800/cpsprodpb/607E/production/_108620742_nadal_getty.jpg",
                ShortDescription = "Ashes highlights: Australia's Steve Smith",
                LongDescription = "Australia have nullified England's momentum from Headingley on day one of the fourth Ashes Test at Old Trafford, says former captain Michael Vaughan.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 17,
                Title = "Real racism lies with football authorities - Vincent Kompany",
                ImgSource = "https://ichef.bbci.co.uk/onesport/cps/800/cpsprodpb/D48C/production/_108621445_komapny_lukaku_getty2.jpg",
                ShortDescription = "Kompany and Lukaku helped Belgium reach",
                LongDescription = "The lack of diversity in football organisations is part of the problem in tackling racism, says former Manchester City captain Vincent Kompany.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 18,
                Title = "Ashes 2019: Steve Smith frustrates England in Old Trafford Test",
                ImgSource = "https://ichef.bbci.co.uk/onesport/cps/800/cpsprodpb/D48C/production/_108621445_komapny_lukaku_getty2.jpg",
                ShortDescription = "Steve Smith once again had the measure of England",
                LongDescription = "Smith, who missed the third Test with concussion, notched up a record-extending eighth successive Ashes half-century to end the day 60 not out and take the tourists to 170-3.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 19,
                Title = "Joshua v Ruiz: Fighters meet in Saudi Arabia for first time on press tour",
                ImgSource = "https://ichef.bbci.co.uk/onesport/cps/800/cpsprodpb/424B/production/_108617961_ruizandjoshua.jpg",
                ShortDescription = "Andy Ruiz and Anthony Joshua will speak at three",
                LongDescription = "Andy Ruiz Jr said he wanted more than 15 minutes of fame as he faced Anthony Joshua for the first time in the run-up to their 7 December rematch.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 20,
                Title = "US Open 2019: Belinda Bencic and Bianca Andreescu progress to semi-finals",
                ImgSource = "https://ichef.bbci.co.uk/onesport/cps/800/cpsprodpb/9EDF/production/_108617604_bencic_getty2.jpg",
                ShortDescription = "Bencic will be back in the top 10 in the world",
                LongDescription = "Switzerland's Belinda Bencic will meet Canadian teenager Bianca Andreescu for a place in the US Open final after both reached their first Grand Slam semis.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 21,
                Title = "Blanca Fernández Ochoa: Spain's missing Winter Olympic medallist found dead",
                ImgSource = "https://ichef.bbci.co.uk/news/660/cpsprodpb/68C6/production/_108622862_056181095-1.jpg",
                ShortDescription = "Blanca Fernández Ochoa was well known in Spain",
                LongDescription = "The body of former Spanish alpine skier Blanca Fernández Ochoa has been found after days of searches involving hundreds of police and volunteers.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 22,
                Title = "US Open 2019: Matteo Berrettini defeats Gael Monfils to reach first Grand Slam semi-final",
                ImgSource = "https://ichef.bbci.co.uk/onesport/cps/800/cpsprodpb/13421/production/_108618887_gettyimages-1172291436.jpg",
                ShortDescription = "Berrettini becomes the second Italian man to reach",
                LongDescription = "Italian 24th seed Matteo Berrettini edged a thrilling five-set match against Gael Monfils to reach a first Grand Slam semi-final at the US Open.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 23,
                Title = "Romelu Lukaku: Monkey chants a form of 'respect' and 'not racist' say Inter Milan fans group",
                ImgSource = "https://ichef.bbci.co.uk/onesport/cps/800/cpsprodpb/FD8C/production/_108580946_gettyimages-1165535779.jpg",
                ShortDescription = "Lukaku was playing his second game for Inter Milan",
                LongDescription = "A group of Inter Milan fans claim Cagliari supporters were showing Romelu Lukaku a form of respect when they aimed monkey chants at him on Sunday.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 24,
                Title = "'I swapped Chelsea FC for the City': From goalie to Goldman Sachs",
                ImgSource = "https://ichef.bbci.co.uk/news/660/cpsprodpb/15053/production/_108099068_mediaitem108099067.jpg",
                ShortDescription = "Durack played three times for the Chelsea first team",
                LongDescription = "When Chelsea Women open their season against Tottenham Hotspur Women in front of a full Stamford Bridge this Sunday, one ex-Blues player will be watching with mixed feelings.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 25,
                Title = "US Open 2019: Serena Williams wary of 'fighter' Elina Svitolina before semi-final",
                ImgSource = "https://ichef.bbci.co.uk/onesport/cps/800/cpsprodpb/F1C3/production/_108619816_elina_svitolina.jpg",
                ShortDescription = "Elina Svitolina beat Serena Williams 6-4 6-3 in",
                LongDescription = "Serena Williams says she has to do everything well to win her US Open semi-final against Elina Svitolina and stay on course for a 24th Grand Slam.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 26,
                Title = "Tyrone Mings: It would be 'fitting to make England debut at St Mary's'",
                ImgSource = "https://ichef.bbci.co.uk/onesport/cps/800/cpsprodpb/8E1D/production/_108618363_gettyimages-1172233049.jpg",
                ShortDescription = "England manager Gareth Southgate praised Tyrone Ming",
                LongDescription = "Aston Villa defender Tyrone Mings says it would be a fitting story if he made his England debut at St Mary's after he was released by Southampton as a teenager.",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem {
                Id = 27,
                Title = "Scotland v Russia: Steve Clarke on managers, Mourinho & making amends",
                ImgSource = "https://ichef.bbci.co.uk/onesport/cps/800/cpsprodpb/94E9/production/_108612183_19233954.jpg",
                ShortDescription = "Steve Clarke will take charge of his third and fourth",
                LongDescription = "Sitting in the Hall of Fame room at the Hampden museum, Steve Clarke has a six-foot cardboard cut-out of Kenny Dalglish standing behind him and another six-foot cardboard cut-out of Alex Ferguson in front of him. ",
                PublishDate = DateTime.Parse("08/11/2018 11:17:04", new CultureInfo("en-US")),
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            }

        };

        public static List<Category> Categories = new List<Category> {
            new Category {
                Id = 1,
                Name = "World News",
                Slug = "World News",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Category {
                Id = 2,
                Name = "Sport",
                Slug = "Sport",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Category {
                Id = 3,
                Name = "Culture",
                Slug = "Culture",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Category {
                Id = 4,
                Name = "Travel",
                Slug = "Travel",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Category {
                Id = 5,
                Name = "Technology",
                Slug = "Technology",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Category {
                Id = 6,
                Name = "Politics",
                Slug = "Politics",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Category {
                Id = 7,
                Name = "Science",
                Slug = "Science",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Category {
                Id = 8,
                Name = "Society",
                Slug = "Society",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Category {
                Id = 9,
                Name = "Literature",
                Slug = "Literature",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Category {
                Id = 10,
                Name = "History",
                Slug = "History",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Category {
                Id = 11,
                Name = "Teaching and Education",
                Slug = "Teaching and Education",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Category {
                Id = 12,
                Name = "Humanities",
                Slug = "Humanities",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            }
        };

        public static List<Author> Authors = new List<Author>{
            new Author {
                Id = 1,
                Name = "Yuval Noah Harari",
                ProfileImgSource = "https://images.gr-assets.com/authors/1546235045p5/395812.jpg",
                Bio = "Professor Harari was born in Haifa, Israel, to Lebanese parents in 1976. He received his Ph.D. from the University of Oxford in 2002, and is now a lecturer at the Department of History, the Hebrew University of Jerusalem. ",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Author {
                Id = 2,
                Name = "Don Winslow",
                ProfileImgSource = "https://images.gr-assets.com/authors/1495554580p5/37795.jpg",
                Bio = "Don Winslow was born in New York City but raised in South Kingstown, Rhode Island. At various times an actor, director, movie theater manager, safari guide and private investigator, Don has done many things on his way to being a novelist.",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Author {
                Id = 3,
                Name = "Ken Follett",
                ProfileImgSource = "https://images.gr-assets.com/authors/1480592356p5/3447.jpg",
                Bio = "Don Winslow was born in New York City but raised in South Kingstown, Rhode Island. At various times an actor, director, movie theater manager, safari guide and private investigator, Don has done many things on his way to being a novelist.",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Author {
                Id = 4,
                Name = "Ernest Hemingway",
                ProfileImgSource = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/28/ErnestHemingway.jpg/330px-ErnestHemingway.jpg",
                Bio = "Ernest Miller Hemingway (July 21, 1899 – July 2, 1961) was an American journalist, novelist, short-story writer, and sportsman. His economical and understated style—which he termed the iceberg theory—had a strong influence on 20th-century fiction, while his adventurous lifestyle and his public image brought him admiration from later generations.",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Author {
                Id = 5,
                Name = "Stephen King",
                ProfileImgSource = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Stephen_King%2C_Comicon.jpg/330px-Stephen_King%2C_Comicon.jpg",
                Bio = "Stephen Edwin King (born September 21, 1947) is an American author of horror, supernatural fiction, suspense, and fantasy novels. His books have sold more than 350 million copies,[2] many of which have been adapted into feature films, miniseries, television series, and comic books.",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Author {
                Id = 6,
                Name = "Mark Twain",
                ProfileImgSource = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Twain1909.jpg/330px-Twain1909.jpg",
                Bio = "Samuel Langhorne Clemens (November 30, 1835 – April 21, 1910),[1] known by his pen name Mark Twain, was an American writer, humorist, entrepreneur, publisher, and lecturer. He was lauded as the 'greatest humorist this country has produced',[2] and William Faulkner called him 'the father of American literature'.",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Author {
                Id = 7,
                Name = "Charles Dickens",
                ProfileImgSource = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Dickens_Gurney_head.jpg/300px-Dickens_Gurney_head.jpg",
                Bio = "Charles John Huffam Dickens (/ˈdɪkɪnz/; 7 February 1812 – 9 June 1870) was an English writer and social critic. He created some of the world's best-known fictional characters and is regarded by many as the greatest novelist of the Victorian era.[1] His works enjoyed unprecedented popularity during his lifetime, and by the 20th century critics and scholars had recognised him as a literary genius. His novels and short stories are still widely read today.",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Author {
                Id = 8,
                Name = "Jane Austen",
                ProfileImgSource = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cc/CassandraAusten-JaneAusten%28c.1810%29_hires.jpg/300px-CassandraAusten-JaneAusten%28c.1810%29_hires.jpg",
                Bio = "Jane Austen (/ˈɒstɪn, ˈɔːs-/; 16 December 1775 – 18 July 1817) was an English novelist known primarily for her six major novels, which interpret, critique and comment upon the British landed gentry at the end of the 18th century. ",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Author {
                Id = 9,
                Name = "J. K. Rowling",
                ProfileImgSource = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5d/J._K._Rowling_2010.jpg/330px-J._K._Rowling_2010.jpg",
                Bio = "better known by her pen name J. K. Rowling, is a British novelist, screenwriter, producer, and philanthropist. She is best known for writing the Harry Potter fantasy series, which has won multiple awards and sold more than 500 million copies,[2][3] becoming the best-selling book series in history.",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Author {
                Id = 10,
                Name = "William Shakespeare",
                ProfileImgSource = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a2/Shakespeare.jpg/330px-Shakespeare.jpg",
                Bio = "was an English poet, playwright, and actor, widely regarded as the greatest writer in the English language and the world's greatest dramatist.",
                ModifiedBy = _adminName,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            }
        };

        public static List<NewsItemAuthors> NewsItemsAuthors = new List<NewsItemAuthors>
        {
            new NewsItemAuthors {
                AuthorId = 1,
                NewsItemId = 1
            },
            new NewsItemAuthors {
                AuthorId = 1,
                NewsItemId = 2
            },
            new NewsItemAuthors {
                AuthorId = 1,
                NewsItemId = 3
            },
            new NewsItemAuthors {
                AuthorId = 2,
                NewsItemId = 6
            },
            new NewsItemAuthors {
                AuthorId = 3,
                NewsItemId = 7
            },
            new NewsItemAuthors {
                AuthorId = 3,
                NewsItemId = 8
            },
            new NewsItemAuthors {
                AuthorId = 3,
                NewsItemId = 9
            },
            new NewsItemAuthors {
                AuthorId = 4,
                NewsItemId = 10
            },
            new NewsItemAuthors {
                AuthorId = 4,
                NewsItemId = 11
            },
            new NewsItemAuthors {
                AuthorId = 5,
                NewsItemId = 12
            },
            new NewsItemAuthors {
                AuthorId = 5,
                NewsItemId = 13
            },
            new NewsItemAuthors {
                AuthorId = 5,
                NewsItemId = 14
            },
            new NewsItemAuthors {
                AuthorId = 5,
                NewsItemId = 15
            },
            new NewsItemAuthors {
                AuthorId = 6,
                NewsItemId = 16
            },
            new NewsItemAuthors {
                AuthorId = 6,
                NewsItemId = 17
            },
            new NewsItemAuthors {
                AuthorId = 7,
                NewsItemId = 18
            },
            new NewsItemAuthors {
                AuthorId = 7,
                NewsItemId = 19
            },
            new NewsItemAuthors {
                AuthorId = 8,
                NewsItemId = 20
            },
            new NewsItemAuthors {
                AuthorId = 8,
                NewsItemId = 21
            },
            new NewsItemAuthors {
                AuthorId = 8,
                NewsItemId = 22
            },
            new NewsItemAuthors {
                AuthorId = 8,
                NewsItemId = 23
            },
            new NewsItemAuthors {
                AuthorId = 9,
                NewsItemId = 24
            },
            new NewsItemAuthors {
                AuthorId = 9,
                NewsItemId = 25
            },
            new NewsItemAuthors {
                AuthorId = 10,
                NewsItemId = 26
            },
            new NewsItemAuthors {
                AuthorId = 10,
                NewsItemId = 27
            }
        };

        public static List<NewsItemCategories> NewsItemsCategories = new List<NewsItemCategories>
        {
            new NewsItemCategories
            {
                CategoryId = 1,
                NewsItemId = 1
            },
            new NewsItemCategories {
                CategoryId = 1,
                NewsItemId = 2
            },
            new NewsItemCategories {
                CategoryId = 2,
                NewsItemId = 3
            },
            new NewsItemCategories {
                CategoryId = 2,
                NewsItemId = 4
            },
            new NewsItemCategories {
                CategoryId = 2,
                NewsItemId = 5
            },
            new NewsItemCategories {
                CategoryId = 2,
                NewsItemId = 6
            },
            new NewsItemCategories {
                CategoryId = 3,
                NewsItemId = 7
            }
        };
    }
}
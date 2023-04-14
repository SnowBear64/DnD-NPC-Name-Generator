using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NpcNameGenerator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnRandomize_Click(object sender, EventArgs e)
		{

            //Race list behavior
            Random rnd = new Random();
            String[] race = new String[8] {
                "Dragonborn", "Elf", "Human", "Dwarf", "Gnome", "Halfling", "Half-Orc", "Tiefling"};
            String randomRace = race[rnd.Next(0, 8)];
            if (boxRace.Checked == false)
            {
                comboRace.Text = randomRace;
            }

            //Gender list behavior
            String[] gender = new String[2] { "Male", "Female" };
            String randomGender = gender[rnd.Next(0, 2)];
            if (boxGender.Checked == false)
            {
                txtGender.Text = randomGender;
            }


            //Name list behavior. Changes based on the race and gender selected

            if (comboRace.Text == "Dragonborn" && boxName.Checked == false)
            {
                //Dragonborn male, first names
                String[] dragonbornMFnames = new String[50] {
                    "Adrex","Arjhan","Azzakh","Balasar","Baradad","Bharash","Bidreked","Dadalan","Dazzazn","Direcris",
                    "Donaar","Fax","Gargax","Ghesh","Gorbundus","Greethen","Heskan","Hirrathak","Ildrex","Kaladan",
                    "Kerkad","Kiirith","Kriv","Maagog","Medrash","Mehen","Mozikth","Mreksh","Mugrunden","Nadarr",
                    "Nithther","Norkruuth","Nykkan","Pandjed","Patrin","Pijjirik","Quarethon","Rathkran","Rhogar","Rivaan",
                    "Sethrekar","Shamash","Shedinn","Srorthen","Tarhun","Torinn","Trynnicus","Valorean","Vrondiss","Zedaar"};
                String randomDragonbornMFnames = dragonbornMFnames[rnd.Next(0, 50)];

                //Dragonborn female, first names
                String[] dragonbornFFnames = new String[50] {
                    "Akra","Asathra","Antrara","Arava","Biri","Blendaeth","Bruna","Chassath","Daar","Dentratha",
                    "Doudra","Driindar","Eggren","Farideh","Findex","Furrele","Gesrethe","Gilkass","Harann","Havilar",
                    "Hethress","Hillanot","Jaxi","Jezean","Jheri","Kadana","Kava","Korinn","Megren","Mijira",
                    "Mishann","Nala","Nuthra","Perra","Pogranix","Pyxrin","Quespa","Raiann","Rezena","Ruloth",
                    "Saphara","Savaran","Sora","Surina","Synthrin","Tatyan","Thava","Uadjit","Vezera","Zykroff"};
                String randomDragonbornFFnames = dragonbornFFnames[rnd.Next(0, 50)];

                if (boxName.Checked == false && txtGender.Text == "Male")
                {
                    txtFname.Text = randomDragonbornMFnames;
                }
                else if (boxName.Checked == false && txtGender.Text == "Female")
                {
                    txtFname.Text = randomDragonbornFFnames;
                }

                //Dragonborn last names
                String[] dragonbornLnames = new String[50] {
                    "Akambherylliax","Argenthrixus","Baharoosh","Beryntolthropal","Bhenkumbyrznaxx","Caavylteradyn","Chumbyxirinnish","Clethinthiallor","Daardendrian","Delmirev",
                    "Dhyrktelonis","Ebynichtomonis","Esstyrlynn","Fharngnarthnost","Ghaallixirn","Grrmmballhyst","Gygazzylyshrift","Hashphronyxadyn","Hshhsstoroth","Imbixtellrhyst",
                    "Jerynomonis","Jharthraxyn","Kerrhylon","Kimbatuul","Lhamboldennish","Linxakasendalor","Mohradyllion","Mystan","Nemmonis","Norixius",
                    "Ophinshtalajiir","Orexijandilin","Pfaphnyrennish","Phrahdrandon","Pyraxtallinost","Qyxpahrgh","Raghthroknaar","Shestendeliath","Skaarzborroosh","Sumnarghthrysh",
                    "Tiammanthyllish","Turnuroth","Umbyrphrael","Vangdondalor","Verthisathurgiesh","Wivvyrholdaphiax","Wystongjiir","Xephyrbahnor","Yarjerit","Zzzxaaxthroth" };
                String randomDragonbornLnames = dragonbornLnames[rnd.Next(0, 50)];

                if (boxName.Checked == false)
                {
                    txtLname.Text = randomDragonbornLnames;
                }


            }

            else if (comboRace.Text == "Elf" && boxName.Checked == false)
            {
                //Elf male, first names
                String[] elfMFnames = new String[50] {
                "Adran","Aelar","Aerdeth","Ahvain","Aramil","Arannis","Aust","Azaki","Beiro","Berrian",
                "Caeldrim","Carric","Dayereth","Dreali","Efferil","Eiravel","Enialis","Erdan","Erevan","Fivin",
                "Galinndan","Gennal","Hadarai","Halimath","Heian","Himo","Immeral","Ivellios","Korfel","Lamlis",
                "Laucian","Lucan","Mindartis","Naal","Nutae","Paelias","Peren","Quarion","Riardon","Rolen",
                "Soveliss","Suhnae","Thamior","Tharivol","Theren","Theriatis","Thervan","Uthemar","Vanuath","Varis"};
                String randomElfMFnames = elfMFnames[rnd.Next(0, 50)];

                //Elf female, first names
                String[] elfFFnames = new String[50] {
                "Adrie","Ahinar","Althaea","Anastrianna","Andraste","Antinua","Arara","Baelitae","Bethrynna","Birel",
                "Caelynn","Chaedi","Claira","Dara","Drusilia","Elama","Enna","Faral","Felosial","Hatae",
                "Ielnia","Ilanis","Irann","Jarsali","Jelenneth","Keyleth","Leshanna","Lia","Maiathah","Malquis",
                "Meriele","Mialee","Myathethil","Naivara","Quelenna","Quillathe","Ridaro","Sariel","Sharnairla","Shava",
                "Silaqui","Sumnes","Theirastra","Thiala","Tiaathque","Traulam","Vadania","Valanthe","Valna","Xanaphia"};
                String randomElfFFnames = elfFFnames[rnd.Next(0, 50)];

                if (boxName.Checked == false && txtGender.Text == "Male")
                {
                    txtFname.Text = randomElfMFnames;
                }
                else if (boxName.Checked == false && txtGender.Text == "Female")
                {
                    txtFname.Text = randomElfFFnames;
                }

                //Elf last names
                String[] elfLnames = new String[50] {
                "Aloro","Amakiir","Amastacia","Ariessus","Arnuanna","Berevan","Caerdonel","Caphaxath","Casilltenirra","Cithreth",
                "Dalanthan","Eathalena","Erenaeth","Ethanasath","Fasharash","Firahel","Floshem","Galanodel","Goltorath","Hanali",
                "Holimion","Horineth","Iathrana","Ilphelkiir","Iranapha","Koehlanna","Lathalas","Liadon","Meliamne","Mellerelel",
                "Mystralath","Nailo","Netyoive","Ofandrus","Ostoroth","Othronus","Qualanthri","Raethran","Rothenel","Selevarun",
                "Siannodel","Suithrasas","Sylvaranth","Teinithra","Tiltathana","Wasanthi","Withrethin","Xiloscient","Xistsrith","Yaeldrin"};
                String randomElfLnames = elfLnames[rnd.Next(0, 50)];

                if (boxName.Checked == false)
                {
                    txtLname.Text = randomElfLnames;
                }

            }

            else if (comboRace.Text == "Human" && boxName.Checked == false)
            {

                //Human male, African first names
                String[] humanMAfricanFnames = new String[50] {
                "Abebe","Abel","Abidemi","Abrafo","Adisa","Amadi","Amara","Anyim","Azabuike","Bapoto",
                "Baraka","Bohlale","Bongani","Bujune","Buziba","Chakide","Chibuzo","Chika","Chimola","Chiratidzo",
                "Dabulamanzi","Dumisa","Dwanh","Emeka","Folami","Gatura","Gebhuza","Gero","Isoba","Kagiso",
                "Kamau","Katlego","Masego","Matata","Nthanda","Ogechi","Olwenyo","Osumare","Paki","Qinisela",
                "Quanda","Samanya","Shanika","Sibonakaliso","Tapiwa","Thabo","Themba","Uzoma","Zuberi","Zuri"};
                String randomHumanMAfricanFnames = humanMAfricanFnames[rnd.Next(0, 50)];
                //Human female, African first names
                String[] humanFAfricanFnames = new String[50] {
                "Abebi","Abena","Abimbola","Akoko","Akachi","Alaba","Anuli","Ayo","Bolanle","Bosede",
                "Chiamaka","Chidi","Chidimma","Chinyere","Chioma","Dada","Ebele","Efemena","Ejiro","Ekundayo",
                "Enitan","Funanya","Ifunanya","Ige","Ime","Kunto","Lesedi","Lumusi","Mojisola","Monifa",
                "Nakato","Ndidi","Ngozi","Nkiruka","Nneka","Ogechi","Olamide","Oluchi","Omolara","Onyeka",
                "Simisola","Temitope","Thema","Titlayo","Udo","Uduak","Ufuoma","Yaa","Yejide","Yewande"};
                String randomHumanFAfricanFnames = humanFAfricanFnames[rnd.Next(0, 50)];


                //Human male, Arabic first names
                String[] humanMArabicFnames = new String[50] {
                "Abbad","Abdul","Achmed","Akeem","Alif","Amir","Asim","Bashir","Bassam","Fahim",
                "Farid","Farouk","Fayez","Fayyaad","Fazil","Hakim","Halil","Hamid","Hazim","Heydar",
                "Hussein","Jabari","Jafar","Jahid","Jamal","Kalim","Karim","Kazim","Khadim","Kalid",
                "Mahmud","Mansour","Musharraf","Mustafa","Nadir","Nazim","Omar","Qadir","Qusay","Rafiq",
                "Rakim","Rashad","Rauf","Saladin","Sami","Samir","Talib","Tamir","Tariq","Yazid"};
                String randomHumanMArabicFnames = humanMArabicFnames[rnd.Next(0, 50)];
                //Human female, Arabic first names
                String[] humanFArabicFnames = new String[50] {
                "Aaliyah","Aida","Akilah","Alia","Amina","Atefeh","Chaima","Dalia","Ehsan","Elham",
                "Farah","Fatemah","Gamila","Iesha","Inbar","Kamaria","Khadija","Layla","Lupe","Nabila",
                "Nadine","Naima","Najila","Najwa","Nakia", "Najwa", "Nawra","Nuha","Nura","Oma",
                "Qadira", "Qamar","Qistina","Rahima","Rihanna","Saadia","Sabah","Sada","Saffron","Sahar",
                "Salma","Shatha","Tahira","Takisha","Thana","Yadira","Zahra","Zaida","Zaina","Zeinab"};
                String randomHumanFArabicFnames = humanFArabicFnames[rnd.Next(0, 50)];


                //Human male, Celtic first names
                String[] humanMCelticFnames = new String[50] {
                "Airell","Airic","Alan","Anghus","Aodh","Bardon","Bearacb","Bevyn","Boden","Bran",
                "Brasil","Bredon","Brian","Bricriu","Bryant","Cadman","Caradoc","Cedric","Conalt","Conchobar",
                "Condon","Darcy","Devin","Dillion","Donaghy","Donall","Duer","Eghan","Ewyn","Ferghus",
                "Galvyn","Gildas","Guy","Harvey","Iden","Irven","Karney","Kayne","Kelvyn","Kunsgnos",
                "Leigh","Maccus","Moryn","Neale","Owyn","Pryderi","Reaghan","Taliesin","Tiernay","Turi"};
                String randomHumanMCelticFnames = humanMCelticFnames[rnd.Next(0, 50)];
                //Human female, Celtic first names
                String[] humanFCelticFnames = new String[50] {
                "Aife","Aina","Alane","Ardena","Arienh","Beatha","Birgit","Briann","Caomh","Cara",
                "Cinnia","Cordelia","Deheune","Divone","Donia","Doreena","Elsha","Enid","Ethne","Evelina",
                "Fianna","Genevieve","Gilda","Gitta","Grania","Gwyndolin","Idelisa","Isolde","Keelin","Kennocha",
                "Lavena","Lesley","Linnette","Lyonesse","Mabina","Marvina","Mavis","Mirna","Morgan","Muriel",
                "Nareena","Oriana","Regan","Ronat","Rowena","Selma","Ula","Venetia","Wynne","Yseult"};
                String randomHumanFCelticFnames = humanFCelticFnames[rnd.Next(0, 50)];


                //Human male, Chinese first names
                String[] humanMChineseFnames = new String[50] {
                "Bingwen","Bo","Bolin","Chang","Chao","Chen","Cheng","Da","Dingxiang","Fang",
                "Feng","Fu","Gang","Guang","Hai","Heng","Hong","Huan","Huang","Huiliang",
                "Huizhong","Jian","Jiayi","Junjie","Kang","Lei","Liang","Ling","Liwei","Melin",
                "Niu","Peizhi","Peng","Ping","Qiang","Qiu","Quan","Renshu","Rong","Ru",
                "Shan","Shen","Tengfei","Wei","Xiaobo","Xiaoli","Xin","Yang","Ying","Zhong"};
                String randomHumanMChineseFnames = humanMChineseFnames[rnd.Next(0, 50)];
                //Human female, Chinese first names
                String[] humanFChineseFnames = new String[50] {
                "Ai","Anming","Baozhai","Bei","Caixia","Changchang","Chen","Chou","Chunhua","Daianna",
                "Daiyu","Die","Ehuang","Fenfang","Ge","Hong","Huan","Huifang","Jia","Jiao",
                "Jiaying","Jingfei","Jinjing","Lan","Li","Lihua","Lin","Ling","Liu","Meili",
                "Ning","Qi","Qiao","Rong","Shu","Shuang","Song","Ting","Wen","Xia",
                "Xiaodan","Xiaoli","Xingjuan","Xue","Ya","Yan","Ying","Yuan","Yue","Yun"};
                String randomHumanFChineseFnames = humanFChineseFnames[rnd.Next(0, 50)];


                //Human male, Egyptian first names
                String[] humanMEgyptianFnames = new String[50] {
                "Ahmose","Akhom","Amasis","Amenemhet","Anen","Banefre","Bek","Djedefre","Djoser","Hekaib",
                "Henenu","Horemheb","Horwedja","Huya","Ibebi","Idu","Imhotep","Ineni","Ipuki","Irsu",
                "Kagemni","Kawab","Kenamon","Kewap","Khaemwaset","Khafra","Khusebek","Masaharta","Meketre","Menkhaf",
                "Merenre","Metjen","Nebamun","Nebetka","Nehi","Nekure","Nessumontu","Pakhom","Pawah","Pawero",
                "Ramose","Rudjek","Sabaf","Sebek-khu","Sebni","Senusret","Shabaka","Somintu","Thaneni","Thethi"};
                String randomHumanMEgyptianFnames = humanMEgyptianFnames[rnd.Next(0, 50)];
                //Human female, Egyptian first names
                String[] humanFEgyptianFnames = new String[50] {
                "A'at","Ahset","Amunet","Aneksi","Atet","Baketamon","Betrest","Bunefer","Dedyet","Hatshepsut",
                "Hentie","Herit","Hetepheres","Intakaes","Ipwet","Itet","Joba","Kasmut","Kemanub","Khemut",
                "Kiya","Maia","Menhet","Merit","Meritamen","Merneith","Merseger","Muyet","Nebet","Nebetah",
                "Nedjemmut","Nefertiti","Neferu","Neithotep","Nit","Nofret","Nubemiunu","Peseshet","Pypuy","Qalhata",
                "Rai","Redji","Sadeh","Sadek","Sitamun","Sitre","Takhat","Tarset","Taweret","Werenro"};
                String randomHumanFEgyptianFnames = humanFEgyptianFnames[rnd.Next(0, 50)];


                //Human male, English first names
                String[] humanMEnglishFnames = new String[50] {
                "Adam","Adelard","Aldous","Anselm","Arnold","Bernard","Bertram","Charles","Clerebold","Conrad",
                "Diggory","Drogo","Everard","Frederick","Geoffrey","Gerald","Gilbert","Godfrey","Gunter","Guy",
                "Henry","Heward","Hubert","Hugh","Jocelyn","John","Lance","Manfred","Miles","Nicholas",
                "Norman","Odo","Percival","Peter","Ralf","Randal","Raymond","Reynard","Richard","Robert",
                "Roger","Roland","Rolf","Simon","Theobald","Theodoric","Thomas","Timmm","William","Wymar"};
                String randomHumanMEnglishFnames = humanMEnglishFnames[rnd.Next(0, 50)];
                //Human female, English first names
                String[] humanFEnglishFnames = new String[50] {
                "Adelaide","Agatha","Agnes","Alice","Aline","Anne","Avelina","Avice","Beatrice","Cecily",
                "Egelina","Eleanor","Elizabeth","Ella","Eloise","Elysande","Emeny","Emma","Emmeline","Ermina",
                "Eva","Galiena","Geva","Giselle","Griselda","Hadwisa","Helen","Herleva","Hugolina","Ida",
                "Isabella","Jacoba","Jane","Joan","Juliana","Katherine","Margery","Mary","Matilda","Maynild",
                "Millicent","Oriel","Rohesia","Rosalind","Rosamund","Sarah","Susannah","Sybil","Williamina","Yvonne"};
                String randomHumanFEnglishFnames = humanFEnglishFnames[rnd.Next(0, 50)];


                //Human male, French first names
                String[] humanMFrenchFnames = new String[50] {
                "Ambroys","Ame","Andri","Andriet","Anthoine","Bernard","Charles","Charlot","Colin","Denis",
                "Durant","Edouart","Eremon","Ernault","Ethor","Felix","Floquart","Galleren","Gaultier","Gilles",
                "Guy","Henry","Hugo","Imbert","Jacques","Jacquot","Jean","Jehannin","Louis","Louys",
                "Loys","Martin","Michel","Mille","Morelet","Nicholas","Nicolle","Qudart","Perrin","Phillippe",
                "Pierre","Regnault","Richart","Robert","Robinet","Sauvage","Simon","Talbot","Tanguy","Vincent"};
                String randomHumanMFrenchFnames = humanMFrenchFnames[rnd.Next(0, 50)];
                //Human female, French first names
                String[] humanFFrenchFnames = new String[50] {
                "Aalis","Agatha","Agnez","Alberea","Alips","Amee","Amelot","Anne","Avelina","Blancha",
                "Cateline","Cecilia","Claricia","Collette","Denisete","Dorian","Edelina","Emelina","Emmelot","Ermentrudis",
                "Gibelina","Gila","Gillette","Guiburgis","Guillemette","Guoite","Hecelina","Heloysis","Helyoudis","Hodeardis",
                "Isabellis","Jaquette","Jehan","Johanna","Juliote","Katerine","Luciana","Margot","Marguerite","Maria",
                "Marie","Melisende","Odelina","Perrette","Petronilla","Sedilia","Stephana","Sybilla","Ysabeau","Ysabel"};
                String randomHumanFFrenchFnames = humanFFrenchFnames[rnd.Next(0, 50)];


                //Human male, German first names
                String[] humanMGermanFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanMGermanFnames = humanMGermanFnames[rnd.Next(0, 50)];
                //Human female, German first names
                String[] humanFGermanFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanFGermanFnames = humanFGermanFnames[rnd.Next(0, 50)];


                //Human male, Greek first names
                String[] humanMGreekFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanMGreekFnames = humanMGreekFnames[rnd.Next(0, 50)];
                //Human female, Greek first names
                String[] humanFGreekFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanFGreekFnames = humanFGreekFnames[rnd.Next(0, 50)];


                //Human male, Indian first names
                String[] humanMIndianFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanMIndianFnames = humanMIndianFnames[rnd.Next(0, 50)];
                //Human female, Indian first names
                String[] humanFIndianFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanFIndianFnames = humanFIndianFnames[rnd.Next(0, 50)];


                //Human male, Japanese first names
                String[] humanMJapaneseFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanMJapaneseFnames = humanMJapaneseFnames[rnd.Next(0, 50)];
                //Human female, Japanese first names
                String[] humanFJapaneseFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanFJapaneseFnames = humanFJapaneseFnames[rnd.Next(0, 50)];


                //Human male, Mesoamerican first names
                String[] humanMMesoamericanFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanMMesoamericanFnames = humanMMesoamericanFnames[rnd.Next(0, 50)];
                //Human female, Mesoamerican first names
                String[] humanFMesoamericanFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanFMesoamericanFnames = humanFMesoamericanFnames[rnd.Next(0, 50)];


                //Human male, Norse first names
                String[] humanMNorseFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanMNorseFnames = humanMNorseFnames[rnd.Next(0, 50)];
                //Human female, Norse first names
                String[] humanFNorseFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanFNorseFnames = humanFNorseFnames[rnd.Next(0, 50)];


                //Human male, Polynesian first names
                String[] humanMPolynesianFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanMPolynesianFnames = humanMPolynesianFnames[rnd.Next(0, 50)];
                //Human female, Polynesian first names
                String[] humanFPolynesianFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanFPolynesianFnames = humanFPolynesianFnames[rnd.Next(0, 50)];


                //Human male, Roman first names
                String[] humanMRomanFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanMRomanFnames = humanMRomanFnames[rnd.Next(0, 50)];
                //Human female, Roman first names
                String[] humanFRomanFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanFRomanFnames = humanFRomanFnames[rnd.Next(0, 50)];


                //Human male, Slavic first names
                String[] humanMSlavicFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanMSlavicFnames = humanMSlavicFnames[rnd.Next(0, 50)];
                //Human female, Slavic first names
                String[] humanFSlavicFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanFSlavicFnames = humanFSlavicFnames[rnd.Next(0, 50)];


                //Human male, Spanish first names
                String[] humanMSpanishFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanMSpanishFnames = humanMSpanishFnames[rnd.Next(0, 50)];
                //Human female, Slavic first names
                String[] humanFSpanishFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanFSpanishFnames = humanFSpanishFnames[rnd.Next(0, 50)];

                if (boxName.Checked == false && txtGender.Text == "Male")
                {
                    //Randomizes region-specific Male names
                    if (comboHumanName.Text == "African")
                    {
                        txtFname.Text = randomHumanMAfricanFnames;
                    }
                    else if (comboHumanName.Text == "Arabic")
                    {
                        txtFname.Text = randomHumanMArabicFnames;
                    }
                    else if (comboHumanName.Text == "Celtic")
                    {
                        txtFname.Text = randomHumanMCelticFnames;
                    }
                    else if (comboHumanName.Text == "Chinese")
                    {
                        txtFname.Text = randomHumanMChineseFnames;
                    }
                    else if (comboHumanName.Text == "Egyptian")
                    {
                        txtFname.Text = randomHumanMEgyptianFnames;
                    }
                    else if (comboHumanName.Text == "English")
                    {
                        txtFname.Text = randomHumanMEnglishFnames;
                    }
                    else if (comboHumanName.Text == "French")
                    {
                        txtFname.Text = randomHumanMFrenchFnames;
                    }
                    else if (comboHumanName.Text == "German")
                    {
                        txtFname.Text = randomHumanMGermanFnames;
                    }
                    else if (comboHumanName.Text == "Greek")
                    {
                        txtFname.Text = randomHumanMGreekFnames;
                    }
                    else if (comboHumanName.Text == "Indian")
                    {
                        txtFname.Text = randomHumanMIndianFnames;
                    }
                    else if (comboHumanName.Text == "Japanese")
                    {
                        txtFname.Text = randomHumanMJapaneseFnames;
                    }
                    else if (comboHumanName.Text == "Mesoamerican")
                    {
                        txtFname.Text = randomHumanMMesoamericanFnames;
                    }
                    else if (comboHumanName.Text == "Norse")
                    {
                        txtFname.Text = randomHumanMNorseFnames;
                    }
                    else if (comboHumanName.Text == "Polynesian")
                    {
                        txtFname.Text = randomHumanMPolynesianFnames;
                    }
                    else if (comboHumanName.Text == "Roman")
                    {
                        txtFname.Text = randomHumanMRomanFnames;
                    }
                    else if (comboHumanName.Text == "Slavic")
                    {
                        txtFname.Text = randomHumanMSlavicFnames;
                    }
                    else if (comboHumanName.Text == "Spanish") 
                    {
                        txtFname.Text = randomHumanMSpanishFnames;
                    }

                }
                else if (boxName.Checked == false && txtGender.Text == "Female")
                {
                    //Randomizes region-specific Female names
                    if (comboHumanName.Text == "African")
                    {
                        txtFname.Text = randomHumanFAfricanFnames;
                    }
                    else if (comboHumanName.Text == "Arabic")
                    {
                        txtFname.Text = randomHumanFArabicFnames;
                    }
                    else if (comboHumanName.Text == "Celtic")
                    {
                        txtFname.Text = randomHumanFCelticFnames;
                    }
                    else if (comboHumanName.Text == "Chinese")
                    {
                        txtFname.Text = randomHumanFChineseFnames;
                    }
                    else if (comboHumanName.Text == "Egyptian")
                    {
                        txtFname.Text = randomHumanFEgyptianFnames;
                    }
                    else if (comboHumanName.Text == "English")
                    {
                        txtFname.Text = randomHumanFEnglishFnames;
                    }
                    else if (comboHumanName.Text == "French")
                    {
                        txtFname.Text = randomHumanFFrenchFnames;
                    }
                    else if (comboHumanName.Text == "German")
                    {
                        txtFname.Text = randomHumanFGermanFnames;
                    }
                    else if (comboHumanName.Text == "Greek")
                    {
                        txtFname.Text = randomHumanFGreekFnames;
                    }
                    else if (comboHumanName.Text == "Indian")
                    {
                        txtFname.Text = randomHumanFIndianFnames;
                    }
                    else if (comboHumanName.Text == "Japanese")
                    {
                        txtFname.Text = randomHumanFJapaneseFnames;
                    }
                    else if (comboHumanName.Text == "Mesoamerican")
                    {
                        txtFname.Text = randomHumanFMesoamericanFnames;
                    }
                    else if (comboHumanName.Text == "Norse")
                    {
                        txtFname.Text = randomHumanFNorseFnames;
                    }
                    else if (comboHumanName.Text == "Polynesian")
                    {
                        txtFname.Text = randomHumanFPolynesianFnames;
                    }
                    else if (comboHumanName.Text == "Roman")
                    {
                        txtFname.Text = randomHumanFRomanFnames;
                    }
                    else if (comboHumanName.Text == "Slavic")
                    {
                        txtFname.Text = randomHumanFSlavicFnames;
                    }
                    else if (comboHumanName.Text == "Spanish")
                    {
                        txtFname.Text = randomHumanFSpanishFnames;
                    }
                }

                //Human last names
                String[] humanLnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHumanLnames = humanLnames[rnd.Next(0, 50)];

                if (boxName.Checked == false)
                {
                    txtLname.Text = randomHumanLnames;
                }
            }

            else if (comboRace.Text == "Dwarf" && boxName.Checked == false)
            {
                //Dwarf male, first names
                String[] dwarfMFnames = new String[50] {
                "Adrik","Alberich","Baern","Barendd","Beloril","Brottor","Dain","Dalgal","Darrak","Delg",
                "Duergath","Dworic","Eberk","Einkil","Elaim","Erias","Fallond","Fargrim","Gardain","Gilthur",
                "Gimgen","Gimurt","Harbek","Kildrak","Kilvar","Morgran","Morkral","Nalral","Nordak","Nurval",
                "Oloric","Olunt","Orsik","Oskar","Rangrim","Reirak","Rurik","Taklinn","Thoradin","Thorin",
                "Thradal","Tordek","Traubon","Travok","Ulfgar","Uraim","Veit","Vonbin","Vondal","Whurbin"};
                String randomDwarfMFnames = dwarfMFnames[rnd.Next(0, 50)];

                //Dwarf female, first names
                String[] dwarfFFnames = new String[50] {
                "Anbera","Artin","Audhild","Balifra","Barbena","Bardryn","Bolhild","Dagnal","Dariff","Delre",
                "Diesa","Eldeth","Eridred","Falkrunn","Fallthra","Finellen","Gillydd","Gunnloda","Gurdis","Helgret",
                "Gelja","Hlin","Ilde","Jarana","Kathra","Kilia","Kristryd","Liftrasa","Marastyr","Mardred",
                "Morana","Nalaed","Nora","Nurkara","Oriff","Ovina","Riswynn","Sannl","Therlin","Thodris",
                "Torbera","Tordrid","Torgga","Urshar","Valida","Vistra","Vonana","Werydd","Whurdred","Yurgunn"};
                String randomDwarfFFnames = dwarfFFnames[rnd.Next(0, 50)];

                if (boxName.Checked == false && txtGender.Text == "Male")
                {
                    txtFname.Text = randomDwarfMFnames;
                }
                else if (boxName.Checked == false && txtGender.Text == "Female")
                {
                    txtFname.Text = randomDwarfFFnames;
                }

                //Dwarf last names
                String[] dwarfLnames = new String[50] {
                "Aranore","Baldrek","Battlehammer","Bigtoe","Bloodkith","Bofdan","Brawnanvil","Brazzik","Broodfist","Burrowfound",
                "Caebrek","Daerdahk","Dankil","Daraln","Deepdelver","Durthane","Eversharp","Fallack","Fireforge","Foamtankard",
                "Frostbeard","Glanhig","Goblinbane","Goldfinder","Gorunn","Graybeard","Hammerstone","Helcral","Holderhek","Ironfist",
                "Loderr","Lutgehr","Morigak","Orcfoe","Rakankrak","Ruby-Eye","Rumnaheim","Silveraxe","Silverstone","Steelfist",
                "Stoutale","Strakeln","Strongheart","Thrahak","Torevir","Torunn","Trollbleeder","Trueanvil","Trueblood","Ungart"};
                String randomDwarfLnames = dwarfLnames[rnd.Next(0, 50)];

                if (boxName.Checked == false)
                {
                    txtLname.Text = randomDwarfLnames;
                }
            }

            else if (comboRace.Text == "Gnome" && boxName.Checked == false)
            {
                //Gnome male, first names
                String[] gnomeMFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomGnomeMFnames = gnomeMFnames[rnd.Next(0, 50)];

                //Gnome female, first names
                String[] gnomeFFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomGnomeFFnames = gnomeFFnames[rnd.Next(0, 50)];

                if (boxName.Checked == false && txtGender.Text == "Male")
                {
                    txtFname.Text = randomGnomeMFnames;
                }
                else if (boxName.Checked == false && txtGender.Text == "Female")
                {
                    txtFname.Text = randomGnomeFFnames;
                }

                //Gnome last names
                String[] gnomeLnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomLnames = gnomeLnames[rnd.Next(0, 50)];

                if (boxName.Checked == false)
                {
                    txtLname.Text = randomLnames;
                }
            }

            else if (comboRace.Text == "Halfling" && boxName.Checked == false)
            {
                //Halfling male, first names
                String[] halflingMFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHalflingMFnames = halflingMFnames[rnd.Next(0, 50)];

                //Halfling female, first names
                String[] halflingFFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHalflingFFnames = halflingFFnames[rnd.Next(0, 50)];

                if (boxName.Checked == false && txtGender.Text == "Male")
                {
                    txtFname.Text = randomHalflingMFnames;
                }
                else if (boxName.Checked == false && txtGender.Text == "Female")
                {
                    txtFname.Text = randomHalflingFFnames;
                }

                //Halfling last names
                String[] halflingLnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHalflingLnames = halflingLnames[rnd.Next(0, 50)];

                if (boxName.Checked == false)
                {
                    txtLname.Text = randomHalflingLnames;
                }
            }

            else if (comboRace.Text == "Half-Orc" && boxName.Checked == false)
            {
                //Half-Orc male, first names
                String[] halforcMFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHalforcMFnames = halforcMFnames[rnd.Next(0, 50)];

                //Half-Orc female, first names
                String[] halforcFFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomHalforcFFnames = halforcFFnames[rnd.Next(0, 50)];

                if (boxName.Checked == false && txtGender.Text == "Male")
                {
                    txtFname.Text = randomHalforcMFnames;
                }
                else if (boxName.Checked == false && txtGender.Text == "Female")
                {
                    txtFname.Text = randomHalforcFFnames;
                }

                //Half-Orc last names
                String[] halforcLnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomLnames = halforcLnames[rnd.Next(0, 50)];

                if (boxName.Checked == false)
                {
                    txtLname.Text = randomLnames;
                }
            }

            else if (comboRace.Text == "Tiefling" && boxName.Checked == false)
            {
                //Tiefling male, first names
                String[] tieflingMFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomTieflingMFnames = tieflingMFnames[rnd.Next(0, 50)];

                //Tiefling female, first names
                String[] tieflingFFnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomTieflingFFnames = tieflingFFnames[rnd.Next(0, 50)];

                if (boxName.Checked == false && txtGender.Text == "Male")
                {
                    txtFname.Text = randomTieflingMFnames;
                }
                else if (boxName.Checked == false && txtGender.Text == "Female")
                {
                    txtFname.Text = randomTieflingFFnames;
                }

                //Tiefling last names
                String[] tieflingLnames = new String[50] {
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","","",
                "","","","","","","","","",""};
                String randomTieflingLnames = tieflingLnames[rnd.Next(0, 50)];

                if (boxName.Checked == false)
                {
                    txtLname.Text = randomTieflingLnames;
                }
            }
        }

		private void btnClear_Click(object sender, EventArgs e)
		{
            txtFname.Text = "";
            txtLname.Text = "";
            comboRace.Text = "";
            txtGender.Text = "";
            txtPhysicalQuality.Text = "";
            txtPersonalityQuirk.Text = "";
            txtIdeal.Text = "";
            txtBond.Text = "";
            txtFlawSecret.Text = "";
        }

		private void btnExit_Click(object sender, EventArgs e)
		{
            //Closes the program
            this.Close();
        }

		private void comboRace_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (comboRace.Text == "Human")
            {
                comboHumanName.Visible = true;
            }
            else {
                comboHumanName.Visible = false;
            }
		}
	}
}

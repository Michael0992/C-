using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Maze_of_Monolith
{
    internal class Rooms
    {
        //level 1 rooms
        ArrayList room1 = new ArrayList() { "r1", "in einem kleinen dunklen Raum. Überall um dich herum liegen Felstrümer",new string[]{ "n1", "", "", ""}, "","" , new string[] { "room1.png", "","","" } };
        ArrayList room2 = new ArrayList() { "r2", "in einem langen Gang.", new string[] { "d1", "d2", "n1", "" }, "", "", "room2", new string[] { "room2.png", "r1", "room2v2", "r3" } };
        ArrayList room3 = new ArrayList() { "r3", "in einem kleinem Raum, das Licht scheint von oben.", new string[] { "", "", "", "" }, "", "Heiltrank" , new string[] { "room3.png", "", "", "" } };
        ArrayList room4 = new ArrayList() { "r4", "in einem relativ kurzen Gang.", new string[] { "d1", "k1", "d3", "" }, "", "" , new string[] { "room4.png", "r2", "room4v2.png", "r7" } };
        ArrayList room5 = new ArrayList() { "r5", "auf einer steinernden Treppe,", new string[] { "k1", "d4", "", "" }, "", "", new string[] { "room5.png", "r4", "room5.png", "r5" } };
        ArrayList room6 = new ArrayList() { "r6", "in einem hell erleuchtetn Raum", new string[] { "d4", "", "", "" }, "", "Ewige Fackel", new string[] { "room6.png", "", "", "" } };
        ArrayList room7 = new ArrayList() { "r7", "in einer dunklen Gruft.", new string[] { "d3", "d5", "d6", "d7" }, "Kobold", "", new string[] { "room7.png", "", "", "" } };
        ArrayList room8 = new ArrayList() { "r8", "in einem finsteren kalten Raum.", new string[] { "d8", "", "", "" }, "", "k1", new string[] { "room8.png", "", "", "" } };
        ArrayList room9 = new ArrayList() { "r9", "auf einer schmalen Treppe.", new string[] { "d8", "d5", "", "" }, "", "", new string[] { "room5.png", "r7", "room5v2.png", "r8" } };
        ArrayList room10 = new ArrayList() {"r10","auf einer glitschigen Treppe.", new string[] { "d7", "d9", "", "" }, "", "" };
        ArrayList room11 = new ArrayList() { "r11", "in einer modrig riechenden Halle.", new string[] { "d10", "d9", "d11", "" }, "Zombie", "" };
        ArrayList room12 = new ArrayList() { "r12", "in einem hohen aber schmalen Raum.", new string[] { "d10", "", "", "" }, "", "Heiltrank" };
        ArrayList room13 = new ArrayList() { "r13", "auf einer sehr kurzen Treppe mit großen Stufen.", new string[] { "d11", "d12", "", "" }, "", "" };
        ArrayList room14 = new ArrayList() { "r14", "in einem langen Gang.", new string[] { "d6", "d14", "d13", "" }, "", "" };
        ArrayList room15 = new ArrayList() { "r15", "in einem dunklen Gang", new string[] { "d15", "d14", "", "" }, "", "" };
        ArrayList room16 = new ArrayList() { "r16", "in einem Raum. Hier riecht es füchterlich!", new string[] { "d16", "d15", "", "" }, "", "Gegengift" };
        ArrayList room17 = new ArrayList() { "r17", "in einem sehr langen Gang mit Fackeln an den Wänden. Wie sind die wohl dahingekommen?!", new string[] { "d16", "k2", "", "" }, "", "" };
        ArrayList room18 = new ArrayList() { "r18", "in einem Raum auf dessen Boden und Wände überall Knochen liegen.", new string[] { "d13", "d21", "", "" }, "Stachelfalle", "" };
        ArrayList room19 = new ArrayList() { "r19", "in einem Runden Raum. Fahles Licht scheint von oben auf ein Podest herab.", new string[] { "d12", "d21", "d22", "d20" }, "", "k2" };
        ArrayList room20 = new ArrayList() { "r20", "in einem winzigen Raum. Vor dir die Überreste einer armen Seele die mit ihrem Blut die Worte  -- Augen -- an die Wand geschrieben hat. Du nimmst diese Warnung zur Kenntnis!", new string[] { "d22", "d23", "", "" }, "", "" };
        ArrayList room21 = new ArrayList() { "r21", "in einer Halle voller Spinnennetze, die dick wie Drahtseile sind", new string[] { "d23", "d26", "d25", "d24" }, "Goliat die Riesenspinne", "" };
        ArrayList room22 = new ArrayList() { "r22", "in einem kleinen Raum mit einem Podest. Auch hier sind überall Netze.", new string[] { "d26", "", "", "" }, "", "Gegengift" };
        ArrayList room23 = new ArrayList() { "r23", "in einem kleinen Raum. An den Wänden wächst überall grüner Schimmel.", new string[] { "d27", "", "", "" }, "", "Heiltrank" };
        ArrayList room24 = new ArrayList() { "r24", "in einem feuchten und felsigen Koridorr", new string[] { "d27", "d25", "d28", "" }, "", "" };
        ArrayList room25 = new ArrayList() { "r25", "in einem runden Raum. An den Wänden kann man überall die spurren goldener Hiroglyphen erkennen. In der mitte steht ein Podest.", new string[] { "", "", "d28", "" }, "", "Scharfe Klinge der Morgendämerung" };
        ArrayList room26 = new ArrayList() { "r26", "auf einer schmalen Treppe mit kurzen Stufen.", new string[] { "d24", "d29", "", "" }, "", "" };
        ArrayList room27 = new ArrayList() { "r27", "ein einem kleinen Raum mit staubigen Boden", new string[] { "d37", "", "", "" }, "", "k4" };
        ArrayList room28 = new ArrayList() { "r28", "in einem Raum mit niedriger Decke. Überall liegen Knochen!", new string[] { "d37", "d36", "", "" }, "Stachelfalle", "" };
        ArrayList room29 = new ArrayList() { "r29", "in einem kleinen Raum. Deine Füße treten auf die knochigen überreste von kleinen Nagetieren wie es dir scheint...", new string[] { "d35", "d36", "", "" }, "Kobold", "" };
        ArrayList room30 = new ArrayList() { "r30", "auf einer großen Treppe mit staubigen Stufen.", new string[] { "d33", "d34", "d35", "" }, "", "" };
        ArrayList room31 = new ArrayList() { "r31", "in einer riesigen Halle die mit schlangenänlichen Säulen gesäumt ist. Auf dem Boden liegen die Überesste von Menschen die weniger glück hatten als du.", new string[] { "k3", "d32", "d33", "" }, "Zenic der Schlangenkönig", "" };
        ArrayList room32 = new ArrayList() { "r32", "in einer winzigen Kammer.", new string[] { "d32", "", "", "" }, "", "Heiltrank" };
        ArrayList room33 = new ArrayList() { "r33", "in einem Raum in dem das Licht auf eine Blutbeschmierte Wand fällt!  -- Schlangenkönig -- ist die Aufschrifft. Du nimmst die Warnung zu Kenntnis!", new string[] { "d31", "k3", "", "" }, "", "" };
        ArrayList room34 = new ArrayList() { "r34", "in einem dunklen Schacht.", new string[] { "d30", "d31", "", "" }, "", "" };
        ArrayList room35 = new ArrayList() { "r35", "einer geläufigen Kammer.", new string[] { "d30", "d19", "", "" }, "", "Schnelfeuer Armbrust" };
        ArrayList room36 = new ArrayList() { "r36", "in einem so schmalen Gang das du dich kaum hindurchzwengen kannst.", new string[] { "d19", "d17", "", "" }, "", "" };
        ArrayList room37 = new ArrayList() { "r37", "in einer großen Kammer. Hier riecht es irgendwie komisch ...", new string[] { "k2", "d18", "", "" }, "Kobold", "" };
        ArrayList room38 = new ArrayList() { "r38", "in einem gewölbten Korridor. Feuchtigkeit tropft von den Wänden.", new string[] { "d18", "d20", "", "" }, "", "" };
        ArrayList room39 = new ArrayList() { "r39", "in einem mit blauen Licht durchfluteten Raum, in dem es so Kalt ist, das sich Eisblumen an den Wänden gebildet haben. In der Mitte des Raumes befindet sich ein Podest.", new string[] { "d40", "", "", "" }, "", "Eisstab der hundert Winter" };
        ArrayList room40 = new ArrayList() { "r40", "in einem sehr sehr langen Gang. Der Boden ist hier mit Wasser durchflutet.", new string[] { "d40", "d38", "", "" }, "", "" };
        ArrayList room41 = new ArrayList() { "r41", "in einer nach Moder riechen Halle. Wasser tropft in rinsalen von der Decke.", new string[] { "d38", "d39", "d34", "" }, "Zombie", "" };
        ArrayList room42 = new ArrayList() { "r42", "in einem engen Schacht. Die Temperatur ist hier unangenehm heiß! Es kommt dir wie eine Warnung vor!", new string[] { "d39", "k4", "d44", "" }, "", "" };
        ArrayList room43 = new ArrayList() { "r43", "in einem Korridor. Es ist hier sehr warm.", new string[] { "k4", "d42", "d43", "d41" }, "", "" };
        ArrayList room44 = new ArrayList() { "r44", "in kleinen Raum mit einem Podest", new string[] { "d41", "", "", "" }, "", "" };
        ArrayList room45 = new ArrayList() { "r45", "in kleinen Raum mit einem Podest", new string[] { "d42", "", "", "" }, "", "" };
        ArrayList room46 = new ArrayList() { "r46", "in kleinen Raum mit einem Podest", new string[] { "d43", "", "", "" }, "", "" };
        ArrayList room47 = new ArrayList() { "r47", "in einer gigantischen Halle. Hier ist es so heiß das dir schwindelig wird. Überall sind verkohlte Knochen", new string[] { "d44", "d45", "", "" }, "Der Rote Drache", "" };
        ArrayList room48 = new ArrayList() { "r48", "in einem Raum der Augenscheinlich aus der Pyramide führt. Etwas sagt dir, du hast es geschafft", new string[] { "d45", "n2", "", "" }, "", "" };
        ArrayList room49 = new ArrayList() { "r49", "in kleinen Raum mit einem Podest und staubigen Steinfliesen", new string[] { "d29", "", "", "" }, "", "K3" };



        static ArrayList rooms;
        
        
        internal Rooms()
        {
            rooms.Add(room1);
            rooms.Add(room2);
            rooms.Add(room3);
            rooms.Add(room4);
            rooms.Add(room5);
            rooms.Add(room6);
            rooms.Add(room7);
            rooms.Add(room8);
            rooms.Add(room9);
            rooms.Add(room10);
            rooms.Add(room11);
            rooms.Add(room12);
            rooms.Add(room13);
            rooms.Add(room14);
            rooms.Add(room15);
            rooms.Add(room16);
            rooms.Add(room17);
            rooms.Add(room18);
            rooms.Add(room19);
            rooms.Add(room20);
            rooms.Add(room21);
            rooms.Add(room22);
            rooms.Add(room23);
            rooms.Add(room24);
            rooms.Add(room25);
            rooms.Add(room26);
            rooms.Add(room27);
            rooms.Add(room28);
            rooms.Add(room29);
            rooms.Add(room30);
            rooms.Add(room31);
            rooms.Add(room32);
            rooms.Add(room33);
            rooms.Add(room34);
            rooms.Add(room35);
            rooms.Add(room36);
            rooms.Add(room37);
            rooms.Add(room38);
            rooms.Add(room39);
            rooms.Add(room40);
            rooms.Add(room41);
            rooms.Add(room42);
            rooms.Add(room43);
            rooms.Add(room44);
            rooms.Add(room45);
            rooms.Add(room46);
            rooms.Add(room47);
            rooms.Add(room48);
            rooms.Add(room49);

 

        }





















    }
}

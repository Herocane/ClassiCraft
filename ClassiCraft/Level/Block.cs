﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassiCraft {
    public class Block {
        public const byte Air = (byte)0;
        public const byte Rock = (byte)1;
        public const byte Grass = (byte)2;
        public const byte Dirt = (byte)3;
        public const byte Stone = (byte)4;
        public const byte Wood = (byte)5;
        public const byte Shrub = (byte)6;
        public const byte Blackrock = (byte)7;
        public const byte Water = (byte)8;
        public const byte Waterstill = (byte)9;
        public const byte Lava = (byte)10;
        public const byte Lavastill = (byte)11;
        public const byte Sand = (byte)12;
        public const byte Gravel = (byte)13;
        public const byte Goldrock = (byte)14;
        public const byte Ironrock = (byte)15;
        public const byte Coal = (byte)16;
        public const byte Trunk = (byte)17;
        public const byte Leaf = (byte)18;
        public const byte Sponge = (byte)19;
        public const byte Glass = (byte)20;
        public const byte Red = (byte)21;
        public const byte Orange = (byte)22;
        public const byte Yellow = (byte)23;
        public const byte Lightgreen = (byte)24;
        public const byte Green = (byte)25;
        public const byte Aquagreen = (byte)26;
        public const byte Cyan = (byte)27;
        public const byte Lightblue = (byte)28;
        public const byte Blue = (byte)29;
        public const byte Purple = (byte)30;
        public const byte Lightpurple = (byte)31;
        public const byte Pink = (byte)32;
        public const byte Darkpink = (byte)33;
        public const byte Darkgrey = (byte)34;
        public const byte Lightgrey = (byte)35;
        public const byte White = (byte)36;
        public const byte Yellowflower = (byte)37;
        public const byte Redflower = (byte)38;
        public const byte Mushroom = (byte)39;
        public const byte Redmushroom = (byte)40;
        public const byte Goldsolid = (byte)41;
        public const byte Iron = (byte)42;
        public const byte Staircasefull = (byte)43;
        public const byte Staircasestep = (byte)44;
        public const byte Brick = (byte)45;
        public const byte Tnt = (byte)46;
        public const byte Bookcase = (byte)47;
        public const byte Stonevine = (byte)48;
        public const byte Obsidian = (byte)49;

        // Portals
        public const byte PortalAir = (byte)100;
        public const byte PortalWater = (byte)108;
        public const byte PortalLava = (byte)110;
        public const byte PortalRed = (byte)121;
        public const byte PortalOrange = (byte)122;
        public const byte PortalYellow = (byte)123;
        public const byte PortalLightgreen = (byte)124;
        public const byte PortalGreen = (byte)125;
        public const byte PortalAquagreen = (byte)126;
        public const byte PortalCyan = (byte)127;
        public const byte PortalLightblue = (byte)128;
        public const byte PortalBlue = (byte)129;
        public const byte PortalPurple = (byte)130;
        public const byte PortalLightpurple = (byte)131;
        public const byte PortalPink = (byte)132;
        public const byte PortalDarkpink = (byte)133;
        public const byte PortalDarkgrey = (byte)134;
        public const byte PortalLightgrey = (byte)135;
        public const byte PortalWhite = (byte)136;

        public static byte Random() {
            Random rnd = new Random();
            return (byte)rnd.Next( 21, 36 );
        }

        public static string Name( byte type ) {
            switch ( type ) {
                case 0: return "Air";
                case 1: return "Rock";
                case 2: return "Grass";
                case 3: return "Dirt";
                case 4: return "Stone";
                case 5: return "Wood";
                case 6: return "Shrub";
                case 7: return "Blackrock";
                case 8: return "Water";
                case 9: return "Waterstill";
                case 10: return "Lava";
                case 11: return "Lavastill";
                case 12: return "Sand";
                case 13: return "Gravel";
                case 14: return "Goldrock";
                case 15: return "Ironrock";
                case 16: return "Coal";
                case 17: return "Trunk";
                case 18: return "Leaf";
                case 19: return "Sponge";
                case 20: return "Glass";
                case 21: return "Red";
                case 22: return "Orange";
                case 23: return "Yellow";
                case 24: return "Lightgreen";
                case 25: return "Green";
                case 26: return "Aquagreen";
                case 27: return "Cyan";
                case 28: return "Lightblue";
                case 29: return "Blue";
                case 30: return "Purple";
                case 31: return "Lightpurple";
                case 32: return "Pink";
                case 33: return "Darkpink";
                case 34: return "Darkgray";
                case 35: return "Gray";
                case 36: return "White";
                case 37: return "Yellowflower";
                case 38: return "Redflower";
                case 39: return "Mushroom";
                case 40: return "Redmushroom";
                case 41: return "Gold";
                case 42: return "Iron";
                case 43: return "Staircasefull";
                case 44: return "Staircasestep";
                case 45: return "Brick";
                case 46: return "Tnt";
                case 47: return "Bookcase";
                case 48: return "Stonevine";
                case 49: return "Obsidian";

                // Portals
                case 100: return "PortalAir";
                case 108: return "PortalWater";
                case 110: return "PortalLava";
                case 121: return "PortalRed";
                case 122: return "PortalOrange";
                case 123: return "PortalYellow";
                case 124: return "PortalLightgreen";
                case 125: return "PortalGreen";
                case 126: return "PortalAquagreen";
                case 127: return "PortalCyan";
                case 128: return "PortalLightblue";
                case 129: return "PortalBlue";
                case 130: return "PortalPurple";
                case 131: return "PortalLightpurple";
                case 132: return "PortalPink";
                case 133: return "PortalDarkpink";
                case 134: return "PortalDarkgray";
                case 135: return "PortalGray";
                case 136: return "PortalWhite";
                default: return null;
            }
        }

        public static byte Byte( string name ) {
            switch ( name.ToLower() ) {
                case "air": return (byte)0;
                case "rock": return (byte)1;
                case "grass": return (byte)2;
                case "dirt": return (byte)3;
                case "stone": return (byte)4;
                case "wood": return (byte)5;
                case "shrub": return (byte)6;
                case "blackrock": return (byte)7;
                case "water": return (byte)8;
                case "waterstill": return (byte)9;
                case "lava": return (byte)10;
                case "lavastill": return (byte)11;
                case "sand": return (byte)12;
                case "gravel": return (byte)13;
                case "goldrock": return (byte)14;
                case "ironrock": return (byte)15;
                case "coal": return (byte)16;
                case "trunk": return (byte)17;
                case "leaf": return (byte)18;
                case "sponge": return (byte)19;
                case "glass": return (byte)20;
                case "red": return (byte)21;
                case "orange": return (byte)22;
                case "yellow": return (byte)23;
                case "lightgreen": return (byte)24;
                case "green": return (byte)25;
                case "aquagreen": return (byte)26;
                case "cyan": return (byte)27;
                case "lightblue": return (byte)28;
                case "blue": return (byte)29;
                case "purple": return (byte)30;
                case "lightpurple": return (byte)31;
                case "pink": return (byte)32;
                case "darkpink": return (byte)33;
                case "darkgray": return (byte)34;
                case "gray": return (byte)35;
                case "white": return (byte)36;
                case "yellowflower": return (byte)37;
                case "redflower": return (byte)38;
                case "mushroom": return (byte)39;
                case "redmushroom": return (byte)40;
                case "gold": return (byte)41;
                case "iron": return (byte)42;
                case "staircasefull": return (byte)43;
                case "staircasestep": return (byte)44;
                case "brick": return (byte)45;
                case "tnt": return (byte)46;
                case "bookcase": return (byte)47;
                case "stonevine": return (byte)48;
                case "obsidian": return (byte)49;

                // Portals
                case "portalair": return (byte)100;
                case "portalwater": return (byte)108;
                case "portallava": return (byte)110;
                case "portalred": return (byte)121;
                case "portalorange": return (byte)122;
                case "portalyellow": return (byte)123;
                case "portallightgreen": return (byte)124;
                case "portalgreen": return (byte)125;
                case "portalaquagreen": return (byte)126;
                case "portalcyan": return (byte)127;
                case "portallightblue": return (byte)128;
                case "portalblue": return (byte)129;
                case "portalpurple": return (byte)130;
                case "portallightpurple": return (byte)131;
                case "portalpink": return (byte)132;
                case "portaldarkpink": return (byte)133;
                case "portaldarkgray": return (byte)134;
                case "portalgray": return (byte)135;
                case "portalwhite": return (byte)136;
                default: unchecked { return (byte)-1; }
            }
        }

        public static byte Convert( byte type ) {
            switch ( type ) {
                default:
                    if ( type >= 100 ) {
                        return (byte)( type - 100 );
                    } else {
                        return type;
                    }
            }
        }
    }
}
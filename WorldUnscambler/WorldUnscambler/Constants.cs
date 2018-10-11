using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldUnscambler
{
    class Constants
    {
        public const string OptionsOnHowToEnterScrambledWords = "Enter scrambled word(s) manually or as a file: F-file / M-manual: ";
        public const string OptionsOnContinuingTheProgram = "Would you like to continue? Y/N: ";

        public const string EnterScrambledWordViaFile = "Enter full path including the file name: ";
        public const string EnterScrambledWordManually = "Enter word(s) manually (separated by comas if multiple): ";

        public const string EnterScrambledWordsOptionNotRecognized = "The option was not recognized.";
        public const string ErrorScrambleWordsCannotBeLoaded = "scrambled words were not loaded because there was an error: ";
        public const string ErrorProgramWillBeTerminated = "The program will be terminated: ";

        public const string MatchFound = "MATCH FOUND FOR {0}: {1}";
        public const string MatchNotFound = "NO MATCHES HAVE FOUND";

        public const string Yes = "Y";
        public const string No = "N";
        public const string File = "F";
        public const string Manual = "M";

        public const string wordListFileName = "wordlist.txt";
    }
}

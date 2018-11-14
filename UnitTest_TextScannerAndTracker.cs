using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReadabilityChecker;

namespace ReadabilityCheckerTests {

    /// <summary>
    /// Performs three simple unit tests to confirm that the scanner and tracker correctly count and record
    /// the number of sentences, words, and syllables.
    /// </summary>
    [TestClass]
    public class UnitTest_TextScannerAndTracker {

        private static string txtMainTest = "The rain in Spain stays mainly in the plain.";
       
        /// <summary>
        /// Verify that the number of sentences detected by the scanner is correct.
        /// </summary>
        [TestMethod]
        public void CountSentences_NumSentencesMatchesText_ReturnsNumSentences() {
            var trackerTest = new RCTracker();
            var scannerTest = new RCScanner();

            trackerTest.NumSentences = scannerTest.CountSentences(txtMainTest);
            Assert.AreEqual(trackerTest.NumSentences, 1, "Number of sentences reported: {0}. Expected value: 1", trackerTest.NumSentences);
        }

        /// <summary>
        /// Verify that the number of words detected by the scanner is correct.
        /// </summary>
        [TestMethod]
        public void TestWords_NumWordsMatchesText_ReturnsNumWords() {
            RCTracker trackerTest = new RCTracker();
            RCScanner scannerTest = new RCScanner();

            trackerTest.NumWords = scannerTest.CountWords(txtMainTest);
            Assert.AreEqual(trackerTest.NumWords, 9, "Number of words reported: {0}. Expected value: 9", trackerTest.NumWords);
        }

        /// <summary>
        /// Verify that the number of syllables detected by the scanner is correct.
        /// </summary>
        [TestMethod]
        public void TestSyllables_NumSyllables_ReturnSyllables() {
            RCTracker trackerTest = new RCTracker();
            RCScanner scannerTest = new RCScanner();

            trackerTest.NumSyllables = scannerTest.CountSyllables(txtMainTest);
            Assert.AreEqual(trackerTest.NumSyllables, 10, "Number of syllables reported: {0}. Expected value: 10", trackerTest.NumSyllables);
        }
    }
}

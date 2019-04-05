using System.Collections.Generic;

public class Anagram
{
    public string first { get; set; }
    public string second { get; set; }
    private char[] firstArray { get; set; }
    private char[] secondArray { get; set; }
    private Dictionary<char, int> lookUp { get; set; }
    private string returnString { get; set; }

    public Anagram()
    {

    }

    public Anagram(string first, string second) {
        this.first = first;
        this.second = second;
        this.firstArray = this.first.ToCharArray();
        this.secondArray = this.second.ToCharArray();
        this.lookUp = new Dictionary<char, int>();
    }

    private bool SameLength() {
        if (first.Length != second.Length) {
            this.returnString = "Not an Anagram";
            return false;
        }

        return true;
    }

    private void BuildLookUp() {
        foreach (var c in firstArray) {
            if (lookUp.ContainsKey(c)) {
                lookUp[c]++;
            } else {
                lookUp[c] = 1;
            }
        }

        string dic = "";
        foreach (var c in lookUp.Keys) {
            dic += c.ToString() + ": " + lookUp[c].ToString() + " ";//c().ToString() + " ";

        }

        this.returnString = dic;
    }

    private void CheckForMatchingLetters() {
        foreach (var c in secondArray) {
            if (!lookUp.ContainsKey(c)) {
                this.returnString += System.Environment.NewLine + "Not an Anagram";
                return;
            } else {
                lookUp[c] -= 1;
            }
        }

        this.returnString += System.Environment.NewLine + "Anagram!";
    }

    public string ValidAnagram() {
        if (!SameLength()) {
            return returnString;
        }

        BuildLookUp();
        CheckForMatchingLetters();

        return returnString;
    }
}
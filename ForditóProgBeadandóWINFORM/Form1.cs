using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForditóProgBeadandóWINFORM
{
    public partial class Assignment : Form
    {
        private int index;
        private string input;
        private string convertedInput;

        private Stack<char> signs;
        private List<int> ruleIDs;

        private bool noError, notAtEnd;

        public Assignment()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Input_BTN_Click(object sender, EventArgs e)
        {
            input = Input_TB.Text;
            convertedInput = ConvertInput(input);
            ConvertedInput_TB.Text = convertedInput;

            resultTitle.ForeColor = Color.Black;
            resultTitle.Text = "Input read and converted successfully!";
        }
        private void InputPath_BTN_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel|*.csv;*.txt";
            openFileDialog1.ShowDialog();
            inputPath_TB.Text = openFileDialog1.FileName;

            LoadCSVOnDataGridView(inputPath_TB.Text);

            convertedInput_BTN.Enabled = true;
        }
        private void LoadCSVOnDataGridView(string fileName)
        {
            try
            {
                ReadCSV csv = new ReadCSV(fileName);

                try
                {
                    ruleGrid.DataSource = csv.readCSV;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void ConvertedInput_BTN_Click(object sender, EventArgs e)
        {
            convertedInput = ConvertedInput_TB.Text;

            resultTitle.ForeColor = Color.Black;
            resultTitle.Text = "Converted text changed successfully!";
        }
        private void solver_BTN_Click(object sender, EventArgs e)
        {
            if (inputPath_TB.Text == "")
            {
                resultTitle.ForeColor = Color.Red;
                resultTitle.Text = "Please select csv or txt file!";
            }
            else
            {
                signs = new Stack<char>();
                ruleIDs = new List<int>();

                runAnalysis(ConvertedInput_TB.Text);

                Input_TB.Text = "";
                convertedInput = ConvertedInput_TB.Text;
                input = "";
                index = 0;
            }
        }
        private void runAnalysis(string text)
        {
            stepByStep_LB.Items.Clear();

            convertedInput = convertedInput + "#";
            signs.Push('#');

            string startS = ruleGrid.Rows[0].Cells[0].Value.ToString();
            int i = startS.Length - 1;

            foreach (char letter in startS)
            {
                signs.Push(startS[i--]);
            }

            index = 0;

            noError = true;
            notAtEnd = true;

            Analysis();

            if (noError)
            {
                resultTitle.ForeColor = Color.Green;
                resultTitle.Text = "Correct Input!";   // DELETE LATER
            }
            else
            {
                resultTitle.ForeColor = Color.Red;
                resultTitle.Text = "Incorrect Input!";
            }
        }
        private void Analysis()
        {
            WriteCurrentState();

            try
            {
                string coll = "";
                string row = "";

                if (signs.Peek() == '#')
                    row = signs.Peek().ToString();
                else
                {
                    row = signs.Pop().ToString();
                }

                if (signs.Peek() == '\'')
                    row += signs.Pop().ToString();

                coll += convertedInput[index].ToString();

                int collIndex = ruleGrid.Columns[coll].Index;
                int rowIndex = FindRowIndex(row);

                string newRuleRaw = (string)ruleGrid[collIndex, rowIndex].Value;
                string[] newRuleInformation = Trim(newRuleRaw).Split(',');

                string newRule = newRuleInformation[0];

                if (newRuleInformation.Length >= 2)
                {
                    int ruleCurrentID = Convert.ToInt32(newRuleInformation[1]);
                    ruleIDs.Add(ruleCurrentID);
                }


                int i = 0;

                switch (newRule)
                {
                    case "accept":
                        notAtEnd = false;
                        break;
                    case "ε":
                        break;
                    case "pop":
                        convertedInput = convertedInput.Substring(1);
                        break;
                    default:
                        foreach (char character in newRule)
                        {
                            signs.Push(newRule[newRule.Length - 1 - i]);
                            i++;
                        }
                        break;
                }

            }
            catch (Exception ex)
            {
                noError = false;
                notAtEnd = false;
            }

            while (notAtEnd)
            {
                Analysis();
            }
        }
        private int FindRowIndex(string searchValue)
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in ruleGrid.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }
            }
            return rowIndex;
        }
        private string Trim(string input)
        {
            string output = input;

            if (output[0] == '(')
                output = output.Substring(1);

            if (output[output.Length - 1] == ')')
                output = output.Substring(0, output.Length - 1);

            return output;
        }
        private string ConvertInput(string input)
        {
            string result = Regex.Replace(input, "[0-9]+", "i");
            result = String.Join("", result.Where(c => !char.IsWhiteSpace(c)));
            return result;
        }
        private void WriteCurrentState()
        {
            string currentLine = "(" + convertedInput + ", ";

            foreach (char character in signs)
                currentLine += character;

            currentLine += ", ";

            foreach (int number in ruleIDs)
                currentLine += number;

            currentLine += ")";

            stepByStep_LB.Items.Add(currentLine);
        }
    }
}

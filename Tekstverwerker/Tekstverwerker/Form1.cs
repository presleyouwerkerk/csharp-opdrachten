using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekstverwerker
{
    public partial class Form1 : Form
    {
        private static int documentCounter = 1;
        private string currentFilePath = string.Empty;
        private string originalText = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = $"Document{documentCounter} - Personal Notepad - Presley";
            documentCounter++; // Increment the counter for the next document
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the form
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load the selected file into the RichTextBox
                        richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);

                        // Update the current file path
                        currentFilePath = openFileDialog.FileName;

                        // Dynamically update the form's title to reflect the opened file name
                        Text = $"{Path.GetFileName(currentFilePath)} - Personal Notepad | Presley";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                // If no file path, call SaveAs
                SaveAs();
            }
            else
            {
                try
                {
                    // Save the content as RTF
                    richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);

                    // Update the title dynamically to the saved file name
                    Text = $"{Path.GetFileName(currentFilePath)} - Personal Notepad | Presley";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveAs()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|All Files (*.*)|*.*";
                saveFileDialog.DefaultExt = "rtf";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName; // Update the file path after saving

                    try
                    {
                        // Save the content as RTF
                        richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);

                        // Update the title dynamically to the saved file name
                        Text = $"{Path.GetFileName(currentFilePath)} - Personal Notepad | Presley";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
            {
                richTextBox1.Undo(); // Perform the undo operation
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo)
            {
                richTextBox1.Redo(); // Perform the redo operation
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Apply the selected color to the selected text
                    richTextBox1.SelectionColor = colorDialog.Color;
                }
            }
        }

        private void styleSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                // Set the initial font to the current selection's font
                fontDialog.Font = richTextBox1.SelectionFont;

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    // Apply the selected font to the selected text
                    richTextBox1.SelectionFont = fontDialog.Font;
                }
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Changes the background color
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog.Color;
            }
        }

        private void hideTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save the original text and replace it with asterisks
            originalText = richTextBox1.Text;
            richTextBox1.Text = new string('*', originalText.Length);
        }

        private void unhideTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Restore the original text
            richTextBox1.Text = originalText;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Personal Notepad\nDeveloped by Presley", "About");
        }

        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For support, contact: presley@example.com", "Support");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Pull in the classes for doing input and output.
using System.IO;

namespace HexViewer
{
    public partial class Form1 : Form
    {
        //Field to pull the file stream object for the currently opened file
        private FileStream fsCurrFile = null; 

        public Form1()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Format a sequence of 8 bytes for display, starting at the location iStart
        // in the byte array byByteSeq. Each byte is written in hex, with a space
        // between each pair of bytes.
        private string strEightBytesToHex(byte[] byByteSeq, int iStart, int iNumBytes) {
            // Start with the first byte.
            string strOutput = byByteSeq[iStart].ToString("X2");
            // Append the remaining bytes, separated by spaces.
            for (int iLoc = iStart + 1; iLoc < iStart + iNumBytes; iLoc++) {
                strOutput += " " + byByteSeq[iLoc].ToString("X2");
            }
            // Finished. Return string.
            return strOutput;
        }

        // Format a paragraph for display. The bytes in the paragraph are written
        // in hex, with a space between each pair of bytes. An extra space separates
        // the first 8 bytes from the second 8 bytes.
        private string strParaToHex(byte[] byParagraph, int iNumBytes) {
            // Format the first 8 bytes in the paragraph.
            string strOutput = strEightBytesToHex(byParagraph, 0, Math.Min(9, iNumBytes));
            // Format the remaining 8 bytes and append to the output, with two
            // spaces in between.
            if (iNumBytes > 8)
            {
                strOutput += "  " + strEightBytesToHex(byParagraph, 8, iNumBytes - 8);
            }
            // Finished. Return string.
            return strOutput;
        }

        // Convert a sequence of 8 bytes to ASCII text, representing bytes that are
        // not printable ASCII characters with '.'.
        private string strEightBytesToASCII(byte[] byByteSeq, int iStart, int iNumBytes) {
            // Build up the output character by character, starting with "".
            string strOutput = "";
            // Loop through 8 bytes starting at iStart, converting each byte to
            // ASCII (if possible) and appending to the output.
            for (int iLoc = iStart; iLoc < iStart + iNumBytes; iLoc++) {
                byte byOneByte = byByteSeq[iLoc];
                if (0x20 <= byOneByte && byOneByte <= 0x7E) {
                    strOutput += (char)byOneByte;
                } else {
                    strOutput += '.';
                }
            }
            // Finished. Return string.
            return strOutput;
        }

        // Convert a paragraph to ASCII text, as above. A space separates the first
        // 8 bytes from the second 8 bytes.
        private string strParaToASCII(byte[] byParagraph, int iNumBytes) {
            // Convert the first 8 bytes, then the second 8 bytes, concatenating with
            // a space in between.
            string strOutput = strEightBytesToASCII(byParagraph, 0, Math.Min(8, iNumBytes));
            strOutput += " " + strEightBytesToASCII(byParagraph, 8, iNumBytes - 8);
            // Finished. Return string.
            return strOutput;
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            //Display the open file dialog. Proceed to open the file only if the user
            //clicked the "Open" button (dialog result is "OK")
            DialogResult drOpenResult = ofdOpenFile.ShowDialog();
            if (drOpenResult == DialogResult.OK)
            {
                //Open the file and set up the form to display that file's data
                fsCurrFile = File.Open(ofdOpenFile.FileName, FileMode.Open, FileAccess.Read);
                //Enable the numeric up-down and set up the max value so that choosing
                //the max value displays the last 5 paragraphs in the file
                nudStartParagraph.Enabled = true;
                double dNumBytesInFile = fsCurrFile.Length;
                double dNumParasInFile = Math.Ceiling(dNumBytesInFile / 16.0);
                double dMaxParaNumInNUD = Math.Max(dNumParasInFile - 5.0, 0.0);
                nudStartParagraph.Maximum = (decimal)dMaxParaNumInNUD;
                //Set starting paragraph in numeric up-down to 0 so we start displaying
                //bytes at the beginning of the file
                nudStartParagraph.Value = 0;
                //Display the first five paragraphs in the file
                nudStartParagraph_ValueChanged(null, null);
            }
        }

        private void nudStartParagraph_ValueChanged(object sender, EventArgs e)
        {
            if (fsCurrFile != null)
            {
                //Calc byte number to move to then do a seek to move the FPP
                long lStartByteNum = (long)nudStartParagraph.Value * 16;
                fsCurrFile.Seek(lStartByteNum, SeekOrigin.Begin);
                //Read and Display 5 paragraphs from the file
                //Clear the Data Grid View
                dgvContent.Rows.Clear();
                //Set up buffer for data read from file
                byte[] byBuffer = new byte[16];
                for (int iCount = 0; iCount < 5; iCount++)
                {
                    int iBytesRead = fsCurrFile.Read(byBuffer, 0, byBuffer.Length);
                    //Only display if we read at least 1 byte
                    if (iBytesRead > 0)
                    {
                        //Get the hex and text version of the paragraph data
                        string strHex = strParaToHex(byBuffer, iBytesRead);
                        string strText = strParaToASCII(byBuffer, iBytesRead);
                        //Number of current paragraph is value from the NUD plus iCount
                        decimal decParaNum = nudStartParagraph.Value + iCount;
                        //Add a row to the data grid view
                        dgvContent.Rows.Add(new object[] { decParaNum, strHex, strText });
                    }
                }
            }
        }

        private void miClose_Click(object sender, EventArgs e)
        {
            //Close the current file, disable the NUD, and clear out the data grid view
            if (fsCurrFile != null)
            {
                fsCurrFile.Close();
                fsCurrFile = null;
            }
            nudStartParagraph.Value = 0;
            nudStartParagraph.Enabled = false;
            dgvContent.Rows.Clear();
        }
    }
}

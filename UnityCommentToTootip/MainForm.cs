using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnityCommentToTootip
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void OnConvertButton_Click(object sender, EventArgs e)
		{
			string comment = m_TextBox.Text;
			StringBuilder sb = new StringBuilder();

			string[] commentLines = comment.Split(new string[] { "\r\n" }, StringSplitOptions.None);
			for (int iCommentLine = 0; iCommentLine < commentLines.Length; iCommentLine++)
			{
				string iterCommentLine = commentLines[iCommentLine];
				int indexOf = iterCommentLine.IndexOf("///");
				if (indexOf < 0)
				{
					continue;
				}

				if (sb.Length > 0)
				{
					sb.Append("\\n");
				}
				else
				{
					sb.Append("[Tooltip(\"");
				}

				iterCommentLine = iterCommentLine.Substring(indexOf + 3).TrimStart(' ');
				if (iterCommentLine.StartsWith("\t"))
				{
					iterCommentLine = iterCommentLine.Substring(1);
				}
				iterCommentLine = iterCommentLine.Replace("\t", "\\t").Replace("\"", "\\\"");
				sb.Append(iterCommentLine);
			}

			if (sb.Length > 0)
			{
				sb.Append("\")]");
			}

			string tooltip = sb.ToString();
			if (tooltip.Length > 0)
			{
				Clipboard.SetText(tooltip, TextDataFormat.Text);
			}
		}
	}
}
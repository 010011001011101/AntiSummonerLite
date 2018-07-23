using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AntiSummonerLite
{
  public partial class MainForm : Form
  {
    private readonly Random _Random = new Random(DateTime.Now.Millisecond);

    public MainForm()
    {
      InitializeComponent();
    }

    private void CalcBtn_Click(object sender, EventArgs e)
    {
      var dmg = _GetDamage().Where(d => d != 0).ToList();
      if (!dmg.Any()) return;

      var calculation = new Calculation((int)DC.Value, (int)Save.Value, (int)CL.Value, Evasion.Checked, ImprovedEvasion.Checked, (int)SR.Value, (int)Resist.Value);
      var results = Enumerable.Range(1, (int) Count.Value).Select(n => (n, calculation.Calculate(_Random, dmg).ToList()));

      _Write(dmg, results);
    }

    #region Write output

    private void _Write(ICollection<int> dmg, IEnumerable<(int num, List<Calculation.Result> results)> results)
    {
      _Nl();
      OutputText.AppendText($"############ [{DateTime.Now:T}] ############"); _Nl();
      OutputText.AppendText($"Attacks Damage: [{string.Join(", ", dmg)}] (MAX: {dmg.Sum()})"); _Nl();
      _Nl();

      using (var dmgFont = new Font(OutputText.Font, FontStyle.Bold | FontStyle.Underline))
      {
        var dmgLength = dmg.Max(d => d.ToString().Length);
        foreach (var result in results)
        {
          var start = OutputText.TextLength;

          OutputText.AppendText($"{_S(result.num)} - DMG: ");
          _AppendWithFont(dmgFont, _S(result.results.Sum(r => r.Damage), dmgLength));
          OutputText.AppendText(" = ");

          var offset = OutputText.TextLength - start;
          var firstFlag = true;
          foreach (var subResult in result.results)
          {
            if (firstFlag)
              firstFlag = false;
            else
              _WriteOffset(offset);

            _Write(subResult, dmgFont, dmgLength);
          }

          _Nl();
          _Nl();
        }
      }

      OutputText.SelectionStart = OutputText.Text.Length;
      OutputText.ScrollToCaret();
    }

    private void _Write(Calculation.Result result, Font dmgFont, int dmgLength)
    {
      OutputText.AppendText("[");

      if (result.NeedSr)
      {
        OutputText.AppendText("SR - ");
        _AppendCheckResult(result.SrCheckResult);
        OutputText.AppendText($" {S(result.SrCheck + result.Calculation.Cl)}:[{S(result.SrCheck)}");
        OutputText.AppendText($" + {S(result.Calculation.Cl)}] {(result.SrCheckResult ? " <" : ">=")} {S(result.Calculation.Sr)} | ");
      }

      if (result.NeedSave)
      {
        OutputText.AppendText("SAVE - ");
        _AppendCheckResult(result.SaveCheckResult);
        OutputText.AppendText($" {S(result.SaveCheck + result.Calculation.Save)}:[");
        _AppendCheck(result.SaveCheck);
        OutputText.AppendText($" + {S(result.Calculation.Save)}] {(result.SaveCheckResult ? ">=" : " <")} {S(result.Calculation.Dc)}");
      }
      else
        OutputText.AppendText("                              ");

      OutputText.AppendText(" => ");
      _AppendWithFont(dmgFont, S(result.Damage, dmgLength));
      OutputText.AppendText("]");
    }

    private void _AppendCheckResult(bool checkResult)
    {
      OutputText.SelectionColor = checkResult ? Color.DarkGreen : Color.DarkRed;
      OutputText.AppendText(checkResult ? " OK " : "FAIL");
      OutputText.SelectionColor = OutputText.ForeColor;
    }

    private void _AppendCheck(int check)
    {
      if (check == 20)
        OutputText.SelectionColor = Color.Green;
      if (check == 1)
        OutputText.SelectionColor = Color.Red;

      OutputText.AppendText(S(check));
      OutputText.SelectionColor = OutputText.ForeColor;
    }

    public static string S(int value, int minLenght = 2)
    {
      var str = value.ToString();

      if (str.Length < minLenght)
        for (var i = 0; i < minLenght - str.Length; ++i)
          str = " " + str;

      return str;
    }

    private void _WriteOffset(int offset)
    {
      var sb = new StringBuilder();
      sb.AppendLine(" +");
      for (var i = 0; i < offset; ++i)
        sb.Append(" ");

      OutputText.AppendText(sb.ToString());
    }

    private void _Nl()
    {
      OutputText.AppendText(Environment.NewLine);
    }

    private string _S(int value, int minLenght = 2)
    {
      var str = value.ToString();

      if (str.Length < minLenght)
        for (var i = 0; i < minLenght - str.Length; ++i)
          str = " " + str;

      return str;
    }

    private void _AppendWithFont(Font font, string text)
    {
      OutputText.SelectionFont = font;
      OutputText.AppendText(text);
      OutputText.SelectionFont = OutputText.Font;
    }

    #endregion

    #region Damage Counter

    private IEnumerable<int> _GetDamage()
    {
      return from attack in Attacks.Text.Split(' ')
             where !string.IsNullOrWhiteSpace(attack)
             select Math.Max(1,_GetAttackParts(attack).Sum());
    }

    private IEnumerable<int> _GetAttackParts(string attack)
    {
      var negative = false;
      var start = 0;
      var end = 0;

      for (var i = 0; i < attack.Length; ++i)
      {
        var ch = attack[i];
        if (ch == '-' || ch == '+')
        {
          if (i != 0 && end >= start)
            yield return _GetPartDamage(attack.Substring(start, end - start + 1), negative);

          negative = ch == '-';
          start = i + 1;
        }
        else
          end = i;
      }

      if (end >= start)
        yield return _GetPartDamage(attack.Substring(start, end - start + 1), negative);
    }

    private int _GetPartDamage(string part, bool negative)
    {
      var koef = negative ? -1 : 1;

      if (int.TryParse(part, out var dmg))
        return dmg * koef;

      var subParts = part.Split('d', 'D');
      if (subParts.Length != 2)
        return 0;

      if (!int.TryParse(subParts[0], out var count) ||
          !int.TryParse(subParts[1], out var dice))
        return 0;

      return Enumerable.Range(1, count).Sum(n => _Random.Next(1, dice + 1)) * koef;
    }

    #endregion
  }
}

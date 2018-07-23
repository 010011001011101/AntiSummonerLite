using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AntiSummonerLite
{
  public class Calculation
  {
    public readonly int Dc;
    public readonly int Save;
    public readonly int Cl;
    public readonly bool Evasion;
    public readonly bool ImprovedEvasion;
    public readonly int Sr;
    public readonly int Resist;

    public Calculation(int dc, int save, int cl = 0, bool evasion = false, bool improvedEvasion = false, int sr = 0, int resist = 0)
    {
      Dc = dc;
      Save = save;
      Cl = cl;
      Evasion = evasion;
      ImprovedEvasion = improvedEvasion;
      Sr = sr;
      Resist = resist;
    }

    public IEnumerable<Result> Calculate(Random random, IEnumerable<int> dmg)
    {
      var dice = Dice.CreateD20(random);
      return dmg.Select(d => _Calculate(d, dice));
    }

    private Result _Calculate(int dmg, Dice dice)
    {
      var srCheck = dice.Roll();
      if (Sr > 0 && srCheck + Cl < Sr)
        return new Result(this, 0, srCheck, true, 0, false);

      var saveCheck = dice.Roll();
      var saveCheckResult = false;
      if ((saveCheck == 20 || saveCheck + Save >= Dc) && saveCheck != 1)
      {
        dmg = Evasion ? 0 : dmg / 2;
        saveCheckResult = true;
      }
      else
        dmg = ImprovedEvasion ? dmg / 2 : dmg;

      dmg = Math.Max(0, dmg - Resist);

      return new Result(this, dmg, srCheck, false, saveCheck, saveCheckResult);
    }
    public class Result
    {
      public readonly Calculation Calculation;
      public readonly int Damage;
      public readonly int SrCheck;
      public readonly bool SrCheckResult;
      public readonly int SaveCheck;
      public readonly bool SaveCheckResult;

      public bool NeedSr => Calculation.Sr > 0;
      public bool NeedSave => !SrCheckResult;

      public Result(Calculation calculation, int dmg, int srCheck, bool srCheckResult, int saveCheck, bool saveCheckResult)
      {
        Calculation = calculation;
        Damage = dmg;
        SrCheck = srCheck;
        SrCheckResult = srCheckResult;
        SaveCheck = saveCheck;
        SaveCheckResult = saveCheckResult;
      }
    }

    private class Dice
    {
      private readonly Random _Random;
      private readonly int _Dice;

      private Dice(Random random, int dice)
      {
        _Random = random;
        _Dice = dice;
      }

      public int Roll()
      {
        return _Random.Next(1, _Dice + 1);
      }

      public static Dice CreateD20(Random random)
      {
        return new Dice(random, 20);
      }
    }
  }
}
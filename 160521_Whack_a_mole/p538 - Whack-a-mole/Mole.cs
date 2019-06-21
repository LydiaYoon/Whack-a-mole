using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p538___Whack_a_mole
{
using System.Windows.Forms;
class Mole {
    public delegate void PopUp(int hole, bool show);
    private PopUp popUpCallback;
    private bool hidden;
    public bool Hidden { get { return hidden; } }
    private int timesHit = 0;
    private int timesShown = 0;
    private bool hit = false;
    private int hole = 0;
    private int miss = 0;
    Random random;

    public Mole(Random random, PopUp popUpCallback) {
        if (popUpCallback == null)
            throw new ArgumentException("popUpCallback can’t be null");
        this.random = random;
        this.popUpCallback = popUpCallback;
        hidden = true;
    }

    public void Show() {
        timesShown++;
        hit = false;
        hidden = false;
        hole = random.Next(6);
        popUpCallback(hole, true);
    }

    public void HideAgain() {
        hit = false;
        hidden = true;
        popUpCallback(hole, false);
        CheckForGameOver();
        miss++;
    }

    public void Smacked(int holeSmacked) {
        if (holeSmacked == hole && hidden == false)
        {
            timesHit++;
            hit = true;
            hidden = true;
            CheckForGameOver();
            popUpCallback(hole, false);
        }
    }

    private void CheckForGameOver() {
        //if (timesShown >= 10) {
        //    popUpCallback(-1, false);
        //    MessageBox.Show("You scored " + timesHit, "Game over");
        //    Application.Exit();
        //}
    }
    public int getScore() { return timesHit; }
    public int getMiss() { return miss; }
    public int getHole() { return hole; }
    public bool getHit() { return hit; }
}
}

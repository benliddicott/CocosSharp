using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CocosSharp;

namespace tests
{
    public class LabelsEmpty : AtlasDemo
    {
        public LabelsEmpty()
        {
			var s = CCDirector.SharedDirector.WinSize;

            // CCLabelBMFont
			var label1 = new CCLabelBMFont("", "fonts/bitmapFontTest3.fnt");
            AddChild(label1, 0, (int)TagSprite.kTagBitmapAtlas1);
            label1.Position = new CCPoint(s.Width / 2, s.Height - 100);

            // CCLabelTTF
			var label2 = new CCLabelTtf("", "arial", 24);
            AddChild(label2, 0, (int)TagSprite.kTagBitmapAtlas2);
            label2.Position = new CCPoint(s.Width / 2, s.Height / 2);

            // CCLabelAtlas
			var label3 = new CCLabelAtlas("", "fonts/tuffy_bold_italic-charmap", 48, 64, ' ');
            AddChild(label3, 0, (int)TagSprite.kTagBitmapAtlas3);
            label3.Position = new CCPoint(s.Width / 2, 0 + 100);

            base.Schedule(updateStrings, 1.0f);

            setEmpty = false;
        }

        public void updateStrings(float dt)
        {
			var label1 = (CCLabelBMFont)GetChildByTag((int)TagSprite.kTagBitmapAtlas1);
			var label2 = (CCLabelTtf)GetChildByTag((int)TagSprite.kTagBitmapAtlas2);
			var label3 = (CCLabelAtlas)GetChildByTag((int)TagSprite.kTagBitmapAtlas3);

            if (!setEmpty)
            {
                label1.Text = ("not empty");
                label2.Text = ("not empty");
                label3.Text = ("hi");

                setEmpty = true;
            }
            else
            {
                label1.Text = ("");
                label2.Text = ("");
                label3.Text = ("");

                setEmpty = false;
            }
        }

        public override string title()
        {
            return "Testing empty labels";
        }

        public override string subtitle()
        {
            return "3 empty labels: LabelAtlas, LabelTTF and LabelBMFont";
        }

        private bool setEmpty;
    }
}

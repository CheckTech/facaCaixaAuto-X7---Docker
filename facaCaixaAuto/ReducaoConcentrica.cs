using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bonus630.vsta.FacaCaixaAuto
{
    class ReducaoConcentrica : FacaBase,IFaca
    {
        public const string name = "Redução Concêntrica";
        public const bool simetric = false;
        public ReducaoConcentrica(string height, string width, string length)
            : base(height, width, length)
        {
            this.Draw();
        }

        public void Draw()
        {
            FacaBase.app.ActiveLayer.CreateEllipse2(0, 0, 60, 0, 0, 180, false);
            FacaBase.app.ActiveLayer.CreateEllipse2(0, 0, 220, 0, 0, 180, false);
           
        }
        protected override void DrawAreaArte() { }
        protected override void DrawTabCoverSide() { }
        protected override void DrawBody() { }
        public void Mirror() { }
        public void UpDown() { }
        protected override void DrawVol()
        {
           
        }
    
    }
}

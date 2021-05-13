using System;

namespace learninterface
{
    public interface IcoreBanking
    {
        void updateTransition(string cusId, string Ref, int amtdposit, int amtcredit);
    }
    public class CoreBanking : IcoreBanking
    {
        public void updateTransition(string cusId, string Ref, int amtdeposit, int amtcredit)
        {
            {
                Transition trans = new Transition();
                trans.save(cusId, Ref, amtdeposit, amtcredit);

            }


        }
    }
}

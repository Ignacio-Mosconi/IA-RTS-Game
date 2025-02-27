using UnityEngine;
using GreenNacho.AI.Fsm;

namespace MinerFsm
{
    [System.Serializable]
    public class MinerDepositingGold : FsmState<Miner>
    {
        [SerializeField, Range(0f, 2f)] float depositTimeOut = 1f;

        float depositTimer;

        public override void EnterState()
        {
            depositTimer = 0f;
        }

        public override void UpdateState()
        {
            depositTimer += Time.deltaTime;

            if (depositTimer >= depositTimeOut)
                owner.OnTimeOut.Invoke();
        }
    }
}
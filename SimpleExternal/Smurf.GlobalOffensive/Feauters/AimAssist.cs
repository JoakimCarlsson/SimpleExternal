﻿using System;
using System.Numerics;
using Smurf.GlobalOffensive.Utils;

namespace Smurf.GlobalOffensive.Feauters
{
    //Todo
    //1. Get a target, and check the bones that are visible. For this we need BSP parsing. Might add that some day...
    //2. Humanized smooth aim to the target. Faster and faster until get come into a certin distance of the target than we randonize it.
    //3. Berizer curve or something simular to that to make it so the line won't be a perfect line.
    //4. Generate a random point somewhere around the target we'll initial aim at and than aim at target again. 
    //5. Maybe make RCS a bit more randomized.
    public class AimAssist
    {
        #region Fields

        #endregion

        #region Methods

        public void Update()
        {

        }

        //private Vector3 AngelToTarget(Player target)
        //{
        //    Vector3 myView = Core.LocalPlayer.Position + Core.LocalPlayer.VecView;
        //    Vector3 aimView = target.GetBonePos(target, _targetBone);

        //    Vector3 dst = myView.CalcAngle(aimView);
        //    dst = dst.NormalizeAngle();
        //    return dst;
        //}

        public void SetViewAngles(Vector3 viewAngles)
        {
            viewAngles = viewAngles.ClampAngle();
            viewAngles = viewAngles.NormalizeAngle();
            Core.Memory.Write((IntPtr)(Core.ClientState + Offsets.ClientState.ViewAngles), viewAngles);
        }
        #endregion
    }
}

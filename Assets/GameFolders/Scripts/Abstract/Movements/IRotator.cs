using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.GameFolders.Scripts.Abstract.Movements
{
    public interface IRotator
    {
        void RotationAction(float direction,float speed);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    enum DesktopMaterials
    {
        Pine,
        Laminate,
        Veneer,
        Oak,
        Rosewood
    }

    class Desk
    {
        private const decimal MIN_WIDTH = 24;
        private const decimal MAX_WIDTH = 96;

        private const decimal MIN_DEPTH = 12;
        private const decimal MAX_DEPTH = 48;

        private const int MIN_NUM_OF_DRAWERS = 0;
        private const int MAX_NUM_OF_DRAWERS = 7;

        private decimal _width;
        private decimal _depth;
        private int _numberOfDrawers;
        private DesktopMaterials _desktopMaterial;

        public decimal Width
        {
            get { return _width; }
            set
            {
                if (value > MAX_WIDTH)
                    _width = MAX_WIDTH;
                
                else if (value < MIN_WIDTH)
                    _width = MIN_WIDTH;

                else
                    _width = value;
            }
        }

        public decimal Depth
        {
            get { return _depth; }
            set
            {
                if (value > MAX_DEPTH)
                    _depth = MAX_DEPTH;

                else if (value < MIN_DEPTH)
                    _depth = MIN_DEPTH;

                else
                    _depth = value;
            }
        }

        public DesktopMaterials DesktopMaterial
        {
            get { return _desktopMaterial;  }
            set { _desktopMaterial = value; }
        }

        public Desk(decimal width = 24,
                    decimal depth = 12,
                    int numberOfDrawers = 0,
                    DesktopMaterials desktopMaterial = DesktopMaterials.Pine)
        {
            _width = width;
            _depth = depth;
            _numberOfDrawers = numberOfDrawers;
            _desktopMaterial = desktopMaterial;
        }

        public int NumberOfDrawers
        {
            get { return _numberOfDrawers; }
            set
            {
                if (value > MAX_NUM_OF_DRAWERS)
                {
                    _numberOfDrawers = MAX_NUM_OF_DRAWERS;
                }
                else if (value < MIN_NUM_OF_DRAWERS)
                {
                    _numberOfDrawers = MIN_NUM_OF_DRAWERS;
                }
                else
                    _numberOfDrawers = value;
            }
        }
    }
}

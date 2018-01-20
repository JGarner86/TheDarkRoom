using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagEngineLib
{
    /// <summary>
    /// Describes the base properties and functions of items.
    /// </summary>
    public class ItemModel : IDisposable
    {
        public enum EndEffectType { Positve, Negative, Null }
        public enum ItemType { Weapon, Consumable, Key, Artifact, Wearable, Structure }
        public enum StructureStatus { Open, Closed }
        public enum ItemStatus { Enabled, Disabled }

        public int Level { get; set; }
        public int MaxLevel { get; set; }
        public int MinLevel { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int ImpactAmount { get; set; }

        // Some items in game may need to stay persistant
        private bool _destroyable = false;
        public bool Destroyable { get { return _destroyable; } set { _destroyable = value; } }

        // If an item has lifePoints, and it drops below zero, dispose of game object
        private int _lifePoints = 100;
        public int LifePoints { get { return _lifePoints; }
                                set { if (_lifePoints <= 0) { Dispose(); } else { _lifePoints = value; } }  }
        
        

        
        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls
        
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    DialogModel.GameDialog = Name + " has been destroyed.";
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~ItemModel() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion




    }
}

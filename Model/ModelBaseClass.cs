using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Model
{
    public abstract class ModelBase : ViewModelBase, INotifyDataErrorInfo
    {
        public bool ValidationOn { get; set; }
        private readonly Dictionary<string, List<string>> errors = new Dictionary<string, List<string>>();

        public bool HasErrors => errors.Count() != 0;

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            if(string.IsNullOrEmpty(propertyName))
            {
                return errors.Values;
            }
            return errors.ContainsKey(propertyName) ? errors[propertyName] : null;
        }

        public void OnErrorsChanged([CallerMemberName] string propertyName=null)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        protected void ClearErrors(string propertyName)
        {
            errors.Remove(propertyName);
            OnErrorsChanged(propertyName);
        }

        protected void AddError(string error, string propertyName)
        {
            AddErrors(new List<string>() {error}, propertyName);
            OnErrorsChanged(propertyName);
        }

        private void AddErrors(IList<string> errors, string propertyName)
        {
            bool changed = false;
            if (!this.errors.ContainsKey(propertyName))
            {
                this.errors.Add(propertyName, new List<string>());
                changed = true;
            }
            errors.ToList().ForEach(x =>
            {
                if (this.errors[propertyName].Contains(x)) return;
                this.errors[propertyName].Add(x);
                changed = true;
            });

            if(changed)
            {
                OnErrorsChanged(propertyName);
            }
        }

    }
}

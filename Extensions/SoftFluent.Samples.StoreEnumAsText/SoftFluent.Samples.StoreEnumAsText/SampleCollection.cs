//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5477
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftFluent.Samples.StoreEnumAsText
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Monday, 07 July 2014 17:45.
    // Build:1.0.61214.0772
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0772")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DataObjectAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("Count={Count}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.CollectionTypeConverter))]
    public partial class SampleCollection : System.Collections.IList, System.Collections.ICollection, CodeFluent.Runtime.ICodeFluentSet, System.Collections.Generic.IList<SoftFluent.Samples.StoreEnumAsText.Sample>, System.Collections.Generic.ICollection<SoftFluent.Samples.StoreEnumAsText.Sample>, System.ComponentModel.IRaiseItemChangedEvents, System.ICloneable, System.ComponentModel.INotifyPropertyChanged, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.IBindingList, System.ComponentModel.ICancelAddNew
    {
        
        private bool _raisePropertyChangedEvents = true;
        
        private bool _raiseCollectionChangedEvents = true;
        
        [System.NonSerializedAttribute()]
        private System.Collections.Generic.List<SoftFluent.Samples.StoreEnumAsText.Sample> _baseList = new System.Collections.Generic.List<SoftFluent.Samples.StoreEnumAsText.Sample>();
        
        [System.NonSerializedAttribute()]
        private System.Collections.Generic.Dictionary<System.Guid, SoftFluent.Samples.StoreEnumAsText.Sample> _baseTable = new System.Collections.Generic.Dictionary<System.Guid, SoftFluent.Samples.StoreEnumAsText.Sample>();
        
        [System.NonSerializedAttribute()]
        private System.Collections.Hashtable _relations = new System.Collections.Hashtable();
        
        private int _maxCount = 2147483647;
        
        [System.NonSerializedAttribute()]
        private int _addNewPos = -1;
        
        [System.NonSerializedAttribute()]
        private CodeFluent.Runtime.Utilities.BindingListManager<SoftFluent.Samples.StoreEnumAsText.Sample> _blm1655277903;
        
        private bool _raiseListChangedEvents = true;
        
        private System.Collections.Specialized.NotifyCollectionChangedEventHandler _h2943838991;

        event System.Collections.Specialized.NotifyCollectionChangedEventHandler System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged{add{_h2943838991+=value;}remove{_h2943838991-=value;}}
        
        public SampleCollection()
        {
            this._blm1655277903 = new CodeFluent.Runtime.Utilities.BindingListManager<SoftFluent.Samples.StoreEnumAsText.Sample>(this);
        }
        
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool RaisePropertyChangedEvents
        {
            get
            {
                return this._raisePropertyChangedEvents;
            }
            set
            {
                this._raisePropertyChangedEvents = value;
            }
        }
        
        public virtual bool RaiseCollectionChangedEvents
        {
            get
            {
                return this._raiseCollectionChangedEvents;
            }
            set
            {
                this._raiseCollectionChangedEvents = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        protected System.Collections.Generic.List<SoftFluent.Samples.StoreEnumAsText.Sample> BaseList
        {
            get
            {
                return this._baseList;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        protected System.Collections.Generic.Dictionary<System.Guid, SoftFluent.Samples.StoreEnumAsText.Sample> BaseTable
        {
            get
            {
                return this._baseTable;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        System.Collections.IDictionary CodeFluent.Runtime.ICodeFluentSet.Relations
        {
            get
            {
                return this._relations;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false)]
        public virtual int MaxCount
        {
            get
            {
                return this._maxCount;
            }
            set
            {
                this._maxCount = value;
            }
        }
        
        public SoftFluent.Samples.StoreEnumAsText.Sample this[int index]
        {
            get
            {
                return ((SoftFluent.Samples.StoreEnumAsText.Sample)(this.BaseList[index]));
            }
            set
            {
                this.BaseList[index] = value;
            }
        }
        
        object System.Collections.IList.this[int index]
        {
            get
            {
                object i = this.BaseList[index];
                return i;
            }
            set
            {
                this.BaseList[index] = ((SoftFluent.Samples.StoreEnumAsText.Sample)(value));
            }
        }
        
        public SoftFluent.Samples.StoreEnumAsText.Sample this[System.Guid id]
        {
            get
            {
                if ((id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
                {
                    throw new System.ArgumentNullException("id");
                }
                SoftFluent.Samples.StoreEnumAsText.Sample i = this.TryGetValue(id);
                return i;
            }
            set
            {
                if ((id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
                {
                    throw new System.ArgumentNullException("id");
                }
                if ((value == null))
                {
                    SoftFluent.Samples.StoreEnumAsText.Sample sample = this.TryGetValue(id);
                    if ((sample != null))
                    {
                        this.Remove(sample);
                    }
                    return;
                }
                SoftFluent.Samples.StoreEnumAsText.Sample existing = this.TryGetValue(value.Id);
                if ((existing != null))
                {
                    this.Remove(existing);
                }
                this.Add(value);
            }
        }
        
        public virtual int Count
        {
            get
            {
                int v = ((System.Collections.IList)(this.BaseList)).Count;
                return v;
            }
        }
        
        public virtual bool IsSynchronized
        {
            get
            {
                bool v = ((System.Collections.IList)(this.BaseList)).IsSynchronized;
                return v;
            }
        }
        
        public virtual object SyncRoot
        {
            get
            {
                object v = ((System.Collections.IList)(this.BaseList)).SyncRoot;
                return v;
            }
        }
        
        public virtual bool IsFixedSize
        {
            get
            {
                bool v = ((System.Collections.IList)(this.BaseList)).IsFixedSize;
                return v;
            }
        }
        
        public virtual bool IsReadOnly
        {
            get
            {
                bool v = ((System.Collections.IList)(this.BaseList)).IsReadOnly;
                return v;
            }
        }
        
        public virtual bool RaiseListChangedEvents
        {
            get
            {
                return this._raiseListChangedEvents;
            }
            set
            {
                this._raiseListChangedEvents = value;
            }
        }
        
        bool System.ComponentModel.IBindingList.AllowEdit
        {
            get
            {
                return this._blm1655277903.AllowEdit;
            }
        }
        
        bool System.ComponentModel.IBindingList.AllowNew
        {
            get
            {
                return this._blm1655277903.AllowNew;
            }
        }
        
        bool System.ComponentModel.IBindingList.AllowRemove
        {
            get
            {
                return this._blm1655277903.AllowRemove;
            }
        }
        
        bool System.ComponentModel.IBindingList.IsSorted
        {
            get
            {
                return this._blm1655277903.IsSorted;
            }
        }
        
        System.ComponentModel.ListSortDirection System.ComponentModel.IBindingList.SortDirection
        {
            get
            {
                return this._blm1655277903.SortDirection;
            }
        }
        
        System.ComponentModel.PropertyDescriptor System.ComponentModel.IBindingList.SortProperty
        {
            get
            {
                return this._blm1655277903.SortProperty;
            }
        }
        
        bool System.ComponentModel.IBindingList.SupportsChangeNotification
        {
            get
            {
                return true;
            }
        }
        
        bool System.ComponentModel.IBindingList.SupportsSearching
        {
            get
            {
                return this._blm1655277903.SupportsSearching;
            }
        }
        
        bool System.ComponentModel.IBindingList.SupportsSorting
        {
            get
            {
                return this._blm1655277903.SupportsSorting;
            }
        }
        
        bool System.ComponentModel.IRaiseItemChangedEvents.RaisesItemChangedEvents
        {
            get
            {
                return this.RaiseListChangedEvents;
            }
        }
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.CollectionChangeEventHandler CollectionChanged;
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.AddingNewEventHandler AddingNew;
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.ListChangedEventHandler ListChanged;
        
        protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((this.RaisePropertyChangedEvents == false))
            {
                return;
            }
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, e);
            }
        }
        
        protected virtual void OnCollectionChanged(System.ComponentModel.CollectionChangeEventArgs e)
        {
            if ((this.RaiseCollectionChangedEvents == false))
            {
                return;
            }
            if ((this.CollectionChanged != null))
            {
                this.CollectionChanged(this, e);
            }
            CodeFluent.Runtime.ServiceModel.CollectionChangeNotifier.Notify(this, e, this._h2943838991);
            this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Count"));
            this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Item[]"));
        }
        
        protected virtual void Relate(SoftFluent.Samples.StoreEnumAsText.Sample item, CodeFluent.Runtime.CodeFluentRelationType relationType)
        {
            ((CodeFluent.Runtime.ICodeFluentSet)(this)).Relations[item] = relationType;
        }
        
        public int Add(SoftFluent.Samples.StoreEnumAsText.Sample sample)
        {
            int localAdd = this.BaseList.Count;
            this.BaseAdd(sample);
            return localAdd;
        }
        
        protected virtual int BaseAdd(SoftFluent.Samples.StoreEnumAsText.Sample sample)
        {
            if ((sample == null))
            {
                throw new System.ArgumentNullException("sample");
            }
            if ((sample.Id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                CodeFluent.Runtime.CodeFluentRuntimeException.Throw("invalidEntityKey", "Id", "sample", "SoftFluent.Samples.StoreEnumAsText.Sample");
            }
            try
            {
                this.BaseTable.Add(sample.Id, sample);
            }
            catch (System.ArgumentNullException ane)
            {
                throw new System.ArgumentNullException(SoftFluent.Samples.StoreEnumAsText.Resources.Manager.GetUserMessage(null, CodeFluent.Runtime.UserExceptionType.VoidCollectionKey, "SoftFluent.Samples.StoreEnumAsText.SampleCollection", sample.EntityKey), ane);
            }
            catch (System.ArgumentException ae)
            {
                throw new System.ArgumentException(SoftFluent.Samples.StoreEnumAsText.Resources.Manager.GetUserMessage(null, CodeFluent.Runtime.UserExceptionType.ItemAlreadyAdded, "SoftFluent.Samples.StoreEnumAsText.SampleCollection", sample.Id), ae);
            }
            sample.KeyChanged += new System.EventHandler<CodeFluent.Runtime.Utilities.KeyChangedEventArgs<System.Guid>>(this.OnItemKeyChanged);
            int localAdd = this.BaseList.Count;
            this.BaseList.Add(sample);
            this.OnCollectionChanged(new CodeFluent.Runtime.Utilities.IndexedCollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction.Add, sample, localAdd));
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.ItemAdded, localAdd));
            return localAdd;
        }
        
        int System.Collections.IList.Add(object value)
        {
            SoftFluent.Samples.StoreEnumAsText.Sample sample = null;
            try
            {
                sample = ((SoftFluent.Samples.StoreEnumAsText.Sample)(value));
            }
            catch (System.InvalidCastException )
            {
                string key = null;
                try
                {
                    key = ((string)(value));
                    int count = this.Count;
                    if ((this.AddByEntityKey(key) != null))
                    {
                        return 1;
                    }
                    return 0;
                }
                catch (System.InvalidCastException )
                {
                }
                if ((key == null))
                {
                    throw new System.ArgumentException("value");
                }
            }
            if ((sample == null))
            {
                throw new System.ArgumentException("value");
            }
            int localAdd = this.Add(sample);
            return localAdd;
        }
        
        void System.Collections.Generic.ICollection<SoftFluent.Samples.StoreEnumAsText.Sample>.Add(SoftFluent.Samples.StoreEnumAsText.Sample sample)
        {
            this.BaseAdd(sample);
        }
        
        public virtual SoftFluent.Samples.StoreEnumAsText.Sample AddByEntityKey(string key)
        {
            SoftFluent.Samples.StoreEnumAsText.Sample sample = SoftFluent.Samples.StoreEnumAsText.Sample.LoadByEntityKey(key);
            if (((sample != null) 
                        && (this.Contains(sample) == false)))
            {
                this.Add(sample);
            }
            return sample;
        }
        
        public void Sort()
        {
            this.Sort(null);
        }
        
        public virtual void Sort(System.Collections.Generic.IComparer<SoftFluent.Samples.StoreEnumAsText.Sample> comparer)
        {
            this.BaseList.Sort(comparer);
        }
        
        public void CopyTo(SoftFluent.Samples.StoreEnumAsText.Sample[] array, int index)
        {
            this.BaseCopyTo(array, index);
        }
        
        protected virtual void BaseCopyTo(SoftFluent.Samples.StoreEnumAsText.Sample[] array, int index)
        {
            this.BaseList.CopyTo(array, index);
        }
        
        void System.Collections.ICollection.CopyTo(System.Array array, int index)
        {
            CodeFluent.Runtime.Utilities.ConvertUtilities.CopyTo(this, array, index);
        }
        
        public bool Contains(SoftFluent.Samples.StoreEnumAsText.Sample sample)
        {
            bool localContains = this.BaseContains(sample);
            return localContains;
        }
        
        protected virtual bool BaseContains(SoftFluent.Samples.StoreEnumAsText.Sample sample)
        {
            if ((sample == null))
            {
                return false;
            }
            bool localContains = this.BaseTable.ContainsKey(sample.Id);
            return localContains;
        }
        
        bool System.Collections.IList.Contains(object value)
        {
            SoftFluent.Samples.StoreEnumAsText.Sample sample;
			sample = value as SoftFluent.Samples.StoreEnumAsText.Sample;
            return this.Contains(sample);
        }
        
        public int IndexOf(SoftFluent.Samples.StoreEnumAsText.Sample sample)
        {
            int localIndexOf = this.BaseIndexOf(sample);
            return localIndexOf;
        }
        
        protected virtual int BaseIndexOf(SoftFluent.Samples.StoreEnumAsText.Sample sample)
        {
            if ((sample == null))
            {
                return -1;
            }
            int localIndexOf = this.BaseList.IndexOf(sample);
            return localIndexOf;
        }
        
        int System.Collections.IList.IndexOf(object value)
        {
            SoftFluent.Samples.StoreEnumAsText.Sample sample;
			sample = value as SoftFluent.Samples.StoreEnumAsText.Sample;
            return this.IndexOf(sample);
        }
        
        public void Insert(int index, SoftFluent.Samples.StoreEnumAsText.Sample sample)
        {
            this.BaseInsert(index, sample);
        }
        
        protected virtual void BaseInsert(int index, SoftFluent.Samples.StoreEnumAsText.Sample sample)
        {
            if ((sample == null))
            {
                throw new System.ArgumentNullException("sample");
            }
            try
            {
                this.BaseTable.Add(sample.Id, sample);
            }
            catch (System.ArgumentNullException ane)
            {
                throw new System.ArgumentNullException(SoftFluent.Samples.StoreEnumAsText.Resources.Manager.GetUserMessage(null, CodeFluent.Runtime.UserExceptionType.VoidCollectionKey, "SoftFluent.Samples.StoreEnumAsText.SampleCollection", sample.EntityKey), ane);
            }
            catch (System.ArgumentException ae)
            {
                throw new System.ArgumentException(SoftFluent.Samples.StoreEnumAsText.Resources.Manager.GetUserMessage(null, CodeFluent.Runtime.UserExceptionType.ItemAlreadyAdded, "SoftFluent.Samples.StoreEnumAsText.SampleCollection", sample.Id), ae);
            }
            this.BaseList.Insert(index, sample);
            this.OnCollectionChanged(new CodeFluent.Runtime.Utilities.IndexedCollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction.Add, sample, index));
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.ItemAdded, index));
        }
        
        void System.Collections.IList.Insert(int index, object value)
        {
            SoftFluent.Samples.StoreEnumAsText.Sample sample;
			sample = value as SoftFluent.Samples.StoreEnumAsText.Sample;
            this.Insert(index, sample);
        }
        
        public virtual void Clear()
        {
            int index;
            int count = this.Count;
            for (index = 0; (index < count); index = (index + 1))
            {
                SoftFluent.Samples.StoreEnumAsText.Sample Sample = this[0];
                this.BaseRemove(Sample);
            }
            this.OnCollectionChanged(new CodeFluent.Runtime.Utilities.IndexedCollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction.Refresh, null));
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.Reset, -1));
        }
        
        public bool Remove(SoftFluent.Samples.StoreEnumAsText.Sample sample)
        {
            return this.BaseRemove(sample);
        }
        
        protected virtual bool BaseRemove(SoftFluent.Samples.StoreEnumAsText.Sample sample)
        {
            if ((sample == null))
            {
                throw new System.ArgumentNullException("sample");
            }
            int index = this.IndexOf(sample);
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(((System.ComponentModel.ListChangedType)(CodeFluent.Runtime.Utilities.SortableBindingList<SoftFluent.Samples.StoreEnumAsText.Sample>.ListChangedTypeDeleting)), index));
            bool ret;
            ret = this.BaseList.Remove(sample);
            sample.KeyChanged -= new System.EventHandler<CodeFluent.Runtime.Utilities.KeyChangedEventArgs<System.Guid>>(this.OnItemKeyChanged);
            ret = this.BaseTable.Remove(sample.Id);
            this.OnCollectionChanged(new CodeFluent.Runtime.Utilities.IndexedCollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction.Remove, sample, index));
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.ItemDeleted, index));
            return ret;
        }
        
        void System.Collections.IList.Remove(object value)
        {
            SoftFluent.Samples.StoreEnumAsText.Sample sample;
			sample = value as SoftFluent.Samples.StoreEnumAsText.Sample;
            this.Remove(sample);
        }
        
        public virtual void RemoveAt(int index)
        {
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(((System.ComponentModel.ListChangedType)(CodeFluent.Runtime.Utilities.SortableBindingList<SoftFluent.Samples.StoreEnumAsText.Sample>.ListChangedTypeDeleting)), index));
            SoftFluent.Samples.StoreEnumAsText.Sample sample = this.BaseList[index];
            if ((sample != null))
            {
                sample.KeyChanged -= new System.EventHandler<CodeFluent.Runtime.Utilities.KeyChangedEventArgs<System.Guid>>(this.OnItemKeyChanged);
                this.BaseTable.Remove(sample.Id);
            }
            this.BaseList.RemoveAt(index);
            this.OnCollectionChanged(new CodeFluent.Runtime.Utilities.IndexedCollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction.Remove, sample, index));
            this.OnListChanged(new System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.ItemDeleted, index));
        }
        
        public virtual System.Collections.Generic.IEnumerator<SoftFluent.Samples.StoreEnumAsText.Sample> GetEnumerator()
        {
            System.Collections.Generic.IEnumerator<SoftFluent.Samples.StoreEnumAsText.Sample> e = this.BaseList.GetEnumerator();
            return e;
        }
        
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.BaseList.GetEnumerator();
        }
        
        private SoftFluent.Samples.StoreEnumAsText.Sample TryGetValue(System.Guid key)
        {
            SoftFluent.Samples.StoreEnumAsText.Sample sample;
            if ((this.BaseTable.TryGetValue(key, out sample) == true))
            {
                return sample;
            }
            return null;
        }
        
        public virtual void SaveAll()
        {
            int index;
            for (index = (this.Count - 1); (index >= 0); index = (index - 1))
            {
                SoftFluent.Samples.StoreEnumAsText.Sample sample = this[index];
                sample.Save();
                if ((sample.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Deleted))
                {
                    this.Remove(sample);
                }
            }
        }
        
        private void LoadAll(int pageIndex, int pageSize, CodeFluent.Runtime.PageOptions pageOptions, System.Data.IDataReader reader)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            if ((pageIndex < 0))
            {
                pageIndex = 0;
            }
            if ((pageSize < 0))
            {
                if ((pageOptions != null))
                {
                    pageSize = pageOptions.DefaultPageSize;
                }
                else
                {
                    pageSize = int.MaxValue;
                }
            }
            this.BaseList.Clear();
            this.BaseTable.Clear();
            int count = 0;
            int readCount = 0;
            bool readerRead;
            for (readerRead = reader.Read(); ((readerRead == true) 
                        && ((count < this.MaxCount) 
                        && (count < pageSize))); readerRead = reader.Read())
            {
                readCount = (readCount + 1);
                if ((CodeFluent.Runtime.CodeFluentPersistence.CanAddEntity(pageIndex, pageSize, pageOptions, readCount) == true))
                {
                    SoftFluent.Samples.StoreEnumAsText.Sample sample = new SoftFluent.Samples.StoreEnumAsText.Sample();
                    ((CodeFluent.Runtime.ICodeFluentEntity)(sample)).ReadRecord(reader);
                    if ((this.BaseContains(sample) == false))
                    {
                        this.BaseAdd(sample);
                        count = (count + 1);
                    }
                    sample.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                }
            }
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static SoftFluent.Samples.StoreEnumAsText.SampleCollection PageLoadAll(int pageIndex, int pageSize, CodeFluent.Runtime.PageOptions pageOptions)
        {
            if ((pageIndex < 0))
            {
                pageIndex = 0;
            }
            if ((pageSize < 0))
            {
                if ((pageOptions != null))
                {
                    pageSize = pageOptions.DefaultPageSize;
                }
                else
                {
                    pageSize = int.MaxValue;
                }
            }
            SoftFluent.Samples.StoreEnumAsText.SampleCollection ret = new SoftFluent.Samples.StoreEnumAsText.SampleCollection();
            System.Data.IDataReader reader = null;
            try
            {
                reader = SoftFluent.Samples.StoreEnumAsText.SampleCollection.PageDataLoadAll(pageOptions);
                if ((reader == null))
                {
                    return ret;
                }
                ret.LoadAll(pageIndex, pageSize, pageOptions, reader);
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                CodeFluent.Runtime.CodeFluentPersistence.CompleteCommand(SoftFluent.Samples.StoreEnumAsText.Constants.SoftFluent_Samples_StoreEnumAsTextStoreName);
            }
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static SoftFluent.Samples.StoreEnumAsText.SampleCollection LoadAll()
        {
            SoftFluent.Samples.StoreEnumAsText.SampleCollection ret = SoftFluent.Samples.StoreEnumAsText.SampleCollection.PageLoadAll(int.MinValue, int.MaxValue, null);
            return ret;
        }
        
        public static System.Data.IDataReader PageDataLoadAll(CodeFluent.Runtime.PageOptions pageOptions)
        {
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(SoftFluent.Samples.StoreEnumAsText.Constants.SoftFluent_Samples_StoreEnumAsTextStoreName).Persistence;
            persistence.CreateStoredProcedureCommand(null, "Sample", "LoadAll");
            if ((pageOptions != null))
            {
                System.Collections.IEnumerator enumerator = pageOptions.OrderByArguments.GetEnumerator();
                bool b;
                int index = 0;
                for (b = enumerator.MoveNext(); b; b = enumerator.MoveNext())
                {
                    CodeFluent.Runtime.OrderByArgument argument = ((CodeFluent.Runtime.OrderByArgument)(enumerator.Current));
                    persistence.AddParameter(string.Format("@_orderBy{0}", index), argument.Name);
                    persistence.AddParameter(string.Format("@_orderByDirection{0}", index), ((int)(argument.Direction)));
                    index = (index + 1);
                }
            }
            System.Data.IDataReader reader = CodeFluentContext.Get(SoftFluent.Samples.StoreEnumAsText.Constants.SoftFluent_Samples_StoreEnumAsTextStoreName).Persistence.ExecuteReader();
            return reader;
        }
        
        public static System.Data.IDataReader DataLoadAll()
        {
            System.Data.IDataReader reader = SoftFluent.Samples.StoreEnumAsText.SampleCollection.PageDataLoadAll(null);
            return reader;
        }
        
        protected virtual void BaseTrace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            writer.Write("[");
            writer.Write(string.Concat("Count=", this.Count));
            writer.Write("]");
        }
        
        public string Trace()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            System.IO.StringWriter stringWriter = new System.IO.StringWriter(stringBuilder, System.Globalization.CultureInfo.CurrentCulture);
            System.CodeDom.Compiler.IndentedTextWriter writer = new System.CodeDom.Compiler.IndentedTextWriter(stringWriter);
            this.BaseTrace(writer);
            writer.Flush();
            ((System.IDisposable)(writer)).Dispose();
            ((System.IDisposable)(stringWriter)).Dispose();
            string sr = stringBuilder.ToString();
            return sr;
        }
        
        void CodeFluent.Runtime.ICodeFluentObject.Trace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            this.BaseTrace(writer);
        }
        
        public virtual void CopyTo(SoftFluent.Samples.StoreEnumAsText.SampleCollection collection, bool deep)
        {
            if ((typeof(System.ICloneable).IsAssignableFrom(typeof(SoftFluent.Samples.StoreEnumAsText.Sample)) == false))
            {
                deep = false;
            }
            System.Collections.Generic.IEnumerator<SoftFluent.Samples.StoreEnumAsText.Sample> enumerator = this.GetEnumerator();
            bool b;
            for (b = enumerator.MoveNext(); b; b = enumerator.MoveNext())
            {
                if ((deep == true))
                {
                    collection.Add(((SoftFluent.Samples.StoreEnumAsText.Sample)(((System.ICloneable)(enumerator.Current)).Clone())));
                }
                else
                {
                    collection.Add(enumerator.Current);
                }
            }
        }
        
        public virtual SoftFluent.Samples.StoreEnumAsText.SampleCollection Clone(bool deep)
        {
            SoftFluent.Samples.StoreEnumAsText.SampleCollection ret = new SoftFluent.Samples.StoreEnumAsText.SampleCollection();
            this.CopyTo(ret, deep);
            return ret;
        }
        
        object System.ICloneable.Clone()
        {
            return this.Clone(true);
        }
        
        public virtual void CancelNew(int index)
        {
            if (((this._addNewPos >= 0) 
                        && (this._addNewPos == index)))
            {
                this.RemoveAt(index);
                this._addNewPos = -1;
            }
        }
        
        public virtual void EndNew(int index)
        {
            if (((this._addNewPos >= 0) 
                        && (this._addNewPos == index)))
            {
                this._addNewPos = -1;
            }
        }
        
        void System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor property)
        {
            this._blm1655277903.AddIndex(property);
        }
        
        protected virtual void OnAddingNew(System.ComponentModel.AddingNewEventArgs e)
        {
            if ((this.AddingNew != null))
            {
                this.AddingNew(this, e);
            }
        }
        
        object System.ComponentModel.IBindingList.AddNew()
        {
            SoftFluent.Samples.StoreEnumAsText.Sample add = new SoftFluent.Samples.StoreEnumAsText.Sample();
            System.ComponentModel.AddingNewEventArgs e = new System.ComponentModel.AddingNewEventArgs(add);
            this.OnAddingNew(e);
            add = ((SoftFluent.Samples.StoreEnumAsText.Sample)(e.NewObject));
            if ((add == null))
            {
                add = new SoftFluent.Samples.StoreEnumAsText.Sample();
            }
            add.Id = System.Guid.NewGuid();
            this._addNewPos = this.Add(add);
            return add;
        }
        
        void System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction)
        {
            this._blm1655277903.ApplySort(property, direction);
        }
        
        int System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor property, object key)
        {
            return this._blm1655277903.Find(property, key);
        }
        
        void System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor property)
        {
            this._blm1655277903.RemoveIndex(property);
        }
        
        void System.ComponentModel.IBindingList.RemoveSort()
        {
            this._blm1655277903.RemoveSort();
        }
        
        protected virtual void OnListChanged(System.ComponentModel.ListChangedEventArgs e)
        {
            if ((e == null))
            {
                throw new System.ArgumentNullException("e");
            }
            if ((this.RaiseListChangedEvents == false))
            {
                return;
            }
            if ((((e.ListChangedType == System.ComponentModel.ListChangedType.Reset) 
                        == false) 
                        && (e.NewIndex < 0)))
            {
                return;
            }
            if ((this.ListChanged != null))
            {
                this.ListChanged(this, e);
            }
        }
        
        public void AddRange(System.Collections.Generic.IEnumerable<SoftFluent.Samples.StoreEnumAsText.Sample> collection)
        {
            CodeFluent.Runtime.Utilities.ConvertUtilities.AddRange(this, collection);
        }
        
        private void OnItemKeyChanged(object sender, CodeFluent.Runtime.Utilities.KeyChangedEventArgs<System.Guid> e)
        {
            if ((e == null))
            {
                throw new System.ArgumentNullException("e");
            }
            SoftFluent.Samples.StoreEnumAsText.Sample existing;
            if ((this.BaseTable.TryGetValue(e.OldKey, out existing) == false))
            {
                return;
            }
            if (((sender != null) 
                        && (typeof(CodeFluent.Runtime.Utilities.IKeyable<System.Guid>).IsAssignableFrom(sender.GetType()) == true)))
            {
                CodeFluent.Runtime.Utilities.IKeyable<System.Guid> item = ((CodeFluent.Runtime.Utilities.IKeyable<System.Guid>)(sender));
                try
                {
                    this.BaseTable.Add(item.Key, existing);
                }
                catch (System.ArgumentNullException ane)
                {
                    throw new System.ArgumentNullException(SoftFluent.Samples.StoreEnumAsText.Resources.Manager.GetUserMessage(null, CodeFluent.Runtime.UserExceptionType.VoidCollectionKey, "SoftFluent.Samples.StoreEnumAsText.SampleCollection", ((CodeFluent.Runtime.ICodeFluentEntity)(item)).EntityKey), ane);
                }
                catch (System.ArgumentException ae)
                {
                    throw new System.ArgumentException(SoftFluent.Samples.StoreEnumAsText.Resources.Manager.GetUserMessage(null, CodeFluent.Runtime.UserExceptionType.ItemAlreadyAdded, "SoftFluent.Samples.StoreEnumAsText.SampleCollection", item.Key), ae);
                }
                this.BaseTable.Remove(e.OldKey);
            }
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static SoftFluent.Samples.StoreEnumAsText.SampleCollection PageLoadAll(int pageIndex, int pageSize)
        {
            return SoftFluent.Samples.StoreEnumAsText.SampleCollection.PageLoadAll(pageIndex, pageSize, null);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public static bool Save(SoftFluent.Samples.StoreEnumAsText.Sample sample)
        {
            if ((sample == null))
            {
                return false;
            }
            bool ret = sample.Save();
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(SoftFluent.Samples.StoreEnumAsText.Sample sample)
        {
            bool ret = SoftFluent.Samples.StoreEnumAsText.Sample.Save(sample);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(SoftFluent.Samples.StoreEnumAsText.Sample sample)
        {
            if ((sample == null))
            {
                return false;
            }
            bool ret = sample.Delete();
            return ret;
        }
    }
}

using System.Configuration;

namespace ImageServer
{
    public class FileExtensionCollection : ConfigurationElementCollection
    {
        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.AddRemoveClearMap;
            }
        }

        public FileExtension this[int index]
        {
            get { return (FileExtension)BaseGet(index); }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        public new FileExtension this[string extension]
        {
            get { return (FileExtension)BaseGet(extension); }
            set
            {
                if (BaseGet(extension) != null)
                {
                    BaseRemove(extension);
                }
                BaseAdd(value);
            }
        }

        public void Add(FileExtension element)
        {
            BaseAdd(element);
        }

        public void Clear()
        {
            BaseClear();
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new FileExtension();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((FileExtension)element).Extension;
        }

        public void Remove(FileExtension element)
        {
            BaseRemove(element.Extension);
        }

        public void Remove(string name)
        {
            BaseRemove(name);
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }
    }
}

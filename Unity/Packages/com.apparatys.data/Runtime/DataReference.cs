using Newtonsoft.Json;
using System;

namespace Apparatys.Data
{
    [Serializable]
    public class DataReference<T> : IDataReference
        where T : IData
    {
        [JsonProperty]
        private DataId m_Id;

        [JsonIgnore]
        public override DataId Id
        {
            get { return m_Id; }
        }

        public DataReference()
        {
            // Serialization constructor
        }

        public DataReference(DataId id)
        {
            m_Id = new DataId(id);
        }
    }
}

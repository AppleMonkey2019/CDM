// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CommonDataModel.ObjectModel.Persistence.Syms.Models
{
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// DDL payload
    /// </summary>
    public partial class DDLPayload
    {
        /// <summary>
        /// Initializes a new instance of the DDLPayload class.
        /// </summary>
        public DDLPayload() { }

        /// <summary>
        /// Initializes a new instance of the DDLPayload class.
        /// </summary>
        /// <param name="actionType">Possible values include: 'CREATE',
        /// 'ALTER', 'DROP'</param>
        public DDLPayload(DDLType actionType, MDEntity oldEntity = default(MDEntity), MDEntity newEntity = default(MDEntity))
        {
            ActionType = actionType;
            OldEntity = oldEntity;
            NewEntity = newEntity;
        }

        /// <summary>
        /// Gets or sets possible values include: 'CREATE', 'ALTER', 'DROP'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ActionType")]
        public DDLType ActionType { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "OldEntity")]
        public MDEntity OldEntity { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "NewEntity")]
        public MDEntity NewEntity { get; set; }
    }
}
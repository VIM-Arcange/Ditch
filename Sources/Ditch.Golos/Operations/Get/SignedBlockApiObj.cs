﻿using Newtonsoft.Json;

namespace Ditch.Golos.Operations.Get
{
    /// <summary>
    /// signed_block_api_obj
    /// golos-0.16.3\libraries\protocol\include\steemit\protocol\block.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SignedBlockApiObj : SignedBlock
    {

        // bdType : block_id_type
        [JsonProperty("block_id")]
        public object BlockId { get; set; }

        // bdType : public_key_type
        [JsonProperty("signing_key")]
        public string SigningKey { get; set; }

        // bdType : vector<transaction_id_type>
        [JsonProperty("transaction_ids")]
        public object[] TransactionIds { get; set; }
    }
}
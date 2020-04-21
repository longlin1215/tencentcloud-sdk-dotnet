/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryDeclareData : AbstractModel
    {
        
        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 对接方汇出指令编号
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId{ get; set; }

        /// <summary>
        /// 申报流水号
        /// </summary>
        [JsonProperty("DeclareId")]
        public string DeclareId{ get; set; }

        /// <summary>
        /// 原申报流水号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginalDeclareId")]
        public string OriginalDeclareId{ get; set; }

        /// <summary>
        /// 付款人ID
        /// </summary>
        [JsonProperty("PayerId")]
        public string PayerId{ get; set; }

        /// <summary>
        /// 源币种
        /// </summary>
        [JsonProperty("SourceCurrency")]
        public string SourceCurrency{ get; set; }

        /// <summary>
        /// 源金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceAmount")]
        public string SourceAmount{ get; set; }

        /// <summary>
        /// 目的币种
        /// </summary>
        [JsonProperty("TargetCurrency")]
        public string TargetCurrency{ get; set; }

        /// <summary>
        /// 目的金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetAmount")]
        public string TargetAmount{ get; set; }

        /// <summary>
        /// 交易编码
        /// </summary>
        [JsonProperty("TradeCode")]
        public string TradeCode{ get; set; }

        /// <summary>
        /// 状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "TransactionId", this.TransactionId);
            this.SetParamSimple(map, prefix + "DeclareId", this.DeclareId);
            this.SetParamSimple(map, prefix + "OriginalDeclareId", this.OriginalDeclareId);
            this.SetParamSimple(map, prefix + "PayerId", this.PayerId);
            this.SetParamSimple(map, prefix + "SourceCurrency", this.SourceCurrency);
            this.SetParamSimple(map, prefix + "SourceAmount", this.SourceAmount);
            this.SetParamSimple(map, prefix + "TargetCurrency", this.TargetCurrency);
            this.SetParamSimple(map, prefix + "TargetAmount", this.TargetAmount);
            this.SetParamSimple(map, prefix + "TradeCode", this.TradeCode);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}


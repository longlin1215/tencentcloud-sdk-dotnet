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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PodSpec : AbstractModel
    {
        
        /// <summary>
        /// 外部资源提供者的标识符，例如"cls-a1cd23fa"。
        /// </summary>
        [JsonProperty("ResourceProviderIdentifier")]
        public string ResourceProviderIdentifier{ get; set; }

        /// <summary>
        /// 外部资源提供者类型，例如"tke",当前仅支持"tke"。
        /// </summary>
        [JsonProperty("ResourceProviderType")]
        public string ResourceProviderType{ get; set; }

        /// <summary>
        /// 资源的用途，即节点类型，当前仅支持"TASK"。
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// CPU核数。
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// 内存大小，单位为GB。
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// 资源对宿主机的挂载点，指定的挂载点对应了宿主机的路径，该挂载点在Pod中作为数据存储目录使用。
        /// </summary>
        [JsonProperty("DataVolumes")]
        public string[] DataVolumes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceProviderIdentifier", this.ResourceProviderIdentifier);
            this.SetParamSimple(map, prefix + "ResourceProviderType", this.ResourceProviderType);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamArraySimple(map, prefix + "DataVolumes.", this.DataVolumes);
        }
    }
}


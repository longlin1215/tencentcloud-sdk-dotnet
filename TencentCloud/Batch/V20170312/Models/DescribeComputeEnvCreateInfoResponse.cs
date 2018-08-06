/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeComputeEnvCreateInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 计算环境 ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 计算环境名称
        /// </summary>
        [JsonProperty("EnvName")]
        public string EnvName{ get; set; }

        /// <summary>
        /// 计算环境描述
        /// </summary>
        [JsonProperty("EnvDescription")]
        public string EnvDescription{ get; set; }

        /// <summary>
        /// 计算环境类型，仅支持“MANAGED”类型
        /// </summary>
        [JsonProperty("EnvType")]
        public string EnvType{ get; set; }

        /// <summary>
        /// 计算环境参数
        /// </summary>
        [JsonProperty("EnvData")]
        public EnvData EnvData{ get; set; }

        /// <summary>
        /// 数据盘挂载选项
        /// </summary>
        [JsonProperty("MountDataDisks")]
        public MountDataDisk[] MountDataDisks{ get; set; }

        /// <summary>
        /// 输入映射
        /// </summary>
        [JsonProperty("InputMappings")]
        public InputMapping[] InputMappings{ get; set; }

        /// <summary>
        /// 授权信息
        /// </summary>
        [JsonProperty("Authentications")]
        public Authentication[] Authentications{ get; set; }

        /// <summary>
        /// 通知信息
        /// </summary>
        [JsonProperty("Notifications")]
        public Notification[] Notifications{ get; set; }

        /// <summary>
        /// 计算节点期望个数
        /// </summary>
        [JsonProperty("DesiredComputeNodeCount")]
        public long? DesiredComputeNodeCount{ get; set; }

        /// <summary>
        /// 唯一请求ID，每次请求都会返回。定位问题时需要提供该次请求的RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "EnvName", this.EnvName);
            this.SetParamSimple(map, prefix + "EnvDescription", this.EnvDescription);
            this.SetParamSimple(map, prefix + "EnvType", this.EnvType);
            this.SetParamObj(map, prefix + "EnvData.", this.EnvData);
            this.SetParamArrayObj(map, prefix + "MountDataDisks.", this.MountDataDisks);
            this.SetParamArrayObj(map, prefix + "InputMappings.", this.InputMappings);
            this.SetParamArrayObj(map, prefix + "Authentications.", this.Authentications);
            this.SetParamArrayObj(map, prefix + "Notifications.", this.Notifications);
            this.SetParamSimple(map, prefix + "DesiredComputeNodeCount", this.DesiredComputeNodeCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

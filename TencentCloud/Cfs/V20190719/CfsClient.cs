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

namespace TencentCloud.Cfs.V20190719
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cfs.V20190719.Models;

   public class CfsClient : AbstractClient{

       private const string endpoint = "cfs.tencentcloudapi.com";
       private const string version = "2019-07-19";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public CfsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public CfsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 用于添加新文件系统
        /// </summary>
        /// <param name="req">参考<see cref="CreateCfsFileSystemRequest"/></param>
        /// <returns>参考<see cref="CreateCfsFileSystemResponse"/>实例</returns>
        public async Task<CreateCfsFileSystemResponse> CreateCfsFileSystem(CreateCfsFileSystemRequest req)
        {
             JsonResponseModel<CreateCfsFileSystemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCfsFileSystem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCfsFileSystemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateCfsPGroup）用于创建权限组
        /// </summary>
        /// <param name="req">参考<see cref="CreateCfsPGroupRequest"/></param>
        /// <returns>参考<see cref="CreateCfsPGroupResponse"/>实例</returns>
        public async Task<CreateCfsPGroupResponse> CreateCfsPGroup(CreateCfsPGroupRequest req)
        {
             JsonResponseModel<CreateCfsPGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCfsPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCfsPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateCfsRule）用于创建权限组规则。
        /// </summary>
        /// <param name="req">参考<see cref="CreateCfsRuleRequest"/></param>
        /// <returns>参考<see cref="CreateCfsRuleResponse"/>实例</returns>
        public async Task<CreateCfsRuleResponse> CreateCfsRule(CreateCfsRuleRequest req)
        {
             JsonResponseModel<CreateCfsRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCfsRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCfsRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除文件系统
        /// </summary>
        /// <param name="req">参考<see cref="DeleteCfsFileSystemRequest"/></param>
        /// <returns>参考<see cref="DeleteCfsFileSystemResponse"/>实例</returns>
        public async Task<DeleteCfsFileSystemResponse> DeleteCfsFileSystem(DeleteCfsFileSystemRequest req)
        {
             JsonResponseModel<DeleteCfsFileSystemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCfsFileSystem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCfsFileSystemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteCfsPGroup）用于删除权限组。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteCfsPGroupRequest"/></param>
        /// <returns>参考<see cref="DeleteCfsPGroupResponse"/>实例</returns>
        public async Task<DeleteCfsPGroupResponse> DeleteCfsPGroup(DeleteCfsPGroupRequest req)
        {
             JsonResponseModel<DeleteCfsPGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCfsPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCfsPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteCfsRule）用于删除权限组规则。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteCfsRuleRequest"/></param>
        /// <returns>参考<see cref="DeleteCfsRuleResponse"/>实例</returns>
        public async Task<DeleteCfsRuleResponse> DeleteCfsRule(DeleteCfsRuleRequest req)
        {
             JsonResponseModel<DeleteCfsRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCfsRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCfsRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteMountTarget）用于删除挂载点
        /// </summary>
        /// <param name="req">参考<see cref="DeleteMountTargetRequest"/></param>
        /// <returns>参考<see cref="DeleteMountTargetResponse"/>实例</returns>
        public async Task<DeleteMountTargetResponse> DeleteMountTarget(DeleteMountTargetRequest req)
        {
             JsonResponseModel<DeleteMountTargetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMountTarget");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMountTargetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAvailableZoneInfo）用于查询区域的可用情况。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAvailableZoneInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeAvailableZoneInfoResponse"/>实例</returns>
        public async Task<DescribeAvailableZoneInfoResponse> DescribeAvailableZoneInfo(DescribeAvailableZoneInfoRequest req)
        {
             JsonResponseModel<DescribeAvailableZoneInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAvailableZoneInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableZoneInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCfsFileSystems）用于查询文件系统
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCfsFileSystemsRequest"/></param>
        /// <returns>参考<see cref="DescribeCfsFileSystemsResponse"/>实例</returns>
        public async Task<DescribeCfsFileSystemsResponse> DescribeCfsFileSystems(DescribeCfsFileSystemsRequest req)
        {
             JsonResponseModel<DescribeCfsFileSystemsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCfsFileSystems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsFileSystemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCfsPGroups）用于查询权限组列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCfsPGroupsRequest"/></param>
        /// <returns>参考<see cref="DescribeCfsPGroupsResponse"/>实例</returns>
        public async Task<DescribeCfsPGroupsResponse> DescribeCfsPGroups(DescribeCfsPGroupsRequest req)
        {
             JsonResponseModel<DescribeCfsPGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCfsPGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsPGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCfsRules）用于查询权限组规则列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCfsRulesRequest"/></param>
        /// <returns>参考<see cref="DescribeCfsRulesResponse"/>实例</returns>
        public async Task<DescribeCfsRulesResponse> DescribeCfsRules(DescribeCfsRulesRequest req)
        {
             JsonResponseModel<DescribeCfsRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCfsRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCfsServiceStatus）用于查询用户使用CFS的服务状态。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCfsServiceStatusRequest"/></param>
        /// <returns>参考<see cref="DescribeCfsServiceStatusResponse"/>实例</returns>
        public async Task<DescribeCfsServiceStatusResponse> DescribeCfsServiceStatus(DescribeCfsServiceStatusRequest req)
        {
             JsonResponseModel<DescribeCfsServiceStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCfsServiceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsServiceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeMountTargets）用于查询文件系统挂载点信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMountTargetsRequest"/></param>
        /// <returns>参考<see cref="DescribeMountTargetsResponse"/>实例</returns>
        public async Task<DescribeMountTargetsResponse> DescribeMountTargets(DescribeMountTargetsRequest req)
        {
             JsonResponseModel<DescribeMountTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMountTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMountTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SignUpCfsService）用于开通CFS服务。
        /// </summary>
        /// <param name="req">参考<see cref="SignUpCfsServiceRequest"/></param>
        /// <returns>参考<see cref="SignUpCfsServiceResponse"/>实例</returns>
        public async Task<SignUpCfsServiceResponse> SignUpCfsService(SignUpCfsServiceRequest req)
        {
             JsonResponseModel<SignUpCfsServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SignUpCfsService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SignUpCfsServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateCfsFileSystemName）用于更新文件系统名
        /// </summary>
        /// <param name="req">参考<see cref="UpdateCfsFileSystemNameRequest"/></param>
        /// <returns>参考<see cref="UpdateCfsFileSystemNameResponse"/>实例</returns>
        public async Task<UpdateCfsFileSystemNameResponse> UpdateCfsFileSystemName(UpdateCfsFileSystemNameRequest req)
        {
             JsonResponseModel<UpdateCfsFileSystemNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCfsFileSystemName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsFileSystemNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateCfsFileSystemPGroup）用于更新文件系统所使用的权限组
        /// </summary>
        /// <param name="req">参考<see cref="UpdateCfsFileSystemPGroupRequest"/></param>
        /// <returns>参考<see cref="UpdateCfsFileSystemPGroupResponse"/>实例</returns>
        public async Task<UpdateCfsFileSystemPGroupResponse> UpdateCfsFileSystemPGroup(UpdateCfsFileSystemPGroupRequest req)
        {
             JsonResponseModel<UpdateCfsFileSystemPGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCfsFileSystemPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsFileSystemPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateCfsFileSystemSizeLimit）用于更新文件系统存储容量限制。
        /// </summary>
        /// <param name="req">参考<see cref="UpdateCfsFileSystemSizeLimitRequest"/></param>
        /// <returns>参考<see cref="UpdateCfsFileSystemSizeLimitResponse"/>实例</returns>
        public async Task<UpdateCfsFileSystemSizeLimitResponse> UpdateCfsFileSystemSizeLimit(UpdateCfsFileSystemSizeLimitRequest req)
        {
             JsonResponseModel<UpdateCfsFileSystemSizeLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCfsFileSystemSizeLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsFileSystemSizeLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateCfsPGroup）更新权限组信息。
        /// </summary>
        /// <param name="req">参考<see cref="UpdateCfsPGroupRequest"/></param>
        /// <returns>参考<see cref="UpdateCfsPGroupResponse"/>实例</returns>
        public async Task<UpdateCfsPGroupResponse> UpdateCfsPGroup(UpdateCfsPGroupRequest req)
        {
             JsonResponseModel<UpdateCfsPGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCfsPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateCfsRule）用于更新权限规则。
        /// </summary>
        /// <param name="req">参考<see cref="UpdateCfsRuleRequest"/></param>
        /// <returns>参考<see cref="UpdateCfsRuleResponse"/>实例</returns>
        public async Task<UpdateCfsRuleResponse> UpdateCfsRule(UpdateCfsRuleRequest req)
        {
             JsonResponseModel<UpdateCfsRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCfsRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

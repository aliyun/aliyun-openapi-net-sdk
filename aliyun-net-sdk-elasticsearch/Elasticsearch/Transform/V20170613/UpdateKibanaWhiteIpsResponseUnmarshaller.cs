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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class UpdateKibanaWhiteIpsResponseUnmarshaller
    {
        public static UpdateKibanaWhiteIpsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateKibanaWhiteIpsResponse updateKibanaWhiteIpsResponse = new UpdateKibanaWhiteIpsResponse();

			updateKibanaWhiteIpsResponse.HttpResponse = _ctx.HttpResponse;
			updateKibanaWhiteIpsResponse.RequestId = _ctx.StringValue("UpdateKibanaWhiteIps.RequestId");

			UpdateKibanaWhiteIpsResponse.UpdateKibanaWhiteIps_Result result = new UpdateKibanaWhiteIpsResponse.UpdateKibanaWhiteIps_Result();

			List<string> result_kibanaPrivateIPWhitelist = new List<string>();
			for (int i = 0; i < _ctx.Length("UpdateKibanaWhiteIps.Result.KibanaPrivateIPWhitelist.Length"); i++) {
				result_kibanaPrivateIPWhitelist.Add(_ctx.StringValue("UpdateKibanaWhiteIps.Result.KibanaPrivateIPWhitelist["+ i +"]"));
			}
			result.KibanaPrivateIPWhitelist = result_kibanaPrivateIPWhitelist;

			List<string> result_kibanaIPWhitelist = new List<string>();
			for (int i = 0; i < _ctx.Length("UpdateKibanaWhiteIps.Result.KibanaIPWhitelist.Length"); i++) {
				result_kibanaIPWhitelist.Add(_ctx.StringValue("UpdateKibanaWhiteIps.Result.KibanaIPWhitelist["+ i +"]"));
			}
			result.KibanaIPWhitelist = result_kibanaIPWhitelist;

			UpdateKibanaWhiteIpsResponse.UpdateKibanaWhiteIps_Result.UpdateKibanaWhiteIps_NetworkConfig networkConfig = new UpdateKibanaWhiteIpsResponse.UpdateKibanaWhiteIps_Result.UpdateKibanaWhiteIps_NetworkConfig();
			networkConfig.VpcId = _ctx.StringValue("UpdateKibanaWhiteIps.Result.NetworkConfig.vpcId");
			networkConfig.VswitchId = _ctx.StringValue("UpdateKibanaWhiteIps.Result.NetworkConfig.vswitchId");
			networkConfig.VsArea = _ctx.StringValue("UpdateKibanaWhiteIps.Result.NetworkConfig.vsArea");
			networkConfig.Type = _ctx.StringValue("UpdateKibanaWhiteIps.Result.NetworkConfig.type");

			List<UpdateKibanaWhiteIpsResponse.UpdateKibanaWhiteIps_Result.UpdateKibanaWhiteIps_NetworkConfig.UpdateKibanaWhiteIps_WhiteIpGroupListItem> networkConfig_whiteIpGroupList = new List<UpdateKibanaWhiteIpsResponse.UpdateKibanaWhiteIps_Result.UpdateKibanaWhiteIps_NetworkConfig.UpdateKibanaWhiteIps_WhiteIpGroupListItem>();
			for (int i = 0; i < _ctx.Length("UpdateKibanaWhiteIps.Result.NetworkConfig.WhiteIpGroupList.Length"); i++) {
				UpdateKibanaWhiteIpsResponse.UpdateKibanaWhiteIps_Result.UpdateKibanaWhiteIps_NetworkConfig.UpdateKibanaWhiteIps_WhiteIpGroupListItem whiteIpGroupListItem = new UpdateKibanaWhiteIpsResponse.UpdateKibanaWhiteIps_Result.UpdateKibanaWhiteIps_NetworkConfig.UpdateKibanaWhiteIps_WhiteIpGroupListItem();
				whiteIpGroupListItem.GroupName = _ctx.StringValue("UpdateKibanaWhiteIps.Result.NetworkConfig.WhiteIpGroupList["+ i +"].groupName");
				whiteIpGroupListItem.WhiteIpType = _ctx.StringValue("UpdateKibanaWhiteIps.Result.NetworkConfig.WhiteIpGroupList["+ i +"].whiteIpType");

				List<string> whiteIpGroupListItem_ips = new List<string>();
				for (int j = 0; j < _ctx.Length("UpdateKibanaWhiteIps.Result.NetworkConfig.WhiteIpGroupList["+ i +"].Ips.Length"); j++) {
					whiteIpGroupListItem_ips.Add(_ctx.StringValue("UpdateKibanaWhiteIps.Result.NetworkConfig.WhiteIpGroupList["+ i +"].Ips["+ j +"]"));
				}
				whiteIpGroupListItem.Ips = whiteIpGroupListItem_ips;

				networkConfig_whiteIpGroupList.Add(whiteIpGroupListItem);
			}
			networkConfig.WhiteIpGroupList = networkConfig_whiteIpGroupList;
			result.NetworkConfig = networkConfig;
			updateKibanaWhiteIpsResponse.Result = result;
        
			return updateKibanaWhiteIpsResponse;
        }
    }
}

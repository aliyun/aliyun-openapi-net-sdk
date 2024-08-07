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
    public class UpdateWhiteIpsResponseUnmarshaller
    {
        public static UpdateWhiteIpsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateWhiteIpsResponse updateWhiteIpsResponse = new UpdateWhiteIpsResponse();

			updateWhiteIpsResponse.HttpResponse = _ctx.HttpResponse;
			updateWhiteIpsResponse.RequestId = _ctx.StringValue("UpdateWhiteIps.RequestId");

			UpdateWhiteIpsResponse.UpdateWhiteIps_Result result = new UpdateWhiteIpsResponse.UpdateWhiteIps_Result();

			List<string> result_esIPWhitelist = new List<string>();
			for (int i = 0; i < _ctx.Length("UpdateWhiteIps.Result.EsIPWhitelist.Length"); i++) {
				result_esIPWhitelist.Add(_ctx.StringValue("UpdateWhiteIps.Result.EsIPWhitelist["+ i +"]"));
			}
			result.EsIPWhitelist = result_esIPWhitelist;

			UpdateWhiteIpsResponse.UpdateWhiteIps_Result.UpdateWhiteIps_NetworkConfig networkConfig = new UpdateWhiteIpsResponse.UpdateWhiteIps_Result.UpdateWhiteIps_NetworkConfig();

			List<UpdateWhiteIpsResponse.UpdateWhiteIps_Result.UpdateWhiteIps_NetworkConfig.UpdateWhiteIps_WhiteIpGroupListItem> networkConfig_whiteIpGroupList = new List<UpdateWhiteIpsResponse.UpdateWhiteIps_Result.UpdateWhiteIps_NetworkConfig.UpdateWhiteIps_WhiteIpGroupListItem>();
			for (int i = 0; i < _ctx.Length("UpdateWhiteIps.Result.NetworkConfig.WhiteIpGroupList.Length"); i++) {
				UpdateWhiteIpsResponse.UpdateWhiteIps_Result.UpdateWhiteIps_NetworkConfig.UpdateWhiteIps_WhiteIpGroupListItem whiteIpGroupListItem = new UpdateWhiteIpsResponse.UpdateWhiteIps_Result.UpdateWhiteIps_NetworkConfig.UpdateWhiteIps_WhiteIpGroupListItem();
				whiteIpGroupListItem.GroupName = _ctx.StringValue("UpdateWhiteIps.Result.NetworkConfig.WhiteIpGroupList["+ i +"].groupName");
				whiteIpGroupListItem.WhiteIpType = _ctx.StringValue("UpdateWhiteIps.Result.NetworkConfig.WhiteIpGroupList["+ i +"].whiteIpType");

				List<string> whiteIpGroupListItem_ips = new List<string>();
				for (int j = 0; j < _ctx.Length("UpdateWhiteIps.Result.NetworkConfig.WhiteIpGroupList["+ i +"].Ips.Length"); j++) {
					whiteIpGroupListItem_ips.Add(_ctx.StringValue("UpdateWhiteIps.Result.NetworkConfig.WhiteIpGroupList["+ i +"].Ips["+ j +"]"));
				}
				whiteIpGroupListItem.Ips = whiteIpGroupListItem_ips;

				networkConfig_whiteIpGroupList.Add(whiteIpGroupListItem);
			}
			networkConfig.WhiteIpGroupList = networkConfig_whiteIpGroupList;
			result.NetworkConfig = networkConfig;
			updateWhiteIpsResponse.Result = result;
        
			return updateWhiteIpsResponse;
        }
    }
}

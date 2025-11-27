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
    public class ListKibanaPvlNetworkResponseUnmarshaller
    {
        public static ListKibanaPvlNetworkResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListKibanaPvlNetworkResponse listKibanaPvlNetworkResponse = new ListKibanaPvlNetworkResponse();

			listKibanaPvlNetworkResponse.HttpResponse = _ctx.HttpResponse;
			listKibanaPvlNetworkResponse.RequestId = _ctx.StringValue("ListKibanaPvlNetwork.RequestId");

			List<ListKibanaPvlNetworkResponse.ListKibanaPvlNetwork_ResultItem> listKibanaPvlNetworkResponse_result = new List<ListKibanaPvlNetworkResponse.ListKibanaPvlNetwork_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListKibanaPvlNetwork.Result.Length"); i++) {
				ListKibanaPvlNetworkResponse.ListKibanaPvlNetwork_ResultItem resultItem = new ListKibanaPvlNetworkResponse.ListKibanaPvlNetwork_ResultItem();
				resultItem.EndpointName = _ctx.StringValue("ListKibanaPvlNetwork.Result["+ i +"].endpointName");
				resultItem.VpcId = _ctx.StringValue("ListKibanaPvlNetwork.Result["+ i +"].vpcId");
				resultItem.EndpointId = _ctx.StringValue("ListKibanaPvlNetwork.Result["+ i +"].endpointId");
				resultItem.EndpointStatus = _ctx.StringValue("ListKibanaPvlNetwork.Result["+ i +"].endpointStatus");
				resultItem.CreateTime = _ctx.StringValue("ListKibanaPvlNetwork.Result["+ i +"].createTime");
				resultItem.PvlId = _ctx.StringValue("ListKibanaPvlNetwork.Result["+ i +"].pvlId");

				List<string> resultItem_securityGroups = new List<string>();
				for (int j = 0; j < _ctx.Length("ListKibanaPvlNetwork.Result["+ i +"].SecurityGroups.Length"); j++) {
					resultItem_securityGroups.Add(_ctx.StringValue("ListKibanaPvlNetwork.Result["+ i +"].SecurityGroups["+ j +"]"));
				}
				resultItem.SecurityGroups = resultItem_securityGroups;

				List<ListKibanaPvlNetworkResponse.ListKibanaPvlNetwork_ResultItem.ListKibanaPvlNetwork_VSwitchIdsZoneItem> resultItem_vSwitchIdsZone = new List<ListKibanaPvlNetworkResponse.ListKibanaPvlNetwork_ResultItem.ListKibanaPvlNetwork_VSwitchIdsZoneItem>();
				for (int j = 0; j < _ctx.Length("ListKibanaPvlNetwork.Result["+ i +"].VSwitchIdsZone.Length"); j++) {
					ListKibanaPvlNetworkResponse.ListKibanaPvlNetwork_ResultItem.ListKibanaPvlNetwork_VSwitchIdsZoneItem vSwitchIdsZoneItem = new ListKibanaPvlNetworkResponse.ListKibanaPvlNetwork_ResultItem.ListKibanaPvlNetwork_VSwitchIdsZoneItem();
					vSwitchIdsZoneItem.ZoneId = _ctx.StringValue("ListKibanaPvlNetwork.Result["+ i +"].VSwitchIdsZone["+ j +"].zoneId");
					vSwitchIdsZoneItem.VswitchId = _ctx.StringValue("ListKibanaPvlNetwork.Result["+ i +"].VSwitchIdsZone["+ j +"].vswitchId");

					resultItem_vSwitchIdsZone.Add(vSwitchIdsZoneItem);
				}
				resultItem.VSwitchIdsZone = resultItem_vSwitchIdsZone;

				listKibanaPvlNetworkResponse_result.Add(resultItem);
			}
			listKibanaPvlNetworkResponse.Result = listKibanaPvlNetworkResponse_result;
        
			return listKibanaPvlNetworkResponse;
        }
    }
}

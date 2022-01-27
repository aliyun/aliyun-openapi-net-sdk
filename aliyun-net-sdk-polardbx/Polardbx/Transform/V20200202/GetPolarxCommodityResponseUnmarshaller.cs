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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class GetPolarxCommodityResponseUnmarshaller
    {
        public static GetPolarxCommodityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPolarxCommodityResponse getPolarxCommodityResponse = new GetPolarxCommodityResponse();

			getPolarxCommodityResponse.HttpResponse = _ctx.HttpResponse;
			getPolarxCommodityResponse.RequestId = _ctx.StringValue("GetPolarxCommodity.RequestId");

			GetPolarxCommodityResponse.GetPolarxCommodity_DBInstance dBInstance = new GetPolarxCommodityResponse.GetPolarxCommodity_DBInstance();
			dBInstance.Status = _ctx.StringValue("GetPolarxCommodity.DBInstance.Status");
			dBInstance.Description = _ctx.StringValue("GetPolarxCommodity.DBInstance.Description");
			dBInstance.ZoneId = _ctx.StringValue("GetPolarxCommodity.DBInstance.ZoneId");
			dBInstance.VPCId = _ctx.StringValue("GetPolarxCommodity.DBInstance.VPCId");
			dBInstance.CreateTime = _ctx.StringValue("GetPolarxCommodity.DBInstance.CreateTime");
			dBInstance.Expired = _ctx.StringValue("GetPolarxCommodity.DBInstance.Expired");
			dBInstance.PayType = _ctx.StringValue("GetPolarxCommodity.DBInstance.PayType");
			dBInstance.DBType = _ctx.StringValue("GetPolarxCommodity.DBInstance.DBType");
			dBInstance.LockMode = _ctx.StringValue("GetPolarxCommodity.DBInstance.LockMode");
			dBInstance.StorageUsed = _ctx.LongValue("GetPolarxCommodity.DBInstance.StorageUsed");
			dBInstance.DBVersion = _ctx.StringValue("GetPolarxCommodity.DBInstance.DBVersion");
			dBInstance.Network = _ctx.StringValue("GetPolarxCommodity.DBInstance.Network");
			dBInstance.RegionId = _ctx.StringValue("GetPolarxCommodity.DBInstance.RegionId");
			dBInstance.Engine = _ctx.StringValue("GetPolarxCommodity.DBInstance.Engine");
			dBInstance.Id = _ctx.StringValue("GetPolarxCommodity.DBInstance.Id");
			dBInstance.ConnectionString = _ctx.StringValue("GetPolarxCommodity.DBInstance.ConnectionString");
			dBInstance.Port = _ctx.StringValue("GetPolarxCommodity.DBInstance.Port");
			dBInstance.MinorVersion = _ctx.StringValue("GetPolarxCommodity.DBInstance.MinorVersion");
			dBInstance.LatestMinorVersion = _ctx.StringValue("GetPolarxCommodity.DBInstance.LatestMinorVersion");
			dBInstance.DBNodeCount = _ctx.IntegerValue("GetPolarxCommodity.DBInstance.DBNodeCount");
			dBInstance.DBInstanceType = _ctx.StringValue("GetPolarxCommodity.DBInstance.DBInstanceType");
			dBInstance.MaintainStartTime = _ctx.StringValue("GetPolarxCommodity.DBInstance.MaintainStartTime");
			dBInstance.MaintainEndTime = _ctx.StringValue("GetPolarxCommodity.DBInstance.MaintainEndTime");
			dBInstance.VSwitchId = _ctx.StringValue("GetPolarxCommodity.DBInstance.VSwitchId");
			dBInstance.CommodityCode = _ctx.StringValue("GetPolarxCommodity.DBInstance.CommodityCode");
			dBInstance.ExpireDate = _ctx.StringValue("GetPolarxCommodity.DBInstance.ExpireDate");
			dBInstance.Type = _ctx.StringValue("GetPolarxCommodity.DBInstance.Type");
			dBInstance.DBNodeClass = _ctx.StringValue("GetPolarxCommodity.DBInstance.DBNodeClass");

			List<string> dBInstance_readDBInstances = new List<string>();
			for (int i = 0; i < _ctx.Length("GetPolarxCommodity.DBInstance.ReadDBInstances.Length"); i++) {
				dBInstance_readDBInstances.Add(_ctx.StringValue("GetPolarxCommodity.DBInstance.ReadDBInstances["+ i +"]"));
			}
			dBInstance.ReadDBInstances = dBInstance_readDBInstances;

			List<GetPolarxCommodityResponse.GetPolarxCommodity_DBInstance.GetPolarxCommodity_DBNode> dBInstance_dBNodes = new List<GetPolarxCommodityResponse.GetPolarxCommodity_DBInstance.GetPolarxCommodity_DBNode>();
			for (int i = 0; i < _ctx.Length("GetPolarxCommodity.DBInstance.DBNodes.Length"); i++) {
				GetPolarxCommodityResponse.GetPolarxCommodity_DBInstance.GetPolarxCommodity_DBNode dBNode = new GetPolarxCommodityResponse.GetPolarxCommodity_DBInstance.GetPolarxCommodity_DBNode();
				dBNode.Id = _ctx.StringValue("GetPolarxCommodity.DBInstance.DBNodes["+ i +"].Id");
				dBNode.NodeClass = _ctx.StringValue("GetPolarxCommodity.DBInstance.DBNodes["+ i +"].NodeClass");
				dBNode.RegionId = _ctx.StringValue("GetPolarxCommodity.DBInstance.DBNodes["+ i +"].RegionId");
				dBNode.ZoneId = _ctx.StringValue("GetPolarxCommodity.DBInstance.DBNodes["+ i +"].ZoneId");

				dBInstance_dBNodes.Add(dBNode);
			}
			dBInstance.DBNodes = dBInstance_dBNodes;

			List<GetPolarxCommodityResponse.GetPolarxCommodity_DBInstance.GetPolarxCommodity_ConnAddr> dBInstance_connAddrs = new List<GetPolarxCommodityResponse.GetPolarxCommodity_DBInstance.GetPolarxCommodity_ConnAddr>();
			for (int i = 0; i < _ctx.Length("GetPolarxCommodity.DBInstance.ConnAddrs.Length"); i++) {
				GetPolarxCommodityResponse.GetPolarxCommodity_DBInstance.GetPolarxCommodity_ConnAddr connAddr = new GetPolarxCommodityResponse.GetPolarxCommodity_DBInstance.GetPolarxCommodity_ConnAddr();
				connAddr.ConnectionString = _ctx.StringValue("GetPolarxCommodity.DBInstance.ConnAddrs["+ i +"].ConnectionString");
				connAddr.Port = _ctx.StringValue("GetPolarxCommodity.DBInstance.ConnAddrs["+ i +"].Port");
				connAddr.Type = _ctx.StringValue("GetPolarxCommodity.DBInstance.ConnAddrs["+ i +"].Type");
				connAddr.VPCId = _ctx.StringValue("GetPolarxCommodity.DBInstance.ConnAddrs["+ i +"].VPCId");
				connAddr.VSwitchId = _ctx.StringValue("GetPolarxCommodity.DBInstance.ConnAddrs["+ i +"].VSwitchId");

				dBInstance_connAddrs.Add(connAddr);
			}
			dBInstance.ConnAddrs = dBInstance_connAddrs;
			getPolarxCommodityResponse.DBInstance = dBInstance;

			List<GetPolarxCommodityResponse.GetPolarxCommodity_Component> getPolarxCommodityResponse_componentList = new List<GetPolarxCommodityResponse.GetPolarxCommodity_Component>();
			for (int i = 0; i < _ctx.Length("GetPolarxCommodity.ComponentList.Length"); i++) {
				GetPolarxCommodityResponse.GetPolarxCommodity_Component component = new GetPolarxCommodityResponse.GetPolarxCommodity_Component();
				component.Name = _ctx.StringValue("GetPolarxCommodity.ComponentList["+ i +"].Name");
				component.Type = _ctx.StringValue("GetPolarxCommodity.ComponentList["+ i +"].Type");

				List<string> component_values = new List<string>();
				for (int j = 0; j < _ctx.Length("GetPolarxCommodity.ComponentList["+ i +"].Values.Length"); j++) {
					component_values.Add(_ctx.StringValue("GetPolarxCommodity.ComponentList["+ i +"].Values["+ j +"]"));
				}
				component.Values = component_values;

				getPolarxCommodityResponse_componentList.Add(component);
			}
			getPolarxCommodityResponse.ComponentList = getPolarxCommodityResponse_componentList;
        
			return getPolarxCommodityResponse;
        }
    }
}

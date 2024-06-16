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
    public class DescribeDBInstanceTopologyResponseUnmarshaller
    {
        public static DescribeDBInstanceTopologyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceTopologyResponse describeDBInstanceTopologyResponse = new DescribeDBInstanceTopologyResponse();

			describeDBInstanceTopologyResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceTopologyResponse.RequestId = _ctx.StringValue("DescribeDBInstanceTopology.RequestId");

			DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data data = new DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data();

			DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data.DescribeDBInstanceTopology_LogicInstanceTopology logicInstanceTopology = new DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data.DescribeDBInstanceTopology_LogicInstanceTopology();
			logicInstanceTopology.DBInstanceName = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.DBInstanceName");
			logicInstanceTopology.DBInstanceCreateTime = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.DBInstanceCreateTime");
			logicInstanceTopology.MaintainStartTime = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.MaintainStartTime");
			logicInstanceTopology.MaintainEndTime = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.MaintainEndTime");
			logicInstanceTopology.LockReason = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.LockReason");
			logicInstanceTopology.DBInstanceStatus = _ctx.IntegerValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.DBInstanceStatus");
			logicInstanceTopology.LockMode = _ctx.IntegerValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.LockMode");
			logicInstanceTopology.EngineVersion = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.EngineVersion");
			logicInstanceTopology.DBInstanceStorage = _ctx.IntegerValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.DBInstanceStorage");
			logicInstanceTopology.DBInstanceConnType = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.DBInstanceConnType");
			logicInstanceTopology.DBInstanceId = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.DBInstanceId");
			logicInstanceTopology.Engine = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Engine");
			logicInstanceTopology.DBInstanceDescription = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.DBInstanceDescription");
			logicInstanceTopology.DBInstanceStatusDescription = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.DBInstanceStatusDescription");

			List<DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data.DescribeDBInstanceTopology_LogicInstanceTopology.DescribeDBInstanceTopology_ItemsItem> logicInstanceTopology_items = new List<DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data.DescribeDBInstanceTopology_LogicInstanceTopology.DescribeDBInstanceTopology_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items.Length"); i++) {
				DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data.DescribeDBInstanceTopology_LogicInstanceTopology.DescribeDBInstanceTopology_ItemsItem itemsItem = new DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data.DescribeDBInstanceTopology_LogicInstanceTopology.DescribeDBInstanceTopology_ItemsItem();
				itemsItem.DBInstanceCreateTime = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].DBInstanceCreateTime");
				itemsItem.DBInstanceName = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].DBInstanceName");
				itemsItem.CharacterType = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].CharacterType");
				itemsItem.MaintainStartTime = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].MaintainStartTime");
				itemsItem.DiskSize = _ctx.LongValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].DiskSize");
				itemsItem.MaintainEndTime = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].MaintainEndTime");
				itemsItem.LockReason = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].LockReason");
				itemsItem.DBInstanceStatus = _ctx.IntegerValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].DBInstanceStatus");
				itemsItem.LockMode = _ctx.IntegerValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].LockMode");
				itemsItem.EngineVersion = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].EngineVersion");
				itemsItem.DBInstanceConnType = _ctx.IntegerValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].DBInstanceConnType");
				itemsItem.MaxConnections = _ctx.IntegerValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].MaxConnections");
				itemsItem.DBInstanceId = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].DBInstanceId");
				itemsItem.Engine = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].Engine");
				itemsItem.MaxIops = _ctx.IntegerValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].MaxIops");
				itemsItem.DBInstanceDescription = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].DBInstanceDescription");
				itemsItem.DBInstanceStatusDescription = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].DBInstanceStatusDescription");
				itemsItem.Region = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].Region");
				itemsItem.Azone = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].Azone");
				itemsItem.Role = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].Role");
				itemsItem.Activated = _ctx.BooleanValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].Activated");
				itemsItem.Status = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].Status");
				itemsItem.NodeClass = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].NodeClass");
				itemsItem.Version = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].Version");
				itemsItem.PhyInstanceName = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].PhyInstanceName");
				itemsItem.StorageUsed = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].StorageUsed");

				List<DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data.DescribeDBInstanceTopology_LogicInstanceTopology.DescribeDBInstanceTopology_ItemsItem.DescribeDBInstanceTopology_ConnectionIpItem> itemsItem_connectionIp = new List<DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data.DescribeDBInstanceTopology_LogicInstanceTopology.DescribeDBInstanceTopology_ItemsItem.DescribeDBInstanceTopology_ConnectionIpItem>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].ConnectionIp.Length"); j++) {
					DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data.DescribeDBInstanceTopology_LogicInstanceTopology.DescribeDBInstanceTopology_ItemsItem.DescribeDBInstanceTopology_ConnectionIpItem connectionIpItem = new DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data.DescribeDBInstanceTopology_LogicInstanceTopology.DescribeDBInstanceTopology_ItemsItem.DescribeDBInstanceTopology_ConnectionIpItem();
					connectionIpItem.Port = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].ConnectionIp["+ j +"].Port");
					connectionIpItem.DBInstanceNetType = _ctx.IntegerValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].ConnectionIp["+ j +"].DBInstanceNetType");
					connectionIpItem.ConnectionString = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].ConnectionIp["+ j +"].ConnectionString");

					itemsItem_connectionIp.Add(connectionIpItem);
				}
				itemsItem.ConnectionIp = itemsItem_connectionIp;

				List<DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data.DescribeDBInstanceTopology_LogicInstanceTopology.DescribeDBInstanceTopology_ItemsItem.DescribeDBInstanceTopology_AoneRoleMap> itemsItem_azoneRoleList = new List<DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data.DescribeDBInstanceTopology_LogicInstanceTopology.DescribeDBInstanceTopology_ItemsItem.DescribeDBInstanceTopology_AoneRoleMap>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].AzoneRoleList.Length"); j++) {
					DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data.DescribeDBInstanceTopology_LogicInstanceTopology.DescribeDBInstanceTopology_ItemsItem.DescribeDBInstanceTopology_AoneRoleMap aoneRoleMap = new DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data.DescribeDBInstanceTopology_LogicInstanceTopology.DescribeDBInstanceTopology_ItemsItem.DescribeDBInstanceTopology_AoneRoleMap();
					aoneRoleMap.Azone = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].AzoneRoleList["+ j +"].Azone");
					aoneRoleMap.Role = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.Items["+ i +"].AzoneRoleList["+ j +"].Role");

					itemsItem_azoneRoleList.Add(aoneRoleMap);
				}
				itemsItem.AzoneRoleList = itemsItem_azoneRoleList;

				logicInstanceTopology_items.Add(itemsItem);
			}
			logicInstanceTopology.Items = logicInstanceTopology_items;

			List<DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data.DescribeDBInstanceTopology_LogicInstanceTopology.DescribeDBInstanceTopology_HistoryItemsItem> logicInstanceTopology_historyItems = new List<DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data.DescribeDBInstanceTopology_LogicInstanceTopology.DescribeDBInstanceTopology_HistoryItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceTopology.Data.LogicInstanceTopology.HistoryItems.Length"); i++) {
				DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data.DescribeDBInstanceTopology_LogicInstanceTopology.DescribeDBInstanceTopology_HistoryItemsItem historyItemsItem = new DescribeDBInstanceTopologyResponse.DescribeDBInstanceTopology_Data.DescribeDBInstanceTopology_LogicInstanceTopology.DescribeDBInstanceTopology_HistoryItemsItem();
				historyItemsItem.CharacterType = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.HistoryItems["+ i +"].CharacterType");
				historyItemsItem.Role = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.HistoryItems["+ i +"].Role");
				historyItemsItem.DBInstanceName = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.HistoryItems["+ i +"].DBInstanceName");
				historyItemsItem.DBInstanceId = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.HistoryItems["+ i +"].DBInstanceId");
				historyItemsItem.Region = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.HistoryItems["+ i +"].Region");
				historyItemsItem.Azone = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.HistoryItems["+ i +"].Azone");
				historyItemsItem.Activated = _ctx.BooleanValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.HistoryItems["+ i +"].Activated");
				historyItemsItem.PhyInstanceName = _ctx.StringValue("DescribeDBInstanceTopology.Data.LogicInstanceTopology.HistoryItems["+ i +"].PhyInstanceName");

				logicInstanceTopology_historyItems.Add(historyItemsItem);
			}
			logicInstanceTopology.HistoryItems = logicInstanceTopology_historyItems;
			data.LogicInstanceTopology = logicInstanceTopology;
			describeDBInstanceTopologyResponse.Data = data;
        
			return describeDBInstanceTopologyResponse;
        }
    }
}

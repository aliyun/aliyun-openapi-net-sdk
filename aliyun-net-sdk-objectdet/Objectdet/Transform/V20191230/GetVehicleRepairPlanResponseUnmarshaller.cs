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
using Aliyun.Acs.objectdet.Model.V20191230;

namespace Aliyun.Acs.objectdet.Transform.V20191230
{
    public class GetVehicleRepairPlanResponseUnmarshaller
    {
        public static GetVehicleRepairPlanResponse Unmarshall(UnmarshallerContext context)
        {
			GetVehicleRepairPlanResponse getVehicleRepairPlanResponse = new GetVehicleRepairPlanResponse();

			getVehicleRepairPlanResponse.HttpResponse = context.HttpResponse;
			getVehicleRepairPlanResponse.RequestId = context.StringValue("GetVehicleRepairPlan.RequestId");
			getVehicleRepairPlanResponse.Code = context.StringValue("GetVehicleRepairPlan.Code");
			getVehicleRepairPlanResponse.ErrorMessage = context.StringValue("GetVehicleRepairPlan.ErrorMessage");
			getVehicleRepairPlanResponse.Success = context.BooleanValue("GetVehicleRepairPlan.Success");
			getVehicleRepairPlanResponse.HttpCode = context.IntegerValue("GetVehicleRepairPlan.HttpCode");

			GetVehicleRepairPlanResponse.GetVehicleRepairPlan_Data data = new GetVehicleRepairPlanResponse.GetVehicleRepairPlan_Data();
			data.FrameNo = context.StringValue("GetVehicleRepairPlan.Data.FrameNo");

			List<GetVehicleRepairPlanResponse.GetVehicleRepairPlan_Data.GetVehicleRepairPlan_RepairItems> data_repairParts = new List<GetVehicleRepairPlanResponse.GetVehicleRepairPlan_Data.GetVehicleRepairPlan_RepairItems>();
			for (int i = 0; i < context.Length("GetVehicleRepairPlan.Data.RepairParts.Length"); i++) {
				GetVehicleRepairPlanResponse.GetVehicleRepairPlan_Data.GetVehicleRepairPlan_RepairItems repairItems = new GetVehicleRepairPlanResponse.GetVehicleRepairPlan_Data.GetVehicleRepairPlan_RepairItems();
				repairItems.GarageType = context.StringValue("GetVehicleRepairPlan.Data.RepairParts["+ i +"].GarageType");
				repairItems.OeMatch = context.BooleanValue("GetVehicleRepairPlan.Data.RepairParts["+ i +"].OeMatch");
				repairItems.OutStandardPartsId = context.StringValue("GetVehicleRepairPlan.Data.RepairParts["+ i +"].OutStandardPartsId");
				repairItems.OutStandardPartsName = context.StringValue("GetVehicleRepairPlan.Data.RepairParts["+ i +"].OutStandardPartsName");
				repairItems.PartNameMatch = context.BooleanValue("GetVehicleRepairPlan.Data.RepairParts["+ i +"].PartNameMatch");
				repairItems.PartsStdCode = context.StringValue("GetVehicleRepairPlan.Data.RepairParts["+ i +"].PartsStdCode");
				repairItems.PartsStdName = context.StringValue("GetVehicleRepairPlan.Data.RepairParts["+ i +"].PartsStdName");
				repairItems.RelationType = context.StringValue("GetVehicleRepairPlan.Data.RepairParts["+ i +"].RelationType");
				repairItems.RepairFee = context.StringValue("GetVehicleRepairPlan.Data.RepairParts["+ i +"].RepairFee");
				repairItems.RepairType = context.StringValue("GetVehicleRepairPlan.Data.RepairParts["+ i +"].RepairType");
				repairItems.RepairTypeName = context.StringValue("GetVehicleRepairPlan.Data.RepairParts["+ i +"].RepairTypeName");

				data_repairParts.Add(repairItems);
			}
			data.RepairParts = data_repairParts;
			getVehicleRepairPlanResponse.Data = data;
        
			return getVehicleRepairPlanResponse;
        }
    }
}

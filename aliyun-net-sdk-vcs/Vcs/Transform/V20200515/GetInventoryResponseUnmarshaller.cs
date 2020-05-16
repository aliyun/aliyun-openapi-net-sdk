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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class GetInventoryResponseUnmarshaller
    {
        public static GetInventoryResponse Unmarshall(UnmarshallerContext context)
        {
			GetInventoryResponse getInventoryResponse = new GetInventoryResponse();

			getInventoryResponse.HttpResponse = context.HttpResponse;
			getInventoryResponse.Success = context.BooleanValue("GetInventory.Success");

			GetInventoryResponse.GetInventory_Data data = new GetInventoryResponse.GetInventory_Data();

			List<GetInventoryResponse.GetInventory_Data.GetInventory_ResultObjectItem> data_resultObject = new List<GetInventoryResponse.GetInventory_Data.GetInventory_ResultObjectItem>();
			for (int i = 0; i < context.Length("GetInventory.Data.ResultObject.Length"); i++) {
				GetInventoryResponse.GetInventory_Data.GetInventory_ResultObjectItem resultObjectItem = new GetInventoryResponse.GetInventory_Data.GetInventory_ResultObjectItem();
				resultObjectItem.BuyerId = context.StringValue("GetInventory.Data.ResultObject["+ i +"].BuyerId");
				resultObjectItem.CommodityCode = context.StringValue("GetInventory.Data.ResultObject["+ i +"].CommodityCode");
				resultObjectItem.CurrentInventory = context.StringValue("GetInventory.Data.ResultObject["+ i +"].CurrentInventory");
				resultObjectItem.ValidEndTime = context.StringValue("GetInventory.Data.ResultObject["+ i +"].ValidEndTime");
				resultObjectItem.ValidStartTime = context.StringValue("GetInventory.Data.ResultObject["+ i +"].ValidStartTime");
				resultObjectItem.InstanceId = context.StringValue("GetInventory.Data.ResultObject["+ i +"].InstanceId");
				resultObjectItem.InventoryId = context.StringValue("GetInventory.Data.ResultObject["+ i +"].InventoryId");

				data_resultObject.Add(resultObjectItem);
			}
			data.ResultObject = data_resultObject;
			getInventoryResponse.Data = data;
        
			return getInventoryResponse;
        }
    }
}

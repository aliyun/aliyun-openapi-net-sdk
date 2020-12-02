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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class DescribeSynchronizationObjectModifyStatusResponseUnmarshaller
    {
        public static DescribeSynchronizationObjectModifyStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSynchronizationObjectModifyStatusResponse describeSynchronizationObjectModifyStatusResponse = new DescribeSynchronizationObjectModifyStatusResponse();

			describeSynchronizationObjectModifyStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeSynchronizationObjectModifyStatusResponse.ErrCode = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.ErrCode");
			describeSynchronizationObjectModifyStatusResponse.ErrMessage = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.ErrMessage");
			describeSynchronizationObjectModifyStatusResponse.ErrorMessage = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.ErrorMessage");
			describeSynchronizationObjectModifyStatusResponse.RequestId = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.RequestId");
			describeSynchronizationObjectModifyStatusResponse.Status = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.Status");
			describeSynchronizationObjectModifyStatusResponse.Success = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.Success");

			DescribeSynchronizationObjectModifyStatusResponse.DescribeSynchronizationObjectModifyStatus_DataInitializationStatus dataInitializationStatus = new DescribeSynchronizationObjectModifyStatusResponse.DescribeSynchronizationObjectModifyStatus_DataInitializationStatus();
			dataInitializationStatus.ErrorMessage = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.DataInitializationStatus.ErrorMessage");
			dataInitializationStatus.Percent = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.DataInitializationStatus.Percent");
			dataInitializationStatus.Progress = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.DataInitializationStatus.Progress");
			dataInitializationStatus.Status = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.DataInitializationStatus.Status");
			describeSynchronizationObjectModifyStatusResponse.DataInitializationStatus = dataInitializationStatus;

			DescribeSynchronizationObjectModifyStatusResponse.DescribeSynchronizationObjectModifyStatus_DataSynchronizationStatus dataSynchronizationStatus = new DescribeSynchronizationObjectModifyStatusResponse.DescribeSynchronizationObjectModifyStatus_DataSynchronizationStatus();
			dataSynchronizationStatus.Delay = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.DataSynchronizationStatus.Delay");
			dataSynchronizationStatus.ErrorMessage = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.DataSynchronizationStatus.ErrorMessage");
			dataSynchronizationStatus.Percent = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.DataSynchronizationStatus.Percent");
			dataSynchronizationStatus.Status = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.DataSynchronizationStatus.Status");
			describeSynchronizationObjectModifyStatusResponse.DataSynchronizationStatus = dataSynchronizationStatus;

			DescribeSynchronizationObjectModifyStatusResponse.DescribeSynchronizationObjectModifyStatus_PrecheckStatus precheckStatus = new DescribeSynchronizationObjectModifyStatusResponse.DescribeSynchronizationObjectModifyStatus_PrecheckStatus();
			precheckStatus.Percent = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.PrecheckStatus.Percent");
			precheckStatus.Status = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.PrecheckStatus.Status");

			List<DescribeSynchronizationObjectModifyStatusResponse.DescribeSynchronizationObjectModifyStatus_PrecheckStatus.DescribeSynchronizationObjectModifyStatus_CheckItem> precheckStatus_detail = new List<DescribeSynchronizationObjectModifyStatusResponse.DescribeSynchronizationObjectModifyStatus_PrecheckStatus.DescribeSynchronizationObjectModifyStatus_CheckItem>();
			for (int i = 0; i < _ctx.Length("DescribeSynchronizationObjectModifyStatus.PrecheckStatus.Detail.Length"); i++) {
				DescribeSynchronizationObjectModifyStatusResponse.DescribeSynchronizationObjectModifyStatus_PrecheckStatus.DescribeSynchronizationObjectModifyStatus_CheckItem checkItem = new DescribeSynchronizationObjectModifyStatusResponse.DescribeSynchronizationObjectModifyStatus_PrecheckStatus.DescribeSynchronizationObjectModifyStatus_CheckItem();
				checkItem.CheckStatus = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.PrecheckStatus.Detail["+ i +"].CheckStatus");
				checkItem.ErrorMessage = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.PrecheckStatus.Detail["+ i +"].ErrorMessage");
				checkItem.ItemName = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.PrecheckStatus.Detail["+ i +"].ItemName");
				checkItem.RepairMethod = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.PrecheckStatus.Detail["+ i +"].RepairMethod");

				precheckStatus_detail.Add(checkItem);
			}
			precheckStatus.Detail = precheckStatus_detail;
			describeSynchronizationObjectModifyStatusResponse.PrecheckStatus = precheckStatus;

			DescribeSynchronizationObjectModifyStatusResponse.DescribeSynchronizationObjectModifyStatus_StructureInitializationStatus structureInitializationStatus = new DescribeSynchronizationObjectModifyStatusResponse.DescribeSynchronizationObjectModifyStatus_StructureInitializationStatus();
			structureInitializationStatus.ErrorMessage = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.StructureInitializationStatus.ErrorMessage");
			structureInitializationStatus.Percent = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.StructureInitializationStatus.Percent");
			structureInitializationStatus.Progress = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.StructureInitializationStatus.Progress");
			structureInitializationStatus.Status = _ctx.StringValue("DescribeSynchronizationObjectModifyStatus.StructureInitializationStatus.Status");
			describeSynchronizationObjectModifyStatusResponse.StructureInitializationStatus = structureInitializationStatus;
        
			return describeSynchronizationObjectModifyStatusResponse;
        }
    }
}

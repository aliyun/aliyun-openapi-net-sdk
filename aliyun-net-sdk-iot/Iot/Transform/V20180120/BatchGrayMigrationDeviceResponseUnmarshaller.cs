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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class BatchGrayMigrationDeviceResponseUnmarshaller
    {
        public static BatchGrayMigrationDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchGrayMigrationDeviceResponse batchGrayMigrationDeviceResponse = new BatchGrayMigrationDeviceResponse();

			batchGrayMigrationDeviceResponse.HttpResponse = _ctx.HttpResponse;
			batchGrayMigrationDeviceResponse.RequestId = _ctx.StringValue("BatchGrayMigrationDevice.RequestId");
			batchGrayMigrationDeviceResponse.Success = _ctx.BooleanValue("BatchGrayMigrationDevice.Success");
			batchGrayMigrationDeviceResponse.Code = _ctx.StringValue("BatchGrayMigrationDevice.Code");
			batchGrayMigrationDeviceResponse.ErrorMessage = _ctx.StringValue("BatchGrayMigrationDevice.ErrorMessage");

			BatchGrayMigrationDeviceResponse.BatchGrayMigrationDevice_Data data = new BatchGrayMigrationDeviceResponse.BatchGrayMigrationDevice_Data();

			List<BatchGrayMigrationDeviceResponse.BatchGrayMigrationDevice_Data.BatchGrayMigrationDevice_Item> data_details = new List<BatchGrayMigrationDeviceResponse.BatchGrayMigrationDevice_Data.BatchGrayMigrationDevice_Item>();
			for (int i = 0; i < _ctx.Length("BatchGrayMigrationDevice.Data.Details.Length"); i++) {
				BatchGrayMigrationDeviceResponse.BatchGrayMigrationDevice_Data.BatchGrayMigrationDevice_Item item = new BatchGrayMigrationDeviceResponse.BatchGrayMigrationDevice_Data.BatchGrayMigrationDevice_Item();
				item.DeviceName = _ctx.StringValue("BatchGrayMigrationDevice.Data.Details["+ i +"].DeviceName");
				item.Status = _ctx.StringValue("BatchGrayMigrationDevice.Data.Details["+ i +"].Status");
				item.Code = _ctx.IntegerValue("BatchGrayMigrationDevice.Data.Details["+ i +"].Code");
				item.Message = _ctx.StringValue("BatchGrayMigrationDevice.Data.Details["+ i +"].Message");

				data_details.Add(item);
			}
			data.Details = data_details;
			batchGrayMigrationDeviceResponse.Data = data;
        
			return batchGrayMigrationDeviceResponse;
        }
    }
}

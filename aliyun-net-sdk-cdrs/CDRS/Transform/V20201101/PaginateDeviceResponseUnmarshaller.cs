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
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class PaginateDeviceResponseUnmarshaller
    {
        public static PaginateDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PaginateDeviceResponse paginateDeviceResponse = new PaginateDeviceResponse();

			paginateDeviceResponse.HttpResponse = _ctx.HttpResponse;
			paginateDeviceResponse.RequestId = _ctx.StringValue("PaginateDevice.RequestId");
			paginateDeviceResponse.Message = _ctx.StringValue("PaginateDevice.Message");
			paginateDeviceResponse.Code = _ctx.StringValue("PaginateDevice.Code");

			PaginateDeviceResponse.PaginateDevice_Data data = new PaginateDeviceResponse.PaginateDevice_Data();
			data.PageNumber = _ctx.IntegerValue("PaginateDevice.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("PaginateDevice.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("PaginateDevice.Data.TotalCount");

			List<PaginateDeviceResponse.PaginateDevice_Data.PaginateDevice_RecordsItem> data_records = new List<PaginateDeviceResponse.PaginateDevice_Data.PaginateDevice_RecordsItem>();
			for (int i = 0; i < _ctx.Length("PaginateDevice.Data.Records.Length"); i++) {
				PaginateDeviceResponse.PaginateDevice_Data.PaginateDevice_RecordsItem recordsItem = new PaginateDeviceResponse.PaginateDevice_Data.PaginateDevice_RecordsItem();
				recordsItem.DeviceId = _ctx.StringValue("PaginateDevice.Data.Records["+ i +"].DeviceId");

				data_records.Add(recordsItem);
			}
			data.Records = data_records;
			paginateDeviceResponse.Data = data;
        
			return paginateDeviceResponse;
        }
    }
}

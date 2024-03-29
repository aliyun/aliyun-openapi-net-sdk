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
    public class BatchCheckDeviceNamesResponseUnmarshaller
    {
        public static BatchCheckDeviceNamesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchCheckDeviceNamesResponse batchCheckDeviceNamesResponse = new BatchCheckDeviceNamesResponse();

			batchCheckDeviceNamesResponse.HttpResponse = _ctx.HttpResponse;
			batchCheckDeviceNamesResponse.RequestId = _ctx.StringValue("BatchCheckDeviceNames.RequestId");
			batchCheckDeviceNamesResponse.Success = _ctx.BooleanValue("BatchCheckDeviceNames.Success");
			batchCheckDeviceNamesResponse.Code = _ctx.StringValue("BatchCheckDeviceNames.Code");
			batchCheckDeviceNamesResponse.ErrorMessage = _ctx.StringValue("BatchCheckDeviceNames.ErrorMessage");

			BatchCheckDeviceNamesResponse.BatchCheckDeviceNames_Data data = new BatchCheckDeviceNamesResponse.BatchCheckDeviceNames_Data();
			data.ApplyId = _ctx.LongValue("BatchCheckDeviceNames.Data.ApplyId");

			List<string> data_invalidDeviceNameList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchCheckDeviceNames.Data.InvalidDeviceNameList.Length"); i++) {
				data_invalidDeviceNameList.Add(_ctx.StringValue("BatchCheckDeviceNames.Data.InvalidDeviceNameList["+ i +"]"));
			}
			data.InvalidDeviceNameList = data_invalidDeviceNameList;

			List<string> data_invalidDeviceNicknameList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchCheckDeviceNames.Data.InvalidDeviceNicknameList.Length"); i++) {
				data_invalidDeviceNicknameList.Add(_ctx.StringValue("BatchCheckDeviceNames.Data.InvalidDeviceNicknameList["+ i +"]"));
			}
			data.InvalidDeviceNicknameList = data_invalidDeviceNicknameList;

			List<string> data_repeatedDeviceNameList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchCheckDeviceNames.Data.RepeatedDeviceNameList.Length"); i++) {
				data_repeatedDeviceNameList.Add(_ctx.StringValue("BatchCheckDeviceNames.Data.RepeatedDeviceNameList["+ i +"]"));
			}
			data.RepeatedDeviceNameList = data_repeatedDeviceNameList;

			List<BatchCheckDeviceNamesResponse.BatchCheckDeviceNames_Data.BatchCheckDeviceNames_InvalidDetailListItem> data_invalidDetailList = new List<BatchCheckDeviceNamesResponse.BatchCheckDeviceNames_Data.BatchCheckDeviceNames_InvalidDetailListItem>();
			for (int i = 0; i < _ctx.Length("BatchCheckDeviceNames.Data.InvalidDetailList.Length"); i++) {
				BatchCheckDeviceNamesResponse.BatchCheckDeviceNames_Data.BatchCheckDeviceNames_InvalidDetailListItem invalidDetailListItem = new BatchCheckDeviceNamesResponse.BatchCheckDeviceNames_Data.BatchCheckDeviceNames_InvalidDetailListItem();
				invalidDetailListItem.DeviceName = _ctx.StringValue("BatchCheckDeviceNames.Data.InvalidDetailList["+ i +"].DeviceName");
				invalidDetailListItem.NickName = _ctx.StringValue("BatchCheckDeviceNames.Data.InvalidDetailList["+ i +"].NickName");
				invalidDetailListItem.ErrorMsg = _ctx.StringValue("BatchCheckDeviceNames.Data.InvalidDetailList["+ i +"].ErrorMsg");

				data_invalidDetailList.Add(invalidDetailListItem);
			}
			data.InvalidDetailList = data_invalidDetailList;
			batchCheckDeviceNamesResponse.Data = data;
        
			return batchCheckDeviceNamesResponse;
        }
    }
}

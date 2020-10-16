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
        public static BatchCheckDeviceNamesResponse Unmarshall(UnmarshallerContext context)
        {
			BatchCheckDeviceNamesResponse batchCheckDeviceNamesResponse = new BatchCheckDeviceNamesResponse();

			batchCheckDeviceNamesResponse.HttpResponse = context.HttpResponse;
			batchCheckDeviceNamesResponse.RequestId = context.StringValue("BatchCheckDeviceNames.RequestId");
			batchCheckDeviceNamesResponse.Success = context.BooleanValue("BatchCheckDeviceNames.Success");
			batchCheckDeviceNamesResponse.Code = context.StringValue("BatchCheckDeviceNames.Code");
			batchCheckDeviceNamesResponse.ErrorMessage = context.StringValue("BatchCheckDeviceNames.ErrorMessage");

			BatchCheckDeviceNamesResponse.BatchCheckDeviceNames_Data data = new BatchCheckDeviceNamesResponse.BatchCheckDeviceNames_Data();
			data.ApplyId = context.LongValue("BatchCheckDeviceNames.Data.ApplyId");

			List<string> data_invalidDeviceNameList = new List<string>();
			for (int i = 0; i < context.Length("BatchCheckDeviceNames.Data.InvalidDeviceNameList.Length"); i++) {
				data_invalidDeviceNameList.Add(context.StringValue("BatchCheckDeviceNames.Data.InvalidDeviceNameList["+ i +"]"));
			}
			data.InvalidDeviceNameList = data_invalidDeviceNameList;

			List<string> data_invalidDeviceNicknameList = new List<string>();
			for (int i = 0; i < context.Length("BatchCheckDeviceNames.Data.InvalidDeviceNicknameList.Length"); i++) {
				data_invalidDeviceNicknameList.Add(context.StringValue("BatchCheckDeviceNames.Data.InvalidDeviceNicknameList["+ i +"]"));
			}
			data.InvalidDeviceNicknameList = data_invalidDeviceNicknameList;
			batchCheckDeviceNamesResponse.Data = data;
        
			return batchCheckDeviceNamesResponse;
        }
    }
}

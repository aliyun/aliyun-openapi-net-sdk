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
    public class BatchCheckImportDeviceResponseUnmarshaller
    {
        public static BatchCheckImportDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchCheckImportDeviceResponse batchCheckImportDeviceResponse = new BatchCheckImportDeviceResponse();

			batchCheckImportDeviceResponse.HttpResponse = _ctx.HttpResponse;
			batchCheckImportDeviceResponse.RequestId = _ctx.StringValue("BatchCheckImportDevice.RequestId");
			batchCheckImportDeviceResponse.Success = _ctx.BooleanValue("BatchCheckImportDevice.Success");
			batchCheckImportDeviceResponse.Code = _ctx.StringValue("BatchCheckImportDevice.Code");
			batchCheckImportDeviceResponse.ErrorMessage = _ctx.StringValue("BatchCheckImportDevice.ErrorMessage");

			BatchCheckImportDeviceResponse.BatchCheckImportDevice_Data data = new BatchCheckImportDeviceResponse.BatchCheckImportDevice_Data();

			List<string> data_invalidDeviceNameList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchCheckImportDevice.Data.InvalidDeviceNameList.Length"); i++) {
				data_invalidDeviceNameList.Add(_ctx.StringValue("BatchCheckImportDevice.Data.InvalidDeviceNameList["+ i +"]"));
			}
			data.InvalidDeviceNameList = data_invalidDeviceNameList;

			List<string> data_invalidDeviceSecretList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchCheckImportDevice.Data.InvalidDeviceSecretList.Length"); i++) {
				data_invalidDeviceSecretList.Add(_ctx.StringValue("BatchCheckImportDevice.Data.InvalidDeviceSecretList["+ i +"]"));
			}
			data.InvalidDeviceSecretList = data_invalidDeviceSecretList;

			List<string> data_invalidSnList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchCheckImportDevice.Data.InvalidSnList.Length"); i++) {
				data_invalidSnList.Add(_ctx.StringValue("BatchCheckImportDevice.Data.InvalidSnList["+ i +"]"));
			}
			data.InvalidSnList = data_invalidSnList;

			List<string> data_repeatedDeviceNameList = new List<string>();
			for (int i = 0; i < _ctx.Length("BatchCheckImportDevice.Data.RepeatedDeviceNameList.Length"); i++) {
				data_repeatedDeviceNameList.Add(_ctx.StringValue("BatchCheckImportDevice.Data.RepeatedDeviceNameList["+ i +"]"));
			}
			data.RepeatedDeviceNameList = data_repeatedDeviceNameList;
			batchCheckImportDeviceResponse.Data = data;
        
			return batchCheckImportDeviceResponse;
        }
    }
}

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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class TransferDeviceInstanceResponseUnmarshaller
    {
        public static TransferDeviceInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TransferDeviceInstanceResponse transferDeviceInstanceResponse = new TransferDeviceInstanceResponse();

			transferDeviceInstanceResponse.HttpResponse = _ctx.HttpResponse;
			transferDeviceInstanceResponse.Code = _ctx.StringValue("TransferDeviceInstance.Code");
			transferDeviceInstanceResponse.RequestId = _ctx.StringValue("TransferDeviceInstance.RequestId");
			transferDeviceInstanceResponse.ErrorMessage = _ctx.StringValue("TransferDeviceInstance.ErrorMessage");
			transferDeviceInstanceResponse.Success = _ctx.BooleanValue("TransferDeviceInstance.Success");

			TransferDeviceInstanceResponse.TransferDeviceInstance_Data data = new TransferDeviceInstanceResponse.TransferDeviceInstance_Data();

			List<TransferDeviceInstanceResponse.TransferDeviceInstance_Data.TransferDeviceInstance_SuccessListItem> data_successList = new List<TransferDeviceInstanceResponse.TransferDeviceInstance_Data.TransferDeviceInstance_SuccessListItem>();
			for (int i = 0; i < _ctx.Length("TransferDeviceInstance.Data.SuccessList.Length"); i++) {
				TransferDeviceInstanceResponse.TransferDeviceInstance_Data.TransferDeviceInstance_SuccessListItem successListItem = new TransferDeviceInstanceResponse.TransferDeviceInstance_Data.TransferDeviceInstance_SuccessListItem();
				successListItem.DeviceName = _ctx.StringValue("TransferDeviceInstance.Data.SuccessList["+ i +"].DeviceName");
				successListItem.Message = _ctx.StringValue("TransferDeviceInstance.Data.SuccessList["+ i +"].Message");

				data_successList.Add(successListItem);
			}
			data.SuccessList = data_successList;

			List<TransferDeviceInstanceResponse.TransferDeviceInstance_Data.TransferDeviceInstance_FailedListItem> data_failedList = new List<TransferDeviceInstanceResponse.TransferDeviceInstance_Data.TransferDeviceInstance_FailedListItem>();
			for (int i = 0; i < _ctx.Length("TransferDeviceInstance.Data.FailedList.Length"); i++) {
				TransferDeviceInstanceResponse.TransferDeviceInstance_Data.TransferDeviceInstance_FailedListItem failedListItem = new TransferDeviceInstanceResponse.TransferDeviceInstance_Data.TransferDeviceInstance_FailedListItem();
				failedListItem.DeviceName = _ctx.StringValue("TransferDeviceInstance.Data.FailedList["+ i +"].DeviceName");
				failedListItem.Message = _ctx.StringValue("TransferDeviceInstance.Data.FailedList["+ i +"].Message");

				data_failedList.Add(failedListItem);
			}
			data.FailedList = data_failedList;
			transferDeviceInstanceResponse.Data = data;
        
			return transferDeviceInstanceResponse;
        }
    }
}

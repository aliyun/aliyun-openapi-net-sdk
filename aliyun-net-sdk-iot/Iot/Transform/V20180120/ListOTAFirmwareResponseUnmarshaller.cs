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
    public class ListOTAFirmwareResponseUnmarshaller
    {
        public static ListOTAFirmwareResponse Unmarshall(UnmarshallerContext context)
        {
			ListOTAFirmwareResponse listOTAFirmwareResponse = new ListOTAFirmwareResponse();

			listOTAFirmwareResponse.HttpResponse = context.HttpResponse;
			listOTAFirmwareResponse.RequestId = context.StringValue("ListOTAFirmware.RequestId");
			listOTAFirmwareResponse.Success = context.BooleanValue("ListOTAFirmware.Success");
			listOTAFirmwareResponse.Code = context.StringValue("ListOTAFirmware.Code");
			listOTAFirmwareResponse.ErrorMessage = context.StringValue("ListOTAFirmware.ErrorMessage");
			listOTAFirmwareResponse.Total = context.IntegerValue("ListOTAFirmware.Total");
			listOTAFirmwareResponse.PageSize = context.IntegerValue("ListOTAFirmware.PageSize");
			listOTAFirmwareResponse.PageCount = context.IntegerValue("ListOTAFirmware.PageCount");
			listOTAFirmwareResponse.CurrentPage = context.IntegerValue("ListOTAFirmware.CurrentPage");

			List<ListOTAFirmwareResponse.ListOTAFirmware_SimpleFirmwareInfo> listOTAFirmwareResponse_firmwareInfo = new List<ListOTAFirmwareResponse.ListOTAFirmware_SimpleFirmwareInfo>();
			for (int i = 0; i < context.Length("ListOTAFirmware.FirmwareInfo.Length"); i++) {
				ListOTAFirmwareResponse.ListOTAFirmware_SimpleFirmwareInfo simpleFirmwareInfo = new ListOTAFirmwareResponse.ListOTAFirmware_SimpleFirmwareInfo();
				simpleFirmwareInfo.FirmwareName = context.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].FirmwareName");
				simpleFirmwareInfo.FirmwareId = context.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].FirmwareId");
				simpleFirmwareInfo.SrcVersion = context.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].SrcVersion");
				simpleFirmwareInfo.DestVersion = context.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].DestVersion");
				simpleFirmwareInfo.UtcCreate = context.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].UtcCreate");
				simpleFirmwareInfo.UtcModified = context.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].UtcModified");
				simpleFirmwareInfo.Status = context.IntegerValue("ListOTAFirmware.FirmwareInfo["+ i +"].Status");
				simpleFirmwareInfo.FirmwareDesc = context.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].FirmwareDesc");
				simpleFirmwareInfo.FirmwareSign = context.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].FirmwareSign");
				simpleFirmwareInfo.FirmwareSize = context.IntegerValue("ListOTAFirmware.FirmwareInfo["+ i +"].FirmwareSize");
				simpleFirmwareInfo.FirmwareUrl = context.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].FirmwareUrl");
				simpleFirmwareInfo.ProductKey = context.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].ProductKey");
				simpleFirmwareInfo.SignMethod = context.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].SignMethod");
				simpleFirmwareInfo.ProductName = context.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].ProductName");
				simpleFirmwareInfo.Type = context.IntegerValue("ListOTAFirmware.FirmwareInfo["+ i +"].Type");
				simpleFirmwareInfo.ModuleName = context.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].ModuleName");

				listOTAFirmwareResponse_firmwareInfo.Add(simpleFirmwareInfo);
			}
			listOTAFirmwareResponse.FirmwareInfo = listOTAFirmwareResponse_firmwareInfo;
        
			return listOTAFirmwareResponse;
        }
    }
}

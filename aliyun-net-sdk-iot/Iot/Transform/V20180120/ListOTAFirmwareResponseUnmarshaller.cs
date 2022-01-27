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
        public static ListOTAFirmwareResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOTAFirmwareResponse listOTAFirmwareResponse = new ListOTAFirmwareResponse();

			listOTAFirmwareResponse.HttpResponse = _ctx.HttpResponse;
			listOTAFirmwareResponse.RequestId = _ctx.StringValue("ListOTAFirmware.RequestId");
			listOTAFirmwareResponse.Success = _ctx.BooleanValue("ListOTAFirmware.Success");
			listOTAFirmwareResponse.Code = _ctx.StringValue("ListOTAFirmware.Code");
			listOTAFirmwareResponse.ErrorMessage = _ctx.StringValue("ListOTAFirmware.ErrorMessage");
			listOTAFirmwareResponse.Total = _ctx.IntegerValue("ListOTAFirmware.Total");
			listOTAFirmwareResponse.PageSize = _ctx.IntegerValue("ListOTAFirmware.PageSize");
			listOTAFirmwareResponse.PageCount = _ctx.IntegerValue("ListOTAFirmware.PageCount");
			listOTAFirmwareResponse.CurrentPage = _ctx.IntegerValue("ListOTAFirmware.CurrentPage");

			List<ListOTAFirmwareResponse.ListOTAFirmware_SimpleFirmwareInfo> listOTAFirmwareResponse_firmwareInfo = new List<ListOTAFirmwareResponse.ListOTAFirmware_SimpleFirmwareInfo>();
			for (int i = 0; i < _ctx.Length("ListOTAFirmware.FirmwareInfo.Length"); i++) {
				ListOTAFirmwareResponse.ListOTAFirmware_SimpleFirmwareInfo simpleFirmwareInfo = new ListOTAFirmwareResponse.ListOTAFirmware_SimpleFirmwareInfo();
				simpleFirmwareInfo.FirmwareName = _ctx.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].FirmwareName");
				simpleFirmwareInfo.FirmwareId = _ctx.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].FirmwareId");
				simpleFirmwareInfo.SrcVersion = _ctx.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].SrcVersion");
				simpleFirmwareInfo.DestVersion = _ctx.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].DestVersion");
				simpleFirmwareInfo.UtcCreate = _ctx.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].UtcCreate");
				simpleFirmwareInfo.UtcModified = _ctx.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].UtcModified");
				simpleFirmwareInfo.Status = _ctx.IntegerValue("ListOTAFirmware.FirmwareInfo["+ i +"].Status");
				simpleFirmwareInfo.FirmwareDesc = _ctx.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].FirmwareDesc");
				simpleFirmwareInfo.FirmwareSign = _ctx.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].FirmwareSign");
				simpleFirmwareInfo.FirmwareSize = _ctx.IntegerValue("ListOTAFirmware.FirmwareInfo["+ i +"].FirmwareSize");
				simpleFirmwareInfo.FirmwareUrl = _ctx.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].FirmwareUrl");
				simpleFirmwareInfo.ProductKey = _ctx.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].ProductKey");
				simpleFirmwareInfo.SignMethod = _ctx.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].SignMethod");
				simpleFirmwareInfo.ProductName = _ctx.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].ProductName");
				simpleFirmwareInfo.Type = _ctx.IntegerValue("ListOTAFirmware.FirmwareInfo["+ i +"].Type");
				simpleFirmwareInfo.ModuleName = _ctx.StringValue("ListOTAFirmware.FirmwareInfo["+ i +"].ModuleName");

				listOTAFirmwareResponse_firmwareInfo.Add(simpleFirmwareInfo);
			}
			listOTAFirmwareResponse.FirmwareInfo = listOTAFirmwareResponse_firmwareInfo;
        
			return listOTAFirmwareResponse;
        }
    }
}

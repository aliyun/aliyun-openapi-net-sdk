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
    public class QueryOTAFirmwareResponseUnmarshaller
    {
        public static QueryOTAFirmwareResponse Unmarshall(UnmarshallerContext context)
        {
			QueryOTAFirmwareResponse queryOTAFirmwareResponse = new QueryOTAFirmwareResponse();

			queryOTAFirmwareResponse.HttpResponse = context.HttpResponse;
			queryOTAFirmwareResponse.RequestId = context.StringValue("QueryOTAFirmware.RequestId");
			queryOTAFirmwareResponse.Success = context.BooleanValue("QueryOTAFirmware.Success");
			queryOTAFirmwareResponse.Code = context.StringValue("QueryOTAFirmware.Code");
			queryOTAFirmwareResponse.ErrorMessage = context.StringValue("QueryOTAFirmware.ErrorMessage");

			QueryOTAFirmwareResponse.QueryOTAFirmware_FirmwareInfo firmwareInfo = new QueryOTAFirmwareResponse.QueryOTAFirmware_FirmwareInfo();
			firmwareInfo.FirmwareName = context.StringValue("QueryOTAFirmware.FirmwareInfo.FirmwareName");
			firmwareInfo.FirmwareId = context.StringValue("QueryOTAFirmware.FirmwareInfo.FirmwareId");
			firmwareInfo.SrcVersion = context.StringValue("QueryOTAFirmware.FirmwareInfo.SrcVersion");
			firmwareInfo.DestVersion = context.StringValue("QueryOTAFirmware.FirmwareInfo.DestVersion");
			firmwareInfo.UtcCreate = context.StringValue("QueryOTAFirmware.FirmwareInfo.UtcCreate");
			firmwareInfo.UtcModified = context.StringValue("QueryOTAFirmware.FirmwareInfo.UtcModified");
			firmwareInfo.Status = context.IntegerValue("QueryOTAFirmware.FirmwareInfo.Status");
			firmwareInfo.FirmwareDesc = context.StringValue("QueryOTAFirmware.FirmwareInfo.FirmwareDesc");
			firmwareInfo.FirmwareSign = context.StringValue("QueryOTAFirmware.FirmwareInfo.FirmwareSign");
			firmwareInfo.FirmwareSize = context.IntegerValue("QueryOTAFirmware.FirmwareInfo.FirmwareSize");
			firmwareInfo.FirmwareUrl = context.StringValue("QueryOTAFirmware.FirmwareInfo.FirmwareUrl");
			firmwareInfo.ProductKey = context.StringValue("QueryOTAFirmware.FirmwareInfo.ProductKey");
			firmwareInfo.SignMethod = context.StringValue("QueryOTAFirmware.FirmwareInfo.SignMethod");
			firmwareInfo.ProductName = context.StringValue("QueryOTAFirmware.FirmwareInfo.ProductName");
			firmwareInfo.Type = context.IntegerValue("QueryOTAFirmware.FirmwareInfo.Type");
			firmwareInfo.VerifyProgress = context.IntegerValue("QueryOTAFirmware.FirmwareInfo.VerifyProgress");
			firmwareInfo.ModuleName = context.StringValue("QueryOTAFirmware.FirmwareInfo.ModuleName");
			queryOTAFirmwareResponse.FirmwareInfo = firmwareInfo;
        
			return queryOTAFirmwareResponse;
        }
    }
}

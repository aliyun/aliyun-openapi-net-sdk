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
        public static QueryOTAFirmwareResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryOTAFirmwareResponse queryOTAFirmwareResponse = new QueryOTAFirmwareResponse();

			queryOTAFirmwareResponse.HttpResponse = _ctx.HttpResponse;
			queryOTAFirmwareResponse.RequestId = _ctx.StringValue("QueryOTAFirmware.RequestId");
			queryOTAFirmwareResponse.Success = _ctx.BooleanValue("QueryOTAFirmware.Success");
			queryOTAFirmwareResponse.Code = _ctx.StringValue("QueryOTAFirmware.Code");
			queryOTAFirmwareResponse.ErrorMessage = _ctx.StringValue("QueryOTAFirmware.ErrorMessage");

			QueryOTAFirmwareResponse.QueryOTAFirmware_FirmwareInfo firmwareInfo = new QueryOTAFirmwareResponse.QueryOTAFirmware_FirmwareInfo();
			firmwareInfo.FirmwareName = _ctx.StringValue("QueryOTAFirmware.FirmwareInfo.FirmwareName");
			firmwareInfo.FirmwareId = _ctx.StringValue("QueryOTAFirmware.FirmwareInfo.FirmwareId");
			firmwareInfo.SrcVersion = _ctx.StringValue("QueryOTAFirmware.FirmwareInfo.SrcVersion");
			firmwareInfo.DestVersion = _ctx.StringValue("QueryOTAFirmware.FirmwareInfo.DestVersion");
			firmwareInfo.UtcCreate = _ctx.StringValue("QueryOTAFirmware.FirmwareInfo.UtcCreate");
			firmwareInfo.UtcModified = _ctx.StringValue("QueryOTAFirmware.FirmwareInfo.UtcModified");
			firmwareInfo.Status = _ctx.IntegerValue("QueryOTAFirmware.FirmwareInfo.Status");
			firmwareInfo.FirmwareDesc = _ctx.StringValue("QueryOTAFirmware.FirmwareInfo.FirmwareDesc");
			firmwareInfo.FirmwareSign = _ctx.StringValue("QueryOTAFirmware.FirmwareInfo.FirmwareSign");
			firmwareInfo.FirmwareSize = _ctx.IntegerValue("QueryOTAFirmware.FirmwareInfo.FirmwareSize");
			firmwareInfo.FirmwareUrl = _ctx.StringValue("QueryOTAFirmware.FirmwareInfo.FirmwareUrl");
			firmwareInfo.ProductKey = _ctx.StringValue("QueryOTAFirmware.FirmwareInfo.ProductKey");
			firmwareInfo.SignMethod = _ctx.StringValue("QueryOTAFirmware.FirmwareInfo.SignMethod");
			firmwareInfo.ProductName = _ctx.StringValue("QueryOTAFirmware.FirmwareInfo.ProductName");
			firmwareInfo.Type = _ctx.IntegerValue("QueryOTAFirmware.FirmwareInfo.Type");
			firmwareInfo.VerifyProgress = _ctx.IntegerValue("QueryOTAFirmware.FirmwareInfo.VerifyProgress");
			firmwareInfo.ModuleName = _ctx.StringValue("QueryOTAFirmware.FirmwareInfo.ModuleName");
			firmwareInfo.Udi = _ctx.StringValue("QueryOTAFirmware.FirmwareInfo.Udi");

			List<QueryOTAFirmwareResponse.QueryOTAFirmware_FirmwareInfo.QueryOTAFirmware_OtaPackageFileDTO> firmwareInfo_multiFiles = new List<QueryOTAFirmwareResponse.QueryOTAFirmware_FirmwareInfo.QueryOTAFirmware_OtaPackageFileDTO>();
			for (int i = 0; i < _ctx.Length("QueryOTAFirmware.FirmwareInfo.MultiFiles.Length"); i++) {
				QueryOTAFirmwareResponse.QueryOTAFirmware_FirmwareInfo.QueryOTAFirmware_OtaPackageFileDTO otaPackageFileDTO = new QueryOTAFirmwareResponse.QueryOTAFirmware_FirmwareInfo.QueryOTAFirmware_OtaPackageFileDTO();
				otaPackageFileDTO.Name = _ctx.StringValue("QueryOTAFirmware.FirmwareInfo.MultiFiles["+ i +"].Name");
				otaPackageFileDTO.Size = _ctx.IntegerValue("QueryOTAFirmware.FirmwareInfo.MultiFiles["+ i +"].Size");
				otaPackageFileDTO.Url = _ctx.StringValue("QueryOTAFirmware.FirmwareInfo.MultiFiles["+ i +"].Url");
				otaPackageFileDTO.SignValue = _ctx.StringValue("QueryOTAFirmware.FirmwareInfo.MultiFiles["+ i +"].SignValue");
				otaPackageFileDTO.FileMd5 = _ctx.StringValue("QueryOTAFirmware.FirmwareInfo.MultiFiles["+ i +"].FileMd5");

				firmwareInfo_multiFiles.Add(otaPackageFileDTO);
			}
			firmwareInfo.MultiFiles = firmwareInfo_multiFiles;
			queryOTAFirmwareResponse.FirmwareInfo = firmwareInfo;
        
			return queryOTAFirmwareResponse;
        }
    }
}

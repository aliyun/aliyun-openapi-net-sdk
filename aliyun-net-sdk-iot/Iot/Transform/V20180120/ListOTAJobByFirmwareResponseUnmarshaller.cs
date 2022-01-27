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
    public class ListOTAJobByFirmwareResponseUnmarshaller
    {
        public static ListOTAJobByFirmwareResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOTAJobByFirmwareResponse listOTAJobByFirmwareResponse = new ListOTAJobByFirmwareResponse();

			listOTAJobByFirmwareResponse.HttpResponse = _ctx.HttpResponse;
			listOTAJobByFirmwareResponse.RequestId = _ctx.StringValue("ListOTAJobByFirmware.RequestId");
			listOTAJobByFirmwareResponse.Success = _ctx.BooleanValue("ListOTAJobByFirmware.Success");
			listOTAJobByFirmwareResponse.Code = _ctx.StringValue("ListOTAJobByFirmware.Code");
			listOTAJobByFirmwareResponse.ErrorMessage = _ctx.StringValue("ListOTAJobByFirmware.ErrorMessage");
			listOTAJobByFirmwareResponse.Total = _ctx.IntegerValue("ListOTAJobByFirmware.Total");
			listOTAJobByFirmwareResponse.PageSize = _ctx.IntegerValue("ListOTAJobByFirmware.PageSize");
			listOTAJobByFirmwareResponse.PageCount = _ctx.IntegerValue("ListOTAJobByFirmware.PageCount");
			listOTAJobByFirmwareResponse.CurrentPage = _ctx.IntegerValue("ListOTAJobByFirmware.CurrentPage");

			List<ListOTAJobByFirmwareResponse.ListOTAJobByFirmware_SimpleOTAJobInfo> listOTAJobByFirmwareResponse_data = new List<ListOTAJobByFirmwareResponse.ListOTAJobByFirmware_SimpleOTAJobInfo>();
			for (int i = 0; i < _ctx.Length("ListOTAJobByFirmware.Data.Length"); i++) {
				ListOTAJobByFirmwareResponse.ListOTAJobByFirmware_SimpleOTAJobInfo simpleOTAJobInfo = new ListOTAJobByFirmwareResponse.ListOTAJobByFirmware_SimpleOTAJobInfo();
				simpleOTAJobInfo.JobId = _ctx.StringValue("ListOTAJobByFirmware.Data["+ i +"].JobId");
				simpleOTAJobInfo.UtcCreate = _ctx.StringValue("ListOTAJobByFirmware.Data["+ i +"].UtcCreate");
				simpleOTAJobInfo.UtcModified = _ctx.StringValue("ListOTAJobByFirmware.Data["+ i +"].UtcModified");
				simpleOTAJobInfo.ProductKey = _ctx.StringValue("ListOTAJobByFirmware.Data["+ i +"].ProductKey");
				simpleOTAJobInfo.FirmwareId = _ctx.StringValue("ListOTAJobByFirmware.Data["+ i +"].FirmwareId");
				simpleOTAJobInfo.UtcStartTime = _ctx.StringValue("ListOTAJobByFirmware.Data["+ i +"].UtcStartTime");
				simpleOTAJobInfo.UtcEndTime = _ctx.StringValue("ListOTAJobByFirmware.Data["+ i +"].UtcEndTime");
				simpleOTAJobInfo.JobStatus = _ctx.StringValue("ListOTAJobByFirmware.Data["+ i +"].JobStatus");
				simpleOTAJobInfo.JobType = _ctx.StringValue("ListOTAJobByFirmware.Data["+ i +"].JobType");
				simpleOTAJobInfo.TargetSelection = _ctx.StringValue("ListOTAJobByFirmware.Data["+ i +"].TargetSelection");
				simpleOTAJobInfo.SelectionType = _ctx.StringValue("ListOTAJobByFirmware.Data["+ i +"].SelectionType");

				List<ListOTAJobByFirmwareResponse.ListOTAJobByFirmware_SimpleOTAJobInfo.ListOTAJobByFirmware_OtaTagDTO> simpleOTAJobInfo_tags = new List<ListOTAJobByFirmwareResponse.ListOTAJobByFirmware_SimpleOTAJobInfo.ListOTAJobByFirmware_OtaTagDTO>();
				for (int j = 0; j < _ctx.Length("ListOTAJobByFirmware.Data["+ i +"].Tags.Length"); j++) {
					ListOTAJobByFirmwareResponse.ListOTAJobByFirmware_SimpleOTAJobInfo.ListOTAJobByFirmware_OtaTagDTO otaTagDTO = new ListOTAJobByFirmwareResponse.ListOTAJobByFirmware_SimpleOTAJobInfo.ListOTAJobByFirmware_OtaTagDTO();
					otaTagDTO.Key = _ctx.StringValue("ListOTAJobByFirmware.Data["+ i +"].Tags["+ j +"].Key");
					otaTagDTO._Value = _ctx.StringValue("ListOTAJobByFirmware.Data["+ i +"].Tags["+ j +"].Value");

					simpleOTAJobInfo_tags.Add(otaTagDTO);
				}
				simpleOTAJobInfo.Tags = simpleOTAJobInfo_tags;

				listOTAJobByFirmwareResponse_data.Add(simpleOTAJobInfo);
			}
			listOTAJobByFirmwareResponse.Data = listOTAJobByFirmwareResponse_data;
        
			return listOTAJobByFirmwareResponse;
        }
    }
}

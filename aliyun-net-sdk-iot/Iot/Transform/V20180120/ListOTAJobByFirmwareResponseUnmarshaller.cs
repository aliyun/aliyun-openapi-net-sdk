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
        public static ListOTAJobByFirmwareResponse Unmarshall(UnmarshallerContext context)
        {
			ListOTAJobByFirmwareResponse listOTAJobByFirmwareResponse = new ListOTAJobByFirmwareResponse();

			listOTAJobByFirmwareResponse.HttpResponse = context.HttpResponse;
			listOTAJobByFirmwareResponse.RequestId = context.StringValue("ListOTAJobByFirmware.RequestId");
			listOTAJobByFirmwareResponse.Success = context.BooleanValue("ListOTAJobByFirmware.Success");
			listOTAJobByFirmwareResponse.Code = context.StringValue("ListOTAJobByFirmware.Code");
			listOTAJobByFirmwareResponse.ErrorMessage = context.StringValue("ListOTAJobByFirmware.ErrorMessage");
			listOTAJobByFirmwareResponse.Total = context.IntegerValue("ListOTAJobByFirmware.Total");
			listOTAJobByFirmwareResponse.PageSize = context.IntegerValue("ListOTAJobByFirmware.PageSize");
			listOTAJobByFirmwareResponse.PageCount = context.IntegerValue("ListOTAJobByFirmware.PageCount");
			listOTAJobByFirmwareResponse.CurrentPage = context.IntegerValue("ListOTAJobByFirmware.CurrentPage");

			List<ListOTAJobByFirmwareResponse.ListOTAJobByFirmware_SimpleOTAJobInfo> listOTAJobByFirmwareResponse_data = new List<ListOTAJobByFirmwareResponse.ListOTAJobByFirmware_SimpleOTAJobInfo>();
			for (int i = 0; i < context.Length("ListOTAJobByFirmware.Data.Length"); i++) {
				ListOTAJobByFirmwareResponse.ListOTAJobByFirmware_SimpleOTAJobInfo simpleOTAJobInfo = new ListOTAJobByFirmwareResponse.ListOTAJobByFirmware_SimpleOTAJobInfo();
				simpleOTAJobInfo.JobId = context.StringValue("ListOTAJobByFirmware.Data["+ i +"].JobId");
				simpleOTAJobInfo.UtcCreate = context.StringValue("ListOTAJobByFirmware.Data["+ i +"].UtcCreate");
				simpleOTAJobInfo.UtcModified = context.StringValue("ListOTAJobByFirmware.Data["+ i +"].UtcModified");
				simpleOTAJobInfo.ProductKey = context.StringValue("ListOTAJobByFirmware.Data["+ i +"].ProductKey");
				simpleOTAJobInfo.FirmwareId = context.StringValue("ListOTAJobByFirmware.Data["+ i +"].FirmwareId");
				simpleOTAJobInfo.UtcStartTime = context.StringValue("ListOTAJobByFirmware.Data["+ i +"].UtcStartTime");
				simpleOTAJobInfo.UtcEndTime = context.StringValue("ListOTAJobByFirmware.Data["+ i +"].UtcEndTime");
				simpleOTAJobInfo.JobStatus = context.StringValue("ListOTAJobByFirmware.Data["+ i +"].JobStatus");
				simpleOTAJobInfo.JobType = context.StringValue("ListOTAJobByFirmware.Data["+ i +"].JobType");
				simpleOTAJobInfo.TargetSelection = context.StringValue("ListOTAJobByFirmware.Data["+ i +"].TargetSelection");
				simpleOTAJobInfo.SelectionType = context.StringValue("ListOTAJobByFirmware.Data["+ i +"].SelectionType");

				List<ListOTAJobByFirmwareResponse.ListOTAJobByFirmware_SimpleOTAJobInfo.ListOTAJobByFirmware_OtaTagDTO> simpleOTAJobInfo_tags = new List<ListOTAJobByFirmwareResponse.ListOTAJobByFirmware_SimpleOTAJobInfo.ListOTAJobByFirmware_OtaTagDTO>();
				for (int j = 0; j < context.Length("ListOTAJobByFirmware.Data["+ i +"].Tags.Length"); j++) {
					ListOTAJobByFirmwareResponse.ListOTAJobByFirmware_SimpleOTAJobInfo.ListOTAJobByFirmware_OtaTagDTO otaTagDTO = new ListOTAJobByFirmwareResponse.ListOTAJobByFirmware_SimpleOTAJobInfo.ListOTAJobByFirmware_OtaTagDTO();
					otaTagDTO.Key = context.StringValue("ListOTAJobByFirmware.Data["+ i +"].Tags["+ j +"].Key");
					otaTagDTO._Value = context.StringValue("ListOTAJobByFirmware.Data["+ i +"].Tags["+ j +"].Value");

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

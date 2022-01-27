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
    public class ListOTAJobByDeviceResponseUnmarshaller
    {
        public static ListOTAJobByDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOTAJobByDeviceResponse listOTAJobByDeviceResponse = new ListOTAJobByDeviceResponse();

			listOTAJobByDeviceResponse.HttpResponse = _ctx.HttpResponse;
			listOTAJobByDeviceResponse.RequestId = _ctx.StringValue("ListOTAJobByDevice.RequestId");
			listOTAJobByDeviceResponse.Success = _ctx.BooleanValue("ListOTAJobByDevice.Success");
			listOTAJobByDeviceResponse.Code = _ctx.StringValue("ListOTAJobByDevice.Code");
			listOTAJobByDeviceResponse.ErrorMessage = _ctx.StringValue("ListOTAJobByDevice.ErrorMessage");
			listOTAJobByDeviceResponse.Total = _ctx.IntegerValue("ListOTAJobByDevice.Total");
			listOTAJobByDeviceResponse.PageSize = _ctx.IntegerValue("ListOTAJobByDevice.PageSize");
			listOTAJobByDeviceResponse.PageCount = _ctx.IntegerValue("ListOTAJobByDevice.PageCount");
			listOTAJobByDeviceResponse.CurrentPage = _ctx.IntegerValue("ListOTAJobByDevice.CurrentPage");

			List<ListOTAJobByDeviceResponse.ListOTAJobByDevice_SimpleOTAJobInfo> listOTAJobByDeviceResponse_data = new List<ListOTAJobByDeviceResponse.ListOTAJobByDevice_SimpleOTAJobInfo>();
			for (int i = 0; i < _ctx.Length("ListOTAJobByDevice.Data.Length"); i++) {
				ListOTAJobByDeviceResponse.ListOTAJobByDevice_SimpleOTAJobInfo simpleOTAJobInfo = new ListOTAJobByDeviceResponse.ListOTAJobByDevice_SimpleOTAJobInfo();
				simpleOTAJobInfo.JobId = _ctx.StringValue("ListOTAJobByDevice.Data["+ i +"].JobId");
				simpleOTAJobInfo.UtcCreate = _ctx.StringValue("ListOTAJobByDevice.Data["+ i +"].UtcCreate");
				simpleOTAJobInfo.UtcModified = _ctx.StringValue("ListOTAJobByDevice.Data["+ i +"].UtcModified");
				simpleOTAJobInfo.ProductKey = _ctx.StringValue("ListOTAJobByDevice.Data["+ i +"].ProductKey");
				simpleOTAJobInfo.FirmwareId = _ctx.StringValue("ListOTAJobByDevice.Data["+ i +"].FirmwareId");
				simpleOTAJobInfo.UtcStartTime = _ctx.StringValue("ListOTAJobByDevice.Data["+ i +"].UtcStartTime");
				simpleOTAJobInfo.UtcEndTime = _ctx.StringValue("ListOTAJobByDevice.Data["+ i +"].UtcEndTime");
				simpleOTAJobInfo.JobStatus = _ctx.StringValue("ListOTAJobByDevice.Data["+ i +"].JobStatus");
				simpleOTAJobInfo.JobType = _ctx.StringValue("ListOTAJobByDevice.Data["+ i +"].JobType");
				simpleOTAJobInfo.TargetSelection = _ctx.StringValue("ListOTAJobByDevice.Data["+ i +"].TargetSelection");
				simpleOTAJobInfo.SelectionType = _ctx.StringValue("ListOTAJobByDevice.Data["+ i +"].SelectionType");

				List<ListOTAJobByDeviceResponse.ListOTAJobByDevice_SimpleOTAJobInfo.ListOTAJobByDevice_OtaTagDTO> simpleOTAJobInfo_tags = new List<ListOTAJobByDeviceResponse.ListOTAJobByDevice_SimpleOTAJobInfo.ListOTAJobByDevice_OtaTagDTO>();
				for (int j = 0; j < _ctx.Length("ListOTAJobByDevice.Data["+ i +"].Tags.Length"); j++) {
					ListOTAJobByDeviceResponse.ListOTAJobByDevice_SimpleOTAJobInfo.ListOTAJobByDevice_OtaTagDTO otaTagDTO = new ListOTAJobByDeviceResponse.ListOTAJobByDevice_SimpleOTAJobInfo.ListOTAJobByDevice_OtaTagDTO();
					otaTagDTO.Key = _ctx.StringValue("ListOTAJobByDevice.Data["+ i +"].Tags["+ j +"].Key");
					otaTagDTO._Value = _ctx.StringValue("ListOTAJobByDevice.Data["+ i +"].Tags["+ j +"].Value");

					simpleOTAJobInfo_tags.Add(otaTagDTO);
				}
				simpleOTAJobInfo.Tags = simpleOTAJobInfo_tags;

				listOTAJobByDeviceResponse_data.Add(simpleOTAJobInfo);
			}
			listOTAJobByDeviceResponse.Data = listOTAJobByDeviceResponse_data;
        
			return listOTAJobByDeviceResponse;
        }
    }
}

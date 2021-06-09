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
    public class QueryOTAJobResponseUnmarshaller
    {
        public static QueryOTAJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryOTAJobResponse queryOTAJobResponse = new QueryOTAJobResponse();

			queryOTAJobResponse.HttpResponse = _ctx.HttpResponse;
			queryOTAJobResponse.RequestId = _ctx.StringValue("QueryOTAJob.RequestId");
			queryOTAJobResponse.Success = _ctx.BooleanValue("QueryOTAJob.Success");
			queryOTAJobResponse.Code = _ctx.StringValue("QueryOTAJob.Code");
			queryOTAJobResponse.ErrorMessage = _ctx.StringValue("QueryOTAJob.ErrorMessage");

			QueryOTAJobResponse.QueryOTAJob_Data data = new QueryOTAJobResponse.QueryOTAJob_Data();
			data.JobId = _ctx.StringValue("QueryOTAJob.Data.JobId");
			data.UtcCreate = _ctx.StringValue("QueryOTAJob.Data.UtcCreate");
			data.UtcModified = _ctx.StringValue("QueryOTAJob.Data.UtcModified");
			data.ProductKey = _ctx.StringValue("QueryOTAJob.Data.ProductKey");
			data.FirmwareId = _ctx.StringValue("QueryOTAJob.Data.FirmwareId");
			data.UtcStartTime = _ctx.StringValue("QueryOTAJob.Data.UtcStartTime");
			data.UtcEndTime = _ctx.StringValue("QueryOTAJob.Data.UtcEndTime");
			data.JobStatus = _ctx.StringValue("QueryOTAJob.Data.JobStatus");
			data.JobType = _ctx.StringValue("QueryOTAJob.Data.JobType");
			data.JobDesc = _ctx.StringValue("QueryOTAJob.Data.JobDesc");
			data.Name = _ctx.StringValue("QueryOTAJob.Data.Name");
			data.UtcScheduleTime = _ctx.StringValue("QueryOTAJob.Data.UtcScheduleTime");
			data.RetryInterval = _ctx.IntegerValue("QueryOTAJob.Data.RetryInterval");
			data.RetryCount = _ctx.IntegerValue("QueryOTAJob.Data.RetryCount");
			data.TimeoutInMinutes = _ctx.IntegerValue("QueryOTAJob.Data.TimeoutInMinutes");
			data.TargetSelection = _ctx.StringValue("QueryOTAJob.Data.TargetSelection");
			data.SelectionType = _ctx.StringValue("QueryOTAJob.Data.SelectionType");
			data.GrayPercent = _ctx.StringValue("QueryOTAJob.Data.GrayPercent");
			data.MaximumPerMinute = _ctx.IntegerValue("QueryOTAJob.Data.MaximumPerMinute");
			data.DestVersion = _ctx.StringValue("QueryOTAJob.Data.DestVersion");
			data.UtcScheduleFinishTime = _ctx.StringValue("QueryOTAJob.Data.UtcScheduleFinishTime");
			data.OverwriteMode = _ctx.IntegerValue("QueryOTAJob.Data.OverwriteMode");
			data.DynamicMode = _ctx.IntegerValue("QueryOTAJob.Data.DynamicMode");
			data.NeedPush = _ctx.BooleanValue("QueryOTAJob.Data.NeedPush");
			data.NeedConfirm = _ctx.BooleanValue("QueryOTAJob.Data.NeedConfirm");

			List<string> data_srcVersions = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryOTAJob.Data.SrcVersions.Length"); i++) {
				data_srcVersions.Add(_ctx.StringValue("QueryOTAJob.Data.SrcVersions["+ i +"]"));
			}
			data.SrcVersions = data_srcVersions;

			List<QueryOTAJobResponse.QueryOTAJob_Data.QueryOTAJob_OtaTagDTO> data_tags = new List<QueryOTAJobResponse.QueryOTAJob_Data.QueryOTAJob_OtaTagDTO>();
			for (int i = 0; i < _ctx.Length("QueryOTAJob.Data.Tags.Length"); i++) {
				QueryOTAJobResponse.QueryOTAJob_Data.QueryOTAJob_OtaTagDTO otaTagDTO = new QueryOTAJobResponse.QueryOTAJob_Data.QueryOTAJob_OtaTagDTO();
				otaTagDTO.Key = _ctx.StringValue("QueryOTAJob.Data.Tags["+ i +"].Key");
				otaTagDTO._Value = _ctx.StringValue("QueryOTAJob.Data.Tags["+ i +"].Value");

				data_tags.Add(otaTagDTO);
			}
			data.Tags = data_tags;
			queryOTAJobResponse.Data = data;
        
			return queryOTAJobResponse;
        }
    }
}

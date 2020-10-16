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
        public static QueryOTAJobResponse Unmarshall(UnmarshallerContext context)
        {
			QueryOTAJobResponse queryOTAJobResponse = new QueryOTAJobResponse();

			queryOTAJobResponse.HttpResponse = context.HttpResponse;
			queryOTAJobResponse.RequestId = context.StringValue("QueryOTAJob.RequestId");
			queryOTAJobResponse.Success = context.BooleanValue("QueryOTAJob.Success");
			queryOTAJobResponse.Code = context.StringValue("QueryOTAJob.Code");
			queryOTAJobResponse.ErrorMessage = context.StringValue("QueryOTAJob.ErrorMessage");

			QueryOTAJobResponse.QueryOTAJob_Data data = new QueryOTAJobResponse.QueryOTAJob_Data();
			data.JobId = context.StringValue("QueryOTAJob.Data.JobId");
			data.UtcCreate = context.StringValue("QueryOTAJob.Data.UtcCreate");
			data.UtcModified = context.StringValue("QueryOTAJob.Data.UtcModified");
			data.ProductKey = context.StringValue("QueryOTAJob.Data.ProductKey");
			data.FirmwareId = context.StringValue("QueryOTAJob.Data.FirmwareId");
			data.UtcStartTime = context.StringValue("QueryOTAJob.Data.UtcStartTime");
			data.UtcEndTime = context.StringValue("QueryOTAJob.Data.UtcEndTime");
			data.JobStatus = context.StringValue("QueryOTAJob.Data.JobStatus");
			data.JobType = context.StringValue("QueryOTAJob.Data.JobType");
			data.JobDesc = context.StringValue("QueryOTAJob.Data.JobDesc");
			data.Name = context.StringValue("QueryOTAJob.Data.Name");
			data.UtcScheduleTime = context.StringValue("QueryOTAJob.Data.UtcScheduleTime");
			data.RetryInterval = context.IntegerValue("QueryOTAJob.Data.RetryInterval");
			data.RetryCount = context.IntegerValue("QueryOTAJob.Data.RetryCount");
			data.TimeoutInMinutes = context.IntegerValue("QueryOTAJob.Data.TimeoutInMinutes");
			data.TargetSelection = context.StringValue("QueryOTAJob.Data.TargetSelection");
			data.SelectionType = context.StringValue("QueryOTAJob.Data.SelectionType");
			data.GrayPercent = context.StringValue("QueryOTAJob.Data.GrayPercent");
			data.MaximumPerMinute = context.IntegerValue("QueryOTAJob.Data.MaximumPerMinute");
			data.DestVersion = context.StringValue("QueryOTAJob.Data.DestVersion");
			data.UtcScheduleFinishTime = context.StringValue("QueryOTAJob.Data.UtcScheduleFinishTime");
			data.OverwriteMode = context.IntegerValue("QueryOTAJob.Data.OverwriteMode");
			data.DynamicMode = context.IntegerValue("QueryOTAJob.Data.DynamicMode");

			List<string> data_srcVersions = new List<string>();
			for (int i = 0; i < context.Length("QueryOTAJob.Data.SrcVersions.Length"); i++) {
				data_srcVersions.Add(context.StringValue("QueryOTAJob.Data.SrcVersions["+ i +"]"));
			}
			data.SrcVersions = data_srcVersions;

			List<QueryOTAJobResponse.QueryOTAJob_Data.QueryOTAJob_OtaTagDTO> data_tags = new List<QueryOTAJobResponse.QueryOTAJob_Data.QueryOTAJob_OtaTagDTO>();
			for (int i = 0; i < context.Length("QueryOTAJob.Data.Tags.Length"); i++) {
				QueryOTAJobResponse.QueryOTAJob_Data.QueryOTAJob_OtaTagDTO otaTagDTO = new QueryOTAJobResponse.QueryOTAJob_Data.QueryOTAJob_OtaTagDTO();
				otaTagDTO.Key = context.StringValue("QueryOTAJob.Data.Tags["+ i +"].Key");
				otaTagDTO._Value = context.StringValue("QueryOTAJob.Data.Tags["+ i +"].Value");

				data_tags.Add(otaTagDTO);
			}
			data.Tags = data_tags;
			queryOTAJobResponse.Data = data;
        
			return queryOTAJobResponse;
        }
    }
}

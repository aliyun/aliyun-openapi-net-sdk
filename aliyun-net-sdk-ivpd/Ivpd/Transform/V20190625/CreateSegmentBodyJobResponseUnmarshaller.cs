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
using Aliyun.Acs.ivpd.Model.V20190625;

namespace Aliyun.Acs.ivpd.Transform.V20190625
{
    public class CreateSegmentBodyJobResponseUnmarshaller
    {
        public static CreateSegmentBodyJobResponse Unmarshall(UnmarshallerContext context)
        {
			CreateSegmentBodyJobResponse createSegmentBodyJobResponse = new CreateSegmentBodyJobResponse();

			createSegmentBodyJobResponse.HttpResponse = context.HttpResponse;
			createSegmentBodyJobResponse.RequestId = context.StringValue("CreateSegmentBodyJob.RequestId");
			createSegmentBodyJobResponse.Code = context.StringValue("CreateSegmentBodyJob.Code");
			createSegmentBodyJobResponse.Message = context.StringValue("CreateSegmentBodyJob.Message");

			CreateSegmentBodyJobResponse.CreateSegmentBodyJob_Data data = new CreateSegmentBodyJobResponse.CreateSegmentBodyJob_Data();
			data.Status = context.StringValue("CreateSegmentBodyJob.Data.Status");
			data.Completed = context.BooleanValue("CreateSegmentBodyJob.Data.Completed");
			data.BatchSize = context.IntegerValue("CreateSegmentBodyJob.Data.BatchSize");
			data.TotalUsedTime = context.LongValue("CreateSegmentBodyJob.Data.TotalUsedTime");
			data.Progress = context.IntegerValue("CreateSegmentBodyJob.Data.Progress");
			data.JobId = context.StringValue("CreateSegmentBodyJob.Data.JobId");

			List<CreateSegmentBodyJobResponse.CreateSegmentBodyJob_Data.CreateSegmentBodyJob_Result> data_resultList = new List<CreateSegmentBodyJobResponse.CreateSegmentBodyJob_Data.CreateSegmentBodyJob_Result>();
			for (int i = 0; i < context.Length("CreateSegmentBodyJob.Data.ResultList.Length"); i++) {
				CreateSegmentBodyJobResponse.CreateSegmentBodyJob_Data.CreateSegmentBodyJob_Result result = new CreateSegmentBodyJobResponse.CreateSegmentBodyJob_Data.CreateSegmentBodyJob_Result();
				result.DataId = context.StringValue("CreateSegmentBodyJob.Data.ResultList["+ i +"].DataId");
				result.Success = context.BooleanValue("CreateSegmentBodyJob.Data.ResultList["+ i +"].Success");
				result.Code = context.StringValue("CreateSegmentBodyJob.Data.ResultList["+ i +"].Code");
				result.Message = context.StringValue("CreateSegmentBodyJob.Data.ResultList["+ i +"].Message");

				CreateSegmentBodyJobResponse.CreateSegmentBodyJob_Data.CreateSegmentBodyJob_Result.CreateSegmentBodyJob_ResultData resultData = new CreateSegmentBodyJobResponse.CreateSegmentBodyJob_Data.CreateSegmentBodyJob_Result.CreateSegmentBodyJob_ResultData();
				resultData.ImageUrl = context.StringValue("CreateSegmentBodyJob.Data.ResultList["+ i +"].ResultData.ImageUrl");
				result.ResultData = resultData;

				data_resultList.Add(result);
			}
			data.ResultList = data_resultList;
			createSegmentBodyJobResponse.Data = data;
        
			return createSegmentBodyJobResponse;
        }
    }
}

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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class GetPrecisionTaskResponseUnmarshaller
    {
        public static GetPrecisionTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPrecisionTaskResponse getPrecisionTaskResponse = new GetPrecisionTaskResponse();

			getPrecisionTaskResponse.HttpResponse = _ctx.HttpResponse;
			getPrecisionTaskResponse.Code = _ctx.StringValue("GetPrecisionTask.Code");
			getPrecisionTaskResponse.Message = _ctx.StringValue("GetPrecisionTask.Message");
			getPrecisionTaskResponse.RequestId = _ctx.StringValue("GetPrecisionTask.RequestId");
			getPrecisionTaskResponse.Success = _ctx.BooleanValue("GetPrecisionTask.Success");

			GetPrecisionTaskResponse.GetPrecisionTask_Data data = new GetPrecisionTaskResponse.GetPrecisionTask_Data();
			data.Status = _ctx.IntegerValue("GetPrecisionTask.Data.Status");
			data.UpdateTime = _ctx.StringValue("GetPrecisionTask.Data.UpdateTime");
			data.IncorrectWords = _ctx.IntegerValue("GetPrecisionTask.Data.IncorrectWords");
			data.DataSetId = _ctx.LongValue("GetPrecisionTask.Data.DataSetId");
			data.VerifiedCount = _ctx.IntegerValue("GetPrecisionTask.Data.VerifiedCount");
			data.Duration = _ctx.IntegerValue("GetPrecisionTask.Data.Duration");
			data.DataSetName = _ctx.StringValue("GetPrecisionTask.Data.DataSetName");
			data.TotalCount = _ctx.IntegerValue("GetPrecisionTask.Data.TotalCount");
			data.Source = _ctx.IntegerValue("GetPrecisionTask.Data.Source");
			data.Name = _ctx.StringValue("GetPrecisionTask.Data.Name");
			data.TaskId = _ctx.StringValue("GetPrecisionTask.Data.TaskId");

			List<GetPrecisionTaskResponse.GetPrecisionTask_Data.GetPrecisionTask_Precision> data_precisions = new List<GetPrecisionTaskResponse.GetPrecisionTask_Data.GetPrecisionTask_Precision>();
			for (int i = 0; i < _ctx.Length("GetPrecisionTask.Data.Precisions.Length"); i++) {
				GetPrecisionTaskResponse.GetPrecisionTask_Data.GetPrecisionTask_Precision precision = new GetPrecisionTaskResponse.GetPrecisionTask_Data.GetPrecisionTask_Precision();
				precision.Status = _ctx.IntegerValue("GetPrecisionTask.Data.Precisions["+ i +"].Status");
				precision.ModelName = _ctx.StringValue("GetPrecisionTask.Data.Precisions["+ i +"].ModelName");
				precision.TaskId = _ctx.StringValue("GetPrecisionTask.Data.Precisions["+ i +"].TaskId");
				precision.Precision = _ctx.FloatValue("GetPrecisionTask.Data.Precisions["+ i +"].Precision");
				precision.ModelId = _ctx.LongValue("GetPrecisionTask.Data.Precisions["+ i +"].ModelId");

				data_precisions.Add(precision);
			}
			data.Precisions = data_precisions;
			getPrecisionTaskResponse.Data = data;
        
			return getPrecisionTaskResponse;
        }
    }
}

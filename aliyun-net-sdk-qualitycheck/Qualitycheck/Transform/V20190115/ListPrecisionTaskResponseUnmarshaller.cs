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
    public class ListPrecisionTaskResponseUnmarshaller
    {
        public static ListPrecisionTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPrecisionTaskResponse listPrecisionTaskResponse = new ListPrecisionTaskResponse();

			listPrecisionTaskResponse.HttpResponse = _ctx.HttpResponse;
			listPrecisionTaskResponse.RequestId = _ctx.StringValue("ListPrecisionTask.RequestId");
			listPrecisionTaskResponse.Success = _ctx.BooleanValue("ListPrecisionTask.Success");
			listPrecisionTaskResponse.Code = _ctx.StringValue("ListPrecisionTask.Code");
			listPrecisionTaskResponse.Message = _ctx.StringValue("ListPrecisionTask.Message");
			listPrecisionTaskResponse.PageNumber = _ctx.IntegerValue("ListPrecisionTask.PageNumber");
			listPrecisionTaskResponse.PageSize = _ctx.IntegerValue("ListPrecisionTask.PageSize");
			listPrecisionTaskResponse.Count = _ctx.IntegerValue("ListPrecisionTask.Count");

			List<ListPrecisionTaskResponse.ListPrecisionTask_PrecisionTask> listPrecisionTaskResponse_data = new List<ListPrecisionTaskResponse.ListPrecisionTask_PrecisionTask>();
			for (int i = 0; i < _ctx.Length("ListPrecisionTask.Data.Length"); i++) {
				ListPrecisionTaskResponse.ListPrecisionTask_PrecisionTask precisionTask = new ListPrecisionTaskResponse.ListPrecisionTask_PrecisionTask();
				precisionTask.Name = _ctx.StringValue("ListPrecisionTask.Data["+ i +"].Name");
				precisionTask.TaskId = _ctx.StringValue("ListPrecisionTask.Data["+ i +"].TaskId");
				precisionTask.Source = _ctx.IntegerValue("ListPrecisionTask.Data["+ i +"].Source");
				precisionTask.DataSetId = _ctx.LongValue("ListPrecisionTask.Data["+ i +"].DataSetId");
				precisionTask.DataSetName = _ctx.StringValue("ListPrecisionTask.Data["+ i +"].DataSetName");
				precisionTask.Duration = _ctx.IntegerValue("ListPrecisionTask.Data["+ i +"].Duration");
				precisionTask.Status = _ctx.IntegerValue("ListPrecisionTask.Data["+ i +"].Status");
				precisionTask.TotalCount = _ctx.IntegerValue("ListPrecisionTask.Data["+ i +"].TotalCount");
				precisionTask.VerifiedCount = _ctx.IntegerValue("ListPrecisionTask.Data["+ i +"].VerifiedCount");
				precisionTask.IncorrectWords = _ctx.IntegerValue("ListPrecisionTask.Data["+ i +"].IncorrectWords");
				precisionTask.CreateTime = _ctx.StringValue("ListPrecisionTask.Data["+ i +"].CreateTime");
				precisionTask.UpdateTime = _ctx.StringValue("ListPrecisionTask.Data["+ i +"].UpdateTime");

				List<ListPrecisionTaskResponse.ListPrecisionTask_PrecisionTask.ListPrecisionTask_Precision> precisionTask_precisions = new List<ListPrecisionTaskResponse.ListPrecisionTask_PrecisionTask.ListPrecisionTask_Precision>();
				for (int j = 0; j < _ctx.Length("ListPrecisionTask.Data["+ i +"].Precisions.Length"); j++) {
					ListPrecisionTaskResponse.ListPrecisionTask_PrecisionTask.ListPrecisionTask_Precision precision = new ListPrecisionTaskResponse.ListPrecisionTask_PrecisionTask.ListPrecisionTask_Precision();
					precision.ModelName = _ctx.StringValue("ListPrecisionTask.Data["+ i +"].Precisions["+ j +"].ModelName");
					precision.ModelId = _ctx.LongValue("ListPrecisionTask.Data["+ i +"].Precisions["+ j +"].ModelId");
					precision.Precision = _ctx.FloatValue("ListPrecisionTask.Data["+ i +"].Precisions["+ j +"].Precision");
					precision.Status = _ctx.IntegerValue("ListPrecisionTask.Data["+ i +"].Precisions["+ j +"].Status");
					precision.TaskId = _ctx.StringValue("ListPrecisionTask.Data["+ i +"].Precisions["+ j +"].TaskId");
					precision.CreateTime = _ctx.StringValue("ListPrecisionTask.Data["+ i +"].Precisions["+ j +"].CreateTime");

					precisionTask_precisions.Add(precision);
				}
				precisionTask.Precisions = precisionTask_precisions;

				listPrecisionTaskResponse_data.Add(precisionTask);
			}
			listPrecisionTaskResponse.Data = listPrecisionTaskResponse_data;
        
			return listPrecisionTaskResponse;
        }
    }
}

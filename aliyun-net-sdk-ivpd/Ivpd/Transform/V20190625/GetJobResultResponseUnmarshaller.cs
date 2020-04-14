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
    public class GetJobResultResponseUnmarshaller
    {
        public static GetJobResultResponse Unmarshall(UnmarshallerContext context)
        {
			GetJobResultResponse getJobResultResponse = new GetJobResultResponse();

			getJobResultResponse.HttpResponse = context.HttpResponse;
			getJobResultResponse.RequestId = context.StringValue("GetJobResult.RequestId");
			getJobResultResponse.Code = context.StringValue("GetJobResult.Code");
			getJobResultResponse.Message = context.StringValue("GetJobResult.Message");

			GetJobResultResponse.GetJobResult_Data data = new GetJobResultResponse.GetJobResult_Data();
			data.Status = context.StringValue("GetJobResult.Data.Status");
			data.BatchSize = context.StringValue("GetJobResult.Data.BatchSize");
			data.Finish = context.BooleanValue("GetJobResult.Data.Finish");
			data.Progress = context.FloatValue("GetJobResult.Data.Progress");
			data.Message = context.StringValue("GetJobResult.Data.Message");
			data.Completed = context.BooleanValue("GetJobResult.Data.Completed");
			data.TotalUsedTime = context.LongValue("GetJobResult.Data.TotalUsedTime");

			List<Dictionary<string, string>> data_resultList = new List<Dictionary<string, string>>();
			for (int i = 0; i < context.Length("GetJobResult.Data.ResultList.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in context.ResponseDictionary){
					string prefix = "GetJobResult.Data.ResultList["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					data_resultList.Add(tmp);
				}
			}
			data.ResultList = data_resultList;
			getJobResultResponse.Data = data;
        
			return getJobResultResponse;
        }
    }
}

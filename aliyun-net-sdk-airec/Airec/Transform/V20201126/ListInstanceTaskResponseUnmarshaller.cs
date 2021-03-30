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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class ListInstanceTaskResponseUnmarshaller
    {
        public static ListInstanceTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstanceTaskResponse listInstanceTaskResponse = new ListInstanceTaskResponse();

			listInstanceTaskResponse.HttpResponse = _ctx.HttpResponse;
			listInstanceTaskResponse.Code = _ctx.StringValue("ListInstanceTask.code");
			listInstanceTaskResponse.Message = _ctx.StringValue("ListInstanceTask.message");
			listInstanceTaskResponse.RequestId = _ctx.StringValue("ListInstanceTask.requestId");

			List<ListInstanceTaskResponse.ListInstanceTask_ResultItem> listInstanceTaskResponse_result = new List<ListInstanceTaskResponse.ListInstanceTask_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListInstanceTask.Result.Length"); i++) {
				ListInstanceTaskResponse.ListInstanceTask_ResultItem resultItem = new ListInstanceTaskResponse.ListInstanceTask_ResultItem();
				resultItem.Name = _ctx.StringValue("ListInstanceTask.Result["+ i +"].name");
				resultItem.TotalProgress = _ctx.IntegerValue("ListInstanceTask.Result["+ i +"].totalProgress");

				List<ListInstanceTaskResponse.ListInstanceTask_ResultItem.ListInstanceTask_SubProgressInfosItem> resultItem_subProgressInfos = new List<ListInstanceTaskResponse.ListInstanceTask_ResultItem.ListInstanceTask_SubProgressInfosItem>();
				for (int j = 0; j < _ctx.Length("ListInstanceTask.Result["+ i +"].SubProgressInfos.Length"); j++) {
					ListInstanceTaskResponse.ListInstanceTask_ResultItem.ListInstanceTask_SubProgressInfosItem subProgressInfosItem = new ListInstanceTaskResponse.ListInstanceTask_ResultItem.ListInstanceTask_SubProgressInfosItem();
					subProgressInfosItem.Detail = _ctx.StringValue("ListInstanceTask.Result["+ i +"].SubProgressInfos["+ j +"].detail");
					subProgressInfosItem.FinishedNum = _ctx.IntegerValue("ListInstanceTask.Result["+ i +"].SubProgressInfos["+ j +"].finishedNum");
					subProgressInfosItem.Progress = _ctx.IntegerValue("ListInstanceTask.Result["+ i +"].SubProgressInfos["+ j +"].progress");
					subProgressInfosItem.TotalNum = _ctx.IntegerValue("ListInstanceTask.Result["+ i +"].SubProgressInfos["+ j +"].totalNum");
					subProgressInfosItem.Type = _ctx.StringValue("ListInstanceTask.Result["+ i +"].SubProgressInfos["+ j +"].type");

					resultItem_subProgressInfos.Add(subProgressInfosItem);
				}
				resultItem.SubProgressInfos = resultItem_subProgressInfos;

				listInstanceTaskResponse_result.Add(resultItem);
			}
			listInstanceTaskResponse.Result = listInstanceTaskResponse_result;
        
			return listInstanceTaskResponse;
        }
    }
}

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
using Aliyun.Acs.Airec.Model.V20181012;

namespace Aliyun.Acs.Airec.Transform.V20181012
{
    public class ListInstanceTaskResponseUnmarshaller
    {
        public static ListInstanceTaskResponse Unmarshall(UnmarshallerContext context)
        {
			ListInstanceTaskResponse listInstanceTaskResponse = new ListInstanceTaskResponse();

			listInstanceTaskResponse.HttpResponse = context.HttpResponse;
			listInstanceTaskResponse.RequestId = context.StringValue("ListInstanceTask.RequestId");
			listInstanceTaskResponse.Code = context.StringValue("ListInstanceTask.Code");
			listInstanceTaskResponse.Message = context.StringValue("ListInstanceTask.Message");

			List<ListInstanceTaskResponse.ListInstanceTask_ResultItem> listInstanceTaskResponse_result = new List<ListInstanceTaskResponse.ListInstanceTask_ResultItem>();
			for (int i = 0; i < context.Length("ListInstanceTask.Result.Length"); i++) {
				ListInstanceTaskResponse.ListInstanceTask_ResultItem resultItem = new ListInstanceTaskResponse.ListInstanceTask_ResultItem();
				resultItem.Name = context.StringValue("ListInstanceTask.Result["+ i +"].Name");
				resultItem.TotalProgress = context.IntegerValue("ListInstanceTask.Result["+ i +"].TotalProgress");

				List<ListInstanceTaskResponse.ListInstanceTask_ResultItem.ListInstanceTask_SubProgressInfosItem> resultItem_subProgressInfos = new List<ListInstanceTaskResponse.ListInstanceTask_ResultItem.ListInstanceTask_SubProgressInfosItem>();
				for (int j = 0; j < context.Length("ListInstanceTask.Result["+ i +"].SubProgressInfos.Length"); j++) {
					ListInstanceTaskResponse.ListInstanceTask_ResultItem.ListInstanceTask_SubProgressInfosItem subProgressInfosItem = new ListInstanceTaskResponse.ListInstanceTask_ResultItem.ListInstanceTask_SubProgressInfosItem();
					subProgressInfosItem.Type = context.StringValue("ListInstanceTask.Result["+ i +"].SubProgressInfos["+ j +"].Type");
					subProgressInfosItem.Progress = context.IntegerValue("ListInstanceTask.Result["+ i +"].SubProgressInfos["+ j +"].Progress");
					subProgressInfosItem.Detail = context.StringValue("ListInstanceTask.Result["+ i +"].SubProgressInfos["+ j +"].Detail");
					subProgressInfosItem.TotalNum = context.IntegerValue("ListInstanceTask.Result["+ i +"].SubProgressInfos["+ j +"].TotalNum");
					subProgressInfosItem.FinishedNum = context.IntegerValue("ListInstanceTask.Result["+ i +"].SubProgressInfos["+ j +"].FinishedNum");

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

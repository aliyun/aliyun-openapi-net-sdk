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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class ListJobHistoriesResponseUnmarshaller
    {
        public static ListJobHistoriesResponse Unmarshall(UnmarshallerContext context)
        {
			ListJobHistoriesResponse listJobHistoriesResponse = new ListJobHistoriesResponse();

			listJobHistoriesResponse.HttpResponse = context.HttpResponse;
			listJobHistoriesResponse.Code = context.IntegerValue("ListJobHistories.Code");
			listJobHistoriesResponse.PageNumber = context.IntegerValue("ListJobHistories.PageNumber");
			listJobHistoriesResponse.RequestId = context.StringValue("ListJobHistories.RequestId");
			listJobHistoriesResponse.PageSize = context.IntegerValue("ListJobHistories.PageSize");
			listJobHistoriesResponse.TotalCount = context.LongValue("ListJobHistories.TotalCount");
			listJobHistoriesResponse.ErrorMsg = context.StringValue("ListJobHistories.ErrorMsg");

			List<ListJobHistoriesResponse.ListJobHistories_JobDetail> listJobHistoriesResponse_data = new List<ListJobHistoriesResponse.ListJobHistories_JobDetail>();
			for (int i = 0; i < context.Length("ListJobHistories.Data.Length"); i++) {
				ListJobHistoriesResponse.ListJobHistories_JobDetail jobDetail = new ListJobHistoriesResponse.ListJobHistories_JobDetail();
				jobDetail.Name = context.StringValue("ListJobHistories.Data["+ i +"].Name");
				jobDetail.CompletionTime = context.StringValue("ListJobHistories.Data["+ i +"].CompletionTime");
				jobDetail.StartTime = context.StringValue("ListJobHistories.Data["+ i +"].StartTime");
				jobDetail.Succeeded = context.IntegerValue("ListJobHistories.Data["+ i +"].Succeeded");
				jobDetail.Failed = context.IntegerValue("ListJobHistories.Data["+ i +"].Failed");
				jobDetail.Message = context.StringValue("ListJobHistories.Data["+ i +"].Message");
				jobDetail.ActiveDeadlineSeconds = context.IntegerValue("ListJobHistories.Data["+ i +"].ActiveDeadlineSeconds");
				jobDetail.BackoffLimit = context.IntegerValue("ListJobHistories.Data["+ i +"].BackoffLimit");
				jobDetail.Completions = context.IntegerValue("ListJobHistories.Data["+ i +"].Completions");
				jobDetail.Parallelism = context.IntegerValue("ListJobHistories.Data["+ i +"].Parallelism");

				List<string> jobDetail_podList = new List<string>();
				for (int j = 0; j < context.Length("ListJobHistories.Data["+ i +"].PodList.Length"); j++) {
					jobDetail_podList.Add(context.StringValue("ListJobHistories.Data["+ i +"].PodList["+ j +"]"));
				}
				jobDetail.PodList = jobDetail_podList;

				listJobHistoriesResponse_data.Add(jobDetail);
			}
			listJobHistoriesResponse.Data = listJobHistoriesResponse_data;
        
			return listJobHistoriesResponse;
        }
    }
}

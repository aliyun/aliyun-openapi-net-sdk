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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class QueryIProductionJobListResponseUnmarshaller
    {
        public static QueryIProductionJobListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryIProductionJobListResponse queryIProductionJobListResponse = new QueryIProductionJobListResponse();

			queryIProductionJobListResponse.HttpResponse = context.HttpResponse;
			queryIProductionJobListResponse.RequestId = context.StringValue("QueryIProductionJobList.RequestId");
			queryIProductionJobListResponse.NextPageToken = context.StringValue("QueryIProductionJobList.NextPageToken");

			List<string> queryIProductionJobListResponse_nonExistIds = new List<string>();
			for (int i = 0; i < context.Length("QueryIProductionJobList.NonExistIds.Length"); i++) {
				queryIProductionJobListResponse_nonExistIds.Add(context.StringValue("QueryIProductionJobList.NonExistIds["+ i +"]"));
			}
			queryIProductionJobListResponse.NonExistIds = queryIProductionJobListResponse_nonExistIds;

			List<string> queryIProductionJobListResponse_jobs = new List<string>();
			for (int i = 0; i < context.Length("QueryIProductionJobList.Jobs.Length"); i++) {
				queryIProductionJobListResponse_jobs.Add(context.StringValue("QueryIProductionJobList.Jobs["+ i +"]"));
			}
			queryIProductionJobListResponse.Jobs = queryIProductionJobListResponse_jobs;
        
			return queryIProductionJobListResponse;
        }
    }
}

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
    public class QuerySmarttagJobResponseUnmarshaller
    {
        public static QuerySmarttagJobResponse Unmarshall(UnmarshallerContext context)
        {
			QuerySmarttagJobResponse querySmarttagJobResponse = new QuerySmarttagJobResponse();

			querySmarttagJobResponse.HttpResponse = context.HttpResponse;
			querySmarttagJobResponse.RequestId = context.StringValue("QuerySmarttagJob.RequestId");
			querySmarttagJobResponse.JobStatus = context.StringValue("QuerySmarttagJob.JobStatus");
			querySmarttagJobResponse.UserData = context.StringValue("QuerySmarttagJob.UserData");

			List<QuerySmarttagJobResponse.QuerySmarttagJob_Result> querySmarttagJobResponse_results = new List<QuerySmarttagJobResponse.QuerySmarttagJob_Result>();
			for (int i = 0; i < context.Length("QuerySmarttagJob.Results.Length"); i++) {
				QuerySmarttagJobResponse.QuerySmarttagJob_Result result = new QuerySmarttagJobResponse.QuerySmarttagJob_Result();
				result.Type = context.StringValue("QuerySmarttagJob.Results["+ i +"].Type");
				result.Data = context.StringValue("QuerySmarttagJob.Results["+ i +"].Data");

				querySmarttagJobResponse_results.Add(result);
			}
			querySmarttagJobResponse.Results = querySmarttagJobResponse_results;
        
			return querySmarttagJobResponse;
        }
    }
}

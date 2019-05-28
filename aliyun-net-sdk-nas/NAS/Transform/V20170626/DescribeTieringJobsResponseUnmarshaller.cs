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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class DescribeTieringJobsResponseUnmarshaller
    {
        public static DescribeTieringJobsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTieringJobsResponse describeTieringJobsResponse = new DescribeTieringJobsResponse();

			describeTieringJobsResponse.HttpResponse = context.HttpResponse;
			describeTieringJobsResponse.RequestId = context.StringValue("DescribeTieringJobs.RequestId");
			describeTieringJobsResponse.TotalCount = context.IntegerValue("DescribeTieringJobs.TotalCount");
			describeTieringJobsResponse.PageSize = context.IntegerValue("DescribeTieringJobs.PageSize");
			describeTieringJobsResponse.PageNumber = context.IntegerValue("DescribeTieringJobs.PageNumber");

			List<DescribeTieringJobsResponse.DescribeTieringJobs_TieringJob> describeTieringJobsResponse_tieringJobs = new List<DescribeTieringJobsResponse.DescribeTieringJobs_TieringJob>();
			for (int i = 0; i < context.Length("DescribeTieringJobs.TieringJobs.Length"); i++) {
				DescribeTieringJobsResponse.DescribeTieringJobs_TieringJob tieringJob = new DescribeTieringJobsResponse.DescribeTieringJobs_TieringJob();
				tieringJob.Name = context.StringValue("DescribeTieringJobs.TieringJobs["+ i +"].Name");
				tieringJob.Volume = context.StringValue("DescribeTieringJobs.TieringJobs["+ i +"].Volume");
				tieringJob.Path = context.StringValue("DescribeTieringJobs.TieringJobs["+ i +"].Path");
				tieringJob.Recursive = context.BooleanValue("DescribeTieringJobs.TieringJobs["+ i +"].Recursive");
				tieringJob.Type = context.StringValue("DescribeTieringJobs.TieringJobs["+ i +"].Type");
				tieringJob.Policy = context.StringValue("DescribeTieringJobs.TieringJobs["+ i +"].Policy");
				tieringJob.Weekday = context.IntegerValue("DescribeTieringJobs.TieringJobs["+ i +"].Weekday");
				tieringJob.Hour = context.IntegerValue("DescribeTieringJobs.TieringJobs["+ i +"].Hour");
				tieringJob.Enabled = context.BooleanValue("DescribeTieringJobs.TieringJobs["+ i +"].Enabled");
				tieringJob.Status = context.StringValue("DescribeTieringJobs.TieringJobs["+ i +"].Status");
				tieringJob.LastUpdateTime = context.LongValue("DescribeTieringJobs.TieringJobs["+ i +"].LastUpdateTime");

				describeTieringJobsResponse_tieringJobs.Add(tieringJob);
			}
			describeTieringJobsResponse.TieringJobs = describeTieringJobsResponse_tieringJobs;
        
			return describeTieringJobsResponse;
        }
    }
}

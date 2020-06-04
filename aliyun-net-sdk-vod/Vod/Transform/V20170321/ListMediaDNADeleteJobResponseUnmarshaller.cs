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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class ListMediaDNADeleteJobResponseUnmarshaller
    {
        public static ListMediaDNADeleteJobResponse Unmarshall(UnmarshallerContext context)
        {
			ListMediaDNADeleteJobResponse listMediaDNADeleteJobResponse = new ListMediaDNADeleteJobResponse();

			listMediaDNADeleteJobResponse.HttpResponse = context.HttpResponse;
			listMediaDNADeleteJobResponse.RequestId = context.StringValue("ListMediaDNADeleteJob.RequestId");

			List<string> listMediaDNADeleteJobResponse_nonExistAIJobIds = new List<string>();
			for (int i = 0; i < context.Length("ListMediaDNADeleteJob.NonExistAIJobIds.Length"); i++) {
				listMediaDNADeleteJobResponse_nonExistAIJobIds.Add(context.StringValue("ListMediaDNADeleteJob.NonExistAIJobIds["+ i +"]"));
			}
			listMediaDNADeleteJobResponse.NonExistAIJobIds = listMediaDNADeleteJobResponse_nonExistAIJobIds;

			List<ListMediaDNADeleteJobResponse.ListMediaDNADeleteJob_AIJob> listMediaDNADeleteJobResponse_aIJobList = new List<ListMediaDNADeleteJobResponse.ListMediaDNADeleteJob_AIJob>();
			for (int i = 0; i < context.Length("ListMediaDNADeleteJob.AIJobList.Length"); i++) {
				ListMediaDNADeleteJobResponse.ListMediaDNADeleteJob_AIJob aIJob = new ListMediaDNADeleteJobResponse.ListMediaDNADeleteJob_AIJob();
				aIJob.JobId = context.StringValue("ListMediaDNADeleteJob.AIJobList["+ i +"].JobId");
				aIJob.MediaId = context.StringValue("ListMediaDNADeleteJob.AIJobList["+ i +"].MediaId");
				aIJob.Status = context.StringValue("ListMediaDNADeleteJob.AIJobList["+ i +"].Status");
				aIJob.Code = context.StringValue("ListMediaDNADeleteJob.AIJobList["+ i +"].Code");
				aIJob.Message = context.StringValue("ListMediaDNADeleteJob.AIJobList["+ i +"].Message");
				aIJob.FpDBId = context.StringValue("ListMediaDNADeleteJob.AIJobList["+ i +"].FpDBId");

				listMediaDNADeleteJobResponse_aIJobList.Add(aIJob);
			}
			listMediaDNADeleteJobResponse.AIJobList = listMediaDNADeleteJobResponse_aIJobList;
        
			return listMediaDNADeleteJobResponse;
        }
    }
}

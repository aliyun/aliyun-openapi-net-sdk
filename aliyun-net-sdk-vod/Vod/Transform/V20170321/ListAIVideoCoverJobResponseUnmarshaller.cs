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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class ListAIVideoCoverJobResponseUnmarshaller
    {
        public static ListAIVideoCoverJobResponse Unmarshall(UnmarshallerContext context)
        {
			ListAIVideoCoverJobResponse listAIVideoCoverJobResponse = new ListAIVideoCoverJobResponse();

			listAIVideoCoverJobResponse.HttpResponse = context.HttpResponse;
			listAIVideoCoverJobResponse.RequestId = context.StringValue("ListAIVideoCoverJob.RequestId");

			ListAIVideoCoverJobResponse.ListAIVideoCoverJob_AIVideoCoverJob aIVideoCoverJob = new ListAIVideoCoverJobResponse.ListAIVideoCoverJob_AIVideoCoverJob();
			aIVideoCoverJob.Id = context.StringValue("ListAIVideoCoverJob.AIVideoCoverJob.Id");
			aIVideoCoverJob.Status = context.StringValue("ListAIVideoCoverJob.AIVideoCoverJob.Status");
			aIVideoCoverJob.Code = context.StringValue("ListAIVideoCoverJob.AIVideoCoverJob.Code");
			aIVideoCoverJob.Message = context.StringValue("ListAIVideoCoverJob.AIVideoCoverJob.Message");
			aIVideoCoverJob.CreationTime = context.StringValue("ListAIVideoCoverJob.AIVideoCoverJob.CreationTime");
			aIVideoCoverJob.Data = context.StringValue("ListAIVideoCoverJob.AIVideoCoverJob.Data");
			listAIVideoCoverJobResponse.AIVideoCoverJob = aIVideoCoverJob;
        
			return listAIVideoCoverJobResponse;
        }
    }
}
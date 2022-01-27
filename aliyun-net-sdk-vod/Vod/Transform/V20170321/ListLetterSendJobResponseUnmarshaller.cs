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
    public class ListLetterSendJobResponseUnmarshaller
    {
        public static ListLetterSendJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLetterSendJobResponse listLetterSendJobResponse = new ListLetterSendJobResponse();

			listLetterSendJobResponse.HttpResponse = _ctx.HttpResponse;
			listLetterSendJobResponse.RequestId = _ctx.StringValue("ListLetterSendJob.RequestId");

			List<ListLetterSendJobResponse.ListLetterSendJob_LetterJob> listLetterSendJobResponse_letterJobList = new List<ListLetterSendJobResponse.ListLetterSendJob_LetterJob>();
			for (int i = 0; i < _ctx.Length("ListLetterSendJob.LetterJobList.Length"); i++) {
				ListLetterSendJobResponse.ListLetterSendJob_LetterJob letterJob = new ListLetterSendJobResponse.ListLetterSendJob_LetterJob();
				letterJob.CcAddress = _ctx.StringValue("ListLetterSendJob.LetterJobList["+ i +"].CcAddress");
				letterJob.CreateTime = _ctx.StringValue("ListLetterSendJob.LetterJobList["+ i +"].CreateTime");
				letterJob.UserId = _ctx.LongValue("ListLetterSendJob.LetterJobList["+ i +"].UserId");
				letterJob.SendTime = _ctx.StringValue("ListLetterSendJob.LetterJobList["+ i +"].SendTime");
				letterJob.ToAddress = _ctx.StringValue("ListLetterSendJob.LetterJobList["+ i +"].ToAddress");
				letterJob.Body = _ctx.StringValue("ListLetterSendJob.LetterJobList["+ i +"].Body");
				letterJob.DetectionId = _ctx.StringValue("ListLetterSendJob.LetterJobList["+ i +"].DetectionId");
				letterJob.BccAddress = _ctx.StringValue("ListLetterSendJob.LetterJobList["+ i +"].BccAddress");
				letterJob.JobId = _ctx.StringValue("ListLetterSendJob.LetterJobList["+ i +"].JobId");
				letterJob.Title = _ctx.StringValue("ListLetterSendJob.LetterJobList["+ i +"].Title");
				letterJob.TemplateId = _ctx.StringValue("ListLetterSendJob.LetterJobList["+ i +"].TemplateId");
				letterJob.ModifyTime = _ctx.StringValue("ListLetterSendJob.LetterJobList["+ i +"].ModifyTime");

				listLetterSendJobResponse_letterJobList.Add(letterJob);
			}
			listLetterSendJobResponse.LetterJobList = listLetterSendJobResponse_letterJobList;
        
			return listLetterSendJobResponse;
        }
    }
}

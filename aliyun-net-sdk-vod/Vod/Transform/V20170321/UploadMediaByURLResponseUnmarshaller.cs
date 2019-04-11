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
    public class UploadMediaByURLResponseUnmarshaller
    {
        public static UploadMediaByURLResponse Unmarshall(UnmarshallerContext context)
        {
			UploadMediaByURLResponse uploadMediaByURLResponse = new UploadMediaByURLResponse();

			uploadMediaByURLResponse.HttpResponse = context.HttpResponse;
			uploadMediaByURLResponse.RequestId = context.StringValue("UploadMediaByURL.RequestId");

			List<UploadMediaByURLResponse.UploadMediaByURL_UploadJob> uploadMediaByURLResponse_uploadJobs = new List<UploadMediaByURLResponse.UploadMediaByURL_UploadJob>();
			for (int i = 0; i < context.Length("UploadMediaByURL.UploadJobs.Length"); i++) {
				UploadMediaByURLResponse.UploadMediaByURL_UploadJob uploadJob = new UploadMediaByURLResponse.UploadMediaByURL_UploadJob();
				uploadJob.JobId = context.StringValue("UploadMediaByURL.UploadJobs["+ i +"].JobId");
				uploadJob.SourceURL = context.StringValue("UploadMediaByURL.UploadJobs["+ i +"].SourceURL");

				uploadMediaByURLResponse_uploadJobs.Add(uploadJob);
			}
			uploadMediaByURLResponse.UploadJobs = uploadMediaByURLResponse_uploadJobs;
        
			return uploadMediaByURLResponse;
        }
    }
}

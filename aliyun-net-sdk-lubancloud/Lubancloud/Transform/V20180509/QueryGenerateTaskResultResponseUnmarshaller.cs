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
using Aliyun.Acs.lubancloud.Model.V20180509;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.lubancloud.Transform.V20180509
{
    public class QueryGenerateTaskResultResponseUnmarshaller
    {
        public static QueryGenerateTaskResultResponse Unmarshall(UnmarshallerContext context)
        {
			QueryGenerateTaskResultResponse queryGenerateTaskResultResponse = new QueryGenerateTaskResultResponse();

			queryGenerateTaskResultResponse.HttpResponse = context.HttpResponse;
			queryGenerateTaskResultResponse.RequestId = context.StringValue("QueryGenerateTaskResult.RequestId");
			queryGenerateTaskResultResponse.TotalSize = context.IntegerValue("QueryGenerateTaskResult.TotalSize");
			queryGenerateTaskResultResponse.WaitSize = context.IntegerValue("QueryGenerateTaskResult.WaitSize");
			queryGenerateTaskResultResponse.SuccessSize = context.IntegerValue("QueryGenerateTaskResult.SuccessSize");
			queryGenerateTaskResultResponse.FailSize = context.IntegerValue("QueryGenerateTaskResult.FailSize");
			queryGenerateTaskResultResponse.Status = context.IntegerValue("QueryGenerateTaskResult.Status");

			List<QueryGenerateTaskResultResponse.QueryGenerateTaskResult_Picture> queryGenerateTaskResultResponse_pictures = new List<QueryGenerateTaskResultResponse.QueryGenerateTaskResult_Picture>();
			for (int i = 0; i < context.Length("QueryGenerateTaskResult.Pictures.Length"); i++) {
				QueryGenerateTaskResultResponse.QueryGenerateTaskResult_Picture picture = new QueryGenerateTaskResultResponse.QueryGenerateTaskResult_Picture();
				picture.Id = context.LongValue("QueryGenerateTaskResult.Pictures["+ i +"].Id");
				picture.Name = context.StringValue("QueryGenerateTaskResult.Pictures["+ i +"].Name");
				picture.PreviewUrl = context.StringValue("QueryGenerateTaskResult.Pictures["+ i +"].PreviewUrl");
				picture.Width = context.IntegerValue("QueryGenerateTaskResult.Pictures["+ i +"].Width");
				picture.Height = context.IntegerValue("QueryGenerateTaskResult.Pictures["+ i +"].Height");
				picture.Status = context.IntegerValue("QueryGenerateTaskResult.Pictures["+ i +"].Status");

				queryGenerateTaskResultResponse_pictures.Add(picture);
			}
			queryGenerateTaskResultResponse.Pictures = queryGenerateTaskResultResponse_pictures;
        
			return queryGenerateTaskResultResponse;
        }
    }
}
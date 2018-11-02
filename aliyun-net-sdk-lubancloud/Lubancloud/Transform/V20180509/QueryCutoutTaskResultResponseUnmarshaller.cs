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
    public class QueryCutoutTaskResultResponseUnmarshaller
    {
        public static QueryCutoutTaskResultResponse Unmarshall(UnmarshallerContext context)
        {
			QueryCutoutTaskResultResponse queryCutoutTaskResultResponse = new QueryCutoutTaskResultResponse();

			queryCutoutTaskResultResponse.HttpResponse = context.HttpResponse;
			queryCutoutTaskResultResponse.RequestId = context.StringValue("QueryCutoutTaskResult.RequestId");
			queryCutoutTaskResultResponse.TotalSize = context.IntegerValue("QueryCutoutTaskResult.TotalSize");
			queryCutoutTaskResultResponse.WaitSize = context.IntegerValue("QueryCutoutTaskResult.WaitSize");
			queryCutoutTaskResultResponse.SuccessSize = context.IntegerValue("QueryCutoutTaskResult.SuccessSize");
			queryCutoutTaskResultResponse.FailSize = context.IntegerValue("QueryCutoutTaskResult.FailSize");
			queryCutoutTaskResultResponse.Status = context.IntegerValue("QueryCutoutTaskResult.Status");

			List<QueryCutoutTaskResultResponse.QueryCutoutTaskResult_Picture> queryCutoutTaskResultResponse_pictures = new List<QueryCutoutTaskResultResponse.QueryCutoutTaskResult_Picture>();
			for (int i = 0; i < context.Length("QueryCutoutTaskResult.Pictures.Length"); i++) {
				QueryCutoutTaskResultResponse.QueryCutoutTaskResult_Picture picture = new QueryCutoutTaskResultResponse.QueryCutoutTaskResult_Picture();
				picture.OriginUrl = context.StringValue("QueryCutoutTaskResult.Pictures["+ i +"].OriginUrl");
				picture.CutoutUrl = context.StringValue("QueryCutoutTaskResult.Pictures["+ i +"].CutoutUrl");
				picture.Width = context.IntegerValue("QueryCutoutTaskResult.Pictures["+ i +"].Width");
				picture.Height = context.IntegerValue("QueryCutoutTaskResult.Pictures["+ i +"].Height");
				picture.Status = context.IntegerValue("QueryCutoutTaskResult.Pictures["+ i +"].Status");
				picture.ErrorCode = context.StringValue("QueryCutoutTaskResult.Pictures["+ i +"].ErrorCode");
				picture.ErrorMessage = context.StringValue("QueryCutoutTaskResult.Pictures["+ i +"].ErrorMessage");

				queryCutoutTaskResultResponse_pictures.Add(picture);
			}
			queryCutoutTaskResultResponse.Pictures = queryCutoutTaskResultResponse_pictures;
        
			return queryCutoutTaskResultResponse;
        }
    }
}
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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class CreateCallTagsResponseUnmarshaller
    {
        public static CreateCallTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateCallTagsResponse createCallTagsResponse = new CreateCallTagsResponse();

			createCallTagsResponse.HttpResponse = _ctx.HttpResponse;
			createCallTagsResponse.RequestId = _ctx.StringValue("CreateCallTags.RequestId");
			createCallTagsResponse.HttpStatusCode = _ctx.IntegerValue("CreateCallTags.HttpStatusCode");
			createCallTagsResponse.Code = _ctx.StringValue("CreateCallTags.Code");
			createCallTagsResponse.Message = _ctx.StringValue("CreateCallTags.Message");

			List<CreateCallTagsResponse.CreateCallTags_FailureItem> createCallTagsResponse_data = new List<CreateCallTagsResponse.CreateCallTags_FailureItem>();
			for (int i = 0; i < _ctx.Length("CreateCallTags.Data.Length"); i++) {
				CreateCallTagsResponse.CreateCallTags_FailureItem failureItem = new CreateCallTagsResponse.CreateCallTags_FailureItem();
				failureItem.Item = _ctx.StringValue("CreateCallTags.Data["+ i +"].Item");
				failureItem.Reason = _ctx.StringValue("CreateCallTags.Data["+ i +"].Reason");

				createCallTagsResponse_data.Add(failureItem);
			}
			createCallTagsResponse.Data = createCallTagsResponse_data;
        
			return createCallTagsResponse;
        }
    }
}

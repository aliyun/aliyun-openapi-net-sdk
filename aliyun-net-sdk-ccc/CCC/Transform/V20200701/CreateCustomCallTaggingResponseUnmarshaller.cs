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
    public class CreateCustomCallTaggingResponseUnmarshaller
    {
        public static CreateCustomCallTaggingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateCustomCallTaggingResponse createCustomCallTaggingResponse = new CreateCustomCallTaggingResponse();

			createCustomCallTaggingResponse.HttpResponse = _ctx.HttpResponse;
			createCustomCallTaggingResponse.RequestId = _ctx.StringValue("CreateCustomCallTagging.RequestId");
			createCustomCallTaggingResponse.HttpStatusCode = _ctx.IntegerValue("CreateCustomCallTagging.HttpStatusCode");
			createCustomCallTaggingResponse.Code = _ctx.StringValue("CreateCustomCallTagging.Code");
			createCustomCallTaggingResponse.Message = _ctx.StringValue("CreateCustomCallTagging.Message");

			List<CreateCustomCallTaggingResponse.CreateCustomCallTagging_FailureItem> createCustomCallTaggingResponse_data = new List<CreateCustomCallTaggingResponse.CreateCustomCallTagging_FailureItem>();
			for (int i = 0; i < _ctx.Length("CreateCustomCallTagging.Data.Length"); i++) {
				CreateCustomCallTaggingResponse.CreateCustomCallTagging_FailureItem failureItem = new CreateCustomCallTaggingResponse.CreateCustomCallTagging_FailureItem();
				failureItem.Item = _ctx.StringValue("CreateCustomCallTagging.Data["+ i +"].Item");
				failureItem.Reason = _ctx.StringValue("CreateCustomCallTagging.Data["+ i +"].Reason");

				createCustomCallTaggingResponse_data.Add(failureItem);
			}
			createCustomCallTaggingResponse.Data = createCustomCallTaggingResponse_data;
        
			return createCustomCallTaggingResponse;
        }
    }
}

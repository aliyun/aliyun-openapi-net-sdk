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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class DelThesaurusForApiResponseUnmarshaller
    {
        public static DelThesaurusForApiResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DelThesaurusForApiResponse delThesaurusForApiResponse = new DelThesaurusForApiResponse();

			delThesaurusForApiResponse.HttpResponse = _ctx.HttpResponse;
			delThesaurusForApiResponse.RequestId = _ctx.StringValue("DelThesaurusForApi.RequestId");
			delThesaurusForApiResponse.Success = _ctx.BooleanValue("DelThesaurusForApi.Success");
			delThesaurusForApiResponse.Code = _ctx.StringValue("DelThesaurusForApi.Code");
			delThesaurusForApiResponse.Message = _ctx.StringValue("DelThesaurusForApi.Message");
        
			return delThesaurusForApiResponse;
        }
    }
}

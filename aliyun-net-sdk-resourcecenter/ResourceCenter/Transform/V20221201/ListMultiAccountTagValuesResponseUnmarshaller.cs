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
using Aliyun.Acs.ResourceCenter.Model.V20221201;

namespace Aliyun.Acs.ResourceCenter.Transform.V20221201
{
    public class ListMultiAccountTagValuesResponseUnmarshaller
    {
        public static ListMultiAccountTagValuesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMultiAccountTagValuesResponse listMultiAccountTagValuesResponse = new ListMultiAccountTagValuesResponse();

			listMultiAccountTagValuesResponse.HttpResponse = _ctx.HttpResponse;
			listMultiAccountTagValuesResponse.DynamicCode = _ctx.StringValue("ListMultiAccountTagValues.DynamicCode");
			listMultiAccountTagValuesResponse.DynamicMessage = _ctx.StringValue("ListMultiAccountTagValues.DynamicMessage");
			listMultiAccountTagValuesResponse.ErrorCode = _ctx.StringValue("ListMultiAccountTagValues.ErrorCode");
			listMultiAccountTagValuesResponse.ErrorMessage = _ctx.StringValue("ListMultiAccountTagValues.ErrorMessage");
			listMultiAccountTagValuesResponse.NextToken = _ctx.StringValue("ListMultiAccountTagValues.NextToken");
			listMultiAccountTagValuesResponse.RequestId = _ctx.StringValue("ListMultiAccountTagValues.RequestId");
			listMultiAccountTagValuesResponse.Success = _ctx.BooleanValue("ListMultiAccountTagValues.Success");

			List<string> listMultiAccountTagValuesResponse_tagValues = new List<string>();
			for (int i = 0; i < _ctx.Length("ListMultiAccountTagValues.TagValues.Length"); i++) {
				listMultiAccountTagValuesResponse_tagValues.Add(_ctx.StringValue("ListMultiAccountTagValues.TagValues["+ i +"]"));
			}
			listMultiAccountTagValuesResponse.TagValues = listMultiAccountTagValuesResponse_tagValues;
        
			return listMultiAccountTagValuesResponse;
        }
    }
}

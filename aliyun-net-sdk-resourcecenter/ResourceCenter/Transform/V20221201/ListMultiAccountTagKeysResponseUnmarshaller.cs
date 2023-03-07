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
    public class ListMultiAccountTagKeysResponseUnmarshaller
    {
        public static ListMultiAccountTagKeysResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMultiAccountTagKeysResponse listMultiAccountTagKeysResponse = new ListMultiAccountTagKeysResponse();

			listMultiAccountTagKeysResponse.HttpResponse = _ctx.HttpResponse;
			listMultiAccountTagKeysResponse.NextToken = _ctx.StringValue("ListMultiAccountTagKeys.NextToken");
			listMultiAccountTagKeysResponse.RequestId = _ctx.StringValue("ListMultiAccountTagKeys.RequestId");
			listMultiAccountTagKeysResponse.Success = _ctx.BooleanValue("ListMultiAccountTagKeys.Success");
			listMultiAccountTagKeysResponse.DynamicCode = _ctx.StringValue("ListMultiAccountTagKeys.DynamicCode");
			listMultiAccountTagKeysResponse.DynamicMessage = _ctx.StringValue("ListMultiAccountTagKeys.DynamicMessage");
			listMultiAccountTagKeysResponse.ErrorCode = _ctx.StringValue("ListMultiAccountTagKeys.ErrorCode");
			listMultiAccountTagKeysResponse.ErrorMessage = _ctx.StringValue("ListMultiAccountTagKeys.ErrorMessage");

			List<string> listMultiAccountTagKeysResponse_tagKeys = new List<string>();
			for (int i = 0; i < _ctx.Length("ListMultiAccountTagKeys.TagKeys.Length"); i++) {
				listMultiAccountTagKeysResponse_tagKeys.Add(_ctx.StringValue("ListMultiAccountTagKeys.TagKeys["+ i +"]"));
			}
			listMultiAccountTagKeysResponse.TagKeys = listMultiAccountTagKeysResponse_tagKeys;
        
			return listMultiAccountTagKeysResponse;
        }
    }
}

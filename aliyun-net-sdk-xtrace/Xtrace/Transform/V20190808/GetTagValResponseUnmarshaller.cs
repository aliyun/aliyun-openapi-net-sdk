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
using Aliyun.Acs.xtrace.Model.V20190808;

namespace Aliyun.Acs.xtrace.Transform.V20190808
{
    public class GetTagValResponseUnmarshaller
    {
        public static GetTagValResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTagValResponse getTagValResponse = new GetTagValResponse();

			getTagValResponse.HttpResponse = _ctx.HttpResponse;
			getTagValResponse.RequestId = _ctx.StringValue("GetTagVal.RequestId");

			List<string> getTagValResponse_tagValues = new List<string>();
			for (int i = 0; i < _ctx.Length("GetTagVal.TagValues.Length"); i++) {
				getTagValResponse_tagValues.Add(_ctx.StringValue("GetTagVal.TagValues["+ i +"]"));
			}
			getTagValResponse.TagValues = getTagValResponse_tagValues;
        
			return getTagValResponse;
        }
    }
}

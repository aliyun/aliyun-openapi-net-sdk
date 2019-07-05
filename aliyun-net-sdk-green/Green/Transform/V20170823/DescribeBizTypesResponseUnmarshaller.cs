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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeBizTypesResponseUnmarshaller
    {
        public static DescribeBizTypesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBizTypesResponse describeBizTypesResponse = new DescribeBizTypesResponse();

			describeBizTypesResponse.HttpResponse = context.HttpResponse;
			describeBizTypesResponse.RequestId = context.StringValue("DescribeBizTypes.RequestId");
			describeBizTypesResponse.TotalCount = context.IntegerValue("DescribeBizTypes.TotalCount");

			List<string> describeBizTypesResponse_bizTypeList = new List<string>();
			for (int i = 0; i < context.Length("DescribeBizTypes.BizTypeList.Length"); i++) {
				describeBizTypesResponse_bizTypeList.Add(context.StringValue("DescribeBizTypes.BizTypeList["+ i +"]"));
			}
			describeBizTypesResponse.BizTypeList = describeBizTypesResponse_bizTypeList;
        
			return describeBizTypesResponse;
        }
    }
}

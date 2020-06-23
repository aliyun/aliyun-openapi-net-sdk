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
using Aliyun.Acs.Tag.Model.V20180828;

namespace Aliyun.Acs.Tag.Transform.V20180828
{
    public class ListTagValuesResponseUnmarshaller
    {
        public static ListTagValuesResponse Unmarshall(UnmarshallerContext context)
        {
			ListTagValuesResponse listTagValuesResponse = new ListTagValuesResponse();

			listTagValuesResponse.HttpResponse = context.HttpResponse;
			listTagValuesResponse.NextToken = context.StringValue("ListTagValues.NextToken");
			listTagValuesResponse.RequestId = context.StringValue("ListTagValues.RequestId");

			List<string> listTagValuesResponse_values = new List<string>();
			for (int i = 0; i < context.Length("ListTagValues.Values.Length"); i++) {
				listTagValuesResponse_values.Add(context.StringValue("ListTagValues.Values["+ i +"]"));
			}
			listTagValuesResponse.Values = listTagValuesResponse_values;
        
			return listTagValuesResponse;
        }
    }
}

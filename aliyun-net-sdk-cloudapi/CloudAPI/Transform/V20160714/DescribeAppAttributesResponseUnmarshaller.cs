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
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeAppAttributesResponseUnmarshaller
    {
        public static DescribeAppAttributesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAppAttributesResponse describeAppAttributesResponse = new DescribeAppAttributesResponse();

			describeAppAttributesResponse.HttpResponse = context.HttpResponse;
			describeAppAttributesResponse.RequestId = context.StringValue("DescribeAppAttributes.RequestId");
			describeAppAttributesResponse.TotalCount = context.IntegerValue("DescribeAppAttributes.TotalCount");
			describeAppAttributesResponse.PageSize = context.IntegerValue("DescribeAppAttributes.PageSize");
			describeAppAttributesResponse.PageNumber = context.IntegerValue("DescribeAppAttributes.PageNumber");

			List<DescribeAppAttributesResponse.AppAttribute> apps = new List<DescribeAppAttributesResponse.AppAttribute>();
			for (int i = 0; i < context.Length("DescribeAppAttributes.Apps.Length"); i++) {
				DescribeAppAttributesResponse.AppAttribute appAttribute = new DescribeAppAttributesResponse.AppAttribute();
				appAttribute.AppId = context.LongValue("DescribeAppAttributes.Apps["+ i +"].AppId");
				appAttribute.AppName = context.StringValue("DescribeAppAttributes.Apps["+ i +"].AppName");
				appAttribute.Description = context.StringValue("DescribeAppAttributes.Apps["+ i +"].Description");
				appAttribute.CreatedTime = context.StringValue("DescribeAppAttributes.Apps["+ i +"].CreatedTime");
				appAttribute.ModifiedTime = context.StringValue("DescribeAppAttributes.Apps["+ i +"].ModifiedTime");

				apps.Add(appAttribute);
			}
			describeAppAttributesResponse.Apps = apps;
        
			return describeAppAttributesResponse;
        }
    }
}
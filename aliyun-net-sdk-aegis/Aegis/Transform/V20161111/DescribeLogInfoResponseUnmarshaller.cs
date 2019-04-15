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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeLogInfoResponseUnmarshaller
    {
        public static DescribeLogInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLogInfoResponse describeLogInfoResponse = new DescribeLogInfoResponse();

			describeLogInfoResponse.HttpResponse = context.HttpResponse;
			describeLogInfoResponse.RequestId = context.StringValue("DescribeLogInfo.RequestId");
			describeLogInfoResponse.TotalCount = context.IntegerValue("DescribeLogInfo.TotalCount");

			List<DescribeLogInfoResponse.DescribeLogInfo_Item> describeLogInfoResponse_logInfoItems = new List<DescribeLogInfoResponse.DescribeLogInfo_Item>();
			for (int i = 0; i < context.Length("DescribeLogInfo.LogInfoItems.Length"); i++) {
				DescribeLogInfoResponse.DescribeLogInfo_Item item = new DescribeLogInfoResponse.DescribeLogInfo_Item();
				item.Name = context.StringValue("DescribeLogInfo.LogInfoItems["+ i +"].Name");
				item.Id = context.StringValue("DescribeLogInfo.LogInfoItems["+ i +"].Id");

				List<DescribeLogInfoResponse.DescribeLogInfo_Item.DescribeLogInfo_Field> item_fields = new List<DescribeLogInfoResponse.DescribeLogInfo_Item.DescribeLogInfo_Field>();
				for (int j = 0; j < context.Length("DescribeLogInfo.LogInfoItems["+ i +"].Fields.Length"); j++) {
					DescribeLogInfoResponse.DescribeLogInfo_Item.DescribeLogInfo_Field field = new DescribeLogInfoResponse.DescribeLogInfo_Item.DescribeLogInfo_Field();
					field.Name = context.StringValue("DescribeLogInfo.LogInfoItems["+ i +"].Fields["+ j +"].Name");
					field.Type = context.StringValue("DescribeLogInfo.LogInfoItems["+ i +"].Fields["+ j +"].Type");
					field.Desc = context.StringValue("DescribeLogInfo.LogInfoItems["+ i +"].Fields["+ j +"].Desc");

					item_fields.Add(field);
				}
				item.Fields = item_fields;

				describeLogInfoResponse_logInfoItems.Add(item);
			}
			describeLogInfoResponse.LogInfoItems = describeLogInfoResponse_logInfoItems;
        
			return describeLogInfoResponse;
        }
    }
}

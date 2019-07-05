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
    public class DescribeAuditContentItemResponseUnmarshaller
    {
        public static DescribeAuditContentItemResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAuditContentItemResponse describeAuditContentItemResponse = new DescribeAuditContentItemResponse();

			describeAuditContentItemResponse.HttpResponse = context.HttpResponse;
			describeAuditContentItemResponse.RequestId = context.StringValue("DescribeAuditContentItem.RequestId");
			describeAuditContentItemResponse.PageSize = context.IntegerValue("DescribeAuditContentItem.PageSize");
			describeAuditContentItemResponse.CurrentPage = context.IntegerValue("DescribeAuditContentItem.CurrentPage");
			describeAuditContentItemResponse.TotalCount = context.IntegerValue("DescribeAuditContentItem.TotalCount");

			List<DescribeAuditContentItemResponse.DescribeAuditContentItem_AuditContentItem> describeAuditContentItemResponse_auditContentItemList = new List<DescribeAuditContentItemResponse.DescribeAuditContentItem_AuditContentItem>();
			for (int i = 0; i < context.Length("DescribeAuditContentItem.AuditContentItemList.Length"); i++) {
				DescribeAuditContentItemResponse.DescribeAuditContentItem_AuditContentItem auditContentItem = new DescribeAuditContentItemResponse.DescribeAuditContentItem_AuditContentItem();
				auditContentItem.ParentTaskId = context.StringValue("DescribeAuditContentItem.AuditContentItemList["+ i +"].ParentTaskId");
				auditContentItem.Content = context.StringValue("DescribeAuditContentItem.AuditContentItemList["+ i +"].Content");
				auditContentItem.Sn = context.IntegerValue("DescribeAuditContentItem.AuditContentItemList["+ i +"].Sn");
				auditContentItem.StartTime = context.StringValue("DescribeAuditContentItem.AuditContentItemList["+ i +"].StartTime");
				auditContentItem.EndTime = context.StringValue("DescribeAuditContentItem.AuditContentItemList["+ i +"].EndTime");
				auditContentItem.Audit = context.IntegerValue("DescribeAuditContentItem.AuditContentItemList["+ i +"].Audit");
				auditContentItem.AuditResult = context.StringValue("DescribeAuditContentItem.AuditContentItemList["+ i +"].AuditResult");
				auditContentItem.Suggestion = context.StringValue("DescribeAuditContentItem.AuditContentItemList["+ i +"].Suggestion");
				auditContentItem.Id = context.LongValue("DescribeAuditContentItem.AuditContentItemList["+ i +"].Id");

				List<string> auditContentItem_auditIllegalReasons = new List<string>();
				for (int j = 0; j < context.Length("DescribeAuditContentItem.AuditContentItemList["+ i +"].AuditIllegalReasons.Length"); j++) {
					auditContentItem_auditIllegalReasons.Add(context.StringValue("DescribeAuditContentItem.AuditContentItemList["+ i +"].AuditIllegalReasons["+ j +"]"));
				}
				auditContentItem.AuditIllegalReasons = auditContentItem_auditIllegalReasons;

				describeAuditContentItemResponse_auditContentItemList.Add(auditContentItem);
			}
			describeAuditContentItemResponse.AuditContentItemList = describeAuditContentItemResponse_auditContentItemList;
        
			return describeAuditContentItemResponse;
        }
    }
}

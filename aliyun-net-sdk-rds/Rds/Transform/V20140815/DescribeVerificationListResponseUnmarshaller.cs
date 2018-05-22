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
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeVerificationListResponseUnmarshaller
    {
        public static DescribeVerificationListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVerificationListResponse describeVerificationListResponse = new DescribeVerificationListResponse();

			describeVerificationListResponse.HttpResponse = context.HttpResponse;
			describeVerificationListResponse.RequestId = context.StringValue("DescribeVerificationList.RequestId");
			describeVerificationListResponse.ReplicaId = context.StringValue("DescribeVerificationList.ReplicaId");
			describeVerificationListResponse.PagNumber = context.IntegerValue("DescribeVerificationList.PagNumber");
			describeVerificationListResponse.PageRecordCount = context.IntegerValue("DescribeVerificationList.PageRecordCount");
			describeVerificationListResponse.TotalRecordCount = context.IntegerValue("DescribeVerificationList.TotalRecordCount");

			List<DescribeVerificationListResponse.DescribeVerificationList_ItemsItem> describeVerificationListResponse_items = new List<DescribeVerificationListResponse.DescribeVerificationList_ItemsItem>();
			for (int i = 0; i < context.Length("DescribeVerificationList.Items.Length"); i++) {
				DescribeVerificationListResponse.DescribeVerificationList_ItemsItem itemsItem = new DescribeVerificationListResponse.DescribeVerificationList_ItemsItem();
				itemsItem.InstanceIdA = context.StringValue("DescribeVerificationList.Items["+ i +"].InstanceIdA");
				itemsItem.InstanceIdB = context.StringValue("DescribeVerificationList.Items["+ i +"].InstanceIdB");
				itemsItem.Key = context.StringValue("DescribeVerificationList.Items["+ i +"].Key");
				itemsItem.KeyType = context.StringValue("DescribeVerificationList.Items["+ i +"].KeyType");
				itemsItem.InconsistentType = context.StringValue("DescribeVerificationList.Items["+ i +"].InconsistentType");
				itemsItem.OccurTime = context.StringValue("DescribeVerificationList.Items["+ i +"].OccurTime");
				itemsItem.Schema = context.StringValue("DescribeVerificationList.Items["+ i +"].Schema");
				itemsItem.InconsistentFields = context.StringValue("DescribeVerificationList.Items["+ i +"].InconsistentFields");

				describeVerificationListResponse_items.Add(itemsItem);
			}
			describeVerificationListResponse.Items = describeVerificationListResponse_items;
        
			return describeVerificationListResponse;
        }
    }
}
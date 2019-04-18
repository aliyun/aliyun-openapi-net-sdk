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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeStaticVerificationListResponseUnmarshaller
    {
        public static DescribeStaticVerificationListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStaticVerificationListResponse describeStaticVerificationListResponse = new DescribeStaticVerificationListResponse();

			describeStaticVerificationListResponse.HttpResponse = context.HttpResponse;
			describeStaticVerificationListResponse.RequestId = context.StringValue("DescribeStaticVerificationList.RequestId");
			describeStaticVerificationListResponse.ReplicaId = context.StringValue("DescribeStaticVerificationList.ReplicaId");
			describeStaticVerificationListResponse.SourceInstanceId = context.StringValue("DescribeStaticVerificationList.SourceInstanceId");
			describeStaticVerificationListResponse.SourceDBNumber = context.IntegerValue("DescribeStaticVerificationList.SourceDBNumber");
			describeStaticVerificationListResponse.SourceTableNumber = context.IntegerValue("DescribeStaticVerificationList.SourceTableNumber");
			describeStaticVerificationListResponse.SourceCountNumber = context.IntegerValue("DescribeStaticVerificationList.SourceCountNumber");
			describeStaticVerificationListResponse.SourceDBSize = context.IntegerValue("DescribeStaticVerificationList.SourceDBSize");
			describeStaticVerificationListResponse.DestinationInstanceId = context.StringValue("DescribeStaticVerificationList.DestinationInstanceId");
			describeStaticVerificationListResponse.DestinationDBNumber = context.IntegerValue("DescribeStaticVerificationList.DestinationDBNumber");
			describeStaticVerificationListResponse.DestinationTableNumber = context.IntegerValue("DescribeStaticVerificationList.DestinationTableNumber");
			describeStaticVerificationListResponse.DestinationCountNumber = context.IntegerValue("DescribeStaticVerificationList.DestinationCountNumber");
			describeStaticVerificationListResponse.DestinationDBSize = context.IntegerValue("DescribeStaticVerificationList.DestinationDBSize");
			describeStaticVerificationListResponse.ConsistencyPercent = context.StringValue("DescribeStaticVerificationList.ConsistencyPercent");

			List<DescribeStaticVerificationListResponse.DescribeStaticVerificationList_ItemsItem> describeStaticVerificationListResponse_items = new List<DescribeStaticVerificationListResponse.DescribeStaticVerificationList_ItemsItem>();
			for (int i = 0; i < context.Length("DescribeStaticVerificationList.Items.Length"); i++) {
				DescribeStaticVerificationListResponse.DescribeStaticVerificationList_ItemsItem itemsItem = new DescribeStaticVerificationListResponse.DescribeStaticVerificationList_ItemsItem();
				itemsItem.AbnormalType = context.StringValue("DescribeStaticVerificationList.Items["+ i +"].AbnormalType");
				itemsItem.SourceDetail = context.StringValue("DescribeStaticVerificationList.Items["+ i +"].SourceDetail");
				itemsItem.DestinationDetail = context.StringValue("DescribeStaticVerificationList.Items["+ i +"].DestinationDetail");

				describeStaticVerificationListResponse_items.Add(itemsItem);
			}
			describeStaticVerificationListResponse.Items = describeStaticVerificationListResponse_items;
        
			return describeStaticVerificationListResponse;
        }
    }
}

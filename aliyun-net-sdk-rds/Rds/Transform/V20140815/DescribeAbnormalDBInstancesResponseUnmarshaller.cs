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
    public class DescribeAbnormalDBInstancesResponseUnmarshaller
    {
        public static DescribeAbnormalDBInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAbnormalDBInstancesResponse describeAbnormalDBInstancesResponse = new DescribeAbnormalDBInstancesResponse();

			describeAbnormalDBInstancesResponse.HttpResponse = context.HttpResponse;
			describeAbnormalDBInstancesResponse.RequestId = context.StringValue("DescribeAbnormalDBInstances.RequestId");
			describeAbnormalDBInstancesResponse.TotalRecordCount = context.IntegerValue("DescribeAbnormalDBInstances.TotalRecordCount");
			describeAbnormalDBInstancesResponse.PageNumber = context.IntegerValue("DescribeAbnormalDBInstances.PageNumber");
			describeAbnormalDBInstancesResponse.PageRecordCount = context.IntegerValue("DescribeAbnormalDBInstances.PageRecordCount");

			List<DescribeAbnormalDBInstancesResponse.DescribeAbnormalDBInstances_InstanceResult> describeAbnormalDBInstancesResponse_items = new List<DescribeAbnormalDBInstancesResponse.DescribeAbnormalDBInstances_InstanceResult>();
			for (int i = 0; i < context.Length("DescribeAbnormalDBInstances.Items.Length"); i++) {
				DescribeAbnormalDBInstancesResponse.DescribeAbnormalDBInstances_InstanceResult instanceResult = new DescribeAbnormalDBInstancesResponse.DescribeAbnormalDBInstances_InstanceResult();
				instanceResult.DBInstanceDescription = context.StringValue("DescribeAbnormalDBInstances.Items["+ i +"].DBInstanceDescription");
				instanceResult.DBInstanceId = context.StringValue("DescribeAbnormalDBInstances.Items["+ i +"].DBInstanceId");

				List<DescribeAbnormalDBInstancesResponse.DescribeAbnormalDBInstances_InstanceResult.DescribeAbnormalDBInstances_AbnormalItem> instanceResult_abnormalItems = new List<DescribeAbnormalDBInstancesResponse.DescribeAbnormalDBInstances_InstanceResult.DescribeAbnormalDBInstances_AbnormalItem>();
				for (int j = 0; j < context.Length("DescribeAbnormalDBInstances.Items["+ i +"].AbnormalItems.Length"); j++) {
					DescribeAbnormalDBInstancesResponse.DescribeAbnormalDBInstances_InstanceResult.DescribeAbnormalDBInstances_AbnormalItem abnormalItem = new DescribeAbnormalDBInstancesResponse.DescribeAbnormalDBInstances_InstanceResult.DescribeAbnormalDBInstances_AbnormalItem();
					abnormalItem.CheckTime = context.StringValue("DescribeAbnormalDBInstances.Items["+ i +"].AbnormalItems["+ j +"].CheckTime");
					abnormalItem.CheckItem = context.StringValue("DescribeAbnormalDBInstances.Items["+ i +"].AbnormalItems["+ j +"].CheckItem");
					abnormalItem.AbnormalReason = context.StringValue("DescribeAbnormalDBInstances.Items["+ i +"].AbnormalItems["+ j +"].AbnormalReason");
					abnormalItem.AbnormalValue = context.StringValue("DescribeAbnormalDBInstances.Items["+ i +"].AbnormalItems["+ j +"].AbnormalValue");
					abnormalItem.AbnormalDetail = context.StringValue("DescribeAbnormalDBInstances.Items["+ i +"].AbnormalItems["+ j +"].AbnormalDetail");
					abnormalItem.AdviceKey = context.StringValue("DescribeAbnormalDBInstances.Items["+ i +"].AbnormalItems["+ j +"].AdviceKey");

					List<string> abnormalItem_adviseValue = new List<string>();
					for (int k = 0; k < context.Length("DescribeAbnormalDBInstances.Items["+ i +"].AbnormalItems["+ j +"].AdviseValue.Length"); k++) {
						abnormalItem_adviseValue.Add(context.StringValue("DescribeAbnormalDBInstances.Items["+ i +"].AbnormalItems["+ j +"].AdviseValue["+ k +"]"));
					}
					abnormalItem.AdviseValue = abnormalItem_adviseValue;

					instanceResult_abnormalItems.Add(abnormalItem);
				}
				instanceResult.AbnormalItems = instanceResult_abnormalItems;

				describeAbnormalDBInstancesResponse_items.Add(instanceResult);
			}
			describeAbnormalDBInstancesResponse.Items = describeAbnormalDBInstancesResponse_items;
        
			return describeAbnormalDBInstancesResponse;
        }
    }
}